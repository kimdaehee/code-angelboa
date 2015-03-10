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
                    CurrentPageNumber = this.Pages.Count - 1;
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
            Point point = new Point(12, 35);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            List<HelpPage> list1 = new List<HelpPage>();
            List<HelpPage> list2 = list1;
            string title1 = "단축키정보1";
            int imageID1 = -1;
            ShortcutPage1 shortcutPage1_1 = new ShortcutPage1();
            shortcutPage1_1.Parent = (MirControl)this;
            ShortcutPage1 shortcutPage1_2 = shortcutPage1_1;
            HelpPage helpPage1 = new HelpPage(title1, imageID1, (MirControl)shortcutPage1_2);
            helpPage1.Parent = (MirControl)this;
            helpPage1.Location = point;
            helpPage1.Visible = false;
            HelpPage helpPage2 = helpPage1;
            list2.Add(helpPage2);
            List<HelpPage> list3 = list1;
            string title2 = "단축키정보2";
            int imageID2 = -1;
            ShortcutPage2 shortcutPage2_1 = new ShortcutPage2();
            shortcutPage2_1.Parent = (MirControl)this;
            ShortcutPage2 shortcutPage2_2 = shortcutPage2_1;
            HelpPage helpPage3 = new HelpPage(title2, imageID2, (MirControl)shortcutPage2_2);
            helpPage3.Parent = (MirControl)this;
            helpPage3.Location = point;
            helpPage3.Visible = false;
            HelpPage helpPage4 = helpPage3;
            list3.Add(helpPage4);
            List<HelpPage> list4 = list1;
            string title3 = "단축키정보3";
            int imageID3 = -1;
            ShortcutPage3 shortcutPage3_1 = new ShortcutPage3();
            shortcutPage3_1.Parent = (MirControl)this;
            ShortcutPage3 shortcutPage3_2 = shortcutPage3_1;
            HelpPage helpPage5 = new HelpPage(title3, imageID3, (MirControl)shortcutPage3_2);
            helpPage5.Parent = (MirControl)this;
            helpPage5.Location = point;
            helpPage5.Visible = false;
            HelpPage helpPage6 = helpPage5;
            list4.Add(helpPage6);
            List<HelpPage> list5 = list1;
            string title4 = "레벨별 사냥터 정보";
            int imageID4 = -1;
            ShortcutPage4 shortcutPage4_1 = new ShortcutPage4();
            shortcutPage4_1.Parent = (MirControl)this;
            ShortcutPage4 shortcutPage4_2 = shortcutPage4_1;
            HelpPage helpPage7 = new HelpPage(title4, imageID4, (MirControl)shortcutPage4_2);
            helpPage7.Parent = (MirControl)this;
            helpPage7.Location = point;
            helpPage7.Visible = false;
            HelpPage helpPage8 = helpPage7;
            list5.Add(helpPage8);
            List<HelpPage> list6 = list1;
            HelpPage helpPage9 = new HelpPage("튜토리얼1", 60, (MirControl)null);
            helpPage9.Parent = (MirControl)this;
            helpPage9.Location = point;
            helpPage9.Visible = false;
            HelpPage helpPage10 = helpPage9;
            list6.Add(helpPage10);
            List<HelpPage> list7 = list1;
            HelpPage helpPage11 = new HelpPage("튜토리얼2", 61, (MirControl)null);
            helpPage11.Parent = (MirControl)this;
            helpPage11.Location = point;
            helpPage11.Visible = false;
            HelpPage helpPage12 = helpPage11;
            list7.Add(helpPage12);
            List<HelpPage> list8 = list1;
            HelpPage helpPage13 = new HelpPage("튜토리얼3", 62, (MirControl)null);
            helpPage13.Parent = (MirControl)this;
            helpPage13.Location = point;
            helpPage13.Visible = false;
            HelpPage helpPage14 = helpPage13;
            list8.Add(helpPage14);
            List<HelpPage> list9 = list1;
            HelpPage helpPage15 = new HelpPage("튜토리얼4", 63, (MirControl)null);
            helpPage15.Parent = (MirControl)this;
            helpPage15.Location = point;
            helpPage15.Visible = false;
            HelpPage helpPage16 = helpPage15;
            list9.Add(helpPage16);
            List<HelpPage> list10 = list1;
            HelpPage helpPage17 = new HelpPage("튜토리얼5", 64, (MirControl)null);
            helpPage17.Parent = (MirControl)this;
            helpPage17.Location = point;
            helpPage17.Visible = false;
            HelpPage helpPage18 = helpPage17;
            list10.Add(helpPage18);
            List<HelpPage> list11 = list1;
            HelpPage helpPage19 = new HelpPage("튜토리얼6", 65, (MirControl)null);
            helpPage19.Parent = (MirControl)this;
            helpPage19.Location = point;
            helpPage19.Visible = false;
            HelpPage helpPage20 = helpPage19;
            list11.Add(helpPage20);
            List<HelpPage> list12 = list1;
            HelpPage helpPage21 = new HelpPage("튜토리얼7", 66, (MirControl)null);
            helpPage21.Parent = (MirControl)this;
            helpPage21.Location = point;
            helpPage21.Visible = false;
            HelpPage helpPage22 = helpPage21;
            list12.Add(helpPage22);
            List<HelpPage> list13 = list1;
            HelpPage helpPage23 = new HelpPage("영웅 튜토리얼1", 67, (MirControl)null);
            helpPage23.Parent = (MirControl)this;
            helpPage23.Location = point;
            helpPage23.Visible = false;
            HelpPage helpPage24 = helpPage23;
            list13.Add(helpPage24);
            List<HelpPage> list14 = list1;
            HelpPage helpPage25 = new HelpPage("영웅 튜토리얼2", 68, (MirControl)null);
            helpPage25.Parent = (MirControl)this;
            helpPage25.Location = point;
            helpPage25.Visible = false;
            HelpPage helpPage26 = helpPage25;
            list14.Add(helpPage26);
            List<HelpPage> list15 = list1;
            HelpPage helpPage27 = new HelpPage("영웅 튜토리얼3", 69, (MirControl)null);
            helpPage27.Parent = (MirControl)this;
            helpPage27.Location = point;
            helpPage27.Visible = false;
            HelpPage helpPage28 = helpPage27;
            list15.Add(helpPage28);
            List<HelpPage> list16 = list1;
            HelpPage helpPage29 = new HelpPage("영웅 튜토리얼4", 70, (MirControl)null);
            helpPage29.Parent = (MirControl)this;
            helpPage29.Location = point;
            helpPage29.Visible = false;
            HelpPage helpPage30 = helpPage29;
            list16.Add(helpPage30);
            List<HelpPage> list17 = list1;
            HelpPage helpPage31 = new HelpPage("영웅 튜토리얼5", 71, (MirControl)null);
            helpPage31.Parent = (MirControl)this;
            helpPage31.Location = point;
            helpPage31.Visible = false;
            HelpPage helpPage32 = helpPage31;
            list17.Add(helpPage32);
            List<HelpPage> list18 = list1;
            HelpPage helpPage33 = new HelpPage("영웅 튜토리얼6", 72, (MirControl)null);
            helpPage33.Parent = (MirControl)this;
            helpPage33.Location = point;
            helpPage33.Visible = false;
            HelpPage helpPage34 = helpPage33;
            list18.Add(helpPage34);
            List<HelpPage> list19 = list1;
            HelpPage helpPage35 = new HelpPage("문파성장 튜토리얼1", 73, (MirControl)null);
            helpPage35.Parent = (MirControl)this;
            helpPage35.Location = point;
            helpPage35.Visible = false;
            HelpPage helpPage36 = helpPage35;
            list19.Add(helpPage36);
            List<HelpPage> list20 = list1;
            HelpPage helpPage37 = new HelpPage("문파성장 튜토리얼2", 74, (MirControl)null);
            helpPage37.Parent = (MirControl)this;
            helpPage37.Location = point;
            helpPage37.Visible = false;
            HelpPage helpPage38 = helpPage37;
            list20.Add(helpPage38);
            List<HelpPage> list21 = list1;
            HelpPage helpPage39 = new HelpPage("문파성장 튜토리얼3", 75, (MirControl)null);
            helpPage39.Parent = (MirControl)this;
            helpPage39.Location = point;
            helpPage39.Visible = false;
            HelpPage helpPage40 = helpPage39;
            list21.Add(helpPage40);
            List<HelpPage> list22 = list1;
            HelpPage helpPage41 = new HelpPage("영물 튜토리얼1", 76, (MirControl)null);
            helpPage41.Parent = (MirControl)this;
            helpPage41.Location = point;
            helpPage41.Visible = false;
            HelpPage helpPage42 = helpPage41;
            list22.Add(helpPage42);
            List<HelpPage> list23 = list1;
            HelpPage helpPage43 = new HelpPage("영물 튜토리얼2", 77, (MirControl)null);
            helpPage43.Parent = (MirControl)this;
            helpPage43.Location = point;
            helpPage43.Visible = false;
            HelpPage helpPage44 = helpPage43;
            list23.Add(helpPage44);
            List<HelpPage> list24 = list1;
            HelpPage helpPage45 = new HelpPage("영물 튜토리얼3", 78, (MirControl)null);
            helpPage45.Parent = (MirControl)this;
            helpPage45.Location = point;
            helpPage45.Visible = false;
            HelpPage helpPage46 = helpPage45;
            list24.Add(helpPage46);
            List<HelpPage> list25 = list1;
            HelpPage helpPage47 = new HelpPage("우편 시스템1", 79, (MirControl)null);
            helpPage47.Parent = (MirControl)this;
            helpPage47.Location = point;
            helpPage47.Visible = false;
            HelpPage helpPage48 = helpPage47;
            list25.Add(helpPage48);
            List<HelpPage> list26 = list1;
            HelpPage helpPage49 = new HelpPage("우편 시스템2", 80, (MirControl)null);
            helpPage49.Parent = (MirControl)this;
            helpPage49.Location = point;
            helpPage49.Visible = false;
            HelpPage helpPage50 = helpPage49;
            list26.Add(helpPage50);
            List<HelpPage> list27 = list1;
            HelpPage helpPage51 = new HelpPage("우편 시스템3", 81, (MirControl)null);
            helpPage51.Parent = (MirControl)this;
            helpPage51.Location = point;
            helpPage51.Visible = false;
            HelpPage helpPage52 = helpPage51;
            list27.Add(helpPage52);
            List<HelpPage> list28 = list1;
            HelpPage helpPage53 = new HelpPage("각성 시스템1", 82, (MirControl)null);
            helpPage53.Parent = (MirControl)this;
            helpPage53.Location = point;
            helpPage53.Visible = false;
            HelpPage helpPage54 = helpPage53;
            list28.Add(helpPage54);
            List<HelpPage> list29 = list1;
            HelpPage helpPage55 = new HelpPage("각성 시스템2", 83, (MirControl)null);
            helpPage55.Parent = (MirControl)this;
            helpPage55.Location = point;
            helpPage55.Visible = false;
            HelpPage helpPage56 = helpPage55;
            list29.Add(helpPage56);
            List<HelpPage> list30 = list1;
            HelpPage helpPage57 = new HelpPage("각성 시스템3", 84, (MirControl)null);
            helpPage57.Parent = (MirControl)this;
            helpPage57.Location = point;
            helpPage57.Visible = false;
            HelpPage helpPage58 = helpPage57;
            list30.Add(helpPage58);
            List<HelpPage> list31 = list1;
            HelpPage helpPage59 = new HelpPage("각성 시스템4", 85, (MirControl)null);
            helpPage59.Parent = (MirControl)this;
            helpPage59.Location = point;
            helpPage59.Visible = false;
            HelpPage helpPage60 = helpPage59;
            list31.Add(helpPage60);
            List<HelpPage> list32 = list1;
            HelpPage helpPage61 = new HelpPage("각성 시스템5", 86, (MirControl)null);
            helpPage61.Parent = (MirControl)this;
            helpPage61.Location = point;
            helpPage61.Visible = false;
            HelpPage helpPage62 = helpPage61;
            list32.Add(helpPage62);
            List<HelpPage> list33 = list1;
            HelpPage helpPage63 = new HelpPage("전장시스템 용맹의전장1", 87, (MirControl)null);
            helpPage63.Parent = (MirControl)this;
            helpPage63.Location = point;
            helpPage63.Visible = false;
            HelpPage helpPage64 = helpPage63;
            list33.Add(helpPage64);
            List<HelpPage> list34 = list1;
            HelpPage helpPage65 = new HelpPage("전장시스템 용맹의전장2", 88, (MirControl)null);
            helpPage65.Parent = (MirControl)this;
            helpPage65.Location = point;
            helpPage65.Visible = false;
            HelpPage helpPage66 = helpPage65;
            list34.Add(helpPage66);
            List<HelpPage> list35 = list1;
            HelpPage helpPage67 = new HelpPage("전장시스템 용맹의전장3", 89, (MirControl)null);
            helpPage67.Parent = (MirControl)this;
            helpPage67.Location = point;
            helpPage67.Visible = false;
            HelpPage helpPage68 = helpPage67;
            list35.Add(helpPage68);
            List<HelpPage> list36 = list1;
            HelpPage helpPage69 = new HelpPage("전장시스템 용맹의전장4", 90, (MirControl)null);
            helpPage69.Parent = (MirControl)this;
            helpPage69.Location = point;
            helpPage69.Visible = false;
            HelpPage helpPage70 = helpPage69;
            list36.Add(helpPage70);
            List<HelpPage> list37 = list1;
            HelpPage helpPage71 = new HelpPage("전장시스템 용맹의전장5", 91, (MirControl)null);
            helpPage71.Parent = (MirControl)this;
            helpPage71.Location = point;
            helpPage71.Visible = false;
            HelpPage helpPage72 = helpPage71;
            list37.Add(helpPage72);
            List<HelpPage> list38 = list1;
            HelpPage helpPage73 = new HelpPage("전장시스템 용맹의전장6", 92, (MirControl)null);
            helpPage73.Parent = (MirControl)this;
            helpPage73.Location = point;
            helpPage73.Visible = false;
            HelpPage helpPage74 = helpPage73;
            list38.Add(helpPage74);
            List<HelpPage> list39 = list1;
            HelpPage helpPage75 = new HelpPage("전장시스템 용맹의전장7", 93, (MirControl)null);
            helpPage75.Parent = (MirControl)this;
            helpPage75.Location = point;
            helpPage75.Visible = false;
            HelpPage helpPage76 = helpPage75;
            list39.Add(helpPage76);
            List<HelpPage> list40 = list1;
            HelpPage helpPage77 = new HelpPage("전장시스템 용맹의전장8", 94, (MirControl)null);
            helpPage77.Parent = (MirControl)this;
            helpPage77.Location = point;
            helpPage77.Visible = false;
            HelpPage helpPage78 = helpPage77;
            list40.Add(helpPage78);
            List<HelpPage> list41 = list1;
            HelpPage helpPage79 = new HelpPage("전장시스템 용맹의전장9", 95, (MirControl)null);
            helpPage79.Parent = (MirControl)this;
            helpPage79.Location = point;
            helpPage79.Visible = false;
            HelpPage helpPage80 = helpPage79;
            list41.Add(helpPage80);
            List<HelpPage> list42 = list1;
            HelpPage helpPage81 = new HelpPage("전장시스템 복수의전장1", 96, (MirControl)null);
            helpPage81.Parent = (MirControl)this;
            helpPage81.Location = point;
            helpPage81.Visible = false;
            HelpPage helpPage82 = helpPage81;
            list42.Add(helpPage82);
            List<HelpPage> list43 = list1;
            HelpPage helpPage83 = new HelpPage("전장시스템 복수의전장2", 97, (MirControl)null);
            helpPage83.Parent = (MirControl)this;
            helpPage83.Location = point;
            helpPage83.Visible = false;
            HelpPage helpPage84 = helpPage83;
            list43.Add(helpPage84);
            List<HelpPage> list44 = list1;
            HelpPage helpPage85 = new HelpPage("전장시스템 복수의전장3", 98, (MirControl)null);
            helpPage85.Parent = (MirControl)this;
            helpPage85.Location = point;
            helpPage85.Visible = false;
            HelpPage helpPage86 = helpPage85;
            list44.Add(helpPage86);
            List<HelpPage> list45 = list1;
            HelpPage helpPage87 = new HelpPage("전장시스템 복수의전장4", 99, (MirControl)null);
            helpPage87.Parent = (MirControl)this;
            helpPage87.Location = point;
            helpPage87.Visible = false;
            HelpPage helpPage88 = helpPage87;
            list45.Add(helpPage88);
            List<HelpPage> list46 = list1;
            HelpPage helpPage89 = new HelpPage("전장시스템 복수의전장5", 100, (MirControl)null);
            helpPage89.Parent = (MirControl)this;
            helpPage89.Location = point;
            helpPage89.Visible = false;
            HelpPage helpPage90 = helpPage89;
            list46.Add(helpPage90);
            List<HelpPage> list47 = list1;
            HelpPage helpPage91 = new HelpPage("전장시스템 복수의전장6", 101, (MirControl)null);
            helpPage91.Parent = (MirControl)this;
            helpPage91.Location = point;
            helpPage91.Visible = false;
            HelpPage helpPage92 = helpPage91;
            list47.Add(helpPage92);
            List<HelpPage> list48 = list1;
            HelpPage helpPage93 = new HelpPage("전장시스템 복수의전장7", 102, (MirControl)null);
            helpPage93.Parent = (MirControl)this;
            helpPage93.Location = point;
            helpPage93.Visible = false;
            HelpPage helpPage94 = helpPage93;
            list48.Add(helpPage94);
            this.Pages.AddRange((IEnumerable<HelpPage>)list1);
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
            this.Shortcuts = new List<ShortcutInfo>();
            this.Shortcuts.Add(new ShortcutInfo("Alt + Q", "게임 종료"));
            this.Shortcuts.Add(new ShortcutInfo("Alt + X", "로그 아웃"));
            this.Shortcuts.Add(new ShortcutInfo("F9 , I", "인벤토리 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("F10 , C", "캐릭터 상태 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("F11 , S", "무공 상태 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("F1 ~ F8", "무공 단축키"));
            this.Shortcuts.Add(new ShortcutInfo("W", "친구등록 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("P", "그룹 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("T", "교환 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("V", "미니맵 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("G", "문파 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("Y", "유료 아이템 상점 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("K", "대여창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("M", "메시지 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("L", "교제 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("Z", "벨트 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("O", "OPTION 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("H", "도움말 창 열기 / 닫기"));

            LoadKeyBinds();
        }
    }
    public class ShortcutPage2 : ShortcutInfoPage
    {
        public ShortcutPage2()
        {
            this.Shortcuts = new List<ShortcutInfo>();
            this.Shortcuts.Add(new ShortcutInfo("Ctrl + A", "소환몹, 테이밍몹의 상태[휴식 / 공격]를 조종하는 키"));
            this.Shortcuts.Add(new ShortcutInfo("Ctrl + F", "채팅창에 뜨는 문자의 폰트를 변경시키는 키"));
            this.Shortcuts.Add(new ShortcutInfo("Ctrl + H", "공격모드 전환키"));
            this.Shortcuts.Add(new ShortcutInfo("", "[평화공격] - 몬스터만 공격"));
            this.Shortcuts.Add(new ShortcutInfo("", "[문파공격] - 같은 문파의 문원을 제외한 모든 대상 공격"));
            this.Shortcuts.Add(new ShortcutInfo("", "[모두공격] - 모든 대상을 공격"));
            this.Shortcuts.Add(new ShortcutInfo("", "[그룹공격] - 같은 그룹의 그룹원을 제외한 모든 대상 공격"));
            this.Shortcuts.Add(new ShortcutInfo("", "[선악공격] - PK 유저와 몬스터만 공격"));
            this.Shortcuts.Add(new ShortcutInfo("B", "필드 맵 보기"));
            this.Shortcuts.Add(new ShortcutInfo("~`", "무공바 체인지"));
            this.Shortcuts.Add(new ShortcutInfo("R", "무공바 단축키 창 보기"));
            this.Shortcuts.Add(new ShortcutInfo("D", "자동 달리기 켜기 / 끄기"));
            this.Shortcuts.Add(new ShortcutInfo("U", "월령의 그리기 방식 변경"));
            this.Shortcuts.Add(new ShortcutInfo("Tab", "아이템 줍기"));
            this.Shortcuts.Add(new ShortcutInfo("Ctrl + 마우스우클릭", "상대방 정보 보기"));
            this.Shortcuts.Add(new ShortcutInfo("F11", "채팅 매크로 보기"));
            this.Shortcuts.Add(new ShortcutInfo("F12", "키 설정창 보기"));
            this.Shortcuts.Add(new ShortcutInfo("N", "낚시 창 열기 / 닫기"));

            LoadKeyBinds();
        }
    }
    public class ShortcutPage3 : ShortcutInfoPage
    {
        public ShortcutPage3()
        {
            this.Shortcuts = new List<ShortcutInfo>();
            this.Shortcuts.Add(new ShortcutInfo("/캐릭터", "해당 캐릭터 사용자에게 귓속말 가능"));
            this.Shortcuts.Add(new ShortcutInfo("!말하기", "외치기가 가능하다"));
            this.Shortcuts.Add(new ShortcutInfo("!~말하기", "문파원에게만 말하기가 가능하다"));
            this.Shortcuts.Add(new ShortcutInfo("@귀엣말거부", "자신에게 오는 귓말을 차단 / 해제 가능"));
            this.Shortcuts.Add(new ShortcutInfo("@차단 캐릭터", "해당 캐릭터에게서 오는 귓속말을 차단 / 해제 가능"));
            this.Shortcuts.Add(new ShortcutInfo("@문파전음차단", "문파전음을 차단 / 해제 가능"));
            this.Shortcuts.Add(new ShortcutInfo("방향키", "지나간 부분의 대화 보기가 가능"));
            this.Shortcuts.Add(new ShortcutInfo(",", "연인 귓속말"));
            this.Shortcuts.Add(new ShortcutInfo("\\", "사제 채팅"));
            this.Shortcuts.Add(new ShortcutInfo("E", "영물 창 열기 / 닫기"));
            this.Shortcuts.Add(new ShortcutInfo("A", "영물 아이템 줍기"));
            this.Shortcuts.Add(new ShortcutInfo("X+마우스클릭", "영물 아이템 줍기"));
            this.Shortcuts.Add(new ShortcutInfo("Pause", "화면 저장"));
            this.Shortcuts.Add(new ShortcutInfo("@놀이거부", "가위바위보 하나빼기 놀이 거부 / 허용 기능"));

            LoadKeyBinds();
        }
    }

    public class ShortcutPage4 : ShortcutInfoPage
    {
        public ShortcutPage4()
        {
            this.Shortcuts = new List<ShortcutInfo>();
            this.Shortcuts.Add(new ShortcutInfo("Lv 1~10", "비천현, 우면숲, 몽촌토성, 도관, 기륭성 필드지역"));
            this.Shortcuts.Add(new ShortcutInfo("Lv 11~20", "뱀의 계곡 필드지역, 오마동굴, 자연동굴, 비천폐광, 우면숲, 벌레동굴"));
            this.Shortcuts.Add(new ShortcutInfo("Lv 21~30", "절명곡, 우마신전, 미석광산, 석각묘, 환목림"));
            this.Shortcuts.Add(new ShortcutInfo("Lv 31~40", "반야 필드지역, 반야석굴, 반야동굴, 반야신전, 적월곡"));
            this.Shortcuts.Add(new ShortcutInfo("Lv 41~50", "주마신전, 과거비천 지역"));
            this.LoadKeyBinds();
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
                Text = "정  보",
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

            Libraries.Help.Draw(ImageID, new Point(DisplayLocation.X, DisplayLocation.Y + 40), Color.White, false);
        }
    }
}
