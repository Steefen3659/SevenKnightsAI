using RestSharp;
using SevenKnightsAI.Classes;
using SevenKnightsAI.Classes.Extensions;
using SevenKnightsAI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Media;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Tesseract;
using Telegram;
using ScreenShotDemo;

namespace SevenKnightsAI
{
    public partial class MainForm : Form
    {
        #region Public Fields

        private readonly CheckBox[][] _formationCheckBoxes = new CheckBox[2][];

        private readonly Point[][] _formationPositions = new Point[][]
        {
            new Point[]
            {
                new Point(46, 24),
                new Point(46, 44),
                new Point(25, 13),
                new Point(25, 33),
                new Point(25, 53)
            },
            new Point[]
            {
                new Point(46, 13),
                new Point(46, 33),
                new Point(46, 53),
                new Point(25, 24),
                new Point(25, 44)
            },
            new Point[]
            {
                new Point(46, 33),
                new Point(25, 7),
                new Point(25, 24),
                new Point(25, 41),
                new Point(25, 58)
            },
            new Point[]
            {
                new Point(46, 7),
                new Point(46, 24),
                new Point(46, 41),
                new Point(46, 58),
                new Point(25, 33)
            }
        };

        private readonly List<Button>[] _skillButtons = new List<Button>[10];

        private readonly Color COLOR_SEQUENCE_ERROR = Color.FromArgb(255, 127, 123);

        private readonly Color COLOR_SEQUENCE_OK = Color.FromArgb(178, 209, 255);

        private readonly Color COLOR_SKILL_LOOP = Color.FromArgb(94, 170, 255);

        private SevenKnightsCore AI;

        private AIProfiles AIProfiles;

        private SoundPlayer AlertSound;

        private bool LG_autoScroll = true;

        private bool loaded;

        private bool started;

        private SynchronizationContext SynchronizationContext;

        private BackgroundWorker Worker;

        private BackgroundWorker Worker2 = new BackgroundWorker();

        private DateTime StartTime;

        private Stopwatch timer1;

        #endregion Private Fields

        #region Public Properties

        public static MainForm Instance
        {
            get;

            private set;
        }

        public AISettings AISettings
        {
            get
            {
                return this.AIProfiles.CurrentProfile;
            }
        }

        public bool IsElevated
        {
            get
            {
                return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        #endregion Public Properties

        #region Public Constructors

        public MainForm()
        {
            this.InitializeComponent();
            this.Init();
            this.ReloadTabs(true);
            if (!this.IsElevated)
            {
                this.adminToolStripLabel.Visible = false;
                MessageBox.Show("No admin permissions. Bot might not function as expected!",
                "No Admin Permissions",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning // for Warning  
               );
                this.AppendWarning("No admin permissions. Bot might not function as expected!");
            }
            //BackgroudWorker for Telegram
        }

        #endregion Public Constructors

        #region Public Methods

        public void InvokeReloadTabs(bool refreshSettings)
        {
            base.Invoke(new MethodInvoker(delegate
            {
                this.ReloadTabs(refreshSettings);
            }));
        }

        #endregion Public Methods

        #region Private Methods

        private void AD_continuousCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_Continuous = checkBox.Checked;
        }

        private void AD_difficultyComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.AISettings.AD_Difficulty = comboBox.SelectedValue as Difficulty? ?? Difficulty.None;
        }

        private void AD_difficultyComboBox2nd_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.AISettings.AD_Difficulty2nd = comboBox.SelectedValue as Difficulty? ?? Difficulty.None;
        }

