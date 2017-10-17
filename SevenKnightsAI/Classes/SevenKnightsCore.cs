using RestSharp;
using SevenKnightsAI.Classes.Extensions;
using SevenKnightsAI.Classes.Imaging;
using SevenKnightsAI.Classes.Mappings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Tesseract;
using Telegram;

namespace SevenKnightsAI.Classes
{
    internal class SevenKnightsCore
    {
        #region Public Fields

        public BlueStacks BlueStacks;

        #endregion Public Fields

        #region Private Fields

        private const int COOLDOWN_INBOX = 1800000;
        private const int COOLDOWN_QUESTS = 1800000;
        private const int COOLDOWN_HERO = 900000;
        private const int COOLDOWN_SELL_HEROES = 900000;
        private const int COOLDOWN_SELL_ITEMS = 900000;
        private const int COOLDOWN_SEND_HONORS = 1800000;
        private const int HANG_FINGERPRINT_SIZE = 50;
        private const int MAX_HANG_TIME = 30000;
        private const int MAX_HERO_MANAGE_ATTEMPS = 3;
        private const int MAX_IDLE_TIME = 8000;
        private const int MAX_MAP_SELECT_TIME = 10000;
        private const int PIXEL_TOLERANCE = 2;
        private const string PUSHBULLET_TOKEN = "";
        private const int SLEEP_L = 1000;
        private const int SLEEP_M = 500;
        private const int SLEEP_S = 300;
        private const int SLEEP_XL = 2000;
        private const int SLEEP_XS = 100;
        private const int SLEEP_XXL = 3000;
        private readonly Color COLOR_ARENA = Color.Peru;
        private readonly Color COLOR_BUY_KEYS = Color.SaddleBrown;
        private readonly Color COLOR_DEATH = Color.Indigo;
        private readonly Color COLOR_HEROES_MANAGEMENT = Color.Navy;
        private readonly Color COLOR_HONOR = Color.MidnightBlue;
        private readonly Color COLOR_INBOX = Color.MediumTurquoise;
        private readonly Color COLOR_LEVEL_30 = Color.MediumPurple;
        private readonly Color COLOR_LEVEL_UP = Color.Orchid;
        private readonly Color COLOR_LIMIT = Color.Peru;
        private readonly Color COLOR_QUEST = Color.SandyBrown;
        private readonly Color COLOR_RAID = Color.RoyalBlue;
        private readonly Color COLOR_SELL_HEROES = Color.MediumVioletRed;
        private readonly Color COLOR_SELL_ITEMS = Color.SeaGreen;
        private readonly Color COLOR_WAVE = Color.RoyalBlue;

        private int AdventureCount;
        private int AdventureKeys;
        private TimeSpan AdventureKeyTime;
        private int AdventureLimitCount;
        private AIProfiles AIProfiles;
        private int ArenaKeys;
        private TimeSpan ArenaKeyTime;
        private int ArenaLimitCount;
        private int ArenaLoseCount;
        private int ArenaRubiesCount;
        private int ArenaWinCount;
        private int ArenaRank;
        private int CollectQuestsCount;
        private int CollectQuestsTotal;
        private int CooldownInbox;
        private int CooldownQuests;
        private int CooldownSellHeroes;
        private int CooldownSellItems;
        private int CooldownSendHonors;
        private int[] CurrentFingerprint;
        private Objective CurrentObjective;
        private int CurrentRaidTeam;
        private Scene CurrentScene;
        private int CurrentSequence;
        private int CurrentSequenceCount;
        private int CurrentSkill;
        private int[] CurrentSkillSet;
        private int CurrentWave;
        private bool EnableLuckyBox;
        private bool EnableRaidRewards;
        private int GoldChamberCount;
        private int GoldChamberLimitCount;
        private int GoldCount;
        private int HangCounter;
        private int HeroManageAttemps;
        private int HonorCount;
        private int IdleCounter;
        private int KeysBoughtHonors;
        private int KeysBoughtRubies;
        private bool LoopSkill;
        private int MapCheckCount;
        private int MapSelectCounter;
        private bool MasteryChecked;
        private System.Timers.Timer OneSecTimer;
        private int PressedSkill;
        private int[] PreviousFingerprint;
        private Objective PreviousObjective;
        private Scene PreviousScene;
        private SlimPushbullet Pushbullet;
        private int RaidCount;
        private int RaidLimitCount;
        private int RubyCount;
        private int HeroCount;
        private bool MaxHeroUpCount;
        private bool botError;
        private bool nomorehero30;
        private string HeroMax;
        private SynchronizationContext SynchronizationContext;
        private Tesseractor Tesseractor;
        private int TopazCount;
        private int TowerKeys;
        private TimeSpan TowerKeyTime;
        private BackgroundWorker Worker;
        private string MapZone;
        private bool Hottimeloop;
        private string PlayerName = "";
        private bool CheckPlayaName;
        private bool DragonFound;
        private int Sp_LimitCount;
        private int sp_dailycount;
        private int sp_row1count;
        private int sp_row2count;
        private int sp_row3count;
        private int sp_row4count;
        private int dragonsummoncount;
        private int dropitemcount;
        private int dropgoldcount;
        private int goldminegoldamount;
        private int goldmineentry;
        private int h30;
        private int heroreplace;
        private bool sp_dailyflag;
        private bool sp_row1flag;
        private bool sp_row2flag;
        private bool sp_row3flag;
        private bool sp_row4flag;

        #endregion Private Fields

        #region Private Properties

        private AISettings AISettings
        {
            get
            {
                return this.AIProfiles.CurrentProfile;
            }
        }

        #endregion Private Properties

        #region Public Constructors

        public SevenKnightsCore(AIProfiles profile)
        {
            this.AIProfiles = profile;
            this.Pushbullet = new SlimPushbullet("SpD0cXpZzSFuLlNBVO6Zo2wKK0jVEkZK");
            if (this.AIProfiles.ST_EnableTelegram)
            {
                bot.token = this.AIProfiles.ST_TelegramToken;
            }
            this.OneSecTimer = new System.Timers.Timer(1000.0);
            this.OneSecTimer.Elapsed += new ElapsedEventHandler(this.OnOneSecEvent);
            try
            {
                this.Tesseractor = new Tesseractor("eng");
            }
            catch (TesseractException)
            {
                MessageBox.Show("Tesseract engine could not be initialized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Tesseractor = null;
            }
        }

        #endregion Public Constructors

        #region Public Methods

        public BackgroundWorker Start(SynchronizationContext synchronizationContext)
        {
            this.SynchronizationContext = synchronizationContext;
            this.Worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this.Worker.DoWork += new DoWorkEventHandler(this.MainLoop);
            this.Worker.RunWorkerAsync();
            return this.Worker;
        }
        public void ChangeMode(Objective OBJA)
        {
            ChangeObjective(OBJA);
        }
        public void ChangeProfile()
        {
            this.AIProfiles.ToggleHotTimeProfile();
            MainForm.Instance.InvokeReloadTabs(true);
        }
        public string GetMode()
        {
            if (this.CurrentObjective == Objective.IDLE)
            {
                return "Current Objective : Idle";
            }
            else if (this.CurrentObjective == Objective.ADVENTURE)
            {
                return "Current Objective : Adventure";
            }
            else if (this.CurrentObjective == Objective.GOLD_CHAMBER)
            {
                return "Current Objective : Gold Chamber";
            }
            else if (this.CurrentObjective == Objective.ARENA)
            {
                return "Current Objective : Arena";
            }
            else if (this.CurrentObjective == Objective.RAID)
            {
                return "Current Objective : Raid";
            }
            else if (this.CurrentObjective == Objective.HERO_MANAGEMENT)
            {
                return "Current Objective : Hero Management";
            }
            else if (this.CurrentObjective == Objective.SELL_HEROES)
            {
                return "Current Objective : Sell Heroes";
            }
            else if (this.CurrentObjective == Objective.SELL_ITEMS)
            {
                return "Current Objective : Sell Items";
            }
            else if (this.CurrentObjective == Objective.BUY_KEYS)
            {
                return "Current Objective : Buy Keys";
            }
            else if (this.CurrentObjective == Objective.COLLECT_INBOX)
            {
                return "Current Objective : Collect Inbox";
            }
            else if (this.CurrentObjective == Objective.COLLECT_QUESTS)
            {
                return "Current Objective : Collect Quest";
            }
            else if (this.CurrentObjective == Objective.SEND_HONORS)
            {
                return "Current Objective : Send Honors";
            }
            else if (this.CurrentObjective == Objective.SPECIAL_DUNGEON)
            {
                return "Current Objective : Special Dungeon";
            }
            else
            {
                return "ERROR DUDE";
            }
        }

        #endregion Public Methods

        #region Private Methods

        private static void Sleep(int timeout)
        {
            Thread.Sleep(timeout);
        }

        private void AdventureAfterFight()
        {
            this.AdventureCount++;
            this.ReportCount(Objective.ADVENTURE);
            this.ProgressSequence();
            this.AdventureCheckLimits();
        }

        private void AdventureCheckLimits()
        {
            if (this.AISettings.AD_EnableLimit)
            {
                this.AdventureLimitCount++;
                if (this.AdventureLimitCount >= this.AISettings.AD_Limit)
                {
                    this.Log("Limit reached [Adventure]", this.COLOR_LIMIT);
                    SendTelegram(this.AIProfiles.ST_TelegramChatID, "Limit Reached [Adventure]");
                    this.AdventureLimitCount = 0;
                    this.NextPossibleObjective();
                }
            }
        }

        private void Alert(string message)
        {
            ProgressArgs userState = new ProgressArgs(ProgressType.Alert, message);
            this.Worker.ReportProgress(0, userState);
        }

        private void ArenaAfterFight(bool win)
        {
            if (win)
            {
                this.ArenaWinCount++;
            }
            else
            {
                this.ArenaLoseCount++;
            }
            this.ReportArenaCount();
            this.ArenaCheckLimits();
        }

        private void ArenaCheckLimits()
        {
            if (this.AISettings.AR_EnableLimit)
            {
                this.ArenaLimitCount++;
                if (this.ArenaLimitCount >= this.AISettings.AR_Limit)
                {
                    this.Log("Limit reached [Arena]", this.COLOR_LIMIT);
                    SendTelegram(this.AIProfiles.ST_TelegramChatID, "Limit Reached [Arena]");
                    this.ArenaLimitCount = 0;
                    this.NextPossibleObjective();
                }
            }
        }

        private bool ArenaUseRuby()
        {
            return this.AISettings.AR_UseRuby && this.ArenaRubiesCount < this.AISettings.AR_UseRubyAmount;
        }

        private void AssignSkillSet(bool shouldAssign, int[] skillSet)
        {
            this.CurrentSkill = 0;
            this.PressedSkill = -1;
            if (shouldAssign)
            {
                this.CurrentSkillSet = skillSet;
                return;
            }
            this.CurrentSkillSet = null;
        }

        private void BuyKeys()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                ShopPM.Key1Honor10,
                ShopPM.Key10Honor100
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                ShopPM.Key5Ruby10,
                ShopPM.Key10Ruby20,
                ShopPM.Key20Ruby35,
                ShopPM.Key40Ruby45,
                ShopPM.Key100Ruby100
            };
            this.Log("Start buying keys", this.COLOR_BUY_KEYS);
            SendTelegram(this.AIProfiles.ST_TelegramChatID,"AI will buy the keys with honors first, then with rubies.");
            this.WeightedClick(ShopPM.KeyTab, 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(500);
            Scene scene;
            while (!this.Worker.CancellationPending && !this.MatchMapping(ShopPM.KeyTabSelected, 2))
            {
                this.CaptureFrame();
                scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.SHOP)
                {
                    this.DoneBuyKeys();
                    return;
                }
                this.WeightedClick(ShopPM.KeyTab, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(500);
            }
            bool flag;
            if (this.IsBuyKeysHonors())
            {
                flag = true;
            }
            else
            {
                if (!this.IsBuyKeysRubies())
                {
                    this.Log("Nothing to buy", this.COLOR_BUY_KEYS);
                    this.DoneBuyKeys();
                    return;
                }
                flag = false;
            }
            if (flag || (!flag && this.AISettings.RS_BuyKeyRubiesType == BuyKeyRubiesType.Key5Ruby10))
            {
                for (int i = 0; i < 5; i++)
                {
                    this.ScrollShopKeys(false);
                    this.LongSleep(2000, 1000);
                    this.CaptureFrame();
                    if (this.MatchMapping(ShopPM.KeyTabLeftMost, 3))
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int j = 0; j < 5; j++)
                {
                    this.ScrollShopKeys(true);
                    this.LongSleep(2000, 1000);
                    this.CaptureFrame();
                    if (this.MatchMapping(ShopPM.KeyTabRightMost, 3))
                    {
                        break;
                    }
                }
            }
            SevenKnightsCore.Sleep(700);
            PixelMapping mapping;
            if (flag)
            {
                int rS_BuyKeyHonorsType = (int)this.AISettings.RS_BuyKeyHonorsType;
                mapping = array[rS_BuyKeyHonorsType];
                this.Log(string.Format("Buy with honors ({0})", this.KeysBoughtHonors + 1), this.COLOR_BUY_KEYS);
                SevenKnightsCore.Sleep(700);
                this.KeysBoughtHonors++;
            }
            else
            {
                int rS_BuyKeyRubiesType = (int)this.AISettings.RS_BuyKeyRubiesType;
                mapping = array2[rS_BuyKeyRubiesType];
                this.Log(string.Format("Buy with rubies ({0})", this.KeysBoughtRubies + 1), this.COLOR_BUY_KEYS);
                SevenKnightsCore.Sleep(700);
                this.KeysBoughtRubies++;
            }
            this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(700);
            this.CaptureFrame();
            scene = this.SceneSearch();
            if (scene != null && scene.SceneType == SceneType.SHOP_BUY_FAILED_POPUP)
            {
                string text = string.Format("Unable to buy keys using {0}", flag ? "honors" : "rubies");
                this.Log(text, this.COLOR_BUY_KEYS);
                SendTelegram(this.AIProfiles.ST_TelegramChatID,"Failed to buy keys "+ text + ".");
                string errormessages = "Failed to buy keys " + text + " .";
                SendTelegram(this.AIProfiles.ST_TelegramChatID, errormessages);
            }
            if (scene != null && scene.SceneType != SceneType.SHOP_BUY_POPUP)
            {
                this.DoneBuyKeys();
                return;
            }
            this.WeightedClick(ShopBuyPopupPM.BuyButton, 1.0, 1.0, 1, 0, "left");
            this.LongSleep(2000, 1000);
            this.CaptureFrame();
            scene = this.SceneSearch();
            if (scene != null && scene.SceneType != SceneType.SHOP_PURCHASE_COMPLETE_POPUP)
            {
                this.DoneBuyKeys();
                return;
            }
            this.Log("Keys bought", this.COLOR_BUY_KEYS);
            this.WeightedClick(ShopPurchaseCompletePopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(500);
            this.DoneBuyKeys();
        }

        private void CancelAllSkills(bool towerFight = false)
        {
            PixelMapping[] array = this.CreateSkillMappings();
            PixelMapping[][] array2 = this.CreateQueueMappingSet(towerFight);
            for (int i = 0; i < array2.Length; i++)
            {
                PixelMapping[] array3 = array2[i];
                if (this.MatchMapping(array3[0], 4) && this.MatchMapping(array3[1], 4))
                {
                    this.WeightedClick(array[i], 1.0, 1.0, 1, 0, "left");
                }
            }
        }

        private Bitmap CaptureFrame()
        {
            bool sT_ForegroundMode = this.AIProfiles.ST_ForegroundMode;
            return this.BlueStacks.CaptureFrame(!sT_ForegroundMode);
        }

        private void ChangeCurrentRaidTeam(int team)
        {
            this.CurrentRaidTeam = team;
            this.Log("@ Team " + team, this.COLOR_RAID);
        }

        private void ChangeCurrentWave(int wave)
        {
            this.CurrentWave = wave;
            this.Log("@ Wave " + wave, this.COLOR_WAVE);
        }

        private void ChangeObjective(Objective objective)
        {
            string message = string.Empty;
            switch (objective)
            {
                case Objective.IDLE:
                    message = "Idle";
                    break;

                case Objective.ADVENTURE:
                    message = "Adventure";
                    break;

                case Objective.GOLD_CHAMBER:
                    message = "Gold Chamber";
                    break;

                case Objective.SPECIAL_DUNGEON:
                    message = "Special Dungeon";
                    break;

                case Objective.ARENA:
                    message = "Arena";
                    break;

                case Objective.RAID:
                    message = "Raid";
                    break;

                case Objective.HERO_MANAGEMENT:
                    message = "Hero Management";
                    break;

                case Objective.SELL_HEROES:
                    message = "Sell Heroes";
                    break;

                case Objective.SELL_ITEMS:
                    message = "Sell Items";
                    break;

                case Objective.BUY_KEYS:
                    message = "Buy Keys";
                    break;

                case Objective.COLLECT_INBOX:
                    message = "Collect Inbox";
                    break;

                case Objective.COLLECT_QUESTS:
                    message = "Collect Quests";
                    break;

                case Objective.SEND_HONORS:
                    message = "Send Honors";
                    break;
            }
            this.PreviousObjective = this.CurrentObjective;
            this.CurrentObjective = objective;
            this.Worker.ReportProgress(0, new ProgressArgs(ProgressType.OBJECTIVE, message));
        }

        private bool CheckMapNumber(World world, int stage)
        {
            if (world == World.None)
            {
                return true;
            }
            int num = world - World.Sequencer;
            int num2 = stage + 1;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, AdventureStartPM.R_MapNumber).ScaleByPercent(128))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("o", "0");
                    Utility.FilterAscii(text);
#if DEBUG
                    Console.WriteLine("MapNumber = " + text.Trim());
                    bitmap.Save("MapNumber.png");
#endif
                    if (text.Length >= 2)
                    {
                        int num3 = -1;
                        int num4 = -1;
                        string[] array = text.Split(new char[]
                        {
                            '-'
                        });
                        if (array.Length < 2)
                        {
                            bool result = false;
                            return result;
                        }
                        int.TryParse(array[0], out num3);
                        int.TryParse(array[1], out num4);
                        if (num3 == num && num4 == num2)
                        {
                            bool result = true;
                            return result;
                        }
                    }
                }
            }
            return false;
        }

        private bool CheckMastery(SceneType sceneType)
        {
            if (!this.MasteryChecked && !this.IsSelectedMastery(sceneType))
            {
                if (sceneType == SceneType.LOBBY)
                {
                    this.WeightedClick(LobbyPM.MasteryButton, 1.0, 1.0, 1, 0, "left");
                }
                else if (sceneType == SceneType.ARENA_START)
                {
                    this.WeightedClick(ArenaStartPM.MasteryButton, 1.0, 1.0, 1, 0, "left");
                }
                else
                {
                    this.WeightedClick(SharedPM.PrepareFight_MasteryButton, 1.0, 1.0, 1, 0, "left");
                }
                return true;
            }
            return false;
        }

        private void ClickDrag(int startX, int startY, int endX, int endY)
        {
            this.BlueStacks.MainWindowAS.ClickDrag(startX, startY, endX, endY, 0, "left");
        }

        private void CollectInbox()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                InboxPM.HonorsTab,
                InboxPM.KeysTab,
                InboxPM.CurrencyTab,
                InboxPM.MaterialTab
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                InboxPM.HonorsTabRedIcon,
                InboxPM.KeysTabRedIcon,
                InboxPM.CurrencyTabRedIcon,
                InboxPM.MaterialTabRedIcon
            };
            string[] array3 = new string[]
            {
                "Honors",
                "Keys",
                "Currency",
                "Material"
            };
            bool[] array4 = new bool[]
            {
                this.AISettings.RS_InboxHonors, //honor
                this.AISettings.RS_InboxKeys, //key
                this.AISettings.RS_InboxGold,// currency
                this.AISettings.RS_InboxRubies //material
            };
            this.Log("Start collecting inbox", this.COLOR_INBOX);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI is collecting your inbox.");
            List<int> list = new List<int>();
            for (int i = 0; i < array2.Length; i++)
            {
                if (this.MatchMapping(array2[i], 4) && array4[i])
                {
                    list.Add(i);
                }
            }
            foreach (int current in list)
            {
                this.Log(string.Format("- Got Tab: {0}", array3[current]), this.COLOR_INBOX);
            }
            if (list.Count <= 0)
            {
                this.Log("Nothing to collect", this.COLOR_INBOX);
                this.DoneCollectInbox();
                return;
            }
            foreach (int current2 in list)
            {
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                SevenKnightsCore.Sleep(500);
                this.Log(string.Format("Collecting {0}", array3[current2]), this.COLOR_INBOX);
                PixelMapping mapping = array[current2];
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.INBOX)
                {
                    this.DoneCollectInbox();
                    return;
                }
                if (current2 == 4)
                {
                    while (!this.Worker.CancellationPending)
                    {
                        this.CaptureFrame();
                        scene = this.SceneSearch();
                        if (scene != null && scene.SceneType != SceneType.INBOX)
                        {
                            this.DoneCollectInbox();
                            return;
                        }
                        if (!this.MatchMapping(InboxPM.AttachCollectButtonBackground, 4))
                        {
                            this.DoneCollectInbox();
                            return;
                        }
                        this.WeightedClick(InboxPM.AttachCollectButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(1000);
                        if (!this.HandleInboxCollected(current2))
                        {
                            this.DoneCollectInbox();
                            return;
                        }
                        SevenKnightsCore.Sleep(500);
                    }
                }
                else if (this.MatchMapping(InboxPM.CollectAllButtonBackground, 4))
                {
                    this.WeightedClick(InboxPM.CollectAllButton, 1.0, 1.0, 1, 0, "left");
                    this.LongSleep(1000, 1000);
                    if (!this.HandleInboxCollected(current2))
                    {
                        SevenKnightsCore.Sleep(300);
                        this.Escape();
                    }
                }
                else
                {
                    SevenKnightsCore.Sleep(300);
                    this.Escape();
                }
            }
            this.DoneCollectInbox();
        }

        private void CollectQuests()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                QuestPM.BattleTab,
                QuestPM.HeroTab,
                QuestPM.ItemTab,
                QuestPM.SocialTab
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                QuestPM.BattleAvailable,
                QuestPM.HeroAvailable,
                QuestPM.ItemAvailable,
                QuestPM.SocialAvailable
            };
            string[] array3 = new string[]
            {
                "Battle",
                "Hero",
                "Item",
                "Social"
            };
            bool[] array4 = new bool[]
            {
                this.AISettings.RS_QuestsBattle,
                this.AISettings.RS_QuestsHero,
                this.AISettings.RS_QuestsItem,
                this.AISettings.RS_QuestsSocial
            };
            this.Log("Start collecting quests", this.COLOR_QUEST);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI is collecting quests.");
            List<int> list = new List<int>();
            for (int i = 0; i < array2.Length; i++)
            {
                if (this.MatchMapping(array2[i], 4) && array4[i])
                {
                    list.Add(i);
                }
            }
            foreach (int current in list)
            {
                this.Log(string.Format("- Got Tab: {0}", array3[current]), this.COLOR_QUEST);
            }
            if (list.Count <= 0)
            {
                this.Log("Nothing to collect", this.COLOR_QUEST);
                this.DoneCollectQuests();
                return;
            }
            foreach (int current2 in list)
            {
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                SevenKnightsCore.Sleep(500);
                this.Log(string.Format("Collecting {0} quest", array3[current2]), this.COLOR_QUEST);
                PixelMapping mapping = array[current2];
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.QUEST)
                {
                    this.DoneCollectQuests();
                    return;
                }
                if (this.MatchMapping(QuestPM.CollectAllButtonBackground, 4))
                {
                    this.WeightedClick(QuestPM.CollectAllButton, 1.0, 1.0, 1, 0, "left");
                    this.LongSleep(1000, 1000);
                    while (!this.Worker.CancellationPending && this.MatchMapping(QuestPM.CollectAllButtonBackground, 4))
                    {
                        this.CaptureFrame();
                        SevenKnightsCore.Sleep(500);
                    }
                    SevenKnightsCore.Sleep(1000);
                    this.CaptureFrame();
                    scene = this.SceneSearch();
                    if (scene == null || scene.SceneType != SceneType.QUEST_REWARDS_POPUP || scene.SceneType != SceneType.LOOT_HERO || scene.SceneType != SceneType.LOOT_ITEM)
                    {
                        SevenKnightsCore.Sleep(300);
                        this.Escape();
                    }
                }
            }
            this.DoneCollectQuests();
        }

        private void CollectSpecialQuests()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                SpecialQuestPM.DailyTab,
                SpecialQuestPM.WeeklyTab,
                SpecialQuestPM.MonthlyTab
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                SpecialQuestPM.DailyAvailable,
                SpecialQuestPM.WeeklyAvailable,
                SpecialQuestPM.MonthlyAvailable
            };
            string[] array3 = new string[]
            {
                "Daily",
                "Weekly",
                "Monthly"
            };
            bool[] array4 = new bool[]
            {
                this.AISettings.RS_SpecialQuestsDaily,
                this.AISettings.RS_SpecialQuestsWeekly,
                this.AISettings.RS_SpecialQuestsMonthly
            };
            this.Log("Start collecting special quests", this.COLOR_QUEST);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI is collecting special quests.");
            List<int> list = new List<int>();
            for (int i = 0; i < array2.Length; i++)
            {
                if (this.MatchMapping(array2[i], 4) && array4[i])
                {
                    list.Add(i);
                }
            }
            foreach (int current in list)
            {
                this.Log(string.Format("- Got Tab: {0}", array3[current]), this.COLOR_QUEST);
            }
            if (list.Count <= 0)
            {
                this.Log("Nothing to collect", this.COLOR_QUEST);
                this.DoneCollectSpecialQuests();
                return;
            }
            foreach (int current2 in list)
            {
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                SevenKnightsCore.Sleep(500);
                this.Log(string.Format("Collecting {0} quest", array3[current2]), this.COLOR_QUEST);
                PixelMapping mapping = array[current2];
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.SPECIAL_QUEST)
                {
                    this.DoneCollectSpecialQuests();
                    return;
                }
                while (!this.Worker.CancellationPending)
                {
                    this.CaptureFrame();
                    scene = this.SceneSearch();
                    if (scene != null && scene.SceneType != SceneType.SPECIAL_QUEST)
                    {
                        this.DoneCollectSpecialQuests();
                        return;
                    }
                    if (!this.MatchMapping(SpecialQuestPM.CollectButtonBackground, 4))
                    {
                        break;
                    }
                    this.WeightedClick(SpecialQuestPM.CollectButton, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(500);
                    if (!this.HandleSpecialQuestsCollected(current2))
                    {
                        break;
                    }
                    SevenKnightsCore.Sleep(500);
                }
                this.CaptureFrame();
                scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.SPECIAL_QUEST)
                {
                    this.DoneCollectSpecialQuests();
                    return;
                }
                if (this.MatchMapping(SpecialQuestPM.CollectMainButtonBackground, 4))
                {
                    this.WeightedClick(SpecialQuestPM.CollectMainButton, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(1000);
                    if (!this.HandleSpecialQuestsCollected(current2))
                    {
                        SevenKnightsCore.Sleep(300);
                        this.Escape();
                    }
                }
            }
            this.DoneCollectSpecialQuests();
        }

        private void CreateHangFingerprint(int[] array)
        {
            if (array.Length < 50)
            {
                throw new Exception("Invalid array size");
            }
            Point[] array2 = new Point[]
            {
                new Point(188, 38),
                new Point(373, 42),
                new Point(662, 40),
                new Point(158, 381),
                new Point(317, 364),
                new Point(480, 377),
                new Point(645, 357),
                new Point(799, 348),
                new Point(203, 17),
                new Point(677, 17),
                new Point(184, 14),
                new Point(362, 12),
                new Point(653, 10),
                new Point(547, 68),
                new Point(711, 65),
                new Point(889, 66),
                new Point(510, 83),
                new Point(601, 82),
                new Point(714, 79),
                new Point(855, 85),
                new Point(478, 530),
                new Point(248, 528),
                new Point(572, 424),
                new Point(587, 507),
                new Point(671, 427),
                new Point(660, 504),
                new Point(746, 495),
                new Point(766, 416),
                new Point(836, 426),
                new Point(836, 493),
                new Point(919, 491),
                new Point(941, 399),
                new Point(120, 498),
                new Point(43, 489),
                new Point(32, 512),
                new Point(426, 26),
                new Point(506, 27),
                new Point(543, 24),
                new Point(560, 26),
                new Point(868, 26),
                new Point(710, 528),
                new Point(294, 123),
                new Point(303, 124),
                new Point(437, 40),
                new Point(463, 41),
                new Point(606, 94),
                new Point(680, 85),
                new Point(765, 95),
                new Point(815, 87),
                new Point(891, 90)
            };
            for (int i = 0; i < 50; i++)
            {
                array[i] = this.GetPixel(array2[i].X, array2[i].Y);
            }
        }

        private PixelMapping[][] CreateQueueMappingSet(bool towerFight = false)
        {
            PixelMapping[][] result;
            if (towerFight)
            {
                   result = new PixelMapping[][]
                   {
                       new PixelMapping[]
                       {
                           TowerFightPM.Skill1_Q1_1,
                           TowerFightPM.Skill1_Q1_2
                       },
                       new PixelMapping[]
                       {
                           TowerFightPM.Skill2_Q1_1,
                           TowerFightPM.Skill2_Q1_2
                       },
                       new PixelMapping[]
                       {
                           TowerFightPM.Skill3_Q1_1,
                           TowerFightPM.Skill3_Q1_2
                       },
                       new PixelMapping[]
                       {
                           TowerFightPM.Skill4_Q1_1,
                           TowerFightPM.Skill4_Q1_2
                       },
                       new PixelMapping[]
                       {
                           TowerFightPM.Skill5_Q1_1,
                           TowerFightPM.Skill5_Q1_2
                       },
                       new PixelMapping[]
                       {
                           TowerFightPM.Skill6_Q1_1,
                           TowerFightPM.Skill6_Q1_2
                       },
                       new PixelMapping[]
                       {
                           TowerFightPM.Skill7_Q1_1,
                           TowerFightPM.Skill7_Q1_2
                       },
                       new PixelMapping[]
                       {
                           TowerFightPM.Skill8_Q1_1,
                           TowerFightPM.Skill8_Q1_2
                       },
                       new PixelMapping[]
                       {
                           TowerFightPM.Skill9_Q1_1,
                           TowerFightPM.Skill9_Q1_2
                       },
                       new PixelMapping[]
                       {
                           TowerFightPM.Skill10_Q1_1,
                           TowerFightPM.Skill10_Q1_2
                       },
                       new PixelMapping[]
                       {
                            SharedPM.Fight_Skill11_Q1_1,
                            SharedPM.Fight_Skill11_Q1_2
                       },
                       new PixelMapping[]
                       {
                            SharedPM.Fight_Skill12_Q1_1,
                            SharedPM.Fight_Skill12_Q1_2
                       },
                       new PixelMapping[]
                       {
                            SharedPM.Fight_Skill13_Q1_1,
                            SharedPM.Fight_Skill13_Q1_2
                       },
                       new PixelMapping[]
                       {
                            SharedPM.Fight_Skill14_Q1_1,
                            SharedPM.Fight_Skill14_Q1_2
                       },
                       new PixelMapping[]
                       {
                            SharedPM.Fight_Skill15_Q1_1,
                            SharedPM.Fight_Skill15_Q1_2
                       }
                   };   
            }
            else
            {
                result = new PixelMapping[][]
                {
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill1_Q1_1,
                        SharedPM.Fight_Skill1_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill2_Q1_1,
                        SharedPM.Fight_Skill2_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill3_Q1_1,
                        SharedPM.Fight_Skill3_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill4_Q1_1,
                        SharedPM.Fight_Skill4_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill5_Q1_1,
                        SharedPM.Fight_Skill5_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill6_Q1_1,
                        SharedPM.Fight_Skill6_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill7_Q1_1,
                        SharedPM.Fight_Skill7_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill8_Q1_1,
                        SharedPM.Fight_Skill8_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill9_Q1_1,
                        SharedPM.Fight_Skill9_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill10_Q1_1,
                        SharedPM.Fight_Skill10_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill11_Q1_1,
                        SharedPM.Fight_Skill11_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill12_Q1_1,
                        SharedPM.Fight_Skill12_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill13_Q1_1,
                        SharedPM.Fight_Skill13_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill14_Q1_1,
                        SharedPM.Fight_Skill14_Q1_2
                    },
                    new PixelMapping[]
                    {
                        SharedPM.Fight_Skill15_Q1_1,
                        SharedPM.Fight_Skill15_Q1_2
                    }
                };
            }
            return result;
        }

        private PixelMapping[] CreateSkillMappings()
        {
            return new PixelMapping[]
            {
                SharedPM.Fight_Skill1,
                SharedPM.Fight_Skill2,
                SharedPM.Fight_Skill3,
                SharedPM.Fight_Skill4,
                SharedPM.Fight_Skill5,
                SharedPM.Fight_Skill6,
                SharedPM.Fight_Skill7,
                SharedPM.Fight_Skill8,
                SharedPM.Fight_Skill9,
                SharedPM.Fight_Skill10,
                SharedPM.Fight_Skill11,
                SharedPM.Fight_Skill12,
                SharedPM.Fight_Skill13,
                SharedPM.Fight_Skill14,
                SharedPM.Fight_Skill15
            };
        }

        private string CheckOwnername()
        {
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, LobbyPM.OwnerLocation))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText();
#if DEBUG
                    Console.WriteLine("Name = " + text.Trim());
                    bitmap.Save("Name.png");
#endif
                    Utility.FilterAscii(text);
                    if (text != "")
                    {
                        PlayerName = text.Trim();
                        this.Log("Owner Name = " + PlayerName, Color.BlueViolet);
                    }
                    else
                    {
                        PlayerName = "NULL";
                    }
                }
#if DEBUG
                Console.WriteLine("Owner Name = " + PlayerName);
