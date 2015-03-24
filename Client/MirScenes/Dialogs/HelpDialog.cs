using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.MirControls;
using Client.MirGraphics;
using Client.MirNetwork;
using Client.MirObjects;
using Client.MirSounds;
using S = ServerPackets;
using C = ClientPackets;

namespace Client.MirScenes.Dialogs
{
    public sealed class HelpDialog : MirImageControl
    {
        public List<HelpPage> Pages = new List<HelpPage>();

        public MirButton CloseButton, NextButton, PreviousButton;
        public MirLabel PageLabel;
        public HelpPage CurrentPage;

        public int CurrentPageNumber = 0;

        public HelpDialog()
        {
            Index = 920;
            Library = Libraries.Prguse;
            Movable = true;
            Sort = true;
            
            Location = new Point((800 - Size.Width) / 2, (600 - Size.Height) / 2);

            MirImageControl TitleLabel = new MirImageControl
            {
                Index = 57,
                Library = Libraries.Title,
                Location = new Point(18, 5),
                Parent = this
            };

            PreviousButton = new MirButton
            {
                Index = 240,
                HoverIndex = 241,
                PressedIndex = 242,
                Library = Libraries.Prguse2,
                Parent = this,
                Size = new Size(16, 16),
                Location = new Point(210, 485),
                Sound = SoundList.ButtonA,
            };
            PreviousButton.Click += (o, e) =>
            {
                if (CurrentPageNumber <= 0)
                    CurrentPageNumber = Pages.Count-1;
                else
                    CurrentPageNumber--;

                DisplayPage(CurrentPageNumber);
            };

            NextButton = new MirButton
            {
                Index = 243,
                HoverIndex = 244,
                PressedIndex = 245,
                Library = Libraries.Prguse2,
                Parent = this,
                Size = new Size(16, 16),
                Location = new Point(310, 485),
                Sound = SoundList.ButtonA,
            };
            NextButton.Click += (o, e) =>
            {
                if (CurrentPageNumber >= Pages.Count - 1)
                    CurrentPageNumber = 0;
                else
                    CurrentPageNumber++;

                DisplayPage(CurrentPageNumber);
            };

            PageLabel = new MirLabel
            {
                Text = "",
                Font = new Font(Settings.FontName, 9F),
                DrawFormat = TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter,
                Parent = this,
                NotControl = true,
                Location = new Point(230, 480),
                Size = new Size(80, 20)
            };

            CloseButton = new MirButton
            {
                HoverIndex = 361,
                Index = 360,
                Location = new Point(509, 3),
                Library = Libraries.Prguse2,
                Parent = this,
                PressedIndex = 362,
                Sound = SoundList.ButtonA,
            };
            CloseButton.Click += (o, e) => Hide();

            LoadImagePages();

            DisplayPage();
        }