        private void AD_elementHeroesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_ElementHeroesOnly = checkBox.Checked;
        }

        private void AD_manageHeroHelpLabel_Click(object sender, EventArgs e)
        {
            Point location = this.AD_formationPanel.Parent.PointToScreen(this.AD_formationPanel.Location);
            location.X += 10;
            location.Y += 10;
            Help.ShowPopup(this.AD_formationPanel, "Choose the positions to manage when hero reached level 30", location);
        }

        private void AD_PopulateStage(int stages)
        {
            int selectedIndex = this.AD_stageComboBox.SelectedIndex;
            this.AD_stageComboBox.Items.Clear();
            for (int i = 0; i < stages; i++)
            {
                string item = (i + 1).ToString();
                this.AD_stageComboBox.Items.Add(item);
            }
            int num = this.AD_stageComboBox.Items.Count - 1;
            if (selectedIndex > num)
            {
                this.AD_stageComboBox.SelectedIndex = num;
                return;
            }
        }

        private void AD_PopulateDifficulty(params Difficulty[] enabledDifficulties)
        {
            Dictionary<Difficulty, string> items = new Dictionary<Difficulty, string>();

            List<Difficulty> difficulties = new List<Difficulty>(enabledDifficulties);
            if (difficulties.Contains(Difficulty.None))
                items.Add(Difficulty.None, "---");
            if (difficulties.Contains(Difficulty.Easy))
                items.Add(Difficulty.Easy, Difficulty.Easy.ToString());
            if (difficulties.Contains(Difficulty.Normal))
                items.Add(Difficulty.Normal, Difficulty.Normal.ToString());
            if (difficulties.Contains(Difficulty.Hard))
                items.Add(Difficulty.Hard, Difficulty.Hard.ToString());

            Difficulty selectedDifficulty = this.AD_difficultyComboBox.SelectedValue as Difficulty? ?? Difficulty.None;
            if (!difficulties.Contains(selectedDifficulty))
                selectedDifficulty = Difficulty.None;

            this.AD_difficultyComboBox.SelectedValueChanged -= this.AD_difficultyComboBox_SelectedValueChanged;
            this.AD_difficultyComboBox.DisplayMember = "Value";
            this.AD_difficultyComboBox.ValueMember = "Key";
            this.AD_difficultyComboBox.DataSource = new BindingSource(items, null);
            this.AD_difficultyComboBox.SelectedValueChanged += this.AD_difficultyComboBox_SelectedValueChanged;

            this.AD_difficultyComboBox.SelectedValue = selectedDifficulty;
        }

        private void AD_PopulateDifficulty2nd(params Difficulty[] enabledDifficulties)
        {
            Dictionary<Difficulty, string> items = new Dictionary<Difficulty, string>();

            List<Difficulty> difficulties = new List<Difficulty>(enabledDifficulties);
            if (difficulties.Contains(Difficulty.None))
                items.Add(Difficulty.None, "---");
            if (difficulties.Contains(Difficulty.Easy))
                items.Add(Difficulty.Easy, Difficulty.Easy.ToString());
            if (difficulties.Contains(Difficulty.Normal))
                items.Add(Difficulty.Normal, Difficulty.Normal.ToString());
            if (difficulties.Contains(Difficulty.Hard))
                items.Add(Difficulty.Hard, Difficulty.Hard.ToString());

            Difficulty selectedDifficulty = this.AD_difficultyComboBox2nd.SelectedValue as Difficulty? ?? Difficulty.None;
            if (!difficulties.Contains(selectedDifficulty))
                selectedDifficulty = Difficulty.None;

            this.AD_difficultyComboBox2nd.SelectedValueChanged -= this.AD_difficultyComboBox2nd_SelectedValueChanged;
            this.AD_difficultyComboBox2nd.DisplayMember = "Value";
            this.AD_difficultyComboBox2nd.ValueMember = "Key";
            this.AD_difficultyComboBox2nd.DataSource = new BindingSource(items, null);
            this.AD_difficultyComboBox2nd.SelectedValueChanged += this.AD_difficultyComboBox2nd_SelectedValueChanged;

            this.AD_difficultyComboBox2nd.SelectedValue = selectedDifficulty;
        }

        private void AD_posCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            CheckBox[] array = this._formationCheckBoxes[0];
            for (int i = 0; i < array.Length; i++)
            {
                CheckBox checkBox = array[i];
                if (checkBox.Checked)
                {
                    list.Add((int)Convert.ToInt16(checkBox.Tag));
                }
            }
            this.AISettings.AD_HeroManagePositions = list.ToArray();
        }

        private void AD_sequenceButton_Click(object sender, EventArgs e)
        {
            this.AD_ShowSequencerForm();
        }

        private void AD_ShowSequencerForm()
        {
            StageSequencerForm stageSequencerForm = new StageSequencerForm(this.AISettings, this.started);
            stageSequencerForm.ShowDialog(this);
            this.AD_UpdateSequenceButton();
        }

        private void AD_stageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.AISettings.AD_Stage = comboBox.SelectedIndex;
        }

        private void AD_StopOnFullHeroes_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_StopOnFullHeroes = checkBox.Checked;
        }

        private void AD_StopOnFullItems_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_StopOnFullItems = checkBox.Checked;
        }
        private void AD_StopOnDragon_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_StopOnDragonFull = checkBox.Checked;
        }

        private void AD_RubyBooster_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_RubyBooster = checkBox.Checked;
            if (this.AISettings.AD_RubyBooster)
            {
                label24.Text = " / 20";
            }
            else
            {
                label24.Text = " / 100";
            }
        }

        private void AD_StopOnLV30_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_StopOnLV30 = checkBox.Checked;
        }

        private void AD_UpdateSequenceButton()
        {
            if (!this.AD_sequenceButton.Enabled)
            {
                this.AD_sequenceButton.BackColor = Control.DefaultBackColor;
                return;
            }
            if (this.AISettings.AD_WorldSequence == null || this.AISettings.AD_WorldSequence.Length <= 0)
            {
                this.AD_sequenceButton.BackColor = this.COLOR_SEQUENCE_ERROR;
                return;
            }
            this.AD_sequenceButton.BackColor = this.COLOR_SEQUENCE_OK;
        }

        private void AD_worldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.AD_stageComboBox.Enabled = (comboBox.SelectedIndex != 0 && comboBox.SelectedIndex != 1);
            this.AD_sequenceButton.Enabled = (comboBox.SelectedIndex == 1);
            this.AISettings.AD_World = (World)comboBox.SelectedIndex;
            this.AD_UpdateSequenceButton();
            if (this.AISettings.AD_World == World.None || this.AISettings.AD_World == World.Sequencer || this.AISettings.AD_World == World.MoonlitIsle)
            {
                this.AD_PopulateStage(20);
            }
            else if (this.AISettings.AD_World == World.WesternEmpire)
            {
                this.AD_PopulateStage(15);
            }
            else
            {
                this.AD_PopulateStage(10);
            }
            this.AD_PopulateDifficulty2nd(Difficulty.None, Difficulty.Easy, Difficulty.Normal);
            this.AD_PopulateDifficulty(Difficulty.None, Difficulty.Easy, Difficulty.Normal, Difficulty.Hard);
            if (this.loaded && this.AISettings.AD_World == World.Sequencer)
            {
                this.AD_ShowSequencerForm();
            }
        }

        private void aiButton_Click(object sender, EventArgs e)
        {
            if (this.AIProfiles.TMP_Paused)
            {
                this.ResumeAI();
                return;
            }
            if (!this.started)
            {
                if (this.ST_TelegramEnableCheckBox.Checked && this.ST_TelegramChatIDTextBox.Text == "")
                {
                    MessageBox.Show("Error : Telegram ChatID empty. Uncheck Enable Telegram Checkbox if you not want use telegram");
                }
                else
                {
                    this.StartAI();
                    return;
                }
            }
            this.StopAI();
            return;
        }

        private void aiPause_Click(object sender, EventArgs e)
        {
            this.PauseAI();
            this.botstatusLabel.Text = "Bot Paused";
            this.botstatusLabel.ForeColor = Color.Orange;
        }

        private void AppendLog(string message)
        {
            this.AppendLog(message, Color.Black);
        }

        private void AppendLog(string message, Color color)
        {
            RichTextBox lG_logTextBox = this.LG_logTextBox;
            RichTextBox logsBox = this.logsBox;
            string text = DateTime.Now.ToString("[hh:mm:ss tt]  ", CultureInfo.InvariantCulture);
            //ubah datetime nya kebentuk UTC
            lG_logTextBox.AppendText(text, Color.Black);
            lG_logTextBox.AppendText(message, color);
            lG_logTextBox.AppendText(Environment.NewLine);
            logsBox.AppendText(text, Color.Black);
            logsBox.AppendText(message, color);
            logsBox.AppendText(Environment.NewLine);

        }

        private void AppendWarning(string message)
        {
            this.AppendLog("WARNING: " + message, Color.Tan);
        }

        private void AR_useRubyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.AR_UseRuby = @checked;
        }

        private void AR_useRubyNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int aR_UseRubyAmount = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.AR_UseRubyAmount = aR_UseRubyAmount;
        }

        private void BackgroundWorkerOnCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.started = false;
            this.aiButton.Text = "Start Bot";
            this.statusToolStripLabel.Text = "Status: Bot Stopped";
            this.botstatusLabel.Text = "Bot Stopped";
            this.botstatusLabel.ForeColor = Color.Red;
            this.ST_toggleBlueStacksButton.Enabled = false;
            try
            {
                Exception arg_39_0 = e.Error;
            }
            finally
            {
                this.Worker.Dispose();
            }
        }

        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressArgs progressArgs = e.UserState as ProgressArgs;
            if (progressArgs == null)
            {
                return;
            }
            Label label = null;
            switch (progressArgs.Type)
            {
                case ProgressType.OBJECTIVE:
                    this.statusToolStripLabel.Text = string.Format("Status: {0}", progressArgs.Message.ToString());
                    this.UpdateCurrentProfileStatus();
                    this.AppendLog("Changing objective to: " + progressArgs.Message.ToString(), Color.OrangeRed);
                    if (progressArgs.Message.ToString() == "Adventure")
                    {
                        groupBox7.ForeColor = Color.Black;
                        groupBox8.ForeColor = Color.Black;
                        groupBox9.ForeColor = Color.Green;
                    }else if(progressArgs.Message.ToString() == "Gold Chamber")
                    {
                        groupBox7.ForeColor = Color.Green;
                        groupBox8.ForeColor = Color.Black;
                        groupBox9.ForeColor = Color.Black;
                    }else if(progressArgs.Message.ToString() == "Arena")
                    {
                        groupBox7.ForeColor = Color.Black;
                        groupBox8.ForeColor = Color.Green;
                        groupBox9.ForeColor = Color.Black;
                    }
                    else
                    {
                        groupBox7.ForeColor = Color.Black;
                        groupBox8.ForeColor = Color.Black;
                        groupBox9.ForeColor = Color.Black;
                    }
                    return;

                case ProgressType.EVENT:
                    this.AppendLog(progressArgs.Message.ToString(), progressArgs.Color);
                    this.UpdateCurrentProfileStatus();
                    return;

                case ProgressType.ERROR:
                    this.AppendLog("ERROR: " + progressArgs.Message, Color.Firebrick);
                    timer1.Stop();
                    return;

                case ProgressType.WARNING:
                    this.AppendWarning(progressArgs.Message.ToString());
                    return;

                case ProgressType.COUNT:
                    {
                        Dictionary<string, object> dictionary = progressArgs.Message as Dictionary<string, object>;
                        Objective objective = (Objective)dictionary["objective"];
                        string arg = Utility.ToTitleCase(objective.ToString().Replace("_", " "));
                        if (objective == Objective.ARENA)
                        {
                            int num = (int)dictionary["winCount"];
                            int num2 = (int)dictionary["loseCount"];
                            int numm2 = (int)dictionary["arenaRank"];
                            this.arenaWinLabel2.Text = num.ToString();
                            this.arenaLoseLabel2.Text = num2.ToString();
                            this.arenaCountLabel.Text = "x" + (num + num2).ToString();
                            this.rankArenaLabel.Text = numm2.ToString();
                            return;
                        }

                        int num3 = (int)dictionary["count"];
                        string text = string.Format("x" + num3);
                        string text2 = "";
                        string text3 = "";
                        string text4 = "";
                        string text5 = "";
                        if (objective == Objective.HERO_MANAGEMENT)
                        {
                            string t1 = "" + dictionary["hc"];
                            string t2 = "" + dictionary["hm"];
                            text = string.Format("{0}/{1}", t1, t2);
                        }
                        else if (objective == Objective.ADVENTURE)
                        {
                            text2 = "" + dictionary["hero"];
                            text3 = "" + dictionary["gold"];
                            text4 = "" + dictionary["item"];
                            text5 = "" + dictionary["h30"];
                        }
                        else if (objective == Objective.GOLD_CHAMBER)
                        {
                            text2 = "" + dictionary["hero"]; //goldminegoldamout
                            text3 = "" + dictionary["gold"];//goldmineentry
                        }
                        switch (objective)
                        {
                            case Objective.ADVENTURE:
                                this.adventureCountLabel.Text = text;
                                this.dragoncountlabel.Text = text2;
                                this.h30Label2.Text = text5;
                                return;

                            case Objective.GOLD_CHAMBER:
                                this.goldChamberCountLabel.Text = text;
                                this.goldmineCountLabel.Text = text3;
                                this.goldmineGoldAmountLabel2.Text = text2;
                                return;

                            case Objective.ARENA:
                                break;

                            case Objective.RAID:
                                this.raidCountLabel.Text = text;
                                return;

                            case Objective.HERO_MANAGEMENT:
                                this.HeroCountLabel.Text = text;
                                this.h30Label2.Text = num3.ToString();
                                return;

                            default:
                                return;
                        }
                        break;
                    }
                case ProgressType.KEY:
                    {
                        Dictionary<string, object> dictionary = progressArgs.Message as Dictionary<string, object>;
                        Objective objective = (Objective)dictionary["objective"];
                        int num4 = (int)dictionary["keys"];
                        string text2;
                        if (num4 == -1)
                        {
                            text2 = "-";
                        }
                        else if (dictionary.ContainsKey("time"))
                        {
                            string arg2 = ((TimeSpan)dictionary["time"]).ToString("mm':'ss");
                            text2 = string.Format("x{0} ({1})", num4, arg2);
                        }
                        else
                        {
                            text2 = string.Format("x{0}", num4);
                        }
                        switch (objective)
                        {
                            case Objective.ADVENTURE:
                                label = this.adventureKeysLabel2;
                                break;

                            case Objective.GOLD_CHAMBER:
                                label = this.towerKeysLabel2;
                                break;

                            case Objective.ARENA:
                                label = this.arenaKeysLabel2;
                                break;
                        }
                        if (text2 != null)
                        {
                            label.Text = text2;
                            return;
                        }
                        break;
                    }
                case ProgressType.RESOURCE:
                    {
                        Dictionary<string, object> dictionary = progressArgs.Message as Dictionary<string, object>;
                        ResourceType resourceType = (ResourceType)dictionary["resourceType"];
                        int num5 = (int)dictionary["value"];
                        string text2;
                        if (num5 == -1)
                        {
                            text2 = "-";
                        }
                        else
                        {
                            text2 = num5.ToString("N0");
                        }
                        switch (resourceType)
                        {
                            case ResourceType.GOLD:
                                //label = this.goldLabel;
                                label = this.goldLabel2;
                                break;

                            case ResourceType.RUBY:
                                //label = this.rubyLabel;
                                label = this.rubyLabel2;
                                break;

                            case ResourceType.HONOR:
                                //label = this.honorLabel;
                                label = this.honorLabel2;
                                break;

                            case ResourceType.TOPAZ:
                                //label = this.topazLabel;
                                label = this.topazLabel2;
                                break;
                        }
                        if (text2 != null)
                        {
                            label.Text = text2;
                        }
                        break;
                    }
                case ProgressType.CURSORPOS:
                    {
                        Point curpos = (Point)progressArgs.Message;
                        this.tsslCursorPosition.Text = string.Format("X: {0}, Y: {1}", curpos.X, curpos.Y);
                        break;
                    }
                case ProgressType.Alert:
                    {
                        if ((string)progressArgs.Message == "Heroes Full")
                        {
                            if (this.AISettings.AD_StopOnFullHeroes)
                            {
                                this.PauseAI();
                                this.AlertSound.PlayLooping();
                                AutoClosingMessageBox.Show("Heroes Full!", "Heroes Full!", 5000);
                                this.AlertSound.Stop();
                            }
                        }
                        else if ((string)progressArgs.Message == "Items Full")
                        {
                            if (this.AISettings.AD_StopOnFullItems)
                            {
                                this.PauseAI();
                                this.AlertSound.PlayLooping();
                                AutoClosingMessageBox.Show("Items Full!", "Items Full!", 5000);
                                this.AlertSound.Stop();
                            }
                        }
                        else if ((string)progressArgs.Message == "Bot Error2")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "Bot Stuck, bot will restart seven knights. You still need to ResumeBot");
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(2000);
                            this.AlertSound.Stop();
                            CaptureReport();
                            bot.SendPhoto.Show_sending_a_photo = true;
                            bot.SendPhoto.caption = String.Format("Last Screenshot {0}", DateTime.Now.ToString());
                            bot.SendPhoto.send(this.AIProfiles.ST_TelegramChatID, @"C://screen.jpg");
                            Thread.Sleep(1000);
                            Restart7k();
                            Thread.Sleep(2000);
                            aiButton.PerformClick(); // resume
                        }
                        else if ((string)progressArgs.Message == "Bot Error")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "Bot Stuck, bot automatically paused");
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(2000);
                            this.AlertSound.Stop();
                        }
                        else if ((string)progressArgs.Message == "Hero Level 30")
                        {
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(1500);
                            this.AlertSound.Stop();
                        }
                        else if ((string)progressArgs.Message == "No More Hero 30")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "Bot Paused because no more hero to replace");
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(1500);
                            this.AlertSound.Stop();
                        }
                        else if ((string)progressArgs.Message == "Max Level Up")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "Bot Paused because Hero Max Level Up 100/100");
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(1500);
                            this.AlertSound.Stop();
                        }
                        else if ((string)progressArgs.Message == "Dragon Found")
                        {
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            AutoClosingMessageBox.Show("Dragon Point 100!", "Dragon Point 100!", 5000);
                            Thread.Sleep(1500);
                            this.AlertSound.Stop();
                        }
                        break;
                    }
                default:
                    return;
            }
        }

        private void contactUsLinkLabel_TextChanged(object sender, EventArgs e)
        {
            LinkLabel linkLabel = sender as LinkLabel;
        }

        private void enableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.AD_Enable = @checked;
                    return;

                case 1:
                    this.AISettings.GC_Enable = @checked;
                    return;

                case 2:
                    this.AISettings.AR_Enable = @checked;
                    return;

                case 3:
                    this.AISettings.RD_Enable = @checked;
                    return;

                case 4:
                    this.AISettings.SP_Enable = @checked;
                    return;

                default:
                    return;
            }
        }

        private void EnablePause(bool value)
        {
            ContextMenu contextMenu = this.aiButton.ContextMenu;
            MenuItem menuItem = contextMenu.MenuItems[0];
            menuItem.Enabled = value;
            aiPause.Enabled = value;
        }

        private Control FindControlByTag(Control.ControlCollection controls, int tag)
        {
            foreach (Control control in controls)
            {
                if (control.Tag != null && Convert.ToInt32(control.Tag) == tag)
                {
                    return control;
                }
            }
            return null;
        }

        private void formationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int selectedIndex = comboBox.SelectedIndex;
            short tag = Convert.ToInt16(comboBox.Tag);
            this.SetFormation((int)tag, selectedIndex);
            if (selectedIndex != 0)
            {
                this.SetFormationPosition((int)tag, selectedIndex - 1);
                this.SetFormationVisibility((int)tag, true);
                return;
            }
            this.SetFormationVisibility((int)tag, false);
        }

        private void GB_WaitForKeys_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.GB_WaitForKeys = @checked;
        }

        private void Init()
        {
            MainForm.Instance = this;
            this.SynchronizationContext = SynchronizationContext.Current;
            HotTimeHelper.ImportHotTimeSchedule();
            try
            {
                this.AIProfiles = AIProfiles.Load();
            }
            catch (AISettingsException ex)
            {
                if (ex.ErrorCode != -1)
                {
                    MessageBox.Show("Error loading settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                this.AIProfiles = new AIProfiles(new AISettings());
            }
            this.AI = new SevenKnightsCore(this.AIProfiles);
        }

        private void InitAdventureTab()
        {
            this._formationCheckBoxes[0] = new CheckBox[]
            {
                this.AD_pos1CheckBox,
                this.AD_pos2CheckBox,
                this.AD_pos3CheckBox,
                this.AD_pos4CheckBox,
                this.AD_pos5CheckBox
            };
            for (int i = 0; i < 3; i++)
            {
                this._skillButtons[i] = new List<Button>();
            }
            this.AD_enableCheckBox.Checked = this.AISettings.AD_Enable;
            this.AD_EnHottime_Checkbox.Checked = this.AISettings.AD_HottimeEnable;
            this.AD_limitCheckBox.Checked = this.AISettings.AD_EnableLimit;
            this.AD_limitNumericBox.Value = this.AISettings.AD_Limit;
            this.AD_RubyBooster_Checkbox.Checked = this.AISettings.AD_RubyBooster;
            this.AD_worldComboBox.SelectedIndex = (int)this.AISettings.AD_World;
            this.AD_stageComboBox.SelectedIndex = this.AISettings.AD_Stage;
            this.AD_difficultyComboBox.SelectedValue = this.AISettings.AD_Difficulty;
            this.AD_difficultyComboBox2nd.SelectedValue = this.AISettings.AD_Difficulty2nd;
            this.AD_teamComboBox.SelectedIndex = (int)this.AISettings.AD_Team;
            this.AD_formationComboBox.SelectedIndex = (int)this.AISettings.AD_Formation;
            this.AD_continuousCheckBox.Checked = this.AISettings.AD_Continuous;
            this.AD_elementHeroesCheckBox.Checked = this.AISettings.AD_ElementHeroesOnly;
            this.AD_leaderComboBox.SelectedIndex = (int)this.AISettings.AD_Mastery;
            this.AD_StopOnFullHeroes_Checkbox.Checked = this.AISettings.AD_StopOnFullHeroes;
            this.AD_StopOnFullItems_Checkbox.Checked = this.AISettings.AD_StopOnFullItems;
            this.AD_StopOnDragon_Checkbox.Checked = this.AISettings.AD_StopOnDragonFull;
            this.AD_StopOnLV30_Checkbox.Checked = this.AISettings.AD_StopOnLV30;
            this.AD_CheckingHeroes_Checkbox.Checked = this.AISettings.AD_CheckingHeroes;
            this.AD_wave1LoopCheckBox.Checked = this.AISettings.AD_Wave1Loop;
            this.AD_wave2LoopCheckBox.Checked = this.AISettings.AD_Wave2Loop;
            this.AD_wave3LoopCheckBox.Checked = this.AISettings.AD_Wave3Loop;
            this.AD_UseFriendCheckBox.Checked = this.AISettings.AD_UseFriend;
            this.AD_bootmodeCheckBox.Checked = this.AISettings.AD_BootMode;
            if (this.AISettings.AD_HeroManagePositions != null)
            {
                int[] aD_HeroManagePositions = this.AISettings.AD_HeroManagePositions;
                foreach (Control control in AD_formationPanel.Controls)
                {
                    if (control.GetType() == typeof(CheckBox))
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }
                for (int j = 0; j < aD_HeroManagePositions.Length; j++)
                {
                    int num = aD_HeroManagePositions[j];
                    CheckBox checkBox = this._formationCheckBoxes[0][num];
                    checkBox.Checked = false;
                    checkBox.Checked = true;
                }
            }
            switch (this.AISettings.AD_SkillType)
            {
                case SkillType.Auto:
                    this.AD_autoSkillRadio.Checked = true;
                    break;

                case SkillType.Manual:
                    this.AD_manualSkillRadio.Checked = true;
                    break;

                case SkillType.Both:
                    this.AD_bothSkillRadio.Checked = true;
                    break;
            }
            switch (this.AISettings.AD_w2SkillType)
            {
                case SkillType.Auto:
                    this.AD_w2autoSkillRadio.Checked = true;
                    break;

                case SkillType.Manual:
                    this.AD_w2manualSkillRadio.Checked = true;
                    break;

                case SkillType.Both:
                    this.AD_w2bothSkillRadio.Checked = true;
                    break;
            }
            switch (this.AISettings.AD_w3SkillType)
            {
                case SkillType.Auto:
                    this.AD_w3autoSkillRadio.Checked = true;
                    break;

                case SkillType.Manual:
                    this.AD_w3manualSkillRadio.Checked = true;
                    break;

                case SkillType.Both:
                    this.AD_w3bothSkillRadio.Checked = true;
                    break;
            }
            Panel[] wavePanels = new Panel[]
            {
                this.AD_wave1Panel,
                this.AD_wave2Panel,
                this.AD_wave3Panel
            };
            int[][] waveSkill = new int[][]
            {
                this.AISettings.AD_Wave1Skills,
                this.AISettings.AD_Wave2Skills,
                this.AISettings.AD_Wave3Skills
            };
            this.LoadWaveSkills(wavePanels, waveSkill, 0);
        }

        private void InitSPdungeonTab()
        {
            for (int i = 7; i < 10; i++)
            {
                this._skillButtons[i] = new List<Button>();
            }
            this.checkBox3.Checked = this.AISettings.SP_Enable;
            this.SP_wave1LoopCheckBox.Checked = this.AISettings.SP_Wave1Loop;
            this.SP_wave2LoopCheckBox.Checked = this.AISettings.SP_Wave2Loop;
            this.SP_wave3LoopCheckBox.Checked = this.AISettings.SP_Wave3Loop;
            this.SP_evanNorRadioButton.Checked = this.AISettings.SP_EvanNormal;
            this.SP_evanHardRadioButton.Checked = this.AISettings.SP_EvanHard;
            this.SP_evanLimitNumericBox.Value = this.AISettings.SP_EvanLimit;
            this.SP_evanCheckBox.Checked = this.AISettings.SP_EvanEnable;
            switch (this.AISettings.SP_SkillType)
            {
                case SkillType.Auto:
                    this.SP_autoSkillRadio.Checked = true;
                    break;

                case SkillType.Manual:
                    this.SP_manualSkillRadio.Checked = true;
                    break;

                case SkillType.Both:
                    this.SP_bothSkillRadio.Checked = true;
                    break;
            }
            switch (this.AISettings.SP_w2SkillType)
            {
                case SkillType.Auto:
                    this.SP_w2autoSkillRadio.Checked = true;
                    break;

                case SkillType.Manual:
                    this.SP_w2manualSkillRadio.Checked = true;
                    break;

                case SkillType.Both:
                    this.SP_w2bothSkillRadio.Checked = true;
                    break;
            }
            switch (this.AISettings.SP_w3SkillType)
            {
                case SkillType.Auto:
                    this.SP_w3autoSkillRadio.Checked = true;
                    break;

                case SkillType.Manual:
                    this.SP_w3manualSkillRadio.Checked = true;
                    break;

                case SkillType.Both:
                    this.SP_w3bothSkillRadio.Checked = true;
                    break;
            }
            Panel[] wavePanels = new Panel[]
            {
                this.SP_wave1Panel,
                this.SP_wave2Panel,
                this.SP_wave3Panel
            };
            int[][] waveSkill = new int[][]
            {
                this.AISettings.SP_Wave1Skills,
                this.AISettings.SP_Wave2Skills,
                this.AISettings.SP_Wave3Skills
            };
            this.LoadWaveSkills(wavePanels, waveSkill, 7);
        }

        private void InitArenaTab()
        {
            this.AR_enableCheckBox.Checked = this.AISettings.AR_Enable;
            this.AR_limitCheckBox.Checked = this.AISettings.AR_EnableLimit;
            this.AR_limitNumericBox.Value = this.AISettings.AR_Limit;
            this.AR_useRubyCheckBox.Checked = this.AISettings.AR_UseRuby;
            this.AR_useRubyNumericBox.Value = this.AISettings.AR_UseRubyAmount;
            this.AR_leaderComboBox.SelectedIndex = (int)this.AISettings.AR_Mastery;
            this.AR_stopArenaCheckBox.Checked = this.AISettings.AR_LimitArena;
            this.AR_stopArenaNumericBox.Value = this.AISettings.AR_LimitScore;
        }

        private void InitGlobalProfile()
        {
            this.GB_WaitForKeys.Checked = this.AISettings.GB_WaitForKeys;
        }

        private void InitGoldChamberTab()
        {
            this._formationCheckBoxes[1] = new CheckBox[]
            {
                this.GC_pos1CheckBox,
                this.GC_pos2CheckBox,
                this.GC_pos3CheckBox,
                this.GC_pos4CheckBox,
                this.GC_pos5CheckBox
            };
            for (int i = 3; i < 5; i++)
            {
                this._skillButtons[i] = new List<Button>();
            }
            this.GC_enableCheckBox.Checked = this.AISettings.GC_Enable;
            this.GC_limitCheckBox.Checked = this.AISettings.GC_EnableLimit;
            this.GC_limitNumericBox.Value = this.AISettings.GC_Limit;
            this.GC_teamComboBox.SelectedIndex = (int)this.AISettings.GC_Team;
            this.GC_formationComboBox.SelectedIndex = (int)this.AISettings.GC_Formation;
            this.GC_masteryComboBox.SelectedIndex = (int)this.AISettings.GC_Mastery;
            this.GC_UseFriendCheckBox.Checked = this.AISettings.GC_UseFriend;
            int[][] waveSkill = new int[][]
            {
                this.AISettings.GC_Wave1Skills,
                this.AISettings.GC_Wave2Skills
            };
        }

        private void InitLogsTab()
        { }

        private void InitRaidTab()
        {
            for (int i = 5; i < 7; i++)
            {
                this._skillButtons[i] = new List<Button>();
            }
            this.RD_enableCheckBox.Checked = this.AISettings.RD_Enable;
            this.RD_DragonLimitCheckBox.Checked = this.AISettings.RD_EnableDragonLimit;
            this.RD_leaderComboBox.SelectedIndex = (int)this.AISettings.RD_Mastery;
            this.RD_team1LoopCheckBox.Checked = this.AISettings.RD_Team1Loop;
            this.RD_team2LoopCheckBox.Checked = this.AISettings.RD_Team2Loop;
            this.RD_OwnerDragon.Checked = this.AISettings.RD_OwnerDragon;
            this.RD_LevelCheckBox.Checked = this.AISettings.RD_LevelCheckBox;
            this.RD_ReadNick.Checked = this.AISettings.RD_ReadNick;
            this.RD_DragonLV.Value = this.AISettings.RD_DragonLV;
            this.RD_RoundNumericUpDown.Value = this.AISettings.RD_DragonRound;
            this.RD_DragonHP.Value = this.AISettings.RD_DragonHP;
            this.RD_DragonHPLimit.Value = this.AISettings.RD_DragonHPLimit;
            this.RD_DragonLVLimit.Value = this.AISettings.RD_DragonLVLimit;
            this.RD_SummonLvl_CheckBox.SelectedIndex = this.AISettings.RD_SummonLV;
            this.AD_SummonAuto.Checked = this.AISettings.AD_SummonAuto;

            switch (this.AISettings.RD_SkillType)
            {
                case SkillType.Auto:
                    this.RD_autoSkillRadio.Checked = true;
                    break;

                case SkillType.Manual:
                    this.RD_manualSkillRadio.Checked = true;
                    break;

                case SkillType.Both:
                    this.RD_bothSkillRadio.Checked = true;
                    break;
            }
            Panel[] wavePanels = new Panel[]
            {
                this.RD_team1Panel,
                this.RD_team2Panel
            };
            int[][] waveSkill = new int[][]
            {
                this.AISettings.RD_Team1Skills,
                this.AISettings.RD_Team2Skills
            };
            this.LoadWaveSkills(wavePanels, waveSkill, 5);
        }

        private void InitResourcesTab()
        {
            this.RS_sellHeroesCheckBox.Checked = this.AISettings.RS_SellHeroes;
            this.RS_heroStarsComboBox.SelectedIndex = this.AISettings.RS_SellHeroStars - 1;
            this.RS_heroAmountNumericBox.Value = this.AISettings.RS_SellHeroAmount;
            this.RS_heroAllRadioButton.Checked = this.AISettings.RS_SellHeroAll;
            this.RS_heroAmountRadioButton.Checked = !this.AISettings.RS_SellHeroAll;
            this.RS_sellItemsCheckBox.Checked = this.AISettings.RS_SellItems;
            this.RS_itemStarsComboBox.SelectedIndex = this.AISettings.RS_SellItemStars - 1;
            this.RS_itemAmountNumericBox.Value = this.AISettings.RS_SellItemAmount;
            this.RS_itemAllRadioButton.Checked = this.AISettings.RS_SellItemAll;
            this.RS_itemAmountRadioButton.Checked = !this.AISettings.RS_SellItemAll;
            this.RS_inboxHonors.Checked = this.AISettings.RS_InboxHonors;
            this.RS_inboxMaterials.Checked = this.AISettings.RS_InboxKeys;
            this.RS_InboxKeys.Checked = this.AISettings.RS_InboxGold;
            this.RS_luckyBoxCheckBox.Checked = this.AISettings.RS_CollectLuckyBox;
            this.RS_luckyChestCheckBox.Checked = this.AISettings.RS_CollectLuckyChest;
            this.RS_specialQuestsDailyCheckBox.Checked = this.AISettings.RS_SpecialQuestsDaily;
            this.RS_specialQuestsWeeklyCheckBox.Checked = this.AISettings.RS_SpecialQuestsWeekly;
            this.RS_specialQuestsMonthlyCheckBox.Checked = this.AISettings.RS_SpecialQuestsMonthly;
            this.RS_questsBattleCheckBox.Checked = this.AISettings.RS_QuestsBattle;
            this.RS_questsHeroCheckBox.Checked = this.AISettings.RS_QuestsHero;
            this.RS_questsItemCheckBox.Checked = this.AISettings.RS_QuestsItem;
            this.RS_questsSocialCheckBox.Checked = this.AISettings.RS_QuestsSocial;
            this.RS_sendHonorsFacebook.Checked = this.AISettings.RS_SendHonorsFacebook;
            this.RS_sendHonorsInGame.Checked = this.AISettings.RS_SendHonorsInGame;
            this.RS_buyKeyHonorsCheckBox.Checked = this.AISettings.RS_BuyKeyHonors;
            this.RS_buyKeyHonorsComboBox.SelectedIndex = (int)this.AISettings.RS_BuyKeyHonorsType;
            this.RS_buyKeyHonorsNumericBox.Value = this.AISettings.RS_BuyKeyHonorsAmount;
            this.RS_buyKeyRubiesCheckBox.Checked = this.AISettings.RS_BuyKeyRubies;
            this.RS_buyKeyRubiesComboBox.SelectedIndex = (int)this.AISettings.RS_BuyKeyRubiesType;
            this.RS_buyKeyRubiesNumericBox.Value = this.AISettings.RS_BuyKeyRubiesAmount;
        }

        private void InitSettingsTab()
        {
            this.ST_RefreshProfiles();
            this.ST_delayTrackBar.Value = this.AIProfiles.ST_Delay;
            this.ST_reconnectInterruptCheckBox.Checked = this.AIProfiles.ST_ReconnectInterruptEnable;
            this.ST_reconnectNumericUpDown.Value = this.AIProfiles.ST_ReconnectInterruptInterval;
            this.ST_hotTimeProfileCheckBox.Checked = this.AIProfiles.ST_EnableHotTimeProfile;
            this.ST_AutoProfileCheckBox.Checked = this.AIProfiles.ST_EnableAutoProfile;
            this.ST_AutoShutdownCheckBox.Checked = this.AIProfiles.ST_EnableAutoShutdown;
            this.ST_TelegramEnableCheckBox.Checked = this.AIProfiles.ST_EnableTelegram;
            this.ST_forceActiveCheckBox.Checked = this.AIProfiles.ST_BlueStacksForceActive;
            this.ST_TelegramTokenTextBox.Text = this.AIProfiles.ST_TelegramToken;
            this.ST_TelegramChatIDTextBox.Text = this.AIProfiles.ST_TelegramChatID;
            this.ST_foregroundMode.Checked = this.AIProfiles.ST_ForegroundMode;
        }
        private void InitOtherTab()
        {
            this.AD_Pause100.Checked = this.AIProfiles.AD_Pause100;
            this.AD_NoHeroUp_Checkbox.Checked = this.AIProfiles.AD_NoHeroUp;
            this.EX_EnableCheckBox.Checked = this.AISettings.EX_Enable;
            this.EX_SendAgainCheckBox.Checked = this.AISettings.EX_Send;
        }

        private void LG_clearButton_Click(object sender, EventArgs e)
        {
            this.LG_logTextBox.Clear();
            this.LG_logTextBox.Refresh();
            this.logsBox.Clear();
            this.logsBox.Refresh();
        }

        private void LG_exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = string.Format("{0}.log", "sevenknights-".AppendTimeStamp());
            saveFileDialog.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = Application.StartupPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.Write(this.LG_logTextBox.Text);
                    streamWriter.Write(this.logsBox.Text);
                }
            }
        }

        private void LG_LogPixel_Click(object sender, EventArgs e)
        {
            this.LogPixel();
        }

        private void LG_logTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.LG_autoScroll)
            {
                this.LG_ScrollToEnd();
            }
        }

        private void LG_SaveScreen_Click(object sender, EventArgs e)
        {

            /*
             * Bitmap screen = this.AI.BlueStacks.CaptureFrame(!this.AIProfiles.ST_ForegroundMode);
            screen.Save("C:\\screen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "bmp";
            saveFileDialog.Filter = "Bitmap file (*.bmp)|*.bmp";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.SupportMultiDottedExtensions = false;
            saveFileDialog.Title = "Save Screen As";
            

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                screen.Save(saveFileDialog.FileName);
            }
            */
        }

        private void LG_scrollCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.LG_autoScroll = @checked;
            if (@checked)
            {
                this.LG_ScrollToEnd();
            }
        }

        private void LG_ScrollToEnd()
        {
            this.LG_logTextBox.SelectionStart = this.LG_logTextBox.Text.Length;
            this.LG_logTextBox.ScrollToCaret();
            this.logsBox.SelectionStart = this.logsBox.Text.Length;
            this.logsBox.ScrollToCaret();
        }

        private void limitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.AD_EnableLimit = @checked;
                    return;

                case 1:
                    this.AISettings.GC_EnableLimit = @checked;
                    return;

                case 2:
                    this.AISettings.AR_EnableLimit = @checked;
                    return;

                case 3:
                    //this.AISettings.RD_EnableLimit = @checked;
                    return;

                case 4:
                    this.AISettings.RD_EnableDragonLimit = @checked;
                    return;

                case 5:
                    this.AISettings.SP_EnableLimit = @checked;
                    return;

                default:
                    return;
            }
        }

        private void limitNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            short num = Convert.ToInt16(numericUpDown.Tag);
            int num2 = Convert.ToInt32(numericUpDown.Value);
            switch (num)
            {
                case 0:
                    this.AISettings.AD_Limit = num2;
                    return;

                case 1:
                    this.AISettings.GC_Limit = num2;
                    return;

                case 2:
                    this.AISettings.AR_Limit = num2;
                    return;

                case 3:
                    //this.AISettings.RD_Limit = num2;
                    return;

                case 4:
                    //this.AISettings.RD_DragonLimit = num2;
                    return;

                case 5:
                    this.AISettings.SP_Limit = num2;
                    return;
                case 6:
                    this.AISettings.AD_CurrH30 = num2;
                    return;
                default:
                    return;
            }
        }

        private void LoadWaveSkills(Panel[] wavePanels, int[][] waveSkill, int offset)
        {
            for (int i = 0; i < wavePanels.Length; i++)
            {
                foreach (Control c in wavePanels[i].Controls)
                {
                    if (c is Button && c.Tag != null)
                    {
                        ((Button)c).Text = "";
                    }
                }
                if (waveSkill[i] != null)
                {
                    int[] array = waveSkill[i];
                    for (int j = 0; j < array.Length; j++)
                    {
                        int tag = array[j];
                        Button item = this.FindControlByTag(wavePanels[i].Controls, tag) as Button;
                        this._skillButtons[i + offset].Add(item);
                    }
                    this.SetSkills(i + offset);
                }
            }
        }

        private void LogPixel()
        {
            if (this.Worker != null)
            {
                this.AIProfiles.TMP_LogPixel = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        { }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bot.token = this.AIProfiles.ST_TelegramToken;
            this.Worker2.DoWork += new DoWorkEventHandler(Test);
            this.Worker2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Worker2_RunWorkerCompleted);
            this.Worker2.ProgressChanged += new ProgressChangedEventHandler(this.Worker2_ProgressChanged);
            this.Worker2.WorkerReportsProgress = true;
            this.Worker2.WorkerSupportsCancellation = true;
            Worker2.RunWorkerAsync();
            timer1 = new Stopwatch();
            bot.CheckForIllegalCrossThreadCalls = false;
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem("Pause");
            contextMenu.MenuItems.Add(menuItem);
            this.aiButton.ContextMenu = contextMenu;
            menuItem.Enabled = false;
            menuItem.Click += delegate (object _sender, EventArgs _e)
            {
                this.PauseAI();
            };

            //Loading Sound file and preparing it to play if needed.
            this.AlertSound = new SoundPlayer(SevenKnightsAI.Properties.Resources.Alien_AlarmDrum_KevanGC_893953959);
            string build = "v" + this.ProductVersion + " - " + Assembly.GetExecutingAssembly().GetLinkerTime().ToShortDateString();
            this.tsslBuildInfo.Text = "Build: " + build;
            AppendLog("Loaded Build :  " + build);
            this.loaded = true;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        { }

        private void masteryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null)
            {
                return;
            }
            short num = Convert.ToInt16(comboBox.Tag);
            Mastery selectedIndex = (Mastery)comboBox.SelectedIndex;
            switch (num)
            {
                case 0:
                    this.AISettings.AD_Mastery = selectedIndex;
                    return;

                case 1:
                    this.AISettings.GC_Mastery = selectedIndex;
                    return;

                case 2:
                    this.AISettings.AR_Mastery = selectedIndex;
                    return;

                case 3:
                    this.AISettings.RD_Mastery = selectedIndex;
                    return;

                default:
                    return;
            }
        }

        private void PauseAI()
        {
            if (this.Worker != null)
            {
                this.AIProfiles.TMP_Paused = true;
                this.aiButton.Text = "&Resume AI";
                this.EnablePause(false);
                timer1.Stop();
            }

            this.tabControl1.SelectedTab = tabPage4;
        }

        private void ReloadTabs(bool refreshSettings)
        {
            this.InitAdventureTab();
            this.InitGlobalProfile();
            this.InitGoldChamberTab();
            this.InitArenaTab();
            this.InitRaidTab();
            this.InitSPdungeonTab();
            this.InitResourcesTab();
            this.InitLogsTab();
            this.InitOtherTab();
            if (refreshSettings)
            {
                this.InitSettingsTab();
            }
        }

        private void ResumeAI()
        {
            this.AIProfiles.TMP_Paused = false;
            this.AIProfiles.TMP_WaitingForKeys = false;
            this.tsslCursorPosition.Text = "";
            this.aiButton.Text = "Stop AI";
            this.botstatusLabel.Text = "Bot Running";
            this.botstatusLabel.ForeColor = Color.Green;

            this.tabControl1.SelectedTab = tabPage4;
            this.EnablePause(true);
            timer1.Start();
            
        }

        private void RS_buyKeysCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            if (num == 0)
            {
                this.AISettings.RS_BuyKeyHonors = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_BuyKeyRubies = @checked;
            }
        }

        private void RS_buyKeysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            short num = Convert.ToInt16(comboBox.Tag);
            int selectedIndex = comboBox.SelectedIndex;
            if (num == 0)
            {
                this.AISettings.RS_BuyKeyHonorsType = (BuyKeyHonorsType)selectedIndex;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_BuyKeyRubiesType = (BuyKeyRubiesType)selectedIndex;
            }
        }

        private void RS_buyKeysNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            short num = Convert.ToInt16(numericUpDown.Tag);
            int num2 = Convert.ToInt32(numericUpDown.Value);
            if (num == 0)
            {
                this.AISettings.RS_BuyKeyHonorsAmount = num2;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_BuyKeyRubiesAmount = num2;
            }
        }

        private void RS_collectGiftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.RS_CollectLuckyChest = @checked;
                    return;

                case 1:
                    this.AISettings.RS_CollectLuckyBox = @checked;
                    return;

                default:
                    return;
            }
        }

        private void RS_collectInboxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.RS_InboxHonors = @checked;
                    return;

                case 1:
                    this.AISettings.RS_InboxKeys = @checked;
                    return;

                case 2:
                    this.AISettings.RS_InboxGold = @checked;
                    return;

                case 3:
                    this.AISettings.RS_InboxRubies = @checked;
                    return;

                case 4:
                    this.AISettings.RS_InboxTickets = @checked;
                    return;

                default:
                    return;
            }
        }

        private void RS_collectQuestsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.RS_SpecialQuestsDaily = @checked;
                    return;

                case 1:
                    this.AISettings.RS_SpecialQuestsWeekly = @checked;
                    return;

                case 2:
                    this.AISettings.RS_SpecialQuestsMonthly = @checked;
                    return;

                case 3:
                    this.AISettings.RS_QuestsBattle = @checked;
                    return;

                case 4:
                    this.AISettings.RS_QuestsHero = @checked;
                    return;

                case 5:
                    this.AISettings.RS_QuestsItem = @checked;
                    return;

                case 6:
                    this.AISettings.RS_QuestsSocial = @checked;
                    return;

                default:
                    return;
            }
        }

        private void RS_sellAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            short num = Convert.ToInt16(radioButton.Tag);
            bool @checked = radioButton.Checked;
            if (num == 0)
            {
                this.RS_heroAmountNumericBox.Enabled = !@checked;
                this.AISettings.RS_SellHeroAll = @checked;
                return;
            }
            if (num == 1)
            {
                this.RS_itemAmountNumericBox.Enabled = !@checked;
                this.AISettings.RS_SellItemAll = @checked;
            }
        }

        private void RS_sellAmountNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            short num = Convert.ToInt16(numericUpDown.Tag);
            int num2 = Convert.ToInt32(numericUpDown.Value);
            if (num == 0)
            {
                this.AISettings.RS_SellHeroAmount = num2;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_SellItemAmount = num2;
            }
        }

        private void RS_sellCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            if (num == 0)
            {
                this.AISettings.RS_SellHeroes = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_SellItems = @checked;
            }
        }

        private void RS_sellStarsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            short num = Convert.ToInt16(comboBox.Tag);
            int num2 = comboBox.SelectedIndex + 1;
            if (num == 0)
            {
                this.AISettings.RS_SellHeroStars = num2;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_SellItemStars = num2;
            }
        }

        private void RS_sendHonorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            if (num == 0)
            {
                this.AISettings.RS_SendHonorsFacebook = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_SendHonorsInGame = @checked;
            }
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.AIProfiles.Save();
                MessageBox.Show("Settings has been saved!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot save settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void SetAutoSkill(int tag, int option)
        {
            SkillType skillType = SkillType.Both;
            if (option == 0)
            {
                skillType = SkillType.Auto;
            }
            else if (option == 1)
            {
                skillType = SkillType.Manual;
            }
            else if (option == 2)
            {
                skillType = SkillType.Both;
            }
            switch (tag)
            {
                case 0:
                    this.AISettings.AD_SkillType = skillType;
                    return;

                case 1:
                    this.AISettings.GC_SkillType = skillType;
                    return;

                case 2:
                    this.AISettings.RD_SkillType = skillType;
                    return;

                case 3:
                    this.AISettings.SP_SkillType = skillType;
                    return;

                default:
                    return;
            }
        }

        private void SetFormation(int tag, int index)
        {
            switch (tag)
            {
                case 0:
                    this.AISettings.AD_Formation = (Formation)index;
                    return;

                case 1:
                    this.AISettings.GC_Formation = (Formation)index;
                    return;

                default:
                    return;
            }
        }

        private void SetFormationPosition(int tag, int index)
        {
            Point[][] formationPositions = this._formationPositions;
            int num = 0;
            CheckBox[] array = this._formationCheckBoxes[tag];
            for (int i = 0; i < array.Length; i++)
            {
                CheckBox checkBox = array[i];
                checkBox.Location = formationPositions[index][num++];
            }
        }

        private void SetFormationVisibility(int tag, bool visible)
        {
            CheckBox[] array = this._formationCheckBoxes[tag];
            for (int i = 0; i < array.Length; i++)
            {
                CheckBox checkBox = array[i];
                checkBox.Visible = visible;
            }
        }

        private void SetSkills(int parentTag)
        {
            List<Button> list = this._skillButtons[parentTag];
            int[] array = new int[list.Count];
            int num = 0;
            foreach (Button current in list)
            {
                current.Text = (num + 1).ToString();
                array[num] = (int)Convert.ToInt16(current.Tag);
                num++;
            }
            switch (parentTag)
            {
                case 0:
                    this.AISettings.AD_Wave1Skills = array;
                    return;

                case 1:
                    this.AISettings.AD_Wave2Skills = array;
                    return;

                case 2:
                    this.AISettings.AD_Wave3Skills = array;
                    return;

                case 3:
                    this.AISettings.GC_Wave1Skills = array;
                    return;

                case 4:
                    this.AISettings.GC_Wave2Skills = array;
                    return;

                case 5:
                    this.AISettings.RD_Team1Skills = array;
                    return;

                case 6:
                    this.AISettings.RD_Team2Skills = array;
                    return;

                case 7:
                    this.AISettings.SP_Wave1Skills = array;
                    return;

                case 8:
                    this.AISettings.SP_Wave2Skills = array;
                    return;

                case 9:
                    this.AISettings.SP_Wave3Skills = array;
                    return;

                default:
                    return;
            }
        }

        private void skillButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            short num = Convert.ToInt16(button.Parent.Tag);
            List<Button> list = this._skillButtons[(int)num];
            if (list.Contains(button))
            {
                button.Text = string.Empty;
                list.Remove(button);
            }
            else
            {
                if (list.Count == 10)
                {
                    list[0].Text = string.Empty;
                    list.RemoveAt(0);
                }
                list.Add(button);
            }
            this.SetSkills((int)num);
        }

        private void skillLoopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Parent.Tag);
            bool @checked = checkBox.Checked;
            if (@checked)
            {
                checkBox.BackColor = this.COLOR_SKILL_LOOP;
            }
            else
            {
                checkBox.BackColor = Control.DefaultBackColor;
            }
            switch (num)
            {
                case 0:
                    this.AISettings.AD_Wave1Loop = @checked;
                    return;

                case 1:
                    this.AISettings.AD_Wave2Loop = @checked;
                    return;

                case 2:
                    this.AISettings.AD_Wave3Loop = @checked;
                    return;

                case 3:
                    this.AISettings.GC_Wave1Loop = @checked;
                    return;

                case 4:
                    this.AISettings.GC_Wave2Loop = @checked;
                    return;

                case 5:
                    this.AISettings.RD_Team1Loop = @checked;
                    return;

                case 6:
                    this.AISettings.RD_Team2Loop = @checked;
                    return;

                case 7:
                    this.AISettings.SP_Wave1Loop = @checked;
                    return;

                case 8:
                    this.AISettings.SP_Wave2Loop = @checked;
                    return;

                case 9:
                    this.AISettings.SP_Wave3Loop = @checked;
                    return;

                default:
                    return;
            }
        }

        private void skillTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            short option = Convert.ToInt16(radioButton.Tag);
            short tag = Convert.ToInt16(radioButton.Parent.Tag);
            this.SetAutoSkill((int)tag, (int)option);
        }

        private void ST_currentProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AIProfiles.ChangeProfile(profileComboBoxItem.Key);
            this.ReloadTabs(false);
        }

        private void ST_delayTrackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            int value = trackBar.Value;
            this.ST_delayValueLabel.Text = value.ToString() + " ms";
            this.AIProfiles.ST_Delay = value;
        }

        private void ST_forceActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_BlueStacksForceActive = @checked;
        }

        private void ST_foregroundMode_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.ST_ToggleBlueStacks(true, true);
            this.AIProfiles.ST_ForegroundMode = @checked;
        }

        private void ST_hotTimeProfileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_EnableHotTimeProfile = @checked;
        }

        private void ST_autoProfileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_EnableAutoProfile = @checked;
        }

        private void ST_AutoShutdownCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_EnableAutoShutdown = @checked;
            if (this.ST_AutoShutdownCheckBox.Checked == true)
            {
                this.AD_Pause100.Checked = false;
            }
        }

        private void ST_TelegramEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_EnableTelegram = @checked;
            if (checkBox.Checked)
            {
                ST_TelegramTokenTextBox.Enabled = true;
                ST_TelegramChatIDTextBox.Text = "";
                ST_TelegramTokenTextBox.Text = "";
            }
            else
            {
                ST_TelegramChatIDTextBox.Text = "";
                ST_TelegramTokenTextBox.Text = "";
                ST_TelegramTokenTextBox.Enabled = false;
            }
        }

        private void ST_hotTimeProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AIProfiles.ST_HotTimeProfile = profileComboBoxItem.Key;
        }

        private void ST_manageProfileButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@Environment.CurrentDirectory + "//profiles"))
            {
                saveSettingsButton.PerformClick();
            }
            CreateNewProfiles cnp = new CreateNewProfiles();
            cnp.Show();
        }

        private void ST_opacityTrackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            int value = trackBar.Value;
            base.Opacity = (double)value / (double)trackBar.Maximum;
        }

        private void ST_TelegramTokenTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;
            this.AIProfiles.ST_TelegramToken = text;
            bot.token = ST_TelegramTokenTextBox.Text;
        }

        private void ST_TelegramChatIDTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;
            this.AIProfiles.ST_TelegramChatID = text;
        }

        private void ST_reconnectInterruptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_ReconnectInterruptEnable = @checked;
        }

        private void ST_reconnectNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            decimal value = numericUpDown.Value;
            this.AIProfiles.ST_ReconnectInterruptInterval = (int)value;
        }

        private void ST_RefreshProfiles()
        {
            int num = 0;
            this.ST_currentProfileComboBox.Items.Clear();
            this.ST_hotTimeProfileComboBox.Items.Clear();
            this.ST_NoMoreProfileComboBox.Items.Clear();
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                ProfileComboBoxItem item = new ProfileComboBoxItem(current);
                this.ST_currentProfileComboBox.Items.Add(item);
                this.ST_hotTimeProfileComboBox.Items.Add(item);
                this.ST_NoMoreProfileComboBox.Items.Add(item);
                if (current.Key == this.AIProfiles.CurrentKey)
                {
                    this.ST_currentProfileComboBox.SelectedIndex = num;
                    if (string.IsNullOrEmpty(this.AIProfiles.ST_HotTimeProfile))
                    {
                        this.ST_hotTimeProfileComboBox.SelectedIndex = this.ST_currentProfileComboBox.SelectedIndex;
                    }
                }
                if (current.Key == this.AIProfiles.ST_HotTimeProfile && this.ST_hotTimeProfileComboBox.SelectedIndex == -1)
                {
                    this.ST_hotTimeProfileComboBox.SelectedIndex = num;
                }
                num++;
            }
            this.groupBox2.Text = "Current Profiles: "+ this.ST_currentProfileComboBox.Text;
        }

        private void ST_ToggleBlueStacks(bool force = false, bool show = true)
        {
            if (this.AI.BlueStacks == null || this.AI.BlueStacks.MainWindowAS == null || this.AI.BlueStacks.SideMenuAS == null)
            {
                return;
            }
            string arg;
            if (this.AI.BlueStacks.IsHidden || (force && show))
            {
                this.AI.BlueStacks.Show(true);
                arg = "Hide";
            }
            else
            {
                this.AI.BlueStacks.Hide(true);
                arg = "Show";
            }
            this.ST_toggleBlueStacksButton.Text = string.Format("{0} BlueStacks", arg);
        }

        private void ST_toggleBlueStacksButton_Click(object sender, EventArgs e)
        {
            this.ST_ToggleBlueStacks(false, true);
        }


        private void StartAI()
        {
            this.Worker = this.AI.Start(this.SynchronizationContext);
            this.Worker.ProgressChanged += new ProgressChangedEventHandler(this.BackgroundWorkerOnProgressChanged);
            this.Worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.BackgroundWorkerOnCompleted);
            this.started = true;
            this.aiButton.Text = "Stop AI";
            this.botstatusLabel.Text = "Bot Running";
            this.botstatusLabel.ForeColor = Color.Green;

            this.tabControl1.SelectedTab = tabPage4;
            this.EnablePause(true);
            this.button2.Enabled = true;
            this.ST_toggleBlueStacksButton.Enabled = true;
            timer1.Reset();
            timer1.Start();
            timer2.Start();

        }

        private string Restart7k()
        {
            string messages;

            if (!this.AI.BlueStacks.RestartGame(5))
            {
                messages = "Error Restart Seven Knights";
            }
            else
            {
                messages = "Restart Seven Knights Success";
            }
            return messages;
        }

        private void StopAI()
        {

            this.tabControl1.SelectedTab = tabPage4;
            if (this.Worker != null)
            {
                this.Worker.CancelAsync();
                this.EnablePause(false);
                this.button2.Enabled = false;
                this.profileToolStripLabel.Text = string.Empty;
                this.AIProfiles.TMP_Paused = false;
                this.AIProfiles.TMP_WaitingForKeys = false;
                if (this.AIProfiles.TMP_UsingHotTimeProfile)
                {
                    this.AIProfiles.ToggleHotTimeProfile();
                    for (int i = 0; i < 2; i++)
                    {
                        this.ReloadTabs(true);
                    }
                }
            }
            timer1.Stop();
            timer.Text = "00:00:00";
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null)
            {
                return;
            }
            short num = Convert.ToInt16(comboBox.Tag);
            Team selectedIndex = (Team)comboBox.SelectedIndex;
            switch (num)
            {
                case 0:
                    this.AISettings.AD_Team = selectedIndex;
                    return;

                case 1:
                    this.AISettings.GC_Team = selectedIndex;
                    return;

                default:
                    return;
            }
        }

        private void UpdateCurrentProfileStatus()
        {
            this.profileToolStripLabel.Text = string.Format("[Profile: {0}]", this.AIProfiles.CurrentProfileName);
        }

        private void AD_CheckingHeroes_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_CheckingHeroes = checkBox.Checked;
        }
        // ***************************************
        private void ARD_enableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.ARD_Enable = checkBox.Checked;
        }
        private void AD_EnHottime_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_HottimeEnable = checkBox.Checked;
        }
        private void AD_UseFriendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_UseFriend = checkBox.Checked;
        }
        private void AD_bootmodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_BootMode = checkBox.Checked;
        }
        private void GC_UseFriendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.GC_UseFriend = checkBox.Checked;
        }
        private void RD_OwnerDragon_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RD_OwnerDragon = checkBox.Checked;
            if (AISettings.RD_OwnerDragon)
            {
                RD_SummonLvl_CheckBox.Enabled = true;
                AD_SummonAuto.Enabled = true;
                AD_SummonAuto.Checked = true;
            }
            else
            {
                RD_SummonLvl_CheckBox.Enabled = false;
                AD_SummonAuto.Enabled = false;
                AD_SummonAuto.Checked = false;
            }
        }
        private void RD_LevelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RD_LevelCheckBox = checkBox.Checked;
        }
        private void RD_ReadNick_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RD_ReadNick = checkBox.Checked;
        }

        private void RD_SummonLvl_CheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.AISettings.RD_SummonLV = comboBox.SelectedIndex;
        }
        private void RD_DragonLV_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int num2 = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.RD_DragonLV = num2;
        }
        private void RD_DragonHP_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int num2 = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.RD_DragonHP = num2;
        }
        private void RD_RoundNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int num = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.RD_DragonRound = num;
        }
        private void RD_DragonLVLimit_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int num = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.RD_DragonLVLimit = num;
        }
        private void RD_DragonHPLimit_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int num = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.RD_DragonHPLimit = num;
        }
        private void ST_stop100CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Link Thank.

        private void linkLabel5_MouseClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nulled.to");
        }

        private void linkLabel4_MouseClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nulled.to/topic/143659-heartcold-seven-knights-ai-v23");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nulled.to/topic/155474-seven-knights-ai");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Nulled-Daelus/SevenKnightsAI");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/dreammed/SevenKnightsAI");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nulled.to/user/600594-xhum");
        }

        private void linkstatusToolStripLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/dreammed/SevenKnightsAI");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/SevenKnightsAIBlack");
        }

        #endregion Private Methods 

        private void AD_teamComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null)
            {
                return;
            }
            short num = Convert.ToInt16(comboBox.Tag);
            Team selectedIndex = (Team)comboBox.SelectedIndex;
            this.AISettings.AD2_Team = selectedIndex;
            return;
        }

        private void spEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.SP_DailyEnable = @checked;
                    return;

                case 1:
                    this.AISettings.SP_CakeEnable = @checked;
                    return;

                case 2:
                    this.AISettings.SP_CrystalEnable = @checked;
                    return;

                case 3:
                    this.AISettings.SP_EvanEnable = @checked;
                    return;

                case 4:
                    this.AISettings.SP_KarinEnable = @checked;
                    return;

                default:
                    return;
            }
        }

        private void SP_dailyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            short num = Convert.ToInt16(radioButton.Tag);
            bool @checked = radioButton.Checked;
            if (num == 0)
            {
                this.AISettings.SP_DailyNormal = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.SP_DailyHard = @checked;
                return;
            }
            if (num == 2)
            {
                this.AISettings.SP_DailyHell = @checked;
                return;
            }
        }

        private void SP_cakeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            short num = Convert.ToInt16(radioButton.Tag);
            bool @checked = radioButton.Checked;
            if (num == 0)
            {
                this.AISettings.SP_CakeEasy = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.SP_CakeNormal = @checked;
                return;
            }
            if (num == 2)
            {
                this.AISettings.SP_CakeHard = @checked;
                return;
            }
        }

        private void SP_crystalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            short num = Convert.ToInt16(radioButton.Tag);
            bool @checked = radioButton.Checked;
            if (num == 0)
            {
                this.AISettings.SP_CrystalEasy = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.SP_CrystalNormal = @checked;
                return;
            }
            if (num == 2)
            {
                this.AISettings.SP_CrystalHard = @checked;
                return;
            }
        }

        private void SP_evanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            short num = Convert.ToInt16(radioButton.Tag);
            bool @checked = radioButton.Checked;
            if (num == 0)
            {
                this.AISettings.SP_EvanNormal = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.SP_EvanHard = @checked;
                return;
            }
            if (num == 2)
            {
                this.AISettings.SP_EvanHell = @checked;
                return;
            }
        }

        private void SP_karinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            short num = Convert.ToInt16(radioButton.Tag);
            bool @checked = radioButton.Checked;
            if (num == 0)
            {
                this.AISettings.SP_karinNormal = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.SP_karinHard = @checked;
                return;
            }
            if (num == 2)
            {
                this.AISettings.SP_karinHell = @checked;
                return;
            }

        }

        private void splimitNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            short num = Convert.ToInt16(numericUpDown.Tag);
            int num2 = Convert.ToInt32(numericUpDown.Value);
            switch (num)
            {
                case 0:
                    this.AISettings.SP_DailyLimit = num2;
                    return;

                case 1:
                    this.AISettings.SP_CakeLimit = num2;
                    return;

                case 2:
                    this.AISettings.SP_CrystalLimit = num2;
                    return;

                case 3:
                    this.AISettings.SP_EvanLimit = num2;
                    return;

                case 4:
                    this.AISettings.SP_KarinLimit = num2;
                    return;

                default:
                    return;
            }
        }

        private void label17_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime myval = DateTime.Now;
        }

        private void AR_stopArenaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AR_LimitArena = checkBox.Checked;
        }

        private void AR_stopArenaNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int num = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.AR_LimitScore = num;
        }

        private void AD_w2autoSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_w2SkillType = SkillType.Auto;
        }

        private void AD_w2manualSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_w2SkillType = SkillType.Manual;
        }

        private void AD_w2bothSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_w2SkillType = SkillType.Both;
        }

        private void AD_w3autoSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_w3SkillType = SkillType.Auto;
        }

        private void AD_w3manualSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_w3SkillType = SkillType.Manual;
        }

        private void AD_w3bothSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_w3SkillType = SkillType.Both;
        }

        private void SP_w2autoSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.SP_w2SkillType = SkillType.Auto;
        }

        private void SP_w2manualSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.SP_w2SkillType = SkillType.Manual;
        }

        private void SP_w2bothSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.SP_w2SkillType = SkillType.Both;
        }

        private void SP_w3autoSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.SP_w3SkillType = SkillType.Auto;
        }

        private void SP_w3manualSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.SP_w3SkillType = SkillType.Manual;
        }

        private void SP_w3bothSkillRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.SP_w3SkillType = SkillType.Both;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;

            // Start with the days if greater than 0.
            string text = "";
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            // Convert milliseconds into tenths of seconds.
            int tenths = elapsed.Milliseconds / 100;

            // Compose the rest of the elapsed time.
            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00");

            timer.Text = text;
        }
        public void CaptureReport()
        {
            if (tabControl1.SelectedTab != tabControl1.TabPages["tabPage4"])
            {
                this.tabControl1.SelectedTab = tabPage4;
            }
            System.Threading.Thread.Sleep(5000);
            ScreenCapture sc = new ScreenCapture();
            // capture entire screen, and save it to a file
            Image img = sc.CaptureScreen();
            // capture this window, and save it
            sc.CaptureWindowToFile(this.Handle, "C:\\report.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Bitmap screen = this.AI.BlueStacks.CaptureFrame(!this.AIProfiles.ST_ForegroundMode);
            screen.Save("C:\\screen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CaptureReport();
        }

        private void statusToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void logsBox_TextChanged(object sender, EventArgs e)
        {
            if (this.LG_autoScroll)
            {
                this.LG_ScrollToEnd();
            }
        }

        private void h30Label2_Click(object sender, EventArgs e)
        {

        }

        private void AD_Pause100_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.AD_Pause100 = @checked;
            if (AD_Pause100.Checked == true)
            {
                this.ST_AutoShutdownCheckBox.Checked = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateNewProfiles cnp = new CreateNewProfiles();
            cnp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ST_RefreshProfiles();
        }

        private void SP_UseTicket1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.SP_UseTicket1 = @checked;
                    return;

                default:
                    return;
            }
        }


        private void Worker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AppendLog(e.Error.ToString());
        }

        private void Worker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressArgsTelegram progressArgsT = e.UserState as ProgressArgsTelegram;
            if (progressArgsT == null)
            {
                return;
            }
            switch (progressArgsT.Type)
            {
                case ProgressType.COMMANDT:
                    {
                        if ((string)progressArgsT.Message == "Start Bot")
                        {
                            this.aiButton.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Stop Bot")
                        {
                            this.aiButton.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Pause Bot")
                        {
                            this.aiPause.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Resume Bot")
                        {
                            this.aiButton.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Enable Adventure")
                        {
                            this.AISettings.AD_Enable = true;
                        }
                        else if ((string)progressArgsT.Message == "Enable GoldMine")
                        {
                            this.AISettings.GC_Enable = true;
                        }
                        else if ((string)progressArgsT.Message == "Enable Arena")
                        {
                            this.AISettings.AR_Enable = true;
                        }
                        else if ((string)progressArgsT.Message == "Enable Raid")
                        {
                            this.AISettings.RD_Enable = true;
                        }
                        else if ((string)progressArgsT.Message == "Disable Adventure")
                        {
                            AI.DisableMode(Objective.ADVENTURE);
                        }
                        else if ((string)progressArgsT.Message == "Disable GoldMine")
                        {
                            AI.DisableMode(Objective.GOLD_CHAMBER);
                        }
                        else if ((string)progressArgsT.Message == "Disable Arena")
                        {
                            AI.DisableMode(Objective.ARENA);
                        }
                        else if ((string)progressArgsT.Message == "Disable Raid")
                        {
                            AI.DisableMode(Objective.RAID);
                        }
                        else if ((string)progressArgsT.Message == "Change Mode Adventure")
                        {
                            this.AI.ChangeMode(Objective.ADVENTURE);
                        }
                        else if ((string)progressArgsT.Message == "Change Mode GoldMine")
                        {
                            this.AI.ChangeMode(Objective.GOLD_CHAMBER);
                        }
                        else if ((string)progressArgsT.Message == "Change Mode Arena")
                        {
                            this.AI.ChangeMode(Objective.ARENA);
                        }
                        else if ((string)progressArgsT.Message == "Change Mode Raid")
                        {
                            this.AI.ChangeMode(Objective.RAID);
                        }
                        else if ((string)progressArgsT.Message == "Change Mode Sell Heroes")
                        {
                            this.AI.ChangeMode(Objective.SELL_HEROES);
                        }
                        break;
                    }
            }
        }

        public void Test(object sender, DoWorkEventArgs e)
        {
            while (!this.Worker2.CancellationPending)
            {
                bot.update = "true";
                if (bot.message_text == "/start" || bot.message_text == "/Start" || bot.message_text == "ResetTelegram")
                {
                    bot.sendKeyboard.keyboard_R1_1 = "ChangeMode";
                    bot.sendKeyboard.keyboard_R1_2 = "ControlPC";
                    bot.sendKeyboard.keyboard_R1_3 = "ResetTelegram";
                    bot.sendKeyboard.keyboard_R2_1 = "EnableMode";
                    bot.sendKeyboard.keyboard_R2_2 = "DisableMode";
                    bot.sendKeyboard.keyboard_R2_3 = "GetReport";
                    bot.sendKeyboard.keyboard_R3_1 = "StartBot";
                    bot.sendKeyboard.keyboard_R3_2 = "StopBot";
                    bot.sendKeyboard.keyboard_R3_3 = "PauseBot";
                    bot.sendKeyboard.keyboard_R3_4 = "ResumeBot";
                    bot.sendKeyboard.send(bot.chat_id, "Welcome to Seven Knights AI Black Telegram Bot.\nYour ChatID will automatically added to your bot.");
                    ST_TelegramChatIDTextBox.Text = bot.chat_id;
                }
                if (bot.message_text == "StartBot")
                {
        
                    this.tabControl1.SelectedTab = tabPage4;
                    Thread.Sleep(5000);
                    if (!this.started)
                    {
                        SendCommand("Start Bot");

                        bot.sendMessage.send(bot.chat_id, "Bot Started");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Bot Already Started");
                    }
                }
                if (bot.message_text == "StopBot")
                {
                    if (this.started)
                    {
                        SendCommand("Stop Bot");

                        bot.sendMessage.send(bot.chat_id, "Bot Stopped");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Bot Already Stopped");

                    }
                }
                if (bot.message_text == "PauseBot")
                {
                    if (this.started)
                    {
                        SendCommand("Pause Bot");
                        bot.sendMessage.send(bot.chat_id, "Bot Paused");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Bot Not Running");
                    }
                }
                if (bot.message_text == "ResumeBot")
                {
                    if (this.AIProfiles.TMP_Paused)
                    {
                        SendCommand("Resume Bot");
                        bot.sendMessage.send(bot.chat_id, "Bot Resume");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Bot Not Paused");
                    }
                }
                if (bot.message_text == "EnableMode")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Adventure";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "EnableAdventure";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Arena";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "EnableArena";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Tower+GoldMine";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "EnableGoldMine";
                    bot.send_inline_keyboard.keyboard_R1_4 = "Raid";
                    bot.send_inline_keyboard.keyboard_R1_4_callback_data = "EnableRaid";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select Mode You Want To Enable : ");
                }
                if (bot.data == "EnableAdventure")
                {
                    SendCommand("Enable Adventure");
                    bot.sendMessage.send(bot.chat_id, "Adventure Enabled");
                }
                if (bot.data == "EnableArena")
                {
                    SendCommand("Enable Arena");
                    bot.sendMessage.send(bot.chat_id, "Adventure Enabled");
                }
                if (bot.data == "EnableGoldMine")
                {
                    SendCommand("Enable GoldMine");
                    bot.sendMessage.send(bot.chat_id, "Adventure Enabled");
                }
                if (bot.data == "EnableRaid")
                {
                    SendCommand("Enable Raid");
                    bot.sendMessage.send(bot.chat_id, "Adventure Enabled");
                }
                if (bot.message_text == "DisableMode")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Adventure";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "DisableAdventure";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Arena";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "DisableArena";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Tower+GoldMine";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "DisableGoldMine";
                    bot.send_inline_keyboard.keyboard_R1_4 = "Raid";
                    bot.send_inline_keyboard.keyboard_R1_4_callback_data = "DisableRaid";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select Mode You Want To Disable : ");
                }
                if (bot.data == "DisableAdventure")
                {
                    SendCommand("Disable Adventure");
                    bot.sendMessage.send(bot.chat_id, "Adventure Disabled");
                }
                if (bot.data == "DisableArena")
                {
                    SendCommand("Disable Arena");
                    bot.sendMessage.send(bot.chat_id, "Adventure Disabled");
                }
                if (bot.data == "DisableGoldMine")
                {
                    SendCommand("Disable GoldMine");
                    bot.sendMessage.send(bot.chat_id, "Adventure Disabled");
                }
                if (bot.data == "DisableRaid")
                {
                    SendCommand("Disable Raid");
                    bot.sendMessage.send(bot.chat_id, "Adventure Disabled");
                }
                if (bot.message_text == "GetReport")
                {
                    CaptureReport();
                    bot.SendPhoto.Show_sending_a_photo = true;
                    bot.SendPhoto.caption = String.Format("Report {0} , {1}", DateTime.Now.ToString(), this.AI.GetMode().ToString());
                    bot.SendPhoto.send(this.AIProfiles.ST_TelegramChatID, @"C://report.jpg");
                    bot.SendPhoto.Show_sending_a_photo = true;
                    bot.SendPhoto.caption = String.Format("Last Screenshot {0}", DateTime.Now.ToString());
                    bot.SendPhoto.send(this.AIProfiles.ST_TelegramChatID, @"C://screen.jpg");
                }
                if (bot.message_text == "ChangeMode")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Adventure";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "FAdventure";
                    bot.send_inline_keyboard.keyboard_R1_2 = "GoldMine";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "FGoldMine";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Arena";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "FArena";
                    bot.send_inline_keyboard.keyboard_R1_4 = "Raid";
                    bot.send_inline_keyboard.keyboard_R1_4_callback_data = "FRaid";
                    bot.send_inline_keyboard.send(bot.chat_id, "This Feature will force bot to change mode, Please choose Mode what you want : ");
                }
                if (bot.data == "FAdventure")
                {
                    if (this.AISettings.AD_Enable == true)
                    {
                        SendCommand("Change Mode Adventure");
                        bot.sendMessage.send(bot.chat_id, "Mode Changed to : Adventure");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Adventure Mode is not Activated");
                    }
                }
                if (bot.data == "FGoldMine")
                {
                    if (this.AISettings.GC_Enable == true)
                    {
                        SendCommand("Change Mode GoldMine");
                        bot.sendMessage.send(bot.chat_id, "Mode Changed to : Gold Mine");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Gold Mine Mode is not Activated");
                    }
                }
                if (bot.data == "FArena")
                {
                    if (this.AISettings.AR_Enable == true)
                    {
                        SendCommand("Change Mode Arena");
                        bot.sendMessage.send(bot.chat_id, "Mode Changed to : Arena");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Arena Mode is not Activated");
                    }
                }
                if (bot.data == "FRaid")
                {
                    if (this.AISettings.RD_Enable == true)
                    {
                        SendCommand("Change Mode Raid");
                        bot.sendMessage.send(bot.chat_id, "Mode Changed to : Raid");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Raid Mode is not Activated");
                    }
                }
                if (bot.data == "FSellHeroes") { 
                        SendCommand("Change Mode Sell Heroes");
                        bot.sendMessage.send(bot.chat_id, "Mode Changed to : Sell Heroes");
                }
                if (bot.message_text == "ControlPC")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Shutdown PC";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "Shutdown";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Restart PC";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "Restart";
                    bot.send_inline_keyboard.keyboard_R2_1 = "Restart 7k";
                    bot.send_inline_keyboard.keyboard_R2_1_callback_data = "Restart7k";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select Mode You Want To Enable : ");
                }
                if (bot.data == "Restart7k")
                {
                    bot.sendMessage.send(bot.chat_id, Restart7k());
                }
                if (bot.data == "Shutdown")
                {
                    bot.sendMessage.send(bot.chat_id, "PC will Shutdown Now!");
                    Process.Start("shutdown", "/s /f /t 0");
                }
                if (bot.data == "Restart")
                {
                    bot.sendMessage.send(bot.chat_id, "PC will Restart Now!");
                    Process.Start("shutdown", "/r /t 0");
                }
            }
        }
        private void SendCommand(string message)
        {
            ProgressArgsTelegram userState = new ProgressArgsTelegram(ProgressType.COMMANDT, message);
            this.Worker2.ReportProgress(0, userState);
        }

        private void AD_NoHeroUp_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.AD_NoHeroUp = @checked;
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void screenshotButton_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = timer1.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
ts.Hours, ts.Minutes, ts.Seconds);
            timer.Text = elapsedTime;
        }

        private void botstatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void EX_EnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.EX_Enable = @checked;
        }

        private void EX_SendAgainCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.EX_Send = @checked;
        }

        private void AD_SummonAuto_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.AD_SummonAuto = @checked;
        }
    }
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            using (_timeoutTimer)
                MessageBox.Show(text, caption);
        }
        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
}