#endif
                return PlayerName;
            }
        }

        private void CheckArenaScore()
        {
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, ArenaEndPM.ArenaScore))
            {
                int arenaScore = 0;
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
#if DEBUG
                    bitmap.Save("ArenaScore2.png");
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                    Utility.FilterAscii(test1);
                    int.TryParse(test1, out arenaScore);
                    this.Log(string.Format("Arena Score = {0}", arenaScore), this.COLOR_ARENA);
                    ArenaRank = arenaScore;
                    if (this.AISettings.AR_LimitArena)
                    {
                        if (arenaScore >= this.AISettings.AR_LimitScore)
                        {
                            SevenKnightsCore.Sleep(800);
                            this.NextPossibleObjective();
                            this.Log(string.Format("Arena Score Limit"), Color.BlueViolet);
                        }
                    }
                }
            }
        }

        private void CalculateGoldMine()
        {
            /*
        using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, TowerSelectPM.GoldMineCalc))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("o", "0").Trim().Replace(" ", "");
                    Utility.FilterAscii(text);
            if (text.Length >= 2)
            {
                int gold = 0;
                int entry = 0;
                int total = 0;
                string[] array = text.Split(new char[]
                    {
                                'x'
                    });

                if (array.Length >= 1)
                    int.TryParse(array[0], out gold);
                if (array.Length >= 2)
                    int.TryParse(array[1].Substring(0, 1), out entry);
                        //calculate
                        total = gold * entry;
#if DEBUG
                this.Log(string.Format("Gold/Entry: {0}/{1} Total: {2}", gold, entry, total));
#endif
            }         
        }
    } */
            int a = 0;
            int b = 0;
            int c = 0;
            //int total = 0;
        //get gold mine gold amount
        using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, TowerSelectPM.GoldMineGoldAmount))
        {
            using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
            {
                string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                    .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                    .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                    .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
                    Utility.FilterAscii(text);
#if DEBUG
                    bitmap.Save("GoldMineGoldAmount.png");
                    this.Log("GoldMineGold Text = " + text.Trim());
#endif
                string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                int.TryParse(test1, out a);
                this.Log(string.Format("Gold Mine Gold Amount = {0}", a), this.COLOR_ARENA);
            }
        }
        //get gold mine entry available
        using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, TowerSelectPM.GoldMineAvailable))
        {
            using (Page page = this.Tesseractor.Engine.Process(bitmap, null, PageSegMode.SingleChar))
            {
                string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                    .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                    .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                    .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
                    Utility.FilterAscii(text);
#if DEBUG
                    bitmap.Save("GoldMineAvailable.png");
                    this.Log("GoldMineGold Text = " + text.Trim());
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                int.TryParse(test1, out b);
                this.Log(string.Format("Gold Mine Gold Amount = {0}", b), this.COLOR_ARENA);
            }
        }

            //calculate
            c = a* b;
            goldminegoldamount += c;
            goldmineentry += b;
            this.Log(string.Format("Total Gold Collected = {0}", c), this.COLOR_ARENA);
        }

        private void CheckArenaScoreReady()
        {
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, ArenaReadyPM.ArenaScore))
            {
                int arenaScore = 0;
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
#if DEBUG
                    bitmap.Save("ArenaScore1.png");
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                    Utility.FilterAscii(test1);
                    int.TryParse(test1, out arenaScore);
                    this.Log(string.Format("Arena Score = {0}", arenaScore), this.COLOR_ARENA);
                    ArenaRank = arenaScore;
                    if(this.AISettings.AR_LimitArena)
                    {
                        if (arenaScore >= this.AISettings.AR_LimitScore)
                        {
                            SevenKnightsCore.Sleep(800);
                            this.NextPossibleObjective();
                            this.Log(string.Format("Arena Score Limit"), Color.BlueViolet);
                        }
                    }
                    
                }
            }
        }

        private string CheckDragonNameUpToDown(int location) //หามังกรหลายตำแหน่งจาก บน ลง ล่าง
        {
            //string DragonN = "";
            Rectangle[] array = new Rectangle[]
            {
                RaidLobbyPM.RaidNameUpToDownL0,
                RaidLobbyPM.RaidNameUpToDownL1,
                RaidLobbyPM.RaidNameUpToDownL2,
                RaidLobbyPM.RaidNameUpToDownL3
            };
            Rectangle rect = array[location];
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, LobbyPM.OwnerLocation))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText();
#if DEBUG
                    Console.WriteLine("Name = " + text.Trim());
                    bitmap.Save("Name.png");
#endif
                    Utility.FilterAscii(text);
                    if (text != "")
                    {
                        PlayerName = text.Trim();
                    }
                    else
                    {
                        PlayerName = "NULL";
                    }
                }
#if DEBUG
                Console.WriteLine("Owner Name = " + PlayerName);
#endif
                return PlayerName;
            }

        }

        private string CheckDragonNameDownToUp(int location) //หามังกรหลายตำแหน่งจาก ล่าง ขึ้น บน
        {
            string DragonN = "";
            Rectangle[] array = new Rectangle[]
            {
                RaidLobbyPM.RaidNameDownToUpL0,
                RaidLobbyPM.RaidNameDownToUpL1,
                RaidLobbyPM.RaidNameDownToUpL2,
                RaidLobbyPM.RaidNameDownToUpL3
            };
            Rectangle rect = array[location];
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText();
#if DEBUG
                            Console.WriteLine("DName = " + text.Trim().Replace(" ", ""));
                            bitmap.Save("DName.png");
#endif
                    Utility.FilterAscii(text);
                    DragonN = text.Trim();
                }
#if DEBUG
                        Console.WriteLine("DName = " + DragonN);
#endif
                return DragonN;
            }

        }

        private string OwnerDragonName()  // หาชื่อมังกรตำแหน่งแรกตำแหน่งเดียว
        {
            string DragonN = "";
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, RaidLobbyPM.RaidNameUpToDownL0))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText();

#if DEBUG
                    Console.WriteLine("DName = " + text.Trim().Replace(" ", ""));
                    bitmap.Save("DName.png");
