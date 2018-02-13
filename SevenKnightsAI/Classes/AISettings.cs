using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SevenKnightsAI.Classes
{
    public class AISettings
    {
        #region Public Fields

        [XmlElement(ElementName = "AD_AmountSequence")]
        public int[] AD_AmountSequence;

        [XmlElement(ElementName = "AD_Continuous")]
        public bool AD_Continuous;

        [XmlElement(ElementName = "AD_Difficulty")]
        public Difficulty AD_Difficulty;

        [XmlElement(ElementName = "AD_Difficulty2nd")]
        public Difficulty AD_Difficulty2nd;

        [XmlElement(ElementName = "AD_ElementHeroesOnly")]
        public bool AD_ElementHeroesOnly;

        [XmlElement(ElementName = "AD_Enable")]
        public bool AD_Enable;

        [XmlElement(ElementName = "AD_HottimeEnable")]
        public bool AD_HottimeEnable;

        [XmlElement(ElementName = "AD_EnableLimit")]
        public bool AD_EnableLimit;

        [XmlElement(ElementName = "AD_Formation")]
        public Formation AD_Formation;

        [XmlElement(ElementName = "AD_HeroManagePositions")]
        public int[] AD_HeroManagePositions;

        [XmlElement(ElementName = "AD_Limit")]
        public int AD_Limit;

        [XmlElement(ElementName = "AD_Mastery")]
        public Mastery AD_Mastery;

        [XmlElement(ElementName = "AD_SkillType")]
        public SkillType AD_SkillType;

        [XmlElement(ElementName = "AD_w2SkillType")]
        public SkillType AD_w2SkillType;

        [XmlElement(ElementName = "AD_w3SkillType")]
        public SkillType AD_w3SkillType;

        [XmlElement(ElementName = "AD_Stage")]
        public int AD_Stage;

        [XmlElement(ElementName = "AD_StageSequence")]
        public int[] AD_StageSequence;

        [XmlElement(ElementName = "AD_StopOnFullHeroes")]
        public bool AD_StopOnFullHeroes;

        [XmlElement(ElementName = "AD_StopOnFullItems")]
        public bool AD_StopOnFullItems;

        [XmlElement(ElementName = "AD_StopOnDragonFull")]
        public bool AD_StopOnDragonFull;

        [XmlElement(ElementName = "AD_RubyBooster")]
        public bool AD_RubyBooster;

        [XmlElement(ElementName = "AD_StopOnLV30")]
        public bool AD_StopOnLV30;

        [XmlElement(ElementName = "AD_CheckingHeroes")]
        public bool AD_CheckingHeroes;

        [XmlElement(ElementName = "AD_Team")]
        public Team AD_Team;

        [XmlElement(ElementName = "AD2_Team")]
        public Team AD2_Team;

        [XmlElement(ElementName = "AD_Wave1Loop")]
        public bool AD_Wave1Loop;

        [XmlElement(ElementName = "AD_Wave1Skills")]
        public int[] AD_Wave1Skills;

        [XmlElement(ElementName = "AD_Wave2Loop")]
        public bool AD_Wave2Loop;

        [XmlElement(ElementName = "AD_Wave2Skills")]
        public int[] AD_Wave2Skills;

        [XmlElement(ElementName = "AD_Wave3Loop")]
        public bool AD_Wave3Loop;

        [XmlElement(ElementName = "AD_Wave3Skills")]
        public int[] AD_Wave3Skills;

        [XmlElement(ElementName = "AD_World")]
        public World AD_World;

        [XmlElement(ElementName = "AD_WorldSequence")]
        public int[] AD_WorldSequence;

        [XmlElement(ElementName = "AD_UseFriend")]
        public bool AD_UseFriend;

        [XmlElement(ElementName = "AD_BootMode")]
        public bool AD_BootMode;

        [XmlElement(ElementName = "AR_Enable")]
        public bool AR_Enable;

        [XmlElement(ElementName = "AR_EnableLimit")]
        public bool AR_EnableLimit;

        [XmlElement(ElementName = "AR_Limit")]
        public int AR_Limit;

        [XmlElement(ElementName = "AR_Mastery")]
        public Mastery AR_Mastery;

        [XmlElement(ElementName = "AR_UseRuby")]
        public bool AR_UseRuby;

        [XmlElement(ElementName = "AR_LimitArena")]
        public bool AR_LimitArena;

        [XmlElement(ElementName = "AR_LimitScore")]
        public int AR_LimitScore;

        [XmlElement(ElementName = "AR_UseRubyAmount")]
        public int AR_UseRubyAmount;

        [XmlElement(ElementName = "GB_WaitForKeys")]
        public bool GB_WaitForKeys;

        [XmlElement(ElementName = "GC_Enable")]
        public bool GC_Enable;

        [XmlElement(ElementName = "GC_EnableLimit")]
        public bool GC_EnableLimit;

        [XmlElement(ElementName = "GC_Formation")]
        public Formation GC_Formation;

        [XmlElement(ElementName = "GC_Limit")]
        public int GC_Limit;

        [XmlElement(ElementName = "GC_Mastery")]
        public Mastery GC_Mastery;

        [XmlElement(ElementName = "GC_SkillType")]
        public SkillType GC_SkillType;

        [XmlElement(ElementName = "GC_Team")]
        public Team GC_Team;

        [XmlElement(ElementName = "GC_Wave1Loop")]
        public bool GC_Wave1Loop;

        [XmlElement(ElementName = "GC_Wave1Skills")]
        public int[] GC_Wave1Skills;

        [XmlElement(ElementName = "GC_Wave2Loop")]
        public bool GC_Wave2Loop;

        [XmlElement(ElementName = "GC_Wave2Skills")]
        public int[] GC_Wave2Skills;

        [XmlElement(ElementName = "GC_UseFriend")]
        public bool GC_UseFriend;

        [XmlElement(ElementName = "RD_Enable")]
        public bool RD_Enable;

        [XmlElement(ElementName = "RD_EnableDragonLimit")]
        public bool RD_EnableDragonLimit;

        [XmlElement(ElementName = "RD_Mastery")]
        public Mastery RD_Mastery;

        [XmlElement(ElementName = "RD_SkillType")]
        public SkillType RD_SkillType;

        [XmlElement(ElementName = "RD_Team1Loop")]
        public bool RD_Team1Loop;

        [XmlElement(ElementName = "RD_Team1Skills")]
        public int[] RD_Team1Skills;

        [XmlElement(ElementName = "RD_Team2Loop")]
        public bool RD_Team2Loop;

        [XmlElement(ElementName = "ARD_Enable")]
        public bool ARD_Enable;

        [XmlElement(ElementName = "RD_Team2Skills")]
        public int[] RD_Team2Skills;

        [XmlElement(ElementName = "RD_OwnerDragon")]
        public bool RD_OwnerDragon;

        [XmlElement(ElementName = "RD_LevelCheckBox")]
        public bool RD_LevelCheckBox;

        [XmlElement(ElementName = "RD_ReadNick")]
        public bool RD_ReadNick;
        
        [XmlElement(ElementName = "RD_DragonLV")]
        public int RD_DragonLV;

        [XmlElement(ElementName = "RD_SummonLV")]
        public int RD_SummonLV;

        [XmlElement(ElementName = "RD_DragonHP")]
        public int RD_DragonHP;

        [XmlElement(ElementName = "RD_DragonRound")]
        public int RD_DragonRound;

        [XmlElement(ElementName = "RD_DragonLVLimit")]
        public int RD_DragonLVLimit;

        [XmlElement(ElementName = "RD_DragonHPLimit")]
        public int RD_DragonHPLimit;

        [XmlElement(ElementName = "RS_BuyKeyHonors")]
        public bool RS_BuyKeyHonors;

        [XmlElement(ElementName = "RS_BuyKeyHonorsAmount")]
        public int RS_BuyKeyHonorsAmount;

        [XmlElement(ElementName = "RS_BuyKeyHonorsType")]
        public BuyKeyHonorsType RS_BuyKeyHonorsType;

        [XmlElement(ElementName = "RS_BuyKeyRubies")]
        public bool RS_BuyKeyRubies;

        [XmlElement(ElementName = "RS_BuyKeyRubiesAmount")]
        public int RS_BuyKeyRubiesAmount;

        [XmlElement(ElementName = "RS_BuyKeyRubiesType")]
        public BuyKeyRubiesType RS_BuyKeyRubiesType;

        [XmlElement(ElementName = "RS_CollectLuckyBox")]
        public bool RS_CollectLuckyBox;

        [XmlElement(ElementName = "RS_CollectLuckyChest")]
        public bool RS_CollectLuckyChest;

        [XmlElement(ElementName = "RS_InboxGold")]
        public bool RS_InboxGold;

        [XmlElement(ElementName = "RS_InboxHonors")]
        public bool RS_InboxHonors;

        [XmlElement(ElementName = "RS_InboxKeys")]
        public bool RS_InboxKeys;

        [XmlElement(ElementName = "RS_InboxRubies")]
        public bool RS_InboxRubies;

        [XmlElement(ElementName = "RS_InboxTickets")]
        public bool RS_InboxTickets;

        [XmlElement(ElementName = "RS_QuestsBattle")]
        public bool RS_QuestsBattle;

        [XmlElement(ElementName = "RS_QuestsHero")]
        public bool RS_QuestsHero;

        [XmlElement(ElementName = "RS_QuestsItem")]
        public bool RS_QuestsItem;

        [XmlElement(ElementName = "RS_QuestsSocial")]
        public bool RS_QuestsSocial;

        [XmlElement(ElementName = "RS_SellHeroAll")]
        public bool RS_SellHeroAll;

        [XmlElement(ElementName = "RS_SellHeroAmount")]
        public int RS_SellHeroAmount;

        [XmlElement(ElementName = "RS_SellHeroes")]
        public bool RS_SellHeroes;

        [XmlElement(ElementName = "RS_SellHeroStars")]
        public int RS_SellHeroStars;

        [XmlElement(ElementName = "RS_SellItemAll")]
        public bool RS_SellItemAll;

        [XmlElement(ElementName = "RS_SellItemAmount")]
        public int RS_SellItemAmount;

        [XmlElement(ElementName = "RS_SellItems")]
        public bool RS_SellItems;

        [XmlElement(ElementName = "RS_SellItemStars")]
        public int RS_SellItemStars;

        [XmlElement(ElementName = "RS_SendHonorsFacebook")]
        public bool RS_SendHonorsFacebook;

        [XmlElement(ElementName = "RS_SendHonorsInGame")]
        public bool RS_SendHonorsInGame;

        [XmlElement(ElementName = "RS_SpecialQuestsDaily")]
        public bool RS_SpecialQuestsDaily;

        [XmlElement(ElementName = "RS_SpecialQuestsMonthly")]
        public bool RS_SpecialQuestsMonthly;

        [XmlElement(ElementName = "RS_SpecialQuestsWeekly")]
        public bool RS_SpecialQuestsWeekly;

        [XmlElement(ElementName = "SP_Enable")]
        public bool SP_Enable;

        [XmlElement(ElementName = "SP_SkillType")]
        public SkillType SP_SkillType;

        [XmlElement(ElementName = "SP_w2SkillType")]
        public SkillType SP_w2SkillType;

        [XmlElement(ElementName = "SP_w3SkillType")]
        public SkillType SP_w3SkillType;

        [XmlElement(ElementName = "SP_Wave1Skills")]
        public int[] SP_Wave1Skills;

        [XmlElement(ElementName = "SP_Wave2Skills")]
        public int[] SP_Wave2Skills;

        [XmlElement(ElementName = "SP_Wave3Skills")]
        public int[] SP_Wave3Skills;

        [XmlElement(ElementName = "SP_Wave1Loop")]
        public bool SP_Wave1Loop;

        [XmlElement(ElementName = "SP_Wave2Loop")]
        public bool SP_Wave2Loop;

        [XmlElement(ElementName = "SP_Wave3Loop")]
        public bool SP_Wave3Loop;

        [XmlElement(ElementName = "SP_DailyNormal")]
        public bool SP_DailyNormal;

        [XmlElement(ElementName = "SP_DailyHard")]
        public bool SP_DailyHard;

        [XmlElement(ElementName = "SP_DailyHell")]
        public bool SP_DailyHell;

        [XmlElement(ElementName = "SP_CakeEasy")]
        public bool SP_CakeEasy;

        [XmlElement(ElementName = "SP_CakeNormal")]
        public bool SP_CakeNormal;

        [XmlElement(ElementName = "SP_CakeHard")]
        public bool SP_CakeHard;

        [XmlElement(ElementName = "SP_CrystalEasy")]
        public bool SP_CrystalEasy;

        [XmlElement(ElementName = "SP_CrystalNormal")]
        public bool SP_CrystalNormal;

        [XmlElement(ElementName = "SP_CrystalHard")]
        public bool SP_CrystalHard;

        [XmlElement(ElementName = "SP_EvanNormal")]
        public bool SP_EvanNormal;

        [XmlElement(ElementName = "SP_EvanHard")]
        public bool SP_EvanHard;

        [XmlElement(ElementName = "SP_EvanHell")]
        public bool SP_EvanHell;

        [XmlElement(ElementName = "SP_karinNormal")]
        public bool SP_karinNormal;

        [XmlElement(ElementName = "SP_karinHard")]
        public bool SP_karinHard;

        [XmlElement(ElementName = "SP_karinHell")]
        public bool SP_karinHell;

        [XmlElement(ElementName = "SP_DailyEnable")]
        public bool SP_DailyEnable;

        [XmlElement(ElementName = "SP_CakeEnable")]
        public bool SP_CakeEnable;

        [XmlElement(ElementName = "SP_CrystalEnable")]
        public bool SP_CrystalEnable;

        [XmlElement(ElementName = "SP_EvanEnable")]
        public bool SP_EvanEnable;

        [XmlElement(ElementName = "SP_KarinEnable")]
        public bool SP_KarinEnable;

        [XmlElement(ElementName = "SP_DailyLimit")]
        public int SP_DailyLimit;

        [XmlElement(ElementName = "SP_CakeLimit")]
        public int SP_CakeLimit;

        [XmlElement(ElementName = "SP_CrystalLimit")]
        public int SP_CrystalLimit;

        [XmlElement(ElementName = "SP_EvanLimit")]
        public int SP_EvanLimit;

        [XmlElement(ElementName = "SP_KarinLimit")]
        public int SP_KarinLimit;

        [XmlElement(ElementName = "SP_EnableLimit")]
        public bool SP_EnableLimit;

        [XmlElement(ElementName = "SP_Limit")]
        public int SP_Limit;

        [XmlElement(ElementName = "SP_UseTicket1")]
        public bool SP_UseTicket1;

        [XmlElement(ElementName = "AD_CurrH30")]
        public int AD_CurrH30;

        [XmlElement(ElementName = "ST_Stop100")]
        public bool ST_Stop100;

        [XmlElement(ElementName = "EX_Enable")]
        public bool EX_Enable;

        [XmlElement(ElementName = "EX_Send")]
        public bool EX_Send;

        [XmlElement(ElementName = "AD_SummonAuto")]
        public bool AD_SummonAuto;


        public string Version = Application.ProductVersion;

        #endregion Public Fields

        #region Public Constructors

        public AISettings()
        {
            this.EX_Enable = true;
            this.EX_Send = true;
            this.AD_SummonAuto = true;
            this.AD_Enable = true;
            this.AD_HottimeEnable = false;
            this.AD_EnableLimit = false;
            this.AD_Limit = 0;
            this.AD_Stage = 0;
            this.AD_Continuous = false;
            this.AD_ElementHeroesOnly = false;
            this.AD_SkillType = SkillType.Both;
            this.AD_w2SkillType = SkillType.Both;
            this.AD_w3SkillType = SkillType.Both;
            this.AD_StopOnFullHeroes = false;
            this.AD_StopOnFullItems = true;
            this.AD_StopOnDragonFull = false;
            this.AD_RubyBooster = false;
            this.AD_StopOnLV30 = false;
            this.AD_CheckingHeroes = true;
            this.AD_Wave1Loop = false;
            this.AD_Wave2Loop = false;
            this.AD_Wave3Loop = false;
            this.AD_UseFriend = false;
            this.AD_BootMode = false;
            this.GB_WaitForKeys = false;
            this.GC_Enable = true;
            this.GC_EnableLimit = false;
            this.GC_Limit = 0;
            this.GC_SkillType = SkillType.Both;
            this.GC_Wave1Loop = false;
            this.GC_Wave2Loop = false;
            this.GC_UseFriend = false;
            this.AR_Enable = true;
            this.AR_EnableLimit = false;
            this.AR_Limit = 0;
            this.AR_UseRuby = false;
            this.AR_LimitArena = false;
            this.AR_LimitScore = 4300;
            this.AR_UseRubyAmount = 0;
            this.RD_Enable = true;
            this.RD_EnableDragonLimit = false;
            this.RD_SkillType = SkillType.Auto;
            this.RD_Team1Loop = false;
            this.RD_Team2Loop = false;
            this.RD_OwnerDragon = true;
            this.RD_LevelCheckBox = true;
            this.RD_ReadNick = true;
            this.RD_DragonLV = 1;
            this.RD_SummonLV = 9;
            this.RD_DragonHP = 50;
            this.RD_DragonRound = 1;
            this.RD_DragonLVLimit = 10;
            this.RD_DragonHPLimit = 100;
            this.ARD_Enable = true;
            this.RS_SellHeroes = false;
            this.RS_SellHeroStars = 1;
            this.RS_SellHeroAmount = 0;
            this.RS_SellHeroAll = true;
            this.RS_SellItems = false;
            this.RS_SellItemStars = 1;
            this.RS_SellItemAmount = 0;
            this.RS_SellItemAll = true;
            this.RS_InboxHonors = false;
            this.RS_InboxKeys = false;
            this.RS_InboxGold = false;
            this.RS_InboxRubies = false;
            this.RS_InboxTickets = false;
            this.RS_CollectLuckyChest = false;
            this.RS_CollectLuckyBox = false;
            this.RS_SpecialQuestsDaily = false;
            this.RS_SpecialQuestsWeekly = false;
            this.RS_SpecialQuestsMonthly = false;
            this.RS_QuestsBattle = false;
            this.RS_QuestsHero = false;
            this.RS_QuestsItem = false;
            this.RS_QuestsSocial = false;
            this.RS_SendHonorsFacebook = false;
            this.RS_SendHonorsInGame = false;
            this.RS_BuyKeyHonors = false;
            this.RS_BuyKeyHonorsType = BuyKeyHonorsType.Key1Honor10;
            this.RS_BuyKeyHonorsAmount = 0;
            this.RS_BuyKeyRubies = false;
            this.RS_BuyKeyRubiesType = BuyKeyRubiesType.Key5Ruby10;
            this.RS_BuyKeyRubiesAmount = 0;
            this.SP_Enable = false;
            this.SP_DailyEnable = false;
            this.SP_CakeEnable = false;
            this.SP_CrystalEnable = false;
            this.SP_EvanEnable = false;
            this.SP_KarinEnable = false;
            this.SP_DailyLimit = 0;
            this.SP_CakeLimit = 0;
            this.SP_CrystalLimit = 0;
            this.SP_EvanLimit = 0;
            this.SP_KarinLimit = 0;
            this.SP_SkillType = SkillType.Both;
            this.SP_w2SkillType = SkillType.Both;
            this.SP_w3SkillType = SkillType.Both;
            this.SP_Wave1Loop = false;
            this.SP_Wave2Loop = false;
            this.SP_Wave3Loop = false;
            this.SP_DailyNormal = true;
            this.SP_CakeEasy = true;
            this.SP_CrystalEasy = true;
            this.SP_EvanNormal = true;
            this.SP_karinNormal = true;
            this.SP_EnableLimit = false;
            this.SP_UseTicket1 = false;
            this.SP_Limit = 0;
            this.AD_CurrH30 = 0;
            this.ST_Stop100 = true;
        }

        #endregion Public Constructors

        #region Public Methods

        public static AISettings Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                string value = File.ReadAllText(filePath);
                Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(value);
                AISettings aISettings = new AISettings();
                try
                {
                    aISettings.AD_SummonAuto = (bool)dictionary["AD_SummonAuto"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.EX_Enable = (bool)dictionary["EX_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.EX_Send = (bool)dictionary["EX_Send"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Enable = (bool)dictionary["AD_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_HottimeEnable = (bool)dictionary["AD_HottimeEnable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_EnableLimit = (bool)dictionary["AD_EnableLimit"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Limit = Convert.ToInt32(dictionary["AD_Limit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Difficulty = (Difficulty)Convert.ToInt32(dictionary["AD_Difficulty"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Difficulty2nd = (Difficulty)Convert.ToInt32(dictionary["AD_Difficulty2nd"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_World = (World)Convert.ToInt32(dictionary["AD_World"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Stage = Convert.ToInt32(dictionary["AD_Stage"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_WorldSequence = ((dictionary["AD_WorldSequence"] == null) ? null : ((JArray)dictionary["AD_WorldSequence"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_StageSequence = ((dictionary["AD_StageSequence"] == null) ? null : ((JArray)dictionary["AD_StageSequence"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_AmountSequence = ((dictionary["AD_AmountSequence"] == null) ? null : ((JArray)dictionary["AD_AmountSequence"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Continuous = (bool)dictionary["AD_Continuous"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Team = (Team)Convert.ToInt32(dictionary["AD_Team"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD2_Team = (Team)Convert.ToInt32(dictionary["AD2_Team"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Formation = (Formation)Convert.ToInt32(dictionary["AD_Formation"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_HeroManagePositions = ((dictionary["AD_HeroManagePositions"] == null) ? null : ((JArray)dictionary["AD_HeroManagePositions"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_ElementHeroesOnly = (bool)dictionary["AD_ElementHeroesOnly"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Mastery = (Mastery)Convert.ToInt32(dictionary["AD_Mastery"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_SkillType = (SkillType)Convert.ToInt32(dictionary["AD_SkillType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_w2SkillType = (SkillType)Convert.ToInt32(dictionary["AD_w2SkillType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_w3SkillType = (SkillType)Convert.ToInt32(dictionary["AD_w3SkillType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_StopOnFullHeroes = (bool)dictionary["AD_StopOnFullHeroes"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_StopOnFullItems = (bool)dictionary["AD_StopOnFullItems"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_StopOnDragonFull = (bool)dictionary["AD_StopOnDragonFull"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_RubyBooster = (bool)dictionary["AD_RubyBooster"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_UseFriend = (bool)dictionary["AD_UseFriend"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_BootMode = (bool)dictionary["AD_BootMode"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_StopOnLV30 = (bool)dictionary["AD_StopOnLV30"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_CheckingHeroes = (bool)dictionary["AD_CheckingHeroes"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Wave1Skills = ((dictionary["AD_Wave1Skills"] == null) ? null : ((JArray)dictionary["AD_Wave1Skills"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Wave2Skills = ((dictionary["AD_Wave2Skills"] == null) ? null : ((JArray)dictionary["AD_Wave2Skills"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Wave3Skills = ((dictionary["AD_Wave3Skills"] == null) ? null : ((JArray)dictionary["AD_Wave3Skills"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Wave1Loop = (bool)dictionary["AD_Wave1Loop"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Wave2Loop = (bool)dictionary["AD_Wave2Loop"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Wave3Loop = (bool)dictionary["AD_Wave3Loop"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GB_WaitForKeys = (bool)dictionary["GB_WaitForKeys"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_Enable = (bool)dictionary["GC_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_EnableLimit = (bool)dictionary["GC_EnableLimit"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_Limit = Convert.ToInt32(dictionary["GC_Limit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_Team = (Team)Convert.ToInt32(dictionary["GC_Team"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_Formation = (Formation)Convert.ToInt32(dictionary["GC_Formation"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_Mastery = (Mastery)Convert.ToInt32(dictionary["GC_Mastery"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_SkillType = (SkillType)Convert.ToInt32(dictionary["GC_SkillType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_Wave1Skills = ((dictionary["GC_Wave1Skills"] == null) ? null : ((JArray)dictionary["GC_Wave1Skills"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_Wave2Skills = ((dictionary["GC_Wave2Skills"] == null) ? null : ((JArray)dictionary["GC_Wave2Skills"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_Wave1Loop = (bool)dictionary["GC_Wave1Loop"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_Wave2Loop = (bool)dictionary["GC_Wave2Loop"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GC_UseFriend = (bool)dictionary["GC_UseFriend"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_Enable = (bool)dictionary["AR_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_EnableLimit = (bool)dictionary["AR_EnableLimit"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_Limit = Convert.ToInt32(dictionary["AR_Limit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_UseRuby = (bool)dictionary["AR_UseRuby"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_UseRubyAmount = Convert.ToInt32(dictionary["AR_UseRubyAmount"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_Mastery = (Mastery)Convert.ToInt32(dictionary["AR_Mastery"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_LimitArena = (bool)dictionary["AR_LimitArena"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_LimitScore = Convert.ToInt32(dictionary["AR_LimitScore"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_Enable = (bool)dictionary["RD_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_Mastery = (Mastery)Convert.ToInt32(dictionary["RD_Mastery"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_EnableDragonLimit = (bool)dictionary["RD_EnableDragonLimit"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_SkillType = (SkillType)Convert.ToInt32(dictionary["RD_SkillType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_Team1Skills = ((dictionary["RD_Team1Skills"] == null) ? null : ((JArray)dictionary["RD_Team1Skills"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_Team2Skills = ((dictionary["RD_Team2Skills"] == null) ? null : ((JArray)dictionary["RD_Team2Skills"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_Team1Loop = (bool)dictionary["RD_Team1Loop"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_Team2Loop = (bool)dictionary["RD_Team2Loop"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_OwnerDragon = (bool)dictionary["RD_OwnerDragon"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_LevelCheckBox = (bool)dictionary["RD_LevelCheckBox"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_ReadNick = (bool)dictionary["RD_ReadNick"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_DragonLV = Convert.ToInt32(dictionary["RD_DragonLV"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_SummonLV = Convert.ToInt32(dictionary["RD_SummonLV"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_DragonLVLimit = Convert.ToInt32(dictionary["RD_DragonLVLimit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_DragonHPLimit = Convert.ToInt32(dictionary["RD_DragonHPLimit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_DragonHP = Convert.ToInt32(dictionary["RD_DragonHP"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RD_DragonRound = Convert.ToInt32(dictionary["RD_DragonRound"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.ARD_Enable = (bool)dictionary["ARD_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellHeroes = (bool)dictionary["RS_SellHeroes"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellHeroStars = Convert.ToInt32(dictionary["RS_SellHeroStars"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellHeroAmount = Convert.ToInt32(dictionary["RS_SellHeroAmount"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellHeroAll = (bool)dictionary["RS_SellHeroAll"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellItems = (bool)dictionary["RS_SellItems"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellItemStars = Convert.ToInt32(dictionary["RS_SellItemStars"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellItemAmount = Convert.ToInt32(dictionary["RS_SellItemAmount"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellItemAll = (bool)dictionary["RS_SellItemAll"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_InboxHonors = (bool)dictionary["RS_InboxHonors"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_InboxKeys = (bool)dictionary["RS_InboxKeys"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_InboxGold = (bool)dictionary["RS_InboxGold"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_InboxRubies = (bool)dictionary["RS_InboxRubies"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_InboxTickets = (bool)dictionary["RS_InboxTickets"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_CollectLuckyChest = (bool)dictionary["RS_CollectLuckyChest"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_CollectLuckyBox = (bool)dictionary["RS_CollectLuckyBox"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SpecialQuestsDaily = (bool)dictionary["RS_SpecialQuestsDaily"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SpecialQuestsWeekly = (bool)dictionary["RS_SpecialQuestsWeekly"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SpecialQuestsMonthly = (bool)dictionary["RS_SpecialQuestsMonthly"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_QuestsBattle = (bool)dictionary["RS_QuestsBattle"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_QuestsHero = (bool)dictionary["RS_QuestsHero"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_QuestsItem = (bool)dictionary["RS_QuestsItem"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_QuestsSocial = (bool)dictionary["RS_QuestsSocial"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SendHonorsFacebook = (bool)dictionary["RS_SendHonorsFacebook"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SendHonorsInGame = (bool)dictionary["RS_SendHonorsInGame"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyHonors = (bool)dictionary["RS_BuyKeyHonors"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyHonorsType = (BuyKeyHonorsType)Convert.ToInt32(dictionary["RS_BuyKeyHonorsType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyHonorsAmount = Convert.ToInt32(dictionary["RS_BuyKeyHonorsAmount"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyRubies = (bool)dictionary["RS_BuyKeyRubies"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyRubiesType = (BuyKeyRubiesType)Convert.ToInt32(dictionary["RS_BuyKeyRubiesType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyRubiesAmount = Convert.ToInt32(dictionary["RS_BuyKeyRubiesAmount"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_Enable = (bool)dictionary["SP_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_Wave1Loop = (bool)dictionary["SP_Wave1Loop"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_Wave2Loop = (bool)dictionary["SP_Wave2Loop"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_Wave3Loop = (bool)dictionary["SP_Wave3Loop"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_SkillType = (SkillType)Convert.ToInt32(dictionary["SP_SkillType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_w2SkillType = (SkillType)Convert.ToInt32(dictionary["SP_w2SkillType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_w3SkillType = (SkillType)Convert.ToInt32(dictionary["SP_w3SkillType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_Wave1Skills = ((dictionary["SP_Wave1Skills"] == null) ? null : ((JArray)dictionary["SP_Wave1Skills"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_Wave2Skills = ((dictionary["SP_Wave2Skills"] == null) ? null : ((JArray)dictionary["SP_Wave2Skills"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_Wave3Skills = ((dictionary["SP_Wave3Skills"] == null) ? null : ((JArray)dictionary["SP_Wave3Skills"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_DailyNormal = (bool)dictionary["SP_DailyNormal"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_DailyHard = (bool)dictionary["SP_DailyHard"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_DailyHell = (bool)dictionary["SP_DailyHell"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_CakeEasy = (bool)dictionary["SP_CakeEasy"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_CakeNormal = (bool)dictionary["SP_CakeNormal"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_CakeHard = (bool)dictionary["SP_CakeHard"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_CrystalEasy = (bool)dictionary["SP_CrystalEasy"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_CrystalNormal = (bool)dictionary["SP_CrystalNormal"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_CrystalHard = (bool)dictionary["SP_CrystalHard"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_EvanNormal = (bool)dictionary["SP_EvanNormal"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_EvanHard = (bool)dictionary["SP_EvanHard"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_EvanHell = (bool)dictionary["SP_EvanHell"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_karinNormal = (bool)dictionary["SP_karinNormal"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_karinHard = (bool)dictionary["SP_karinHard"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_karinHell = (bool)dictionary["SP_karinHell"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_DailyEnable = (bool)dictionary["SP_DailyEnable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_CakeEnable = (bool)dictionary["SP_CakeEnable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_CrystalEnable = (bool)dictionary["SP_CrystalEnable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_EvanEnable = (bool)dictionary["SP_EvanEnable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_KarinEnable = (bool)dictionary["SP_KarinEnable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_DailyLimit = Convert.ToInt32(dictionary["SP_DailyLimit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_CakeLimit = Convert.ToInt32(dictionary["SP_CakeLimit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_CrystalLimit = Convert.ToInt32(dictionary["SP_CrystalLimit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_EvanLimit = Convert.ToInt32(dictionary["SP_EvanLimit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_KarinLimit = Convert.ToInt32(dictionary["SP_KarinLimit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_EnableLimit = (bool)dictionary["SP_EnableLimit"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_UseTicket1 = (bool)dictionary["SP_UseTicket1"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SP_Limit = Convert.ToInt32(dictionary["SP_Limit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.ST_Stop100 = (bool)dictionary["ST_Stop100"];
                }
                catch (Exception)
                { }
                return aISettings;
            }
            throw new AISettingsException("Settings file not found", -1);
        }

        public void Save(string filePath)
        {
            Dictionary<string, object> value = new Dictionary<string, object>
            {
                {
                    "AD_Enable",
                    this.AD_Enable
                },
                {
                    "AD_EnableLimit",
                    this.AD_EnableLimit
                },
                {
                    "AD_Limit",
                    this.AD_Limit
                },
                {
                    "AD_Difficulty",
                    this.AD_Difficulty
                },
                {
                    "AD_Difficulty2nd",
                    this.AD_Difficulty2nd
                },
                {
                    "AD_World",
                    this.AD_World
                },
                {
                    "AD_Stage",
                    this.AD_Stage
                },
                {
                    "AD_WorldSequence",
                    this.AD_WorldSequence
                },
                {
                    "AD_StageSequence",
                    this.AD_StageSequence
                },
                {
                    "AD_AmountSequence",
                    this.AD_AmountSequence
                },
                {
                    "AD_Continuous",
                    this.AD_Continuous
                },
                {
                    "AD_Team",
                    this.AD_Team
                },
                {
                    "AD2_Team",
                    this.AD2_Team
                },
                {
                    "AD_Formation",
                    this.AD_Formation
                },
                {
                    "AD_HeroManagePositions",
                    this.AD_HeroManagePositions
                },
                {
                    "AD_ElementHeroesOnly",
                    this.AD_ElementHeroesOnly
                },
                {
                    "AD_Mastery",
                    this.AD_Mastery
                },
                {
                    "AD_SkillType",
                    this.AD_SkillType
                },
                {
                    "AD_w2SkillType",
                    this.AD_w2SkillType
                },
                {
                    "AD_w3SkillType",
                    this.AD_w3SkillType
                },
                {
                    "AD_StopOnFullHeroes",
                    this.AD_StopOnFullHeroes
                },
                {
                    "AD_StopOnFullItems",
                    this.AD_StopOnFullItems
                },
                {
                    "AD_StopOnDragonFull",
                    this.AD_StopOnDragonFull
                },
                {
                    "AD_RubyBooster",
                    this.AD_RubyBooster
                },
                {
                    "AD_StopOnLV30",
                    this.AD_StopOnLV30
                },
                {
                    "AD_CheckingHeroes",
                    this.AD_CheckingHeroes
                },
                {
                    "AD_Wave1Skills",
                    this.AD_Wave1Skills
                },
                {
                    "AD_Wave2Skills",
                    this.AD_Wave2Skills
                },
                {
                    "AD_Wave3Skills",
                    this.AD_Wave3Skills
                },
                {
                    "AD_Wave1Loop",
                    this.AD_Wave1Loop
                },
                {
                    "AD_Wave2Loop",
                    this.AD_Wave2Loop
                },
                {
                    "AD_Wave3Loop",
                    this.AD_Wave3Loop
                },
                {
                    "GB_WaitForKeys",
                    this.GB_WaitForKeys
                },
                {
                    "GC_Enable",
                    this.GC_Enable
                },
                {
                    "GC_EnableLimit",
                    this.GC_EnableLimit
                },
                {
                    "GC_Limit",
                    this.GC_Limit
                },
                {
                    "GC_Team",
                    this.GC_Team
                },
                {
                    "GC_Formation",
                    this.GC_Formation
                },
                {
                    "GC_Mastery",
                    this.GC_Mastery
                },
                {
                    "GC_SkillType",
                    this.GC_SkillType
                },
                {
                    "GC_Wave1Skills",
                    this.GC_Wave1Skills
                },
                {
                    "GC_Wave2Skills",
                    this.GC_Wave2Skills
                },
                {
                    "GC_Wave1Loop",
                    this.GC_Wave1Loop
                },
                {
                    "GC_Wave2Loop",
                    this.GC_Wave2Loop
                },
                {
                    "AR_Enable",
                    this.AR_Enable
                },
                {
                    "AR_EnableLimit",
                    this.AR_EnableLimit
                },
                {
                    "AR_Limit",
                    this.AR_Limit
                },
                {
                    "AR_UseRuby",
                    this.AR_UseRuby
                },
                {
                    "AR_UseRubyAmount",
                    this.AR_UseRubyAmount
                },
                {
                    "AR_Mastery",
                    this.AR_Mastery
                },
                {
                    "AR_LimitArena",
                    this.AR_LimitArena
                },
                {
                    "AR_LimitScore",
                    this.AR_LimitScore
                },
                {
                    "RD_Enable",
                    this.RD_Enable
                },
                {
                    "RD_Mastery",
                    this.RD_Mastery
                },
                {
                    "RD_EnableDragonLimit",
                    this.RD_EnableDragonLimit
                },
                {
                    "RD_SkillType",
                    this.RD_SkillType
                },
                {
                    "RD_Team1Skills",
                    this.RD_Team1Skills
                },
                {
                    "RD_Team2Skills",
                    this.RD_Team2Skills
                },
                {
                    "RD_Team1Loop",
                    this.RD_Team1Loop
                },
                {
                    "RD_Team2Loop",
                    this.RD_Team2Loop
                },
                {
                    "RD_OwnerDragon",
                    this.RD_OwnerDragon
                },
                {
                    "RD_LevelCheckBox",
                    this.RD_LevelCheckBox
                },
                {
                    "RD_ReadNick",
                    this.RD_ReadNick
                },
                {
                    "RD_DragonLV",
                    this.RD_DragonLV
                },
                {
                    "RD_SummonLV",
                    this.RD_SummonLV
                },
                {
                    "RD_DragonHP",
                    this.RD_DragonHP
                },
                {
                    "RD_DragonRound",
                    this.RD_DragonRound
                },
                {
                    "RD_DragonLVLimit",
                    this.RD_DragonLVLimit
                },
                {
                    "RD_DragonHPLimit",
                    this.RD_DragonHPLimit
                },
                {
                    "ARD_Enable",
                    this.ARD_Enable
                },
                {
                    "RS_SellHeroes",
                    this.RS_SellHeroes
                },
                {
                    "RS_SellHeroStars",
                    this.RS_SellHeroStars
                },
                {
                    "RS_SellHeroAmount",
                    this.RS_SellHeroAmount
                },
                {
                    "RS_SellHeroAll",
                    this.RS_SellHeroAll
                },
                {
                    "RS_SellItems",
                    this.RS_SellItems
                },
                {
                    "RS_SellItemStars",
                    this.RS_SellItemStars
                },
                {
                    "RS_SellItemAmount",
                    this.RS_SellItemAmount
                },
                {
                    "RS_SellItemAll",
                    this.RS_SellItemAll
                },
                {
                    "RS_InboxHonors",
                    this.RS_InboxHonors
                },
                {
                    "RS_InboxKeys",
                    this.RS_InboxKeys
                },
                {
                    "RS_InboxGold",
                    this.RS_InboxGold
                },
                {
                    "RS_InboxRubies",
                    this.RS_InboxRubies
                },
                {
                    "RS_InboxTickets",
                    this.RS_InboxTickets
                },
                {
                    "RS_CollectLuckyChest",
                    this.RS_CollectLuckyChest
                },
                {
                    "RS_CollectLuckyBox",
                    this.RS_CollectLuckyBox
                },
                {
                    "RS_SpecialQuestsDaily",
                    this.RS_SpecialQuestsDaily
                },
                {
                    "RS_SpecialQuestsWeekly",
                    this.RS_SpecialQuestsWeekly
                },
                {
                    "RS_SpecialQuestsMonthly",
                    this.RS_SpecialQuestsMonthly
                },
                {
                    "RS_QuestsBattle",
                    this.RS_QuestsBattle
                },
                {
                    "RS_QuestsHero",
                    this.RS_QuestsHero
                },
                {
                    "RS_QuestsItem",
                    this.RS_QuestsItem
                },
                {
                    "RS_QuestsSocial",
                    this.RS_QuestsSocial
                },
                {
                    "RS_SendHonorsFacebook",
                    this.RS_SendHonorsFacebook
                },
                {
                    "RS_SendHonorsInGame",
                    this.RS_SendHonorsInGame
                },
                {
                    "RS_BuyKeyHonors",
                    this.RS_BuyKeyHonors
                },
                {
                    "RS_BuyKeyHonorsType",
                    this.RS_BuyKeyHonorsType
                },
                {
                    "RS_BuyKeyHonorsAmount",
                    this.RS_BuyKeyHonorsAmount
                },
                {
                    "RS_BuyKeyRubies",
                    this.RS_BuyKeyRubies
                },
                {
                    "RS_BuyKeyRubiesType",
                    this.RS_BuyKeyRubiesType
                },
                {
                    "RS_BuyKeyRubiesAmount",
                    this.RS_BuyKeyRubiesAmount
                },
                {
                    "AD_HottimeEnable",
                    this.AD_HottimeEnable
                },
                {
                    "AD_UseFriend",
                    this.AD_UseFriend
                },
                {
                    "AD_BootMode",
                    this.AD_BootMode
                },
                {
                    "GC_UseFriend",
                    this.GC_UseFriend
                },
                {
                    "SP_Enable",
                    this.SP_Enable
                },
                {
                    "SP_UseTicket1",
                    this.SP_UseTicket1
                },
                {
                    "SP_Wave1Loop",
                    this.SP_Wave1Loop
                },
                {
                    "SP_Wave2Loop",
                    this.SP_Wave2Loop
                },
                {
                    "SP_Wave3Loop",
                    this.SP_Wave3Loop
                },
                {
                    "SP_SkillType",
                    this.SP_SkillType
                },
                {
                    "SP_w2SkillType",
                    this.SP_w2SkillType
                },
                {
                    "SP_w3SkillType",
                    this.SP_w3SkillType
                },
                {
                    "SP_Wave1Skills",
                    this.SP_Wave1Skills
                },
                {
                    "SP_Wave2Skills",
                    this.SP_Wave2Skills
                },
                {
                    "SP_Wave3Skills",
                    this.SP_Wave3Skills
                },
                {
                    "SP_DailyNormal",
                    this.SP_DailyNormal
                },
                {
                    "SP_DailyHard",
                    this.SP_DailyHard
                },
                {
                    "SP_DailyHell",
                    this.SP_DailyHell
                },
                {
                    "SP_CakeEasy",
                    this.SP_CakeEasy
                },
                {
                    "SP_CakeNormal",
                    this.SP_CakeNormal
                },
                {
                    "SP_CakeHard",
                    this.SP_CakeHard
                },
                {
                    "SP_CrystalEasy",
                    this.SP_CrystalEasy
                },
                {
                    "SP_CrystalNormal",
                    this.SP_CrystalNormal
                },
                {
                    "SP_CrystalHard",
                    this.SP_CrystalHard
                },
                {
                    "SP_EvanNormal",
                    this.SP_EvanNormal
                },
                {
                    "SP_EvanHard",
                    this.SP_EvanHard
                },
                {
                    "SP_EvanHell",
                    this.SP_EvanHell
                },
                {
                    "SP_karinNormal",
                    this.SP_karinNormal
                },
                {
                    "SP_karinHard",
                    this.SP_karinHard
                },
                {
                    "SP_karinHell",
                    this.SP_karinHell
                },
                {
                    "SP_DailyEnable",
                    this.SP_DailyEnable
                },
                {
                    "SP_CakeEnable",
                    this.SP_CakeEnable
                },
                {
                    "SP_CrystalEnable",
                    this.SP_CrystalEnable
                },
                {
                    "SP_EvanEnable",
                    this.SP_EvanEnable
                },
                {
                    "SP_KarinEnable",
                    this.SP_KarinEnable
                },
                {
                    "SP_DailyLimit",
                    this.SP_DailyLimit
                },
                {
                    "SP_CakeLimit",
                    this.SP_CakeLimit
                },
                {
                    "SP_CrystalLimit",
                    this.SP_CrystalLimit
                },
                {
                    "SP_EvanLimit",
                    this.SP_EvanLimit
                },
                {
                    "SP_KarinLimit",
                    this.SP_KarinLimit
                },
                {
                    "SP_EnableLimit",
                    this.SP_EnableLimit
                },
                {
                    "SP_Limit",
                    this.SP_Limit
                },
                {
                    "ST_Stop100",
                    this.ST_Stop100
                }
            };
            string data = JsonConvert.SerializeObject(value);
            File.WriteAllText(filePath, data);
        }

        #endregion Public Methods
    }
}