        private void LoadImagePages()
        {
            Point location = new Point(12, 35);

            Dictionary<string, string> keybinds = new Dictionary<string, string>();

            List<HelpPage> imagePages = new List<HelpPage> { 
                new HelpPage("단축키정보1", -1, new ShortcutPage1 { Parent = this } ) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("단축키정보2", -1, new ShortcutPage2 { Parent = this } ) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("단축키정보3", -1, new ShortcutPage3 { Parent = this } ) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("레벨별 사냥터 정보", -1, new ShortcutPage4 { Parent = this } ) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("튜토리얼1", 60, null) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("튜토리얼2", 61, null) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("튜토리얼3", 62, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("튜토리얼4", 63, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("튜토리얼5", 64, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("튜토리얼6", 65, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("튜토리얼7", 66, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("영웅 튜토리얼1", 67, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("영웅 튜토리얼2", 68, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("영웅 튜토리얼3", 69, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("영웅 튜토리얼4", 70, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("영웅 튜토리얼5", 71, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("영웅 튜토리얼6", 72, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("문파성장 튜토리얼1", 73, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("문파성장 튜토리얼2", 74, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("문파성장 튜토리얼3", 75, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("영물 튜토리얼1", 76, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("영물 튜토리얼2", 77, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("영물 튜토리얼3", 78, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("우편 시스템1", 79, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("우편 시스템2", 80, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("우편 시스템3", 81, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("각성 시스템1", 82, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("각성 시스템2", 83, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("각성 시스템3", 84, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("각성 시스템4", 85, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("각성 시스템5", 86, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 용맹의전장1", 87, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 용맹의전장2", 88, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 용맹의전장3", 89, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 용맹의전장4", 90, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 용맹의전장5", 91, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 용맹의전장6", 92, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 용맹의전장7", 93, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 용맹의전장8", 94, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 용맹의전장9", 95, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 복수의전장1", 96, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 복수의전장2", 97, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 복수의전장3", 98, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 복수의전장4", 99, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 복수의전장5", 100, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 복수의전장6", 101, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("전장시스템 복수의전장7", 102, null) { Parent = this, Location = location, Visible = false },
            };

            Pages.AddRange(imagePages);
        }


        public void DisplayPage(string pageName)
        {
            if (Pages.Count < 1) return;

            for (int i = 0; i < Pages.Count; i++)
            {
                if (Pages[i].Title.ToLower() != pageName.ToLower()) continue;

                DisplayPage(i);
                break;
            }
        }

        public void DisplayPage(int id = 0)
        {
            if (Pages.Count < 1) return;

            if (id > Pages.Count - 1) id = Pages.Count - 1;
            if (id < 0) id = 0;

            if (CurrentPage != null)
            {
                CurrentPage.Visible = false;
                if (CurrentPage.Page != null) CurrentPage.Page.Visible = false;
            }

            CurrentPage = Pages[id];

            if (CurrentPage == null) return;

            CurrentPage.Visible = true;
            if (CurrentPage.Page != null) CurrentPage.Page.Visible = true;
            CurrentPageNumber = id;

            CurrentPage.PageTitleLabel.Text = id + 1 + ". " + CurrentPage.Title;

            PageLabel.Text = string.Format("{0} / {1}", id + 1, Pages.Count);

            Show();
        }

        public void Show()
        {
            if (Visible) return;
            Visible = true;
        }

        public void Hide()
        {
            if (!Visible) return;
            Visible = false;
        }

        public void Toggle()
        {
            if (!Visible)
                Show();
            else
                Hide();
        }
    }

    public class ShortcutPage1 : ShortcutInfoPage
    {
        public ShortcutPage1()
        {
            Shortcuts = new List<ShortcutInfo>();
            Shortcuts.Add(new ShortcutInfo("Alt + Q", "게임 종료"));
            Shortcuts.Add(new ShortcutInfo("Alt + X", "로그 아웃"));
            Shortcuts.Add(new ShortcutInfo("F9 , I", "인벤토리 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("F10 , C", "캐릭터 상태 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("F11 , S", "무공 상태 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("F1 ~ F8", "무공 단축키"));
            Shortcuts.Add(new ShortcutInfo("W", "친구등록 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("P", "그룹 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("T", "교환 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("V", "미니맵 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("G", "문파 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("Y", "유료 아이템 상점 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("K", "대여창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("M", "메시지 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("L", "교제 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("Z", "벨트 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("O", "OPTION 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("H", "도움말 창 열기 / 닫기"));
            

            LoadKeyBinds();
        }
    }
    public class ShortcutPage2 : ShortcutInfoPage
    {
        public ShortcutPage2()
        {
            Shortcuts = new List<ShortcutInfo>();
            Shortcuts.Add(new ShortcutInfo("Ctrl + A", "소환몹, 테이밍몹의 상태[휴식 / 공격]를 조종하는 키"));
            Shortcuts.Add(new ShortcutInfo("Ctrl + F", "채팅창에 뜨는 문자의 폰트를 변경시키는 키"));
            Shortcuts.Add(new ShortcutInfo("Ctrl + H", "공격모드 전환키"));
            Shortcuts.Add(new ShortcutInfo("", "[평화공격] - 몬스터만 공격"));
            Shortcuts.Add(new ShortcutInfo("", "[문파공격] - 같은 문파의 문원을 제외한 모든 대상 공격"));
            Shortcuts.Add(new ShortcutInfo("", "[모두공격] - 모든 대상을 공격"));
            Shortcuts.Add(new ShortcutInfo("", "[그룹공격] - 같은 그룹의 그룹원을 제외한 모든 대상 공격"));
            Shortcuts.Add(new ShortcutInfo("", "[선악공격] - PK 유저와 몬스터만 공격"));
            Shortcuts.Add(new ShortcutInfo("B", "필드 맵 보기"));
            Shortcuts.Add(new ShortcutInfo("~`", "무공바 체인지"));
            Shortcuts.Add(new ShortcutInfo("R", "무공바 단축키 창 보기"));
            Shortcuts.Add(new ShortcutInfo("D", "자동 달리기 켜기 / 끄기"));
            Shortcuts.Add(new ShortcutInfo("U", "월령의 그리기 방식 변경"));
            Shortcuts.Add(new ShortcutInfo("Tab", "아이템 줍기"));
            Shortcuts.Add(new ShortcutInfo("Ctrl + 마우스우클릭", "상대방 정보 보기"));
            Shortcuts.Add(new ShortcutInfo("F11", "채팅 매크로 보기"));
            Shortcuts.Add(new ShortcutInfo("F12", "키 설정창 보기"));
            Shortcuts.Add(new ShortcutInfo("N", "낚시 창 열기 / 닫기"));

            LoadKeyBinds();
        }
    }
    public class ShortcutPage3 : ShortcutInfoPage
    {
        public ShortcutPage3()
        {
            Shortcuts = new List<ShortcutInfo>();
            Shortcuts.Add(new ShortcutInfo("/캐릭터", "해당 캐릭터 사용자에게 귓속말 가능"));
            Shortcuts.Add(new ShortcutInfo("!말하기", "외치기가 가능하다"));
            Shortcuts.Add(new ShortcutInfo("!~말하기", "문파원에게만 말하기가 가능하다"));
            Shortcuts.Add(new ShortcutInfo("@귀엣말거부", "자신에게 오는 귓말을 차단 / 해제 가능"));
            Shortcuts.Add(new ShortcutInfo("@차단 캐릭터", "해당 캐릭터에게서 오는 귓속말을 차단 / 해제 가능"));
            Shortcuts.Add(new ShortcutInfo("@문파전음차단", "문파전음을 차단 / 해제 가능"));
            Shortcuts.Add(new ShortcutInfo("방향키", "지나간 부분의 대화 보기가 가능"));
            Shortcuts.Add(new ShortcutInfo(",", "연인 귓속말"));
            Shortcuts.Add(new ShortcutInfo("\\", "사제 채팅"));
            Shortcuts.Add(new ShortcutInfo("E", "영물 창 열기 / 닫기"));
            Shortcuts.Add(new ShortcutInfo("A", "영물 아이템 줍기"));
            Shortcuts.Add(new ShortcutInfo("X+마우스클릭", "영물 아이템 줍기"));
            Shortcuts.Add(new ShortcutInfo("Pause", "화면 저장"));
            Shortcuts.Add(new ShortcutInfo("@놀이거부", "가위바위보 하나빼기 놀이 거부 / 허용 기능"));
            LoadKeyBinds();
        }
    }

    public class ShortcutPage4 : ShortcutInfoPage
    {
        public ShortcutPage4()
        {
            Shortcuts = new List<ShortcutInfo>();
            Shortcuts.Add(new ShortcutInfo("Lv 1~10", "비천현, 우면숲, 몽촌토성, 도관, 기륭성 필드지역"));
            Shortcuts.Add(new ShortcutInfo("Lv 11~20", "뱀의 계곡 필드지역, 오마동굴, 자연동굴, 비천폐광, 우면숲, 벌레동굴"));
            Shortcuts.Add(new ShortcutInfo("Lv 21~30", "절명곡, 우마신전, 미석광산, 석각묘, 환목림"));
            Shortcuts.Add(new ShortcutInfo("Lv 31~40", "반야 필드지역, 반야석굴, 반야동굴, 반야신전, 적월곡"));
            Shortcuts.Add(new ShortcutInfo("Lv 41~50", "주마신전, 과거비천 지역"));

            LoadKeyBinds();
        }
    }

    public class ShortcutInfo
    {
        public string Shortcut { get; set; }
        public string Information { get; set; }

        public ShortcutInfo(string shortcut, string info)
        {
            Shortcut = shortcut;
            Information = info;
        }
    }

    public class ShortcutInfoPage : MirControl
    {
        protected List<ShortcutInfo> Shortcuts = new List<ShortcutInfo>();

        public ShortcutInfoPage()
        {
            Visible = false;

            MirLabel shortcutTitleLabel = new MirLabel
            {
                Text = "단축키",
                DrawFormat = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                ForeColour = Color.White,
                Font = new Font(Settings.FontName, 10F),
                Parent = this,
                AutoSize = true,
                Location = new Point(13, 75),
                Size = new Size(100, 30)
            };

            MirLabel infoTitleLabel = new MirLabel
            {
                Text = "정보",
                DrawFormat = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                ForeColour = Color.White,
                Font = new Font(Settings.FontName, 10F),
                Parent = this,
                AutoSize = true,
                Location = new Point(114, 75),
                Size = new Size(405, 30)
            };
        }

        public void LoadKeyBinds()
        {
            if (Shortcuts == null) return;

            for (int i = 0; i < Shortcuts.Count; i++)
            {
                MirLabel shortcutLabel = new MirLabel
                {
                    Text = Shortcuts[i].Shortcut,
                    ForeColour = Color.Yellow,
                    DrawFormat = TextFormatFlags.VerticalCenter,
                    Font = new Font(Settings.FontName, 9F),
                    Parent = this,
                    AutoSize = true,
                    Location = new Point(18, 107 + (20 * i)),
                    Size = new Size(95, 23),
                };

                MirLabel informationLabel = new MirLabel
                {
                    Text = Shortcuts[i].Information,
                    DrawFormat = TextFormatFlags.VerticalCenter,
                    ForeColour = Color.White,
                    Font = new Font(Settings.FontName, 9F),
                    Parent = this,
                    AutoSize = true,
                    Location = new Point(119, 107 + (20 * i)),
                    Size = new Size(400, 23),
                };
            }  
        }
    }

    public class HelpPage : MirControl
    {
        public string Title;
        public int ImageID;
        public MirControl Page;

        public MirLabel PageTitleLabel;

        public HelpPage(string title, int imageID, MirControl page)
        {
            Title = title;
            ImageID = imageID;
            Page = page;

            NotControl = true;
            Size = new System.Drawing.Size(508, 396 + 40);

            BeforeDraw += HelpPage_BeforeDraw;

            PageTitleLabel = new MirLabel
            {
                Text = Title,
                Font = new Font(Settings.FontName, 10F, FontStyle.Bold),
                DrawFormat = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                Parent = this,
                Size = new System.Drawing.Size(242, 30),
                Location = new Point(135, 4)
            };
        }

        void HelpPage_BeforeDraw(object sender, EventArgs e)
        {
            if (ImageID < 0) return;

            Libraries.Title.Draw(ImageID, new Point(DisplayLocation.X, DisplayLocation.Y + 40), Color.White, false);
        }
    }
}
