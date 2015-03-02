using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Global
{
    class GlobalText
    {
        //System
        public static string Sys_StartGame = "이곳은 테스트 서버입니다. 테스트서버의 운용 규칙은 홈페이지를 참고하십시오.";
        public static string Sys_LevelUp = "축하합니다! 레벨이 올랐습니다. HP,MP가 모두 회복되었습니다.";
        public static string Sys_GainedExp = "경험치가 {0} 올랐습니다.";
        public static string Sys_GainedItem = "{0}를 얻었습니다.";
        public static string Sys_GainedGold = "{0:###,###,###}전을 얻었습니다.";
        public static string Sys_Exit = "미르의 전설2를 종료하시겠습니까?";
        public static string Sys_LogOut = "로그아웃 하시겠습니까?";
        public static string Sys_ReviveTown = "당신은 죽었습니다. 마을로 귀환하시겠습니까?";
        public static string Sys_NotEnoughMaterials = "재료를 가지고 있지 않습니다.";
        public static string Sys_DontHaveGold = "금전이 부족합니다.";
        public static string Sys_OverWeight = "You do no have enough weight.";
        public static string Sys_DontPurchase = "Cannot purchase any more items.";
        public static string Sys_MaxAwakeningLevel = "각성 레벨이 최대치입니다.";
        public static string Sys_CantAwaken = "각성을 할 수 없는 아이템 입니다.";
        public static string Sys_RequestTrade = "{0}님과 거래가 시작되었습니다.";
        public static string Sys_CancelTrade = "거래가 취소되었습니다.";
        public static string Sys_LoginGuildMember = "{0} 님이 접속했습니다.";
        public static string Sys_JoinGuildMember = "{0} 님이 가입했습니다.";
        public static string Sys_KickMember = "{0} 님이 추방되었습니다.";
        public static string Sys_LeaveMember = "{0} 님이 떠났습니다.";
        public static string Sys_CreateGuild = "설립할 문파의 이름을 적으십시오.";
        public static string Sys_CantUseGuildName = "사용할 수 없는 문파명입니다.";
        public static string Sys_CantDrop = "You cannot drop {0}";
        public static string Sys_WantDrop = "정말로 {0}을 버리시겠습니까?";
        public static string Sys_MustBeWearingABow = "You must be wearing a bow to perform this skill.";
        public static string Sys_MaxGroup = "Your group already has the maximum number of members.";
        public static string Sys_NotGroupLeader = "You are not the leader of your group.";
        public static string Sys_EnterGroupMember = "Please enter the name of the person you wish to group.";
        public static string Sys_CantSell = "Cannot sell this item.";
        public static string Sys_CantCarryGold = "Cannot carry anymore gold.";
        public static string Sys_CantRepair = "Cannot repair this item.";
        public static string Sys_CantStore = "Cannot store this item.";
        public static string Sys_PurchaseAmount = "Purchase Amount:";
        public static string Sys_DropAmount = "Drop Amount:";
        public static string Sys_ConsignmentPrice = "Consignment Price:";
        public static string Sys_SellAmount = "Sell Amount:";
        public static string Sys_DropPanelSale = "Sale: ";
        public static string Sys_DropPanelRepair = "Repair: ";
        public static string Sys_DropPanelSRepair = "S. Repair: ";
        public static string Sys_DropPanelConsignment = "Consignment: ";
        public static string Sys_DropPanelDisassemble = "Disassemble: ";
        public static string Sys_DropPanelDowngrade = "Downgrade: ";
        public static string Sys_DropPanelReset = "Reset: ";
        public static string Sys_SelectAwakeItem = "Select Upgrade Item.";
        public static string Sys_SelectAwakeUpgradeType = "Select Upgrade Item.";
        public static string Sys_SelectKey = "Select the Key for: {0}";
        public static string Sys_DontMount = "You do not own a mount.";
        public static string Sys_DontHaveFishingRod = "You are not holding a fishing rod.";
        //AttackMode
        public static string AttackModePeacefulStartMsg = "[대인 공격 방식: 평화 공격]";
        public static string AttackModeGroupStartMsg = "[대인 공격 방식: 그룹 단위 공격]";
        public static string AttackModeGuildStartMsg = "[대인 공격 방식: 문파 단위 공격]";
        public static string AttackModeEnemyGuildStartMsg = "[대인 공격 방식: 적대 문파 공격]";
        public static string AttackModeRedBrownStartMsg = "[대인 공격 방식: 선악 대결 공격]";
        public static string AttackModeAllStartMsg = "[대인 공격 방식: 모두 공격 가능]";

        public static string AttackModePeaceful = "[평화 공격 형태]";
        public static string AttackModeGroup = "[그룹단위 공격 형태]";
        public static string AttackModeGuild = "[문파단위 공격 형태]";
        public static string AttackModeEnemyGuild = "[적대 문파 공격 형태]";
        public static string AttackModeRedBrown = "[선악 대결 공격 형태]";
        public static string AttackModeAll = "[모두 공격 가능]";

        public static string AttackModePeaceful1 = "[평화공격]";
        public static string AttackModeGroup1 = "[그룹공격]";
        public static string AttackModeGuild1 = "[문파공격]";
        public static string AttackModeEnemyGuild1 = "[적대문파공격]";
        public static string AttackModeRedBrown1 = "[선악공격]";
        public static string AttackModeAll1 = "[모두공격]";
        //SkillMode
        public static string SkillModeCtrl = "[Ctrl키 사용]";
        public static string SkillModeDot = "[~키 사용]";
        //ViewHpMode
        public static string HpMode1 = "<HP/MP Mode 1>";
        public static string HpMode2 = "<HP/MP Mode 2>";
        //PetMode
        public static string PetModeAttack = "[부하의 행동 : 공격]";
        public static string PetModeAttackOnly = "[부하의 행동 : 이동금지]";
        public static string PetModeMoveOnly = "[부하의 행동 : 공격금지]";
        public static string PetModeNone = "[부하의 행동 : 휴식]";
        //Interface
        public static string InventoryButton = "가방 (I)";
        public static string CharacterButton = "캐릭터 (C)";
        public static string SkillButton = "무공 (S)";
        public static string QuestButton = "퀘스트 (Q)";
        public static string OptionButton = "옵션 (O)";
        public static string MenuButton = "메뉴";
        public static string GameShopButton = "환상점";
        public static string SizeButton = "Size";
        public static string SettingsButton = "설정";
        public static string ChatNormalButton = "All";
        public static string ChatShoutButton = "Shout";
        public static string ChatWhisperButton = "Whisper";
        public static string ChatLoverButton = "Lover";
        public static string ChatMentorButton = "Mentor";
        public static string ChatGroupButton = "Group";
        public static string ChatGuildButton = "Guild";
        public static string RotateButton = "회전";
        public static string BeltCloseButton = "닫기(Z)";
        public static string MailButton = "편지함";
        public static string BigMapButton = "필드맵(B)";
        public static string MiniMapButton = "미니맵(V)";
        public static string ExitButton = "종료(Alt + Q)";
        public static string LogOutButton = "로그아웃(Alt + X)";
        public static string HelpButton = "도움말(H)";
        public static string RideButton = "탈것(J)";
        public static string FishingButton = "낚시(N)";
        public static string FriendButton = "친구";
        public static string MentorButton = "스승";
        public static string RelationshipButton = "결혼";
        public static string GroupButton = "그룹(P)";
        public static string GuildButton = "문파(G)";
        public static string ExpBar = "경험치 {0} / {1}";
        //Item
        public static string BraveryGlyph = "용맹의각성";
        public static string MagicGlyph = "마성의각성";
        public static string SoulGlyph = "선계의각성";
        public static string ProtectionGlyph = "수호의각성";
        public static string EvilSlayerGlyph = "제마의각성";
        public static string BodyGlyph = "육체의각성";
        //Atturibute
        public static string Count = "개수";
        public static string Usage = "사용";
        public static string Purity = "순도";
        public static string Quality = "품질";
        public static string Loyalty = "충성도";
        public static string Nutrition = "영양";
        public static string Durability = "내구";
        public static string Weight = "무게";
        public static string DC = "파괴";
        public static string MC = "마법";
        public static string SC = "도력";
        public static string Luck = "행운";
        public static string Curse = "저주";
        public static string Success = "성공확률";
        public static string Failure = "실패확률";
        public static string Accuracy = "정확";
        public static string Holy = "신성";
        public static string ASpeed = "공격속도";
        public static string Freezing = "둔화";
        public static string Poison = "중독";
        public static string CriticalRate = "치명타확률";
        public static string Flexibility = "유연성";
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
        public static string Strong = "힘";
        public static string PoisonResist = "중독저항";
        public static string MagicResist = "마법저항";
        public static string HandWeight = "양손무게";
        public static string WearWeight = "착용무게";
        public static string BagWeight = "가방무게";
        public static string FastRun = "질주";
        public static string Time = "적용시간";
        public static string Range = "적용범위";
        public static string Att_RequiredLevel = "필요 레벨";
        public static string Att_RequiredAC = "필요 방어";
        public static string Att_RequiredMAC = "필요 마법방어";
        public static string Att_RequiredDC = "필요 파괴력";
        public static string Att_RequiredMC = "필요 마법력";
        public static string Att_RequiredSC = "필요 도력";
        public static string Att_RequiredClass = "필요 직업";
        public static string DontDeathDrop = "드랍 불가능";
        public static string DontDrop = "버림 금지";
        public static string DontUpgrade = "강화 금지";
        public static string DontSell = "판매 금지";
        public static string DontTrade = "거래 금지";
        public static string DontStore = "보관 금지";
        public static string DontRepair = "수리 금지";
        public static string DontSuperRepair = "특수수리 금지";
        public static string DontDestroyOnDrop = "버림 시 파괴";
        public static string BindOnEquip = "귀속안됨";
        public static string SoundBound = "귀속";
        public static string Cursed = "이건머지";
        public static string DontAwaken = "각성 불가능";
        public static string GemTooltip1 = "Ctrl키를 누르고 수리할 장신구 선택\n수리가능: 목걸이, 반지, 팔찌";
        public static string GemTooltip2 = "Ctrl키를 누르고 수리할 방어구 선택\n수리가능: 갑옷, 투구, 요대, 신발";
        public static string GemTooltip3 = "Ctrl키를 누르고 강화할 아이템 선택\n강화가능:반지, 팔찌,옷,투구,허리띠,신발";
        public static string SplitUp = "겹치기 최대 개수 : {0}\nShift+마우스(좌)클릭으로 아이템분리";
        public static string Experience = "경험치";
        public static string Gold = "금전";
        //Skill
        public static string Skill_TargetIsTooFar = "대상과 거리가 멀어 공격 할 수 없습니다.";
        public static string Skill_NotEnoughMana = "마력이 부족하여 사용 할 수 없습니다.";
        public static string Skill_ToBeRevived = "부활 하시겠습니까?";
        public static string Skill_UseThrusting = "어검술을 사용합니다.";
        public static string Skill_DontUseThrusting = "어검술을 사용하지 않습니다.";
        public static string Skill_UseHalfMoon = "반월검법을 사용합니다.";
        public static string Skill_DontUseHalfMoon = "반월검법을 사용하지 않습니다.";
        public static string Skill_UseCrossHalfMoon = "광풍참을 사용합니다.";
        public static string Skill_DontUseCrossHalfMoon = "광풍참을 사용하지 않습니다.";
        public static string Skill_UseDoubleSlash = "풍검술을 사용합니다.";
        public static string Skill_DontUseDoubleSlash = "풍검술을 사용하지 않습니다.";
        public static string Skill_FlamingSwordMsg = "당신의 무기가 불의 기운으로 달아올랐습니다.";
        public static string Skill_FlamingSwordFailMsg = "기를 모으는데 실패하였습니다.";
        public static string Skill_CoolTimePoisonCloud = "You cannot cast Poison Cloud for another {0} seconds.";
        public static string Skill_CoolTimeSlashingBurst = "You cannot cast SlashingBurst for another {0} seconds.";
        public static string Skill_CoolTimeFury = "You cannot cast Fury for another {0} seconds.";
        public static string Skill_CoolTimeTrap = "You cannot cast Trap for another {0} seconds.";
        public static string Skill_CoolTimeSwiftFeet = "You cannot cast SwiftFeet for another {0} seconds.";

        public static Color GradeNameColor(ItemGrade grade)
        {
            switch (grade)
            {
                case ItemGrade.Common:
                    return Color.Yellow;
                case ItemGrade.Rare:
                    return Color.DeepSkyBlue;
                case ItemGrade.Legendary:
                    return Color.DarkOrange;
                case ItemGrade.Mythical:
                    return Color.Plum;
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
                    return Color.DeepSkyBlue;
                case ItemGrade.Legendary:
                    return Color.DarkOrange;
                case ItemGrade.Mythical:
                    return Color.Plum;
                default:
                    return Color.White;
            }
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
            else if (classType == RequiredClass.WarWizTao)
                return "전사/술사/도사";
            else if (classType == RequiredClass.None)
                return "전직업";
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
                    return "무공책";
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
    }
}


