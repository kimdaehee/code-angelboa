using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Global
{
    public enum KorMirClass : byte
    {
        전사 = 0,
        술사 = 1,
        도사 = 2,
        자객 = 3,
        궁수 = 4,
        벽혈전사 = 5,
        홍현술사 = 6,
        익선도사 = 7,
        비연자객 = 8,
        암귀궁수 = 9,
    }

    public enum KorItemGrade : byte
    {
        없음 = 0,
        일반 = 1,
        보물 = 2,
        성물 = 3,
        신물 = 4,
    }

    public enum KorItemType : byte
    {
        일반 = 0,
        무기 = 1,
        갑옷 = 2,
        투구 = 4,
        목걸이 = 5,
        팔찌 = 6,
        반지 = 7,
        부적 = 8,
        허리띠 = 9,
        신발 = 10,
        수호석 = 11,
        횃불 = 12,
        물약 = 13,
        광석 = 14,
        고기 = 15,
        제작재료 = 16,
        주문서 = 17,
        보옥 = 18,
        탈것 = 19,
        무공서 = 20,
        강화서 = 21,
        고삐 = 22,
        방울 = 23,
        안장 = 24,
        리본 = 25,
        가면 = 26,
        음식 = 27,
        낚시줄과바늘 = 28,
        찌 = 29,
        미끼 = 30,
        어군탐지기 = 31,
        릴 = 32,
        물고기 = 33,
        퀘스트 = 34,
        각성 = 35,
    }

    public enum KorRequiredGender : byte
    {
        남 = 1,
        여 = 2,
        모두 = 남 | 여
    }

    public enum KorRequiredType : byte
    {
        레벨 = 0,
        방어 = 1,
        마법방어 = 2,
        파괴 = 3,
        마력 = 4,
        도력 = 5,
    }

    class GlobalText
    {
        public class System
        {
            public static string StartGame = "미르의 전설 2에 오신 것을 환영합니다.";
            public static string LevelUp = "레벨이 올랐습니다.";
            public static string LevelUpEffect = "축하합니다! 레벨이 올랐습니다. HP,MP가 모두 회복되었습니다.";
            public static string GainedExp = "경험치가 {0} 올랐습니다.";
            public static string GainedItem = "{0}를 얻었습니다.";
            public static string GainedGold = "{0:###,###,###}전을 얻었습니다.";
            public static string Exit = "미르의 전설2를 종료하시겠습니까?";
            public static string LogOut = "로그아웃 하시겠습니까?";
            public static string ReviveTown = "당신은 죽었습니다. 마을로 귀환하시겠습니까?";
            public static string NotEnoughMaterials = "재료를 가지고 있지 않습니다.";
            public static string DontHaveGold = "금전이 부족합니다.";
            public static string OverWeight = "You do no have enough weight.";
            public static string DontPurchase = "Cannot purchase any more items.";
            public static string MaxAwakeningLevel = "각성 레벨이 최대치입니다.";
            public static string CantAwaken = "각성을 할 수 없는 아이템입니다.";
            public static string RequestTrade = "{0}님과 거래가 시작되었습니다.";
            public static string CancelTrade = "거래가 취소되었습니다.";
            public static string LoginGuildMember = "{0} 님이 접속했습니다.";
            public static string JoinGuildMember = "{0} 님이 가입했습니다.";
            public static string KickMember = "{0} 님이 추방되었습니다.";
            public static string LeaveMember = "{0} 님이 떠났습니다.";
            public static string CreateGuild = "설립할 문파의 이름을 적으십시오.";
            public static string CantUseGuildName = "사용할 수 없는 문파명입니다.";
            public static string CantDrop = "You cannot drop {0}";
            //public static string CantDrop = "정말로 아이템을 버리겠습니까?";
            //public static string WantDrop = "Are you sure you want to drop {0}?";
            public static string WantDrop = "정말로 아이템을 버리겠습니까?";
            public static string MustBeWearingABow = "You must be wearing a bow to perform this skill.";
            public static string MaxGroup = "Your group already has the maximum number of members.";
            public static string NotGroupLeader = "You are not the leader of your group.";
            public static string EnterGroupMember = "Please enter the name of the person you wish to group.";
            public static string CantSell = "Cannot sell this item.";
            public static string CantCarryGold = "Cannot carry anymore gold.";
            public static string CantRepair = "Cannot repair this item.";
            public static string CantStore = "Cannot store this item.";
            public static string PurchaseAmount = "Purchase Amount:";
            public static string DropAmount = "몇개를 버리시겠습니까?";
            public static string DropAmountGold = "돈을 얼마나 버리시겠습니까?";
            public static string TradeAmountGold = "돈을 얼마나 옮기시겠습니까?";
            public static string ConsignmentPrice = "Consignment Price:";
            public static string SellAmount = "Sell Amount:";
            public static string DropPanelSale = "판매: ";
            public static string DropPanelRepair = "수리: ";
            public static string DropPanelSRepair = "특수수리: ";
            public static string SelectAwakeLabel = "각성 능력 선택";
            public static string DropPanelConsignment = "등록: ";
            public static string DropPanelDisassemble = "분해: ";
            public static string DropPanelDowngrade = "각성취소: ";
            public static string DropPanelReset = "복원: ";
            public static string SelectAwakeItem = "선택해 주세요.";
            public static string SelectAwakeUpgradeType = "선택해 주세요.";
            public static string SelectKey = "Select the Key for: {0}";
            public static string DontMount = "You do not own a mount.";
            public static string DontHaveFishingRod = "You are not holding a fishing rod.";
            public static string Poisoned = "중독되었습니다.";
            public static string AutoRunOn = "<자동달리기를 합니다.>";
            public static string AutoRunOff = "<자동달리기를 하지 않습니다.>";
            public static string WeaptonMakeLuck = "당신의 무기에 행운의 기운이 깃들었습니다.";
            public static string WeaptonNotMakeLuck = "당신의 무기에 아무런 효과가 없었습니다.";
            public static string TheWeaponIsCursed = "당신의 무기에 저주가 붙었습니다.";
            public static string HasBeenRepaired = "아이템({0})이(가) 수리되었습니다.";
            public static string HasBeenUpgraded = "{0}에 영롱한 빛이 감돌며 {1}이(가) 상승하였습니다.";
            public static string HasBeenDestroyed = "아이템({0})이(가) 파괴되었습니다.";
            public static string HasNoEffect = "{0}에 아무런 변화도 일어나지 않았습니다.";
            public static string CantUseItem = "사용할 수 없는 아이템입니다.";
            public static string CantUpgradeItem = "더 이상 강화할 수 없습니다.";
            public static string DontNeedToBeRepaired = "더 이상 수리할 수 없습니다.";
            public static string BuyInventory = "가방Ⅱ 구입을 위해 100,0000전을 지불하시겠습니까?\n" +
                                                    "가방Ⅱ 구입시 가방 공간 8칸을 제공하며, 추가 공간 구입을 통해\n" +
                                                    "40칸까지 가방을 확장 할 수 있습니다.";
            public static string AddInventory = "가방Ⅱ의 공간 4칸을 {0:###,###}전을 지불하여 확장하시겠습니까?\n" +
                                                    "가방Ⅱ 추가 공간 구입시 총 {1}칸을 사용 할 수 있습니다.";


        }

        public class Interface
        {
            public static string AttackModePeaceful = "[평화 공격 형태]";
            public static string AttackModeGroup = "[그룹단위 공격 형태]";
            public static string AttackModeGuild = "[문파단위 공격 형태]";
            public static string AttackModeEnemyGuild = "[적대 문파 공격 형태]";
            public static string AttackModeRedBrown = "[선악 대결 공격 형태]";
            public static string AttackModeAll = "[모두 공격 가능]";
            public static string AttackMode_Peaceful = "[평화공격]";
            public static string AttackMode_Group = "[그룹공격]";
            public static string AttackMode_Guild = "[문파공격]";
            public static string AttackMode_EnemyGuild = "[적대문파]";
            public static string AttackMode_RedBrown = "[선악공격]";
            public static string AttackMode_All = "[모두공격]";

            public static string SkillModeCtrl = "<무공바 체인지 2>";            //[Ctrl키 사용]
            public static string SkillModeDot = "<무공바 체인지 1>";             //[~키 사용]

            public static string SkillModeCtrl1 = "[Ctrl키 사용]";
            public static string SkillModeDot1 = "[~키 사용]";

            public static string HpMode1 = "<HP/MP Mode 1>";
            public static string HpMode2 = "<HP/MP Mode 2>";

            public static string PetModeAttack = "[부하의 행동 : 공격]";
            public static string PetModeAttackOnly = "[부하의 행동 : 이동금지]";
            public static string PetModeMoveOnly = "[부하의 행동 : 공격금지]";
            public static string PetModeNone = "[부하의 행동 : 휴식]";

            public static string InventoryButton = "가방창(I)";
            public static string CharacterButton = "캐릭터상태창(C)";
            public static string SkillButton = "무공상태창(S)";
            public static string QuestButton = "퀘스트(Q)";
            public static string OptionButton = "옵션창(O)";
            public static string MenuButton = "메뉴";
            public static string GameShopButton = "밀환상점(Y)";
            public static string SizeButton = "";
            public static string SettingsButton = "";
            public static string ChatNormalButton = "일반 대화\n일반 대화입니다.";
            public static string ChatShoutButton = "외치기\n클릭하면 외치기를 합니다.\n레벨 8부터 사용이 가능합니다.";
            public static string ChatWhisperButton = "귓속말 하기\n'/캐릭터명 귓속말 내용'을 1회 이상 입력하면 귓속말 사용이 가능합니다.\n" +
                                                                       "클릭하면 최대 5명, 최근 보낸 사람 순서로 귓속말 대상 목록을 보여주며,\n" +
                                                                       "로그아웃을 하면 대상 목록은 초기화 됩니다.";
            public static string ChatLoverButton = "연인 대화 하기\n클릭하면 연인 대화를 시작합니다.\n" +
                                                                  "연인이 없을 경우 대화가 되지 않습니다.";
            public static string ChatMentorButton = "사제 대화 하기\n클릭하면 사제 대화를 시작합니다.\n" +
                                                                     "사제관계가 아닐 경우 대화가 되지 않습니다.";
            public static string ChatGroupButton = "그룹 대화 하기\n클릭하면 그룹 대화를 시작합니다.\n" +
                                                                   "그룹에 가입되어 있지 않을 경우 대화가 되지 않습니다.";
            public static string ChatGuildButton = "문파 대화 하기\n클릭하면 문파 대화를 시작합니다.\n" +
                                                                  "문파에 가입되어 있지 않을 경우 대화가 되지 않습니다.";
            public static string ChatFilterAllButton = "모든 대화 버튼 OFF\n클릭하면 모든 대화 버튼을 끕니다.";
            public static string ChatFilterNormalButton = "일반 대화 OFF\n클릭하면 일반 대화 내용을 볼 수 없게 됩니다.";
            public static string ChatFilterWhisperButton = "귓속말 OFF\n클릭하면 귓속말 내용을 볼 수 없게 됩니다.";
            public static string ChatFilterShoutButton = "외치기 OFF\n클릭하면 외치기 내용을 볼 수 없게 됩니다.";
            public static string ChatFilterSystemButton = "시스템 알림 OFF\n클릭하면 시스템 알림 내용을 볼 수 없게 됩니다.";
            public static string ChatFilterLoverButton = "연인 대화 OFF\n클릭하면 연인 대화 내용을 볼 수 없게 됩니다.";
            public static string ChatFilterMentorButton = "사제 대화 OFF\n클릭하면 사제 대화 내용을 볼 수 없게 됩니다.";
            public static string ChatFilterGroupButton = "그룹 대화 OFF\n클릭하면 그룹 대화 내용을 볼 수 없게 됩니다.";
            public static string ChatFilterGuildButton = "문파 대화 OFF\n클릭하면 문파 대화 내용을 볼 수 없게 됩니다.";
            public static string RotateButton = "";
            public static string BeltCloseButton = "벨트창(Z)";
            public static string MailButton = "우편목록(M)";
            public static string BigMapButton = "필드맵(B)";
            public static string MiniMapButton = "미니맵(V)";
            public static string ExitButton = "종료(Alt + Q)";
            public static string LogOutButton = "로그아웃(Alt + X)";
            public static string HelpButton = "도움말(H)";
            public static string PetButton = "영물(E)";
            public static string RideButton = "탈것(J)";
            public static string FishingButton = "낚시(N)";
            public static string FriendButton = "친구창(W)";
            public static string MentorButton = "사제(F)";
            public static string RelationshipButton = "교제창(L)";
            public static string GroupButton = "그룹창(P)";
            public static string GuildButton = "문파창(G)";
            public static string PCDuraPanel = "PC내구도";
            public static string ExpBar = "경험치 {0}/{1}";
            public static string HoldButton = "HOLD상태가되면 올려놓음과 동시에 처리됩니다";
        }

        public class Item
        {
            public static string BraveryGlyph = "용맹의각성";
            public static string MagicGlyph = "마성의각성";
            public static string SoulGlyph = "선계의각성";
            public static string ProtectionGlyph = "수호의각성";
            public static string EvilSlayerGlyph = "제마의각성";
            public static string BodyGlyph = "육체의각성";
        }

        public class Atturibute
        {
            public static string Count = "개수";
            public static string Usage = "사용";
            public static string Purity = "순도";
            public static string Quality = "품질";
            public static string Loyalty = "충성도";
            public static string Nutrition = "탈 것 충성도 회복";
            public static string Durability = "내구";
            public static string Weight = "무게";
            public static string DC = "파괴";
            public static string MC = "마력";
            public static string SC = "도력";
            public static string Luck = "행운";
            public static string Curse = "저주";
            public static string FishingSuccess = "낚시 추가 성공률";
            public static string FishingAutoReelRate = "자동 챔질 성공확률";
            public static string FishingNibbleRate = "입질 확률";
            public static string FishingFailSuccessRate = "실패시 낚시 성공률 상승폭";
            public static string Accuracy = "정확";
            public static string Holy = "신성";
            public static string ASpeed = "공격속도";
            public static string Freezing = "둔화";
            public static string Poison = "중독";
            public static string CriticalRate = "치명타확률";
            public static string Flexibility = "탄성";
            public static string CriticalDamage = "치명타공격력";
            public static string AC = "방어";
            public static string MAC = "마법방어";
            public static string MaxHp = "MAXHP";
            public static string MaxMp = "MAXMP";
            public static string Recovery = "지속회복";
            public static string MaxHpRate = "";
            public static string MaxMpRate = "";
            public static string MaxAcRate = "";
            public static string MaxMacRate = "";
            public static string HealthRecovery = "체력회복";
            public static string ManaRecovery = "마력회복";
            public static string PoisonRecovery = "중독회복";
            public static string Agility = "민첩";
            public static string Strong = "강도";
            public static string PoisonResist = "중독저항";
            public static string MagicResist = "마법저항";
            public static string HandWeight = "양손무게";
            public static string WearWeight = "착용무게";
            public static string BagWeight = "가방무게";
            public static string BagWeight_Hint = "무게";
            public static string FastRun = "질주 기능";
            public static string Time = "적용시간";
            public static string Range = "적용범위";
            public static string RequiredLevel = "필요 레벨";
            public static string RequiredAC = "필요 방어";
            public static string RequiredMAC = "필요 마방";
            public static string RequiredDC = "필요 파괴";
            public static string RequiredMC = "필요 마법";
            public static string RequiredSC = "필요 도력";
            public static string RequiredClass = "필요 직업";
            public static string DontDeathDrop = "드랍 불가능";
            public static string DontDrop = "버리기 금지";
            public static string DontUpgrade = "강화 금지";
            public static string DontSell = "상점 판매 금지";
            public static string DontTrade = "거래 금지";
            public static string DontStore = "보관 금지";
            public static string DontRepair = "수리 금지";
            public static string DontSuperRepair = "특수수리 금지";
            public static string DontDestroyOnDrop = "버림 시 파괴";
            public static string BindOnEquip = "착용시 귀속";
            public static string SoundBound = "귀속";
            public static string Cursed = "이건머지";
            public static string DontAwaken = "각성 불가능";
            public static string GemTooltip1 = "Ctrl키를 누르고 수리할 장신구 선택\n수리가능: ";
            public static string GemTooltip2 = "Ctrl키를 누르고 수리할 방어구 선택\n수리가능: ";
            public static string GemTooltip3 = "Ctrl키를 누르고 강화할 아이템 선택\n강화가능: ";
            public static string SplitUp = "겹치기 최대 개수 : {0}\nShift+마우스(좌)클릭으로 아이템분리";
            public static string Experience = "경험";
            public static string Gold = "금전";
        }

        public class Skill
        {
            public static string TargetIsTooFar = "대상과 거리가 멀어 공격 할 수 없습니다.";
            public static string NotEnoughMana = "마력이 부족하여 사용 할 수 없습니다.";
            public static string ToBeRevived = "부활 하시겠습니까?";
            public static string ThrustingOn = "어검술을 사용합니다.";
            public static string ThrustingOff = "어검술을 사용하지 않습니다.";
            public static string HalfMoonOn = "반월검법을 사용합니다.";
            public static string HalfMoonOff = "반월검법을 사용하지 않습니다.";
            public static string CrossHalfMoonOn = "광풍참을 사용합니다.";
            public static string CrossHalfMoonOff = "광풍참을 사용하지 않습니다.";
            public static string DoubleSlashOn = "풍검술을 사용합니다.";
            public static string DoubleSlashOff = "풍검술을 사용하지 않습니다.";
            public static string FlamingSwordOn = "당신의 무기에 불의기운이 달아오름을 느낍니다.";
            public static string FlamingSwordOff = "불의기운이 소멸 되었습니다.";
            public static string CoolTime = "You cannot cast for another {0} seconds.";
        }

        public static Color GradeNameColor(ItemGrade grade)
        {
            switch (grade)
            {
                case ItemGrade.Common:
                    return Color.Yellow;
                case ItemGrade.Rare:
                    return Color.FromArgb(255,74,233,255);
                case ItemGrade.Legendary:
                    return Color.FromArgb(255,255,117,0);
                case ItemGrade.Mythical:
                    return Color.FromArgb(255,220,168,255);
                default:
                    return Color.Yellow;
            }
        }

        public static Color GradeDropNameColor(ItemGrade grade)
        {
            switch (grade)
            {
                case ItemGrade.Common:
                    return Color.White;
                case ItemGrade.Rare:
                    return Color.FromArgb(255, 74, 233, 255);
                case ItemGrade.Legendary:
                    return Color.FromArgb(255, 255, 117, 0);
                case ItemGrade.Mythical:
                    return Color.FromArgb(255, 220, 168, 255);
                default:
                    return Color.White;
            }
        }

        public static string MirClassToString(MirClass Class)
        {
            return ((KorMirClass)Class).ToString();
        }

        public static MirClass ToMirClass(string ClassName)
        {
            KorMirClass kmc;
            Enum.TryParse(ClassName, out kmc);
            return (MirClass)kmc;
        }

        public static string RequiredClassToString(RequiredClass classType)
        {
            if (classType == RequiredClass.Warrior)
                return "전사";
            else if (classType == RequiredClass.Wizard)
                return "술사";
            else if (classType == RequiredClass.Taoist)
                return "도사";
            else if (classType == RequiredClass.Assassin)
                return "자객";
            else if (classType == RequiredClass.Archer)
                return "궁수";
            else if (classType == RequiredClass.HighWarrior)
                return "벽혈전사";
            else if (classType == RequiredClass.HighWizard)
                return "홍현술사";
            else if (classType == RequiredClass.HighTaoist)
                return "익선도사";
            else if (classType == RequiredClass.HighAssassin)
                return "비연자객";
            else if (classType == RequiredClass.HighArcher)
                return "암귀궁수";
            else if (classType == RequiredClass.WarHighWar)
                return "전사/벽혈전사";
            else if (classType == RequiredClass.WizHighWiz)
                return "술사/홍현술사";
            else if (classType == RequiredClass.TaoHighTao)
                return "도사/익선도사";
            else if (classType == RequiredClass.AssHighAss)
                return "자객/비연자객";
            else if (classType == RequiredClass.ArcHighArc)
                return "궁수/암귀궁수";
            else if (classType == RequiredClass.WarWizTao)
                return "전사/술사/도사";
            else if (classType == RequiredClass.WarWizTaoAssArc)
                return "전사/술사/도사/자객/궁수";
            else if (classType == RequiredClass.All || classType == RequiredClass.None)
                return "전 직업";
            else if (classType == RequiredClass.High)
                return "우화등선";
            else
                return "전직업";
        }

        public static string ItemGradeToString(ItemGrade grade)
        {
            switch (grade)
            {
                default:
                case ItemGrade.None:
                    return "";
                case ItemGrade.Common:
                    return "일반";
                case ItemGrade.Rare:
                    return "보물";
                case ItemGrade.Legendary:
                    return "성물";
                case ItemGrade.Mythical:
                    return "신물";
            }
        }

        public static string ItemTypeToString(ItemType type, short shape)
        {
            switch (type)
            {
                default:
                case ItemType.Nothing:
                    return "아무거나";
                case ItemType.Weapon:
                    return "무기";
                case ItemType.Armour:
                    return "갑옷";
                case ItemType.Helmet:
                    return "투구";
                case ItemType.Necklace:
                    return "목걸이";
                case ItemType.Bracelet:
                    return "팔찌";
                case ItemType.Ring:
                    return "반지";
                case ItemType.Pets:
                    return "영물";
                case ItemType.Amulet:
                    {
                        switch (shape)
                        {
                            case 0:
                            case 3:
                                return "부적";
                            case 1:
                            case 2:
                                return "독가루";
                            default:
                                return "기공석";
                        }
                    }
                case ItemType.Belt:
                    return "허리띠";
                case ItemType.Boots:
                    return "신발";
                case ItemType.Stone:
                    return "수호석";
                case ItemType.Torch:
                    return "횃불";
                case ItemType.Potion:
                    {
                        switch (shape)
                        {
                            case 0:
                                return "지속회복";
                            case 1:
                                return "즉시회복";
                            case 2:
                                return "미지수";
                            case 3:
                                return "강화";
                            default:
                                return "물약";
                        }
                    }
                case ItemType.Ore:
                    return "광석";
                case ItemType.Meat:
                    return "고기";
                case ItemType.CraftingMaterial:
                    return "재료";
                case ItemType.Scroll:
                    {
                        switch (shape)
                        {
                            case 3:
                                return "장비강화";
                            case 4:
                                return "무기수리";
                            case 5:
                                return "무기수리";
                            default:
                                return "이동서";
                        }
                    }
                case ItemType.Gem:
                    {
                        switch (shape)
                        {
                            case 1:
                                return "수리";
                            case 2:
                                return "수리";
                            case 3:
                                return "보옥";
                            case 4:
                                return "신주";
                            default:
                                return "보옥";
                        }
                    }
                case ItemType.Mount:
                    return "탈것";
                case ItemType.Book:
                    {
                        if (shape >= 0 && shape <= 30)
                            return "전사, 벽혈전사 무공책";
                        else if (shape >= 31 && shape <= 60)
                            return "술사, 홍현술사 무공책";
                        else if (shape >= 61 && shape <= 90)
                            return "도사, 익선도사 무공책";
                        else if (shape >= 91 && shape <= 120)
                            return "자객, 비연자객 무공책";
                        else
                            return "궁수, 암귀궁수 무공책";
                    }
                case ItemType.Script:
                    return "밀환상점";
                case ItemType.Reins:
                    return "탈것기능";
                case ItemType.Bells:
                    return "탈것기능";
                case ItemType.Saddle:
                    return "탈것기능";
                case ItemType.Ribbon:
                    return "탈것기능";
                case ItemType.Mask:
                    return "탈것기능";
                case ItemType.Food:
                    return "탈것먹이";
                case ItemType.Hook:
                    return "낚시용품";
                case ItemType.Float:
                    return "낚시용품";
                case ItemType.Bait:
                    return "낚시용품";
                case ItemType.Finder:
                    return "낚시용품";
                case ItemType.Reel:
                    return "낚시용품";
                case ItemType.Fish:
                    return "낚시대";
                case ItemType.Quest:
                    return "퀘스트";
                case ItemType.Awakening:
                    return "특수사용";
            }
        }

        //temp impl
        public static string SpellToStriong(Spell spell, bool isToolTip = false)
        {
            switch (spell)
            {
                //Warrior
                case Spell.Fencing:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "외수검법";
                        }
                    }
                case Spell.Slaying:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "예도검법";
                        }
                    }
                case Spell.Thrusting:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "어검술";
                        }
                    }
                case Spell.HalfMoon:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "반월검법";
                        }
                    }
                case Spell.ShoulderDash:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "무태보";
                        }
                    }
                case Spell.TwinDrakeBlade:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "쌍룡참";
                        }
                    }
                case Spell.Entrapment:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "포승검";
                        }
                    }
                case Spell.FlamingSword:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "염화결";
                        }
                    }
                case Spell.LionRoar:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "사자후";
                        }
                    }
                case Spell.CrossHalfMoon:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "광풍참";
                        }
                    }
                case Spell.BladeAvalanche:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "공파섬";
                        }
                    }
                case Spell.ProtectionField:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "호신기막";
                        }
                    }
                case Spell.Rage:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "첨기폭";
                        }
                    }
                case Spell.CounterAttack:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "천무";
                        }
                    }
                case Spell.SlashingBurst:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "일섬";
                        }
                    }
                case Spell.Fury:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "혈룡검법";
                        }
                    }

                //Wizard
                case Spell.FireBall:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "화염장";
                        }
                    }
                case Spell.Repulsion:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "화염풍";
                        }
                    }
                case Spell.ElectricShock:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "뢰혼격";
                        }
                    }
                case Spell.GreatFireBall:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "금강화염장";
                        }
                    }
                case Spell.HellFire:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "염사장";
                        }
                    }
                case Spell.ThunderBolt:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "강격";
                        }
                    }
                case Spell.Teleport:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "아공행법";
                        }
                    }
                case Spell.FireBang:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "폭열파";
                        }
                    }
                case Spell.FireWall:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "지염술";
                        }
                    }
                case Spell.Lightning:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "뢰인장";
                        }
                    }
                case Spell.FrostCrunch:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "결빙장";
                        }
                    }
                case Spell.ThunderStorm:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "뢰설화";
                        }
                    }
                case Spell.MagicShield:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "주술의막";
                        }
                    }
                case Spell.TurnUndead:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "사자윤회";
                        }
                    }
                case Spell.Vampirism:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "흡혈술";
                        }
                    }
                case Spell.IceStorm:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "빙설풍";
                        }
                    }
                case Spell.FlameDisruptor:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "멸천화";
                        }
                    }
                case Spell.Mirroring:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "분신술";
                        }
                    }
                case Spell.FlameField:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "화룡기염";
                        }
                    }
                case Spell.Blizzard:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "천상빙환";
                        }
                    }
                case Spell.MagicBooster:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "천상비술";
                        }
                    }
                case Spell.MeteorStrike:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "천상낙염";
                        }
                    }
                case Spell.IceThrust:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "빙염술";
                        }
                    }

                //Taoist
                case Spell.Healing:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "회복술";
                        }
                    }
                case Spell.SpiritSword:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "일광검법";
                        }
                    }
                case Spell.Poisoning:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "암연술";
                        }
                    }
                case Spell.SoulFireBall:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "폭살계";
                        }
                    }
                case Spell.SummonSkeleton:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "백골소환술";
                        }
                    }
                case Spell.Hiding:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "은신술";
                        }
                    }
                case Spell.MassHiding:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "대은신술";
                        }
                    }
                case Spell.SoulShield:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "항마진법";
                        }
                    }
                case Spell.Revelation:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "탐기파연";
                        }
                    }
                case Spell.BlessedArmour:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "대지원호";
                        }
                    }
                case Spell.EnergyRepulsor:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "기공파";
                        }
                    }
                case Spell.TrapHexagon:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "결계";
                        }
                    }
                case Spell.Purification:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "정화술";
                        }
                    }
                case Spell.MassHealing:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "대회복술";
                        }
                    }
                case Spell.Hallucination:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "미혼술";
                        }
                    }
                case Spell.UltimateEnhancer:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "무극진기";
                        }
                    }
                case Spell.SummonShinsu:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "신수소환";
                        }
                    }
                case Spell.Reincarnation:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "소생술";
                        }
                    }
                case Spell.SummonHolyDeva:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "정혼소환술";
                        }
                    }
                case Spell.Curse:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "저주술";
                        }
                    }
                case Spell.Plague:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "번뇌";
                        }
                    }
                case Spell.PoisonCloud:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "독무";
                        }
                    }
                case Spell.EnergyShield:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "선천기공";
                        }
                    }
    
                //Assassin
                case Spell.FatalSword:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "절명검법";
                        }
                    }
                case Spell.DoubleSlash:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "풍검술";
                        }
                    }
                case Spell.Haste:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "체신풍";
                        }
                    }
                case Spell.FlashDash:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "발도술";
                        }
                    }
                case Spell.LightBody:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "풍신술";
                        }
                    }
                case Spell.HeavenlySword:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "천이검";
                        }
                    }
                case Spell.FireBurst:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "열풍격";
                        }
                    }
                case Spell.Trap:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "포박술";
                        }
                    }
                case Spell.PoisonSword:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "맹독검기";
                        }
                    }
                case Spell.MoonLight:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "월영술";
                        }
                    }
                case Spell.MPEater:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "흡기";
                        }
                    }
                case Spell.SwiftFeet:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "경신보";
                        }
                    }
                case Spell.DarkBody:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "열화신";
                        }
                    }
                case Spell.Hemorrhage:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "혈풍격";
                        }
                    }
                case Spell.CrescentSlash:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "월하난무";
                        }
                    }

                //Archer
                case Spell.Focus:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "필중섬";
                        }
                    }
                case Spell.StraightShot:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "천일섬";
                        }
                    }
                case Spell.DoubleShot:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "무아섬";
                        }
                    }
                case Spell.ExplosiveTrap:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "폭정";
                        }
                    }
                case Spell.DelayedExplosion:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "폭섬";
                        }
                    }
                case Spell.Meditation:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "기공술";
                        }
                    }
                case Spell.BackStep:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "풍탄보";
                        }
                    }
                case Spell.ElementalShot:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "기공술";
                        }
                    }
                case Spell.Concentration:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "기류술";
                        }
                    }
                case Spell.Stonetrap:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "지주정";
                        }
                    }
                case Spell.ElementalBarrier:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "금강술";
                        }
                    }
                case Spell.SummonVampire:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "흡혈지정";
                        }
                    }
                case Spell.VampireShot:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "흡혈지섬";
                        }
                    }
                case Spell.SummonToad:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "비마정";
                        }
                    }
                case Spell.PoisonShot:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "독마섬";
                        }
                    }
                case Spell.CrippleShot:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "사폭섬";
                        }
                    }
                case Spell.SummonSnakes:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "사주정";
                        }
                    }
                case Spell.NapalmShot:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "혈룡섬";
                        }
                    }
                case Spell.OneWithNature:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "혈룡섬비급";
                        }
                    }
                case Spell.BindingShot:
                    {
                        if (isToolTip)
                        {
                            return "정보없음";
                        }
                        else
                        {
                            return "만금섬";
                        }
                    }
                default:
                    {
                        return "정보없음";
                    }
            }
        }
    }
}