#endif
                    Utility.FilterAscii(text);
                    DragonN = text.Trim();
                }
                return DragonN;
            }
        }

        private int CheckDragonLvlUpToDown(int location) //หา Level มังกรหลายตำแหน่งจาก บน ลงล่าง
        {
            int Dragonlvl;
            Rectangle[] array = new Rectangle[]
            {
                RaidLobbyPM.RaidLvlUpToDownL0,
                RaidLobbyPM.RaidLvlUpToDownL1,
                RaidLobbyPM.RaidLvlUpToDownL2,
                RaidLobbyPM.RaidLvlUpToDownL3
            };
            Rectangle rect = array[location];
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace(".", "").Replace(" ", "").Replace("s", "5").Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "");
#if DEBUG
                    Console.WriteLine("LV text = " + text.Trim());
                    bitmap.Save("Dragon.png");
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                    Utility.FilterAscii(test1);
                    int.TryParse(test1, out Dragonlvl);
                    if (Dragonlvl != 0)
                    {
                        return Dragonlvl;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }

        private int CheckDragonLvlDownToUp(int location) //หา Level มังกรหลายตำแหน่งจากล่าง ขึ้นบน
        {
            int Dragonlvl;
            Rectangle[] array = new Rectangle[]
            {
                RaidLobbyPM.RaidLvlDownToUpL0,
                RaidLobbyPM.RaidLvlDownToUpL1,
                RaidLobbyPM.RaidLvlDownToUpL2,
                RaidLobbyPM.RaidLvlDownToUpL3
            };
            Rectangle rect = array[location];
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace(".", "").Replace(" ", "").Replace("s", "5").Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "");
#if DEBUG
                    Console.WriteLine("LV text = " + text.Trim());
                    bitmap.Save("Dragon.png");
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                    Utility.FilterAscii(test1);
                    int.TryParse(test1, out Dragonlvl);
                    if (Dragonlvl != 0)
                    {
                        return Dragonlvl;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }

        private int CheckHPUpToDownF(int location) //หา Level มังกรหลายตำแหน่งจากล่าง ขึ้นบน
        {
            int RaidHP;
            Rectangle[] array = new Rectangle[]
            {
                RaidLobbyPM.RaidHPUpToDownL0F,
                RaidLobbyPM.RaidHPUpToDownL1F,
                RaidLobbyPM.RaidHPUpToDownL2F,
                RaidLobbyPM.RaidHPUpToDownL3F
            };
            Rectangle rect = array[location];
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(300))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
#if DEBUG
                    this.Log("HPFUp2Down text = " + text.Trim());
                    Console.WriteLine("HPFUP2Down text = " + text.Trim());
                    bitmap.Save("HPFUP2Down.png");
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                    Utility.FilterAscii(test1);
                    int.TryParse(test1, out RaidHP);
                    if (RaidHP != 0)
                    {
                        return RaidHP;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }

        private int CheckHPUpToDownB(int location) //หา Level มังกรหลายตำแหน่งจากล่าง ขึ้นบน
        {
            int RaidHP;
            Rectangle[] array = new Rectangle[]
            {
                RaidLobbyPM.RaidHPUpToDownL0B,
                RaidLobbyPM.RaidHPUpToDownL1B,
                RaidLobbyPM.RaidHPUpToDownL2B,
                RaidLobbyPM.RaidHPUpToDownL3B
            };
            Rectangle rect = array[location];
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(300))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
#if DEBUG
                    this.Log("HPFUp2Down text = " + text.Trim());
                    Console.WriteLine("HPBUp2Down text = " + text.Trim());
                    bitmap.Save("HPBUp2Down.png");
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                    Utility.FilterAscii(test1);
                    int.TryParse(test1, out RaidHP);
                    if (RaidHP != 0)
                    {
                        return RaidHP;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }

        private int CheckHPDownToUpF(int location) //หา Level มังกรหลายตำแหน่งจากล่าง ขึ้นบน
        {
            int RaidHP;
            Rectangle[] array = new Rectangle[]
            {
                RaidLobbyPM.RaidHPDownToUpL0F,
                RaidLobbyPM.RaidHPDownToUpL1F,
                RaidLobbyPM.RaidHPDownToUpL2F,
                RaidLobbyPM.RaidHPDownToUpL3F
            };
            Rectangle rect = array[location];
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(300))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
#if DEBUG
                    this.Log("HPFDown2Up text = " + text.Trim());
                    Console.WriteLine("HPFDown2Up text = " + text.Trim());
                    bitmap.Save("HPFDown2Up.png");
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                    Utility.FilterAscii(test1);
                    int.TryParse(test1, out RaidHP);
                    if (RaidHP != 0)
                    {
                        return RaidHP;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }

        private int CheckHPDownToUpB(int location) //หา Level มังกรหลายตำแหน่งจากล่าง ขึ้นบน
        {
            int RaidHP;
            Rectangle[] array = new Rectangle[]
            {
                RaidLobbyPM.RaidHPDownToUpL0B,
                RaidLobbyPM.RaidHPDownToUpL1B,
                RaidLobbyPM.RaidHPDownToUpL2B,
                RaidLobbyPM.RaidHPDownToUpL3B
            };
            Rectangle rect = array[location];
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(300))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
#if DEBUG
                    this.Log("HPFDown2Up text = " + text.Trim());
                    Console.WriteLine("HPBDown2Up text = " + text.Trim());
                    bitmap.Save("HPBDown2Up.png");
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                    Utility.FilterAscii(test1);
                    if (test1.Length >= 2)
                    {
                        int.TryParse(test1, out RaidHP);
                        return RaidHP;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }

        private void ScrollRaidDragonPage(bool down = true)
        {
            int num = 198;
            PixelMapping pixelMapping = down ? SpecialDungeonReady.ScrollAreaDown : SpecialDungeonReady.ScrollAreaUp;
            int num2 = down ? (-num) : num;
            this.ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X, pixelMapping.Y + num2);
        }

        private Bitmap CropFrame(Bitmap frame, Rectangle rect)
        {
            rect.X += BlueStacks.OFFSET_X;
            rect.Y += BlueStacks.OFFSET_Y;
            return frame.Clone(rect, frame.PixelFormat);
        }

        private void DoneBuyKeys()
        {
            this.Log("Done buying keys", this.COLOR_BUY_KEYS);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has finished buying keys.");
            this.NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneCollectAllQuests()
        {
            if (this.CollectQuestsTotal >= 1)
            {
                this.Log("Done collecting all quests", this.COLOR_QUEST);
            }
            this.CollectQuestsCount = -1;
            this.CollectQuestsTotal = -1;
            this.NextPossibleObjective();
        }

        private void DoneCollectInbox()
        {
            this.Log("Done collecting inbox", this.COLOR_INBOX);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has finished collecting your inbox.");
            this.NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneCollectQuests()
        {
            this.Log("Done collecting quests", this.COLOR_QUEST);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has finished collecting quests.");
            this.CollectQuestsCount++;
            if (this.CollectQuestsCount == this.CollectQuestsTotal)
            {
                this.DoneCollectAllQuests();
            }
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(500);
        }

        private void DoneCollectSpecialQuests()
        {
            this.Log("Done collecting special quests", this.COLOR_QUEST);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has finished collecting special quests.");
            this.CollectQuestsCount++;
            if (this.CollectQuestsCount == this.CollectQuestsTotal)
            {
                this.DoneCollectAllQuests();
            }
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(500);
        }


        private void DoneManageHeroes()

        {

            this.Log("Done managing heroes", this.COLOR_HEROES_MANAGEMENT);


            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has finished managing your team.");
            String message = String.Format("Replaced {0} Hero", heroreplace);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, message);
            this.heroreplace = 0;

            this.HeroManageAttemps = 0;

            this.NextPossibleObjective();

            SevenKnightsCore.Sleep(500);

            this.Escape();

            SevenKnightsCore.Sleep(500);

        }



        private void DoneRaid()
        {
            this.EnableRaidRewards = false;
            if (this.CurrentObjective == Objective.RAID && (this.PreviousObjective == Objective.ADVENTURE || this.PreviousObjective == Objective.GOLD_CHAMBER))
            {
                this.ChangeObjective(Objective.HERO_MANAGEMENT);
            }
            else
            {
                this.NextPossibleObjective();
            }
            this.Escape();
            if (this.CurrentObjective == Objective.RAID)
            {
                this.CurrentObjective = Objective.IDLE;
            }
        }

        private void DoneSellHeroes(int sellCount)
        {
            this.Log("Done selling heroes", this.COLOR_SELL_HEROES);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has finished selling your heroes.");
            if (sellCount == 0)
            {
                this.Log("No more heroes that satisfied the conditions", this.COLOR_SELL_HEROES);
                this.CooldownSellHeroes = 900000;
            }
            this.NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneSellHeroesMini()
        {
            SevenKnightsCore.Sleep(1000);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneSellItems(int sellCount)
        {
            this.Log("Done selling items", this.COLOR_SELL_ITEMS);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has finished selling your items.");
            if (sellCount == 0)
            {
                this.Log("No more items that satisfied the conditions", this.COLOR_SELL_ITEMS);
                this.CooldownSellItems = 900000;
            }
            this.NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneSendHonors()
        {
            this.Log("Done sending honors", this.COLOR_HONOR);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has finished selling your heroes.");
            this.NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(500);
        }

        private void DoneHottime()
        {
            SevenKnightsCore.Sleep(800);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void Escape()
        {
            this.BlueStacks.MainWindowAS.PressKey(27u, 1, 0);
        }

        private bool ExpectedFightScene(SceneType sceneType)
        {
            if (this.PreviousScene == null)
            {
                return true;
            }
            SceneType sceneType2 = this.PreviousScene.SceneType;
            if (sceneType <= SceneType.TOWER_FIGHT)
            {
                if (sceneType == SceneType.ADVENTURE_FIGHT)
                {
                    return sceneType2 != SceneType.TOWER_FIGHT && sceneType2 != SceneType.ARENA_FIGHT && sceneType2 != SceneType.RAID_FIGHT;
                }
                if (sceneType == SceneType.TOWER_FIGHT)
                {
                    return sceneType2 != SceneType.ADVENTURE_FIGHT && sceneType2 != SceneType.ARENA_FIGHT && sceneType2 != SceneType.RAID_FIGHT;
                }
            }
            else
            {
                if (sceneType == SceneType.ARENA_FIGHT)
                {
                    return sceneType2 != SceneType.ADVENTURE_FIGHT && sceneType2 != SceneType.TOWER_FIGHT && sceneType2 != SceneType.RAID_FIGHT;
                }
                if (sceneType == SceneType.RAID_FIGHT)
                {
                    return sceneType2 != SceneType.ADVENTURE_FIGHT && sceneType2 != SceneType.TOWER_FIGHT && sceneType2 != SceneType.ARENA_FIGHT;
                }
            }
            return false;
        }

        private bool ExpectingScene(SceneType sceneType, int retry = 5, int sleepInterval = 500)
        {
            for (int i = 0; i < retry; i++)
            {
                if (this.Worker.CancellationPending)
                {
                    return false;
                }
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null || scene.SceneType == sceneType)
                {
                    return true;
                }
                SevenKnightsCore.Sleep(sleepInterval);
            }
            return false;
        }

        private bool ExpectingScenes(List<SceneType> sceneTypes, int retry = 5, int sleepInterval = 500)
        {
            for (int i = 0; i < retry; i++)
            {
                if (this.Worker.CancellationPending)
                {
                    return false;
                }
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null || sceneTypes.Contains(scene.SceneType))
                {
                    return true;
                }
                SevenKnightsCore.Sleep(sleepInterval);
            }
            return false;
        }

        private int FindShortestWorldPath(int current, int destination, int maxNodes)
        {
            int num = current - destination;
            int num2 = destination - current;
            if (num == 0 || num2 == 0)
            {
                return 0;
            }
            if (num < 0)
            {
                num += maxNodes;
            }
            if (num2 < 0)
            {
                num2 += maxNodes;
            }
            if (num == num2)
            {
                return num2;
            }
            if (num >= num2)
            {
                return num2;
            }
            return -num;
        }

        private int GetPixel(int x, int y)
        {
            return this.BlueStacks.GetPixel(x, y);
        }

        private Tuple<World, int> GetWorldStageFromSequencer()
        {
            if (this.AISettings.AD_World != World.Sequencer)
            {
                return null;
            }
            if (this.AISettings.AD_WorldSequence == null || this.AISettings.AD_WorldSequence.Length <= 0 || this.AISettings.AD_StageSequence == null || this.AISettings.AD_StageSequence.Length <= 0 || this.AISettings.AD_AmountSequence == null || this.AISettings.AD_AmountSequence.Length <= 0)
            {
                return null;
            }
            World item = (World)this.AISettings.AD_WorldSequence[this.CurrentSequence];
            int item2 = this.AISettings.AD_StageSequence[this.CurrentSequence];
            return new Tuple<World, int>(item, item2);
        }

        private void GoldChamberAfterFight()
        {
            this.GoldChamberCount++;
            this.ReportCount(Objective.GOLD_CHAMBER);
            this.GoldChamberCheckLimits();
        }

        private void SpecialDunAfterFight()
        {
            this.SpecialDunCheckLimits();
        }

        private void SpecialDunCheckLimits()
        {
            bool flag1 = false;
            bool flag2 = false;
            if (this.sp_dailyflag == true)
            {
                this.sp_dailycount++;
                if (this.AISettings.SP_EnableLimit)
                {
                    this.Sp_LimitCount++;
                    if (this.Sp_LimitCount >= this.AISettings.SP_Limit)
                    {
                        this.Sp_LimitCount = 0;
                        flag1 = true;
                    }
                }
                if (this.sp_dailycount >= this.AISettings.SP_DailyLimit)
                {
                    this.sp_dailyflag = false;
                    flag2 = true;
                }
                if (flag1 || flag2)
                {
                    this.Log("Limit reached [Daily Dungeon]", this.COLOR_LIMIT);
                    this.NextPossibleObjective();
                }
            }
            else if (this.sp_row1flag == true)
            {
                this.sp_row1count++;
                if (this.AISettings.SP_EnableLimit)
                {
                    this.Sp_LimitCount++;
                    if (this.Sp_LimitCount >= this.AISettings.SP_Limit)
                    {
                        this.Sp_LimitCount = 0;
                        flag1 = true;
                    }
                }
                if (this.sp_row1count >= this.AISettings.SP_CakeLimit)
                {
                    this.sp_row1flag = false;
                    flag2 = true;
                }
                if (flag1 || flag2)
                {
                    this.Log("Limit reached [Special Dungeon]", this.COLOR_LIMIT);
                    this.NextPossibleObjective();
                }
            }
            else if (this.sp_row2flag == true)
            {
                this.sp_row2count++;
                if (this.AISettings.SP_EnableLimit)
                {
                    this.Sp_LimitCount++;
                    if (this.Sp_LimitCount >= this.AISettings.SP_Limit)
                    {
                        this.Sp_LimitCount = 0;
                        flag1 = true;
                    }
                }
                if (this.sp_row2count >= this.AISettings.SP_CrystalLimit)
                {
                    this.sp_row2flag = false;
                    flag2 = true;
                }
                if (flag1 || flag2)
                {
                    this.Log("Limit reached [Special Dungeon]", this.COLOR_LIMIT);
                    this.NextPossibleObjective();
                }
            }
            else if (this.sp_row3flag == true)
            {
                this.sp_row3count++;
                if (this.AISettings.SP_EnableLimit)
                {
                    this.Sp_LimitCount++;
                    if (this.Sp_LimitCount >= this.AISettings.SP_Limit)
                    {
                        this.Sp_LimitCount = 0;
                        flag1 = true;
                    }
                }
                if (this.sp_row3count >= this.AISettings.SP_EvanLimit)
                {
                    this.sp_row3flag = false;
                    flag2 = true;
                }
                if (flag1 || flag2)
                {
                    this.Log("Limit reached [Special Dungeon]", this.COLOR_LIMIT);
                    this.NextPossibleObjective();
                }
            }
            else if (this.sp_row4flag == true)
            {
                this.sp_row4count++;
                if (this.AISettings.SP_EnableLimit)
                {
                    this.Sp_LimitCount++;
                    if (this.Sp_LimitCount >= this.AISettings.SP_Limit)
                    {
                        this.Sp_LimitCount = 0;
                        flag1 = true;
                    }
                }
                if (this.sp_row4count >= this.AISettings.SP_KarinLimit)
                {
                    this.sp_row4flag = false;
                    flag2 = true;
                }
                if (flag1 || flag2)
                {
                    this.Log("Limit reached [Special Dungeon]", this.COLOR_LIMIT);
                    this.NextPossibleObjective();
                }
            }
        }

        private void GoldChamberCheckLimits()
        {
            if (this.AISettings.GC_EnableLimit)
            {
                this.GoldChamberLimitCount++;
                if (this.GoldChamberLimitCount >= this.AISettings.GC_Limit)
                {
                    this.Log("Limit reached [Gold Chamber]", this.COLOR_LIMIT);
                    SendTelegram(this.AIProfiles.ST_TelegramChatID, "Limit reached [Gold Chamber]");
                    this.GoldChamberLimitCount = 0;
                    this.NextPossibleObjective();
                }
            }
        }

        private bool HandleInboxCollected(int tabIndex)
        {
            while (!this.Worker.CancellationPending && this.MatchMapping(InboxPM.AttachCollectButtonBackground, 4))
            {
                this.CaptureFrame();
                SevenKnightsCore.Sleep(500);
            }
            SevenKnightsCore.Sleep(1000);
            this.CaptureFrame();
            Scene scene = this.SceneSearch();
            if (scene == null || (scene.SceneType != SceneType.INBOX_REWARDS_POPUP && scene.SceneType != SceneType.LOOT_HERO && scene.SceneType != SceneType.LOOT_ITEM && scene.SceneType != SceneType.INBOX_SELECT_HERO && scene.SceneType != SceneType.INBOX_COLLECT_FAILED_POPUP))
            {
                return false;
            }
            if (scene.SceneType == SceneType.INBOX_REWARDS_POPUP)
            {
                this.Log("-- Rewards collected", this.COLOR_INBOX);
            }
            else if (scene.SceneType == SceneType.LOOT_ITEM)
            {
                this.Log("-- Item ticket collected", this.COLOR_INBOX);
            }
            else if (scene.SceneType == SceneType.LOOT_HERO)
            {
                this.Log("-- Hero ticket collected", this.COLOR_INBOX);
            }
            else
            {
                if (scene.SceneType == SceneType.INBOX_SELECT_HERO)
                {
                    this.Log("Found a hero card that needs to be selected", this.COLOR_INBOX);
                    SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI will skip and not collect this card.");
                    return false;
                }
                if (scene.SceneType != SceneType.INBOX_COLLECT_FAILED_POPUP)
                {
                    return false;
                }
                if (tabIndex == 4)
                {
                    return false;
                }
            }
            if (scene.SceneType == SceneType.INBOX_REWARDS_POPUP)
            {
                this.WeightedClick(SharedPM.Rewards_OkButton, 1.0, 1.0, 1, 0, "left");
            }
            else
            {
                this.Escape();
            }
            SevenKnightsCore.Sleep(500);
            return true;
        }

        private void HandleOutOfKey(SceneType sceneType)
        {
            if (sceneType != SceneType.OUT_OF_KEYS_POPUP && sceneType != SceneType.RAID_OUT_OF_KEYS_POPUP)
            {
                return;
            }
            Dictionary<SceneType, PixelMapping[]> dictionary = new Dictionary<SceneType, PixelMapping[]>
            {
                {
                    SceneType.OUT_OF_KEYS_POPUP,
                    new PixelMapping[]
                    {
                        OutOfKeysPopupPM.ShopButton,
                        OutOfKeysPopupPM.NoButton
                    }
                },
                {
                    SceneType.RAID_OUT_OF_KEYS_POPUP,
                    new PixelMapping[]
                    {
                        RaidOutOfKeysPopupPM.BuyButton,
                        RaidOutOfKeysPopupPM.NoButton
                    }
                }
            };
            PixelMapping[] array = dictionary[sceneType];
            if (this.IsBuyKeysEnabled())
            {
                this.WeightedClick(array[0], 1.0, 1.0, 1, 0, "left");
                if (this.CurrentObjective != Objective.BUY_KEYS)
                {
                    this.ChangeObjective(Objective.BUY_KEYS);
                    return;
                }
            }
            else
            {
                this.WeightedClick(array[1], 1.0, 1.0, 1, 0, "left");
                this.NextPossibleObjective();
            }
        }

        private bool HandleSpecialQuestsCollected(int tabIndex)
        {
            while (!this.Worker.CancellationPending && (this.MatchMapping(QuestPM.CollectAllButtonBackground, 4) || this.MatchMapping(QuestPM.CollectButtonBackground, 2) || this.MatchMapping(SpecialQuestPM.CollectMainButtonBackground, 4) || this.MatchMapping(SpecialQuestPM.CollectButtonBackground, 2)))
            {
                this.CaptureFrame();
                SevenKnightsCore.Sleep(500);
            }
            SevenKnightsCore.Sleep(300);
            this.CaptureFrame();
            Scene scene = this.SceneSearch();
            if (scene == null || (scene.SceneType != SceneType.QUEST_REWARDS_POPUP && scene.SceneType != SceneType.LOOT_ITEM && scene.SceneType != SceneType.LOOT_HERO && scene.SceneType != SceneType.QUEST_COLLECT_FAILED_POPUP))
            {
                return false;
            }
            if (scene.SceneType == SceneType.QUEST_REWARDS_POPUP)
            {
                this.Log("-- Rewards collected", this.COLOR_QUEST);
            }
            else if (scene.SceneType == SceneType.LOOT_ITEM)
            {
                this.Log("-- Item ticket collected", this.COLOR_QUEST);
            }
            else if (scene.SceneType == SceneType.LOOT_HERO)
            {
                this.Log("-- Hero ticket collected", this.COLOR_QUEST);
            }
            else
            {
                if (scene.SceneType == SceneType.QUEST_COLLECT_FAILED_POPUP)
                {
                    this.Escape();
                    SevenKnightsCore.Sleep(500);
                    return false;
                }
                return false;
            }
            if (scene.SceneType == SceneType.QUEST_REWARDS_POPUP)
            {
                this.WeightedClick(SharedPM.Rewards_OkButton, 1.0, 1.0, 1, 0, "left");
            }
            else
            {
                this.Escape();
            }
            SevenKnightsCore.Sleep(500);
            return true;
        }

        private void HeroSortReset(bool sortLevel = true, bool ascending = true)
        {
            if (sortLevel)
            {
                if (!this.MatchMapping(HeroesPM.SortByBoxExpanded, 2))
                {
                    this.WeightedClick(HeroesPM.SortByBox, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(300);
                }
                this.WeightedClick(HeroesPM.SortByLevel, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            }
            PixelMapping mapping = ascending ? HeroesPM.SortButtonAscending : HeroesPM.SortButtonDescending;
            if (!this.MatchMapping(mapping, 2))
            {
                this.WeightedClick(HeroesPM.SortButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            }
            this.ScrollHeroCards(false);
            SevenKnightsCore.Sleep(500);
        }

        private void InitLoop()
        {
            this.CurrentObjective = Objective.IDLE;
            this.NextPossibleObjective();
            this.MasteryChecked = false;
            this.MapCheckCount = 0;
            this.CurrentSequence = 0;
            this.CurrentSequenceCount = 0;
            this.CurrentWave = 0;
            this.CurrentRaidTeam = 0;
            this.CurrentSkillSet = null;
            this.CurrentSkill = -1;
            this.PressedSkill = -1;
            this.LoopSkill = false;
            this.HeroManageAttemps = 0;
            this.EnableLuckyBox = true;
            this.EnableRaidRewards = false;
            this.KeysBoughtHonors = 0;
            this.KeysBoughtRubies = 0;
            this.ArenaRubiesCount = 0;
            this.CollectQuestsCount = -1;
            this.CollectQuestsTotal = -1;
            this.HangCounter = 0;
            this.IdleCounter = 0;
            this.MapSelectCounter = 0;
            this.CooldownInbox = 0;
            this.CooldownQuests = 0;
            this.CooldownSendHonors = 0;
            this.CooldownSellHeroes = 0;
            this.CooldownSellItems = 0;
            this.AdventureCount = 0;
            this.GoldChamberCount = 0;
            this.ArenaWinCount = 0;
            this.ArenaRank = 0;
            this.ArenaLoseCount = 0;
            this.RaidCount = 0;
            this.ReportAllCount();
            this.AdventureLimitCount = 0;
            this.GoldChamberLimitCount = 0;
            this.h30 = 0;
            this.heroreplace = 0;
            this.Sp_LimitCount = 0;
            this.sp_dailycount = 0;
            this.sp_row1count = 0;
            this.sp_row2count = 0;
            this.sp_row3count = 0;
            this.sp_row4count = 0;
            this.dropgoldcount = 0;
            this.dropitemcount = 0;
            this.dragonsummoncount = 0;
            this.goldmineentry = 0;
            this.goldminegoldamount = 0;
            this.ArenaLimitCount = 0;
            this.RaidLimitCount = 0;
            this.HeroCount = 0;
            this.MaxHeroUpCount = false;
            this.botError = false;
            this.nomorehero30 = false;
            this.AdventureKeys = -1;
            this.AdventureKeyTime = TimeSpan.MaxValue;
            this.TowerKeys = -1;
            this.TowerKeyTime = TimeSpan.MaxValue;
            this.ArenaKeys = -1;
            this.ArenaKeyTime = TimeSpan.MaxValue;
            this.ReportAllKeys();
            this.GoldCount = -1;
            this.RubyCount = -1;
            this.HonorCount = -1;
            this.TopazCount = -1;
            this.ReportAllResources();
            this.OneSecTimer.Enabled = true;
            this.DragonFound = false;
        }

        private bool IsAnyQuestsEnabled()
        {
            return this.IsSpecialQuestsEnabled() || this.IsQuestsEnabled();
        }

        private bool IsBuyKeysEnabled()
        {
            return this.IsBuyKeysHonors() || this.IsBuyKeysRubies();
        }

        private bool IsBuyKeysHonors()
        {
            return this.AISettings.RS_BuyKeyHonors && this.KeysBoughtHonors < this.AISettings.RS_BuyKeyHonorsAmount;
        }

        private bool IsBuyKeysRubies()
        {
            return this.AISettings.RS_BuyKeyRubies && this.KeysBoughtRubies < this.AISettings.RS_BuyKeyRubiesAmount;
        }

        private bool IsGameActive()
        {
            IList text = this.BlueStacks.MainWindowAS.GetText();
            Console.Write(text.Contains("Seven Knights") || text.Contains("Android"));
            return text.Contains("Seven Knights") || text.Contains("Android");
        }

        private bool IsHeroLevel30(bool retrying = false)
        {
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, SharedPM.Hero_R_Level_30))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("o", "0").Trim().Replace(" ", "");
                    Utility.FilterAscii(text);
                    if (text.Length >= 2)
                    {
                        int lvl = -1;
                        int maxLvl = 30;
                        string[] array = text.Split(new char[]
                            {
                                '/'
                            });

                        if (array.Length >= 1)
                            int.TryParse(array[0], out lvl);
                        if (array.Length >= 2)
                        {
                            int.TryParse(array[1].Substring(0, 2), out maxLvl);
                            if (maxLvl < 30)
                                maxLvl = 30;
                        }
#if DEBUG
						this.Log(string.Format("Level: {0}/{1} String: {2}", lvl, maxLvl, text));
						bitmap.Save(string.Format("{0} of {1}.png", lvl, maxLvl));
#endif
                        if (lvl != maxLvl)
                        {
                            return false;
                        }
                    }
                    else if (!retrying)
                    {
                        Sleep(1000);
                        IsHeroLevel30(true);
                    }
                }
            }
            return true;
        }
        private bool IsDragonAvailable(bool retrying = false)
        {
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, AdventureLootPM.DragonPoint))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap,null,PageSegMode.Auto))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    Utility.FilterAscii(text);
                    if (text.Length >= 2)
                    {
                        int lvl = -1;
                        int maxLvl = 100;
                        string[] array = text.Split(new char[]
                            {
                                '/'
                            });

                        if (array.Length >= 1)
                            int.TryParse(array[0], out lvl);
                        if (array.Length >= 2)
                        {
                            int.TryParse(array[1].Substring(0, 2), out maxLvl);
                            if (maxLvl < 100)
                                maxLvl = 100;
                        }
#if DEBUG
                        this.Log(string.Format("Level: {0}/{1} String: {2}", lvl, maxLvl, text));
                        bitmap.Save(string.Format("{0} of {1}.png", lvl, maxLvl));
#endif
                        dragonsummoncount = lvl;
                        if (lvl != maxLvl)
                        {
                            page.Dispose();
                            return false;
                        }
                    }
                    else if (!retrying)
                    {
                        Sleep(1000);
                        page.Dispose();
                        IsDragonAvailable(true);
                    }
                    page.Dispose();
                }
            }
            return true;
        }

        private bool IsInboxEnabled()
        {
            return this.AISettings.RS_InboxHonors || this.AISettings.RS_InboxKeys || this.AISettings.RS_InboxGold || this.AISettings.RS_InboxRubies || this.AISettings.RS_InboxTickets;
        }

        private bool IsQuestsEnabled()
        {
            return this.AISettings.RS_QuestsBattle || this.AISettings.RS_QuestsHero || this.AISettings.RS_QuestsItem || this.AISettings.RS_QuestsSocial;
        }

        private bool IsSelectedMastery(SceneType sceneType)
        {
            PixelMapping[] array = new PixelMapping[]
            {
                SharedPM.PrepareFight_Mastery_1,
                SharedPM.PrepareFight_Mastery_2,
                SharedPM.PrepareFight_Mastery_3
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                ArenaStartPM.Mastery_1,
                ArenaStartPM.Mastery_2,
                ArenaStartPM.Mastery_3
            };
            PixelMapping[] RDarray = new PixelMapping[]
            {
                MasteryPopupPM.Tab1,
                MasteryPopupPM.Tab2,
                MasteryPopupPM.Tab3
            };
            int tolerance = 5;
            int num = -1;
            PixelMapping[] array3 = null;
            if (sceneType == SceneType.LOBBY && this.CurrentObjective == Objective.RAID)
            {
                num = (int)this.AISettings.RD_Mastery;
                array3 = RDarray;
            }
            else if (sceneType != SceneType.ADVENTURE_START && (this.CurrentObjective == Objective.ARENA || this.CurrentObjective == Objective.GOLD_CHAMBER))
            {
                if (sceneType != SceneType.TOWER_START)
                {
                    if (sceneType == SceneType.ARENA_START)
                    {
                        num = (int)this.AISettings.AR_Mastery;
                        array3 = array2;
                    }
                }
                else
                {
                    num = (int)this.AISettings.GC_Mastery;
                    array3 = array;
                }
            }
            else if (this.CurrentObjective == Objective.ADVENTURE)
            {
                num = (int)this.AISettings.AD_Mastery;
                array3 = array;
            }
            if (num < 1 || num > 3)
            {
                return true;
            }
            int num2 = num - 1;
            bool flag = this.MatchMapping(array3[num2], tolerance);
            if (flag)
            {
                return true;
            }
            int num3 = 0;
            PixelMapping[] array4 = array3;
            for (int i = 0; i < array4.Length; i++)
            {
                PixelMapping arg_117_0 = array4[i];
                if (num3 != num2)
                {
                    bool flag2 = this.MatchMapping(array3[num3], tolerance);
                    if (flag2)
                    {
                        return false;
                    }
                    num3++;
                }
            }
            return false;
        }

        private bool IsSendHonorsEnabled()
        {
            return this.AISettings.RS_SendHonorsFacebook || this.AISettings.RS_SendHonorsInGame;
        }

        private bool IsSpecialQuestsEnabled()
        {
            return this.AISettings.RS_SpecialQuestsDaily || this.AISettings.RS_SpecialQuestsWeekly || this.AISettings.RS_SpecialQuestsMonthly;
        }

        private void Log(string message)
        {
            this.Log(message, Color.Black);
        }

        private void Log(string message, Color color)
        {
            ProgressArgs userState = new ProgressArgs(ProgressType.EVENT, message, color);
            this.Worker.ReportProgress(0, userState);
        }

        private void LogError(string message)
        {
            ProgressArgs userState = new ProgressArgs(ProgressType.ERROR, message);
            this.Worker.ReportProgress(0, userState);
        }

        private void LogScene(string scene)
        {
            string str = Utility.ToTitleCase(scene.Replace("_", " "));
            this.Log("Scene: " + str, Color.DimGray);
        }

        private void LongSleep(int timeout, int interval = 1000)
        {
            int num = 0;
            while (!this.Worker.CancellationPending && num < timeout)
            {
                SevenKnightsCore.Sleep(interval);
                num += interval;
            }
        }

        private void MainLoop(object sender, DoWorkEventArgs e)
        {
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            this.Hottimeloop = true;
            this.sp_dailyflag = false;
            this.sp_row1flag = false;
            this.sp_row2flag = false;
            this.sp_row3flag = false;
            this.sp_row4flag = false;
            this.CheckPlayaName = true;
            this.Log("Initializing AI...");
            this.BlueStacks = new BlueStacks();
            string errorMessage;
            if (!this.BlueStacks.Hook())
            {
                errorMessage = "BlueStacks is not active or not yet initialized";
                SendTelegram(this.AIProfiles.ST_TelegramChatID, "ERROR : BlueStacks is not active or not yet initialized");
                this.LogError(errorMessage);
                this.SynchronizationContext.Send(delegate (object callback)
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }, null);
                return;
            }
            if (this.BlueStacks.NeedResize() || this.BlueStacks.NeedRenderConfig())
            {
                string text = "BlueStacks needs to be resized. Proceed?";
                SendTelegram(this.AIProfiles.ST_TelegramChatID, "ERROR : Bluestacks needs to be resized.Check now!");
                DialogResult dialogResult = MessageBox.Show(text, "Restart Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {
                    string exePath = this.BlueStacks.GetExePath();
                    this.BlueStacks.RenderConfig();
                    this.BlueStacks.Resize();
                    this.BlueStacks.Kill();
                    SevenKnightsCore.Sleep(500);
                    Process.Start(exePath);
                }
                
                return;
            }
            if (this.BlueStacks.IsGameInstalled())
            {
                if (!this.BlueStacks.IsGameActive())
                {
                    this.Log("Launching Seven Knights...");
                    this.BlueStacks.LaunchGame();
                    this.LongSleep(3000, 1000);
                }
                this.InitLoop();
                string value = null;
                while (!this.Worker.CancellationPending)
                {
                    try
                    {
                        if (!this.AIProfiles.TMP_Paused && !this.AIProfiles.TMP_WaitingForKeys)
                        {
                            if (this.AIProfiles.ST_BlueStacksForceActive)
                            {
                                this.BlueStacks.MainWindowAS.BringToFront();
                            }
                            int sT_Delay = this.AIProfiles.ST_Delay;
                            SevenKnightsCore.Sleep(sT_Delay);
                            this.IdleCounter += sT_Delay;
                            this.HangCounter += sT_Delay;
                            this.MapSelectCounter += sT_Delay;
                            this.CooldownInbox -= sT_Delay;
                            this.CooldownQuests -= sT_Delay;
                            this.CooldownSendHonors -= sT_Delay;
                            this.CooldownSellHeroes -= sT_Delay;
                            this.CooldownSellItems -= sT_Delay;
                            this.CaptureFrame();
                            if (this.BlueStacks.MainWindowAS.CurrentFrame != null)
                            {
                                this.UpdateHangFingerprint();

                                if (this.HangCounter >= 30000)
                                {
                                    this.Log("Restarting Seven Knights", Color.DarkRed);
                                    SendTelegram(this.AIProfiles.ST_TelegramChatID, "The game is not responding... AI will restart the game and continue.");
                                    this.HangCounter = 0;
                                    if (!this.BlueStacks.RestartGame(5))
                                    {
                                        errorMessage = "Restart failed";
                                        this.LogError(errorMessage);
                                        this.SynchronizationContext.Send(delegate (object callback)
                                        {
                                            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        }, null);
                                        break;
                                    }
                                    if (this.PreviousObjective == Objective.HERO_MANAGEMENT)
                                    {
                                        this.ChangeObjective(Objective.HERO_MANAGEMENT);
                                    }
                                    this.IdleCounter = 0;
                                    this.LongSleep(10000, 1000);
                                }
                                Scene scene = this.SceneSearch();
                                bool flag4 = false;
                                string text2 = "";
                                if (scene == null)
                                {
                                    Sleep(this.AIProfiles.ST_Delay);
                                    int sleep = 0;
                                    for (int i = 0; i < 6; i++)
                                    {
                                        this.CaptureFrame();
                                        scene = this.SearchScenes();
                                        if (scene != null)
                                        {
                                            text2 = scene.SceneType.ToString();
                                            break;
                                        }
                                        sleep += 1000;
                                        Sleep(sleep);
                                    }
                                    if (scene == null)
                                    {
                                        text2 = "...";
                                        flag4 = true;
                                        this.IdleCounter += sT_Delay;
                                    }
                                }
                                else
                                {
                                    text2 = scene.SceneType.ToString();
                                }
                                if (!text2.Equals(value))
                                {
                                    if (IdleCounter > 10000)
                                    {
                                        this.Log("IdleTime = " + IdleCounter / 1000, Color.Orange);
                                    }
                                    this.LogScene(text2);
                                    value = text2;
                                    IdleCounter = 0;
                                }
                                if (flag4)
                                {
                                    if (this.MatchMapping(SharedPM.BackButton, 2) && this.MatchMapping(SharedPM.BackButtonAnchor, 2))
                                    {
                                        this.LogScene("BACKABLE");
                                        this.Escape();
                                    }
                                    else if (this.IdleCounter >= sT_Delay)
                                    {
                                        this.Escape();
                                        this.Log("cannot find scene escape");
                                        this.botError = true;
                                        this.Alert("Bot Error");
                                        this.IdleCounter = 0;
                                    }
                                }
                                else
                                {
                                    if (scene.SceneType != SceneType.ADVENTURE_FIGHT && scene.SceneType != SceneType.TOWER_FIGHT && scene.SceneType != SceneType.SPECIAL_DUN_FIGHT && scene.SceneType != SceneType.ARENA_FIGHT && scene.SceneType != SceneType.RAID_FIGHT)
                                    {
                                        this.CurrentWave = 0;
                                        this.CurrentRaidTeam = 0;
                                        this.CurrentSkillSet = null;
                                        this.CurrentSkill = -1;
                                        this.PressedSkill = -1;
                                    }
                                    if (scene.SceneType != SceneType.MAP_SELECT)
                                    {
                                        this.MapSelectCounter = 0;
                                    }
                                    if (scene.SceneType != SceneType.ADVENTURE_START && scene.SceneType != SceneType.MAP_SELECT && scene.SceneType != SceneType.ADVENTURE_READY && scene.SceneType != SceneType.MAP_SELECT_POPUP)
                                    {
                                        this.MapCheckCount = 0;
                                    }
                                    this.IdleCounter = 0;
                                    switch (scene.SceneType)
                                    {

                                        case SceneType._ANDROID_POPUP:
                                            if (this.AIProfiles.ST_ReconnectInterruptEnable)
                                            {
                                                this.LongSleep(this.AIProfiles.ST_ReconnectInterruptInterval * 60000, 1000);
                                                if (!this.BlueStacks.RestartGame(5))
                                                {
                                                    this.SynchronizationContext.Send(delegate (object callback)
                                                    {
                                                        MessageBox.Show("BlueStacks restart failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                    }, null);
                                                    return;
                                                }
                                            }
                                            break;

                                        case SceneType.BLUESTACK_HOME:
                                            this.WeightedClick(BluestackPM.SearchIcon, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType._DIALOG:
                                            this.Escape();
                                            SevenKnightsCore.Sleep(300);
                                            break;

                                        case SceneType.TAP_TO_PLAY:
                                            this.WeightedClick(TapToPlayPM.TapArea, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(1000);
                                            break;

                                        case SceneType.NOTICE:
                                            this.WeightedClick(NoticePM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.ADS:
                                            this.WeightedClick(AdsPM.CloseAds, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.ADS_CLOSE:
                                            this.WeightedClick(AdsClosePM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.CHECK_IN:
                                            this.Escape();
                                            break;

                                        case SceneType.POPUP_1:
                                            this.Escape();
                                            break;

                                        case SceneType.POPUP_2:
                                            this.Escape();
                                            break;

                                        case SceneType.DISCONNECTED_POPUP:
                                            this.WeightedClick(DisconnectedPopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            this.LongSleep(3000, 1000);
                                            break;

                                        case SceneType.WIFI_WARNING_POPUP:
                                            this.WeightedClick(WifiWarningPopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.LOBBY:
                                            this.UpdateAdventureKeys(scene.SceneType);
                                            this.UpdateGold(scene.SceneType);
                                            this.UpdateRuby(scene.SceneType);
                                            this.UpdateHonor(scene.SceneType);
                                            if (this.CheckPlayaName == true)
                                            {
                                                this.WeightedClick(LobbyPM.MasteryButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(800);
                                                this.CaptureFrame();
                                                this.CheckOwnername();
                                                this.Escape();
                                                SevenKnightsCore.Sleep(800);
                                                this.CheckPlayaName = false;
                                            }
                                            if (this.AISettings.AD_HottimeEnable && this.Hottimeloop == true)
                                            {
                                                this.WeightedClick(LobbyPM.StatusBoard, 1.0, 1.0, 1, 0, "left");
                                                this.Hottimeloop = false;
                                                SevenKnightsCore.Sleep(800);
                                            }
                                            if (this.AISettings.AD_Enable && this.AISettings.AD_CheckingHeroes)
                                            {
                                                this.ChangeObjective(Objective.HERO_MANAGEMENT);
                                                this.SelectTeamHero();
                                                this.AISettings.AD_CheckingHeroes = false;
                                            }
                                            else if (this.AISettings.RS_CollectLuckyChest && this.MatchMapping(LobbyPM.MaysLuckyChestAvailable_1, 4) && this.MatchMapping(LobbyPM.MaysLuckyChestAvailable_2, 4))
                                            {
                                                this.WeightedClick(LobbyPM.MaysLuckyChestButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.AISettings.RS_CollectLuckyBox && this.EnableLuckyBox && this.MatchMapping(LobbyPM.LuckyBoxAvailable_1, 4) && this.MatchMapping(LobbyPM.LuckyBoxAvailable_2, 4))
                                            {
                                                if (this.MatchMapping(LobbyPM.LuckyBoxLastOne_1, 2) && this.MatchMapping(LobbyPM.LuckyBoxLastOne_2, 2))
                                                {
                                                    this.StopLuckyBox(false);
                                                }
                                                else
                                                {
                                                    this.WeightedClick(LobbyPM.LuckyBoxButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                            }
                                            else
                                            {
                                                if (this.IsSendHonorsEnabled() && this.CooldownSendHonors <= 0)
                                                {
                                                    this.CooldownSendHonors = 1800000;
                                                    if (this.IsSendHonorsEnabled() && this.CurrentObjective != Objective.COLLECT_QUESTS && this.CurrentObjective != Objective.COLLECT_INBOX && this.CurrentObjective != Objective.SEND_HONORS && this.CurrentObjective != Objective.BUY_KEYS && this.CurrentObjective != Objective.HERO_MANAGEMENT)
                                                    {
                                                        this.ChangeObjective(Objective.SEND_HONORS);
                                                    }
                                                }
                                                else if (this.MatchMapping(LobbyPM.QuestAvailable, 3) && this.IsAnyQuestsEnabled() && this.CooldownQuests <= 0)
                                                {
                                                    this.CooldownQuests = 1800000;
                                                    if (this.IsAnyQuestsEnabled() && this.CurrentObjective != Objective.COLLECT_QUESTS && this.CurrentObjective != Objective.COLLECT_INBOX && this.CurrentObjective != Objective.SEND_HONORS && this.CurrentObjective != Objective.BUY_KEYS && this.CurrentObjective != Objective.HERO_MANAGEMENT)
                                                    {
                                                        this.ChangeObjective(Objective.COLLECT_QUESTS);
                                                    }
                                                }
                                                else if (this.MatchMapping(LobbyPM.InboxAvailable, 3) && this.IsInboxEnabled() && this.CooldownInbox <= 0)
                                                {
                                                    this.CooldownInbox = 1800000;
                                                    if (this.IsInboxEnabled() && this.CurrentObjective != Objective.COLLECT_INBOX && this.CurrentObjective != Objective.COLLECT_QUESTS && this.CurrentObjective != Objective.SEND_HONORS && this.CurrentObjective != Objective.BUY_KEYS && this.CurrentObjective != Objective.HERO_MANAGEMENT)
                                                    {
                                                        this.ChangeObjective(Objective.COLLECT_INBOX);
                                                    }
                                                }
                                                if (this.CurrentObjective == Objective.ADVENTURE || this.CurrentObjective == Objective.GOLD_CHAMBER || this.CurrentObjective == Objective.RAID || this.CurrentObjective == Objective.SPECIAL_DUNGEON)
                                                {
                                                    this.WeightedClick(LobbyPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else if (this.CurrentObjective == Objective.ARENA)
                                                {
                                                    this.WeightedClick(LobbyPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else if (this.CurrentObjective == Objective.HERO_MANAGEMENT || this.CurrentObjective == Objective.SELL_HEROES)
                                                {
                                                    this.WeightedClick(LobbyPM.HeroButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else if (this.CurrentObjective == Objective.BUY_KEYS)
                                                {
                                                    this.WeightedClick(LobbyPM.ShopButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else if (this.CurrentObjective == Objective.COLLECT_INBOX)
                                                {
                                                    this.WeightedClick(LobbyPM.InboxButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else if (this.CurrentObjective == Objective.COLLECT_QUESTS)
                                                {
                                                    this.WeightedClick(LobbyPM.QuestButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else if (this.CurrentObjective == Objective.SEND_HONORS)
                                                {
                                                    this.WeightedClick(LobbyPM.SocialButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else if (this.CurrentObjective == Objective.IDLE)
                                                {
                                                    this.NextPossibleObjective();
                                                }
                                                SevenKnightsCore.Sleep(300);
                                            }
                                            break;

                                        case SceneType.GIFT_REWARDS_POPUP:
                                            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has collected May's Lucky Chest or Lucky Box.");
                                            this.WeightedClick(SharedPM.Rewards_OkButton, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(300);
                                            break;

                                        case SceneType.GIFT_FULL_ITEM_POPUP:
                                            this.StopLuckyBox(true);
                                            break;

                                        case SceneType.GIFT_FULL_HERO_POPUP:
                                            this.StopLuckyBox(true);
                                            break;

                                        case SceneType.GIFT_FULL_HONOR_POPUP:
                                            this.StopLuckyBox(true);
                                            break;

                                        case SceneType.OUT_OF_LUCKY_BOX_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.MASTERY_POPUP:
                                            if (this.MasteryChecked)
                                            {
                                                this.WeightedClick(MasteryPopupPM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                                break;
                                            }
                                            int num = -1;
                                            if (this.CurrentObjective == Objective.ADVENTURE)
                                            {
                                                num = (int)this.AISettings.AD_Mastery;
                                            }
                                            else if (this.CurrentObjective == Objective.GOLD_CHAMBER)
                                            {
                                                num = (int)this.AISettings.GC_Mastery;
                                            }
                                            else if (this.CurrentObjective == Objective.ARENA)
                                            {
                                                num = (int)this.AISettings.AR_Mastery;
                                            }
                                            else if (this.CurrentObjective == Objective.RAID)
                                            {
                                                num = (int)this.AISettings.RD_Mastery;
                                            }
                                            if (num == 0 || num == -1)
                                            {
                                                this.WeightedClick(MasteryPopupPM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                                break;
                                            }
                                            PixelMapping[] array = new PixelMapping[]
                                            {
                                                    MasteryPopupPM.Tab1,
                                                    MasteryPopupPM.Tab2,
                                                    MasteryPopupPM.Tab3
                                            };
                                            this.WeightedClick(array[num - 1], 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(500);
                                            this.MasteryChecked = true;
                                            this.WeightedClick(MasteryPopupPM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.ADVENTURE_MODES:
                                            if (this.CurrentObjective == Objective.ADVENTURE)
                                            {
                                                this.WeightedClick(AdventureModesPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.GOLD_CHAMBER)
                                            {
                                                this.WeightedClick(AdventureModesPM.CelestialTowerButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.SPECIAL_DUNGEON)
                                            {
                                                this.WeightedClick(AdventureModesPM.SpecialDungeonButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.RAID)
                                            {
                                                this.WeightedClick(AdventureModesPM.RaidButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.MAP_SELECT:

                                            if (this.MapSelectCounter >= 10000)

                                            {

                                                this.WeightedClick(SharedPM.BackButton, 1.0, 1.0, 1, 0, "left");

                                                SevenKnightsCore.Sleep(500);

                                            }

                                            else if (this.CurrentObjective == Objective.ADVENTURE)

                                            {

                                                World world = this.AISettings.AD_World;

                                                int stage = this.AISettings.AD_Stage;

                                                if (this.AISettings.AD_World == World.Sequencer)

                                                {

                                                    Tuple<World, int> worldStageFromSequencer = this.GetWorldStageFromSequencer();

                                                    if (worldStageFromSequencer == null)

                                                    {

                                                        this.LogError("Stage sequence is empty");

                                                        this.NextPossibleObjective();

                                                        break;

                                                    }

                                                    world = worldStageFromSequencer.Item1;

                                                    stage = worldStageFromSequencer.Item2;

                                                }

                                                this.Log("Wrold =" + world);

                                                if (world == World.ShadowsEye)

                                                {

                                                    this.Log("ShadowsEYE");

                                                    //on ASGAR

                                                    if (this.MatchMapping(MapSelectPM.MoonBoatLitLeft, 2) && this.MatchMapping(MapSelectPM.MoonLitBoatRight, 2))

                                                    {

                                                        this.Log("1,1");

                                                        this.WeightedClick(MapSelectPM.RightBottomBTN, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        this.CaptureFrame();

                                                        //then

                                                    }

                                                    //on Aisha

                                                    if (this.MatchMapping(MapSelectPM.AishaBoatLeft, 2) && this.MatchMapping(MapSelectPM.AishaBoatRight, 2))

                                                    {

                                                        this.Log("1,2");

                                                        this.WeightedClick(MapSelectPM.RightBottomBTN, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        this.CaptureFrame();

                                                    }



                                                    this.MapZone = "ShadowsEye";

                                                    this.SelectStageShadowsEye(world, stage);

                                                }

                                                else if (world == World.MoonlitIsle || world == World.WesternEmpire || world == World.EasternEmpire || world == World.DarkSanctuary)

                                                {

                                                    this.Log("Aisha");

                                                    //on ASGAR

                                                    if (this.MatchMapping(MapSelectPM.MoonBoatLitLeft, 2) && this.MatchMapping(MapSelectPM.MoonLitBoatRight, 2))

                                                    {

                                                        this.Log("2,1");

                                                        this.WeightedClick(MapSelectPM.RightBottomBTN, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        this.CaptureFrame();

                                                    }

                                                    this.MapZone = "Aisha";

                                                    this.SelectStageAisha(world, stage);

                                                }

                                                else

                                                {

                                                    this.Log("Asgar");

                                                    //on shadow eye

                                                    if (this.MatchMapping(MapSelectPM.World12_1Anchor_1, 2) && this.MatchMapping(MapSelectPM.World12_1Anchor_2, 2))

                                                    {

                                                        this.Log("3,1");

                                                        this.WeightedClick(MapSelectPM.RightBottomBTN, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        //then

                                                        this.CaptureFrame();

                                                    }

                                                    //on aisha

                                                    //if (this.MatchMapping(MapSelectPM.AishaBoatLeft, 2) && this.MatchMapping(MapSelectPM.AishaBoatRight, 2))

                                                    if (this.MatchMapping(MapSelectPM.AishaBoatLeft, 2) || this.MatchMapping(MapSelectPM.AishaBoatRight, 2))

                                                    {

                                                        this.Log("3,2");

                                                        this.WeightedClick(MapSelectPM.QuickStartMidButton, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        this.CaptureFrame();

                                                    }



                                                    this.MapZone = "Asgar";

                                                    this.SelectStageAsgar(world, stage);

                                                }

                                            }

                                            else

                                            {

                                                this.Escape();

                                            }

                                            break;

                                        case SceneType.MAP_SELECT_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.FULL_ITEM_POPUP:
                                            if (this.AISettings.AD_StopOnFullItems)
                                            {
                                                this.Alert("Items Full");
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has stopped because Your inventory is full");
                                                this.Escape();
                                            }
                                            if (!flag)
                                            {
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "Your inventory is full. AI will start selling them if enabled.");
                                                flag = true;
                                            }
                                            if (this.AISettings.RS_SellItems && this.CooldownSellItems <= 0)
                                            {
                                                if (this.CurrentObjective != Objective.SELL_ITEMS)
                                                {
                                                    this.ChangeObjective(Objective.SELL_ITEMS);
                                                }
                                                this.WeightedClick(SharedPM.Full_NoButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(SharedPM.Full_ProceedButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            SevenKnightsCore.Sleep(500);
                                            break;

                                        case SceneType.FULL_HERO_POPUP:
                                            if (this.AISettings.AD_StopOnFullHeroes)
                                            {
                                                this.Alert("Heroes Full");
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI has stopped Because Your hero cards are full");
                                                this.Escape();
                                            }
                                            if (!flag2)
                                            {
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "Your hero cards are full. AI will start selling them if enabled.");
                                                flag2 = true;
                                            }
                                            if (this.AISettings.RS_SellHeroes && this.CooldownSellHeroes <= 0)
                                            {
                                                if (this.CurrentObjective != Objective.SELL_HEROES)
                                                {
                                                    this.ChangeObjective(Objective.SELL_HEROES);
                                                }
                                                this.WeightedClick(SharedPM.Full_NoButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(SharedPM.Full_ProceedButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            SevenKnightsCore.Sleep(500);
                                            break;


                                        case SceneType.ADVENTURE_READY:
                                            SevenKnightsCore.Sleep(600);
                                            if (this.CurrentObjective == Objective.ADVENTURE && ExpectingScene(SceneType.ADVENTURE_READY, 3, 500))
                                            {
                                                this.WeightedClick(AdventureReadyPM.ReadyButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(AdventureReadyPM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            SevenKnightsCore.Sleep(500);
                                            break;

                                        case SceneType.ADVENTURE_START:
                                                this.UpdateAdventureKeys(scene.SceneType);
                                                this.UpdateGold(scene.SceneType);
                                            if (this.CurrentObjective == Objective.ADVENTURE)
                                            {
                                                World world2 = this.AISettings.AD_World;
                                                int stage2 = this.AISettings.AD_Stage;
                                                if (this.AISettings.AD_World == World.Sequencer)
                                                {
                                                    Tuple<World, int> worldStageFromSequencer2 = this.GetWorldStageFromSequencer();
                                                    if (worldStageFromSequencer2 == null)
                                                    {
                                                        this.LogError("Stage sequence is empty");
                                                        this.NextPossibleObjective();
                                                        break;
                                                    }
                                                    world2 = worldStageFromSequencer2.Item1;
                                                    stage2 = worldStageFromSequencer2.Item2;
                                                }
                                                if (this.AISettings.AD_Continuous || this.CheckMapNumber(world2, stage2) || this.MapCheckCount >= 3)
                                                {
                                                    if (!this.CheckMastery(scene.SceneType))
                                                    {
                                                        this.MasteryChecked = false;
                                                        this.SelectTeam(SceneType.ADVENTURE_START);
                                                        if (this.AISettings.AD_UseFriend)
                                                        {
                                                            if(this.MatchMapping(AdventureStartPM.UseFriendOff,2))
                                                            {
                                                                this.WeightedClick(SharedPM.UseFriendButton, 1.0, 1.0, 1, 0, "left");
                                                                SevenKnightsCore.Sleep(600);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (this.MatchMapping(AdventureStartPM.UseFriendOn, 2))
                                                            {
                                                                this.WeightedClick(SharedPM.UseFriendButton, 1.0, 1.0, 1, 0, "left");
                                                                SevenKnightsCore.Sleep(600);
                                                            }
                                                        }
                                                        if (this.AISettings.AD_BootMode)
                                                        {
                                                            if (this.MatchMapping(AdventureStartPM.BootmodeOff, 2))
                                                            {
                                                                this.WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                                SevenKnightsCore.Sleep(600);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (this.MatchMapping(AdventureStartPM.BootmodeOn, 2))
                                                            {
                                                                this.WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                                SevenKnightsCore.Sleep(600);
                                                            }
                                                        }
                                                        if (this.MatchMapping(AdventureStartPM.AutoRepeatOn, 2))
                                                        {
                                                            this.WeightedClick(AdventureStartPM.AutoRepeatOff, 1.0, 1.0, 1, 0, "left");
                                                            SevenKnightsCore.Sleep(900);
                                                        }
                                                        SevenKnightsCore.Sleep(500);
                                                        this.WeightedClick(SharedPM.PrepareFight_StartButton, 1.0, 1.0, 1, 0, "left");
                                                        SevenKnightsCore.Sleep(600);
                                                    }
                                                }
                                                else
                                                {
                                                    this.MapCheckCount++;
                                                    this.Escape();
                                                    SevenKnightsCore.Sleep(300);
                                                }
                                            }
                                            else if (this.CurrentObjective == Objective.HERO_MANAGEMENT)
                                            {
                                                this.WeightedClick(SharedPM.PrepareFight_ManageButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.ADVENTURE_FIGHT:
                                            this.PerformFightTatics(scene.SceneType);
                                            break;

                                        case SceneType.ADVENTURE_END:
                                            SevenKnightsCore.Sleep(500);
                                            break;

                                        case SceneType.ADVENTURE_LOST:
                                            this.AdventureAfterFight();
                                            this.Log("Your team lost the battle [Adventure]", this.COLOR_DEATH);
                                            SendTelegram(this.AIProfiles.ST_TelegramChatID, "[Adventure] Your team has lost a battle. Continuing AI.");
                                            this.WeightedClick(AdventureLostPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.VICTORY:
                                            for (int i = 0; i < 3; i++)
                                            {
                                                SevenKnightsCore.Sleep(500);
                                                this.WeightedClick(VictoryPM.TapToSkipArea, 1.0, 1.0, 1, 0, "left");
                                            }
                                            break;

                                        case SceneType.ADVENTURE_LOOT_ITEM:
                                        case SceneType.ADVENTURE_LOOT_HERO:
                                        case SceneType.ADVENTURE_LOOT_GOLD:
                                        case SceneType.ADVENTURE_LOOT:
                                            this.AdventureAfterFight();
                                            SevenKnightsCore.Sleep(500);
                                            if (this.IsDragonAvailable()) {
                                                if (this.AISettings.AD_StopOnDragonFull)
                                                {
                                                    this.Alert("Dragon Found");
                                                    SendTelegram(this.AIProfiles.ST_TelegramChatID, "Dragon can be summon, Check Now!");
                                                    this.Escape();
                                                    this.AIProfiles.TMP_Paused = true;
                                                    break;
                                                }
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "Dragon can be summon, Bot will summon dragon if enabled!");
                                                if (this.AISettings.RD_OwnerDragon)
                                                {
                                                    this.ChangeObjective(Objective.RAID);
                                                    this.DragonFound = true;
                                                }
                                            }
                                            
                                                if (this.CurrentObjective == Objective.ADVENTURE)
                                                {
                                                    if (this.AISettings.AD_Continuous && this.AISettings.AD_World != World.Sequencer)
                                                    {
                                                        this.WeightedClick(AdventureLootPM.NextZoneButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if (this.AISettings.AD_World == World.None)
                                                    {
                                                        this.WeightedClick(AdventureLootPM.QuickStartButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else
                                                    {
                                                        this.WeightedClick(AdventureLootPM.AgainButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                }
                                                else
                                                {
                                                    this.WeightedClick(SharedPM.Loot_LobbyButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                            break;

                                        case SceneType.ADVENTURE_LOOT_HERO_SPECIAL:
                                            this.AdventureAfterFight();
                                            SevenKnightsCore.Sleep(300);
                                            this.WeightedClick(SharedPM.Loot_LobbyButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.OUT_OF_KEYS_OFFER:
                                            if (!flag3)
                                            {
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "[Adventure] AI will buy more keys or play other modes while waiting.");
                                                flag3 = true;
                                            }
                                            if (this.CurrentObjective != Objective.BUY_KEYS && this.AISettings.RS_BuyKeyHonors && this.KeysBoughtHonors < this.AISettings.RS_BuyKeyHonorsAmount)
                                            {
                                                this.ChangeObjective(Objective.BUY_KEYS);
                                                this.Escape();
                                            }
                                            else
                                            {
                                                this.Escape();
                                                this.NextPossibleObjective();
                                            }
                                            break;

                                        case SceneType.OUT_OF_KEYS_POPUP:
                                            if (!flag3)
                                            {
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "[Adventure] AI will buy more keys or play other modes while waiting.");
                                                flag3 = true;
                                            }
                                            this.HandleOutOfKey(scene.SceneType);
                                            break;

                                        //case SceneType.TOWER_SELECT:
                                        //    this.UpdateTowerKeys();
                                        //    if (this.CurrentObjective == Objective.GOLD_CHAMBER)
                                        //    {
                                        //        if (this.TowerKeys > 0)
                                        //        {
                                        //            this.WeightedClick(TowerSelectPM.GoldChamberButton, 1.0, 1.0, 1, 0, "left");
                                        //        }
                                        //        else
                                        //        {
                                        //            this.NextPossibleObjective();
                                        //        }
                                        //    }
                                        //    else
                                        //    {
                                        //        this.Escape();
                                        //    }
                                        //    break;

                                        case SceneType.TOWER_SELECT:
                                            this.UpdateTowerKeys();
                                            if (this.CurrentObjective == Objective.GOLD_CHAMBER)
                                            {
                                                this.CalculateGoldMine();
                                                if (!this.MatchMapping(TowerSelectPM.GoldMindCheck, 2))
                                                {
                                                    
                                                    this.Log("Gold Mine Collect.", this.COLOR_LIMIT);
                                                    SendTelegram(this.AIProfiles.ST_TelegramChatID, "Gold Mine Collected!");
                                                    this.WeightedClick(TowerSelectPM.CollectButton, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    this.GoldChamberCount++;
                                                    this.ReportCount(Objective.GOLD_CHAMBER);
                                                    this.NextPossibleObjective();
                                                }
                                                else
                                                {
                                                            if (this.TowerKeys > 0)
                                                            {
                                                            if (!this.MatchMapping(TowerSelectPM.ReadyDisabled, 2))
                                                                {
                                                                    this.Log("Gold Mine Countdown, Go to Tower", this.COLOR_LIMIT);
                                                                    this.WeightedClick(TowerSelectPM.GoldChamberButton, 1.0, 1.0, 1, 0, "left"); //tower start button
                                                                }
                                                                else
                                                                {
                                                                    this.Log("Gold Mine Countdown, Your tower already finished.", this.COLOR_LIMIT);
                                                                    this.NextPossibleObjective();
                                                                }
                                                            }
                                                           else
                                                            {
                                                                this.Log("Gold Mine Countdown, Your Tower Key 0", this.COLOR_LIMIT);
                                                                this.NextPossibleObjective();
                                                            }
                                                }
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.TOWER_START:
                                            this.UpdateTowerKeys();
                                            if (this.CurrentObjective == Objective.GOLD_CHAMBER)
                                            {
                                                if (this.TowerKeys > 0)
                                                {
                                                    if (!this.CheckMastery(scene.SceneType))
                                                    {
                                                        this.MasteryChecked = false;
                                                        this.SelectTeam(SceneType.TOWER_START);
                                                        SevenKnightsCore.Sleep(800);
                                                        if (this.AISettings.GC_UseFriend)
                                                        {
                                                            if (this.MatchMapping(TowerStartPM.UseFriendOff, 2))
                                                            {
                                                                this.WeightedClick(SharedPM.UseFriendButton, 1.0, 1.0, 1, 0, "left");
                                                                SevenKnightsCore.Sleep(800);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (this.MatchMapping(TowerStartPM.UseFriendOn, 2))
                                                            {
                                                                this.WeightedClick(SharedPM.UseFriendButton, 1.0, 1.0, 1, 0, "left");
                                                                SevenKnightsCore.Sleep(800);
                                                            }
                                                        }
                                                        this.WeightedClick(TowerStartPM.StartButton, 1.0, 1.0, 1, 0, "left");
                                                        SevenKnightsCore.Sleep(300);
                                                    }
                                                }
                                                else
                                                {
                                                    this.NextPossibleObjective();
                                                }
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.TOWER_FIGHT:
                                            this.PerformFightTatics(scene.SceneType);
                                            break;

                                        case SceneType.TOWER_LOST:
                                            this.GoldChamberAfterFight();
                                            this.Log("Your team lost the battle [Tower]", this.COLOR_DEATH);
                                            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Your team has lost a battle. Continuing AI.");
                                            this.WeightedClick(TowerLostPM.ReadyButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.GOLD_CHAMBER_LOOT:
                                            this.GoldChamberAfterFight();
                                            if (this.CurrentObjective == Objective.GOLD_CHAMBER)
                                            {
                                                this.WeightedClick(GoldChamberLootPM.AgainButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(SharedPM.Loot_LobbyButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            break;

                                        case SceneType.OUT_OF_SILVER_KEYS_POPUP:
                                            this.Escape();
                                            this.NextPossibleObjective();
                                            break;

                                        case SceneType.BATTLE_MODES:
                                            if (this.CurrentObjective == Objective.ARENA)
                                            {
                                                this.WeightedClick(BattleModesPM.ArenaButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.ADVENTURE)
                                            {
                                                this.WeightedClick(BattleModesPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.GOLD_CHAMBER)
                                            {
                                                this.WeightedClick(BattleModesPM.CelestialTowerButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.SPECIAL_DUNGEON)
                                            {
                                                this.WeightedClick(BattleModesPM.SpecialDungeonButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.RAID)
                                            {
                                                this.WeightedClick(BattleModesPM.RaidButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.ARENA_READY:
                                            this.UpdateArenaKeys();
                                            this.UpdateRuby(scene.SceneType);
                                            this.UpdateHonor(scene.SceneType);
                                            this.CheckArenaScoreReady();
                                            if (this.CurrentObjective == Objective.ARENA)
                                            {
                                                if (this.ArenaKeys > 0 || this.ArenaUseRuby())
                                                {
                                                    this.WeightedClick(ArenaReadyPM.ReadyButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    this.NextPossibleObjective();
                                                }
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.ARENA_START:
                                            if (this.CurrentObjective == Objective.ARENA)
                                            {
                                                bool flag5 = this.ArenaUseRuby();
                                                if (this.ArenaKeys > 0 || flag5)
                                                {
                                                    if (!this.CheckMastery(scene.SceneType))
                                                    {
                                                        this.MasteryChecked = false;
                                                        this.WeightedClick(ArenaStartPM.StartButton, 1.0, 1.0, 1, 0, "left");
                                                        SevenKnightsCore.Sleep(300);
                                                    }
                                                }
                                                else
                                                {
                                                    this.NextPossibleObjective();
                                                }
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.ARENA_FIGHT:
                                            this.PerformFightTatics(scene.SceneType);
                                            break;

                                        case SceneType.ARENA_END:
                                            if (this.MatchMapping(ArenaEndPM.GetStrongerButton, 2))
                                            {
                                                this.Log("Arena Lose", this.COLOR_ARENA);
                                                this.ArenaAfterFight(false);
                                            }
                                            else
                                            {
                                                this.Log("Arena Victory", this.COLOR_ARENA);
                                                this.ArenaAfterFight(true);
                                            }
                                            this.CheckArenaScore();
                                            if (this.CurrentObjective == Objective.ARENA)
                                            {
                                                this.WeightedClick(ArenaEndPM.QuickStartButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(ArenaEndPM.LobbyButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            this.LongSleep(2000, 1000);
                                            break;

                                        case SceneType.ARENA_FULL_HONOR_POPUP:
                                            if (this.AISettings.RS_BuyKeyHonors)
                                            {
                                                if (this.CurrentObjective != Objective.BUY_KEYS)
                                                {
                                                    this.ChangeObjective(Objective.BUY_KEYS);
                                                    this.Escape();
                                                }
                                                this.Escape();
                                            }
                                            else
                                            {
                                                this.WeightedClick(ArenaFullHonorPopupPM.YesButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            break;

                                        case SceneType.OUT_OF_SWORDS_POPUP:
                                            if (this.ArenaUseRuby())
                                            {
                                                this.Log(string.Format("Entering arena using Ruby ({0})", this.ArenaRubiesCount + 1), this.COLOR_ARENA);
                                                this.WeightedClick(OutOfSwordsPopupPM.EnterButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(1000);
                                                this.ArenaRubiesCount++;
                                            }
                                            else
                                            {
                                                this.Escape();
                                                this.NextPossibleObjective();
                                            }
                                            SevenKnightsCore.Sleep(1000);
                                            break;

                                        case SceneType.LEVEL_UP_DIALOG:
                                            this.Log("Player Level Up", this.COLOR_LEVEL_UP);
                                            if (this.AISettings.AD_Formation != Formation.None && this.AISettings.AD_HeroManagePositions != null && this.AISettings.AD_HeroManagePositions.Length > 0)
                                            {
                                                this.ChangeObjective(Objective.HERO_MANAGEMENT);
                                            }
                                            this.WeightedClick(LevelUpDialogPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(300);
                                            break;

                                        case SceneType.LEVEL_30_DIALOG:
                                        case SceneType.LEVEL_30_MAX_DIALOG:
                                            this.Log("Hero Level 30", this.COLOR_LEVEL_30);
                                            this.HeroLVUPCount();
                                            
                                            if (this.AISettings.AD_StopOnLV30)
                                            {
                                                this.Alert("Hero Level 30");
                                                this.Escape();
                                                this.AIProfiles.TMP_Paused = true;
                                                break;
                                            }
                                            if (this.AISettings.AD_Formation != Formation.None && this.AISettings.AD_HeroManagePositions != null && this.AISettings.AD_HeroManagePositions.Length > 0)
                                            {
                                                this.ChangeObjective(Objective.HERO_MANAGEMENT);
                                            }
                                            this.WeightedClick(Level30DialogPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(300); 
                                            break;

                                        case SceneType.HEROES:
                                            this.UpdateHeroCount();
                                            if (this.CurrentObjective != Objective.HERO_MANAGEMENT && this.PreviousObjective != Objective.HERO_MANAGEMENT && this.CurrentObjective != Objective.SELL_HEROES && this.PreviousObjective != Objective.SELL_HEROES && this.AISettings.AD_Formation != Formation.None && this.AISettings.AD_HeroManagePositions != null && this.AISettings.AD_HeroManagePositions.Length > 0)
                                            {
                                                this.ChangeObjective(Objective.HERO_MANAGEMENT);
                                            }
                                            if (this.MatchMapping(HeroesPM.BlockingChatCloseButton, 2))
                                            {
                                                this.WeightedClick(HeroesPM.BlockingChatCloseButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.HERO_MANAGEMENT)
                                            {
                                                if (this.AISettings.AD_ElementHeroesOnly)
                                                {
                                                    this.WeightedClick(HeroesPM.ElementButton, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                                                }
                                                this.ManageHeroes();
                                            }
                                            else if (this.CurrentObjective == Objective.SELL_HEROES)
                                            {
                                                if (!this.MatchMapping(HeroesPM.ElementButton, 2))
                                                {
                                                    this.WeightedClick(HeroesPM.ElementButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    this.SellHeroes();
                                                }
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.HEROES_SAME_TEAM_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.HERO_JOIN:
                                            this.Escape();
                                            break;

                                        case SceneType.HERO_REMOVE:
                                            this.Escape();
                                            break;


                                        case SceneType.RAID_DRAGON:
                                            this.Log("The dragon Appears!", this.COLOR_RAID);
                                            SevenKnightsCore.Sleep(1500);
                                            this.WeightedClick(RaidDragonPM.TapArea, 1.0, 1.0, 1, 0, "left");
                                            if (this.AISettings.RD_OwnerDragon)
                                            {
                                                this.DragonFound = true;
                                                this.ChangeObjective(Objective.RAID);
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.RAID_SUMMON_LEVEL:
                                            int lvl = AISettings.RD_SummonLV;
                                            SevenKnightsCore.Sleep(250);
                                            PixelMapping[] array2 = new PixelMapping[]
                                            {
                                           RaidSummonLvlPM.Lv1Button,

                                           RaidSummonLvlPM.Lv2Button,

                                           RaidSummonLvlPM.Lv3Button,

                                           RaidSummonLvlPM.Lv4Button,

                                           RaidSummonLvlPM.Lv5Button,

                                           RaidSummonLvlPM.Lv6Button,

                                           RaidSummonLvlPM.Lv7Button,

                                           RaidSummonLvlPM.Lv8Button,

                                           RaidSummonLvlPM.Lv9Button,

                                           RaidSummonLvlPM.Lv10Button
                                            };
                                            this.WeightedClick(array2[lvl], 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(250);
                                            this.WeightedClick(RaidSummonLvlPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            break;
                                        case SceneType.RAID_LOBBY:
                                            if (this.CurrentObjective == Objective.RAID)
                                            {
                                                if (this.MatchMapping(RaidLobbyPM.RedIconOnDefeatedTab, 2))
                                                {
                                                    this.Log("Go Collect Raid Reward", Color.DarkOrchid);
                                                    this.WeightedClick(RaidLobbyPM.DefeatedTab, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(500);
                                                    this.CaptureFrame();
                                                    if (this.MatchMapping(RaidLobbyPM.EnterButton, 2))
                                                    {
                                                        this.Log("Collect Raid Reward", Color.DarkRed);
                                                        this.WeightedClick(RaidLobbyPM.EnterButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else
                                                    {
                                                        this.Log("No Raid Reward", Color.DarkMagenta);
                                                        this.DoneRaid();
                                                    }
                                                }
                                                else
                                                {
                                                    /*****************จุดกำหนดทดลองตีมังกร**************************/
                                                    //this.DragonFound = true;
                                                    //this.Log("Old Player Name =" + PlayerName, Color.BlueViolet);
                                                    //this.PlayerName = "https://www.facebook.com/mmkkssww";
                                                    //this.Log("New Player Name =" + PlayerName, Color.BlueViolet);
                                                    /****************สิ้นสุดจุดทดสอบตีมังกร***************************/
                                                    this.WeightedClick(RaidLobbyPM.NewTab, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(1000);
                                                    this.CaptureFrame();
                                                    /**************************************เริ่มตรวจหามังกรตัวเอง***********************************************/
                                                    if (this.DragonFound && this.AISettings.RD_ReadNick)
                                                    {
                                                        this.WeightedClick(RaidLobbyPM.AwakenedRaidEnter, 1.0, 1.0, 1, 0, "left");  // กดปุ่ม Refresh
                                                        this.DragonFound = false;
                                                        SevenKnightsCore.Sleep(1000);
                                                        this.WeightedClick(RaidLobbyPM.RefreshButton, 1.0, 1.0, 1, 0, "left");  // กดปุ่ม Refresh
                                                        SevenKnightsCore.Sleep(2000);
                                                        this.ScrollRaidDragonPage(false);
                                                        SevenKnightsCore.Sleep(2000);
                                                        this.Log("Owner Name = " + PlayerName, Color.BlueViolet);
                                                        int i = 1;    // ตัวสำหรับตรวจสอบว่าเจอมังกรรึยัง
                                                        while (i != 0 && !this.Worker.CancellationPending)
                                                        {
                                                            SevenKnightsCore.Sleep(1000);
                                                            this.CaptureFrame();
                                                            if (this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn0, 4) && this.AISettings.RD_ReadNick)  //ตรวจสอบ ถ้า ยึดบน ทำอันนี้ ตรวจสอบหน้าที่ 1 หรือหน้าที่ 2
                                                            {
                                                                int NameLocation = 0;
                                                                string ckname0 = "mmkkssww";
                                                                string ckname1 = "mmkkssww";
                                                                string ckname2 = "mmkkssww";
                                                                string ckname3 = "mmkkssww";
                                                                string Name0 = CheckDragonNameUpToDown(NameLocation);
                                                                string Name1 = CheckDragonNameUpToDown(NameLocation + 1);
                                                                string Name2 = CheckDragonNameUpToDown(NameLocation + 2);
                                                                string Name3 = CheckDragonNameUpToDown(NameLocation + 3);

                                                                this.Log(string.Format("Dragon1 Name :{0}", Name0), Color.BlueViolet);
                                                                this.Log(string.Format("Dragon2 Name :{0}", Name1), Color.BlueViolet);
                                                                this.Log(string.Format("Dragon3 Name :{0}", Name2), Color.BlueViolet);
                                                                this.Log(string.Format("Dragon4 Name :{0}", Name3), Color.BlueViolet);
                                                                if (Name0 == PlayerName)
                                                                {
                                                                    this.Log(string.Format("Match Dragon1 Name :{0}", Name0), this.COLOR_RAID);
                                                                    SevenKnightsCore.Sleep(1000);
                                                                    this.WeightedClick(RaidLobbyPM.RaidUpToDownBtn0, 1.0, 1.0, 1, 0, "left");
                                                                    SevenKnightsCore.Sleep(3000);
                                                                    i = 0;
                                                                    break;
                                                                }
                                                                else if (Name1 == PlayerName)
                                                                {
                                                                    this.Log(string.Format("Match Dragon2 Name :{0}", Name1), this.COLOR_RAID);
                                                                    SevenKnightsCore.Sleep(1000);
                                                                    this.WeightedClick(RaidLobbyPM.RaidUpToDownBtn1, 1.0, 1.0, 1, 0, "left");
                                                                    SevenKnightsCore.Sleep(3000);
                                                                    i = 0;
                                                                    break;
                                                                }
                                                                else if (Name2 == PlayerName)
                                                                {
                                                                    this.Log(string.Format("Match Dragon3 Name :{0}", Name2), this.COLOR_RAID);
                                                                    SevenKnightsCore.Sleep(1000);
                                                                    this.WeightedClick(RaidLobbyPM.RaidUpToDownBtn2, 1.0, 1.0, 1, 0, "left");
                                                                    SevenKnightsCore.Sleep(3000);
                                                                    i = 0;
                                                                    break;
                                                                }
                                                                else if (Name3 == PlayerName)
                                                                {
                                                                    this.Log(string.Format("Match Dragon4 Name :{0}", Name3), this.COLOR_RAID);
                                                                    SevenKnightsCore.Sleep(1000);
                                                                    this.WeightedClick(RaidLobbyPM.RaidUpToDownBtn3, 1.0, 1.0, 1, 0, "left");
                                                                    SevenKnightsCore.Sleep(3000);
                                                                    i = 0;
                                                                    break;
                                                                }
                                                                // ตรวจมีมังกรแค่ 4 ตัว
                                                                else if ((ckname0 == Name0) || (ckname1 == Name1) || (ckname2 == Name2) || (ckname3 == Name3))
                                                                {
                                                                    this.Log("Not Found Owner Dragon", Color.PaleVioletRed);
                                                                    i = 0;
                                                                    this.DoneRaid();
                                                                    break;
                                                                }
                                                                // ถ้าตรวจสอบแล้ว มังกรหมด ให้จบ
                                                                else if (!this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn0, 2) || !this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn1, 2) || !this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn2, 2) || !this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn3, 2))
                                                                {
                                                                    this.Log("Not Found Owner Dragon", Color.PaleVioletRed);
                                                                    i = 0;
                                                                    this.DoneRaid();
                                                                    break;
                                                                }
                                                                else // เลื่อนหน้าจอ
                                                                {
                                                                    ckname0 = Name0;
                                                                    ckname1 = Name1;
                                                                    ckname2 = Name2;
                                                                    ckname3 = Name3;
                                                                    this.ScrollRaidPage(true);
                                                                    this.Log("Find Next..", this.COLOR_RAID);
                                                                    SevenKnightsCore.Sleep(1000);
                                                                } 
                                                            }
                                                            else if (this.MatchMapping(RaidLobbyPM.RaidDownToUpBtn0, 2) && this.AISettings.RD_ReadNick) // ถ้า ยึดล่าง ทำอันนี้   ตรวจสอบหน้าสุดท้าย
                                                            {
                                                                int NameLocation = 0;
                                                                string Name0 = CheckDragonNameDownToUp(NameLocation);
                                                                string Name1 = CheckDragonNameDownToUp(NameLocation + 1);
                                                                string Name2 = CheckDragonNameDownToUp(NameLocation + 2);
                                                                string Name3 = CheckDragonNameDownToUp(NameLocation + 3);

                                                                this.Log(string.Format("Dragon1 Name :{0}", Name0), Color.BlueViolet);
                                                                this.Log(string.Format("Dragon2 Name :{0}", Name1), Color.BlueViolet);
                                                                this.Log(string.Format("Dragon3 Name :{0}", Name2), Color.BlueViolet);
                                                                this.Log(string.Format("Dragon4 Name :{0}", Name3), Color.BlueViolet);

                                                                if (Name0 == PlayerName)
                                                                {
                                                                    this.Log(string.Format("Match Dragon1 Name :{0}", Name0), this.COLOR_RAID);
                                                                    SevenKnightsCore.Sleep(1000);
                                                                    this.WeightedClick(RaidLobbyPM.RaidDownToUpBtn0, 1.0, 1.0, 1, 0, "left");
                                                                    SevenKnightsCore.Sleep(3000);
                                                                    i = 0;
                                                                    break;
                                                                }
                                                                else if (Name1 == PlayerName)
                                                                {
                                                                    this.Log(string.Format("Match Dragon2 Name :{0}", Name1), this.COLOR_RAID);
                                                                    SevenKnightsCore.Sleep(1000);
                                                                    this.WeightedClick(RaidLobbyPM.RaidDownToUpBtn1, 1.0, 1.0, 1, 0, "left");
                                                                    SevenKnightsCore.Sleep(3000);
                                                                    i = 0;
                                                                    break;
                                                                }
                                                                else if (Name2 == PlayerName)
                                                                {
                                                                    this.Log(string.Format("Match Dragon3 Name :{0}", Name2), this.COLOR_RAID);
                                                                    SevenKnightsCore.Sleep(1000);
                                                                    this.WeightedClick(RaidLobbyPM.RaidDownToUpBtn2, 1.0, 1.0, 1, 0, "left");
                                                                    SevenKnightsCore.Sleep(3000);
                                                                    i = 0;
                                                                    break;
                                                                }
                                                                else if (Name3 == PlayerName)
                                                                {
                                                                    this.Log(string.Format("Match Dragon4 Name :{0}", Name3), this.COLOR_RAID);
                                                                    SevenKnightsCore.Sleep(1000);
                                                                    this.WeightedClick(RaidLobbyPM.RaidDownToUpBtn3, 1.0, 1.0, 1, 0, "left");
                                                                    SevenKnightsCore.Sleep(3000);
                                                                    i = 0;
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    i = 0;
                                                                    this.Log("Not Found Owner Dragon", Color.PaleVioletRed);
                                                                    this.DoneRaid();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                this.Log("Not Found Owner Dragon", Color.PaleVioletRed);
                                                                i = 0;
                                                                this.DoneRaid();
                                                                break;
                                                            }
                                                        }
                                                        this.CaptureFrame();
                                                        scene = this.SceneSearch();
                                                        SevenKnightsCore.Sleep(2000);
                                                        break;
                                                    }
                                                    /************************************** จุดตรวจสอบ Level ของมังกร **********************************/
                                                    if (AISettings.RD_LevelCheckBox) 
                                                    {
                                                        this.WeightedClick(RaidLobbyPM.RefreshButton, 1.0, 1.0, 1, 0, "left");  // กดปุ่ม Refresh
                                                        SevenKnightsCore.Sleep(2000);
                                                        this.ScrollRaidDragonPage(false);
                                                        SevenKnightsCore.Sleep(1000);
                                                        int i = 1;
                                                        int chkhp = 0;
                                                        while (i != 0 && !this.Worker.CancellationPending)
                                                        {
                                                            SevenKnightsCore.Sleep(2000);
                                                            this.CaptureFrame();
                                                            if (this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn0, 2))    // ถ้ายึดจากด้านบน
                                                            {
                                                                int LvlLocation = 0;
                                                                int PercentHP0, PercentHP1, PercentHP2, PercentHP3;
                                                                int LvlLoca0 = CheckDragonLvlUpToDown(LvlLocation);
                                                                int LvlLoca1 = CheckDragonLvlUpToDown(LvlLocation + 1);
                                                                int LvlLoca2 = CheckDragonLvlUpToDown(LvlLocation + 2);
                                                                int LvlLoca3 = CheckDragonLvlUpToDown(LvlLocation + 3);

                                                                int hp0f = CheckHPDownToUpF(LvlLocation);
                                                                int hp0b = CheckHPDownToUpB(LvlLocation);
                                                                int hp1f = CheckHPDownToUpF(LvlLocation + 1);
                                                                int hp1b = CheckHPDownToUpB(LvlLocation + 1);
                                                                int hp2f = CheckHPDownToUpF(LvlLocation + 2);
                                                                int hp2b = CheckHPDownToUpB(LvlLocation + 2);
                                                                int hp3f = CheckHPDownToUpF(LvlLocation + 3);
                                                                int hp3b = CheckHPDownToUpB(LvlLocation + 3);

                                                                if (this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn0, 2))
                                                                {
                                                                    if (hp0b >= hp0f)       // ฟังชั่นตรวจสอบตัวหน้ามากกว่า HP ทั้งหมด
                                                                    {
                                                                        PercentHP0 = (hp0f * 100) / hp0b;
                                                                    }
                                                                    else
                                                                    {
                                                                        PercentHP0 = 0;
                                                                    }
                                                                    this.Log(string.Format("Dragon1 Lv.{0}, HP: {1}%", LvlLoca0, PercentHP0), Color.BlueViolet);
                                                                    if (LvlLoca0 >= AISettings.RD_DragonLV && LvlLoca0  <= this.AISettings.RD_DragonLVLimit 
                                                                        && PercentHP0 >= AISettings.RD_DragonHP && PercentHP0 <= this.AISettings.RD_DragonHPLimit)
                                                                    {
                                                                        this.Log(string.Format("Match Dragon1 Lv.{0}, HP: {1}%", LvlLoca0, PercentHP0), this.COLOR_RAID);
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        this.WeightedClick(RaidLobbyPM.RaidUpToDownBtn0, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        i = 0;
                                                                        break;
                                                                    }
                                                                }
                                                                if (this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn1, 2))
                                                                {
                                                                    if(hp1b >= hp1f)
                                                                    {
                                                                        PercentHP1 = (hp1f * 100) / hp1b;
                                                                    }
                                                                    else
                                                                    {
                                                                        PercentHP1 = 0;
                                                                    }
                                                                    this.Log(string.Format("Dragon2 Lv.{0}, HP: {1}%", LvlLoca1, PercentHP1), Color.BlueViolet);
                                                                    if (LvlLoca1 >= AISettings.RD_DragonLV && LvlLoca1 <= this.AISettings.RD_DragonLVLimit 
                                                                        && PercentHP1 >= AISettings.RD_DragonHP && PercentHP1 <= this.AISettings.RD_DragonHPLimit)
                                                                    {
                                                                        this.Log(string.Format("Match Dragon2 Lv.{0}, HP: {1}%", LvlLoca1, PercentHP1), this.COLOR_RAID);
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        this.WeightedClick(RaidLobbyPM.RaidUpToDownBtn1, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        i = 0;
                                                                        break;
                                                                    }
                                                                }
                                                                if (this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn2, 2))
                                                                {
                                                                    if (hp2b >= hp2f)
                                                                    {
                                                                        PercentHP2 = (hp2f * 100) / hp2b;
                                                                    }
                                                                    else
                                                                    {
                                                                        PercentHP2 = 0;
                                                                    }
                                                                    this.Log(string.Format("Dragon3 Lv.{0}, HP: {1}%", LvlLoca2, PercentHP2), Color.BlueViolet);
                                                                    if (LvlLoca2 >= AISettings.RD_DragonLV && LvlLoca2 <= this.AISettings.RD_DragonLVLimit 
                                                                        && PercentHP2 >= AISettings.RD_DragonHP && PercentHP2 <= this.AISettings.RD_DragonHPLimit)
                                                                    {
                                                                        this.Log(string.Format("Match Dragon3 Lv.{0}, HP: {1}%", LvlLoca2, PercentHP2), this.COLOR_RAID);
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        this.WeightedClick(RaidLobbyPM.RaidUpToDownBtn2, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        i = 0;
                                                                        break;
                                                                    } 
                                                                }
                                                                if (this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn3, 2))
                                                                {
                                                                    if (hp3b >= hp3f)
                                                                    {
                                                                        PercentHP3 = (hp3f * 100) / hp3b;
                                                                    }
                                                                    else
                                                                    {
                                                                        PercentHP3 = 0;
                                                                    }
                                                                    this.Log(string.Format("Dragon4 Lv.{0}, HP: {1}%", LvlLoca3, PercentHP3), Color.BlueViolet);
                                                                    if (LvlLoca3 >= AISettings.RD_DragonLV && LvlLoca3 <= this.AISettings.RD_DragonLVLimit
                                                                        && PercentHP3 >= AISettings.RD_DragonHP && PercentHP3 <= this.AISettings.RD_DragonHPLimit)
                                                                    {
                                                                        this.Log(string.Format("Match Dragon4 Lv.{0}, HP: {1}%", LvlLoca3, PercentHP3), this.COLOR_RAID);
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        this.WeightedClick(RaidLobbyPM.RaidUpToDownBtn3, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        i = 0;
                                                                        break;
                                                                    }   
                                                                }
                                                                if (chkhp == hp0f)
                                                                {
                                                                    this.Log("Does not meet the conditions", Color.PaleVioletRed);
                                                                    i = 0;
                                                                    this.DoneRaid();
                                                                }
                                                                // ถ้าตรวจสอบแล้ว มังกรหมด ให้จบ
                                                                if (!this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn0, 2) || !this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn1, 2) || !this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn2, 2) || !this.MatchMapping(RaidLobbyPM.RaidUpToDownBtn3, 2))
                                                                {
                                                                    this.Log("Does not meet the conditions", Color.PaleVioletRed);
                                                                    i = 0;
                                                                    this.DoneRaid();
                                                                    break;
                                                                }
                                                                // เลื่อนหน้าจอ
                                                                chkhp = hp0f;
                                                                this.ScrollRaidPage(true);
                                                                this.Log("Find Next..", this.COLOR_RAID);
                                                                SevenKnightsCore.Sleep(1500);
                                                            }
                                                            else if (this.MatchMapping(RaidLobbyPM.RaidDownToUpBtn0, 2)) // ถ้า ยึดล่าง ทำอันนี้   ตรวจสอบหน้าสุดท้าย
                                                            {
                                                                int LvlLocation = 0;
                                                                int PercentHP0, PercentHP1, PercentHP2, PercentHP3;
                                                                int LvlLoca0 = CheckDragonLvlDownToUp(LvlLocation);
                                                                int LvlLoca1 = CheckDragonLvlDownToUp(LvlLocation + 1);
                                                                int LvlLoca2 = CheckDragonLvlDownToUp(LvlLocation + 2);
                                                                int LvlLoca3 = CheckDragonLvlDownToUp(LvlLocation + 3);

                                                                int hp0f = CheckHPUpToDownF(LvlLocation);
                                                                int hp0b = CheckHPUpToDownB(LvlLocation);
                                                                int hp1f = CheckHPUpToDownF(LvlLocation + 1);
                                                                int hp1b = CheckHPUpToDownB(LvlLocation + 1);
                                                                int hp2f = CheckHPUpToDownF(LvlLocation + 2);
                                                                int hp2b = CheckHPUpToDownB(LvlLocation + 2);
                                                                int hp3f = CheckHPUpToDownF(LvlLocation + 3);
                                                                int hp3b = CheckHPUpToDownB(LvlLocation + 3);

                                                                if (this.MatchMapping(RaidLobbyPM.RaidDownToUpBtn0, 2))
                                                                {
                                                                    if (hp0b >= hp0f)
                                                                    {
                                                                        PercentHP0 = (hp0f * 100) / hp0b;
                                                                    }
                                                                    else
                                                                    {
                                                                        PercentHP0 = 0;
                                                                    }
                                                                    this.Log(string.Format("Dragon1 Lv.{0}, HP: {1}%", LvlLoca0, PercentHP0), Color.BlueViolet);
                                                                    if (LvlLoca0 >= AISettings.RD_DragonLV && LvlLoca0 <= this.AISettings.RD_DragonLVLimit
                                                                        && PercentHP0 >= AISettings.RD_DragonHP && PercentHP0 <= this.AISettings.RD_DragonHPLimit)
                                                                    {
                                                                        this.Log(string.Format("Match Dragon1 Lv.{0}, HP: {1}%", LvlLoca0, PercentHP0), this.COLOR_RAID);
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        this.WeightedClick(RaidLobbyPM.RaidDownToUpBtn0, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        i = 0;
                                                                        break;
                                                                    }
                                                                }
                                                                if (this.MatchMapping(RaidLobbyPM.RaidDownToUpBtn1, 2))
                                                                {
                                                                    if (hp1b >= hp1f)
                                                                    {
                                                                        PercentHP1 = (hp1f * 100) / hp1b;
                                                                    }
                                                                    else
                                                                    {
                                                                        PercentHP1 = 0;
                                                                    }
                                                                    this.Log(string.Format("Dragon2 Lv.{0}, HP: {1}%", LvlLoca1, PercentHP1), Color.BlueViolet);
                                                                    if (LvlLoca1 >= AISettings.RD_DragonLV && LvlLoca1 <= this.AISettings.RD_DragonLVLimit
                                                                        && PercentHP1 >= AISettings.RD_DragonHP && PercentHP1 <= this.AISettings.RD_DragonHPLimit)
                                                                    {
                                                                        this.Log(string.Format("Match Dragon2 Lv.{0}, HP: {1}%", LvlLoca1, PercentHP1), this.COLOR_RAID);
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        this.WeightedClick(RaidLobbyPM.RaidDownToUpBtn1, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        i = 0;
                                                                        break;
                                                                    }
                                                                }
                                                                if (this.MatchMapping(RaidLobbyPM.RaidDownToUpBtn2, 2))
                                                                {
                                                                    if (hp2b >= hp2f)
                                                                    {
                                                                        PercentHP2 = (hp2f * 100) / hp2b;
                                                                    }
                                                                    else
                                                                    {
                                                                        PercentHP2 = 0;
                                                                    }
                                                                    this.Log(string.Format("Dragon3 Lv.{0}, HP: {1}%", LvlLoca2, PercentHP2), Color.BlueViolet);
                                                                    if (LvlLoca2 >= AISettings.RD_DragonLV && LvlLoca2 <= this.AISettings.RD_DragonLVLimit
                                                                        && PercentHP2 >= AISettings.RD_DragonHP && PercentHP2 <= this.AISettings.RD_DragonHPLimit)
                                                                    {
                                                                        this.Log(string.Format("Match Dragon3 Lv.{0}, HP: {1}%", LvlLoca2, PercentHP2), this.COLOR_RAID);
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        this.WeightedClick(RaidLobbyPM.RaidDownToUpBtn2, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        i = 0;
                                                                        break;
                                                                    }  
                                                                }
                                                                if (this.MatchMapping(RaidLobbyPM.RaidDownToUpBtn3, 2))
                                                                {
                                                                    if (hp3b >= hp3f)
                                                                    {
                                                                        PercentHP3 = (hp3f * 100) / hp3b;
                                                                    }
                                                                    else
                                                                    {
                                                                        PercentHP3 = 0;
                                                                    }
                                                                    this.Log(string.Format("Dragon4 Lv.{0}, HP: {1}%", LvlLoca3, PercentHP3), Color.BlueViolet);
                                                                    if (LvlLoca3 >= AISettings.RD_DragonLV && LvlLoca3 <= this.AISettings.RD_DragonLVLimit
                                                                        && PercentHP3 >= AISettings.RD_DragonHP && PercentHP3 <= this.AISettings.RD_DragonHPLimit)
                                                                    {
                                                                        this.Log(string.Format("Match Dragon4 Lv.{0}, HP: {1}%", LvlLoca3, PercentHP3), this.COLOR_RAID);
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        this.WeightedClick(RaidLobbyPM.RaidDownToUpBtn3, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(1000);
                                                                        i = 0;
                                                                        break;
                                                                    }    
                                                                }
                                                                i = 0;
                                                                this.Log("Does not meet the conditions", Color.PaleVioletRed);
                                                                this.DoneRaid();
                                                            }
                                                            else
                                                            {
                                                                i = 0;
                                                                this.DoneRaid();
                                                            }
                                                        }
                                                        this.CaptureFrame();
                                                        scene = this.SceneSearch();
                                                        SevenKnightsCore.Sleep(1000);
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        this.WeightedClick(RaidLobbyPM.EnterButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                }
                                                this.MasteryChecked = !this.MasteryChecked;
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.RAID_READY:
                                            SevenKnightsCore.Sleep(300);
                                            this.ParseEntred();
                                            if (this.CurrentObjective == Objective.RAID)
                                            {
                                                this.WeightedClick(RaidReadyPM.ReadyButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                                SevenKnightsCore.Sleep(800);
                                                this.DoneRaid();
                                            }
                                            break;

                                        case SceneType.RAID_START:
                                            if (this.CurrentObjective == Objective.RAID)
                                            {
                                                this.WeightedClick(RaidStartPM.StartButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(300);
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.RAID_FIGHT:
                                            this.PerformFightTatics(scene.SceneType);
                                            break;

                                        case SceneType.RAID_END:
                                            this.RaidAfterFight();
                                            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI will collect the reward and if there is any.");
                                            this.WeightedClick(RaidEndPM.AgainButton, 1.0, 1.0, 1, 0, "left");
                                            this.LongSleep(2000, 1000);
                                            break;

                                        case SceneType.RAID_REWARD:
                                            if (this.CurrentObjective == Objective.RAID)
                                            {
                                                this.WeightedClick(RaidRewardPM.RewardButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(300);
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.RAID_REWARD_POPUP:
                                            this.DoneRaid();
                                            break;

                                        case SceneType.RAID_REWARD_FAILED_POPUP:
                                            this.DoneRaid();
                                            break;

                                        case SceneType.RAID_OUT_OF_KEYS_POPUP:
                                            if (!flag3)
                                            {
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "[Raid] AI will buy more keys or play other modes while waiting.");
                                                flag3 = true;
                                            }
                                            this.Escape();
                                            SevenKnightsCore.Sleep(800);
                                            this.CaptureFrame();
                                            if (this.MatchMapping(RaidReadyPM.AwakenBlueIcon, 2) && this.MatchMapping(RaidReadyPM.AwakenDragonImg, 2))
                                            {
                                                this.Escape();
                                            }
                                            this.DoneRaid();
                                            break;

                                        case SceneType.RAID_ALREADY_ENDED_POPUP:
                                            this.DoneRaid();
                                            break;

                                        case SceneType.RAID_SUMMON_LOBBY:
                                            
                                            if (this.CurrentObjective == Objective.RAID && this.DragonFound == true)
                                            {
                                                this.WeightedClick(RaidLobbyPM.AwakenedRaidEnter, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(RaidLobbyPM.NewTab, 1.0, 1.0, 1, 0, "left");
                                            }
                                            break;

                                        case SceneType.RAID_AWAKENED_READY:
                                            if (this.CurrentObjective == Objective.RAID && this.AISettings.ARD_Enable)
                                            {
                                                this.WeightedClick(RaidReadyPM.AwakenedReadyButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                                this.DoneRaid();
                                            }
                                            break;

                                        case SceneType.RAID_AWAKENED_START:
                                            if (this.CurrentObjective == Objective.RAID)
                                            {
                                                this.WeightedClick(RaidStartPM.StartButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(300);
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.ENTER_RAID_AGAIN_POPUP:
                                            this.DoneRaid();
                                            break;

                                        case SceneType.SELL_HERO_CONFIRM_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SELL_ITEM_POPUP:
                                            if (this.AISettings.RS_SellItems)
                                            {
                                                if (this.CurrentObjective != Objective.SELL_ITEMS)
                                                {
                                                    this.ChangeObjective(Objective.SELL_ITEMS);
                                                }
                                                this.SellItems();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SELL_ITEM_CONFIRM_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.LOOT_HERO:
                                            this.Escape();
                                            break;

                                        case SceneType.LOOT_ITEM:
                                            this.Escape();
                                            break;

                                        case SceneType.SHOP_LOBBY:
                                            if (this.CurrentObjective == Objective.BUY_KEYS)
                                            {
                                                this.WeightedClick(ShopPM.CommonShop, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SHOP:
                                            this.UpdateTopaz(scene.SceneType);
                                            if (this.CurrentObjective == Objective.BUY_KEYS)
                                            {
                                                this.BuyKeys();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SHOP_BUY_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SHOP_BUY_FAILED_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SHOP_PURCHASE_COMPLETE_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.INBOX:
                                            if (this.IsInboxEnabled())
                                            {
                                                if (this.CurrentObjective != Objective.COLLECT_INBOX && this.PreviousObjective != Objective.COLLECT_INBOX)
                                                {
                                                    this.ChangeObjective(Objective.COLLECT_INBOX);
                                                }
                                                if (this.CurrentObjective == Objective.COLLECT_INBOX)
                                                {
                                                    this.CollectInbox();
                                                }
                                                else
                                                {
                                                    this.Escape();
                                                }
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.INBOX_REWARDS_POPUP:
                                            this.WeightedClick(SharedPM.Rewards_OkButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.INBOX_COLLECT_FAILED_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.INBOX_SELECT_HERO:
                                            this.Escape();
                                            break;

                                        case SceneType.QUEST_SELECT:
                                            if (this.CurrentObjective == Objective.COLLECT_QUESTS && this.IsAnyQuestsEnabled())
                                            {
                                                bool flag6 = this.IsSpecialQuestsEnabled() && this.MatchMapping(QuestSelectPM.SpecialQuestAvailable, 4);
                                                bool flag7 = this.IsQuestsEnabled() && this.MatchMapping(QuestSelectPM.QuestAvailable, 4);
                                                if (this.CollectQuestsTotal == -1 || this.CollectQuestsCount == -1)
                                                {
                                                    this.CollectQuestsCount = 0;
                                                    this.CollectQuestsTotal = 0;
                                                    if (flag6)
                                                    {
                                                        this.CollectQuestsTotal++;
                                                    }
                                                    if (flag7)
                                                    {
                                                        this.CollectQuestsTotal++;
                                                    }
                                                }
                                                if (this.CollectQuestsCount == 0 && this.CollectQuestsTotal == 1)
                                                {
                                                    if (flag6)
                                                    {
                                                        this.WeightedClick(QuestSelectPM.SpecialQuestButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if (flag7)
                                                    {
                                                        this.WeightedClick(QuestSelectPM.QuestButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                }
                                                else if (this.CollectQuestsCount == 0 && this.CollectQuestsTotal == 2)
                                                {
                                                    this.WeightedClick(QuestSelectPM.SpecialQuestButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    if (this.CollectQuestsCount != 1 || this.CollectQuestsTotal != 2)
                                                    {
                                                        this.DoneCollectAllQuests();
                                                        break;
                                                    }
                                                    this.WeightedClick(QuestSelectPM.QuestButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                this.LongSleep(1000, 1000);
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SPECIAL_QUEST:
                                            if (this.CurrentObjective == Objective.COLLECT_QUESTS && this.IsSpecialQuestsEnabled())
                                            {
                                                this.CollectSpecialQuests();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.QUEST:
                                            if (this.CurrentObjective == Objective.COLLECT_QUESTS && this.IsQuestsEnabled())
                                            {
                                                this.CollectQuests();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.QUEST_REWARDS_POPUP:
                                            this.WeightedClick(SharedPM.Rewards_OkButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.QUEST_COLLECT_FAILED_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SOCIAL_SELECT:
                                            if (this.CurrentObjective == Objective.SEND_HONORS && this.IsSendHonorsEnabled())
                                            {
                                                this.WeightedClick(SocialSelectPM.FriendsButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(500);
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.FRIENDS:
                                            if (this.CurrentObjective == Objective.SEND_HONORS && this.IsSendHonorsEnabled())
                                            {
                                                this.SendHonors();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SEND_HONOR_SENDING_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SEND_HONOR_FAILED_POPUP:
                                            this.WeightedClick(SendHonorFailedPopupPM.YellowTick, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.SEND_HONOR_CONFIRM_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SEND_HONOR_FULL_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.RACHEL_SPECIAL_PACK_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.RACHEL_SPECIAL_PACK_CLOSE_POPUP:
                                            this.WeightedClick(Popup3PM.SPrachelCloseOKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.ALICE_PRO_PACK_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.ALICE_PRO_PACK_CLOSE_POPUP:
                                            this.WeightedClick(Popup3PM.AliceProCloseOKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.MAY_LUCKY_BOX_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.MAY_LUCKY_BOX_CLOSE_POPUP:
                                            this.WeightedClick(Popup3PM.MayCloseOKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.MAY_CALENDAR_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.EVENT_PACKAGE_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.EVENT_PACKAGE_CLOSE_POPUP:
                                            this.WeightedClick(Popup3PM.EvenCloseOKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.ARENA_WEEK_REWARD:
                                            this.Escape();
                                            break;

                                        case SceneType.DAILY_QUEST_COMPLETE:
                                            this.WeightedClick(QuestRewardsPopupPM.OKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.STATUS_BOARD:
                                            SevenKnightsCore.Sleep(300);
                                            if (this.MatchMapping(StatusBoardPM.ContentsTabSelect, 2) && this.MatchMapping(StatusBoardPM.HottimeRedIcon, 2))
                                            {
                                                this.WeightedClick(StatusBoardPM.HottimeTab, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(800);
                                                this.WeightedClick(StatusBoardPM.ActiveHottimeButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.DoneHottime();
                                            }
                                            break;

                                        case SceneType.HOTTIME_CONFIRM_POPUP:
                                            if (this.MatchMapping(StatusBoardPM.ConfirmOKtick, 2) && this.MatchMapping(StatusBoardPM.NoRedCloss, 2) && this.MatchMapping(StatusBoardPM.ActiveBG, 2))
                                            {
                                                this.WeightedClick(StatusBoardPM.OKButton, 1.0, 1.0, 1, 0, "left");
                                                this.Log("Hottime Active", Color.Brown);
                                                this.DoneHottime();
                                            }
                                            break;

                                        case SceneType.EXCLUSIVE_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.EXCLUSIVE_CLOSE_POPUP:
                                            this.WeightedClick(Popup3PM.MayCloseOKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.ELEMENT_POPUP:
                                            this.WeightedClick(Popup3PM.ElementCloseButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.SELL_HERO_FINISH:
                                            this.WeightedClick(SellHeroConfirmPopupPM.SoldOKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.RANK_UP:
                                            this.WeightedClick(ArenaEndPM.RankUpTik, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.SELL_HERO_LOBBY:
                                            this.Escape();
                                            break;

                                        case SceneType.YEAR_END_AWAKE:
                                            this.Escape();
                                            break;

                                        case SceneType.YEAR_END_AWAKE_POPUP:
                                            this.WeightedClick(Popup3PM.MayCloseOKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.HELPED_FRIEND:
                                            this.Escape();
                                            break;

                                        case SceneType.EXIT_POPUP:
                                            this.WeightedClick(Popup3PM.ExitNo, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.SPECIAL_DUN_READY:
                                            if (this.CurrentObjective == Objective.SPECIAL_DUNGEON && this.AISettings.SP_Enable)
                                            {
                                                if(this.AISettings.SP_DailyEnable && this.sp_dailycount < this.AISettings.SP_DailyLimit)
                                                {
                                                    this.sp_dailyflag = true;
                                                    this.WeightedClick(SpecialDungeonReady.DailyTab, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    this.WeightedClick(SpecialDungeonReady.SelectMode, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    if (this.AISettings.SP_DailyNormal)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR1, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if(this.AISettings.SP_DailyHard)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR2, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if(this.AISettings.SP_DailyHell)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR3, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    SevenKnightsCore.Sleep(800);
                                                    this.WeightedClick(SpecialDungeonReady.ReadyButton, 1.0, 1.0, 1, 0, "left");

                                                }// AwakenTab 1
                                                else if(this.AISettings.SP_CakeEnable && this.sp_row1count < this.AISettings.SP_CakeLimit)
                                                {
                                                    this.sp_row1flag = true;
                                                    this.WeightedClick(SpecialDungeonReady.AwakenTab, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    this.ScrollSpecialdunPage(false);
                                                    SevenKnightsCore.Sleep(1000);
                                                    // เลือกดัน
                                                    this.WeightedClick(SpecialDungeonReady.Row1Select, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);

                                                    //เลือกโหมด
                                                    this.WeightedClick(SpecialDungeonReady.SelectMode, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    if (this.AISettings.SP_CakeEasy)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR1, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if(this.AISettings.SP_CakeNormal)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR2, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if(this.AISettings.SP_CakeHard)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR3, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    SevenKnightsCore.Sleep(800);
                                                    this.WeightedClick(SpecialDungeonReady.ReadyButton, 1.0, 1.0, 1, 0, "left");

                                                } // AwakenTab 2
                                                else if(this.AISettings.SP_CrystalEnable && this.sp_row2count < this.AISettings.SP_CrystalLimit)
                                                {
                                                    this.sp_row2flag = true;
                                                    this.WeightedClick(SpecialDungeonReady.AwakenTab, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    this.ScrollSpecialdunPage(false);
                                                    SevenKnightsCore.Sleep(1000);
                                                    //เลือกดัน
                                                    this.WeightedClick(SpecialDungeonReady.Row2Select, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);

                                                    //เลือกโหมด
                                                    this.WeightedClick(SpecialDungeonReady.SelectMode, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    if (this.AISettings.SP_CrystalEasy)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR1, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if(this.AISettings.SP_CrystalNormal)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR2, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if(this.AISettings.SP_CrystalHard)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR3, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    SevenKnightsCore.Sleep(800);
                                                    this.WeightedClick(SpecialDungeonReady.ReadyButton, 1.0, 1.0, 1, 0, "left");

                                                } //AwakenTab 3
                                                else if(this.AISettings.SP_EvanEnable && this.sp_row3count < this.AISettings.SP_EvanLimit)
                                                {
                                                    this.sp_row3flag = true;
                                                    this.WeightedClick(SpecialDungeonReady.AwakenTab, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    this.ScrollSpecialdunPage(false);
                                                    SevenKnightsCore.Sleep(1000);
                                                    //เลือกดัน
                                                    this.WeightedClick(SpecialDungeonReady.Row3Select, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    //เลือกโหมด
                                                    this.WeightedClick(SpecialDungeonReady.SelectMode, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    if (this.AISettings.SP_EvanNormal)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR1, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if (this.AISettings.SP_EvanHard)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR2, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if (this.AISettings.SP_EvanHell)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR3, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    SevenKnightsCore.Sleep(800);
                                                    this.WeightedClick(SpecialDungeonReady.ReadyButton, 1.0, 1.0, 1, 0, "left");

                                                }  //AwakenTab 4
                                                else if(this.AISettings.SP_KarinEnable && this.sp_row4count < this.AISettings.SP_KarinLimit)
                                                {
                                                    this.sp_row4flag = true;
                                                    this.WeightedClick(SpecialDungeonReady.AwakenTab, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    this.ScrollSpecialdunPage(false);
                                                    SevenKnightsCore.Sleep(1000);
                                                    //เลือกดัน
                                                    this.WeightedClick(SpecialDungeonReady.Row4Select, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    //เลือกโหมด
                                                    this.WeightedClick(SpecialDungeonReady.SelectMode, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(800);
                                                    if (this.AISettings.SP_karinNormal)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR1, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if (this.AISettings.SP_karinHard)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR2, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if (this.AISettings.SP_karinHell)
                                                    {
                                                        this.WeightedClick(SpecialDungeonReady.ModeR3, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    SevenKnightsCore.Sleep(800);
                                                    this.WeightedClick(SpecialDungeonReady.ReadyButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    this.NextPossibleObjective();
                                                }
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SPECIAL_DUN_START:
                                            if (this.CurrentObjective == Objective.SPECIAL_DUNGEON && this.AISettings.SP_Enable)
                                            {
                                                this.WeightedClick(SpecialDungeonStartPM.StartButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SPECIAL_DUN_FIGHT:
                                            this.PerformFightTatics(scene.SceneType);
                                            break;

                                        case SceneType.SPECIAL_DUN_LOOT:
                                            this.SpecialDunAfterFight();
                                            if (this.CurrentObjective == Objective.SPECIAL_DUNGEON)
                                            {
                                                this.WeightedClick(SpecialDungeonLootPM.AgainButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(SharedPM.Loot_LobbyButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            break;

                                        case SceneType.SP_OUT_OF_KEYS:
                                            if (this.CurrentObjective != Objective.BUY_KEYS && this.AISettings.RS_BuyKeyHonors && this.KeysBoughtHonors < this.AISettings.RS_BuyKeyHonorsAmount)
                                            {
                                                this.Escape();
                                                this.ChangeObjective(Objective.BUY_KEYS);
                                            }
                                            else
                                            {
                                                this.Escape();
                                                this.NextPossibleObjective();
                                            }
                                            break;

                                        case SceneType.SPECIAL_DUN_MAX:
                                            if (this.CurrentObjective == Objective.SPECIAL_DUNGEON)
                                            {
                                                this.Escape();
                                                if(this.sp_dailyflag == true)
                                                {
                                                    this.sp_dailycount = 1000;
                                                    this.sp_dailyflag = false;
                                                }
                                                else if (this.sp_row1flag == true)
                                                {
                                                    this.sp_row1count = 1000;
                                                    this.sp_row1flag = false;
                                                }
                                                else if (this.sp_row2flag == true)
                                                {
                                                    this.sp_row2count = 1000;
                                                    this.sp_row2flag = false;
                                                }
                                                else if (this.sp_row3flag == true)
                                                {
                                                    this.sp_row3count = 1000;
                                                    this.sp_row3flag = false;
                                                }
                                                else if (this.sp_row4flag == true)
                                                {
                                                    this.sp_row4count = 1000;
                                                    this.sp_row4flag = false;
                                                }
                                                this.NextPossibleObjective();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.CLOSE_POPUP:
                                            this.WeightedClick(Popup3PM.ClosePopupOKButton, 1.0, 1.0, 1, 0, "left");
                                            break;
                                    }
                                }
                            }
                        }
                        else if (this.AIProfiles.TMP_WaitingForKeys)
                        {
                            Random rnd = new Random();
#if DEBUG
							if ((this.AISettings.AD_Enable && this.AdventureKeys >= 1 && rnd.Next(1, (int)this.AdventureKeyTime.TotalMinutes) == 1) ||
								(this.AISettings.AR_Enable && this.ArenaKeys >= 1 && rnd.Next(1, (int)this.ArenaKeyTime.TotalMinutes) == 1) ||
								(this.AISettings.GC_Enable && this.TowerKeys >= 1 && rnd.Next(1, (int)this.TowerKeyTime.TotalMinutes) == 1) ||
								(this.AISettings.RD_Enable && this.AdventureKeys >= 1 && rnd.Next(1, (int)this.AdventureKeyTime.TotalMinutes) == 1))
#else
                            if ((this.AISettings.AD_Enable && this.AdventureKeys >= 10 && rnd.Next(1, (int)this.AdventureKeyTime.TotalSeconds) == 1) ||
                                (this.AISettings.AR_Enable && this.ArenaKeys >= 4 && rnd.Next(1, (int)this.ArenaKeyTime.TotalSeconds) == 1) ||
                                (this.AISettings.GC_Enable && this.TowerKeys >= 4 && rnd.Next(1, (int)this.TowerKeyTime.TotalSeconds) == 1) ||
                                (this.AISettings.RD_Enable && this.AdventureKeys >= 10 && rnd.Next(1, (int)this.AdventureKeyTime.TotalSeconds) == 1))
#endif
                            {
                                int resumeIn = rnd.Next(1, 60);
                                this.Log("Resuming in " + resumeIn + " seconds");
                                Sleep(resumeIn * 1000);
                                this.BlueStacks.LaunchGame();
                                this.AIProfiles.TMP_WaitingForKeys = false;
                                this.Log("Keys sufficiently Replenished. Resuming");
                            }
                        }
                        if (!this.AIProfiles.TMP_WaitingForKeys &&
                            this.AISettings.GB_WaitForKeys &&
                            ((!this.AISettings.AD_Enable && !this.AISettings.RD_Enable) || this.AdventureKeys == 0) &&
                            (!this.AISettings.AR_Enable || this.ArenaKeys == 0) &&
                            (!this.AISettings.GC_Enable || this.TowerKeys == 0))
                        {
                            this.AIProfiles.TMP_WaitingForKeys = true;
                            this.Log("Waiting for keys to replenish");
                            this.BlueStacks.TerminateGame();
                        }
                        MousePos();
                    }
                    catch (Exception ex)
                    {
                        this.LogError(ex.Message);
                        this.LogError(ex.ToString());
                    }
                }
                this.OneSecTimer.Enabled = false;
                return;
            }
            errorMessage = "Seven Knights not installed in BlueStacks";
            this.LogError(errorMessage);
            this.SynchronizationContext.Send(delegate (object callback)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }, null);
        }

        private void ManageHeroes()
        {
            this.HeroManageAttemps++;
            if (this.HeroManageAttemps > 3)
            {
                this.DoneManageHeroes();
                return;
            }
            PixelMapping[] array = new PixelMapping[]
            {
                HeroesPM.TeamAButton,
                HeroesPM.TeamBButton,
                HeroesPM.TeamCButton
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                HeroesPM.HeroCard1,
                HeroesPM.HeroCard2,
                HeroesPM.HeroCard3,
                HeroesPM.HeroCard4,
                HeroesPM.HeroCard5,
                HeroesPM.HeroCard6,
                HeroesPM.HeroCard7,
                HeroesPM.HeroCard8,
                HeroesPM.HeroCard9,
                HeroesPM.HeroCard10
            };
            PixelMapping[][] array3 = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    HeroesPM.F2B3_1,
                    HeroesPM.F2B3_2,
                    HeroesPM.F2B3_3,
                    HeroesPM.F2B3_4,
                    HeroesPM.F2B3_5
                },
                new PixelMapping[]
                {
                    HeroesPM.F3B2_1,
                    HeroesPM.F3B2_2,
                    HeroesPM.F3B2_3,
                    HeroesPM.F3B2_4,
                    HeroesPM.F3B2_5
                },
                new PixelMapping[]
                {
                    HeroesPM.F1B4_1,
                    HeroesPM.F1B4_2,
                    HeroesPM.F1B4_3,
                    HeroesPM.F1B4_4,
                    HeroesPM.F1B4_5
                },
                new PixelMapping[]
                {
                    HeroesPM.F4B1_1,
                    HeroesPM.F4B1_2,
                    HeroesPM.F4B1_3,
                    HeroesPM.F4B1_4,
                    HeroesPM.F4B1_5
                }
            };
            PixelMapping[][] array4 = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    HeroesPM.F2B3_Finger_1,
                    HeroesPM.F2B3_Finger_2,
                    HeroesPM.F2B3_Finger_3,
                    HeroesPM.F2B3_Finger_4,
                    HeroesPM.F2B3_Finger_5
                },
                new PixelMapping[]
                {
                    HeroesPM.F3B2_Finger_1,
                    HeroesPM.F3B2_Finger_2,
                    HeroesPM.F3B2_Finger_3,
                    HeroesPM.F3B2_Finger_4,
                    HeroesPM.F3B2_Finger_5
                },
                new PixelMapping[]
                {
                    HeroesPM.F1B4_Finger_1,
                    HeroesPM.F1B4_Finger_2,
                    HeroesPM.F1B4_Finger_3,
                    HeroesPM.F1B4_Finger_4,
                    HeroesPM.F1B4_Finger_5
                },
                new PixelMapping[]
                {
                    HeroesPM.F4B1_Finger_1,
                    HeroesPM.F4B1_Finger_2,
                    HeroesPM.F4B1_Finger_3,
                    HeroesPM.F4B1_Finger_4,
                    HeroesPM.F4B1_Finger_5
                }
            };
            Team aD_Team = this.AISettings.AD_Team;
            Formation aD_Formation = this.AISettings.AD_Formation;
            List<int> list = new List<int>(this.AISettings.AD_HeroManagePositions);
            if (aD_Formation == Formation.None || list == null)
            {
                this.DoneManageHeroes();
                return;
            }
            if (this.HeroManageAttemps == 1)
            {
                this.Log("Start managing heroes", this.COLOR_HEROES_MANAGEMENT);
                this.SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI will replace the team on the selected positions with lower level heroes");
            }
            int num = aD_Formation - Formation.Front2Back3;
            PixelMapping[] array5 = array3[num];
            PixelMapping[] array6 = array4[num];
            if (aD_Team != Team.None)
            {
                this.WeightedClick(array[aD_Team - Team.A], 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
            }
            this.Log("Checking each position for level 30...", this.COLOR_HEROES_MANAGEMENT);
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            foreach (int current in list)
            {
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                this.WeightedClick(array5[current], 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                if (!this.ExpectingScene(SceneType.HERO_REMOVE, 30, 500))
                {
                    return;
                }
                if (this.IsHeroLevel30())
                {
                    this.Log(string.Format("- Got position: {0}", current + 1), this.COLOR_HEROES_MANAGEMENT);
                    list2.Add(current);
                }
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                this.Escape();
                SevenKnightsCore.Sleep(800);
                if (!this.ExpectingScene(SceneType.HEROES, 8, 800))
                {
                    return;
                }
            }
            SevenKnightsCore.Sleep(500);
            if (list2.Count <= 0)
            {
                this.Log("Nothing to manage", this.COLOR_HEROES_MANAGEMENT);
                this.DoneManageHeroes();
            }
            else
            {
                if (!this.ExpectingScene(SceneType.HEROES, 8, 800))
                {
                    return;
                }
                this.HeroSortReset(true, true);
                this.Log("Finding heroes...", this.COLOR_HEROES_MANAGEMENT);
                bool flag = false;
                bool flag4 = false;
                //ulong num2 = 0uL;
                //double num3 = 91.0;
                int num4 = 0;
                while (num4 < 100 && !this.Worker.CancellationPending)
                {
                    bool flag2 = false;
                    SevenKnightsCore.Sleep(1000);
                    this.CaptureFrame();
                    Scene scene = this.SceneSearch();
                    if (!this.ExpectingScene(SceneType.HEROES, 8, 800))
                    {
                        return;
                    }
                    if (this.MatchMapping(HeroesPM.LastRow_1, 3) && this.MatchMapping(HeroesPM.LastRow_2, 3))
                    {
                        flag = true;
                    }
                    int num5 = 0;
                    while (num5 < (flag ? 11 : 5) && !this.Worker.CancellationPending)
                    {
                        if (list2.Count == 0)
                        {
                            this.DoneManageHeroes();
                            return;
                        }
                        if(num5 == 10)
                        {
                            this.ScrollHeroCards(true);
                            SevenKnightsCore.Sleep(800);
                            num5 = 0;
                        }
                        Rectangle r_HeroCard_Base = HeroesPM.R_HeroCard_Base;
                        r_HeroCard_Base.X += HeroesPM.CARD_X_DELTA * num5;
                        if (flag)
                        {
                            r_HeroCard_Base.Y += HeroesPM.CARD_Y_DELTA + HeroesPM.CARD_LAST_Y_DELTA;
                        }
                        SevenKnightsCore.Sleep(800);
                        /*ulong num6 = 0uL;
                        if (num5 != 5 || num5 != 10)
                        {
                            using (this.CaptureFrame())
                            {
                                using (Bitmap bitmap2 = this.CropFrame(this.CaptureFrame(), r_HeroCard_Base))
                                {
                                    num6 = ImageHashing.AverageHash(bitmap2);
                                    double num7 = ImageHashing.Similarity(num2, num6);
                                    if (num2 != 0uL && num7 >= num3)
                                    {
                                        goto IL_B14;
                                    }
                                }
                            }
                        }*/
                        goto IL_7A8;
                    IL_B14:
                        num5++;
                        continue;
                    IL_7A8:
                        this.WeightedClick(array2[num5], 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(1000);
                        if (this.Worker.CancellationPending)
                        {
                            return;
                        }
                        if (!this.ExpectingScenes(new List<SceneType>
                        {
                            SceneType.HERO_JOIN,
                            SceneType.HERO_REMOVE
                        }, 8, 800))
                        {
                            return;
                        }
                        SevenKnightsCore.Sleep(1000);
                        this.CaptureFrame();
                        scene = this.SceneSearch();
                        if (scene.SceneType == SceneType.HERO_JOIN)
                        {
                            if (this.IsHeroLevel30())
                            {
                                this.Log("No more heroes less than level 30", this.COLOR_HEROES_MANAGEMENT);
                                this.Escape();
                                SevenKnightsCore.Sleep(1000);
                                this.CaptureFrame();
                                scene = this.SceneSearch();
                                if (flag4)
                                {
                                    this.DoneManageHeroes();
                                    this.Log("DoneManageHeroes flag4");
                                    return;
                                }
                                else
                                {
                                    this.WeightedClick(HeroesPM.ElementButton, 1.0, 1.0, 1, 0, "left");
                                    SevenKnightsCore.Sleep(1000);
                                    //num2 = 0uL;
                                    this.HeroSortReset(true, true);
                                    flag2 = true;
                                    flag4 = true;
                                    break;
                                }
                            }
                            else if (this.ExpectingScene(SceneType.HERO_JOIN, 8, 800))
                            {
                                this.WeightedClick(HeroJoinPM.JoinButton, 1.0, 1.0, 1, 0, "left");
                                SevenKnightsCore.Sleep(1000);
                                this.CaptureFrame();
                                scene = this.SceneSearch();
                                if (this.Worker.CancellationPending || scene == null || scene.SceneType != SceneType.HEROES)
                                {
                                    return;
                                }
                                int num8 = -1;
                                int num9 = 0;
                                while (num9 < 5 && !this.Worker.CancellationPending)
                                {
                                    this.CaptureFrame();
                                    for (int i = 0; i < array6.Length; i++)
                                    {
                                        bool flag3 = true;
                                        for (int j = 0; j < array6.Length; j++)
                                        {
                                            if (i != j)
                                            {
                                                flag3 &= this.MatchMapping(array6[j], 3);
                                            }
                                        }
                                        if (this.MatchMapping(array6[i], 3) && !flag3)
                                        {
                                            num8 = i;
                                            break;
                                        }
                                    }
                                    if (num8 != -1)
                                    {
                                        break;
                                    }
                                    SevenKnightsCore.Sleep(300);
                                    num9++;
                                }
                                int num10;
                                if (num8 != -1)
                                {
                                    if (!list3.Contains(num8) && list2.Contains(num8))
                                    {
                                        num10 = list2.IndexOf(num8);
                                    }
                                    else
                                    {
                                        goto IL_B14;
                                    }
                                }
                                else
                                {
                                    num10 = 0;
                                }
                                int num11 = list2[num10];
                                this.WeightedClick(array5[num11], 1.0, 1.0, 1, 0, "left");
                                SevenKnightsCore.Sleep(800);
                                if (!this.ExpectingScenes(new List<SceneType>
                                {
                                    SceneType.HEROES_SAME_TEAM_POPUP,
                                    SceneType.HEROES
                                }, 5, 500))
                                {
                                    return;
                                }
                                SevenKnightsCore.Sleep(1000);
                                this.CaptureFrame();
                                scene = this.SceneSearch();
                                if (scene.SceneType == SceneType.HEROES_SAME_TEAM_POPUP)
                                {
                                    this.Escape();
                                    goto IL_B14;
                                }
                                if (scene.SceneType == SceneType.HEROES)
                                {
                                    this.Log(string.Format("Replaced hero position: {0}", num11 + 1), this.COLOR_HEROES_MANAGEMENT);
                                    heroreplace += 1;
                                    list2.RemoveAt(num10);
                                    list3.Add(num10);
                                    goto IL_B14;
                                }
                                goto IL_B14;
                            }
                        }
                        else
                        {
                            if (scene.SceneType == SceneType.HERO_REMOVE)
                            {
                                this.Escape();
                                SevenKnightsCore.Sleep(500);
                                goto IL_B14;
                            }
                            return;
                        }
                    }
                    if (flag)
                    {
                        break;
                    }
                    if (!flag2)
                    {
                        this.ScrollHeroCards(true);
                        SevenKnightsCore.Sleep(800);
                    }
                    num4++;
                }
                this.DoneManageHeroes();
                return;
            }
        }




        //This Function accepts a PixelMapping and send through to MatchPixel.
        private bool MatchMapping(PixelMapping mapping, int tolerance = 2, bool log = false)
        {
            // If if either log paramater or the log property of the mapping it will send true.
            return this.MatchPixel(mapping.X, mapping.Y, mapping.Color, tolerance, log || mapping.Log);
        }

        //This accepts X and Y coords and expected colour as an Argb integer.
        //The Tolerance is how much of a difference between each colour there in the actual pixel and the expected.
        private bool MatchPixel(int x, int y, int color, int tolerance = 2, bool log = false)
        {
            //Grab the Pixel.
            int currentPixel = this.GetPixel(x, y);
            //Log to the Log if it's true current pixel if log is true
            if (log)
            {
                this.Log("X = " + x.ToString() + ", Y = " + y.ToString() + ", Color = " + currentPixel.ToString());
            }
            //Generate Color objects for each the Target Colour and the Actual Colour.
            Color currentColour = Color.FromArgb(currentPixel);
            Color targetColour = Color.FromArgb(color);
            //this is where we calculate the varience to compare against the tolerance.
            int variance = (int)(Math.Max(currentColour.R, targetColour.R) - Math.Min(currentColour.R, targetColour.R) + (Math.Max(currentColour.G, targetColour.G) - Math.Min(currentColour.G, targetColour.G)) + (Math.Max(currentColour.B, targetColour.B) - Math.Min(currentColour.B, targetColour.B)));
            //Check the variance vs tolerance and returns the result.
            return variance <= tolerance;
        }

        private void MousePos()
        {
            if (this.AIProfiles.TMP_LogPixel && this.AIProfiles.TMP_Paused)
            {
                Sleep(3000);
                Point mousePos = this.BlueStacks.GetMousePos();
                mousePos.X = mousePos.X - BlueStacks.OFFSET_X;
                mousePos.Y = mousePos.Y - BlueStacks.OFFSET_Y;

                if (this.AIProfiles.TMP_LogPixel)
                {
                    if (this.AIProfiles.TMP_Paused)
                        this.CaptureFrame();
                    int colour = this.BlueStacks.GetPixel(mousePos);
                    if (colour != -1)
                    {
                        string message = "X = " + (mousePos.X + ", Y = " + mousePos.Y + ", Color = " + colour);
                        this.Log(message);
                    }
                    this.AIProfiles.TMP_LogPixel = false;
                }
                if (this.AIProfiles.TMP_Paused)
                {
                    ProgressArgs cursorUpdate = new ProgressArgs(ProgressType.CURSORPOS, mousePos);
                    this.Worker.ReportProgress(0, cursorUpdate);
                    Sleep(1000);
                }
            }
        }

        private void NextPossibleObjective()
        {
            bool aD_Enable = this.AISettings.AD_Enable;
            bool gC_Enable = this.AISettings.GC_Enable;
            bool sP_Enable = this.AISettings.SP_Enable;
            bool aR_Enable = this.AISettings.AR_Enable;
            bool rD_Enable = this.AISettings.RD_Enable;
            switch (this.CurrentObjective)
            {
                case Objective.IDLE:
                    if (aD_Enable)
                    {
                        this.ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (gC_Enable)
                    {
                        this.ChangeObjective(Objective.GOLD_CHAMBER);
                        return;
                    }
                    if (sP_Enable)
                    {
                        this.ChangeObjective(Objective.SPECIAL_DUNGEON);
                        return;
                    }
                    if (aR_Enable)
                    {
                        this.ChangeObjective(Objective.ARENA);
                        return;
                    }
                    if (rD_Enable)
                    {
                        this.ChangeObjective(Objective.RAID);
                        return;
                    }
                    break;

                case Objective.ADVENTURE:
                    if (gC_Enable)
                    {
                        this.ChangeObjective(Objective.GOLD_CHAMBER);
                        return;
                    }
                    if (sP_Enable)
                    {
                        this.ChangeObjective(Objective.SPECIAL_DUNGEON);
                        return;
                    }
                    if (aR_Enable)
                    {
                        this.ChangeObjective(Objective.ARENA);
                        return;
                    }
                    if (rD_Enable)
                    {
                        this.ChangeObjective(Objective.RAID);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;

                case Objective.SPECIAL_DUNGEON:
                    if (aR_Enable)
                    {
                        this.ChangeObjective(Objective.ARENA);
                        return;
                    }
                    if (rD_Enable)
                    {
                        this.ChangeObjective(Objective.RAID);
                        return;
                    }
                    if (aD_Enable)
                    {
                        this.ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (gC_Enable)
                    {
                        this.ChangeObjective(Objective.GOLD_CHAMBER);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;

                case Objective.GOLD_CHAMBER:
                    if (sP_Enable)
                    {
                        this.ChangeObjective(Objective.SPECIAL_DUNGEON);
                        return;
                    }
                    if (aR_Enable)
                    {
                        this.ChangeObjective(Objective.ARENA);
                        return;
                    }
                    if (rD_Enable)
                    {
                        this.ChangeObjective(Objective.RAID);
                        return;
                    }
                    if (aD_Enable)
                    {
                        this.ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;

                case Objective.ARENA:
                    if (rD_Enable)
                    {
                        this.ChangeObjective(Objective.RAID);
                        return;
                    }
                    if (aD_Enable)
                    {
                        this.ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (gC_Enable)
                    {
                        this.ChangeObjective(Objective.GOLD_CHAMBER);
                        return;
                    }
                    if (sP_Enable)
                    {
                        this.ChangeObjective(Objective.SPECIAL_DUNGEON);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;

                case Objective.RAID:
                    if (aD_Enable)
                    {
                        this.ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (gC_Enable)
                    {
                        this.ChangeObjective(Objective.GOLD_CHAMBER);
                        return;
                    }
                    if (sP_Enable)
                    {
                        this.ChangeObjective(Objective.SPECIAL_DUNGEON);
                        return;
                    }
                    if (aR_Enable)
                    {
                        this.ChangeObjective(Objective.ARENA);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;

                case Objective.HERO_MANAGEMENT:
                case Objective.SELL_HEROES:
                case Objective.SELL_ITEMS:
                    if (this.PreviousObjective != this.CurrentObjective)
                    {
                        this.ChangeObjective(this.PreviousObjective);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    break;

                case Objective.BUY_KEYS:
                case Objective.COLLECT_INBOX:
                case Objective.COLLECT_QUESTS:
                case Objective.SEND_HONORS:
                    if (this.PreviousObjective == Objective.IDLE || this.PreviousObjective == Objective.ADVENTURE || this.PreviousObjective == Objective.GOLD_CHAMBER || this.PreviousObjective == Objective.SPECIAL_DUNGEON || this.PreviousObjective == Objective.ARENA || this.PreviousObjective == Objective.RAID)
                    {
                        this.ChangeObjective(this.PreviousObjective);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;

                default:
                    return;
            }
        }

        private void OnOneSecEvent(object source, ElapsedEventArgs e)
        {
            if (this.AIProfiles.ST_EnableHotTimeProfile && ((HotTimeHelper.IsNowHotTime() && !this.AIProfiles.TMP_UsingHotTimeProfile) || (!HotTimeHelper.IsNowHotTime() && this.AIProfiles.TMP_UsingHotTimeProfile)))
            {
                this.AIProfiles.ToggleHotTimeProfile();
                MainForm.Instance.InvokeReloadTabs(true);
            }
            if (this.AIProfiles.ST_EnableAutoProfile && MaxHeroUpCount)
            {
                this.MaxHeroUpCount = false;
                this.AIProfiles.ToggleHotTimeProfile();
                MainForm.Instance.InvokeReloadTabs(true);
            }
            if (this.AIProfiles.ST_EnableAutoProfile && nomorehero30)
            {
                this.nomorehero30 = false;
                this.Alert("No More Hero 30");
                //                this.AIProfiles.ToggleHotTimeProfile();
                //                MainForm.Instance.InvokeReloadTabs(true);
            }
            if (this.AIProfiles.ST_EnableAutoShutdown && MaxHeroUpCount)
            {
                this.Log("Shutdown Now!");
                Process.Start("shutdown", "/s /f /t 0");
            }
            TimeSpan ts = TimeSpan.FromSeconds(1.0);
            if (this.AdventureKeyTime != TimeSpan.MaxValue)
            {
                this.AdventureKeyTime = this.AdventureKeyTime.Subtract(ts);
            }
            if (this.TowerKeyTime != TimeSpan.MaxValue)
            {
                this.TowerKeyTime = this.TowerKeyTime.Subtract(ts);
            }
            if (this.ArenaKeyTime != TimeSpan.MaxValue)
            {
                this.ArenaKeyTime = this.ArenaKeyTime.Subtract(ts);
            }
            if (this.AdventureKeyTime == TimeSpan.Zero)
            {
                this.AdventureKeyTime = new TimeSpan(0, 10, 0);
                if (this.AdventureKeys < 11)
                {
                    this.AdventureKeys++;
                }
                else
                {
                    this.AdventureKeyTime = TimeSpan.MaxValue;
                }
            }
            if (this.TowerKeyTime == TimeSpan.Zero)
            {
                this.TowerKeyTime = new TimeSpan(0, 30, 0);
                if (this.TowerKeys < 5)
                {
                    this.TowerKeys++;
                }
                else
                {
                    this.TowerKeyTime = TimeSpan.MaxValue;
                }
            }
            if (this.ArenaKeyTime == TimeSpan.Zero)
            {
                this.ArenaKeyTime = new TimeSpan(0, 30, 0);
                if (this.ArenaKeys < 5)
                {
                    this.ArenaKeys++;
                }
                else
                {
                    this.ArenaKeyTime = TimeSpan.MaxValue;
                }
            }
            this.ReportAllKeys();
        }

        private int ParseAdventureKeys(int offsetX, int offsetY)
        {
            int num = -1;
            Rectangle rect = SharedPM.R_KeyOnTopTimeBase;
            rect.X += offsetX;
            rect.Y += offsetY;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
#if DEBUG
				bitmap.Save("keysOnTop.png");
#endif
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText();
                    if (text.ToLower().Contains("x"))
                    {
                        int.TryParse(text.Substring(1), out num);
#if DEBUG
                        this.Log("int: " + num + "  text: " + text.Trim());
                        Console.WriteLine("int: " + num + "  text: " + text.Trim());
#endif
                    }
                }
            }
            if (num != -1)
            {
                rect = SharedPM.R_TimeBase;
                rect.X += offsetX;
                rect.Y += offsetY;
                using (Bitmap bitmap2 = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(128))
                {
#if DEBUG
                    bitmap2.Save("r_timebase.png");
#endif
                    using (Page page2 = this.Tesseractor.Engine.Process(bitmap2, null))
                    {
                        string text2 = page2.GetText();
                        Utility.FilterAscii(text2);
#if DEBUG
                       this.Log("r_timebase txt = "+text2.Trim());
                       this.Log("r_timebase txt.length = " + text2.Length);
#endif
                        if (text2.Length >= 2)
                        {
                            string s = text2.Substring(0, 2);
                            string s2 = text2.Substring(3, 2);
                            int minutes;
                            int.TryParse(s, out minutes);
                            int seconds;
                            int.TryParse(s2, out seconds);
                            TimeSpan adventureKeyTime = new TimeSpan(0, minutes, seconds);
                            this.AdventureKeyTime = adventureKeyTime;
                            return num;
                        }
                        else
                        {
                            this.AdventureKeys = -1;
                            this.AdventureKeyTime = TimeSpan.MaxValue;
                        }
                    }
                }
            }
            rect = SharedPM.R_KeyNormalBase;
            rect.X += offsetX;
            rect.Y += offsetY;
            using (Bitmap bitmap3 = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(128))
            {
#if DEBUG
                bitmap3.Save("r_normalbase.png");
#endif
                using (Page page3 = this.Tesseractor.Engine.Process(bitmap3, null))
                {
                    string text3 = page3.GetText();
                    if (text3.ToLower().Contains("x"))
                    {
                        int.TryParse(text3.Substring(1), out num);
                    }
                    else
                    {
                        this.AdventureKeys = -1;
                        this.AdventureKeyTime = TimeSpan.MaxValue;
                    }
                }
            }
            this.AdventureKeyTime = TimeSpan.MaxValue;
            return num;
        }

        private int ParseEntred()
        {
            int result = -1;
            Rectangle rect = RaidReadyPM.EnteredCount;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(128))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    Utility.FilterAscii(text);
#if DEBUG
                            bitmap.Save("DragonRound.png");
                            Console.WriteLine("DragonRound =" + text.Trim());
#endif
                    if (text.Length != 0)
                    {
                        int.TryParse(text, out result);
                    }
                }
                return result;
            }
        }

        private int ParseGold(int offsetX, int offsetY)
        {
            int result = -1;
            Rectangle r_GoldBase = SharedPM.R_GoldBase;
            r_GoldBase.X += offsetX;
            r_GoldBase.Y += offsetY;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, r_GoldBase))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    if (text.Length >= 1)
                    {
                        int.TryParse(text, out result);
                    }
                }
            }
            return result;
        }

        private int ParseHonor(int offsetX, int offsetY)
        {
            int result = -1;
            Rectangle r_HonorBase = SharedPM.R_HonorBase;
            r_HonorBase.X += offsetX;
            r_HonorBase.Y += offsetY;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, r_HonorBase))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    if (text.Contains("/") && text.Length >= 4)
                    {
                        string[] array = text.Split(new char[]
                        {
                            '/'
                        });
                        if (array.Length >= 1)
                        {
                            int.TryParse(array[0], out result);
                        }
                    }
                }
            }
            return result;
        }

        private int ParseRuby(int offsetX, int offsetY)
        {
            int result = -1;
            Rectangle r_RubyBase = SharedPM.R_RubyBase;
            r_RubyBase.X += offsetX;
            r_RubyBase.Y += offsetY;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, r_RubyBase))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    if (text.Length >= 1)
                    {
                        int.TryParse(text, out result);
                    }
                }
            }
            return result;
        }

        private int ParseTopaz(int offsetX, int offsetY)
        {
            int result = -1;
            Rectangle r_TopazBase = SharedPM.R_TopazBase;
            r_TopazBase.X += offsetX;
            r_TopazBase.Y += offsetY;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, r_TopazBase))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    if (text.Length >= 1)
                    {
                        int.TryParse(text, out result);
                    }
                }
            }
            return result;
        }

        private void PerformFightTatics(SceneType sceneType)
        {
            if (this.MatchMapping(SharedPM.Fight_SpeedOff, 2))
            {
                this.WeightedClick(SharedPM.Fight_SpeedButton, 1.0, 1.0, 1, 0, "left");
            }
            if (sceneType == SceneType.TOWER_FIGHT)
            {
                bool flag = this.AISettings.GC_SkillType != SkillType.Manual;
                bool flag2 = this.AISettings.GC_SkillType == SkillType.Both;
                bool shouldAssign = !flag || flag2;
                this.ToggleTowerAutoSkill();
                if (this.MatchMapping(TowerFightPM.AtTurn1Of1, 3) || (this.MatchMapping(TowerFightPM.AtTurn1Of2, 3) && this.MatchMapping(TowerFightPM.Turn2Of2, 3)))
                {
                    int num = 1;
                    this.LoopSkill = this.AISettings.GC_Wave1Loop;
                    if (this.CurrentWave < num)
                    {
                        this.ChangeCurrentWave(num);
                        this.CancelAllSkills(false);
                        this.AssignSkillSet(shouldAssign, this.AISettings.GC_Wave1Skills);
                        this.WeightedClick(SharedPM.FriendClick, 1.0, 1.0, 1, 0, "left");
                    }
                }
                else if (this.MatchMapping(TowerFightPM.AtTurn2Of2, 3) && this.MatchMapping(TowerFightPM.Turn1Of2, 3))
                {
                    int num2 = 2;
                    this.LoopSkill = this.AISettings.GC_Wave2Loop;
                    if (this.CurrentWave < num2)
                    {
                        this.ChangeCurrentWave(num2);
                        this.CancelAllSkills(false);
                        this.AssignSkillSet(shouldAssign, this.AISettings.GC_Wave2Skills);
                    }
                }
            }
            else if (sceneType == SceneType.SPECIAL_DUN_FIGHT)
            {
                if ((this.MatchMapping(AdventureFightPM.AtTurn1Of1, 5) || (this.MatchMapping(AdventureFightPM.AtTurn1Of2, 5) && this.MatchMapping(AdventureFightPM.Turn2Of2, 5)) || (this.MatchMapping(AdventureFightPM.AtTurn1Of3_1, 5) && this.MatchMapping(AdventureFightPM.AtTurn1Of3_2, 5) && this.MatchMapping(AdventureFightPM.Turn2Of3, 5)))
                    || this.MatchMapping(SpecialDungeonFightPM.Turn1Of1, 5))
                {
                    bool flag = this.AISettings.SP_SkillType != SkillType.Manual;
                    bool flag2 = this.AISettings.SP_SkillType == SkillType.Both;
                    bool shouldAssign = !flag || flag2;
                    this.ToggleAutoSkill(flag);
                    int num3 = 1;
                    this.LoopSkill = this.AISettings.SP_Wave1Loop;
                    if (this.CurrentWave < num3)
                    {
                        this.ChangeCurrentWave(num3);
                        this.CancelAllSkills(false);
                        this.AssignSkillSet(shouldAssign, this.AISettings.SP_Wave1Skills);
                    }
                }
                else if ((this.MatchMapping(AdventureFightPM.AtTurn2Of2, 5) && this.MatchMapping(AdventureFightPM.Turn1Of2, 5)) || (this.MatchMapping(AdventureFightPM.AtTurn2Of3_1, 5) && this.MatchMapping(AdventureFightPM.AtTurn2Of3_2, 5) && this.MatchMapping(AdventureFightPM.Turn1Of3, 5)))
                {
                    bool flag = this.AISettings.SP_w2SkillType != SkillType.Manual;
                    bool flag2 = this.AISettings.SP_w2SkillType == SkillType.Both;
                    bool shouldAssign = !flag || flag2;
                    this.ToggleAutoSkill(flag);
                    int num4 = 2;
                    this.LoopSkill = this.AISettings.SP_Wave2Loop;
                    if (this.CurrentWave < num4)
                    {
                        this.ChangeCurrentWave(num4);
                        this.CancelAllSkills(false);
                        this.AssignSkillSet(shouldAssign, this.AISettings.SP_Wave2Skills);
                    }
                }
                else if ((this.MatchMapping(AdventureFightPM.AtTurn3Of3_1, 5) && this.MatchMapping(AdventureFightPM.AtTurn3Of3_2, 5) && this.MatchMapping(AdventureFightPM.Turn2Of3, 5)) || this.MatchMapping(SpecialDungeonFightPM.Turn3Of3, 2))
                {
                    bool flag = this.AISettings.SP_w3SkillType != SkillType.Manual;
                    bool flag2 = this.AISettings.SP_w3SkillType == SkillType.Both;
                    bool shouldAssign = !flag || flag2;
                    this.ToggleAutoSkill(flag);
                    int num5 = 3;
                    this.LoopSkill = this.AISettings.SP_Wave3Loop;
                    if (this.CurrentWave < num5)
                    {
                        this.ChangeCurrentWave(num5);
                        this.CancelAllSkills(false);
                        this.AssignSkillSet(shouldAssign, this.AISettings.SP_Wave3Skills);
                    }
                }
            }
            else if (sceneType == SceneType.ADVENTURE_FIGHT)
            {
                if (this.MatchMapping(AdventureFightPM.Fight_AweakOn, 2))
                {
                    this.WeightedClick(AdventureFightPM.Fight_AweakButton, 1.0, 1.0, 1, 0, "left");
                }
                if (this.MatchMapping(AdventureFightPM.AtTurn1Of1, 5) || (this.MatchMapping(AdventureFightPM.AtTurn1Of2, 5) && this.MatchMapping(AdventureFightPM.Turn2Of2, 5)) || (this.MatchMapping(AdventureFightPM.AtTurn1Of3_1, 5) && this.MatchMapping(AdventureFightPM.AtTurn1Of3_2, 5) && this.MatchMapping(AdventureFightPM.Turn2Of3, 5)))
                {
                    bool flag = this.AISettings.AD_SkillType != SkillType.Manual;
                    bool flag2 = this.AISettings.AD_SkillType == SkillType.Both;
                    bool shouldAssign = !flag || flag2;
                    this.ToggleAutoSkill(flag);
                    int num3 = 1;
                    this.LoopSkill = this.AISettings.AD_Wave1Loop;
                    if (this.CurrentWave < num3)
                    {
                        this.ChangeCurrentWave(num3);
                        this.CancelAllSkills(false);
                        this.AssignSkillSet(shouldAssign, this.AISettings.AD_Wave1Skills);
                        this.WeightedClick(SharedPM.FriendClick, 1.0, 1.0, 1, 0, "left");
                    }
                }
                else if ((this.MatchMapping(AdventureFightPM.AtTurn2Of2, 5) && this.MatchMapping(AdventureFightPM.Turn1Of2, 5)) || (this.MatchMapping(AdventureFightPM.AtTurn2Of3_1, 5) && this.MatchMapping(AdventureFightPM.AtTurn2Of3_2, 5) && this.MatchMapping(AdventureFightPM.Turn1Of3, 5)))
                {
                    bool flag = this.AISettings.AD_w2SkillType != SkillType.Manual;
                    bool flag2 = this.AISettings.AD_w2SkillType == SkillType.Both;
                    bool shouldAssign = !flag || flag2;
                    this.ToggleAutoSkill(flag);
                    int num4 = 2;
                    this.LoopSkill = this.AISettings.AD_Wave2Loop;
                    if (this.CurrentWave < num4)
                    {
                        this.ChangeCurrentWave(num4);
                        this.CancelAllSkills(false);
                        this.AssignSkillSet(shouldAssign, this.AISettings.AD_Wave2Skills);
                    }
                }
                else if (this.MatchMapping(AdventureFightPM.AtTurn3Of3_1, 5) && this.MatchMapping(AdventureFightPM.AtTurn3Of3_2, 5) && this.MatchMapping(AdventureFightPM.Turn2Of3, 5))
                {
                    bool flag = this.AISettings.AD_w3SkillType != SkillType.Manual;
                    bool flag2 = this.AISettings.AD_w3SkillType == SkillType.Both;
                    bool shouldAssign = !flag || flag2;
                    this.ToggleAutoSkill(flag);
                    int num5 = 3;
                    this.LoopSkill = this.AISettings.AD_Wave3Loop;
                    if (this.CurrentWave < num5)
                    {
                        this.ChangeCurrentWave(num5);
                        this.CancelAllSkills(false);
                        this.AssignSkillSet(shouldAssign, this.AISettings.AD_Wave3Skills);
                    }
                }
            }
            else if(sceneType == SceneType.RAID_FIGHT)
            {
                bool flag = this.AISettings.RD_SkillType != SkillType.Manual;
                bool flag2 = this.AISettings.RD_SkillType == SkillType.Both;
                bool shouldAssign = !flag || flag2;
                this.ToggleAutoSkill(flag);
                if (this.MatchMapping(RaidFightPM.SkipOff, 2))
                {
                    this.WeightedClick(RaidFightPM.SkipButton, 1.0, 1.0, 1, 0, "left");
                }
                if (this.CurrentRaidTeam == 0)
                {
                    this.LoopSkill = this.AISettings.RD_Team1Loop;
                    this.ChangeCurrentRaidTeam(1);
                    this.CancelAllSkills(false);
                    this.AssignSkillSet(shouldAssign, this.AISettings.RD_Team1Skills);
                }
                else if (this.CurrentRaidTeam == 1)
                {
                    this.LoopSkill = this.AISettings.RD_Team1Loop;
                    if (this.MatchMapping(RaidFightPM.TeamTransition_1, 3) && this.MatchMapping(RaidFightPM.TeamTransition_2, 4) && this.MatchMapping(RaidFightPM.TeamTransition_3, 4))
                    {
                        SevenKnightsCore.Sleep(500);
                        this.LoopSkill = this.AISettings.RD_Team2Loop;
                        this.ChangeCurrentRaidTeam(2);
                        this.LongSleep(2000, 1000);
                        this.CancelAllSkills(false);
                        this.AssignSkillSet(shouldAssign, this.AISettings.RD_Team2Skills);
                    }
                }
                else if (this.CurrentRaidTeam == 2)
                {
                    this.LoopSkill = this.AISettings.RD_Team2Loop;
                }
            }
            bool towerFight = sceneType == SceneType.TOWER_FIGHT;
            this.UseSkills(towerFight);
        }

        private void ProgressSequence()
        {
            if (this.AISettings.AD_World != World.Sequencer)
            {
                return;
            }
            if (this.AISettings.AD_WorldSequence == null || this.AISettings.AD_StageSequence == null || this.AISettings.AD_AmountSequence == null)
            {
                return;
            }
            if (this.AISettings.AD_WorldSequence.Length <= 0 || this.AISettings.AD_StageSequence.Length <= 0 || this.AISettings.AD_AmountSequence.Length <= 0)
            {
                return;
            }
            if (this.CurrentSequence >= this.AISettings.AD_WorldSequence.Length || this.CurrentSequence >= this.AISettings.AD_StageSequence.Length || this.CurrentSequence >= this.AISettings.AD_AmountSequence.Length)
            {
                this.CurrentSequence = 0;
                return;
            }
            int num = this.AISettings.AD_WorldSequence.Length;
            int arg_CF_0 = this.AISettings.AD_WorldSequence[this.CurrentSequence];
            int arg_E2_0 = this.AISettings.AD_StageSequence[this.CurrentSequence];
            int num2 = this.AISettings.AD_AmountSequence[this.CurrentSequence];
            this.CurrentSequenceCount++;
            if (this.CurrentSequenceCount >= num2)
            {
                this.CurrentSequenceCount = 0;
                this.CurrentSequence++;
                if (this.CurrentSequence >= num)
                {
                    this.CurrentSequence %= num;
                }
            }
        }

        private void RaidAfterFight()
        {
            this.RaidCount++;
            this.ReportCount(Objective.RAID);
            this.RaidCheckLimits();
        }

        private void RaidCheckLimits()
        {
            if (this.AISettings.RD_EnableDragonLimit)
            {
                this.RaidLimitCount++;
                if (this.RaidLimitCount >= this.AISettings.RD_DragonRound)
                {
                    this.Log("Limit reached [Raid]", this.COLOR_LIMIT);
                    this.RaidLimitCount = 0;
                    this.DoneRaid();
                }
            }
        }

        private string ReplaceNumericResource(string text)
        {
            return Utility.FilterAscii(text).ToLower().Replace("o", "0").Replace("l", "1").Replace("s", "8").Replace(",", "").Replace(".", "");
        }

        private void ReportAllCount()
        {
            this.ReportCount(Objective.ADVENTURE);
            this.ReportCount(Objective.GOLD_CHAMBER);
            this.ReportCount(Objective.RAID);
            this.ReportArenaCount();
        }

        private void ReportAllKeys()
        {
            this.ReportKeys(Objective.ADVENTURE);
            this.ReportKeys(Objective.GOLD_CHAMBER);
            this.ReportKeys(Objective.ARENA);
        }

        private void ReportAllResources()
        {
            this.ReportResources(ResourceType.GOLD);
            this.ReportResources(ResourceType.RUBY);
            this.ReportResources(ResourceType.HONOR);
            this.ReportResources(ResourceType.TOPAZ);
        }

        private void ReportArenaCount()
        {
            Dictionary<string, object> message = new Dictionary<string, object>
            {
                {
                    "objective",
                    Objective.ARENA
                },
                {
                    "winCount",
                    this.ArenaWinCount
                },
                {
                    "loseCount",
                    this.ArenaLoseCount
                },
                {
                    "arenaRank",
                    this.ArenaRank
                }
            };
            ProgressArgs userState = new ProgressArgs(ProgressType.COUNT, message);
            this.Worker.ReportProgress(0, userState);
        }

        private void ReportCount(Objective objective)
        {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            switch (objective)
            {
                case Objective.ADVENTURE:
                    num = this.AdventureCount;
                    num2 = this.dragonsummoncount;
                    num5 = this.h30;
                    break;

                case Objective.GOLD_CHAMBER:
                    num = this.GoldChamberCount;
                    num2 = this.goldminegoldamount;
                    num3 = this.goldmineentry;
                    break;

                case Objective.RAID:
                    num = this.RaidCount;
                    break;

                case Objective.HERO_MANAGEMENT:
                    num = this.h30;
                    break;
            }

            Dictionary<string, object> message = new Dictionary<string, object>
                {
                    {
                        "objective",
                        objective
                    },
                    {
                        "count",
                         num
                    },
                    {
                        "gold",
                         num3
                    },
                    {
                        "hero",
                         num2
                    },
                    {
                        "item",
                         num4
                    },
                    {
                        "h30",
                         num5
                    },
                    {   "hc",
                         HeroCount
                    },
                    {   "hm",
                         HeroMax
                    }
                };

            ProgressArgs userState = new ProgressArgs(ProgressType.COUNT, message);
            this.Worker.ReportProgress(0, userState);
        }

        private void ReportKeys(Objective objective)
        {
            int num = 0;
            TimeSpan timeSpan = TimeSpan.MaxValue;
            switch (objective)
            {
                case Objective.ADVENTURE:
                    num = this.AdventureKeys;
                    timeSpan = this.AdventureKeyTime;
                    break;

                case Objective.GOLD_CHAMBER:
                    num = this.TowerKeys;
                    timeSpan = this.TowerKeyTime;
                    break;

                case Objective.ARENA:
                    num = this.ArenaKeys;
                    timeSpan = this.ArenaKeyTime;
                    break;
            }
            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                {
                    "objective",
                    objective
                },
                {
                    "keys",
                    num
                }
            };
            if (timeSpan != TimeSpan.MaxValue)
            {
                dictionary.Add("time", timeSpan);
            }
            ProgressArgs userState = new ProgressArgs(ProgressType.KEY, dictionary);
            this.Worker.ReportProgress(0, userState);
        }

        private void ReportResources(ResourceType resourceType)
        {
            int num = -1;
            switch (resourceType)
            {
                case ResourceType.GOLD:
                    num = this.GoldCount;
                    break;

                case ResourceType.RUBY:
                    num = this.RubyCount;
                    break;

                case ResourceType.HONOR:
                    num = this.HonorCount;
                    break;

                case ResourceType.TOPAZ:
                    num = this.TopazCount;
                    break;
            }
            Dictionary<string, object> message = new Dictionary<string, object>
            {
                {
                    "resourceType",
                    resourceType
                },
                {
                    "value",
                    num
                }
            };
            ProgressArgs userState = new ProgressArgs(ProgressType.RESOURCE, message);
            this.Worker.ReportProgress(0, userState);
        }

        private Scene SceneSearch()
        {
            Scene scene = this.SearchScenes();
            if (this.CurrentScene != null)
            {
                this.PreviousScene = this.CurrentScene;
            }
            this.CurrentScene = scene;
            return scene;
        }

        private void ScrollHeroCards(bool down = true)
        {
            PixelMapping pixelMapping = down ? HeroesPM.ScrollAreaDown : HeroesPM.ScrollAreaUp;
            int num = down ? (-HeroesPM.SCROLL_DELTA) : HeroesPM.SCROLL_DELTA;
            this.ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X, pixelMapping.Y + num);
        }

        private void ScrollItemPopup(bool down = true)
        {
            PixelMapping pixelMapping = down ? SellItemPopupPM.ScrollAreaDown : SellItemPopupPM.ScrollAreaUp;
            int num = down ? (-SellItemPopupPM.SCROLL_DOUBLE_DELTA) : SellItemPopupPM.SCROLL_DOUBLE_DELTA;
            this.ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X, pixelMapping.Y + num);
        }

        private void ScrollShopKeys(bool right = true)
        {
            int num = 500;
            PixelMapping pixelMapping = right ? ShopPM.ScrollAreaRight : ShopPM.ScrollAreaLeft;
            int num2 = right ? (-num) : num;
            this.ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X + num2, pixelMapping.Y + num2);
        }

        private void ScrollRaidDown90(bool down = true)
        {
            int num = 400;
            PixelMapping pixelMapping = down ? RaidLobbyPM.ScrollAreaDown : RaidLobbyPM.ScrollAreaUp;
            int num2 = down ? (-num) : num;
            this.ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X, pixelMapping.Y + num2);
        }

        private void ScrollRaidPage(bool down = true)
        {
            int num2 = 198; 
            PixelMapping pixelMapping = down ? RaidLobbyPM.ScrollAreaDown : RaidLobbyPM.ScrollAreaUp;
            int num = down ? (-num2) : num2;
            this.ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X, pixelMapping.Y + num);
        }

        private void ScrollRaidOneDragon(bool down = true)
        {
            int num = 48;
            PixelMapping pixelMapping = down ? RaidLobbyPM.ScrollAreaDown : RaidLobbyPM.ScrollAreaUp;
            int num2 = down ? (-num) : num;
            this.ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X, pixelMapping.Y + num2);
        }

        private void ScrollSpecialdunPage(bool down = true)
        {
            int num = 198;
            PixelMapping pixelMapping = down ? RaidLobbyPM.ScrollAreaDown : RaidLobbyPM.ScrollAreaUp;
            int num2 = down ? (-num) : num;
            this.ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X, pixelMapping.Y + num2);
        }

        private Scene SearchScenes()
        {
            try
            {
                bool flag = this.MatchMapping(DialogPM.Arena_Intro_CharacterEye, 2) && this.MatchMapping(DialogPM.Arena_Intro_DimmedBackground, 2);
                if (flag)
                {
                    Scene result = new Scene(SceneType._DIALOG);
                    return result;
                }
                bool flag2 = this.MatchMapping(AndroidPopupPM.TopLeftBorder, 2) && this.MatchMapping(AndroidPopupPM.TopRightBorder, 2);
                if (flag2)
                {
                    Scene result = new Scene(SceneType._ANDROID_POPUP);
                    return result;
                }
                if (this.MatchMapping(BluestackPM.SevenKnightIcon, 2) && this.MatchMapping(BluestackPM.SearchIcon, 2) && this.MatchMapping(BluestackPM.Background, 2))
                {
                    Scene result = new Scene(SceneType.BLUESTACK_HOME);
                    return result;
                }
                if (this.MatchMapping(HeroesPM.IconLeft, 2) && this.MatchMapping(HeroesPM.IconMiddle, 2) && this.MatchMapping(HeroesPM.IconRight, 2) && this.MatchMapping(HeroesPM.OptimizeBorder, 4))
                {
                    Scene result = new Scene(SceneType.HEROES);
                    return result;
                }
                if (this.MatchMapping(HeroesSameTeamPopupPM.DimmedBG, 2) && this.MatchMapping(HeroesSameTeamPopupPM.PopupBorderLeft, 2) && this.MatchMapping(HeroesSameTeamPopupPM.PopupBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.HEROES_SAME_TEAM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Hero_BlackBar, 2) && this.MatchMapping(SharedPM.Hero_BottomLeftBorder, 2) && this.MatchMapping(HeroJoinPM.JoinButtonIcon, 2) && this.MatchMapping(HeroJoinPM.SellButton, 2))
                {
                    Scene result = new Scene(SceneType.HERO_JOIN);
                    return result;
                }
                if (this.MatchMapping(HeroRemovePM.RemoveAllButton, 2) &&
                    this.MatchMapping(HeroRemovePM.PositionButton, 2) &&
                    this.MatchMapping(HeroRemovePM.RemoveButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.HERO_REMOVE);
                    return result;
                }
                if (this.MatchMapping(Level30DialogPM.CharacterEye, 4) && this.MatchMapping(Level30DialogPM.DialogBorder, 4) && this.MatchMapping(Level30DialogPM.InboxIcon, 3))
                {
                    Scene result = new Scene(SceneType.LEVEL_30_DIALOG);
                    return result;
                }
                if (this.MatchMapping(Level30MaxDialogPM.CharacterEye, 3) && this.MatchMapping(Level30MaxDialogPM.DialogBorder, 4) && this.MatchMapping(Level30MaxDialogPM.YellowTick, 3))
                {
                    Scene result = new Scene(SceneType.LEVEL_30_MAX_DIALOG);
                    return result;
                }
                if (this.MatchMapping(LevelUpDialogPM.CharacterEye, 3) && this.MatchMapping(LevelUpDialogPM.DialogBorder, 4) && this.MatchMapping(LevelUpDialogPM.YellowTick, 3))
                {
                    Scene result = new Scene(SceneType.LEVEL_UP_DIALOG);
                    return result;
                }
                if (this.MatchMapping(LobbyPM.MenuButtonYellowLeft, 1) && this.MatchMapping(LobbyPM.MenuButtonYellowRight, 1))
                {
                    Scene result = new Scene(SceneType.LOBBY);
                    return result;
                }
                if (this.MatchMapping(QuestSelectPM.TitleBorderLeft, 1) && this.MatchMapping(QuestSelectPM.TitleBorderRight, 1) && this.MatchMapping(QuestSelectPM.SpecialQuestIcon, 3) && this.MatchMapping(QuestSelectPM.QuestIcon, 3))
                {
                    Scene result = new Scene(SceneType.QUEST_SELECT);
                    return result;
                }
                if (this.MatchMapping(SocialSelectPM.TitleBorderLeft, 1) && this.MatchMapping(SocialSelectPM.TitleBorderRight, 1) && this.MatchMapping(SocialSelectPM.FriendsIcon, 3) && this.MatchMapping(SocialSelectPM.FriendshipIcon, 3))
                {
                    Scene result = new Scene(SceneType.SOCIAL_SELECT);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Quests_Background, 3) && this.MatchMapping(SharedPM.Quests_CharacterArmor, 2) && this.MatchMapping(SpecialQuestPM.StatusBorder, 3))
                {
                    Scene result = new Scene(SceneType.SPECIAL_QUEST);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Quests_Background, 3) && this.MatchMapping(SharedPM.Quests_CharacterArmor, 2))
                {
                    Scene result = new Scene(SceneType.QUEST);
                    return result;
                }
                if (this.ExpectedFightScene(SceneType.ARENA_FIGHT) && this.MatchMapping(ArenaFightPM.ChatButton, 2) && this.MatchMapping(ArenaFightPM.PauseButton, 2))
                {
                    Scene result = new Scene(SceneType.ARENA_FIGHT);
                    return result;
                }
                if (this.ExpectedFightScene(SceneType.ADVENTURE_FIGHT) &&
                    (this.MatchMapping(SharedPM.Fight_PauseButton, 5)) &&
                    (this.MatchMapping(SharedPM.Fight_ChatButton, 5)) &&
                    (this.MatchMapping(AdventureFightPM.GoldIcon, 5))
                    )
                {
                    Scene result = new Scene(SceneType.ADVENTURE_FIGHT);
                    return result;
                }
                if (this.ExpectedFightScene(SceneType.ADVENTURE_FIGHT) &&
                    (this.MatchMapping(AdventureFightPM.GoldIcon, 5))
                    )
                {
                    Scene result = new Scene(SceneType.ADVENTURE_END);
                    return result;
                }
                if (this.MatchMapping(StatusBoardPM.LeftTabCon, 2) && this.MatchMapping(StatusBoardPM.RightTabCol, 2))
                {
                    Scene result = new Scene(SceneType.STATUS_BOARD);
                    return result;
                }

                if (this.MatchMapping(OutOfKeysOfferPM.BuyButtonBorder, 2) && this.MatchMapping(OutOfKeysOfferPM.RedCross, 2) && this.MatchMapping(OutOfKeysOfferPM.StartBG, 2))
                {
                    Scene result = new Scene(SceneType.OUT_OF_KEYS_OFFER);
                    return result;
                }
                
                if (this.MatchMapping(StatusBoardPM.NoRedCloss, 2) && this.MatchMapping(StatusBoardPM.ConfirmOKtick, 2) && this.MatchMapping(StatusBoardPM.ActiveBG, 2))
                {
                    Scene result = new Scene(SceneType.HOTTIME_CONFIRM_POPUP);
                    return result;
                }

                if (this.ExpectedFightScene(SceneType.RAID_FIGHT) && this.MatchMapping(TowerFightPM.PauseButton, 2) && this.MatchMapping(TowerFightPM.ChatButton, 2) && (this.MatchMapping(RaidFightPM.DragonIcon, 2)))
                {
                    Scene result = new Scene(SceneType.RAID_FIGHT);
                    return result;
                }
                if (this.ExpectedFightScene(SceneType.TOWER_FIGHT) &&
                    (this.MatchMapping(TowerFightPM.PauseButton, 2)) &&
                    this.MatchMapping(TowerFightPM.ChatButton, 2) &&
                    !(this.MatchMapping(AdventureFightPM.GoldIcon, 5))
                    )
                {
                    Scene result = new Scene(SceneType.TOWER_FIGHT);
                    return result;
                }
                
                if (this.MatchMapping(ShopPM.ShopCommon, 2) && this.MatchMapping(ShopPM.ShopPackge, 2))
                {
                    Scene result = new Scene(SceneType.SHOP_LOBBY);
                    return result;
                }
                
                if (this.MatchMapping(ShopPM.BoderRight, 2) && this.MatchMapping(ShopPM.Borderleft, 2) || (this.MatchMapping(ShopPM.BoderCompair1, 2) && this.MatchMapping(ShopPM.BoderCompair2, 2)))
                {
                    Scene result = new Scene(SceneType.SHOP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.ShopPopup_DimmedBG, 2) && this.MatchMapping(ShopBuyPopupPM.PopupBorderLeft, 2) && this.MatchMapping(ShopBuyPopupPM.RedCross, 2) && this.MatchMapping(ShopBuyPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.SHOP_BUY_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.ShopPopup_DimmedBG, 2) && this.MatchMapping(ShopPurchaseCompletePopupPM.PopupBorderLeft, 2) && this.MatchMapping(ShopPurchaseCompletePopupPM.YellowTick, 2) && this.MatchMapping(ShopPurchaseCompletePopupPM.ShopBGMiMic, 2))
                {
                    Scene result = new Scene(SceneType.SHOP_PURCHASE_COMPLETE_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.ShopPopup_DimmedBG, 2) && this.MatchMapping(ShopBuyFailedPopupPM.PopupBorderLeft, 2) && this.MatchMapping(ShopBuyFailedPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.SHOP_BUY_FAILED_POPUP);
                    return result;
                }
                if (this.MatchMapping(InboxPM.CharacterBody, 3) && this.MatchMapping(InboxPM.MailIcon, 2))
                {
                    Scene result = new Scene(SceneType.INBOX);
                    return result;
                }
                if (this.MatchMapping(InboxRewardsPopupPM.DimmedBG, 2) && this.MatchMapping(SharedPM.Rewards_PopupBorder, 2) && this.MatchMapping(SharedPM.Rewards_YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.INBOX_REWARDS_POPUP);
                    return result;
                }
                if (this.MatchMapping(InboxCollectFailedPopupPM.DimmedBG_1, 2) && this.MatchMapping(InboxCollectFailedPopupPM.DimmedBG_2, 2) && this.MatchMapping(InboxCollectFailedPopupPM.PopupBorder, 2))
                {
                    Scene result = new Scene(SceneType.INBOX_COLLECT_FAILED_POPUP);
                    return result;
                }
                if (this.MatchMapping(QuestRewardsPopupPM.DimmedBG, 2) && this.MatchMapping(SharedPM.Rewards_PopupBorder, 2) && this.MatchMapping(SharedPM.Rewards_YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.QUEST_REWARDS_POPUP);
                    return result;
                }
                if (this.MatchMapping(QuestCollectFailedPopupPM.DimmedBG_1, 2) && this.MatchMapping(QuestCollectFailedPopupPM.DimmedBG_2, 2) && this.MatchMapping(QuestCollectFailedPopupPM.PopupBorder, 2))
                {
                    Scene result = new Scene(SceneType.QUEST_COLLECT_FAILED_POPUP);
                    return result;
                }
                if (this.MatchMapping(GiftRewardsPopupPM.DimmedBG, 2) && this.MatchMapping(SharedPM.Rewards_PopupBorder, 2) && this.MatchMapping(SharedPM.Rewards_YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.GIFT_REWARDS_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.GiftFull_DimmedBG, 2) && this.MatchMapping(SharedPM.GiftFull_PopupBorder, 2) && this.MatchMapping(SharedPM.GiftFull_RedCross, 2) && this.MatchMapping(GiftFullItemPopupPM.SellIcon, 2))
                {
                    Scene result = new Scene(SceneType.GIFT_FULL_ITEM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.GiftFull_DimmedBG, 2) && this.MatchMapping(SharedPM.GiftFull_PopupBorder, 2) && this.MatchMapping(SharedPM.GiftFull_RedCross, 2) && this.MatchMapping(GiftFullHeroPopupPM.HeroIcon, 2))
                {
                    Scene result = new Scene(SceneType.GIFT_FULL_HERO_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.GiftFull_DimmedBG, 2) && this.MatchMapping(SharedPM.GiftFull_PopupBorder, 2))
                {
                    Scene result = new Scene(SceneType.GIFT_FULL_HONOR_POPUP);
                    return result;
                }
                if (this.MatchMapping(OutOfLuckyBoxPopupPM.DimmedBG, 2) && this.MatchMapping(OutOfLuckyBoxPopupPM.PopupBorder, 2) && this.MatchMapping(OutOfLuckyBoxPopupPM.LuckyBoxIcon, 2))
                {
                    Scene result = new Scene(SceneType.OUT_OF_LUCKY_BOX_POPUP);
                    return result;
                }
                if (this.MatchMapping(RaidLobbyPM.AwakenedShard, 2, false) && this.MatchMapping(RaidLobbyPM.AwakenedRaidEnter, 2, false))
                {
                    Scene result = new Scene(SceneType.RAID_SUMMON_LOBBY);
                    return result;
                }
                if (this.MatchMapping(RaidReadyPM.AwakenBlueIcon, 2) && this.MatchMapping(RaidReadyPM.AwakenDragonImg, 2))
                {
                    Scene result = new Scene(SceneType.RAID_AWAKENED_READY);
                    return result;
                }
                if (this.MatchMapping(RaidAwakStartPM.ManageParty1Border, 2) && this.MatchMapping(RaidAwakStartPM.ManageParty2Border, 2) && this.MatchMapping(RaidAwakStartPM.AwakenDragonImg, 2))
                {
                    Scene result = new Scene(SceneType.RAID_AWAKENED_START);
                    return result;
                }
                if (this.MatchMapping(RaidDragonPM.TopRight, 5) && this.MatchMapping(RaidDragonPM.Clouds, 8))
                {
                    Scene result = new Scene(SceneType.RAID_DRAGON);
                    return result;
                }
                if (this.MatchMapping(RaidLobbyPM.ManageParty1Border, 2) && this.MatchMapping(RaidLobbyPM.ManageParty2Border, 2))
                {
                    Scene result = new Scene(SceneType.RAID_LOBBY);
                    return result;
                }
                if (this.MatchMapping(RaidSummonLvlPM.DimmedBG, 2) && this.MatchMapping(RaidSummonLvlPM.PopupBorderLeft, 2) && this.MatchMapping(RaidSummonLvlPM.PopupBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.RAID_SUMMON_LEVEL);
                    return result;
                }
                if (this.MatchMapping(RaidReadyPM.ReadyButtonBorderLeft, 2) && this.MatchMapping(RaidReadyPM.ReadyButtonBorderRight, 2) && this.MatchMapping(RaidReadyPM.DragonHead, 2))
                {
                    Scene result = new Scene(SceneType.RAID_READY);
                    return result;
                }
                if (this.MatchMapping(RaidStartPM.ManageParty1Border, 2) && this.MatchMapping(RaidStartPM.ManageParty2Border, 2) && this.MatchMapping(RaidStartPM.StartButtonBorder, 2))
                {
                    Scene result = new Scene(SceneType.RAID_START);
                    return result;
                }
                if (this.MatchMapping(RaidEndPM.GetStrongerButton, 4) && this.MatchMapping(RaidEndPM.AgainButton, 2) && this.MatchMapping(RaidEndPM.RaidButton, 2))
                {
                    Scene result = new Scene(SceneType.RAID_END);
                    return result;
                }
                if (this.MatchMapping(RaidRewardPM.RewardButtonBackground, 2) && this.MatchMapping(RaidRewardPM.RewardButtonRedIcon, 2) && this.MatchMapping(RaidRewardPM.MemberListBackground, 2))
                {
                    Scene result = new Scene(SceneType.RAID_REWARD);
                    return result;
                }
                if (this.MatchMapping(RaidRewardPopupPM.DimmedBG, 2) && this.MatchMapping(RaidRewardPopupPM.PopupBorder, 2) && this.MatchMapping(RaidRewardPopupPM.YellowTick, 2) && this.MatchMapping(RaidRewardPopupPM.OkButtonBorder, 2))
                {
                    Scene result = new Scene(SceneType.RAID_REWARD_POPUP);
                    return result;
                }
                if (this.MatchMapping(RaidRewardPopupPM.DimmedBG, 2) && this.MatchMapping(RaidRewardPopupPM.PopupBorder, 2))
                {
                    Scene result = new Scene(SceneType.RAID_REWARD_FAILED_POPUP);
                    return result;
                }
                if (this.MatchMapping(RaidOutOfKeysPopupPM.DimmedBG, 2) && this.MatchMapping(RaidOutOfKeysPopupPM.PopupBorder, 2) && this.MatchMapping(RaidOutOfKeysPopupPM.BuyIcon, 2))
                {
                    Scene result = new Scene(SceneType.RAID_OUT_OF_KEYS_POPUP);
                    return result;
                }
                if (this.MatchMapping(RaidAlreadyEndedPopupPM.DimmedBG, 2) && this.MatchMapping(RaidOutOfKeysPopupPM.PopupBorder, 2))
                {
                    Scene result = new Scene(SceneType.RAID_ALREADY_ENDED_POPUP);
                    return result;
                }
                if (this.MatchMapping(EnterRaidAgainPopupPM.DimmedBG_1, 3) && this.MatchMapping(EnterRaidAgainPopupPM.DimmedBG_2, 2) && this.MatchMapping(EnterRaidAgainPopupPM.PopupBorder, 2) && this.MatchMapping(EnterRaidAgainPopupPM.RubyIcon, 3))
                {
                    Scene result = new Scene(SceneType.ENTER_RAID_AGAIN_POPUP);
                    return result;
                }
                if (this.MatchMapping(DisconnectedPopupPM.LeftBorder, 2) && this.MatchMapping(DisconnectedPopupPM.YellowTick, 2) && this.MatchMapping(DisconnectedPopupPM.OkButtonBorderLeft, 2) && this.MatchMapping(DisconnectedPopupPM.OkButtonBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.DISCONNECTED_POPUP);
                    return result;
                }
                if (this.MatchMapping(AdventureModesPM.BorderTopLeft, 3) && this.MatchMapping(AdventureModesPM.BorderBottomRight, 3))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_MODES);
                    return result;
                }
                if (this.MatchMapping(MasteryPopupPM.TitleBorder, 2) && this.MatchMapping(MasteryPopupPM.RedBackground, 2) && this.MatchMapping(MasteryPopupPM.CloseButton, 2))
                {
                    Scene result = new Scene(SceneType.MASTERY_POPUP);
                    return result;
                }
                if ((this.MatchMapping(MapSelectPM.QuickStartMidIcon, 2) || (this.MatchMapping(MapSelectPM.QuickStartLeftButton, 2))) && this.MatchMapping(MapSelectPM.BottomRightPanel, 3))
                {
                    Scene result = new Scene(SceneType.MAP_SELECT);
                    return result;
                }
                if (this.MatchMapping(MapSelectPopupPM.PopupBorderLeft, 2) && this.MatchMapping(MapSelectPopupPM.PopupBorderRight, 2) && this.MatchMapping(MapSelectPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.MAP_SELECT_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Full_DimmedBG, 2) && this.MatchMapping(FullItemPopupPM.SellButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.FULL_ITEM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Full_DimmedBG, 2) && this.MatchMapping(FullHeroPopupPM.SellButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.FULL_HERO_POPUP);
                    return result;
                }
                if (this.MatchMapping(BattleModesPM.BorderTopLeft, 2) && this.MatchMapping(BattleModesPM.BorderBottomRight, 2) && this.MatchMapping(BattleModesPM.QuestRedScroll, 2))
                {
                    Scene result = new Scene(SceneType.BATTLE_MODES);
                    return result;
                }
                if (this.MatchMapping(ArenaStartPM.CombatTeamBorderLeft, 2) && this.MatchMapping(ArenaStartPM.CombatTeamBorderRight, 2) && this.MatchMapping(ArenaStartPM.FormationBorderLeft, 3))
                {
                    Scene result = new Scene(SceneType.ARENA_START);
                    return result;
                }
                if (this.MatchMapping(ArenaEndPM.QuickStartButton, 2) && this.MatchMapping(ArenaEndPM.ArenaButton, 2))
                {
                    Scene result = new Scene(SceneType.ARENA_END);
                    return result;
                }
                if (this.MatchMapping(ArenaFullHonorPopupPM.PopupBorderLeft, 2) && this.MatchMapping(ArenaFullHonorPopupPM.YellowTick, 4) && this.MatchMapping(ArenaFullHonorPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.ARENA_FULL_HONOR_POPUP);
                    return result;
                }
                if (this.MatchMapping(OutOfSwordsPopupPM.PopupBorderLeft, 2) && (this.MatchMapping(OutOfSwordsPopupPM.DimmedBGStart, 2) || this.MatchMapping(OutOfSwordsPopupPM.DimmedBGEnd, 2)))
                {
                    Scene result = new Scene(SceneType.OUT_OF_SWORDS_POPUP);
                    return result;
                }
                if (this.MatchMapping(AdventureReadyPM.ReadyButtonBackground, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_READY);
                    return result;
                }
                if (this.MatchMapping(AdventureStartPM.KeyPlusButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_START);
                    return result;
                }
                if (this.MatchMapping(VictoryPM.RibbonLeft, 2) && this.MatchMapping(VictoryPM.RibbonMiddle, 2) && this.MatchMapping(VictoryPM.RibbonRight, 2))
                {
                    Scene result = new Scene(SceneType.VICTORY);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Lost_PurpleBase, 2) && this.MatchMapping(SharedPM.Lost_Moon, 2) && this.MatchMapping(AdventureLostPM.GetStrongerButton, 2) && this.MatchMapping(AdventureLostPM.AgainButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_LOST);
                    return result;
                }
                if (this.MatchMapping(GoldChamberLootPM.AgainButton, 2) && this.MatchMapping(GoldChamberLootPM.CelestialTowerButton, 2))
                {
                    Scene result = new Scene(SceneType.GOLD_CHAMBER_LOOT);
                    return result;
                }
                if (this.MatchMapping(AdventureLootPM.AdventureButton, 2) && this.MatchMapping(AdventureLootPM.QuickStartButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_LOOT);
                    return result;
                }
                if (this.MatchMapping(LootItemPM.ItemBorder, 4) && this.MatchMapping(LootItemPM.OkButton, 2) && this.MatchMapping(LootItemPM.OkButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.LOOT_ITEM);
                    return result;
                }
                if (this.MatchMapping(LootHeroPM.OkButton, 2) && this.MatchMapping(LootHeroPM.OkButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.LOOT_HERO);
                    return result;
                }

                if (this.MatchMapping(OutOfKeysPopupPM.PopupBorder, 3) && this.MatchMapping(OutOfKeysPopupPM.NoButtonBorder, 3) && this.MatchMapping(OutOfKeysPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.OUT_OF_KEYS_POPUP);
                    return result;
                }
                if (this.MatchMapping(TowerSelectPM.PreviewBorderLeft, 2) && this.MatchMapping(TowerSelectPM.PreviewBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.TOWER_SELECT);
                    return result;
                }
                if (this.MatchMapping(FriendsPM.Background, 2) && this.MatchMapping(FriendsPM.HonorIcon, 2))
                {
                    Scene result = new Scene(SceneType.FRIENDS);
                    return result;
                }
                if (this.MatchMapping(SendHonorSendingPopupPM.SocialTabBG, 2) && this.MatchMapping(SendHonorSendingPopupPM.RedCross, 2) && this.MatchMapping(SendHonorSendingPopupPM.GoldIconPlusBG, 2))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_SENDING_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Friends_DimmedBG_1, 2) && this.MatchMapping(SharedPM.Friends_DimmedBG_2, 2) && this.MatchMapping(SharedPM.Friends_PopupBorder, 2) && this.MatchMapping(SendHonorFailedPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_FAILED_POPUP);
                    return result;
                }
                if (this.HonorCount >= 300 && this.MatchMapping(SharedPM.Friends_DimmedBG_1, 2) && this.MatchMapping(SharedPM.Friends_DimmedBG_2, 2) && this.MatchMapping(SharedPM.Friends_PopupBorder, 2) && this.MatchMapping(SendHonorFullPopupPM.RedCross, 2) && this.MatchMapping(SendHonorFullPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_FULL_POPUP);
                    return result;
                }
                if (this.MatchMapping(SendHonorConfirmPopupPM.RedCross, 2) && this.MatchMapping(SendHonorConfirmPopupPM.YellowTick, 2) && this.MatchMapping(SendHonorConfirmPopupPM.GoldPlusBG, 2))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_CONFIRM_POPUP);
                    return result;
                }
                if (this.MatchMapping(TowerStartPM.KeyBoxBorder, 2) && this.MatchMapping(TowerStartPM.StartKey, 5))
                {
                    Scene result = new Scene(SceneType.TOWER_START);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Lost_PurpleBase, 2) && this.MatchMapping(SharedPM.Lost_Moon, 2) && this.MatchMapping(TowerLostPM.GetStrongerButton, 2))
                {
                    Scene result = new Scene(SceneType.TOWER_LOST);
                    return result;
                }
                if (this.MatchMapping(SellHeroConfirmPopupPM.DimmedBG_1, 2) && this.MatchMapping(SellHeroConfirmPopupPM.DimmedBG_2, 2) && this.MatchMapping(SellHeroConfirmPopupPM.RedCross, 2) && this.MatchMapping(SellHeroConfirmPopupPM.SellButtonBG, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HERO_CONFIRM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SellItemPopupPM.ItemIcon, 2) && this.MatchMapping(SellItemPopupPM.CloseButton, 2))
                {
                    Scene result = new Scene(SceneType.SELL_ITEM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SellItemConfirmPopupPM.DimmedBG_1, 2) && this.MatchMapping(SellItemConfirmPopupPM.DimmedBG_2, 2) && this.MatchMapping(SellItemConfirmPopupPM.RedCross, 2))
                {
                    Scene result = new Scene(SceneType.SELL_ITEM_CONFIRM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SpecialDungeonLootPM.LobbyButton, 2) && this.MatchMapping(SpecialDungeonLootPM.AgainButton, 2))
                {
                    Scene result = new Scene(SceneType.SPECIAL_DUN_LOOT);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Loot_LobbyButton, 2) && !this.MatchMapping(AdventureLootHeroPM.AdventureButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_LOOT_HERO_SPECIAL);
                    return result;
                }
                if (this.MatchMapping(InboxSelectHeroPM.Background, 2) && this.MatchMapping(InboxSelectHeroPM.SelectedBorder, 2) && this.MatchMapping(InboxSelectHeroPM.TitleBorder, 2) && this.MatchMapping(InboxSelectHeroPM.SelectButtonBorder, 2))
                {
                    Scene result = new Scene(SceneType.INBOX_SELECT_HERO);
                    return result;
                }
                if (this.MatchMapping(NetmarbleSplashPM.Mascot_1, 2) && this.MatchMapping(NetmarbleSplashPM.Mascot_2, 2) && this.MatchMapping(NetmarbleSplashPM.WhiteBackground, 2))
                {
                    Scene result = new Scene(SceneType.NETMARBLE_SPLASH);
                    return result;
                }
                if (this.MatchMapping(PatchUpdatePM.ProgressBarLeft, 2) && this.MatchMapping(PatchUpdatePM.ProgressBarRight, 2))
                {
                    Scene result = new Scene(SceneType.PATCH_UPDATE);
                    return result;
                }
                if (this.MatchMapping(TapToPlayPM.Point1, 2) && !this.MatchMapping(LandingPM.Shield, 2))
                {
                    Scene result = new Scene(SceneType.TAP_TO_PLAY);
                    return result;
                }
                if (this.MatchMapping(LandingPM.Shield, 2))
                {
                    Scene result = new Scene(SceneType.LANDING);
                    return result;
                }
                if (this.MatchMapping(LandingPM.LeftCheck, 2))
                {
                    Scene result = new Scene(SceneType.LOADING);
                    return result;
                }
                if (this.MatchMapping(NoticePM.TopBorderLeft, 2) && this.MatchMapping(NoticePM.TopBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.NOTICE);
                    return result;
                }
                if (this.MatchMapping(AdsPM.SkipTodayCheckBox_1, 2) && this.MatchMapping(AdsPM.SkipTodayCheckBox_2, 2) || this.MatchMapping(AdsPM.CloseButton, 2))
                {
                    Scene result = new Scene(SceneType.ADS);
                    return result;
                }
                if (this.MatchMapping(AdsClosePM.CloseButton, 2) && this.MatchMapping(AdsClosePM.CancleButton, 2))
                {
                    Scene result = new Scene(SceneType.ADS_CLOSE);
                    return result;
                }
                if (this.MatchMapping(CheckInPM.CloseButton, 2))
                {
                    Scene result = new Scene(SceneType.CHECK_IN);
                    return result;
                }
                if (this.MatchMapping(Popup1PM.CloseButton, 2))
                {
                    Scene result = new Scene(SceneType.POPUP_1);
                    return result;
                }
                if (this.MatchMapping(Popup2PM.NoButton, 2) && this.MatchMapping(Popup2PM.BuyButton, 2))
                {
                    Scene result = new Scene(SceneType.POPUP_2);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.SPrachelNo, 2) && this.MatchMapping(Popup3PM.SPrachelBuy, 2) && this.MatchMapping(Popup3PM.SPrachel, 2))
                {
                    Scene result = new Scene(SceneType.RACHEL_SPECIAL_PACK_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.SPrachelCloseOK, 2) && this.MatchMapping(Popup3PM.SPrachelCloseCancle, 2) && this.MatchMapping(Popup3PM.SPrachelBG, 2))
                {
                    Scene result = new Scene(SceneType.RACHEL_SPECIAL_PACK_CLOSE_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.AliceProColor, 2) && this.MatchMapping(Popup3PM.AliceProPurchase, 2))
                {
                    Scene result = new Scene(SceneType.ALICE_PRO_PACK_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.AliceProCloseOK, 2) && this.MatchMapping(Popup3PM.AliceProCloseCancle, 2) && this.MatchMapping(Popup3PM.AliceProBG, 2))
                {
                    Scene result = new Scene(SceneType.ALICE_PRO_PACK_CLOSE_POPUP);
                    return result;
                }
                if (this.MatchMapping(WifiWarningPopupPM.LeftBorder, 2) && this.MatchMapping(WifiWarningPopupPM.RightBorder, 2) && this.MatchMapping(WifiWarningPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.WIFI_WARNING_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.EvenBoderRight, 2) && this.MatchMapping(Popup3PM.Exclucsive, 2))
                {
                    Scene result = new Scene(SceneType.MAY_LUCKY_BOX_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.EvenBoderRightBG, 2) && this.MatchMapping(Popup3PM.ExclucsiveBG, 2) && this.MatchMapping(Popup3PM.EvenCloseCancle, 2))
                {
                    Scene result = new Scene(SceneType.MAY_LUCKY_BOX_CLOSE_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.MayCalendarVm, 2) && this.MatchMapping(Popup3PM.MayCalendarLeft, 2))
                {
                    Scene result = new Scene(SceneType.MAY_CALENDAR_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.ArenaAregon, 2) && this.MatchMapping(Popup3PM.ArenaAregonOK, 2))
                {
                    Scene result = new Scene(SceneType.ARENA_WEEK_REWARD);
                    return result;
                }
                if (this.MatchMapping(SellHeroConfirmPopupPM.GoldSellIcon, 2) && this.MatchMapping(SellHeroConfirmPopupPM.SellText, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HERO_LOBBY);
                    return result;
                }
                if (this.MatchMapping(QuestRewardsPopupPM.QuestIcon, 2) && this.MatchMapping(QuestRewardsPopupPM.AragonPic, 2))
                {
                    Scene result = new Scene(SceneType.DAILY_QUEST_COMPLETE);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.ViewMoreCol, 2) || this.MatchMapping(Popup3PM.ExclusivePic, 2))
                {
                    Scene result = new Scene(SceneType.EXCLUSIVE_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.ViewMoreBG, 2) && this.MatchMapping(Popup3PM.ExclusiveTick, 2))
                {
                    Scene result = new Scene(SceneType.EXCLUSIVE_CLOSE_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.ElementBG, 2) && this.MatchMapping(Popup3PM.ElementTick, 2))
                {
                    Scene result = new Scene(SceneType.ELEMENT_POPUP);
                    return result;
                }
                if (this.MatchMapping(SellHeroConfirmPopupPM.SellButtonbg, 2) && this.MatchMapping(SellHeroConfirmPopupPM.GoldSellIconbg, 2) && this.MatchMapping(SellHeroConfirmPopupPM.SoldOKYellowTik, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HERO_FINISH);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.EventPackColor1, 2) || this.MatchMapping(Popup3PM.EventPackColor2, 2) || this.MatchMapping(Popup3PM.EventPackPic, 2))
                {
                    Scene result = new Scene(SceneType.EVENT_PACKAGE_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.EventPackColorbg, 2) && this.MatchMapping(Popup3PM.EventPackOKBtn, 2))
                {
                    Scene result = new Scene(SceneType.EVENT_PACKAGE_CLOSE_POPUP);
                    return result;
                }
                if (this.MatchMapping(ArenaEndPM.QuickStartButtonBG, 2) && this.MatchMapping(ArenaEndPM.LobbyButtonBG, 2) && this.MatchMapping(ArenaEndPM.RankUpTik, 2))
                {
                    Scene result = new Scene(SceneType.RANK_UP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.AWAKENPackPic, 2) && this.MatchMapping(Popup3PM.AWAKENPackColor, 2))
                {
                    Scene result = new Scene(SceneType.YEAR_END_AWAKE);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.AWAKENPackColorBG, 2) && this.MatchMapping(Popup3PM.ElementTick, 2))
                {
                    Scene result = new Scene(SceneType.YEAR_END_AWAKE_POPUP);
                    return result;
                }
                if ((this.MatchMapping(SpecialDungeonReady.AllTab, 2) || this.MatchMapping(SpecialDungeonReady.DailyTab, 2) || this.MatchMapping(SpecialDungeonReady.AdventTab, 2) || this.MatchMapping(SpecialDungeonReady.EventTab, 2))
                    && this.MatchMapping(SpecialDungeonReady.KeyPlusButton, 2))
                {
                    Scene result = new Scene(SceneType.SPECIAL_DUN_READY);
                    return result;
                }
                if (this.MatchMapping(SpecialDungeonStartPM.Masterry, 2) && this.MatchMapping(SpecialDungeonStartPM.KeyPlus, 2) && this.MatchMapping(SpecialDungeonStartPM.CardPlus, 2))
                {
                    Scene result = new Scene(SceneType.SPECIAL_DUN_START);
                    return result;
                }
                if (this.MatchMapping(SpecialDungeonFightPM.ChatBT, 2) && (this.MatchMapping(SpecialDungeonFightPM.SWaveCheck, 2) || this.MatchMapping(SpecialDungeonFightPM.S1WaveCheck, 2)))
                {
                    Scene result = new Scene(SceneType.SPECIAL_DUN_FIGHT);
                    return result;
                }
                if (this.MatchMapping(SpecialDungeonReady.CardlogoBG, 2) && this.MatchMapping(SpecialDungeonReady.ReadyButtonBG, 2) && this.MatchMapping(SpecialDungeonReady.NoRedcross, 2))
                {
                    Scene result = new Scene(SceneType.SP_OUT_OF_KEYS);
                    return result;
                }
                if ((this.MatchMapping(SpecialDungeonReady.MaxKeyPlusBG, 2) && this.MatchMapping(SpecialDungeonReady.MaxCardPlusBG, 2) && this.MatchMapping(SpecialDungeonReady.MaxYellowTik, 2)) 
                    || (this.MatchMapping(SpecialDungeonStartPM.CardEnterButton, 2) && this.MatchMapping(SpecialDungeonStartPM.KeyPlusBG, 2)))
                {
                    Scene result = new Scene(SceneType.SPECIAL_DUN_MAX);
                    return result;
                }
                if (this.MatchMapping(SendHonorConfirmPopupPM.GoldPlusBG, 2) && this.MatchMapping(SendHonorFailedPopupPM.NoFriendYellowTick, 2))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_NO_FRIEND_TO_SEND);
                    return result;
                }
                if (this.MatchMapping(SharedPM.HelpFriendTik, 2) && this.MatchMapping(SharedPM.HelpFriendBorder, 2))
                {
                    Scene result = new Scene(SceneType.HELPED_FRIEND);
                    return result;
                }
                if (this.MatchMapping(OutOfSilverKeysPopupPM.PopupBorderLeft, 2) && (this.MatchMapping(OutOfSilverKeysPopupPM.DimmedBGTowerSelect, 2) || this.MatchMapping(OutOfSilverKeysPopupPM.DimmedBGGoldChamber, 2)))
                {
                    Scene result = new Scene(SceneType.OUT_OF_SILVER_KEYS_POPUP);
                    return result;
                }
                if ((this.MatchMapping(ArenaReadyPM.RecordBorder, 2) && this.MatchMapping(ArenaReadyPM.ReadyButtonBackground, 2) && this.MatchMapping(ArenaReadyPM.RubyPlus, 2))
                    || ((this.MatchMapping(ArenaReadyPM.RewardBackground, 2) && this.MatchMapping(ArenaReadyPM.CollectBorder, 2))))
                {
                    Scene result = new Scene(SceneType.ARENA_READY);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.ExitNo, 2) && this.MatchMapping(Popup3PM.ExitYes, 2))
                {
                    Scene result = new Scene(SceneType.EXIT_POPUP);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.Bolder, 2) && this.MatchMapping(Popup3PM.ClosePopupCancle, 2) && this.MatchMapping(Popup3PM.ClosePopupOK, 2))
                {
                    Scene result = new Scene(SceneType.CLOSE_POPUP);
                    return result;
                }
            }
            catch
            {
                Scene result = null;
                return result;
            }
            return null;
        }

        private int SearchStage(PixelMapping[][] anchorMappings)
        {
            this.CaptureFrame();
            int num = 0;
            for (int i = 0; i < anchorMappings.Length; i++)
            {
                PixelMapping[] array = anchorMappings[i];
                if (this.MatchMapping(array[0], 3) && this.MatchMapping(array[1], 3))
                {
                    break;
                }
                num++;
            }
            return num;
        }

        private void SelectDifficulty()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                MapSelectPM.DifficultyBox,
                MapSelectPM.DifficultyBoxSelectEasy,
                MapSelectPM.DifficultyBoxSelectNormal,
                MapSelectPM.DifficultyBoxSelectHard
            };
            Difficulty aD_Difficulty = Difficulty.None;
            PixelMapping mapping;
            if (MapZone.Equals("Asgar"))
            {
                aD_Difficulty = this.AISettings.AD_Difficulty;
            }
            else if (MapZone.Equals("Aisha") || MapZone.Equals("ShadowsEye"))
            {
                aD_Difficulty = this.AISettings.AD_Difficulty2nd;
            }
            mapping = array[(int)aD_Difficulty];
            if (this.MatchMapping(MapSelectPM.DifficultyBoxExpanded, 2))
            {
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                return;
            }
            if (aD_Difficulty != Difficulty.None)
            {
                this.WeightedClick(array[0], 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(500);
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
            }
        }

        private void SelectStage(PixelMapping[][] anchorMappings, PixelMapping stageMapping, int pageDestIndex)
        {
            int num = this.SearchStage(anchorMappings);
            if (num > anchorMappings.Length - 1)
            {
                return;
            }
            if (num != pageDestIndex)
            {
                int num2 = this.FindShortestWorldPath(num, pageDestIndex, anchorMappings.Length);
                PixelMapping mapping = (num2 > 0) ? MapSelectPM.NextButton : MapSelectPM.PreviousButton;
                for (int i = 0; i < Math.Abs(num2); i++)
                {
                    this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(500);
                }
            }
            SevenKnightsCore.Sleep(500);
            int num3 = this.SearchStage(anchorMappings);
            if (num3 == pageDestIndex)
            {
                this.SelectDifficulty();
                SevenKnightsCore.Sleep(500);
                this.WeightedClick(stageMapping, 1.0, 1.0, 1, 0, "left");
            }
        }

        private void SelectStageAsgar(World world, int stage)
        {
            PixelMapping[][] anchorMappings = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World1Anchor_1,
                    MapSelectPM.World1Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World2Anchor_1,
                    MapSelectPM.World2Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World3Anchor_1,
                    MapSelectPM.World3Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World4Anchor_1,
                    MapSelectPM.World4Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World5Anchor_1,
                    MapSelectPM.World5Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World6Anchor_1,
                    MapSelectPM.World6Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World7Anchor_1,
                    MapSelectPM.World7Anchor_2
                }
            };
            PixelMapping[][] array = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World1Stage1,
                    MapSelectPM.World1Stage2,
                    MapSelectPM.World1Stage3,
                    MapSelectPM.World1Stage4,
                    MapSelectPM.World1Stage5,
                    MapSelectPM.World1Stage6,
                    MapSelectPM.World1Stage7,
                    MapSelectPM.World1Stage8,
                    MapSelectPM.World1Stage9,
                    MapSelectPM.World1Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World2Stage1,
                    MapSelectPM.World2Stage2,
                    MapSelectPM.World2Stage3,
                    MapSelectPM.World2Stage4,
                    MapSelectPM.World2Stage5,
                    MapSelectPM.World2Stage6,
                    MapSelectPM.World2Stage7,
                    MapSelectPM.World2Stage8,
                    MapSelectPM.World2Stage9,
                    MapSelectPM.World2Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World3Stage1,
                    MapSelectPM.World3Stage2,
                    MapSelectPM.World3Stage3,
                    MapSelectPM.World3Stage4,
                    MapSelectPM.World3Stage5,
                    MapSelectPM.World3Stage6,
                    MapSelectPM.World3Stage7,
                    MapSelectPM.World3Stage8,
                    MapSelectPM.World3Stage9,
                    MapSelectPM.World3Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World4Stage1,
                    MapSelectPM.World4Stage2,
                    MapSelectPM.World4Stage3,
                    MapSelectPM.World4Stage4,
                    MapSelectPM.World4Stage5,
                    MapSelectPM.World4Stage6,
                    MapSelectPM.World4Stage7,
                    MapSelectPM.World4Stage8,
                    MapSelectPM.World4Stage9,
                    MapSelectPM.World4Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World5Stage1,
                    MapSelectPM.World5Stage2,
                    MapSelectPM.World5Stage3,
                    MapSelectPM.World5Stage4,
                    MapSelectPM.World5Stage5,
                    MapSelectPM.World5Stage6,
                    MapSelectPM.World5Stage7,
                    MapSelectPM.World5Stage8,
                    MapSelectPM.World5Stage9,
                    MapSelectPM.World5Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World6Stage1,
                    MapSelectPM.World6Stage2,
                    MapSelectPM.World6Stage3,
                    MapSelectPM.World6Stage4,
                    MapSelectPM.World6Stage5,
                    MapSelectPM.World6Stage6,
                    MapSelectPM.World6Stage7,
                    MapSelectPM.World6Stage8,
                    MapSelectPM.World6Stage9,
                    MapSelectPM.World6Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World7Stage1,
                    MapSelectPM.World7Stage2,
                    MapSelectPM.World7Stage3,
                    MapSelectPM.World7Stage4,
                    MapSelectPM.World7Stage5,
                    MapSelectPM.World7Stage6,
                    MapSelectPM.World7Stage7,
                    MapSelectPM.World7Stage8,
                    MapSelectPM.World7Stage9,
                    MapSelectPM.World7Stage10
                }
            };
            if (world == World.None)
            {
                this.WeightedClick(MapSelectPM.QuickStartMidButton, 1.0, 1.0, 1, 0, "left");
                return;
            }
            int num = world - World.MysticWoods;
            PixelMapping stageMapping = array[num][stage];
            this.SelectStage(anchorMappings, stageMapping, num);
        }

        private void SelectStageAisha(World world, int stage)
        {
            PixelMapping[][] array = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World8_1Anchor_1,
                    MapSelectPM.World8_1Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World8_2Anchor_1,
                    MapSelectPM.World8_2Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World8_3Anchor_1,
                    MapSelectPM.World8_3Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World8_4Anchor_1,
                    MapSelectPM.World8_4Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World9_1Anchor_1,
                    MapSelectPM.World9_1Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World9_2Anchor_1,
                    MapSelectPM.World9_2Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World9_3Anchor_1,
                    MapSelectPM.World9_3Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World10_1Anchor_1,
                    MapSelectPM.World10_1Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World10_2Anchor_1,
                    MapSelectPM.World10_2Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World11_1Anchor_1,
                    MapSelectPM.World11_1Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World11_2Anchor_1,
                    MapSelectPM.World11_2Anchor_2
                }
            };
            PixelMapping[][] stages = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World8_1Stage1,
                    MapSelectPM.World8_1Stage2,
                    MapSelectPM.World8_1Stage3,
                    MapSelectPM.World8_1Stage4,
                    MapSelectPM.World8_1Stage5,
                    MapSelectPM.World8_2Stage6,
                    MapSelectPM.World8_2Stage7,
                    MapSelectPM.World8_2Stage8,
                    MapSelectPM.World8_2Stage9,
                    MapSelectPM.World8_2Stage10,
                    MapSelectPM.World8_3Stage11,
                    MapSelectPM.World8_3Stage12,
                    MapSelectPM.World8_3Stage13,
                    MapSelectPM.World8_3Stage14,
                    MapSelectPM.World8_3Stage15,
                    MapSelectPM.World8_4Stage16,
                    MapSelectPM.World8_4Stage17,
                    MapSelectPM.World8_4Stage18,
                    MapSelectPM.World8_4Stage19,
                    MapSelectPM.World8_4Stage20,
                },
                new PixelMapping[]
                {
                    MapSelectPM.World9_1Stage1,
                    MapSelectPM.World9_1Stage2,
                    MapSelectPM.World9_1Stage3,
                    MapSelectPM.World9_1Stage4,
                    MapSelectPM.World9_1Stage5,
                    MapSelectPM.World9_2Stage6,
                    MapSelectPM.World9_2Stage7,
                    MapSelectPM.World9_2Stage8,
                    MapSelectPM.World9_2Stage9,
                    MapSelectPM.World9_2Stage10,
                    MapSelectPM.World9_3Stage11,
                    MapSelectPM.World9_3Stage12,
                    MapSelectPM.World9_3Stage13,
                    MapSelectPM.World9_3Stage14,
                    MapSelectPM.World9_3Stage15
                },
                new PixelMapping[]
                {
                    MapSelectPM.World10_1Stage1,
                    MapSelectPM.World10_1Stage2,
                    MapSelectPM.World10_1Stage3,
                    MapSelectPM.World10_1Stage4,
                    MapSelectPM.World10_1Stage5,
                    MapSelectPM.World10_2Stage6,
                    MapSelectPM.World10_2Stage7,
                    MapSelectPM.World10_2Stage8,
                    MapSelectPM.World10_2Stage9,
                    MapSelectPM.World10_2Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World11_1Stage1,
                    MapSelectPM.World11_1Stage2,
                    MapSelectPM.World11_1Stage3,
                    MapSelectPM.World11_1Stage4,
                    MapSelectPM.World11_1Stage5,
                    MapSelectPM.World11_2Stage6,
                    MapSelectPM.World11_2Stage7,
                    MapSelectPM.World11_2Stage8,
                    MapSelectPM.World11_2Stage9,
                    MapSelectPM.World11_2Stage10
                }
            };
            int pageDestIndex = array.Length + 1;
            if (world == World.None)
            {
                this.WeightedClick(MapSelectPM.QuickStartLeftButton, 1.0, 1.0, 1, 0, "left");
                return;
            }
            PixelMapping stageMapping;
            if (world == World.MoonlitIsle)
            {
                stageMapping = stages[0][stage];
                if (stage < 5)
                {
                    pageDestIndex = 0;
                }
                else if (stage < 10)
                {
                    pageDestIndex = 1;
                }
                else if (stage < 15)
                {
                    pageDestIndex = 2;
                }
                else if (stage < 20)
                {
                    pageDestIndex = 3;
                }
            }
            else if (world == World.WesternEmpire)
            {
                stageMapping = stages[1][stage];
                if (stage < 5)
                {
                    pageDestIndex = 4;
                }
                else if (stage < 10)
                {
                    pageDestIndex = 5;
                }
                else if (stage < 15)
                {
                    pageDestIndex = 6;
                }
            }
            else if (world == World.EasternEmpire)
            {
                stageMapping = stages[2][stage];
                if (stage < 5)
                {
                    pageDestIndex = 7;
                }
                else if (stage < 10)
                {
                    pageDestIndex = 8;
                }
            }
            else if (world == World.DarkSanctuary)
            {
                stageMapping = stages[3][stage];
                if (stage < 5)
                {
                    pageDestIndex = 9;
                }
                else if (stage < 10)
                {
                    pageDestIndex = 10;
                }
            }
            else
            {
                return;
            }
            this.SelectStage(array, stageMapping, pageDestIndex);
        }

        private void SelectStageShadowsEye(World world, int stage)
        {
            PixelMapping[][] anchorMappings = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World12_1Anchor_1,
                    MapSelectPM.World12_1Anchor_2
                }
            };
            PixelMapping[][] array = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World12_1Stage1,
                    MapSelectPM.World12_1Stage2,
                    MapSelectPM.World12_1Stage3,
                    MapSelectPM.World12_1Stage4,
                    MapSelectPM.World12_1Stage5,
                    MapSelectPM.World12_1Stage6,
                    MapSelectPM.World12_1Stage7,
                    MapSelectPM.World12_1Stage8,
                    MapSelectPM.World12_1Stage9,
                    MapSelectPM.World12_1Stage10
                }
            };
            if (world == World.None)
            {
                this.WeightedClick(MapSelectPM.QuickStartMidButton, 1.0, 1.0, 1, 0, "left");
                return;
            }
            int num = world - World.ShadowsEye;
            PixelMapping stageMapping = array[num][stage];
            this.SelectStage(anchorMappings, stageMapping, num);
        }


        private void SelectTeam(SceneType sceneType)
        {
            Team team = Team.None;
            PixelMapping[] array = new PixelMapping[]
            {
                SharedPM.PrepareFight_TeamAButton,
                SharedPM.PrepareFight_TeamBButton,
                SharedPM.PrepareFight_TeamCButton
            };
            if (sceneType != SceneType.ADVENTURE_START)
            {
                if (sceneType == SceneType.TOWER_START)
                {
                    team = this.AISettings.GC_Team;
                }
            }
            else
            {
                team = this.AISettings.AD_Team;
            }
            if (team == Team.None)
            {
                return;
            }
            this.WeightedClick(array[team - Team.A], 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(500);
        }

        private void SelectTeamHero()
        {
            Team team = Team.None;
            PixelMapping[] array = new PixelMapping[]
            {
                HeroesPM.TeamAButton,
                HeroesPM.TeamBButton,
                HeroesPM.TeamCButton
            };
            team = this.AISettings.AD_Team;
            if (team == Team.None)
            {
                return;
            }
            this.WeightedClick(array[team - Team.A], 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(500);
        }

        private void SellHeroes()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                SellHeroConfirmPopupPM.Star1,
                SellHeroConfirmPopupPM.Star2,
                SellHeroConfirmPopupPM.Star3,
                SellHeroConfirmPopupPM.Star4,
                SellHeroConfirmPopupPM.Star5,
                SellHeroConfirmPopupPM.Star6
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                HeroesPM.HeroCard1,
                HeroesPM.HeroCard2,
                HeroesPM.HeroCard3,
                HeroesPM.HeroCard4,
                HeroesPM.HeroCard5,
                HeroesPM.HeroCard6,
                HeroesPM.HeroCard7,
                HeroesPM.HeroCard8,
                HeroesPM.HeroCard9,
                HeroesPM.HeroCard10
            };
            PixelMapping[][] array3 = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    SellHeroConfirmPopupPM.ElementWater_1,
                    SellHeroConfirmPopupPM.ElementWater_2,
                    SellHeroConfirmPopupPM.ElementWater_3
                },
                new PixelMapping[]
                {
                    SellHeroConfirmPopupPM.ElementFire_1,
                    SellHeroConfirmPopupPM.ElementFire_2,
                    SellHeroConfirmPopupPM.ElementFire_3
                },
                new PixelMapping[]
                {
                    SellHeroConfirmPopupPM.ElementLight_1,
                    SellHeroConfirmPopupPM.ElementLight_2,
                    SellHeroConfirmPopupPM.ElementLight_3
                },
                new PixelMapping[]
                {
                    SellHeroConfirmPopupPM.ElementDark_1,
                    SellHeroConfirmPopupPM.ElementDark_2,
                    SellHeroConfirmPopupPM.ElementDark_3
                },
                new PixelMapping[]
                {
                    SellHeroConfirmPopupPM.ElementRock_1,
                    SellHeroConfirmPopupPM.ElementRock_2,
                    SellHeroConfirmPopupPM.ElementRock_3
                }
            };
            this.Log("Start selling heroes", this.COLOR_SELL_HEROES);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI will only sell the hero if the given condition is met.");
            if (!this.MatchMapping(HeroesPM.SortByBoxExpanded, 2))                                          
            {
                this.WeightedClick(HeroesPM.SortByBox, 1.0, 1.0, 1, 0, "left");                            
                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            }
            this.WeightedClick(HeroesPM.SortByRank, 1.0, 1.0, 1, 0, "left");                               
            SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            if (!this.MatchMapping(HeroesPM.SortButtonAscending, 2))                                        
            {
                this.WeightedClick(HeroesPM.SortButton, 1.0, 1.0, 1, 0, "left");                            
                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            }
            this.ScrollHeroCards(false);                                                                   
            SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            bool flag = false;
            int monstar = 0;
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            while (num3 < 100 && !this.Worker.CancellationPending)                                  
            {
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.HEROES)                           
                {
                    this.DoneSellHeroes(-1);                                                                
                    return;
                }
                if (this.MatchMapping(HeroesPM.LastRow_1, 3) && this.MatchMapping(HeroesPM.LastRow_2, 3))   
                {
                    flag = true;                                                                            
                }
                if (!this.AISettings.RS_SellHeroAll && num2 >= this.AISettings.RS_SellHeroAmount)           
                {
                    this.DoneSellHeroes(-1);                                                                
                    return;
                }
                /**************************************************************************************/
                if (this.MatchMapping(HeroStar.Star1Loca1, 2) || this.MatchMapping(HeroStar.Star1Loca2, 2)
                     || this.MatchMapping(HeroStar.Star1Loca3, 2) || this.MatchMapping(HeroStar.Star1Loca4, 2)
                     || this.MatchMapping(HeroStar.Star1Loca1R1, 2) || this.MatchMapping(HeroStar.Star1Loca2R1, 2)
                     || this.MatchMapping(HeroStar.Star1Loca3R1, 2) || this.MatchMapping(HeroStar.Star1Loca4R1, 2)
                     || this.MatchMapping(HeroStar.Star1Loca1R2, 2) || this.MatchMapping(HeroStar.Star1Loca2R2, 2)
                     || this.MatchMapping(HeroStar.Star1Loca3R2, 2) || this.MatchMapping(HeroStar.Star1Loca4R2, 2))
                {
                    monstar = 1;
                }
                else if (this.MatchMapping(HeroStar.Star2Loca1, 2) || this.MatchMapping(HeroStar.Star2Loca2, 2)
                     || this.MatchMapping(HeroStar.Star2Loca3, 2) || this.MatchMapping(HeroStar.Star2Loca4, 2)
                     || this.MatchMapping(HeroStar.Star2Loca1R3, 2) || this.MatchMapping(HeroStar.Star2Loca2R3, 2)
                     || this.MatchMapping(HeroStar.Star2Loca3R3, 2) || this.MatchMapping(HeroStar.Star2Loca4R3, 2)
                     || this.MatchMapping(HeroStar.Star2Loca1R4, 2) || this.MatchMapping(HeroStar.Star2Loca2R4, 2)
                     || this.MatchMapping(HeroStar.Star2Loca3R4, 2) || this.MatchMapping(HeroStar.Star2Loca4R4, 2)
                     || this.MatchMapping(HeroStar.Star2Loca1R5, 2) || this.MatchMapping(HeroStar.Star2Loca2R5, 2)
                     || this.MatchMapping(HeroStar.Star2Loca3R5, 2) || this.MatchMapping(HeroStar.Star2Loca4R5, 2))
                {
                    monstar = 2;
                }
                else if (this.MatchMapping(HeroStar.Star3Loca1R1, 2) || this.MatchMapping(HeroStar.Star3Loca2R1, 2)
                     || this.MatchMapping(HeroStar.Star3Loca3R1, 2) || this.MatchMapping(HeroStar.Star3Loca4R1, 2)
                     || this.MatchMapping(HeroStar.Star3Loca3R2, 2) || this.MatchMapping(HeroStar.Star3Loca4R2, 2)
                     || this.MatchMapping(HeroStar.Star3Loca3R2, 2) || this.MatchMapping(HeroStar.Star3Loca4R2, 2)
                     || this.MatchMapping(HeroStar.Star3Loca3R3, 2) || this.MatchMapping(HeroStar.Star3Loca4R3, 2)
                     || this.MatchMapping(HeroStar.Star3Loca3R3, 2) || this.MatchMapping(HeroStar.Star3Loca4R3, 2))
                {
                    monstar = 3;
                }
                else
                {
                    monstar = 4;
                }
                if (monstar <= this.AISettings.RS_SellHeroStars)
                {
                        //ตรวจเวล 30
                        SevenKnightsCore.Sleep(500);
                        this.WeightedClick(array2[num], 1.0, 1.0, 1, 0, "left");                                    
                        SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                        this.CaptureFrame();
                        scene = this.SceneSearch();
                    if (scene != null && scene.SceneType != SceneType.HERO_JOIN && scene.SceneType != SceneType.HERO_REMOVE)
                    {
                        this.DoneSellHeroes(-1);
                        return;
                    }
                    if (this.IsHeroLevel30() && this.MatchMapping(HeroJoinPM.KeyLockButton, 2)
                            && this.MatchMapping(HeroJoinPM.SellButton, 2))                                     
                    {
                        this.WeightedClick(HeroJoinPM.SellButton, 1.0, 1.0, 1, 0, "left");                  
                        SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                        this.WeightedClick(SellHeroConfirmPopupPM.SellLobbyButton, 1.0, 1.0, 1, 0, "left"); 
                        SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                        this.CaptureFrame();                                                                
                        scene = this.SceneSearch();
                        if (scene != null && scene.SceneType != SceneType.SELL_HERO_CONFIRM_POPUP)          
                        {
                            this.Log("Stop Sell Hero.");
                            this.DoneSellHeroes(-1);
                            return;
                        }
                        PixelMapping[][] array4 = array3;
                        for (int j = 0; j < array4.Length; j++)
                        {
                            PixelMapping[] array5 = array4[j];
                            if (this.MatchMapping(array5[0], 5) && this.MatchMapping(array5[1], 5) && this.MatchMapping(array5[2], 5))
                            {
                                this.Log("-- Found element hero, skipping..", this.COLOR_SELL_HEROES);
                                this.WeightedClick(SellHeroConfirmPopupPM.NoButton, 1.0, 1.0, 1, 0, "left");
                                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                                this.Escape();
                                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                            }
                        }
                        num2++;
                        this.WeightedClick(SellHeroConfirmPopupPM.SellButton, 1.0, 1.0, 1, 0, "left");     
                        int n = 1;
                        while (n <= 100)
                        {
                            SevenKnightsCore.Sleep(300);
                            this.CaptureFrame();
                            if (!this.MatchMapping(SellHeroConfirmPopupPM.SoldOKYellowTik, 2) && !this.MatchMapping(SellHeroConfirmPopupPM.SellButtonbg, 2))
                            {
                                n++;
                            }
                            else
                            {
                                n = 110;
                                SevenKnightsCore.Sleep(500);
                                this.WeightedClick(SellHeroConfirmPopupPM.SoldOKButton, 1.0, 1.0, 1, 0, "left");
                                this.Log(string.Format("-- Hero sold ({0})", num2), this.COLOR_SELL_HEROES);
                                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                                this.DoneSellHeroesMini();
                            }
                        }
                    }
                    else
                    {
                        num = num + 1;
                        this.Escape();
                        SevenKnightsCore.Sleep(500);
                    }
                    if (!flag)
                    {
                        num %= 4;
                    }
                    if (num == 0)
                    {
                        this.ScrollHeroCards(true);
                        SevenKnightsCore.Sleep(800);
                    }
                    if (flag && num >= array2.Length)
                    {
                        this.DoneSellHeroes(num2);
                        return;
                    }
                }
                else
                {
                    this.DoneSellHeroes(-1);                                                                
                    return;
                }
                num3++;
            }
            return;
        }

        private void SellItems()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                SellItemPopupPM.SellButtonRow1,
                SellItemPopupPM.SellButtonRow2,
                SellItemPopupPM.SellButtonRow3,
                SellItemPopupPM.SellButtonRow4,
                SellItemPopupPM.SellButtonRow5
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                SellItemConfirmPopupPM.Star1,
                SellItemConfirmPopupPM.Star2,
                SellItemConfirmPopupPM.Star3,
                SellItemConfirmPopupPM.Star4,
                SellItemConfirmPopupPM.Star5,
                SellItemConfirmPopupPM.Star6
            };
            this.Log("Start selling items", this.COLOR_SELL_ITEMS);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI will only sell the item if the given condition is met.");
            if (this.MatchMapping(SellItemPopupPM.SortButtonDescending, 2))                                     
            {
                this.WeightedClick(SellItemPopupPM.SortButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(300);
            }
            this.ScrollItemPopup(false);
            SevenKnightsCore.Sleep(500);
            bool flag = false;
            int num = 0;
            int num2 = 0;
            ulong num3 = 0uL;
            ulong hash = 0uL;
            double num4 = 99.9;
            int num5 = 0;
            while (num5 < 80 && !this.Worker.CancellationPending)
            {
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.SELL_ITEM_POPUP)
                {
                    this.DoneSellItems(-1);
                    return;
                }
                if (!this.AISettings.RS_SellItemAll && num2 >= this.AISettings.RS_SellItemAmount)
                {
                    this.DoneSellItems(num2);
                    return;
                }
                if (!this.MatchMapping(array[num], 3))
                {
                    this.DoneSellItems(num2);
                    return;
                }
                this.WeightedClick(array[num], 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(500);
                this.CaptureFrame();
                scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.SELL_ITEM_CONFIRM_POPUP)
                {
                    this.DoneSellItems(-1);
                    return;
                }
                int num6 = -1;
                for (int i = 5; i >= 0; i--)
                {
                    if (this.MatchMapping(array2[i], 8))
                    {
                        num6 = i + 1;
                        break;
                    }
                }
                int num7 = this.AISettings.RS_SellItemStars;
                if (num6 != -1 && num6 <= this.AISettings.RS_SellItemStars)
                {
                    num2++;
                    this.Log(string.Format("-- Item sold ({0})", num2), this.COLOR_SELL_ITEMS);
                    this.WeightedClick(SellItemConfirmPopupPM.SellButton, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(1000);
                }
                else
                {
                    num++;
                    if (!flag)
                    {
                        num %= 2;
                    }
                    this.WeightedClick(SellItemConfirmPopupPM.NoButton, 1.0, 1.0, 1, 0, "left");
                    if (num == 0)
                    {
                        SevenKnightsCore.Sleep(500);
                        this.ScrollItemPopup(true);
                        SevenKnightsCore.Sleep(200);
                        Bitmap frame = this.CaptureFrame();
                        scene = this.SceneSearch();
                        if (scene != null && scene.SceneType != SceneType.SELL_ITEM_POPUP)
                        {
                            this.DoneSellItems(-1);
                            return;
                        }
                        using (Bitmap bitmap = this.CropFrame(frame, SellItemPopupPM.R_ScrollBarArea))
                        {
                            ulong num8 = ImageHashing.AverageHash(bitmap);
                            double num9 = ImageHashing.Similarity(num3, num8);
                            double num10 = ImageHashing.Similarity(hash, num8);
                            if (!flag && num3 != 0uL && num9 >= num4 && num10 >= num4)
                            {
                                Console.WriteLine("At last row");
                                flag = true;
                                num = 2;
                            }
                            hash = num3;
                            num3 = num8;
                        }
                    }
                }
                if (flag && num >= array.Length)
                {
                    this.DoneSellItems(num2);
                    return;
                }
                SevenKnightsCore.Sleep(1200);
                num5++;
            }
        }

        private void SendHonors()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                FriendsPM.FacebookTab,
                FriendsPM.InGameTab
            };
            PixelMapping arg_34_0 = FriendsPM.Facebook_TabSelected;
            PixelMapping arg_3A_0 = FriendsPM.InGame_TabSelected;
            string[] array2 = new string[]
            {
                "Facebook friends",
                "In-Game friends"
            };
            bool[] array3 = new bool[]
            {
                this.AISettings.RS_SendHonorsFacebook,
                this.AISettings.RS_SendHonorsInGame
            };

            this.Log("Start sending honors", this.COLOR_HONOR);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "AI is sending honors to friends.");
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array3[i])
                {
                    list.Add(i);
                }
            }
            if (list.Count <= 0)
            {
                this.Log("Nothing to do", this.COLOR_HONOR);
                this.DoneSendHonors();
                return;
            }
            foreach (int current in list)
            {
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                SevenKnightsCore.Sleep(500);
                this.Log(string.Format("Sending to {0}", array2[current]), this.COLOR_HONOR);
                PixelMapping mapping = array[current];
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.FRIENDS)
                {
                    this.DoneSendHonors();
                    return;
                }
                this.UpdateHonor(SceneType.FRIENDS);
                if (current == 0 && this.MatchMapping(FriendsPM.Facebook_NotConnected, 4))
                {
                    this.Log("Not connected to facebook", this.COLOR_HONOR);
                }
                else
                {
                    this.WeightedClick(FriendsPM.SortByLogin, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(500);
                    this.WeightedClick(FriendsPM.SendAllButton, 1.0, 1.0, 1, 0, "left");  
                    SevenKnightsCore.Sleep(1000);
                    this.CaptureFrame();
                    if (this.MatchMapping(SendHonorConfirmPopupPM.RedCross, 2) && this.MatchMapping(SendHonorConfirmPopupPM.YellowTick, 2) && this.MatchMapping(SendHonorConfirmPopupPM.GoldPlusBG, 2))
                    {
                        this.WeightedClick(SendHonorConfirmPopupPM.HonorsGiftButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(1000);
                        this.CaptureFrame();
                        while (!this.Worker.CancellationPending && this.MatchMapping(SendHonorSendingPopupPM.RedCross, 2))
                        {
                            this.CaptureFrame();
                            SevenKnightsCore.Sleep(500);
                        }
                        SevenKnightsCore.Sleep(500);
                        this.CaptureFrame();
                        scene = this.SceneSearch();
                        if (scene == null || scene.SceneType != SceneType.SEND_HONOR_FAILED_POPUP || scene.SceneType != SceneType.SEND_HONOR_FULL_POPUP || scene.SceneType != SceneType.SEND_HONOR_CONFIRM_POPUP)
                        {
                            SevenKnightsCore.Sleep(1000);
                        }
                        else
                        {
                            if (scene.SceneType == SceneType.SEND_HONOR_FULL_POPUP || scene.SceneType == SceneType.SEND_HONOR_CONFIRM_POPUP)
                            {
                                this.DoneSendHonors();
                                return;
                            }
                            if (scene.SceneType == SceneType.SEND_HONOR_FAILED_POPUP)
                            {
                                SevenKnightsCore.Sleep(300);
                                this.Escape();
                            }

                        }
                    }
                    else
                    {
                        SevenKnightsCore.Sleep(300);
                        this.Escape();
                    }
                }
            }
            this.DoneSendHonors();
        }

        private void StopLuckyBox(bool escape = true)
        {
            this.EnableLuckyBox = false;
            if (escape)
            {
                this.Escape();
            }
        }

        private void ToggleAutoSkill(bool shouldUse)
        {
            if (
                ((!shouldUse && this.MatchMapping(SharedPM.Fight_AutoSkillOnTop, 2) && this.MatchMapping(SharedPM.Fight_AutoSkillOnBottom, 2))) 
                || (shouldUse && this.MatchMapping(SharedPM.Fight_AutoSkillOff, 2))
                )
            {
                this.WeightedClick(SharedPM.Fight_AutoSkillButton, 1.0, 1.0, 1, 0, "left");
            }
        }

        private void ToggleTowerAutoSkill()
        {
            if (this.AISettings.GC_SkillType == SkillType.Manual && this.MatchMapping(TowerFightPM.Fight_AutoSkillOnBottom, 2) && this.MatchMapping(SharedPM.Fight_AutoSkillOnTop, 2))
            {
                this.WeightedClick(SharedPM.Fight_AutoSkillButton, 1.0, 1.0, 1, 0, "left");
            }
        }

        private void UpdateHeroCount()
        {
            int curHero = HeroCount;
            string maxHero = HeroMax;
            Rectangle rect = HeroesPM.R_HeroCount;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    Utility.FilterAscii(text);
                    if (text.Length >= 2)
                    {
                        string[] array = text.Split(new char[]
                            {
                                '/'
                            });

                        if (array.Length >= 1)
                            int.TryParse(array[0], out curHero);
                        if (array.Length >= 2)
                        {
                            maxHero = array[1].Substring(0, 3);
                        }
#if DEBUG
                        this.Log(string.Format("HC: {0}/{1} String: {2}", curHero, maxHero, text.Trim()));
                        bitmap.Save(string.Format("H_{0} of {1}.png", curHero, maxHero));
#endif
                    }
                    this.HeroCount = curHero;
                    this.HeroMax = maxHero;
                    this.ReportCount(Objective.HERO_MANAGEMENT);
                }
            }
        }

        private void HeroLVUPCount()
        {
            int curCount = 0;
            Rectangle rect = Level30DialogPM.R_HeroLvlUpCount;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null, PageSegMode.Auto))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace("Z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Trim();

                    Console.WriteLine("OldText =" + "'" + text + "'");
                    string text1 = Regex.Replace(text, @"\D", "");
                    Utility.FilterAscii(text1);
#if DEBUG
                    bitmap.Save("HeroCount.png");
                    Console.WriteLine("NewText = " + text1);
#endif
                    if (text1.Length != 0)
                    {
                        Console.WriteLine("FilterText =" + "'" + text1 + "'");
                        int.TryParse(text1, out curCount);
                        if (curCount < 100)
                        {
                            this.SendTelegram(this.AIProfiles.ST_TelegramChatID, string.Format("Max Heroes level up per day : {0}/100", curCount));
                            this.Log(string.Format("Max Heroes level up per day : {0}/100", curCount), Color.BlueViolet);
                            this.ReportCount(Objective.HERO_MANAGEMENT);
                        }
                        else if (curCount == 100)
                        {
                            this.SendTelegram(this.AIProfiles.ST_TelegramChatID, string.Format("Max Heroes level up per day : {0}/100", curCount));
                            this.Log(string.Format("Max Heroes level up per day : {0}/100", curCount), Color.BlueViolet);
                            this.MaxHeroUpCount = true;
                            this.NextPossibleObjective();
                        }
                        h30 = curCount;
                        this.ReportCount(Objective.HERO_MANAGEMENT);
                    }
                }
            }
        }


        private void UpdateAdventureKeys(SceneType sceneType)
        {
            Dictionary<SceneType, Point> dictionary = new Dictionary<SceneType, Point>
            {
                {
                    SceneType.LOBBY,
                    new Point(LobbyPM.KEY_OFFSET_X, LobbyPM.KEY_OFFSET_Y)
                },
                {
                    SceneType.INBOX,
                    new Point(InboxPM.KEY_OFFSET_X, InboxPM.KEY_OFFSET_Y)
                },
                {
                    SceneType.HEROES,
                    new Point(HeroesPM.KEY_OFFSET_X, HeroesPM.KEY_OFFSET_Y)
                },
                {
                    SceneType.SHOP,
                    new Point(ShopPM.KEY_OFFSET_X, ShopPM.KEY_OFFSET_Y)
                },
                {
                    SceneType.ADVENTURE_START,
                    new Point(AdventureStartPM.KEY_OFFSET_X, AdventureStartPM.KEY_OFFSET_Y)
                },
                {
                    SceneType.ADVENTURE_MODES,
                    new Point(AdventureModesPM.KEY_OFFSET_X, AdventureModesPM.KEY_OFFSET_Y)
                },
                {
                    SceneType.MAP_SELECT,
                    new Point(MapSelectPM.KEY_OFFSET_X, MapSelectPM.KEY_OFFSET_Y)
                },
                {
                    SceneType.FRIENDS,
                    new Point(FriendsPM.KEY_OFFSET_X, FriendsPM.KEY_OFFSET_Y)
                },
                {
                    SceneType.QUEST,
                    new Point(QuestPM.KEY_OFFSET_X, QuestPM.KEY_OFFSET_Y)
                },
                {
                    SceneType.SPECIAL_QUEST,
                    new Point(SpecialQuestPM.KEY_OFFSET_X, SpecialQuestPM.KEY_OFFSET_Y)
                }
                ,
                {
                    SceneType.SPECIAL_DUN_READY,
                    new Point(SpecialDungeonReady.KEY_OFFSET_X, SpecialDungeonReady.KEY_OFFSET_Y)
                }
            };
            Point point = dictionary[sceneType];
            int num = this.ParseAdventureKeys(point.X, point.Y);
            if (num != -1)
            {
                this.AdventureKeys = num;
                this.ReportKeys(Objective.ADVENTURE);
            }
        }

        private void UpdateArenaKeys()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                ArenaStartPM.Key_0,
                ArenaStartPM.Key_1,
                ArenaStartPM.Key_2,
                ArenaStartPM.Key_3,
                ArenaStartPM.Key_4,
                ArenaStartPM.Key_5
            };
            int num = -1;
            for (int i = 0; i < 6; i++)
            {
                if (this.MatchMapping(array[i], 5))
                {
                    num = i;
                    break;
                }
            }
            if (num != -1)
            {
                if (num < 5)
                {
                    Bitmap image = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, ArenaStartPM.R_Time);
                    using (Page page = this.Tesseractor.Engine.Process(image, null))
                    {
                        string text = page.GetText();
                        Utility.FilterAscii(text);
#if DEBUG
                        Console.WriteLine("Arena R_Time = " + text.Trim());
#endif
                        if (text.Length >= 2)
                        {
                            string s = text.Substring(0, 2);
                            string s2 = text.Substring(3, 2);
                            int minutes;
                            int.TryParse(s, out minutes);
                            int seconds;
                            int.TryParse(s2, out seconds);
                            TimeSpan arenaKeyTime = new TimeSpan(0, minutes, seconds);
                            this.ArenaKeyTime = arenaKeyTime;
                        }
                        else
                        {
                            this.ArenaKeyTime = TimeSpan.MaxValue;
                        }
                        goto IL_164;
                    }
                }
                this.ArenaKeyTime = TimeSpan.MaxValue;
            IL_164:
                this.ArenaKeys = num;
                this.ReportKeys(Objective.ARENA);
            }
        }

        private void UpdateGold(SceneType sceneType)
        {
            Dictionary<SceneType, Point> dictionary = new Dictionary<SceneType, Point>
            {
                {
                    SceneType.LOBBY,
                    new Point(LobbyPM.GOLD_OFFSET_X, LobbyPM.GOLD_OFFSET_Y)
                },
                {
                    SceneType.INBOX,
                    new Point(InboxPM.GOLD_OFFSET_X, InboxPM.GOLD_OFFSET_Y)
                },
                {
                    SceneType.HEROES,
                    new Point(HeroesPM.GOLD_OFFSET_X, HeroesPM.GOLD_OFFSET_Y)
                },
                {
                    SceneType.SHOP,
                    new Point(ShopPM.GOLD_OFFSET_X, ShopPM.GOLD_OFFSET_Y)
                },
                {
                    SceneType.ADVENTURE_MODES,
                    new Point(AdventureModesPM.GOLD_OFFSET_X, AdventureModesPM.GOLD_OFFSET_Y)
                },
                {
                    SceneType.MAP_SELECT,
                    new Point(MapSelectPM.GOLD_OFFSET_X, MapSelectPM.GOLD_OFFSET_Y)
                },
                {
                    SceneType.ADVENTURE_START,
                    new Point(AdventureStartPM.GOLD_OFFSET_X, AdventureStartPM.GOLD_OFFSET_Y)
                },
                {
                    SceneType.BATTLE_MODES,
                    new Point(BattleModesPM.GOLD_OFFSET_X, BattleModesPM.GOLD_OFFSET_Y)
                },
                {
                    SceneType.FRIENDS,
                    new Point(FriendsPM.GOLD_OFFSET_X, FriendsPM.GOLD_OFFSET_Y)
                },
                {
                    SceneType.QUEST,
                    new Point(QuestPM.GOLD_OFFSET_X, QuestPM.GOLD_OFFSET_Y)
                },
                {
                    SceneType.SPECIAL_QUEST,
                    new Point(SpecialQuestPM.GOLD_OFFSET_X, SpecialQuestPM.GOLD_OFFSET_Y)
                }
            };
            Point point = dictionary[sceneType];
            int num = this.ParseGold(point.X, point.Y);
            if (num != -1)
            {
                this.GoldCount = num;
                this.ReportResources(ResourceType.GOLD);
            }
        }

        private void UpdateHangFingerprint()
        {
            if (this.PreviousFingerprint == null)
            {
                this.PreviousFingerprint = new int[50];
                this.CurrentFingerprint = new int[50];
            }
            this.CreateHangFingerprint(this.CurrentFingerprint);
            for (int i = 0; i < 50; i++)
            {
                if (this.PreviousFingerprint[i] != this.CurrentFingerprint[i])
                {
                    this.HangCounter = 0;
                }
            }
            this.CreateHangFingerprint(this.PreviousFingerprint);
        }

        private void UpdateHonor(SceneType sceneType)
        {
            Dictionary<SceneType, Point> dictionary = new Dictionary<SceneType, Point>
            {
                {
                    SceneType.LOBBY,
                    new Point(LobbyPM.HONOR_OFFSET_X, LobbyPM.HONOR_OFFSET_Y)
                },
                {
                    SceneType.INBOX,
                    new Point(InboxPM.HONOR_OFFSET_X, InboxPM.HONOR_OFFSET_Y)
                },
                {
                    SceneType.SHOP,
                    new Point(ShopPM.HONOR_OFFSET_X, ShopPM.HONOR_OFFSET_Y)
                },
                {
                    SceneType.BATTLE_MODES,
                    new Point(BattleModesPM.HONOR_OFFSET_X, BattleModesPM.HONOR_OFFSET_Y)
                },
                {
                    SceneType.ARENA_READY,
                    new Point(ArenaReadyPM.HONOR_OFFSET_X, ArenaReadyPM.HONOR_OFFSET_Y)
                },
                {
                    SceneType.ARENA_START,
                    new Point(ArenaStartPM.HONOR_OFFSET_X, ArenaStartPM.HONOR_OFFSET_Y)
                },
                {
                    SceneType.FRIENDS,
                    new Point(FriendsPM.HONOR_OFFSET_X, FriendsPM.HONOR_OFFSET_Y)
                },
                {
                    SceneType.QUEST,
                    new Point(QuestPM.HONOR_OFFSET_X, QuestPM.HONOR_OFFSET_Y)
                },
                {
                    SceneType.SPECIAL_QUEST,
                    new Point(SpecialQuestPM.HONOR_OFFSET_X, SpecialQuestPM.HONOR_OFFSET_Y)
                }
            };
            Point point = dictionary[sceneType];
            int num = this.ParseHonor(point.X, point.Y);
            if (num != -1)
            {
                this.HonorCount = num;
                this.ReportResources(ResourceType.HONOR);
            }
        }

        private void UpdateRuby(SceneType sceneType)
        {
            Dictionary<SceneType, Point> dictionary = new Dictionary<SceneType, Point>
            {
                {
                    SceneType.LOBBY,
                    new Point(LobbyPM.RUBY_OFFSET_X, LobbyPM.RUBY_OFFSET_Y)
                },
                {
                    SceneType.INBOX,
                    new Point(InboxPM.RUBY_OFFSET_X, InboxPM.RUBY_OFFSET_Y)
                },
                {
                    SceneType.HEROES,
                    new Point(HeroesPM.RUBY_OFFSET_X, HeroesPM.RUBY_OFFSET_Y)
                },
                {
                    SceneType.SHOP,
                    new Point(ShopPM.RUBY_OFFSET_X, ShopPM.RUBY_OFFSET_Y)
                },
                {
                    SceneType.ADVENTURE_MODES,
                    new Point(AdventureModesPM.RUBY_OFFSET_X, AdventureModesPM.RUBY_OFFSET_Y)
                },
                {
                    SceneType.MAP_SELECT,
                    new Point(MapSelectPM.RUBY_OFFSET_X, MapSelectPM.RUBY_OFFSET_Y)
                },
                {
                    SceneType.BATTLE_MODES,
                    new Point(BattleModesPM.RUBY_OFFSET_X, BattleModesPM.RUBY_OFFSET_Y)
                },
                {
                    SceneType.ARENA_READY,
                    new Point(ArenaReadyPM.RUBY_OFFSET_X, ArenaReadyPM.RUBY_OFFSET_Y)
                },
                {
                    SceneType.ARENA_START,
                    new Point(ArenaStartPM.RUBY_OFFSET_X, ArenaStartPM.RUBY_OFFSET_Y)
                },
                {
                    SceneType.QUEST,
                    new Point(QuestPM.RUBY_OFFSET_X, QuestPM.RUBY_OFFSET_Y)
                },
                {
                    SceneType.SPECIAL_QUEST,
                    new Point(SpecialQuestPM.RUBY_OFFSET_X, SpecialQuestPM.RUBY_OFFSET_Y)
                }
            };
            Point point = dictionary[sceneType];
            int num = this.ParseRuby(point.X, point.Y);
            if (num != -1)
            {
                this.RubyCount = num;
                this.ReportResources(ResourceType.RUBY);
            }
        }

        private void UpdateTopaz(SceneType sceneType)
        {
            Dictionary<SceneType, Point> dictionary = new Dictionary<SceneType, Point>
            {
                {
                    SceneType.LOBBY,
                    new Point(LobbyPM.TOPAZ_OFFSET_X, LobbyPM.TOPAZ_OFFSET_Y)
                },
                {
                    SceneType.SHOP,
                    new Point(ShopPM.TOPAZ_OFFSET_X, ShopPM.TOPAZ_OFFSET_Y)
                }
            };
            Point point = dictionary[sceneType];
            int num = this.ParseTopaz(point.X, point.Y);
            if (num != -1)
            {
                this.TopazCount = num;
                this.ReportResources(ResourceType.TOPAZ);
            }
        }

        private void UpdateTowerKeys()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                TowerStartPM.Key_0,
                TowerStartPM.Key_1,
                TowerStartPM.Key_2,
                TowerStartPM.Key_3,
                TowerStartPM.Key_4
            };
            int num = 5;
            for (int i = 0; i < array.Length; i++)
            {
                if (this.MatchMapping(array[i], 4))
                {
                    num = i;
                    break;
                }
            }

            if (num < 5)
            {
                using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, TowerStartPM.R_Time))
                {
                    using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                    {
                        string text = page.GetText();
                        Utility.FilterAscii(text);
                        if (text.Length >= 2)
                        {
                            string s = text.Substring(0, 2);
                            string s2 = text.Substring(3, 2);
                            int minutes;
                            int.TryParse(s, out minutes);
                            int seconds;
                            int.TryParse(s2, out seconds);
                            TimeSpan towerKeyTime = new TimeSpan(0, minutes, seconds);
                            this.TowerKeyTime = towerKeyTime;
                        }
                        else
                        {
                            this.TowerKeyTime = TimeSpan.MaxValue;
                        }
                    }
                }
            }
            this.TowerKeys = num;
            this.ReportKeys(Objective.GOLD_CHAMBER);
        }

        private void UseSkills(bool towerFight = false)
        {
            if (this.CurrentSkillSet == null || this.CurrentSkillSet.Length == 0)  
            {
                return;
            }
            PixelMapping[] array = this.CreateSkillMappings();          
            if (!this.LoopSkill && this.CurrentSkillSet.Length <= 3)    
            {
                int[] currentSkillSet = this.CurrentSkillSet;           
                for (int i = 0; i < currentSkillSet.Length; i++)        
                {
                    int num = currentSkillSet[i];                          
                    this.WeightedClick(array[num], 1.0, 1.0, 1, 0, "left"); 
                }
                this.CurrentSkillSet = null;
                return;
            }
            PixelMapping[][] array2 = this.CreateQueueMappingSet(towerFight);   
            int num2 = this.CurrentSkillSet[this.CurrentSkill];                 
            PixelMapping[] array3 = array2[num2];                               
            bool flag = false;                                                  
            if (this.PressedSkill < this.CurrentSkill)                          
            {
                this.WeightedClick(array[num2], 1.0, 1.0, 1, 0, "left");        
                SevenKnightsCore.Sleep(500);                                    
                this.CaptureFrame();                                            
                if (this.MatchMapping(array3[0], 4) && this.MatchMapping(array3[1], 4))   
                {
                    this.PressedSkill = this.CurrentSkill;                                  
                }
                else                                                                       
                {
                    flag = true;                                                            
                }
            }
            else if (this.PressedSkill == this.CurrentSkill)                                
            {
                if (!this.MatchMapping(array3[0], 4) && !this.MatchMapping(array3[1], 4))   
                {
                    flag = true;                                                            
                }
            }
            else if (this.LoopSkill)                                                        
            {
                this.PressedSkill = -1;                                                     
            }
            if (flag)                                                                       
            {
                this.CurrentSkill = (this.CurrentSkill + 1) % this.CurrentSkillSet.Length;  
                if (this.LoopSkill && this.CurrentSkill == 0)                               
                {
                    this.PressedSkill = -1;                                                 
                }
            }
        }

        private void WeightedClick(PixelMapping mapping, double scale = 1.0, double density = 1.0, int numClicks = 1, int delay = 0, string button = "left")
        {
            this.BlueStacks.MainWindowAS.Click(mapping.X, mapping.Y, numClicks, delay, button);
        }

        private void SendTelegram(string chatid, string text)
        {
            if (this.AIProfiles.ST_EnableTelegram == true)
            {
                try
                {
                    bot.sendMessage.send(chatid, text);
                }
                catch (Exception ex)
                {
                    this.Log("Send Telegram Failed! : " + ex);
                }
            }
        }

        #endregion Private Methods
    }
}