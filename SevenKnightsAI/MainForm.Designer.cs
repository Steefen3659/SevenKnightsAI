namespace SevenKnightsAI
{
	
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GC_limitLabel = new System.Windows.Forms.Label();
            this.GC_limitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.GC_limitCheckBox = new System.Windows.Forms.CheckBox();
            this.GC_UseFriendCheckBox = new System.Windows.Forms.CheckBox();
            this.GC_masteryComboBox = new System.Windows.Forms.ComboBox();
            this.GC_masteryLabel = new System.Windows.Forms.Label();
            this.GC_formationComboBox = new System.Windows.Forms.ComboBox();
            this.GC_teamComboBox = new System.Windows.Forms.ComboBox();
            this.GC_formationPanel = new System.Windows.Forms.Panel();
            this.GC_pos5CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos4CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos3CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos2CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos1CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_formationLabel = new System.Windows.Forms.Label();
            this.GC_teamLabel = new System.Windows.Forms.Label();
            this.AD_NoHeroUp_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_Pause100 = new System.Windows.Forms.CheckBox();
            this.AD_StopOnDragon_Checkbox = new System.Windows.Forms.CheckBox();
            this.RD_ReadNick = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RD_DragonLVLimit = new System.Windows.Forms.NumericUpDown();
            this.RD_DragonHPLimit = new System.Windows.Forms.NumericUpDown();
            this.RD_LevelCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RD_DragonLV = new System.Windows.Forms.NumericUpDown();
            this.RD_DragonHP = new System.Windows.Forms.NumericUpDown();
            this.RD_leaderComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SP_skillGroupBox = new System.Windows.Forms.GroupBox();
            this.SP_wave3Panel = new System.Windows.Forms.Panel();
            this.SP_w3bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_w3Skill11Button = new System.Windows.Forms.Button();
            this.SP_w3manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_w3Skill12Button = new System.Windows.Forms.Button();
            this.SP_w3autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_w3Skill13Button = new System.Windows.Forms.Button();
            this.SP_w3Skill14Button = new System.Windows.Forms.Button();
            this.SP_w3Skill15Button = new System.Windows.Forms.Button();
            this.SP_wave3LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_w3Skill10Button = new System.Windows.Forms.Button();
            this.SP_w3Skill09Button = new System.Windows.Forms.Button();
            this.SP_w3Skill08Button = new System.Windows.Forms.Button();
            this.SP_w3Skill07Button = new System.Windows.Forms.Button();
            this.SP_w3Skill06Button = new System.Windows.Forms.Button();
            this.SP_w3Skill05Button = new System.Windows.Forms.Button();
            this.SP_w3Skill04Button = new System.Windows.Forms.Button();
            this.SP_w3Skill03Button = new System.Windows.Forms.Button();
            this.SP_w3Skill02Button = new System.Windows.Forms.Button();
            this.SP_wave3Label = new System.Windows.Forms.Label();
            this.SP_w3Skill01Button = new System.Windows.Forms.Button();
            this.SP_bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_wave2Panel = new System.Windows.Forms.Panel();
            this.SP_w2bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_w2manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_w2autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_w2Skill11Button = new System.Windows.Forms.Button();
            this.SP_wave2LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_w2Skill12Button = new System.Windows.Forms.Button();
            this.SP_w2Skill10Button = new System.Windows.Forms.Button();
            this.SP_w2Skill13Button = new System.Windows.Forms.Button();
            this.SP_w2Skill09Button = new System.Windows.Forms.Button();
            this.SP_w2Skill14Button = new System.Windows.Forms.Button();
            this.SP_w2Skill08Button = new System.Windows.Forms.Button();
            this.SP_w2Skill15Button = new System.Windows.Forms.Button();
            this.SP_w2Skill07Button = new System.Windows.Forms.Button();
            this.SP_w2Skill06Button = new System.Windows.Forms.Button();
            this.SP_w2Skill05Button = new System.Windows.Forms.Button();
            this.SP_w2Skill04Button = new System.Windows.Forms.Button();
            this.SP_w2Skill03Button = new System.Windows.Forms.Button();
            this.SP_w2Skill02Button = new System.Windows.Forms.Button();
            this.SP_wave2Label = new System.Windows.Forms.Label();
            this.SP_w2Skill01Button = new System.Windows.Forms.Button();
            this.SP_manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_wave1Panel = new System.Windows.Forms.Panel();
            this.SP_w1Skill11Button = new System.Windows.Forms.Button();
            this.SP_wave1LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_w1Skill10Button = new System.Windows.Forms.Button();
            this.SP_w1Skill12Button = new System.Windows.Forms.Button();
            this.SP_w1Skill09Button = new System.Windows.Forms.Button();
            this.SP_w1Skill08Button = new System.Windows.Forms.Button();
            this.SP_w1Skill13Button = new System.Windows.Forms.Button();
            this.SP_w1Skill07Button = new System.Windows.Forms.Button();
            this.SP_w1Skill06Button = new System.Windows.Forms.Button();
            this.SP_w1Skill14Button = new System.Windows.Forms.Button();
            this.SP_w1Skill05Button = new System.Windows.Forms.Button();
            this.SP_w1Skill04Button = new System.Windows.Forms.Button();
            this.SP_w1Skill15Button = new System.Windows.Forms.Button();
            this.SP_w1Skill03Button = new System.Windows.Forms.Button();
            this.SP_w1Skill02Button = new System.Windows.Forms.Button();
            this.SP_wave1Label = new System.Windows.Forms.Label();
            this.SP_w1Skill01Button = new System.Windows.Forms.Button();
            this.evanGroupBox = new System.Windows.Forms.GroupBox();
            this.SP_UseTicket1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SP_evanCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_evanLimitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.SP_evanHardRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.SP_evanNorRadioButton = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.RS_collectQuestsGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_questsSocialCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsItemCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsHeroCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsBattleCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_specialQuestsMonthlyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_specialQuestsWeeklyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_specialQuestsDailyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsNormalLabel = new System.Windows.Forms.Label();
            this.RS_questsSpecialLabel = new System.Windows.Forms.Label();
            this.RS_sendHonorsGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_giftsGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_luckyBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_luckyChestCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_sendHonorsInGame = new System.Windows.Forms.CheckBox();
            this.RS_sendHonorsFacebook = new System.Windows.Forms.CheckBox();
            this.RS_buyKeysGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_buyKeyRubiesLabel = new System.Windows.Forms.Label();
            this.RS_buyKeyRubiesNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_buyKeyRubiesComboBox = new System.Windows.Forms.ComboBox();
            this.RS_buyKeyRubiesCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_buyKeyHonorsLabel = new System.Windows.Forms.Label();
            this.RS_buyKeyHonorsNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_buyKeyHonorsComboBox = new System.Windows.Forms.ComboBox();
            this.RS_buyKeyHonorsCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_inboxGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_InboxCurrency = new System.Windows.Forms.CheckBox();
            this.RS_InboxKeys = new System.Windows.Forms.CheckBox();
            this.RS_inboxMaterials = new System.Windows.Forms.CheckBox();
            this.RS_inboxHonors = new System.Windows.Forms.CheckBox();
            this.RS_sellingGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_itemRadioPanel = new System.Windows.Forms.Panel();
            this.RS_itemAmountRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_itemAllRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_heroRadioPanel = new System.Windows.Forms.Panel();
            this.RS_heroAmountRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_heroAllRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_itemAmountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_heroAmountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_itemStarsComboBox = new System.Windows.Forms.ComboBox();
            this.RS_heroStarsComboBox = new System.Windows.Forms.ComboBox();
            this.RS_sellHeroesCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_sellItemsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ST_TelegramChatIDTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ST_TelegramTokenTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ST_TelegramEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_opacityLabel = new System.Windows.Forms.Label();
            this.ST_manageProfileButton = new System.Windows.Forms.Button();
            this.ST_hotTimeProfileCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_currentProfileComboBox = new System.Windows.Forms.ComboBox();
            this.ST_currentProfileLabel = new System.Windows.Forms.Label();
            this.ST_opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.ST_reconnectNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ST_reconnectInterruptCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_delayValueLabel = new System.Windows.Forms.Label();
            this.ST_delayLabel = new System.Windows.Forms.Label();
            this.ST_delayTrackBar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.logsBox = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Label();
            this.botstatusLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.towerKeysLabel2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.arenaKeysLabel2 = new System.Windows.Forms.Label();
            this.adventureKeysLabel2 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dragoncountlabel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.h30Label2 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.HeroCountLabel = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rankArenaLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.arenaLoseLabel2 = new System.Windows.Forms.Label();
            this.arenaWinLabel2 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.goldmineGoldAmountLabel2 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.honorLabel2 = new System.Windows.Forms.Label();
            this.topazLabel2 = new System.Windows.Forms.Label();
            this.rubyLabel2 = new System.Windows.Forms.Label();
            this.goldLabel2 = new System.Windows.Forms.Label();
            this.ST_AutoShutdownCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_limitLabel = new System.Windows.Forms.Label();
            this.AD_limitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AD_limitCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_RubyBooster_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_bootmodeCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_leaderComboBox = new System.Windows.Forms.ComboBox();
            this.AD_UseFriendCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_masteryLabel = new System.Windows.Forms.Label();
            this.AD_EnHottime_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_teamComboBox2 = new System.Windows.Forms.ComboBox();
            this.AD_difficultyComboBox2nd = new System.Windows.Forms.ComboBox();
            this.AD_StopOnLV30_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_continuousCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_CheckingHeroes_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_sequenceButton = new System.Windows.Forms.Button();
            this.AD_StopOnFullItems_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_formationComboBox = new System.Windows.Forms.ComboBox();
            this.AD_StopOnFullHeroes_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_teamComboBox = new System.Windows.Forms.ComboBox();
            this.AD_stageComboBox = new System.Windows.Forms.ComboBox();
            this.AD_worldComboBox = new System.Windows.Forms.ComboBox();
            this.AD_elementHeroesCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_formationPanel = new System.Windows.Forms.Panel();
            this.AD_pos5CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_pos4CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_pos3CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_pos2CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_pos1CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_formationLabel = new System.Windows.Forms.Label();
            this.AD_teamLabel = new System.Windows.Forms.Label();
            this.AD_stageLabel = new System.Windows.Forms.Label();
            this.AD_worldLabel = new System.Windows.Forms.Label();
            this.AD_difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.AD_skillGroupBox = new System.Windows.Forms.GroupBox();
            this.AD_bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_wave3Panel = new System.Windows.Forms.Panel();
            this.AD_w3bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_w3Skill11Button = new System.Windows.Forms.Button();
            this.AD_w3Skill12Button = new System.Windows.Forms.Button();
            this.AD_w3manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_w3Skill13Button = new System.Windows.Forms.Button();
            this.AD_w3autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_w3Skill14Button = new System.Windows.Forms.Button();
            this.AD_w3Skill15Button = new System.Windows.Forms.Button();
            this.AD_wave3LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_w3Skill10Button = new System.Windows.Forms.Button();
            this.AD_w3Skill09Button = new System.Windows.Forms.Button();
            this.AD_w3Skill08Button = new System.Windows.Forms.Button();
            this.AD_w3Skill07Button = new System.Windows.Forms.Button();
            this.AD_w3Skill06Button = new System.Windows.Forms.Button();
            this.AD_w3Skill05Button = new System.Windows.Forms.Button();
            this.AD_w3Skill04Button = new System.Windows.Forms.Button();
            this.AD_w3Skill03Button = new System.Windows.Forms.Button();
            this.AD_w3Skill02Button = new System.Windows.Forms.Button();
            this.AD_wave3Label = new System.Windows.Forms.Label();
            this.AD_w3Skill01Button = new System.Windows.Forms.Button();
            this.AD_wave2Panel = new System.Windows.Forms.Panel();
            this.AD_w2bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_w2Skill11Button = new System.Windows.Forms.Button();
            this.AD_w2manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_w2Skill12Button = new System.Windows.Forms.Button();
            this.AD_w2autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_wave2LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_w2Skill13Button = new System.Windows.Forms.Button();
            this.AD_w2Skill10Button = new System.Windows.Forms.Button();
            this.AD_w2Skill14Button = new System.Windows.Forms.Button();
            this.AD_w2Skill09Button = new System.Windows.Forms.Button();
            this.AD_w2Skill15Button = new System.Windows.Forms.Button();
            this.AD_w2Skill08Button = new System.Windows.Forms.Button();
            this.AD_w2Skill07Button = new System.Windows.Forms.Button();
            this.AD_w2Skill06Button = new System.Windows.Forms.Button();
            this.AD_w2Skill05Button = new System.Windows.Forms.Button();
            this.AD_w2Skill04Button = new System.Windows.Forms.Button();
            this.AD_w2Skill03Button = new System.Windows.Forms.Button();
            this.AD_w2Skill02Button = new System.Windows.Forms.Button();
            this.AD_wave2Label = new System.Windows.Forms.Label();
            this.AD_w2Skill01Button = new System.Windows.Forms.Button();
            this.AD_manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_wave1Panel = new System.Windows.Forms.Panel();
            this.AD_w1Skill11Button = new System.Windows.Forms.Button();
            this.AD_wave1LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_w1Skill12Button = new System.Windows.Forms.Button();
            this.AD_w1Skill10Button = new System.Windows.Forms.Button();
            this.AD_w1Skill09Button = new System.Windows.Forms.Button();
            this.AD_w1Skill13Button = new System.Windows.Forms.Button();
            this.AD_w1Skill08Button = new System.Windows.Forms.Button();
            this.AD_w1Skill07Button = new System.Windows.Forms.Button();
            this.AD_w1Skill14Button = new System.Windows.Forms.Button();
            this.AD_w1Skill06Button = new System.Windows.Forms.Button();
            this.AD_w1Skill05Button = new System.Windows.Forms.Button();
            this.AD_w1Skill15Button = new System.Windows.Forms.Button();
            this.AD_w1Skill04Button = new System.Windows.Forms.Button();
            this.AD_w1Skill03Button = new System.Windows.Forms.Button();
            this.AD_w1Skill02Button = new System.Windows.Forms.Button();
            this.AD_wave1Label = new System.Windows.Forms.Label();
            this.AD_w1Skill01Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AD_difficultyLabel = new System.Windows.Forms.Label();
            this.AD_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.GC_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.AR_limitLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.AR_useRubyLabel = new System.Windows.Forms.Label();
            this.AR_limitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AR_stopArenaNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AR_useRubyNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AR_limitCheckBox = new System.Windows.Forms.CheckBox();
            this.AR_stopArenaCheckBox = new System.Windows.Forms.CheckBox();
            this.AR_useRubyCheckBox = new System.Windows.Forms.CheckBox();
            this.AR_skillGroupBox = new System.Windows.Forms.GroupBox();
            this.AR_leaderComboBox = new System.Windows.Forms.ComboBox();
            this.AR_masteryLabel = new System.Windows.Forms.Label();
            this.AR_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.RD_RoundNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RD_DragonLimit_lbl = new System.Windows.Forms.Label();
            this.RD_SummonLvl_CheckBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.RD_OwnerDragon = new System.Windows.Forms.CheckBox();
            this.RD_skillGroupBox = new System.Windows.Forms.GroupBox();
            this.RD_bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.RD_team2Panel = new System.Windows.Forms.Panel();
            this.RD_t2Skill11Button = new System.Windows.Forms.Button();
            this.RD_t2Skill12Button = new System.Windows.Forms.Button();
            this.RD_t2Skill13Button = new System.Windows.Forms.Button();
            this.RD_t2Skill14Button = new System.Windows.Forms.Button();
            this.RD_t2Skill15Button = new System.Windows.Forms.Button();
            this.RD_team2LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.RD_t2Skill10Button = new System.Windows.Forms.Button();
            this.RD_t2Skill09Button = new System.Windows.Forms.Button();
            this.RD_t2Skill08Button = new System.Windows.Forms.Button();
            this.RD_t2Skill07Button = new System.Windows.Forms.Button();
            this.RD_t2Skill06Button = new System.Windows.Forms.Button();
            this.RD_t2Skill05Button = new System.Windows.Forms.Button();
            this.RD_t2Skill04Button = new System.Windows.Forms.Button();
            this.RD_t2Skill03Button = new System.Windows.Forms.Button();
            this.RD_t2Skill02Button = new System.Windows.Forms.Button();
            this.RD_team2Label = new System.Windows.Forms.Label();
            this.RD_t2Skill01Button = new System.Windows.Forms.Button();
            this.RD_manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.RD_autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.RD_team1Panel = new System.Windows.Forms.Panel();
            this.RD_t1Skill11Button = new System.Windows.Forms.Button();
            this.RD_team1LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.RD_t1Skill12Button = new System.Windows.Forms.Button();
            this.RD_t1Skill10Button = new System.Windows.Forms.Button();
            this.RD_t1Skill13Button = new System.Windows.Forms.Button();
            this.RD_t1Skill09Button = new System.Windows.Forms.Button();
            this.RD_t1Skill14Button = new System.Windows.Forms.Button();
            this.RD_t1Skill08Button = new System.Windows.Forms.Button();
            this.RD_t1Skill15Button = new System.Windows.Forms.Button();
            this.RD_t1Skill07Button = new System.Windows.Forms.Button();
            this.RD_t1Skill06Button = new System.Windows.Forms.Button();
            this.RD_t1Skill05Button = new System.Windows.Forms.Button();
            this.RD_t1Skill04Button = new System.Windows.Forms.Button();
            this.RD_t1Skill03Button = new System.Windows.Forms.Button();
            this.RD_t1Skill02Button = new System.Windows.Forms.Button();
            this.RD_team1Label = new System.Windows.Forms.Label();
            this.RD_t1Skill01Button = new System.Windows.Forms.Button();
            this.RD_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.RD_DragonLimitCheckBox = new System.Windows.Forms.CheckBox();
            this.GB_WaitForKeys = new System.Windows.Forms.CheckBox();
            this.ST_hotTimeProfileComboBox = new System.Windows.Forms.ComboBox();
            this.ST_AutoProfileCheckBox = new System.Windows.Forms.CheckBox();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.goldmineCountLabel = new System.Windows.Forms.Label();
            this.raidPictureBox = new System.Windows.Forms.PictureBox();
            this.goldChamberPictureBox = new System.Windows.Forms.PictureBox();
            this.arenaPictureBox = new System.Windows.Forms.PictureBox();
            this.adventurePictureBox = new System.Windows.Forms.PictureBox();
            this.raidCountLabel = new System.Windows.Forms.Label();
            this.goldChamberCountLabel = new System.Windows.Forms.Label();
            this.arenaCountLabel = new System.Windows.Forms.Label();
            this.adventureCountLabel = new System.Windows.Forms.Label();
            this.aiPause = new System.Windows.Forms.Button();
            this.aiButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.adminToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.profileToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCursorPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPixel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBuildInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topheaderPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LG_logTextBox = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.ADCH_ChangeHeroGroupBox = new System.Windows.Forms.GroupBox();
            this.tabPage23 = new System.Windows.Forms.TabPage();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.AD_SummonAuto = new System.Windows.Forms.CheckBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.EX_SendAgainCheckBox = new System.Windows.Forms.CheckBox();
            this.EX_EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button33 = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.ST_blueStacksGroupBox = new System.Windows.Forms.GroupBox();
            this.ST_forceActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_toggleBlueStacksButton = new System.Windows.Forms.Button();
            this.ST_foregroundMode = new System.Windows.Forms.CheckBox();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.label79 = new System.Windows.Forms.Label();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.tabPage21 = new System.Windows.Forms.TabPage();
            this.tabPage22 = new System.Windows.Forms.TabPage();
            this.label84 = new System.Windows.Forms.Label();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.screenshotButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ST_NoMoreProfileComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GC_limitNumericBox)).BeginInit();
            this.GC_formationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonLVLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonHPLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonHP)).BeginInit();
            this.SP_skillGroupBox.SuspendLayout();
            this.SP_wave3Panel.SuspendLayout();
            this.SP_wave2Panel.SuspendLayout();
            this.SP_wave1Panel.SuspendLayout();
            this.evanGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_evanLimitNumericBox)).BeginInit();
            this.RS_collectQuestsGroupBox.SuspendLayout();
            this.RS_sendHonorsGroupBox.SuspendLayout();
            this.RS_giftsGroupBox.SuspendLayout();
            this.RS_buyKeysGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyRubiesNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyHonorsNumericBox)).BeginInit();
            this.RS_inboxGroupBox.SuspendLayout();
            this.RS_sellingGroupBox.SuspendLayout();
            this.RS_itemRadioPanel.SuspendLayout();
            this.RS_heroRadioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_itemAmountNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_heroAmountNumericBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_opacityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_reconnectNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_delayTrackBar)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD_limitNumericBox)).BeginInit();
            this.AD_formationPanel.SuspendLayout();
            this.AD_skillGroupBox.SuspendLayout();
            this.AD_wave3Panel.SuspendLayout();
            this.AD_wave2Panel.SuspendLayout();
            this.AD_wave1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AR_limitNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AR_stopArenaNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AR_useRubyNumericBox)).BeginInit();
            this.AR_skillGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RD_RoundNumericUpDown)).BeginInit();
            this.RD_skillGroupBox.SuspendLayout();
            this.RD_team2Panel.SuspendLayout();
            this.RD_team1Panel.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raidPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldChamberPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventurePictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topheaderPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.ADCH_ChangeHeroGroupBox.SuspendLayout();
            this.tabPage23.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabPage18.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tabPage19.SuspendLayout();
            this.ST_blueStacksGroupBox.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.tabPage20.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.tabPage21.SuspendLayout();
            this.tabPage22.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GC_limitLabel
            // 
            this.GC_limitLabel.AutoSize = true;
            this.GC_limitLabel.Location = new System.Drawing.Point(363, 16);
            this.GC_limitLabel.Name = "GC_limitLabel";
            this.GC_limitLabel.Size = new System.Drawing.Size(70, 13);
            this.GC_limitLabel.TabIndex = 19;
            this.GC_limitLabel.Text = "times per visit";
            // 
            // GC_limitNumericBox
            // 
            this.GC_limitNumericBox.Location = new System.Drawing.Point(321, 13);
            this.GC_limitNumericBox.Name = "GC_limitNumericBox";
            this.GC_limitNumericBox.Size = new System.Drawing.Size(37, 20);
            this.GC_limitNumericBox.TabIndex = 18;
            this.GC_limitNumericBox.Tag = "1";
            this.GC_limitNumericBox.ValueChanged += new System.EventHandler(this.limitNumericBox_ValueChanged);
            // 
            // GC_limitCheckBox
            // 
            this.GC_limitCheckBox.Location = new System.Drawing.Point(271, 15);
            this.GC_limitCheckBox.Name = "GC_limitCheckBox";
            this.GC_limitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.GC_limitCheckBox.TabIndex = 17;
            this.GC_limitCheckBox.Tag = "1";
            this.GC_limitCheckBox.Text = "Limit";
            this.GC_limitCheckBox.UseVisualStyleBackColor = true;
            this.GC_limitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // GC_UseFriendCheckBox
            // 
            this.GC_UseFriendCheckBox.AutoSize = true;
            this.GC_UseFriendCheckBox.Location = new System.Drawing.Point(294, 46);
            this.GC_UseFriendCheckBox.Name = "GC_UseFriendCheckBox";
            this.GC_UseFriendCheckBox.Size = new System.Drawing.Size(82, 17);
            this.GC_UseFriendCheckBox.TabIndex = 20;
            this.GC_UseFriendCheckBox.Text = "Use Friends";
            this.GC_UseFriendCheckBox.UseVisualStyleBackColor = true;
            this.GC_UseFriendCheckBox.CheckedChanged += new System.EventHandler(this.GC_UseFriendCheckBox_CheckedChanged);
            // 
            // GC_masteryComboBox
            // 
            this.GC_masteryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GC_masteryComboBox.Enabled = false;
            this.GC_masteryComboBox.FormattingEnabled = true;
            this.GC_masteryComboBox.Items.AddRange(new object[] {
            "--",
            "1",
            "2",
            "3"});
            this.GC_masteryComboBox.Location = new System.Drawing.Point(393, 325);
            this.GC_masteryComboBox.Name = "GC_masteryComboBox";
            this.GC_masteryComboBox.Size = new System.Drawing.Size(46, 21);
            this.GC_masteryComboBox.TabIndex = 16;
            this.GC_masteryComboBox.Tag = "1";
            this.GC_masteryComboBox.Visible = false;
            this.GC_masteryComboBox.SelectedIndexChanged += new System.EventHandler(this.masteryComboBox_SelectedIndexChanged);
            // 
            // GC_masteryLabel
            // 
            this.GC_masteryLabel.AutoSize = true;
            this.GC_masteryLabel.Enabled = false;
            this.GC_masteryLabel.Location = new System.Drawing.Point(341, 329);
            this.GC_masteryLabel.Name = "GC_masteryLabel";
            this.GC_masteryLabel.Size = new System.Drawing.Size(44, 13);
            this.GC_masteryLabel.TabIndex = 15;
            this.GC_masteryLabel.Text = "Mastery";
            this.GC_masteryLabel.Visible = false;
            // 
            // GC_formationComboBox
            // 
            this.GC_formationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GC_formationComboBox.FormattingEnabled = true;
            this.GC_formationComboBox.Items.AddRange(new object[] {
            "--",
            "2 Front / 3 Back",
            "3 Front / 2 Back",
            "1 Front / 4 Back",
            "4 Front / 1 Back"});
            this.GC_formationComboBox.Location = new System.Drawing.Point(118, 211);
            this.GC_formationComboBox.Name = "GC_formationComboBox";
            this.GC_formationComboBox.Size = new System.Drawing.Size(127, 21);
            this.GC_formationComboBox.TabIndex = 3;
            this.GC_formationComboBox.Tag = "1";
            this.GC_formationComboBox.Visible = false;
            this.GC_formationComboBox.SelectedIndexChanged += new System.EventHandler(this.formationComboBox_SelectedIndexChanged);
            // 
            // GC_teamComboBox
            // 
            this.GC_teamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GC_teamComboBox.Enabled = false;
            this.GC_teamComboBox.FormattingEnabled = true;
            this.GC_teamComboBox.Items.AddRange(new object[] {
            "--",
            "A",
            "B",
            "C"});
            this.GC_teamComboBox.Location = new System.Drawing.Point(118, 179);
            this.GC_teamComboBox.Name = "GC_teamComboBox";
            this.GC_teamComboBox.Size = new System.Drawing.Size(52, 21);
            this.GC_teamComboBox.TabIndex = 2;
            this.GC_teamComboBox.Tag = "1";
            this.GC_teamComboBox.Visible = false;
            this.GC_teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // GC_formationPanel
            // 
            this.GC_formationPanel.BackColor = System.Drawing.Color.Silver;
            this.GC_formationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GC_formationPanel.Controls.Add(this.GC_pos5CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos4CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos3CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos2CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos1CheckBox);
            this.GC_formationPanel.Location = new System.Drawing.Point(118, 238);
            this.GC_formationPanel.Name = "GC_formationPanel";
            this.GC_formationPanel.Size = new System.Drawing.Size(80, 85);
            this.GC_formationPanel.TabIndex = 4;
            this.GC_formationPanel.Tag = "1";
            this.GC_formationPanel.Visible = false;
            // 
            // GC_pos5CheckBox
            // 
            this.GC_pos5CheckBox.AutoSize = true;
            this.GC_pos5CheckBox.Enabled = false;
            this.GC_pos5CheckBox.Location = new System.Drawing.Point(3, 61);
            this.GC_pos5CheckBox.Name = "GC_pos5CheckBox";
            this.GC_pos5CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos5CheckBox.TabIndex = 4;
            this.GC_pos5CheckBox.Tag = "4";
            this.GC_pos5CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos5CheckBox.Visible = false;
            // 
            // GC_pos4CheckBox
            // 
            this.GC_pos4CheckBox.AutoSize = true;
            this.GC_pos4CheckBox.Enabled = false;
            this.GC_pos4CheckBox.Location = new System.Drawing.Point(3, 48);
            this.GC_pos4CheckBox.Name = "GC_pos4CheckBox";
            this.GC_pos4CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos4CheckBox.TabIndex = 3;
            this.GC_pos4CheckBox.Tag = "3";
            this.GC_pos4CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos4CheckBox.Visible = false;
            // 
            // GC_pos3CheckBox
            // 
            this.GC_pos3CheckBox.AutoSize = true;
            this.GC_pos3CheckBox.Enabled = false;
            this.GC_pos3CheckBox.Location = new System.Drawing.Point(3, 35);
            this.GC_pos3CheckBox.Name = "GC_pos3CheckBox";
            this.GC_pos3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos3CheckBox.TabIndex = 2;
            this.GC_pos3CheckBox.Tag = "2";
            this.GC_pos3CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos3CheckBox.Visible = false;
            // 
            // GC_pos2CheckBox
            // 
            this.GC_pos2CheckBox.AutoSize = true;
            this.GC_pos2CheckBox.Enabled = false;
            this.GC_pos2CheckBox.Location = new System.Drawing.Point(3, 22);
            this.GC_pos2CheckBox.Name = "GC_pos2CheckBox";
            this.GC_pos2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos2CheckBox.TabIndex = 1;
            this.GC_pos2CheckBox.Tag = "1";
            this.GC_pos2CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos2CheckBox.Visible = false;
            // 
            // GC_pos1CheckBox
            // 
            this.GC_pos1CheckBox.AutoSize = true;
            this.GC_pos1CheckBox.Enabled = false;
            this.GC_pos1CheckBox.Location = new System.Drawing.Point(3, 9);
            this.GC_pos1CheckBox.Name = "GC_pos1CheckBox";
            this.GC_pos1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos1CheckBox.TabIndex = 0;
            this.GC_pos1CheckBox.Tag = "0";
            this.GC_pos1CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos1CheckBox.Visible = false;
            // 
            // GC_formationLabel
            // 
            this.GC_formationLabel.Location = new System.Drawing.Point(49, 214);
            this.GC_formationLabel.Name = "GC_formationLabel";
            this.GC_formationLabel.Size = new System.Drawing.Size(62, 13);
            this.GC_formationLabel.TabIndex = 20;
            this.GC_formationLabel.Text = "Formation";
            this.GC_formationLabel.Visible = false;
            // 
            // GC_teamLabel
            // 
            this.GC_teamLabel.Enabled = false;
            this.GC_teamLabel.Location = new System.Drawing.Point(49, 182);
            this.GC_teamLabel.Name = "GC_teamLabel";
            this.GC_teamLabel.Size = new System.Drawing.Size(62, 13);
            this.GC_teamLabel.TabIndex = 19;
            this.GC_teamLabel.Text = "Team";
            this.GC_teamLabel.Visible = false;
            // 
            // AD_NoHeroUp_Checkbox
            // 
            this.AD_NoHeroUp_Checkbox.AutoSize = true;
            this.AD_NoHeroUp_Checkbox.Location = new System.Drawing.Point(274, 109);
            this.AD_NoHeroUp_Checkbox.Name = "AD_NoHeroUp_Checkbox";
            this.AD_NoHeroUp_Checkbox.Size = new System.Drawing.Size(208, 17);
            this.AD_NoHeroUp_Checkbox.TabIndex = 4;
            this.AD_NoHeroUp_Checkbox.Text = "Paused When No More Hero to Lv Up";
            this.AD_NoHeroUp_Checkbox.UseVisualStyleBackColor = true;
            this.AD_NoHeroUp_Checkbox.CheckedChanged += new System.EventHandler(this.AD_NoHeroUp_Checkbox_CheckedChanged);
            // 
            // AD_Pause100
            // 
            this.AD_Pause100.AutoSize = true;
            this.AD_Pause100.Location = new System.Drawing.Point(6, 86);
            this.AD_Pause100.Name = "AD_Pause100";
            this.AD_Pause100.Size = new System.Drawing.Size(136, 17);
            this.AD_Pause100.TabIndex = 0;
            this.AD_Pause100.Text = "Pause After Max Lv Up";
            this.AD_Pause100.UseVisualStyleBackColor = true;
            this.AD_Pause100.CheckedChanged += new System.EventHandler(this.AD_Pause100_CheckedChanged);
            // 
            // AD_StopOnDragon_Checkbox
            // 
            this.AD_StopOnDragon_Checkbox.AutoSize = true;
            this.AD_StopOnDragon_Checkbox.Enabled = false;
            this.AD_StopOnDragon_Checkbox.Location = new System.Drawing.Point(278, 330);
            this.AD_StopOnDragon_Checkbox.Name = "AD_StopOnDragon_Checkbox";
            this.AD_StopOnDragon_Checkbox.Size = new System.Drawing.Size(143, 17);
            this.AD_StopOnDragon_Checkbox.TabIndex = 41;
            this.AD_StopOnDragon_Checkbox.Text = "Pause on Dragon Ready";
            this.AD_StopOnDragon_Checkbox.UseVisualStyleBackColor = true;
            this.AD_StopOnDragon_Checkbox.Visible = false;
            this.AD_StopOnDragon_Checkbox.CheckedChanged += new System.EventHandler(this.AD_StopOnDragon_Checkbox_CheckedChanged);
            // 
            // RD_ReadNick
            // 
            this.RD_ReadNick.AutoSize = true;
            this.RD_ReadNick.Location = new System.Drawing.Point(6, 19);
            this.RD_ReadNick.Name = "RD_ReadNick";
            this.RD_ReadNick.Size = new System.Drawing.Size(137, 17);
            this.RD_ReadNick.TabIndex = 42;
            this.RD_ReadNick.Text = "Read Owner Nickname";
            this.RD_ReadNick.UseVisualStyleBackColor = true;
            this.RD_ReadNick.CheckedChanged += new System.EventHandler(this.RD_ReadNick_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(134, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(135, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "-";
            // 
            // RD_DragonLVLimit
            // 
            this.RD_DragonLVLimit.Location = new System.Drawing.Point(156, 42);
            this.RD_DragonLVLimit.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.RD_DragonLVLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonLVLimit.Name = "RD_DragonLVLimit";
            this.RD_DragonLVLimit.Size = new System.Drawing.Size(38, 20);
            this.RD_DragonLVLimit.TabIndex = 39;
            this.RD_DragonLVLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonLVLimit.ValueChanged += new System.EventHandler(this.RD_DragonLVLimit_ValueChanged);
            // 
            // RD_DragonHPLimit
            // 
            this.RD_DragonHPLimit.Location = new System.Drawing.Point(156, 71);
            this.RD_DragonHPLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonHPLimit.Name = "RD_DragonHPLimit";
            this.RD_DragonHPLimit.Size = new System.Drawing.Size(38, 20);
            this.RD_DragonHPLimit.TabIndex = 38;
            this.RD_DragonHPLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonHPLimit.ValueChanged += new System.EventHandler(this.RD_DragonHPLimit_ValueChanged);
            // 
            // RD_LevelCheckBox
            // 
            this.RD_LevelCheckBox.AutoSize = true;
            this.RD_LevelCheckBox.Location = new System.Drawing.Point(6, 46);
            this.RD_LevelCheckBox.Name = "RD_LevelCheckBox";
            this.RD_LevelCheckBox.Size = new System.Drawing.Size(67, 17);
            this.RD_LevelCheckBox.TabIndex = 34;
            this.RD_LevelCheckBox.Text = "Level >=";
            this.RD_LevelCheckBox.UseVisualStyleBackColor = true;
            this.RD_LevelCheckBox.CheckedChanged += new System.EventHandler(this.RD_LevelCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "% HP >=";
            // 
            // RD_DragonLV
            // 
            this.RD_DragonLV.Location = new System.Drawing.Point(89, 42);
            this.RD_DragonLV.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.RD_DragonLV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonLV.Name = "RD_DragonLV";
            this.RD_DragonLV.Size = new System.Drawing.Size(38, 20);
            this.RD_DragonLV.TabIndex = 35;
            this.RD_DragonLV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonLV.ValueChanged += new System.EventHandler(this.RD_DragonLV_ValueChanged);
            // 
            // RD_DragonHP
            // 
            this.RD_DragonHP.Location = new System.Drawing.Point(91, 71);
            this.RD_DragonHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonHP.Name = "RD_DragonHP";
            this.RD_DragonHP.Size = new System.Drawing.Size(38, 20);
            this.RD_DragonHP.TabIndex = 36;
            this.RD_DragonHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonHP.ValueChanged += new System.EventHandler(this.RD_DragonHP_ValueChanged);
            // 
            // RD_leaderComboBox
            // 
            this.RD_leaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RD_leaderComboBox.Enabled = false;
            this.RD_leaderComboBox.FormattingEnabled = true;
            this.RD_leaderComboBox.Items.AddRange(new object[] {
            "Universal",
            "Defensive",
            "Offensive",
            "Support",
            "Magic"});
            this.RD_leaderComboBox.Location = new System.Drawing.Point(384, 353);
            this.RD_leaderComboBox.Name = "RD_leaderComboBox";
            this.RD_leaderComboBox.Size = new System.Drawing.Size(46, 21);
            this.RD_leaderComboBox.TabIndex = 16;
            this.RD_leaderComboBox.Tag = "3";
            this.RD_leaderComboBox.Visible = false;
            this.RD_leaderComboBox.SelectedIndexChanged += new System.EventHandler(this.masteryComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(332, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Leader";
            this.label2.Visible = false;
            // 
            // SP_skillGroupBox
            // 
            this.SP_skillGroupBox.Controls.Add(this.SP_wave3Panel);
            this.SP_skillGroupBox.Controls.Add(this.SP_bothSkillRadio);
            this.SP_skillGroupBox.Controls.Add(this.SP_wave2Panel);
            this.SP_skillGroupBox.Controls.Add(this.SP_manualSkillRadio);
            this.SP_skillGroupBox.Controls.Add(this.SP_autoSkillRadio);
            this.SP_skillGroupBox.Controls.Add(this.SP_wave1Panel);
            this.SP_skillGroupBox.Enabled = false;
            this.SP_skillGroupBox.Location = new System.Drawing.Point(222, 6);
            this.SP_skillGroupBox.Name = "SP_skillGroupBox";
            this.SP_skillGroupBox.Size = new System.Drawing.Size(254, 335);
            this.SP_skillGroupBox.TabIndex = 40;
            this.SP_skillGroupBox.TabStop = false;
            this.SP_skillGroupBox.Tag = "3";
            this.SP_skillGroupBox.Text = "Skill Management";
            // 
            // SP_wave3Panel
            // 
            this.SP_wave3Panel.Controls.Add(this.SP_w3bothSkillRadio);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill11Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3manualSkillRadio);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill12Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3autoSkillRadio);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill13Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill14Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill15Button);
            this.SP_wave3Panel.Controls.Add(this.SP_wave3LoopCheckBox);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill10Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill09Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill08Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill07Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill06Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill05Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill04Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill03Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill02Button);
            this.SP_wave3Panel.Controls.Add(this.SP_wave3Label);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill01Button);
            this.SP_wave3Panel.Location = new System.Drawing.Point(9, 229);
            this.SP_wave3Panel.Name = "SP_wave3Panel";
            this.SP_wave3Panel.Size = new System.Drawing.Size(241, 102);
            this.SP_wave3Panel.TabIndex = 13;
            this.SP_wave3Panel.Tag = "9";
            // 
            // SP_w3bothSkillRadio
            // 
            this.SP_w3bothSkillRadio.AutoSize = true;
            this.SP_w3bothSkillRadio.Location = new System.Drawing.Point(192, 3);
            this.SP_w3bothSkillRadio.Name = "SP_w3bothSkillRadio";
            this.SP_w3bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.SP_w3bothSkillRadio.TabIndex = 31;
            this.SP_w3bothSkillRadio.Text = "Both";
            this.SP_w3bothSkillRadio.UseVisualStyleBackColor = true;
            this.SP_w3bothSkillRadio.CheckedChanged += new System.EventHandler(this.SP_w3bothSkillRadio_CheckedChanged);
            // 
            // SP_w3Skill11Button
            // 
            this.SP_w3Skill11Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w3Skill11Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w3Skill11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill11Button.Location = new System.Drawing.Point(78, 23);
            this.SP_w3Skill11Button.Name = "SP_w3Skill11Button";
            this.SP_w3Skill11Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill11Button.TabIndex = 26;
            this.SP_w3Skill11Button.Tag = "10";
            this.SP_w3Skill11Button.UseVisualStyleBackColor = false;
            this.SP_w3Skill11Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3manualSkillRadio
            // 
            this.SP_w3manualSkillRadio.AutoSize = true;
            this.SP_w3manualSkillRadio.Location = new System.Drawing.Point(129, 3);
            this.SP_w3manualSkillRadio.Name = "SP_w3manualSkillRadio";
            this.SP_w3manualSkillRadio.Size = new System.Drawing.Size(60, 17);
            this.SP_w3manualSkillRadio.TabIndex = 31;
            this.SP_w3manualSkillRadio.Text = "Manual";
            this.SP_w3manualSkillRadio.UseVisualStyleBackColor = true;
            this.SP_w3manualSkillRadio.CheckedChanged += new System.EventHandler(this.SP_w3manualSkillRadio_CheckedChanged);
            // 
            // SP_w3Skill12Button
            // 
            this.SP_w3Skill12Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w3Skill12Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w3Skill12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill12Button.Location = new System.Drawing.Point(110, 23);
            this.SP_w3Skill12Button.Name = "SP_w3Skill12Button";
            this.SP_w3Skill12Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill12Button.TabIndex = 27;
            this.SP_w3Skill12Button.Tag = "11";
            this.SP_w3Skill12Button.UseVisualStyleBackColor = false;
            this.SP_w3Skill12Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3autoSkillRadio
            // 
            this.SP_w3autoSkillRadio.AutoSize = true;
            this.SP_w3autoSkillRadio.Checked = true;
            this.SP_w3autoSkillRadio.Location = new System.Drawing.Point(78, 3);
            this.SP_w3autoSkillRadio.Name = "SP_w3autoSkillRadio";
            this.SP_w3autoSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.SP_w3autoSkillRadio.TabIndex = 31;
            this.SP_w3autoSkillRadio.TabStop = true;
            this.SP_w3autoSkillRadio.Text = "Auto";
            this.SP_w3autoSkillRadio.UseVisualStyleBackColor = true;
            this.SP_w3autoSkillRadio.CheckedChanged += new System.EventHandler(this.SP_w3autoSkillRadio_CheckedChanged);
            // 
            // SP_w3Skill13Button
            // 
            this.SP_w3Skill13Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w3Skill13Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w3Skill13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill13Button.Location = new System.Drawing.Point(142, 23);
            this.SP_w3Skill13Button.Name = "SP_w3Skill13Button";
            this.SP_w3Skill13Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill13Button.TabIndex = 28;
            this.SP_w3Skill13Button.Tag = "12";
            this.SP_w3Skill13Button.UseVisualStyleBackColor = false;
            this.SP_w3Skill13Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill14Button
            // 
            this.SP_w3Skill14Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w3Skill14Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w3Skill14Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill14Button.Location = new System.Drawing.Point(174, 23);
            this.SP_w3Skill14Button.Name = "SP_w3Skill14Button";
            this.SP_w3Skill14Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill14Button.TabIndex = 29;
            this.SP_w3Skill14Button.Tag = "13";
            this.SP_w3Skill14Button.UseVisualStyleBackColor = false;
            this.SP_w3Skill14Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill15Button
            // 
            this.SP_w3Skill15Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w3Skill15Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w3Skill15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill15Button.Location = new System.Drawing.Point(206, 23);
            this.SP_w3Skill15Button.Name = "SP_w3Skill15Button";
            this.SP_w3Skill15Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill15Button.TabIndex = 30;
            this.SP_w3Skill15Button.Tag = "14";
            this.SP_w3Skill15Button.UseVisualStyleBackColor = false;
            this.SP_w3Skill15Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_wave3LoopCheckBox
            // 
            this.SP_wave3LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SP_wave3LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_wave3LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.SP_wave3LoopCheckBox.Name = "SP_wave3LoopCheckBox";
            this.SP_wave3LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.SP_wave3LoopCheckBox.TabIndex = 24;
            this.SP_wave3LoopCheckBox.Text = "Loop";
            this.SP_wave3LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SP_wave3LoopCheckBox.UseVisualStyleBackColor = true;
            this.SP_wave3LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // SP_w3Skill10Button
            // 
            this.SP_w3Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill10Button.Location = new System.Drawing.Point(206, 75);
            this.SP_w3Skill10Button.Name = "SP_w3Skill10Button";
            this.SP_w3Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill10Button.TabIndex = 10;
            this.SP_w3Skill10Button.Tag = "9";
            this.SP_w3Skill10Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill09Button
            // 
            this.SP_w3Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill09Button.Location = new System.Drawing.Point(174, 75);
            this.SP_w3Skill09Button.Name = "SP_w3Skill09Button";
            this.SP_w3Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill09Button.TabIndex = 9;
            this.SP_w3Skill09Button.Tag = "8";
            this.SP_w3Skill09Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill08Button
            // 
            this.SP_w3Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill08Button.Location = new System.Drawing.Point(142, 75);
            this.SP_w3Skill08Button.Name = "SP_w3Skill08Button";
            this.SP_w3Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill08Button.TabIndex = 8;
            this.SP_w3Skill08Button.Tag = "7";
            this.SP_w3Skill08Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill07Button
            // 
            this.SP_w3Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill07Button.Location = new System.Drawing.Point(110, 75);
            this.SP_w3Skill07Button.Name = "SP_w3Skill07Button";
            this.SP_w3Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill07Button.TabIndex = 7;
            this.SP_w3Skill07Button.Tag = "6";
            this.SP_w3Skill07Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill06Button
            // 
            this.SP_w3Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill06Button.Location = new System.Drawing.Point(78, 75);
            this.SP_w3Skill06Button.Name = "SP_w3Skill06Button";
            this.SP_w3Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill06Button.TabIndex = 6;
            this.SP_w3Skill06Button.Tag = "s";
            this.SP_w3Skill06Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill05Button
            // 
            this.SP_w3Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill05Button.Location = new System.Drawing.Point(206, 51);
            this.SP_w3Skill05Button.Name = "SP_w3Skill05Button";
            this.SP_w3Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill05Button.TabIndex = 5;
            this.SP_w3Skill05Button.Tag = "4";
            this.SP_w3Skill05Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill04Button
            // 
            this.SP_w3Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill04Button.Location = new System.Drawing.Point(174, 51);
            this.SP_w3Skill04Button.Name = "SP_w3Skill04Button";
            this.SP_w3Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill04Button.TabIndex = 4;
            this.SP_w3Skill04Button.Tag = "3";
            this.SP_w3Skill04Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill03Button
            // 
            this.SP_w3Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill03Button.Location = new System.Drawing.Point(142, 51);
            this.SP_w3Skill03Button.Name = "SP_w3Skill03Button";
            this.SP_w3Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill03Button.TabIndex = 3;
            this.SP_w3Skill03Button.Tag = "2";
            this.SP_w3Skill03Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill02Button
            // 
            this.SP_w3Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill02Button.Location = new System.Drawing.Point(110, 51);
            this.SP_w3Skill02Button.Name = "SP_w3Skill02Button";
            this.SP_w3Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill02Button.TabIndex = 2;
            this.SP_w3Skill02Button.Tag = "1";
            this.SP_w3Skill02Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_wave3Label
            // 
            this.SP_wave3Label.Location = new System.Drawing.Point(6, 7);
            this.SP_wave3Label.Name = "SP_wave3Label";
            this.SP_wave3Label.Size = new System.Drawing.Size(60, 13);
            this.SP_wave3Label.TabIndex = 0;
            this.SP_wave3Label.Text = "Wave 3";
            // 
            // SP_w3Skill01Button
            // 
            this.SP_w3Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill01Button.Location = new System.Drawing.Point(78, 51);
            this.SP_w3Skill01Button.Name = "SP_w3Skill01Button";
            this.SP_w3Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill01Button.TabIndex = 1;
            this.SP_w3Skill01Button.Tag = "0";
            this.SP_w3Skill01Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_bothSkillRadio
            // 
            this.SP_bothSkillRadio.AutoSize = true;
            this.SP_bothSkillRadio.Location = new System.Drawing.Point(200, 14);
            this.SP_bothSkillRadio.Name = "SP_bothSkillRadio";
            this.SP_bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.SP_bothSkillRadio.TabIndex = 7;
            this.SP_bothSkillRadio.Tag = "2";
            this.SP_bothSkillRadio.Text = "Both";
            this.SP_bothSkillRadio.UseVisualStyleBackColor = true;
            this.SP_bothSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // SP_wave2Panel
            // 
            this.SP_wave2Panel.Controls.Add(this.SP_w2bothSkillRadio);
            this.SP_wave2Panel.Controls.Add(this.SP_w2manualSkillRadio);
            this.SP_wave2Panel.Controls.Add(this.SP_w2autoSkillRadio);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill11Button);
            this.SP_wave2Panel.Controls.Add(this.SP_wave2LoopCheckBox);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill12Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill10Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill13Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill09Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill14Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill08Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill15Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill07Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill06Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill05Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill04Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill03Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill02Button);
            this.SP_wave2Panel.Controls.Add(this.SP_wave2Label);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill01Button);
            this.SP_wave2Panel.Location = new System.Drawing.Point(9, 121);
            this.SP_wave2Panel.Name = "SP_wave2Panel";
            this.SP_wave2Panel.Size = new System.Drawing.Size(241, 102);
            this.SP_wave2Panel.TabIndex = 9;
            this.SP_wave2Panel.Tag = "8";
            // 
            // SP_w2bothSkillRadio
            // 
            this.SP_w2bothSkillRadio.AutoSize = true;
            this.SP_w2bothSkillRadio.Location = new System.Drawing.Point(192, 3);
            this.SP_w2bothSkillRadio.Name = "SP_w2bothSkillRadio";
            this.SP_w2bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.SP_w2bothSkillRadio.TabIndex = 31;
            this.SP_w2bothSkillRadio.Text = "Both";
            this.SP_w2bothSkillRadio.UseVisualStyleBackColor = true;
            this.SP_w2bothSkillRadio.CheckedChanged += new System.EventHandler(this.SP_w2bothSkillRadio_CheckedChanged);
            // 
            // SP_w2manualSkillRadio
            // 
            this.SP_w2manualSkillRadio.AutoSize = true;
            this.SP_w2manualSkillRadio.Location = new System.Drawing.Point(129, 3);
            this.SP_w2manualSkillRadio.Name = "SP_w2manualSkillRadio";
            this.SP_w2manualSkillRadio.Size = new System.Drawing.Size(60, 17);
            this.SP_w2manualSkillRadio.TabIndex = 31;
            this.SP_w2manualSkillRadio.Text = "Manual";
            this.SP_w2manualSkillRadio.UseVisualStyleBackColor = true;
            this.SP_w2manualSkillRadio.CheckedChanged += new System.EventHandler(this.SP_w2manualSkillRadio_CheckedChanged);
            // 
            // SP_w2autoSkillRadio
            // 
            this.SP_w2autoSkillRadio.AutoSize = true;
            this.SP_w2autoSkillRadio.Checked = true;
            this.SP_w2autoSkillRadio.Location = new System.Drawing.Point(78, 3);
            this.SP_w2autoSkillRadio.Name = "SP_w2autoSkillRadio";
            this.SP_w2autoSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.SP_w2autoSkillRadio.TabIndex = 31;
            this.SP_w2autoSkillRadio.TabStop = true;
            this.SP_w2autoSkillRadio.Text = "Auto";
            this.SP_w2autoSkillRadio.UseVisualStyleBackColor = true;
            this.SP_w2autoSkillRadio.CheckedChanged += new System.EventHandler(this.SP_w2autoSkillRadio_CheckedChanged);
            // 
            // SP_w2Skill11Button
            // 
            this.SP_w2Skill11Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w2Skill11Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w2Skill11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill11Button.Location = new System.Drawing.Point(78, 24);
            this.SP_w2Skill11Button.Name = "SP_w2Skill11Button";
            this.SP_w2Skill11Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill11Button.TabIndex = 26;
            this.SP_w2Skill11Button.Tag = "10";
            this.SP_w2Skill11Button.UseVisualStyleBackColor = false;
            this.SP_w2Skill11Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_wave2LoopCheckBox
            // 
            this.SP_wave2LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SP_wave2LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_wave2LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.SP_wave2LoopCheckBox.Name = "SP_wave2LoopCheckBox";
            this.SP_wave2LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.SP_wave2LoopCheckBox.TabIndex = 12;
            this.SP_wave2LoopCheckBox.Text = "Loop";
            this.SP_wave2LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SP_wave2LoopCheckBox.UseVisualStyleBackColor = true;
            this.SP_wave2LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // SP_w2Skill12Button
            // 
            this.SP_w2Skill12Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w2Skill12Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w2Skill12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill12Button.Location = new System.Drawing.Point(110, 24);
            this.SP_w2Skill12Button.Name = "SP_w2Skill12Button";
            this.SP_w2Skill12Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill12Button.TabIndex = 27;
            this.SP_w2Skill12Button.Tag = "11";
            this.SP_w2Skill12Button.UseVisualStyleBackColor = false;
            this.SP_w2Skill12Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill10Button
            // 
            this.SP_w2Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill10Button.Location = new System.Drawing.Point(206, 76);
            this.SP_w2Skill10Button.Name = "SP_w2Skill10Button";
            this.SP_w2Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill10Button.TabIndex = 10;
            this.SP_w2Skill10Button.Tag = "9";
            this.SP_w2Skill10Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill13Button
            // 
            this.SP_w2Skill13Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w2Skill13Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w2Skill13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill13Button.Location = new System.Drawing.Point(142, 24);
            this.SP_w2Skill13Button.Name = "SP_w2Skill13Button";
            this.SP_w2Skill13Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill13Button.TabIndex = 28;
            this.SP_w2Skill13Button.Tag = "12";
            this.SP_w2Skill13Button.UseVisualStyleBackColor = false;
            this.SP_w2Skill13Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill09Button
            // 
            this.SP_w2Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill09Button.Location = new System.Drawing.Point(174, 76);
            this.SP_w2Skill09Button.Name = "SP_w2Skill09Button";
            this.SP_w2Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill09Button.TabIndex = 9;
            this.SP_w2Skill09Button.Tag = "8";
            this.SP_w2Skill09Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill14Button
            // 
            this.SP_w2Skill14Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w2Skill14Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w2Skill14Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill14Button.Location = new System.Drawing.Point(174, 24);
            this.SP_w2Skill14Button.Name = "SP_w2Skill14Button";
            this.SP_w2Skill14Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill14Button.TabIndex = 29;
            this.SP_w2Skill14Button.Tag = "13";
            this.SP_w2Skill14Button.UseVisualStyleBackColor = false;
            this.SP_w2Skill14Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill08Button
            // 
            this.SP_w2Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill08Button.Location = new System.Drawing.Point(142, 76);
            this.SP_w2Skill08Button.Name = "SP_w2Skill08Button";
            this.SP_w2Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill08Button.TabIndex = 8;
            this.SP_w2Skill08Button.Tag = "7";
            this.SP_w2Skill08Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill15Button
            // 
            this.SP_w2Skill15Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w2Skill15Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w2Skill15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill15Button.Location = new System.Drawing.Point(206, 24);
            this.SP_w2Skill15Button.Name = "SP_w2Skill15Button";
            this.SP_w2Skill15Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill15Button.TabIndex = 30;
            this.SP_w2Skill15Button.Tag = "14";
            this.SP_w2Skill15Button.UseVisualStyleBackColor = false;
            this.SP_w2Skill15Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill07Button
            // 
            this.SP_w2Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill07Button.Location = new System.Drawing.Point(110, 76);
            this.SP_w2Skill07Button.Name = "SP_w2Skill07Button";
            this.SP_w2Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill07Button.TabIndex = 7;
            this.SP_w2Skill07Button.Tag = "6";
            this.SP_w2Skill07Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill06Button
            // 
            this.SP_w2Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill06Button.Location = new System.Drawing.Point(78, 76);
            this.SP_w2Skill06Button.Name = "SP_w2Skill06Button";
            this.SP_w2Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill06Button.TabIndex = 6;
            this.SP_w2Skill06Button.Tag = "15";
            this.SP_w2Skill06Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill05Button
            // 
            this.SP_w2Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill05Button.Location = new System.Drawing.Point(206, 52);
            this.SP_w2Skill05Button.Name = "SP_w2Skill05Button";
            this.SP_w2Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill05Button.TabIndex = 5;
            this.SP_w2Skill05Button.Tag = "4";
            this.SP_w2Skill05Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill04Button
            // 
            this.SP_w2Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill04Button.Location = new System.Drawing.Point(174, 52);
            this.SP_w2Skill04Button.Name = "SP_w2Skill04Button";
            this.SP_w2Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill04Button.TabIndex = 4;
            this.SP_w2Skill04Button.Tag = "3";
            this.SP_w2Skill04Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill03Button
            // 
            this.SP_w2Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill03Button.Location = new System.Drawing.Point(142, 52);
            this.SP_w2Skill03Button.Name = "SP_w2Skill03Button";
            this.SP_w2Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill03Button.TabIndex = 3;
            this.SP_w2Skill03Button.Tag = "2";
            this.SP_w2Skill03Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill02Button
            // 
            this.SP_w2Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill02Button.Location = new System.Drawing.Point(110, 52);
            this.SP_w2Skill02Button.Name = "SP_w2Skill02Button";
            this.SP_w2Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill02Button.TabIndex = 2;
            this.SP_w2Skill02Button.Tag = "1";
            this.SP_w2Skill02Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_wave2Label
            // 
            this.SP_wave2Label.Location = new System.Drawing.Point(6, 7);
            this.SP_wave2Label.Name = "SP_wave2Label";
            this.SP_wave2Label.Size = new System.Drawing.Size(60, 13);
            this.SP_wave2Label.TabIndex = 0;
            this.SP_wave2Label.Text = "Wave 2";
            // 
            // SP_w2Skill01Button
            // 
            this.SP_w2Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill01Button.Location = new System.Drawing.Point(78, 52);
            this.SP_w2Skill01Button.Name = "SP_w2Skill01Button";
            this.SP_w2Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill01Button.TabIndex = 1;
            this.SP_w2Skill01Button.Tag = "0";
            this.SP_w2Skill01Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_manualSkillRadio
            // 
            this.SP_manualSkillRadio.AutoSize = true;
            this.SP_manualSkillRadio.Location = new System.Drawing.Point(138, 14);
            this.SP_manualSkillRadio.Name = "SP_manualSkillRadio";
            this.SP_manualSkillRadio.Size = new System.Drawing.Size(60, 17);
            this.SP_manualSkillRadio.TabIndex = 6;
            this.SP_manualSkillRadio.Tag = "1";
            this.SP_manualSkillRadio.Text = "Manual";
            this.SP_manualSkillRadio.UseVisualStyleBackColor = true;
            this.SP_manualSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // SP_autoSkillRadio
            // 
            this.SP_autoSkillRadio.AutoSize = true;
            this.SP_autoSkillRadio.Checked = true;
            this.SP_autoSkillRadio.Location = new System.Drawing.Point(86, 14);
            this.SP_autoSkillRadio.Name = "SP_autoSkillRadio";
            this.SP_autoSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.SP_autoSkillRadio.TabIndex = 5;
            this.SP_autoSkillRadio.TabStop = true;
            this.SP_autoSkillRadio.Tag = "0";
            this.SP_autoSkillRadio.Text = "Auto";
            this.SP_autoSkillRadio.UseVisualStyleBackColor = true;
            this.SP_autoSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // SP_wave1Panel
            // 
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill11Button);
            this.SP_wave1Panel.Controls.Add(this.SP_wave1LoopCheckBox);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill10Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill12Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill09Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill08Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill13Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill07Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill06Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill14Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill05Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill04Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill15Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill03Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill02Button);
            this.SP_wave1Panel.Controls.Add(this.SP_wave1Label);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill01Button);
            this.SP_wave1Panel.Location = new System.Drawing.Point(9, 34);
            this.SP_wave1Panel.Name = "SP_wave1Panel";
            this.SP_wave1Panel.Size = new System.Drawing.Size(241, 82);
            this.SP_wave1Panel.TabIndex = 8;
            this.SP_wave1Panel.Tag = "7";
            // 
            // SP_w1Skill11Button
            // 
            this.SP_w1Skill11Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w1Skill11Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w1Skill11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill11Button.Location = new System.Drawing.Point(78, 4);
            this.SP_w1Skill11Button.Name = "SP_w1Skill11Button";
            this.SP_w1Skill11Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill11Button.TabIndex = 26;
            this.SP_w1Skill11Button.Tag = "10";
            this.SP_w1Skill11Button.UseVisualStyleBackColor = false;
            this.SP_w1Skill11Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_wave1LoopCheckBox
            // 
            this.SP_wave1LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SP_wave1LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_wave1LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.SP_wave1LoopCheckBox.Name = "SP_wave1LoopCheckBox";
            this.SP_wave1LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.SP_wave1LoopCheckBox.TabIndex = 12;
            this.SP_wave1LoopCheckBox.Text = "Loop";
            this.SP_wave1LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SP_wave1LoopCheckBox.UseVisualStyleBackColor = true;
            this.SP_wave1LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // SP_w1Skill10Button
            // 
            this.SP_w1Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill10Button.Location = new System.Drawing.Point(206, 56);
            this.SP_w1Skill10Button.Name = "SP_w1Skill10Button";
            this.SP_w1Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill10Button.TabIndex = 10;
            this.SP_w1Skill10Button.Tag = "9";
            this.SP_w1Skill10Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill12Button
            // 
            this.SP_w1Skill12Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w1Skill12Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w1Skill12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill12Button.Location = new System.Drawing.Point(110, 4);
            this.SP_w1Skill12Button.Name = "SP_w1Skill12Button";
            this.SP_w1Skill12Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill12Button.TabIndex = 27;
            this.SP_w1Skill12Button.Tag = "11";
            this.SP_w1Skill12Button.UseVisualStyleBackColor = false;
            this.SP_w1Skill12Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill09Button
            // 
            this.SP_w1Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill09Button.Location = new System.Drawing.Point(174, 56);
            this.SP_w1Skill09Button.Name = "SP_w1Skill09Button";
            this.SP_w1Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill09Button.TabIndex = 9;
            this.SP_w1Skill09Button.Tag = "8";
            this.SP_w1Skill09Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill08Button
            // 
            this.SP_w1Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill08Button.Location = new System.Drawing.Point(142, 56);
            this.SP_w1Skill08Button.Name = "SP_w1Skill08Button";
            this.SP_w1Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill08Button.TabIndex = 8;
            this.SP_w1Skill08Button.Tag = "7";
            this.SP_w1Skill08Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill13Button
            // 
            this.SP_w1Skill13Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w1Skill13Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w1Skill13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill13Button.Location = new System.Drawing.Point(142, 4);
            this.SP_w1Skill13Button.Name = "SP_w1Skill13Button";
            this.SP_w1Skill13Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill13Button.TabIndex = 28;
            this.SP_w1Skill13Button.Tag = "12";
            this.SP_w1Skill13Button.UseVisualStyleBackColor = false;
            this.SP_w1Skill13Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill07Button
            // 
            this.SP_w1Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill07Button.Location = new System.Drawing.Point(110, 56);
            this.SP_w1Skill07Button.Name = "SP_w1Skill07Button";
            this.SP_w1Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill07Button.TabIndex = 7;
            this.SP_w1Skill07Button.Tag = "6";
            this.SP_w1Skill07Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill06Button
            // 
            this.SP_w1Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill06Button.Location = new System.Drawing.Point(78, 56);
            this.SP_w1Skill06Button.Name = "SP_w1Skill06Button";
            this.SP_w1Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill06Button.TabIndex = 6;
            this.SP_w1Skill06Button.Tag = "15";
            this.SP_w1Skill06Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill14Button
            // 
            this.SP_w1Skill14Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w1Skill14Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w1Skill14Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill14Button.Location = new System.Drawing.Point(174, 4);
            this.SP_w1Skill14Button.Name = "SP_w1Skill14Button";
            this.SP_w1Skill14Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill14Button.TabIndex = 29;
            this.SP_w1Skill14Button.Tag = "13";
            this.SP_w1Skill14Button.UseVisualStyleBackColor = false;
            this.SP_w1Skill14Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill05Button
            // 
            this.SP_w1Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill05Button.Location = new System.Drawing.Point(206, 32);
            this.SP_w1Skill05Button.Name = "SP_w1Skill05Button";
            this.SP_w1Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill05Button.TabIndex = 5;
            this.SP_w1Skill05Button.Tag = "4";
            this.SP_w1Skill05Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill04Button
            // 
            this.SP_w1Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill04Button.Location = new System.Drawing.Point(174, 32);
            this.SP_w1Skill04Button.Name = "SP_w1Skill04Button";
            this.SP_w1Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill04Button.TabIndex = 4;
            this.SP_w1Skill04Button.Tag = "3";
            this.SP_w1Skill04Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill15Button
            // 
            this.SP_w1Skill15Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w1Skill15Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w1Skill15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill15Button.Location = new System.Drawing.Point(206, 4);
            this.SP_w1Skill15Button.Name = "SP_w1Skill15Button";
            this.SP_w1Skill15Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill15Button.TabIndex = 30;
            this.SP_w1Skill15Button.Tag = "14";
            this.SP_w1Skill15Button.UseVisualStyleBackColor = false;
            this.SP_w1Skill15Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill03Button
            // 
            this.SP_w1Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill03Button.Location = new System.Drawing.Point(142, 32);
            this.SP_w1Skill03Button.Name = "SP_w1Skill03Button";
            this.SP_w1Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill03Button.TabIndex = 3;
            this.SP_w1Skill03Button.Tag = "2";
            this.SP_w1Skill03Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill02Button
            // 
            this.SP_w1Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill02Button.Location = new System.Drawing.Point(110, 32);
            this.SP_w1Skill02Button.Name = "SP_w1Skill02Button";
            this.SP_w1Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill02Button.TabIndex = 2;
            this.SP_w1Skill02Button.Tag = "1";
            this.SP_w1Skill02Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_wave1Label
            // 
            this.SP_wave1Label.Location = new System.Drawing.Point(6, 7);
            this.SP_wave1Label.Name = "SP_wave1Label";
            this.SP_wave1Label.Size = new System.Drawing.Size(60, 13);
            this.SP_wave1Label.TabIndex = 0;
            this.SP_wave1Label.Text = "Wave 1";
            // 
            // SP_w1Skill01Button
            // 
            this.SP_w1Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill01Button.Location = new System.Drawing.Point(78, 32);
            this.SP_w1Skill01Button.Name = "SP_w1Skill01Button";
            this.SP_w1Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill01Button.TabIndex = 1;
            this.SP_w1Skill01Button.Tag = "0";
            this.SP_w1Skill01Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // evanGroupBox
            // 
            this.evanGroupBox.Controls.Add(this.SP_UseTicket1);
            this.evanGroupBox.Controls.Add(this.label8);
            this.evanGroupBox.Controls.Add(this.SP_evanCheckBox);
            this.evanGroupBox.Controls.Add(this.SP_evanLimitNumericBox);
            this.evanGroupBox.Controls.Add(this.SP_evanHardRadioButton);
            this.evanGroupBox.Controls.Add(this.label11);
            this.evanGroupBox.Controls.Add(this.SP_evanNorRadioButton);
            this.evanGroupBox.Enabled = false;
            this.evanGroupBox.Location = new System.Drawing.Point(3, 30);
            this.evanGroupBox.Name = "evanGroupBox";
            this.evanGroupBox.Size = new System.Drawing.Size(213, 83);
            this.evanGroupBox.TabIndex = 39;
            this.evanGroupBox.TabStop = false;
            // 
            // SP_UseTicket1
            // 
            this.SP_UseTicket1.AutoSize = true;
            this.SP_UseTicket1.Location = new System.Drawing.Point(24, 49);
            this.SP_UseTicket1.Name = "SP_UseTicket1";
            this.SP_UseTicket1.Size = new System.Drawing.Size(78, 17);
            this.SP_UseTicket1.TabIndex = 38;
            this.SP_UseTicket1.Text = "Use Ticket";
            this.SP_UseTicket1.UseVisualStyleBackColor = true;
            this.SP_UseTicket1.CheckedChanged += new System.EventHandler(this.SP_UseTicket1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(21, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Difficulty";
            // 
            // SP_evanCheckBox
            // 
            this.SP_evanCheckBox.AutoSize = true;
            this.SP_evanCheckBox.Location = new System.Drawing.Point(10, -1);
            this.SP_evanCheckBox.Name = "SP_evanCheckBox";
            this.SP_evanCheckBox.Size = new System.Drawing.Size(108, 17);
            this.SP_evanCheckBox.TabIndex = 33;
            this.SP_evanCheckBox.Tag = "3";
            this.SP_evanCheckBox.Text = "Winter Nightmare";
            this.SP_evanCheckBox.UseVisualStyleBackColor = true;
            this.SP_evanCheckBox.CheckedChanged += new System.EventHandler(this.spEnableCheckBox_CheckedChanged);
            // 
            // SP_evanLimitNumericBox
            // 
            this.SP_evanLimitNumericBox.Location = new System.Drawing.Point(131, 0);
            this.SP_evanLimitNumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SP_evanLimitNumericBox.Name = "SP_evanLimitNumericBox";
            this.SP_evanLimitNumericBox.Size = new System.Drawing.Size(41, 20);
            this.SP_evanLimitNumericBox.TabIndex = 35;
            this.SP_evanLimitNumericBox.Tag = "3";
            this.SP_evanLimitNumericBox.ValueChanged += new System.EventHandler(this.splimitNumericBox_ValueChanged);
            // 
            // SP_evanHardRadioButton
            // 
            this.SP_evanHardRadioButton.AutoSize = true;
            this.SP_evanHardRadioButton.Location = new System.Drawing.Point(149, 23);
            this.SP_evanHardRadioButton.Name = "SP_evanHardRadioButton";
            this.SP_evanHardRadioButton.Size = new System.Drawing.Size(58, 17);
            this.SP_evanHardRadioButton.TabIndex = 1;
            this.SP_evanHardRadioButton.Tag = "1";
            this.SP_evanHardRadioButton.Text = "Normal";
            this.SP_evanHardRadioButton.UseVisualStyleBackColor = true;
            this.SP_evanHardRadioButton.CheckedChanged += new System.EventHandler(this.SP_evanRadioButton_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "times";
            // 
            // SP_evanNorRadioButton
            // 
            this.SP_evanNorRadioButton.AutoSize = true;
            this.SP_evanNorRadioButton.Checked = true;
            this.SP_evanNorRadioButton.Location = new System.Drawing.Point(78, 23);
            this.SP_evanNorRadioButton.Name = "SP_evanNorRadioButton";
            this.SP_evanNorRadioButton.Size = new System.Drawing.Size(48, 17);
            this.SP_evanNorRadioButton.TabIndex = 2;
            this.SP_evanNorRadioButton.TabStop = true;
            this.SP_evanNorRadioButton.Tag = "0";
            this.SP_evanNorRadioButton.Text = "Easy";
            this.SP_evanNorRadioButton.UseVisualStyleBackColor = true;
            this.SP_evanNorRadioButton.CheckedChanged += new System.EventHandler(this.SP_evanRadioButton_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(13, 6);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 17);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Tag = "4";
            this.checkBox3.Text = "Enable Dungeon";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // RS_collectQuestsGroupBox
            // 
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsSocialCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsItemCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsHeroCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsBattleCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_specialQuestsMonthlyCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_specialQuestsWeeklyCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_specialQuestsDailyCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsNormalLabel);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsSpecialLabel);
            this.RS_collectQuestsGroupBox.Location = new System.Drawing.Point(9, 165);
            this.RS_collectQuestsGroupBox.Name = "RS_collectQuestsGroupBox";
            this.RS_collectQuestsGroupBox.Size = new System.Drawing.Size(485, 96);
            this.RS_collectQuestsGroupBox.TabIndex = 3;
            this.RS_collectQuestsGroupBox.TabStop = false;
            this.RS_collectQuestsGroupBox.Text = "Collect Quests";
            // 
            // RS_questsSocialCheckBox
            // 
            this.RS_questsSocialCheckBox.AutoSize = true;
            this.RS_questsSocialCheckBox.Location = new System.Drawing.Point(406, 57);
            this.RS_questsSocialCheckBox.Name = "RS_questsSocialCheckBox";
            this.RS_questsSocialCheckBox.Size = new System.Drawing.Size(55, 17);
            this.RS_questsSocialCheckBox.TabIndex = 8;
            this.RS_questsSocialCheckBox.Tag = "6";
            this.RS_questsSocialCheckBox.Text = "Social";
            this.RS_questsSocialCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsSocialCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsItemCheckBox
            // 
            this.RS_questsItemCheckBox.AutoSize = true;
            this.RS_questsItemCheckBox.Location = new System.Drawing.Point(294, 58);
            this.RS_questsItemCheckBox.Name = "RS_questsItemCheckBox";
            this.RS_questsItemCheckBox.Size = new System.Drawing.Size(46, 17);
            this.RS_questsItemCheckBox.TabIndex = 7;
            this.RS_questsItemCheckBox.Tag = "5";
            this.RS_questsItemCheckBox.Text = "Item";
            this.RS_questsItemCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsItemCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsHeroCheckBox
            // 
            this.RS_questsHeroCheckBox.AutoSize = true;
            this.RS_questsHeroCheckBox.Location = new System.Drawing.Point(170, 54);
            this.RS_questsHeroCheckBox.Name = "RS_questsHeroCheckBox";
            this.RS_questsHeroCheckBox.Size = new System.Drawing.Size(49, 17);
            this.RS_questsHeroCheckBox.TabIndex = 6;
            this.RS_questsHeroCheckBox.Tag = "4";
            this.RS_questsHeroCheckBox.Text = "Hero";
            this.RS_questsHeroCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsHeroCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsBattleCheckBox
            // 
            this.RS_questsBattleCheckBox.AutoSize = true;
            this.RS_questsBattleCheckBox.Location = new System.Drawing.Point(62, 57);
            this.RS_questsBattleCheckBox.Name = "RS_questsBattleCheckBox";
            this.RS_questsBattleCheckBox.Size = new System.Drawing.Size(53, 17);
            this.RS_questsBattleCheckBox.TabIndex = 5;
            this.RS_questsBattleCheckBox.Tag = "3";
            this.RS_questsBattleCheckBox.Text = "Battle";
            this.RS_questsBattleCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsBattleCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_specialQuestsMonthlyCheckBox
            // 
            this.RS_specialQuestsMonthlyCheckBox.AutoSize = true;
            this.RS_specialQuestsMonthlyCheckBox.Location = new System.Drawing.Point(336, 20);
            this.RS_specialQuestsMonthlyCheckBox.Name = "RS_specialQuestsMonthlyCheckBox";
            this.RS_specialQuestsMonthlyCheckBox.Size = new System.Drawing.Size(63, 17);
            this.RS_specialQuestsMonthlyCheckBox.TabIndex = 4;
            this.RS_specialQuestsMonthlyCheckBox.Tag = "2";
            this.RS_specialQuestsMonthlyCheckBox.Text = "Monthly";
            this.RS_specialQuestsMonthlyCheckBox.UseVisualStyleBackColor = true;
            this.RS_specialQuestsMonthlyCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_specialQuestsWeeklyCheckBox
            // 
            this.RS_specialQuestsWeeklyCheckBox.AutoSize = true;
            this.RS_specialQuestsWeeklyCheckBox.Location = new System.Drawing.Point(221, 19);
            this.RS_specialQuestsWeeklyCheckBox.Name = "RS_specialQuestsWeeklyCheckBox";
            this.RS_specialQuestsWeeklyCheckBox.Size = new System.Drawing.Size(62, 17);
            this.RS_specialQuestsWeeklyCheckBox.TabIndex = 3;
            this.RS_specialQuestsWeeklyCheckBox.Tag = "1";
            this.RS_specialQuestsWeeklyCheckBox.Text = "Weekly";
            this.RS_specialQuestsWeeklyCheckBox.UseVisualStyleBackColor = true;
            this.RS_specialQuestsWeeklyCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_specialQuestsDailyCheckBox
            // 
            this.RS_specialQuestsDailyCheckBox.AutoSize = true;
            this.RS_specialQuestsDailyCheckBox.Location = new System.Drawing.Point(119, 20);
            this.RS_specialQuestsDailyCheckBox.Name = "RS_specialQuestsDailyCheckBox";
            this.RS_specialQuestsDailyCheckBox.Size = new System.Drawing.Size(49, 17);
            this.RS_specialQuestsDailyCheckBox.TabIndex = 2;
            this.RS_specialQuestsDailyCheckBox.Tag = "0";
            this.RS_specialQuestsDailyCheckBox.Text = "Daily";
            this.RS_specialQuestsDailyCheckBox.UseVisualStyleBackColor = true;
            this.RS_specialQuestsDailyCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsNormalLabel
            // 
            this.RS_questsNormalLabel.AutoSize = true;
            this.RS_questsNormalLabel.Location = new System.Drawing.Point(7, 58);
            this.RS_questsNormalLabel.Name = "RS_questsNormalLabel";
            this.RS_questsNormalLabel.Size = new System.Drawing.Size(43, 13);
            this.RS_questsNormalLabel.TabIndex = 1;
            this.RS_questsNormalLabel.Text = "Normal:";
            // 
            // RS_questsSpecialLabel
            // 
            this.RS_questsSpecialLabel.AutoSize = true;
            this.RS_questsSpecialLabel.Location = new System.Drawing.Point(7, 20);
            this.RS_questsSpecialLabel.Name = "RS_questsSpecialLabel";
            this.RS_questsSpecialLabel.Size = new System.Drawing.Size(45, 13);
            this.RS_questsSpecialLabel.TabIndex = 0;
            this.RS_questsSpecialLabel.Text = "Special:";
            // 
            // RS_sendHonorsGroupBox
            // 
            this.RS_sendHonorsGroupBox.Controls.Add(this.RS_giftsGroupBox);
            this.RS_sendHonorsGroupBox.Controls.Add(this.RS_sendHonorsInGame);
            this.RS_sendHonorsGroupBox.Controls.Add(this.RS_sendHonorsFacebook);
            this.RS_sendHonorsGroupBox.Location = new System.Drawing.Point(9, 267);
            this.RS_sendHonorsGroupBox.Name = "RS_sendHonorsGroupBox";
            this.RS_sendHonorsGroupBox.Size = new System.Drawing.Size(146, 80);
            this.RS_sendHonorsGroupBox.TabIndex = 4;
            this.RS_sendHonorsGroupBox.TabStop = false;
            this.RS_sendHonorsGroupBox.Text = "Send Honors";
            // 
            // RS_giftsGroupBox
            // 
            this.RS_giftsGroupBox.Controls.Add(this.RS_luckyBoxCheckBox);
            this.RS_giftsGroupBox.Controls.Add(this.RS_luckyChestCheckBox);
            this.RS_giftsGroupBox.Enabled = false;
            this.RS_giftsGroupBox.Location = new System.Drawing.Point(62, 86);
            this.RS_giftsGroupBox.Name = "RS_giftsGroupBox";
            this.RS_giftsGroupBox.Size = new System.Drawing.Size(168, 18);
            this.RS_giftsGroupBox.TabIndex = 2;
            this.RS_giftsGroupBox.TabStop = false;
            this.RS_giftsGroupBox.Text = "Gifts";
            this.RS_giftsGroupBox.Visible = false;
            // 
            // RS_luckyBoxCheckBox
            // 
            this.RS_luckyBoxCheckBox.AutoSize = true;
            this.RS_luckyBoxCheckBox.Location = new System.Drawing.Point(7, 44);
            this.RS_luckyBoxCheckBox.Name = "RS_luckyBoxCheckBox";
            this.RS_luckyBoxCheckBox.Size = new System.Drawing.Size(111, 17);
            this.RS_luckyBoxCheckBox.TabIndex = 1;
            this.RS_luckyBoxCheckBox.Tag = "1";
            this.RS_luckyBoxCheckBox.Text = "Collect Lucky Box";
            this.RS_luckyBoxCheckBox.UseVisualStyleBackColor = true;
            this.RS_luckyBoxCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectGiftCheckBox_CheckedChanged);
            // 
            // RS_luckyChestCheckBox
            // 
            this.RS_luckyChestCheckBox.AutoSize = true;
            this.RS_luckyChestCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RS_luckyChestCheckBox.Name = "RS_luckyChestCheckBox";
            this.RS_luckyChestCheckBox.Size = new System.Drawing.Size(150, 17);
            this.RS_luckyChestCheckBox.TabIndex = 0;
            this.RS_luckyChestCheckBox.Tag = "0";
            this.RS_luckyChestCheckBox.Text = "Collect May\'s Lucky Chest";
            this.RS_luckyChestCheckBox.UseVisualStyleBackColor = true;
            this.RS_luckyChestCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectGiftCheckBox_CheckedChanged);
            // 
            // RS_sendHonorsInGame
            // 
            this.RS_sendHonorsInGame.AutoSize = true;
            this.RS_sendHonorsInGame.Location = new System.Drawing.Point(7, 44);
            this.RS_sendHonorsInGame.Name = "RS_sendHonorsInGame";
            this.RS_sendHonorsInGame.Size = new System.Drawing.Size(119, 17);
            this.RS_sendHonorsInGame.TabIndex = 1;
            this.RS_sendHonorsInGame.Tag = "1";
            this.RS_sendHonorsInGame.Text = "To In-Game Friends";
            this.toolTip.SetToolTip(this.RS_sendHonorsInGame, "BETA Function");
            this.RS_sendHonorsInGame.UseVisualStyleBackColor = true;
            this.RS_sendHonorsInGame.CheckedChanged += new System.EventHandler(this.RS_sendHonorsCheckBox_CheckedChanged);
            // 
            // RS_sendHonorsFacebook
            // 
            this.RS_sendHonorsFacebook.AutoSize = true;
            this.RS_sendHonorsFacebook.Location = new System.Drawing.Point(7, 20);
            this.RS_sendHonorsFacebook.Name = "RS_sendHonorsFacebook";
            this.RS_sendHonorsFacebook.Size = new System.Drawing.Size(127, 17);
            this.RS_sendHonorsFacebook.TabIndex = 0;
            this.RS_sendHonorsFacebook.Tag = "0";
            this.RS_sendHonorsFacebook.Text = "To Facebook Friends";
            this.toolTip.SetToolTip(this.RS_sendHonorsFacebook, "BETA Function");
            this.RS_sendHonorsFacebook.UseVisualStyleBackColor = true;
            this.RS_sendHonorsFacebook.CheckedChanged += new System.EventHandler(this.RS_sendHonorsCheckBox_CheckedChanged);
            // 
            // RS_buyKeysGroupBox
            // 
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesLabel);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesNumericBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesComboBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesCheckBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsLabel);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsNumericBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsComboBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsCheckBox);
            this.RS_buyKeysGroupBox.Enabled = false;
            this.RS_buyKeysGroupBox.Location = new System.Drawing.Point(169, 267);
            this.RS_buyKeysGroupBox.Name = "RS_buyKeysGroupBox";
            this.RS_buyKeysGroupBox.Size = new System.Drawing.Size(325, 80);
            this.RS_buyKeysGroupBox.TabIndex = 5;
            this.RS_buyKeysGroupBox.TabStop = false;
            this.RS_buyKeysGroupBox.Text = "Buy Keys";
            // 
            // RS_buyKeyRubiesLabel
            // 
            this.RS_buyKeyRubiesLabel.Location = new System.Drawing.Point(256, 49);
            this.RS_buyKeyRubiesLabel.Name = "RS_buyKeyRubiesLabel";
            this.RS_buyKeyRubiesLabel.Size = new System.Drawing.Size(35, 13);
            this.RS_buyKeyRubiesLabel.TabIndex = 7;
            this.RS_buyKeyRubiesLabel.Text = "times";
            // 
            // RS_buyKeyRubiesNumericBox
            // 
            this.RS_buyKeyRubiesNumericBox.Location = new System.Drawing.Point(213, 45);
            this.RS_buyKeyRubiesNumericBox.Name = "RS_buyKeyRubiesNumericBox";
            this.RS_buyKeyRubiesNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_buyKeyRubiesNumericBox.TabIndex = 6;
            this.RS_buyKeyRubiesNumericBox.Tag = "1";
            this.RS_buyKeyRubiesNumericBox.ValueChanged += new System.EventHandler(this.RS_buyKeysNumericBox_ValueChanged);
            // 
            // RS_buyKeyRubiesComboBox
            // 
            this.RS_buyKeyRubiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_buyKeyRubiesComboBox.FormattingEnabled = true;
            this.RS_buyKeyRubiesComboBox.Items.AddRange(new object[] {
            "5 Keys with 10 Rubies",
            "10 Keys with 20 Rubies",
            "20 Keys with 35 Rubies",
            "40 Keys with 45 Rubies",
            "100 Keys with 100 Rubbies"});
            this.RS_buyKeyRubiesComboBox.Location = new System.Drawing.Point(57, 44);
            this.RS_buyKeyRubiesComboBox.Name = "RS_buyKeyRubiesComboBox";
            this.RS_buyKeyRubiesComboBox.Size = new System.Drawing.Size(150, 21);
            this.RS_buyKeyRubiesComboBox.TabIndex = 5;
            this.RS_buyKeyRubiesComboBox.Tag = "1";
            this.RS_buyKeyRubiesComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_buyKeysComboBox_SelectedIndexChanged);
            // 
            // RS_buyKeyRubiesCheckBox
            // 
            this.RS_buyKeyRubiesCheckBox.AutoSize = true;
            this.RS_buyKeyRubiesCheckBox.Location = new System.Drawing.Point(7, 48);
            this.RS_buyKeyRubiesCheckBox.Name = "RS_buyKeyRubiesCheckBox";
            this.RS_buyKeyRubiesCheckBox.Size = new System.Drawing.Size(44, 17);
            this.RS_buyKeyRubiesCheckBox.TabIndex = 4;
            this.RS_buyKeyRubiesCheckBox.Tag = "1";
            this.RS_buyKeyRubiesCheckBox.Text = "Buy";
            this.RS_buyKeyRubiesCheckBox.UseVisualStyleBackColor = true;
            this.RS_buyKeyRubiesCheckBox.CheckedChanged += new System.EventHandler(this.RS_buyKeysCheckBox_CheckedChanged);
            // 
            // RS_buyKeyHonorsLabel
            // 
            this.RS_buyKeyHonorsLabel.Location = new System.Drawing.Point(256, 21);
            this.RS_buyKeyHonorsLabel.Name = "RS_buyKeyHonorsLabel";
            this.RS_buyKeyHonorsLabel.Size = new System.Drawing.Size(35, 13);
            this.RS_buyKeyHonorsLabel.TabIndex = 3;
            this.RS_buyKeyHonorsLabel.Text = "times";
            // 
            // RS_buyKeyHonorsNumericBox
            // 
            this.RS_buyKeyHonorsNumericBox.Location = new System.Drawing.Point(213, 17);
            this.RS_buyKeyHonorsNumericBox.Name = "RS_buyKeyHonorsNumericBox";
            this.RS_buyKeyHonorsNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_buyKeyHonorsNumericBox.TabIndex = 2;
            this.RS_buyKeyHonorsNumericBox.Tag = "0";
            this.RS_buyKeyHonorsNumericBox.ValueChanged += new System.EventHandler(this.RS_buyKeysNumericBox_ValueChanged);
            // 
            // RS_buyKeyHonorsComboBox
            // 
            this.RS_buyKeyHonorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_buyKeyHonorsComboBox.FormattingEnabled = true;
            this.RS_buyKeyHonorsComboBox.Items.AddRange(new object[] {
            "1 Key with 10 Honors",
            "10 Keys with 100 Honors"});
            this.RS_buyKeyHonorsComboBox.Location = new System.Drawing.Point(57, 16);
            this.RS_buyKeyHonorsComboBox.Name = "RS_buyKeyHonorsComboBox";
            this.RS_buyKeyHonorsComboBox.Size = new System.Drawing.Size(150, 21);
            this.RS_buyKeyHonorsComboBox.TabIndex = 1;
            this.RS_buyKeyHonorsComboBox.Tag = "0";
            this.RS_buyKeyHonorsComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_buyKeysComboBox_SelectedIndexChanged);
            // 
            // RS_buyKeyHonorsCheckBox
            // 
            this.RS_buyKeyHonorsCheckBox.AutoSize = true;
            this.RS_buyKeyHonorsCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RS_buyKeyHonorsCheckBox.Name = "RS_buyKeyHonorsCheckBox";
            this.RS_buyKeyHonorsCheckBox.Size = new System.Drawing.Size(44, 17);
            this.RS_buyKeyHonorsCheckBox.TabIndex = 0;
            this.RS_buyKeyHonorsCheckBox.Tag = "0";
            this.RS_buyKeyHonorsCheckBox.Text = "Buy";
            this.RS_buyKeyHonorsCheckBox.UseVisualStyleBackColor = true;
            this.RS_buyKeyHonorsCheckBox.CheckedChanged += new System.EventHandler(this.RS_buyKeysCheckBox_CheckedChanged);
            // 
            // RS_inboxGroupBox
            // 
            this.RS_inboxGroupBox.Controls.Add(this.RS_InboxCurrency);
            this.RS_inboxGroupBox.Controls.Add(this.RS_InboxKeys);
            this.RS_inboxGroupBox.Controls.Add(this.RS_inboxMaterials);
            this.RS_inboxGroupBox.Controls.Add(this.RS_inboxHonors);
            this.RS_inboxGroupBox.Location = new System.Drawing.Point(9, 104);
            this.RS_inboxGroupBox.Name = "RS_inboxGroupBox";
            this.RS_inboxGroupBox.Size = new System.Drawing.Size(485, 55);
            this.RS_inboxGroupBox.TabIndex = 1;
            this.RS_inboxGroupBox.TabStop = false;
            this.RS_inboxGroupBox.Text = "Collect Inbox";
            // 
            // RS_InboxCurrency
            // 
            this.RS_InboxCurrency.AutoSize = true;
            this.RS_InboxCurrency.Location = new System.Drawing.Point(242, 23);
            this.RS_InboxCurrency.Name = "RS_InboxCurrency";
            this.RS_InboxCurrency.Size = new System.Drawing.Size(68, 17);
            this.RS_InboxCurrency.TabIndex = 3;
            this.RS_InboxCurrency.Tag = "2";
            this.RS_InboxCurrency.Text = "Currency";
            this.RS_InboxCurrency.UseVisualStyleBackColor = true;
            this.RS_InboxCurrency.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_InboxKeys
            // 
            this.RS_InboxKeys.AutoSize = true;
            this.RS_InboxKeys.Location = new System.Drawing.Point(119, 23);
            this.RS_InboxKeys.Name = "RS_InboxKeys";
            this.RS_InboxKeys.Size = new System.Drawing.Size(49, 17);
            this.RS_InboxKeys.TabIndex = 2;
            this.RS_InboxKeys.Tag = "1";
            this.RS_InboxKeys.Text = "Keys";
            this.RS_InboxKeys.UseVisualStyleBackColor = true;
            this.RS_InboxKeys.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_inboxMaterials
            // 
            this.RS_inboxMaterials.AutoSize = true;
            this.RS_inboxMaterials.Location = new System.Drawing.Point(387, 23);
            this.RS_inboxMaterials.Name = "RS_inboxMaterials";
            this.RS_inboxMaterials.Size = new System.Drawing.Size(68, 17);
            this.RS_inboxMaterials.TabIndex = 1;
            this.RS_inboxMaterials.Tag = "3";
            this.RS_inboxMaterials.Text = "Materials";
            this.RS_inboxMaterials.UseVisualStyleBackColor = true;
            this.RS_inboxMaterials.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_inboxHonors
            // 
            this.RS_inboxHonors.AutoSize = true;
            this.RS_inboxHonors.Location = new System.Drawing.Point(7, 23);
            this.RS_inboxHonors.Name = "RS_inboxHonors";
            this.RS_inboxHonors.Size = new System.Drawing.Size(60, 17);
            this.RS_inboxHonors.TabIndex = 0;
            this.RS_inboxHonors.Tag = "0";
            this.RS_inboxHonors.Text = "Honors";
            this.RS_inboxHonors.UseVisualStyleBackColor = true;
            this.RS_inboxHonors.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_sellingGroupBox
            // 
            this.RS_sellingGroupBox.Controls.Add(this.RS_itemRadioPanel);
            this.RS_sellingGroupBox.Controls.Add(this.RS_heroRadioPanel);
            this.RS_sellingGroupBox.Controls.Add(this.RS_itemAmountNumericBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_heroAmountNumericBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_itemStarsComboBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_heroStarsComboBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_sellHeroesCheckBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_sellItemsCheckBox);
            this.RS_sellingGroupBox.Location = new System.Drawing.Point(9, 3);
            this.RS_sellingGroupBox.Name = "RS_sellingGroupBox";
            this.RS_sellingGroupBox.Size = new System.Drawing.Size(485, 95);
            this.RS_sellingGroupBox.TabIndex = 0;
            this.RS_sellingGroupBox.TabStop = false;
            this.RS_sellingGroupBox.Text = "Selling";
            // 
            // RS_itemRadioPanel
            // 
            this.RS_itemRadioPanel.Controls.Add(this.RS_itemAmountRadioButton);
            this.RS_itemRadioPanel.Controls.Add(this.RS_itemAllRadioButton);
            this.RS_itemRadioPanel.Enabled = false;
            this.RS_itemRadioPanel.Location = new System.Drawing.Point(310, 52);
            this.RS_itemRadioPanel.Name = "RS_itemRadioPanel";
            this.RS_itemRadioPanel.Size = new System.Drawing.Size(108, 25);
            this.RS_itemRadioPanel.TabIndex = 11;
            this.RS_itemRadioPanel.Tag = "1";
            // 
            // RS_itemAmountRadioButton
            // 
            this.RS_itemAmountRadioButton.Enabled = false;
            this.RS_itemAmountRadioButton.Location = new System.Drawing.Point(46, 4);
            this.RS_itemAmountRadioButton.Name = "RS_itemAmountRadioButton";
            this.RS_itemAmountRadioButton.Size = new System.Drawing.Size(61, 17);
            this.RS_itemAmountRadioButton.TabIndex = 10;
            this.RS_itemAmountRadioButton.TabStop = true;
            this.RS_itemAmountRadioButton.Tag = "1";
            this.RS_itemAmountRadioButton.Text = "Amount";
            this.RS_itemAmountRadioButton.UseVisualStyleBackColor = true;
            this.RS_itemAmountRadioButton.Visible = false;
            // 
            // RS_itemAllRadioButton
            // 
            this.RS_itemAllRadioButton.AutoSize = true;
            this.RS_itemAllRadioButton.Enabled = false;
            this.RS_itemAllRadioButton.Location = new System.Drawing.Point(3, 4);
            this.RS_itemAllRadioButton.Name = "RS_itemAllRadioButton";
            this.RS_itemAllRadioButton.Size = new System.Drawing.Size(36, 17);
            this.RS_itemAllRadioButton.TabIndex = 9;
            this.RS_itemAllRadioButton.TabStop = true;
            this.RS_itemAllRadioButton.Tag = "1";
            this.RS_itemAllRadioButton.Text = "All";
            this.RS_itemAllRadioButton.UseVisualStyleBackColor = true;
            this.RS_itemAllRadioButton.Visible = false;
            this.RS_itemAllRadioButton.CheckedChanged += new System.EventHandler(this.RS_sellAllRadioButton_CheckedChanged);
            // 
            // RS_heroRadioPanel
            // 
            this.RS_heroRadioPanel.Controls.Add(this.RS_heroAmountRadioButton);
            this.RS_heroRadioPanel.Controls.Add(this.RS_heroAllRadioButton);
            this.RS_heroRadioPanel.Location = new System.Drawing.Point(310, 16);
            this.RS_heroRadioPanel.Name = "RS_heroRadioPanel";
            this.RS_heroRadioPanel.Size = new System.Drawing.Size(108, 25);
            this.RS_heroRadioPanel.TabIndex = 2;
            this.RS_heroRadioPanel.Tag = "0";
            // 
            // RS_heroAmountRadioButton
            // 
            this.RS_heroAmountRadioButton.Location = new System.Drawing.Point(46, 4);
            this.RS_heroAmountRadioButton.Name = "RS_heroAmountRadioButton";
            this.RS_heroAmountRadioButton.Size = new System.Drawing.Size(63, 17);
            this.RS_heroAmountRadioButton.TabIndex = 10;
            this.RS_heroAmountRadioButton.TabStop = true;
            this.RS_heroAmountRadioButton.Tag = "0";
            this.RS_heroAmountRadioButton.Text = "Amount";
            this.RS_heroAmountRadioButton.UseVisualStyleBackColor = true;
            // 
            // RS_heroAllRadioButton
            // 
            this.RS_heroAllRadioButton.AutoSize = true;
            this.RS_heroAllRadioButton.Location = new System.Drawing.Point(3, 4);
            this.RS_heroAllRadioButton.Name = "RS_heroAllRadioButton";
            this.RS_heroAllRadioButton.Size = new System.Drawing.Size(36, 17);
            this.RS_heroAllRadioButton.TabIndex = 9;
            this.RS_heroAllRadioButton.TabStop = true;
            this.RS_heroAllRadioButton.Tag = "0";
            this.RS_heroAllRadioButton.Text = "All";
            this.RS_heroAllRadioButton.UseVisualStyleBackColor = true;
            this.RS_heroAllRadioButton.CheckedChanged += new System.EventHandler(this.RS_sellAllRadioButton_CheckedChanged);
            // 
            // RS_itemAmountNumericBox
            // 
            this.RS_itemAmountNumericBox.Enabled = false;
            this.RS_itemAmountNumericBox.Location = new System.Drawing.Point(424, 56);
            this.RS_itemAmountNumericBox.Name = "RS_itemAmountNumericBox";
            this.RS_itemAmountNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_itemAmountNumericBox.TabIndex = 8;
            this.RS_itemAmountNumericBox.Tag = "1";
            this.RS_itemAmountNumericBox.Visible = false;
            this.RS_itemAmountNumericBox.ValueChanged += new System.EventHandler(this.RS_sellAmountNumericBox_ValueChanged);
            // 
            // RS_heroAmountNumericBox
            // 
            this.RS_heroAmountNumericBox.Location = new System.Drawing.Point(425, 19);
            this.RS_heroAmountNumericBox.Name = "RS_heroAmountNumericBox";
            this.RS_heroAmountNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_heroAmountNumericBox.TabIndex = 7;
            this.RS_heroAmountNumericBox.Tag = "0";
            this.RS_heroAmountNumericBox.ValueChanged += new System.EventHandler(this.RS_sellAmountNumericBox_ValueChanged);
            // 
            // RS_itemStarsComboBox
            // 
            this.RS_itemStarsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_itemStarsComboBox.FormattingEnabled = true;
            this.RS_itemStarsComboBox.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★"});
            this.RS_itemStarsComboBox.Location = new System.Drawing.Point(226, 54);
            this.RS_itemStarsComboBox.Name = "RS_itemStarsComboBox";
            this.RS_itemStarsComboBox.Size = new System.Drawing.Size(78, 21);
            this.RS_itemStarsComboBox.TabIndex = 4;
            this.RS_itemStarsComboBox.Tag = "1";
            this.RS_itemStarsComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_sellStarsComboBox_SelectedIndexChanged);
            // 
            // RS_heroStarsComboBox
            // 
            this.RS_heroStarsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_heroStarsComboBox.FormattingEnabled = true;
            this.RS_heroStarsComboBox.Items.AddRange(new object[] {
            "★",
            "★★"});
            this.RS_heroStarsComboBox.Location = new System.Drawing.Point(226, 18);
            this.RS_heroStarsComboBox.Name = "RS_heroStarsComboBox";
            this.RS_heroStarsComboBox.Size = new System.Drawing.Size(78, 21);
            this.RS_heroStarsComboBox.TabIndex = 3;
            this.RS_heroStarsComboBox.Tag = "0";
            this.RS_heroStarsComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_sellStarsComboBox_SelectedIndexChanged);
            // 
            // RS_sellHeroesCheckBox
            // 
            this.RS_sellHeroesCheckBox.AutoSize = true;
            this.RS_sellHeroesCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RS_sellHeroesCheckBox.Name = "RS_sellHeroesCheckBox";
            this.RS_sellHeroesCheckBox.Size = new System.Drawing.Size(220, 17);
            this.RS_sellHeroesCheckBox.TabIndex = 2;
            this.RS_sellHeroesCheckBox.Tag = "0";
            this.RS_sellHeroesCheckBox.Text = "Lv.30 heroes with ★ less than or equal to";
            this.toolTip.SetToolTip(this.RS_sellHeroesCheckBox, "BETA Function");
            this.RS_sellHeroesCheckBox.UseVisualStyleBackColor = true;
            this.RS_sellHeroesCheckBox.CheckedChanged += new System.EventHandler(this.RS_sellCheckBox_CheckedChanged);
            // 
            // RS_sellItemsCheckBox
            // 
            this.RS_sellItemsCheckBox.AutoSize = true;
            this.RS_sellItemsCheckBox.Location = new System.Drawing.Point(7, 56);
            this.RS_sellItemsCheckBox.Name = "RS_sellItemsCheckBox";
            this.RS_sellItemsCheckBox.Size = new System.Drawing.Size(207, 17);
            this.RS_sellItemsCheckBox.TabIndex = 0;
            this.RS_sellItemsCheckBox.Tag = "1";
            this.RS_sellItemsCheckBox.Text = "Every item with ★ less than or equal to";
            this.RS_sellItemsCheckBox.UseVisualStyleBackColor = true;
            this.RS_sellItemsCheckBox.CheckedChanged += new System.EventHandler(this.RS_sellCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.linkLabel2);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.ST_TelegramChatIDTextBox);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.ST_TelegramTokenTextBox);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.ST_TelegramEnableCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 158);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Telegram Bot";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(55, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "How to use Telegram Bot : ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(189, 127);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://goo.gl/obtKV2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::SevenKnightsAI.Properties.Resources.telegramLogo;
            this.pictureBox2.Location = new System.Drawing.Point(7, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // ST_TelegramChatIDTextBox
            // 
            this.ST_TelegramChatIDTextBox.Enabled = false;
            this.ST_TelegramChatIDTextBox.Location = new System.Drawing.Point(118, 88);
            this.ST_TelegramChatIDTextBox.Name = "ST_TelegramChatIDTextBox";
            this.ST_TelegramChatIDTextBox.Size = new System.Drawing.Size(347, 20);
            this.ST_TelegramChatIDTextBox.TabIndex = 4;
            this.ST_TelegramChatIDTextBox.TextChanged += new System.EventHandler(this.ST_TelegramChatIDTextBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Chat ID";
            // 
            // ST_TelegramTokenTextBox
            // 
            this.ST_TelegramTokenTextBox.Enabled = false;
            this.ST_TelegramTokenTextBox.Location = new System.Drawing.Point(118, 62);
            this.ST_TelegramTokenTextBox.Name = "ST_TelegramTokenTextBox";
            this.ST_TelegramTokenTextBox.Size = new System.Drawing.Size(347, 20);
            this.ST_TelegramTokenTextBox.TabIndex = 2;
            this.ST_TelegramTokenTextBox.TextChanged += new System.EventHandler(this.ST_TelegramTokenTextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Bot Token";
            // 
            // ST_TelegramEnableCheckBox
            // 
            this.ST_TelegramEnableCheckBox.AutoSize = true;
            this.ST_TelegramEnableCheckBox.Location = new System.Drawing.Point(55, 30);
            this.ST_TelegramEnableCheckBox.Name = "ST_TelegramEnableCheckBox";
            this.ST_TelegramEnableCheckBox.Size = new System.Drawing.Size(125, 17);
            this.ST_TelegramEnableCheckBox.TabIndex = 0;
            this.ST_TelegramEnableCheckBox.Text = "Enable Telegram Bot";
            this.ST_TelegramEnableCheckBox.UseVisualStyleBackColor = true;
            this.ST_TelegramEnableCheckBox.CheckedChanged += new System.EventHandler(this.ST_TelegramEnableCheckBox_CheckedChanged);
            // 
            // ST_opacityLabel
            // 
            this.ST_opacityLabel.AutoSize = true;
            this.ST_opacityLabel.Location = new System.Drawing.Point(6, 90);
            this.ST_opacityLabel.Name = "ST_opacityLabel";
            this.ST_opacityLabel.Size = new System.Drawing.Size(72, 13);
            this.ST_opacityLabel.TabIndex = 10;
            this.ST_opacityLabel.Text = "Transparency";
            // 
            // ST_manageProfileButton
            // 
            this.ST_manageProfileButton.Location = new System.Drawing.Point(225, 16);
            this.ST_manageProfileButton.Name = "ST_manageProfileButton";
            this.ST_manageProfileButton.Size = new System.Drawing.Size(80, 23);
            this.ST_manageProfileButton.TabIndex = 2;
            this.ST_manageProfileButton.Text = "New Profiles";
            this.ST_manageProfileButton.UseVisualStyleBackColor = true;
            this.ST_manageProfileButton.Click += new System.EventHandler(this.ST_manageProfileButton_Click);
            // 
            // ST_hotTimeProfileCheckBox
            // 
            this.ST_hotTimeProfileCheckBox.AutoSize = true;
            this.ST_hotTimeProfileCheckBox.Enabled = false;
            this.ST_hotTimeProfileCheckBox.Location = new System.Drawing.Point(6, 46);
            this.ST_hotTimeProfileCheckBox.Name = "ST_hotTimeProfileCheckBox";
            this.ST_hotTimeProfileCheckBox.Size = new System.Drawing.Size(167, 17);
            this.ST_hotTimeProfileCheckBox.TabIndex = 3;
            this.ST_hotTimeProfileCheckBox.Text = "Use profile during \'HOT TIME\'";
            this.ST_hotTimeProfileCheckBox.UseVisualStyleBackColor = true;
            this.ST_hotTimeProfileCheckBox.Visible = false;
            this.ST_hotTimeProfileCheckBox.CheckedChanged += new System.EventHandler(this.ST_hotTimeProfileCheckBox_CheckedChanged);
            // 
            // ST_currentProfileComboBox
            // 
            this.ST_currentProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ST_currentProfileComboBox.FormattingEnabled = true;
            this.ST_currentProfileComboBox.Location = new System.Drawing.Point(82, 18);
            this.ST_currentProfileComboBox.Name = "ST_currentProfileComboBox";
            this.ST_currentProfileComboBox.Size = new System.Drawing.Size(112, 21);
            this.ST_currentProfileComboBox.TabIndex = 1;
            this.ST_currentProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.ST_currentProfileComboBox_SelectedIndexChanged);
            // 
            // ST_currentProfileLabel
            // 
            this.ST_currentProfileLabel.AutoSize = true;
            this.ST_currentProfileLabel.Location = new System.Drawing.Point(3, 22);
            this.ST_currentProfileLabel.Name = "ST_currentProfileLabel";
            this.ST_currentProfileLabel.Size = new System.Drawing.Size(73, 13);
            this.ST_currentProfileLabel.TabIndex = 0;
            this.ST_currentProfileLabel.Text = "Current Profile";
            // 
            // ST_opacityTrackBar
            // 
            this.ST_opacityTrackBar.AutoSize = false;
            this.ST_opacityTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.ST_opacityTrackBar.Location = new System.Drawing.Point(84, 86);
            this.ST_opacityTrackBar.Maximum = 100;
            this.ST_opacityTrackBar.Minimum = 20;
            this.ST_opacityTrackBar.Name = "ST_opacityTrackBar";
            this.ST_opacityTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ST_opacityTrackBar.Size = new System.Drawing.Size(104, 27);
            this.ST_opacityTrackBar.TabIndex = 11;
            this.ST_opacityTrackBar.TickFrequency = 10;
            this.ST_opacityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ST_opacityTrackBar.Value = 100;
            this.ST_opacityTrackBar.ValueChanged += new System.EventHandler(this.ST_opacityTrackBar_ValueChanged);
            // 
            // ST_reconnectNumericUpDown
            // 
            this.ST_reconnectNumericUpDown.Location = new System.Drawing.Point(225, 52);
            this.ST_reconnectNumericUpDown.Name = "ST_reconnectNumericUpDown";
            this.ST_reconnectNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.ST_reconnectNumericUpDown.TabIndex = 4;
            this.ST_reconnectNumericUpDown.ValueChanged += new System.EventHandler(this.ST_reconnectNumericBox_ValueChanged);
            // 
            // ST_reconnectInterruptCheckBox
            // 
            this.ST_reconnectInterruptCheckBox.AutoSize = true;
            this.ST_reconnectInterruptCheckBox.Location = new System.Drawing.Point(9, 52);
            this.ST_reconnectInterruptCheckBox.Name = "ST_reconnectInterruptCheckBox";
            this.ST_reconnectInterruptCheckBox.Size = new System.Drawing.Size(210, 17);
            this.ST_reconnectInterruptCheckBox.TabIndex = 3;
            this.ST_reconnectInterruptCheckBox.Text = "Reconnect on interrupt within (minutes)";
            this.ST_reconnectInterruptCheckBox.UseVisualStyleBackColor = true;
            this.ST_reconnectInterruptCheckBox.CheckedChanged += new System.EventHandler(this.ST_reconnectInterruptCheckBox_CheckedChanged);
            // 
            // ST_delayValueLabel
            // 
            this.ST_delayValueLabel.AutoSize = true;
            this.ST_delayValueLabel.Location = new System.Drawing.Point(229, 26);
            this.ST_delayValueLabel.Name = "ST_delayValueLabel";
            this.ST_delayValueLabel.Size = new System.Drawing.Size(47, 13);
            this.ST_delayValueLabel.TabIndex = 2;
            this.ST_delayValueLabel.Text = "1800 ms";
            // 
            // ST_delayLabel
            // 
            this.ST_delayLabel.Location = new System.Drawing.Point(6, 26);
            this.ST_delayLabel.Name = "ST_delayLabel";
            this.ST_delayLabel.Size = new System.Drawing.Size(49, 13);
            this.ST_delayLabel.TabIndex = 1;
            this.ST_delayLabel.Text = "Delay";
            // 
            // ST_delayTrackBar
            // 
            this.ST_delayTrackBar.AutoSize = false;
            this.ST_delayTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.ST_delayTrackBar.LargeChange = 100;
            this.ST_delayTrackBar.Location = new System.Drawing.Point(61, 19);
            this.ST_delayTrackBar.Maximum = 3000;
            this.ST_delayTrackBar.Minimum = 500;
            this.ST_delayTrackBar.Name = "ST_delayTrackBar";
            this.ST_delayTrackBar.Size = new System.Drawing.Size(162, 27);
            this.ST_delayTrackBar.SmallChange = 100;
            this.ST_delayTrackBar.TabIndex = 0;
            this.ST_delayTrackBar.TickFrequency = 100;
            this.ST_delayTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ST_delayTrackBar.Value = 1800;
            this.ST_delayTrackBar.ValueChanged += new System.EventHandler(this.ST_delayTrackBar_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 28;
            this.button1.Text = "&Export";
            this.toolTip.SetToolTip(this.button1, "Use this when you got an error. Send log file to Admin");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LG_exportButton_Click);
            // 
            // logsBox
            // 
            this.logsBox.BackColor = System.Drawing.SystemColors.Control;
            this.logsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logsBox.Location = new System.Drawing.Point(10, 19);
            this.logsBox.Name = "logsBox";
            this.logsBox.ReadOnly = true;
            this.logsBox.Size = new System.Drawing.Size(296, 165);
            this.logsBox.TabIndex = 24;
            this.logsBox.Text = "";
            this.logsBox.TextChanged += new System.EventHandler(this.logsBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LG_clearButton_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(76, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 27;
            this.button2.Text = "&Log Pixel";
            this.toolTip.SetToolTip(this.button2, "Requries bot to be running or paused\r\n\r\nMouse over pixel to Log while keeping the" +
        " bot focused\r\nPress Alt+L");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LG_LogPixel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(234, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Auto Scroll";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.LG_scrollCheckBox_CheckedChanged);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.Green;
            this.timer.Location = new System.Drawing.Point(64, 44);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(64, 18);
            this.timer.TabIndex = 18;
            this.timer.Text = "00:00:00";
            // 
            // botstatusLabel
            // 
            this.botstatusLabel.AutoSize = true;
            this.botstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botstatusLabel.ForeColor = System.Drawing.Color.Red;
            this.botstatusLabel.Location = new System.Drawing.Point(23, 16);
            this.botstatusLabel.Name = "botstatusLabel";
            this.botstatusLabel.Size = new System.Drawing.Size(90, 18);
            this.botstatusLabel.TabIndex = 20;
            this.botstatusLabel.Text = "Bot Stopped";
            this.botstatusLabel.Click += new System.EventHandler(this.botstatusLabel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox5);
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.towerKeysLabel2);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.arenaKeysLabel2);
            this.groupBox4.Controls.Add(this.adventureKeysLabel2);
            this.groupBox4.Location = new System.Drawing.Point(6, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 51);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Keys";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SevenKnightsAI.Properties.Resources.icon_key_arena;
            this.pictureBox5.Location = new System.Drawing.Point(325, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox5, "Arena Keys");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SevenKnightsAI.Properties.Resources.icon_key_adventure;
            this.pictureBox3.Location = new System.Drawing.Point(83, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox3, "Adventure Keys");
            // 
            // towerKeysLabel2
            // 
            this.towerKeysLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.towerKeysLabel2.AutoSize = true;
            this.towerKeysLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.towerKeysLabel2.ForeColor = System.Drawing.Color.Blue;
            this.towerKeysLabel2.Location = new System.Drawing.Point(244, 16);
            this.towerKeysLabel2.Name = "towerKeysLabel2";
            this.towerKeysLabel2.Size = new System.Drawing.Size(13, 18);
            this.towerKeysLabel2.TabIndex = 9;
            this.towerKeysLabel2.Text = "-";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SevenKnightsAI.Properties.Resources.icon_key_tower;
            this.pictureBox4.Location = new System.Drawing.Point(209, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox4, "Tower Keys");
            // 
            // arenaKeysLabel2
            // 
            this.arenaKeysLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arenaKeysLabel2.AutoSize = true;
            this.arenaKeysLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaKeysLabel2.ForeColor = System.Drawing.Color.Blue;
            this.arenaKeysLabel2.Location = new System.Drawing.Point(360, 16);
            this.arenaKeysLabel2.Name = "arenaKeysLabel2";
            this.arenaKeysLabel2.Size = new System.Drawing.Size(13, 18);
            this.arenaKeysLabel2.TabIndex = 10;
            this.arenaKeysLabel2.Text = "-";
            // 
            // adventureKeysLabel2
            // 
            this.adventureKeysLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.adventureKeysLabel2.AutoSize = true;
            this.adventureKeysLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adventureKeysLabel2.ForeColor = System.Drawing.Color.Blue;
            this.adventureKeysLabel2.Location = new System.Drawing.Point(118, 16);
            this.adventureKeysLabel2.Name = "adventureKeysLabel2";
            this.adventureKeysLabel2.Size = new System.Drawing.Size(13, 18);
            this.adventureKeysLabel2.TabIndex = 8;
            this.adventureKeysLabel2.Text = "-";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.dragoncountlabel);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.h30Label2);
            this.groupBox9.Controls.Add(this.label51);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox9.Location = new System.Drawing.Point(6, 126);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(172, 70);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Adventure";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(118, 44);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 16);
            this.label27.TabIndex = 26;
            this.label27.Text = "/1000";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // dragoncountlabel
            // 
            this.dragoncountlabel.AutoSize = true;
            this.dragoncountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragoncountlabel.Location = new System.Drawing.Point(83, 42);
            this.dragoncountlabel.Name = "dragoncountlabel";
            this.dragoncountlabel.Size = new System.Drawing.Size(16, 18);
            this.dragoncountlabel.TabIndex = 25;
            this.dragoncountlabel.Tag = "";
            this.dragoncountlabel.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(5, 46);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(45, 13);
            this.label29.TabIndex = 24;
            this.label29.Text = "Dragon:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(125, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 16);
            this.label24.TabIndex = 23;
            this.label24.Text = "/100";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // h30Label2
            // 
            this.h30Label2.AutoSize = true;
            this.h30Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h30Label2.Location = new System.Drawing.Point(83, 16);
            this.h30Label2.Name = "h30Label2";
            this.h30Label2.Size = new System.Drawing.Size(16, 18);
            this.h30Label2.TabIndex = 22;
            this.h30Label2.Text = "0";
            this.h30Label2.Click += new System.EventHandler(this.h30Label2_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(5, 19);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(67, 13);
            this.label51.TabIndex = 4;
            this.label51.Text = "Hero lvl 30 : ";
            // 
            // HeroCountLabel
            // 
            this.HeroCountLabel.AutoSize = true;
            this.HeroCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeroCountLabel.Location = new System.Drawing.Point(280, 82);
            this.HeroCountLabel.Name = "HeroCountLabel";
            this.HeroCountLabel.Size = new System.Drawing.Size(12, 16);
            this.HeroCountLabel.TabIndex = 14;
            this.HeroCountLabel.Text = "-";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rankArenaLabel);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.arenaLoseLabel2);
            this.groupBox8.Controls.Add(this.arenaWinLabel2);
            this.groupBox8.Controls.Add(this.label45);
            this.groupBox8.Location = new System.Drawing.Point(331, 202);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(163, 70);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Arena";
            // 
            // rankArenaLabel
            // 
            this.rankArenaLabel.AutoSize = true;
            this.rankArenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankArenaLabel.Location = new System.Drawing.Point(83, 40);
            this.rankArenaLabel.Name = "rankArenaLabel";
            this.rankArenaLabel.Size = new System.Drawing.Size(13, 18);
            this.rankArenaLabel.TabIndex = 26;
            this.rankArenaLabel.Text = "-";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 44);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Rank : ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(97, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(12, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "/";
            // 
            // arenaLoseLabel2
            // 
            this.arenaLoseLabel2.AutoSize = true;
            this.arenaLoseLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaLoseLabel2.Location = new System.Drawing.Point(115, 16);
            this.arenaLoseLabel2.Name = "arenaLoseLabel2";
            this.arenaLoseLabel2.Size = new System.Drawing.Size(13, 18);
            this.arenaLoseLabel2.TabIndex = 23;
            this.arenaLoseLabel2.Text = "-";
            // 
            // arenaWinLabel2
            // 
            this.arenaWinLabel2.AutoSize = true;
            this.arenaWinLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaWinLabel2.Location = new System.Drawing.Point(83, 16);
            this.arenaWinLabel2.Name = "arenaWinLabel2";
            this.arenaWinLabel2.Size = new System.Drawing.Size(13, 18);
            this.arenaWinLabel2.TabIndex = 5;
            this.arenaWinLabel2.Text = "-";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 20);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(69, 13);
            this.label45.TabIndex = 4;
            this.label45.Text = "Win / Lose : ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.goldmineGoldAmountLabel2);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Location = new System.Drawing.Point(331, 126);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 70);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Gold Mine";
            // 
            // goldmineGoldAmountLabel2
            // 
            this.goldmineGoldAmountLabel2.AutoSize = true;
            this.goldmineGoldAmountLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldmineGoldAmountLabel2.Location = new System.Drawing.Point(94, 17);
            this.goldmineGoldAmountLabel2.Name = "goldmineGoldAmountLabel2";
            this.goldmineGoldAmountLabel2.Size = new System.Drawing.Size(13, 18);
            this.goldmineGoldAmountLabel2.TabIndex = 5;
            this.goldmineGoldAmountLabel2.Text = "-";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 21);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(82, 13);
            this.label39.TabIndex = 4;
            this.label39.Text = "Gold Collected: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox6);
            this.groupBox5.Controls.Add(this.pictureBox7);
            this.groupBox5.Controls.Add(this.pictureBox8);
            this.groupBox5.Controls.Add(this.pictureBox9);
            this.groupBox5.Controls.Add(this.honorLabel2);
            this.groupBox5.Controls.Add(this.topazLabel2);
            this.groupBox5.Controls.Add(this.rubyLabel2);
            this.groupBox5.Controls.Add(this.goldLabel2);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(488, 57);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resources";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SevenKnightsAI.Properties.Resources.icon_gold;
            this.pictureBox6.Location = new System.Drawing.Point(6, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox6, "Gold");
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SevenKnightsAI.Properties.Resources.icon_topaz;
            this.pictureBox7.Location = new System.Drawing.Point(375, 16);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox7, "Topaz");
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SevenKnightsAI.Properties.Resources.icon_ruby;
            this.pictureBox8.Location = new System.Drawing.Point(142, 17);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox8, "Ruby");
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SevenKnightsAI.Properties.Resources.icon_honor;
            this.pictureBox9.Location = new System.Drawing.Point(258, 18);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(29, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox9, "Honor");
            // 
            // honorLabel2
            // 
            this.honorLabel2.AutoSize = true;
            this.honorLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.honorLabel2.Location = new System.Drawing.Point(293, 23);
            this.honorLabel2.Name = "honorLabel2";
            this.honorLabel2.Size = new System.Drawing.Size(13, 18);
            this.honorLabel2.TabIndex = 7;
            this.honorLabel2.Text = "-";
            // 
            // topazLabel2
            // 
            this.topazLabel2.AutoSize = true;
            this.topazLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topazLabel2.Location = new System.Drawing.Point(413, 23);
            this.topazLabel2.Name = "topazLabel2";
            this.topazLabel2.Size = new System.Drawing.Size(13, 18);
            this.topazLabel2.TabIndex = 5;
            this.topazLabel2.Text = "-";
            // 
            // rubyLabel2
            // 
            this.rubyLabel2.AutoSize = true;
            this.rubyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rubyLabel2.Location = new System.Drawing.Point(178, 23);
            this.rubyLabel2.Name = "rubyLabel2";
            this.rubyLabel2.Size = new System.Drawing.Size(13, 18);
            this.rubyLabel2.TabIndex = 3;
            this.rubyLabel2.Text = "-";
            // 
            // goldLabel2
            // 
            this.goldLabel2.AutoSize = true;
            this.goldLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldLabel2.Location = new System.Drawing.Point(39, 23);
            this.goldLabel2.Name = "goldLabel2";
            this.goldLabel2.Size = new System.Drawing.Size(13, 18);
            this.goldLabel2.TabIndex = 1;
            this.goldLabel2.Text = "-";
            // 
            // ST_AutoShutdownCheckBox
            // 
            this.ST_AutoShutdownCheckBox.AutoSize = true;
            this.ST_AutoShutdownCheckBox.Location = new System.Drawing.Point(6, 63);
            this.ST_AutoShutdownCheckBox.Name = "ST_AutoShutdownCheckBox";
            this.ST_AutoShutdownCheckBox.Size = new System.Drawing.Size(154, 17);
            this.ST_AutoShutdownCheckBox.TabIndex = 31;
            this.ST_AutoShutdownCheckBox.Text = "Shutdown After Max Lv Up";
            this.ST_AutoShutdownCheckBox.UseVisualStyleBackColor = true;
            this.ST_AutoShutdownCheckBox.CheckedChanged += new System.EventHandler(this.ST_AutoShutdownCheckBox_CheckedChanged);
            // 
            // AD_limitLabel
            // 
            this.AD_limitLabel.AutoSize = true;
            this.AD_limitLabel.Location = new System.Drawing.Point(366, 20);
            this.AD_limitLabel.Name = "AD_limitLabel";
            this.AD_limitLabel.Size = new System.Drawing.Size(70, 13);
            this.AD_limitLabel.TabIndex = 16;
            this.AD_limitLabel.Text = "times per visit";
            // 
            // AD_limitNumericBox
            // 
            this.AD_limitNumericBox.Location = new System.Drawing.Point(324, 17);
            this.AD_limitNumericBox.Name = "AD_limitNumericBox";
            this.AD_limitNumericBox.Size = new System.Drawing.Size(37, 20);
            this.AD_limitNumericBox.TabIndex = 15;
            this.AD_limitNumericBox.Tag = "0";
            this.AD_limitNumericBox.ValueChanged += new System.EventHandler(this.limitNumericBox_ValueChanged);
            // 
            // AD_limitCheckBox
            // 
            this.AD_limitCheckBox.Location = new System.Drawing.Point(274, 19);
            this.AD_limitCheckBox.Name = "AD_limitCheckBox";
            this.AD_limitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.AD_limitCheckBox.TabIndex = 14;
            this.AD_limitCheckBox.Tag = "0";
            this.AD_limitCheckBox.Text = "Limit";
            this.AD_limitCheckBox.UseVisualStyleBackColor = true;
            this.AD_limitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // AD_RubyBooster_Checkbox
            // 
            this.AD_RubyBooster_Checkbox.AutoSize = true;
            this.AD_RubyBooster_Checkbox.Location = new System.Drawing.Point(6, 62);
            this.AD_RubyBooster_Checkbox.Name = "AD_RubyBooster_Checkbox";
            this.AD_RubyBooster_Checkbox.Size = new System.Drawing.Size(90, 17);
            this.AD_RubyBooster_Checkbox.TabIndex = 29;
            this.AD_RubyBooster_Checkbox.Text = "Ruby Booster";
            this.AD_RubyBooster_Checkbox.UseVisualStyleBackColor = true;
            this.AD_RubyBooster_Checkbox.CheckedChanged += new System.EventHandler(this.AD_RubyBooster_Checkbox_CheckedChanged);
            // 
            // AD_bootmodeCheckBox
            // 
            this.AD_bootmodeCheckBox.AutoSize = true;
            this.AD_bootmodeCheckBox.Location = new System.Drawing.Point(6, 39);
            this.AD_bootmodeCheckBox.Name = "AD_bootmodeCheckBox";
            this.AD_bootmodeCheckBox.Size = new System.Drawing.Size(83, 17);
            this.AD_bootmodeCheckBox.TabIndex = 28;
            this.AD_bootmodeCheckBox.Text = "Boost Mode";
            this.AD_bootmodeCheckBox.UseVisualStyleBackColor = true;
            this.AD_bootmodeCheckBox.CheckedChanged += new System.EventHandler(this.AD_bootmodeCheckBox_CheckedChanged);
            // 
            // AD_leaderComboBox
            // 
            this.AD_leaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_leaderComboBox.Enabled = false;
            this.AD_leaderComboBox.FormattingEnabled = true;
            this.AD_leaderComboBox.Items.AddRange(new object[] {
            "Universal",
            "Defensive",
            "Offensive",
            "Support",
            "Magic"});
            this.AD_leaderComboBox.Location = new System.Drawing.Point(175, 121);
            this.AD_leaderComboBox.Name = "AD_leaderComboBox";
            this.AD_leaderComboBox.Size = new System.Drawing.Size(46, 21);
            this.AD_leaderComboBox.TabIndex = 14;
            this.AD_leaderComboBox.Tag = "0";
            this.AD_leaderComboBox.Visible = false;
            this.AD_leaderComboBox.SelectedIndexChanged += new System.EventHandler(this.masteryComboBox_SelectedIndexChanged);
            // 
            // AD_UseFriendCheckBox
            // 
            this.AD_UseFriendCheckBox.AutoSize = true;
            this.AD_UseFriendCheckBox.Location = new System.Drawing.Point(6, 17);
            this.AD_UseFriendCheckBox.Name = "AD_UseFriendCheckBox";
            this.AD_UseFriendCheckBox.Size = new System.Drawing.Size(82, 17);
            this.AD_UseFriendCheckBox.TabIndex = 28;
            this.AD_UseFriendCheckBox.Text = "Use Friends";
            this.AD_UseFriendCheckBox.UseVisualStyleBackColor = true;
            this.AD_UseFriendCheckBox.CheckedChanged += new System.EventHandler(this.AD_UseFriendCheckBox_CheckedChanged);
            // 
            // AD_masteryLabel
            // 
            this.AD_masteryLabel.AutoSize = true;
            this.AD_masteryLabel.Enabled = false;
            this.AD_masteryLabel.Location = new System.Drawing.Point(172, 103);
            this.AD_masteryLabel.Name = "AD_masteryLabel";
            this.AD_masteryLabel.Size = new System.Drawing.Size(40, 13);
            this.AD_masteryLabel.TabIndex = 13;
            this.AD_masteryLabel.Text = "Leader";
            this.AD_masteryLabel.Visible = false;
            // 
            // AD_EnHottime_Checkbox
            // 
            this.AD_EnHottime_Checkbox.AutoSize = true;
            this.AD_EnHottime_Checkbox.Location = new System.Drawing.Point(274, 86);
            this.AD_EnHottime_Checkbox.Name = "AD_EnHottime_Checkbox";
            this.AD_EnHottime_Checkbox.Size = new System.Drawing.Size(95, 17);
            this.AD_EnHottime_Checkbox.TabIndex = 27;
            this.AD_EnHottime_Checkbox.Text = "Active Hottime";
            this.AD_EnHottime_Checkbox.UseVisualStyleBackColor = true;
            this.AD_EnHottime_Checkbox.CheckedChanged += new System.EventHandler(this.AD_EnHottime_Checkbox_CheckedChanged);
            // 
            // AD_teamComboBox2
            // 
            this.AD_teamComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_teamComboBox2.Enabled = false;
            this.AD_teamComboBox2.FormattingEnabled = true;
            this.AD_teamComboBox2.Items.AddRange(new object[] {
            "--",
            "A",
            "B",
            "C"});
            this.AD_teamComboBox2.Location = new System.Drawing.Point(164, 22);
            this.AD_teamComboBox2.Name = "AD_teamComboBox2";
            this.AD_teamComboBox2.Size = new System.Drawing.Size(60, 21);
            this.AD_teamComboBox2.TabIndex = 28;
            this.AD_teamComboBox2.Tag = "0";
            this.AD_teamComboBox2.Visible = false;
            this.AD_teamComboBox2.SelectedIndexChanged += new System.EventHandler(this.AD_teamComboBox2_SelectedIndexChanged);
            // 
            // AD_difficultyComboBox2nd
            // 
            this.AD_difficultyComboBox2nd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_difficultyComboBox2nd.FormattingEnabled = true;
            this.AD_difficultyComboBox2nd.Items.AddRange(new object[] {
            "--",
            "Easy",
            "Normal",
            "Hard"});
            this.AD_difficultyComboBox2nd.Location = new System.Drawing.Point(69, 129);
            this.AD_difficultyComboBox2nd.MaxDropDownItems = 3;
            this.AD_difficultyComboBox2nd.Name = "AD_difficultyComboBox2nd";
            this.AD_difficultyComboBox2nd.Size = new System.Drawing.Size(60, 21);
            this.AD_difficultyComboBox2nd.TabIndex = 27;
            this.toolTip.SetToolTip(this.AD_difficultyComboBox2nd, "For Map 8 +");
            this.AD_difficultyComboBox2nd.SelectedValueChanged += new System.EventHandler(this.AD_difficultyComboBox2nd_SelectedValueChanged);
            // 
            // AD_StopOnLV30_Checkbox
            // 
            this.AD_StopOnLV30_Checkbox.AutoSize = true;
            this.AD_StopOnLV30_Checkbox.Location = new System.Drawing.Point(6, 65);
            this.AD_StopOnLV30_Checkbox.Name = "AD_StopOnLV30_Checkbox";
            this.AD_StopOnLV30_Checkbox.Size = new System.Drawing.Size(101, 17);
            this.AD_StopOnLV30_Checkbox.TabIndex = 25;
            this.AD_StopOnLV30_Checkbox.Text = "Pause On LV30";
            this.AD_StopOnLV30_Checkbox.UseVisualStyleBackColor = true;
            this.AD_StopOnLV30_Checkbox.CheckedChanged += new System.EventHandler(this.AD_StopOnLV30_Checkbox_CheckedChanged);
            // 
            // AD_continuousCheckBox
            // 
            this.AD_continuousCheckBox.AutoSize = true;
            this.AD_continuousCheckBox.Location = new System.Drawing.Point(70, 73);
            this.AD_continuousCheckBox.Name = "AD_continuousCheckBox";
            this.AD_continuousCheckBox.Size = new System.Drawing.Size(128, 17);
            this.AD_continuousCheckBox.TabIndex = 5;
            this.AD_continuousCheckBox.Text = "Progress to next zone";
            this.AD_continuousCheckBox.UseVisualStyleBackColor = true;
            this.AD_continuousCheckBox.CheckedChanged += new System.EventHandler(this.AD_continuousCheckBox_CheckedChanged);
            // 
            // AD_CheckingHeroes_Checkbox
            // 
            this.AD_CheckingHeroes_Checkbox.AutoSize = true;
            this.AD_CheckingHeroes_Checkbox.Location = new System.Drawing.Point(6, 19);
            this.AD_CheckingHeroes_Checkbox.Name = "AD_CheckingHeroes_Checkbox";
            this.AD_CheckingHeroes_Checkbox.Size = new System.Drawing.Size(97, 17);
            this.AD_CheckingHeroes_Checkbox.TabIndex = 26;
            this.AD_CheckingHeroes_Checkbox.Text = "Check Max Lvl";
            this.AD_CheckingHeroes_Checkbox.UseVisualStyleBackColor = true;
            this.AD_CheckingHeroes_Checkbox.CheckedChanged += new System.EventHandler(this.AD_CheckingHeroes_Checkbox_CheckedChanged);
            // 
            // AD_sequenceButton
            // 
            this.AD_sequenceButton.Location = new System.Drawing.Point(128, 47);
            this.AD_sequenceButton.Name = "AD_sequenceButton";
            this.AD_sequenceButton.Size = new System.Drawing.Size(69, 23);
            this.AD_sequenceButton.TabIndex = 4;
            this.AD_sequenceButton.Text = "Sequence";
            this.AD_sequenceButton.UseVisualStyleBackColor = true;
            this.AD_sequenceButton.Click += new System.EventHandler(this.AD_sequenceButton_Click);
            // 
            // AD_StopOnFullItems_Checkbox
            // 
            this.AD_StopOnFullItems_Checkbox.AutoSize = true;
            this.AD_StopOnFullItems_Checkbox.Location = new System.Drawing.Point(274, 63);
            this.AD_StopOnFullItems_Checkbox.Name = "AD_StopOnFullItems_Checkbox";
            this.AD_StopOnFullItems_Checkbox.Size = new System.Drawing.Size(120, 17);
            this.AD_StopOnFullItems_Checkbox.TabIndex = 25;
            this.AD_StopOnFullItems_Checkbox.Text = "Pause On Full Items";
            this.AD_StopOnFullItems_Checkbox.UseVisualStyleBackColor = true;
            this.AD_StopOnFullItems_Checkbox.CheckedChanged += new System.EventHandler(this.AD_StopOnFullItems_Checkbox_CheckedChanged);
            // 
            // AD_formationComboBox
            // 
            this.AD_formationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_formationComboBox.FormattingEnabled = true;
            this.AD_formationComboBox.Items.AddRange(new object[] {
            "--",
            "2 Front / 3 Back",
            "3 Front / 2 Back",
            "1 Front / 4 Back",
            "4 Front / 1 Back"});
            this.AD_formationComboBox.Location = new System.Drawing.Point(77, 48);
            this.AD_formationComboBox.Name = "AD_formationComboBox";
            this.AD_formationComboBox.Size = new System.Drawing.Size(127, 21);
            this.AD_formationComboBox.TabIndex = 11;
            this.AD_formationComboBox.Tag = "0";
            this.AD_formationComboBox.SelectedIndexChanged += new System.EventHandler(this.formationComboBox_SelectedIndexChanged);
            // 
            // AD_StopOnFullHeroes_Checkbox
            // 
            this.AD_StopOnFullHeroes_Checkbox.AutoSize = true;
            this.AD_StopOnFullHeroes_Checkbox.Location = new System.Drawing.Point(274, 40);
            this.AD_StopOnFullHeroes_Checkbox.Name = "AD_StopOnFullHeroes_Checkbox";
            this.AD_StopOnFullHeroes_Checkbox.Size = new System.Drawing.Size(112, 17);
            this.AD_StopOnFullHeroes_Checkbox.TabIndex = 25;
            this.AD_StopOnFullHeroes_Checkbox.Text = "Pause Full Heroes";
            this.AD_StopOnFullHeroes_Checkbox.UseVisualStyleBackColor = true;
            this.AD_StopOnFullHeroes_Checkbox.CheckedChanged += new System.EventHandler(this.AD_StopOnFullHeroes_Checkbox_CheckedChanged);
            // 
            // AD_teamComboBox
            // 
            this.AD_teamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_teamComboBox.FormattingEnabled = true;
            this.AD_teamComboBox.Items.AddRange(new object[] {
            "--",
            "A",
            "B",
            "C"});
            this.AD_teamComboBox.Location = new System.Drawing.Point(77, 22);
            this.AD_teamComboBox.Name = "AD_teamComboBox";
            this.AD_teamComboBox.Size = new System.Drawing.Size(52, 21);
            this.AD_teamComboBox.TabIndex = 9;
            this.AD_teamComboBox.Tag = "0";
            this.AD_teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // AD_stageComboBox
            // 
            this.AD_stageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_stageComboBox.FormattingEnabled = true;
            this.AD_stageComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.AD_stageComboBox.Location = new System.Drawing.Point(70, 46);
            this.AD_stageComboBox.Name = "AD_stageComboBox";
            this.AD_stageComboBox.Size = new System.Drawing.Size(52, 21);
            this.AD_stageComboBox.TabIndex = 3;
            this.AD_stageComboBox.SelectedIndexChanged += new System.EventHandler(this.AD_stageComboBox_SelectedIndexChanged);
            // 
            // AD_worldComboBox
            // 
            this.AD_worldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_worldComboBox.FormattingEnabled = true;
            this.AD_worldComboBox.Items.AddRange(new object[] {
            "-- Quick Start",
            "-- Sequencer",
            "1 - Mystic Woods",
            "2 - Silent Mine",
            "3 - Blazing Desert",
            "4 - Dark Grave",
            "5 - Dragon Ruins",
            "6 - Frozen Land",
            "7 - Purgatory",
            "8 - Moonlit Isle",
            "9 - Western Empire",
            "10 - Eastern Empire",
            "11 - Dark Sanctuary",
            "12 - Shadow\'s EYE"});
            this.AD_worldComboBox.Location = new System.Drawing.Point(69, 16);
            this.AD_worldComboBox.Name = "AD_worldComboBox";
            this.AD_worldComboBox.Size = new System.Drawing.Size(127, 21);
            this.AD_worldComboBox.TabIndex = 1;
            this.AD_worldComboBox.SelectedIndexChanged += new System.EventHandler(this.AD_worldComboBox_SelectedIndexChanged);
            // 
            // AD_elementHeroesCheckBox
            // 
            this.AD_elementHeroesCheckBox.AutoSize = true;
            this.AD_elementHeroesCheckBox.Location = new System.Drawing.Point(6, 42);
            this.AD_elementHeroesCheckBox.Name = "AD_elementHeroesCheckBox";
            this.AD_elementHeroesCheckBox.Size = new System.Drawing.Size(86, 17);
            this.AD_elementHeroesCheckBox.TabIndex = 13;
            this.AD_elementHeroesCheckBox.Text = "Element First";
            this.AD_elementHeroesCheckBox.UseVisualStyleBackColor = true;
            this.AD_elementHeroesCheckBox.CheckedChanged += new System.EventHandler(this.AD_elementHeroesCheckBox_CheckedChanged);
            // 
            // AD_formationPanel
            // 
            this.AD_formationPanel.BackColor = System.Drawing.Color.Silver;
            this.AD_formationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AD_formationPanel.Controls.Add(this.AD_pos5CheckBox);
            this.AD_formationPanel.Controls.Add(this.AD_pos4CheckBox);
            this.AD_formationPanel.Controls.Add(this.AD_pos3CheckBox);
            this.AD_formationPanel.Controls.Add(this.AD_pos2CheckBox);
            this.AD_formationPanel.Controls.Add(this.AD_pos1CheckBox);
            this.AD_formationPanel.Location = new System.Drawing.Point(77, 77);
            this.AD_formationPanel.Name = "AD_formationPanel";
            this.AD_formationPanel.Size = new System.Drawing.Size(80, 85);
            this.AD_formationPanel.TabIndex = 12;
            this.AD_formationPanel.Tag = "0";
            // 
            // AD_pos5CheckBox
            // 
            this.AD_pos5CheckBox.AutoSize = true;
            this.AD_pos5CheckBox.Location = new System.Drawing.Point(3, 61);
            this.AD_pos5CheckBox.Name = "AD_pos5CheckBox";
            this.AD_pos5CheckBox.Size = new System.Drawing.Size(15, 14);
            this.AD_pos5CheckBox.TabIndex = 4;
            this.AD_pos5CheckBox.Tag = "4";
            this.AD_pos5CheckBox.UseVisualStyleBackColor = true;
            this.AD_pos5CheckBox.Visible = false;
            this.AD_pos5CheckBox.CheckedChanged += new System.EventHandler(this.AD_posCheckBox_CheckedChanged);
            // 
            // AD_pos4CheckBox
            // 
            this.AD_pos4CheckBox.AutoSize = true;
            this.AD_pos4CheckBox.Location = new System.Drawing.Point(3, 48);
            this.AD_pos4CheckBox.Name = "AD_pos4CheckBox";
            this.AD_pos4CheckBox.Size = new System.Drawing.Size(15, 14);
            this.AD_pos4CheckBox.TabIndex = 3;
            this.AD_pos4CheckBox.Tag = "3";
            this.AD_pos4CheckBox.UseVisualStyleBackColor = true;
            this.AD_pos4CheckBox.Visible = false;
            this.AD_pos4CheckBox.CheckedChanged += new System.EventHandler(this.AD_posCheckBox_CheckedChanged);
            // 
            // AD_pos3CheckBox
            // 
            this.AD_pos3CheckBox.AutoSize = true;
            this.AD_pos3CheckBox.Location = new System.Drawing.Point(3, 35);
            this.AD_pos3CheckBox.Name = "AD_pos3CheckBox";
            this.AD_pos3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.AD_pos3CheckBox.TabIndex = 2;
            this.AD_pos3CheckBox.Tag = "2";
            this.AD_pos3CheckBox.UseVisualStyleBackColor = true;
            this.AD_pos3CheckBox.Visible = false;
            this.AD_pos3CheckBox.CheckedChanged += new System.EventHandler(this.AD_posCheckBox_CheckedChanged);
            // 
            // AD_pos2CheckBox
            // 
            this.AD_pos2CheckBox.AutoSize = true;
            this.AD_pos2CheckBox.Location = new System.Drawing.Point(3, 22);
            this.AD_pos2CheckBox.Name = "AD_pos2CheckBox";
            this.AD_pos2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.AD_pos2CheckBox.TabIndex = 1;
            this.AD_pos2CheckBox.Tag = "1";
            this.AD_pos2CheckBox.UseVisualStyleBackColor = true;
            this.AD_pos2CheckBox.Visible = false;
            this.AD_pos2CheckBox.CheckedChanged += new System.EventHandler(this.AD_posCheckBox_CheckedChanged);
            // 
            // AD_pos1CheckBox
            // 
            this.AD_pos1CheckBox.AutoSize = true;
            this.AD_pos1CheckBox.Location = new System.Drawing.Point(3, 9);
            this.AD_pos1CheckBox.Name = "AD_pos1CheckBox";
            this.AD_pos1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.AD_pos1CheckBox.TabIndex = 0;
            this.AD_pos1CheckBox.Tag = "0";
            this.AD_pos1CheckBox.UseVisualStyleBackColor = true;
            this.AD_pos1CheckBox.Visible = false;
            this.AD_pos1CheckBox.CheckedChanged += new System.EventHandler(this.AD_posCheckBox_CheckedChanged);
            // 
            // AD_formationLabel
            // 
            this.AD_formationLabel.Location = new System.Drawing.Point(8, 51);
            this.AD_formationLabel.Name = "AD_formationLabel";
            this.AD_formationLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_formationLabel.TabIndex = 10;
            this.AD_formationLabel.Text = "Formation";
            // 
            // AD_teamLabel
            // 
            this.AD_teamLabel.Location = new System.Drawing.Point(9, 24);
            this.AD_teamLabel.Name = "AD_teamLabel";
            this.AD_teamLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_teamLabel.TabIndex = 8;
            this.AD_teamLabel.Text = "Team";
            // 
            // AD_stageLabel
            // 
            this.AD_stageLabel.Location = new System.Drawing.Point(6, 51);
            this.AD_stageLabel.Name = "AD_stageLabel";
            this.AD_stageLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_stageLabel.TabIndex = 2;
            this.AD_stageLabel.Text = "Stage";
            // 
            // AD_worldLabel
            // 
            this.AD_worldLabel.Location = new System.Drawing.Point(6, 19);
            this.AD_worldLabel.Name = "AD_worldLabel";
            this.AD_worldLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_worldLabel.TabIndex = 0;
            this.AD_worldLabel.Text = "World";
            // 
            // AD_difficultyComboBox
            // 
            this.AD_difficultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_difficultyComboBox.FormattingEnabled = true;
            this.AD_difficultyComboBox.Items.AddRange(new object[] {
            "--",
            "Easy",
            "Normal",
            "Hard"});
            this.AD_difficultyComboBox.Location = new System.Drawing.Point(69, 95);
            this.AD_difficultyComboBox.MaxDropDownItems = 3;
            this.AD_difficultyComboBox.Name = "AD_difficultyComboBox";
            this.AD_difficultyComboBox.Size = new System.Drawing.Size(60, 21);
            this.AD_difficultyComboBox.TabIndex = 7;
            this.toolTip.SetToolTip(this.AD_difficultyComboBox, "For Map 1 to Map 7");
            this.AD_difficultyComboBox.SelectedValueChanged += new System.EventHandler(this.AD_difficultyComboBox_SelectedValueChanged);
            // 
            // AD_skillGroupBox
            // 
            this.AD_skillGroupBox.Controls.Add(this.AD_bothSkillRadio);
            this.AD_skillGroupBox.Controls.Add(this.AD_wave3Panel);
            this.AD_skillGroupBox.Controls.Add(this.AD_wave2Panel);
            this.AD_skillGroupBox.Controls.Add(this.AD_manualSkillRadio);
            this.AD_skillGroupBox.Controls.Add(this.AD_autoSkillRadio);
            this.AD_skillGroupBox.Controls.Add(this.AD_wave1Panel);
            this.AD_skillGroupBox.Location = new System.Drawing.Point(231, 2);
            this.AD_skillGroupBox.Name = "AD_skillGroupBox";
            this.AD_skillGroupBox.Size = new System.Drawing.Size(254, 334);
            this.AD_skillGroupBox.TabIndex = 14;
            this.AD_skillGroupBox.TabStop = false;
            this.AD_skillGroupBox.Tag = "0";
            this.AD_skillGroupBox.Text = "Skill Management";
            // 
            // AD_bothSkillRadio
            // 
            this.AD_bothSkillRadio.AutoSize = true;
            this.AD_bothSkillRadio.Location = new System.Drawing.Point(200, 12);
            this.AD_bothSkillRadio.Name = "AD_bothSkillRadio";
            this.AD_bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.AD_bothSkillRadio.TabIndex = 9;
            this.AD_bothSkillRadio.Tag = "2";
            this.AD_bothSkillRadio.Text = "Both";
            this.AD_bothSkillRadio.UseVisualStyleBackColor = true;
            this.AD_bothSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // AD_wave3Panel
            // 
            this.AD_wave3Panel.Controls.Add(this.AD_w3bothSkillRadio);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill11Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill12Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3manualSkillRadio);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill13Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3autoSkillRadio);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill14Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill15Button);
            this.AD_wave3Panel.Controls.Add(this.AD_wave3LoopCheckBox);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill10Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill09Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill08Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill07Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill06Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill05Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill04Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill03Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill02Button);
            this.AD_wave3Panel.Controls.Add(this.AD_wave3Label);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill01Button);
            this.AD_wave3Panel.Location = new System.Drawing.Point(9, 227);
            this.AD_wave3Panel.Name = "AD_wave3Panel";
            this.AD_wave3Panel.Size = new System.Drawing.Size(241, 102);
            this.AD_wave3Panel.TabIndex = 12;
            this.AD_wave3Panel.Tag = "2";
            // 
            // AD_w3bothSkillRadio
            // 
            this.AD_w3bothSkillRadio.AutoSize = true;
            this.AD_w3bothSkillRadio.Location = new System.Drawing.Point(192, 3);
            this.AD_w3bothSkillRadio.Name = "AD_w3bothSkillRadio";
            this.AD_w3bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.AD_w3bothSkillRadio.TabIndex = 13;
            this.AD_w3bothSkillRadio.Text = "Both";
            this.AD_w3bothSkillRadio.UseVisualStyleBackColor = true;
            this.AD_w3bothSkillRadio.CheckedChanged += new System.EventHandler(this.AD_w3bothSkillRadio_CheckedChanged);
            // 
            // AD_w3Skill11Button
            // 
            this.AD_w3Skill11Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w3Skill11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill11Button.Location = new System.Drawing.Point(78, 23);
            this.AD_w3Skill11Button.Name = "AD_w3Skill11Button";
            this.AD_w3Skill11Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill11Button.TabIndex = 11;
            this.AD_w3Skill11Button.Tag = "10";
            this.AD_w3Skill11Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill11Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill12Button
            // 
            this.AD_w3Skill12Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w3Skill12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill12Button.Location = new System.Drawing.Point(110, 23);
            this.AD_w3Skill12Button.Name = "AD_w3Skill12Button";
            this.AD_w3Skill12Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill12Button.TabIndex = 12;
            this.AD_w3Skill12Button.Tag = "11";
            this.AD_w3Skill12Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill12Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3manualSkillRadio
            // 
            this.AD_w3manualSkillRadio.AutoSize = true;
            this.AD_w3manualSkillRadio.Location = new System.Drawing.Point(129, 3);
            this.AD_w3manualSkillRadio.Name = "AD_w3manualSkillRadio";
            this.AD_w3manualSkillRadio.Size = new System.Drawing.Size(60, 17);
            this.AD_w3manualSkillRadio.TabIndex = 13;
            this.AD_w3manualSkillRadio.Text = "Manual";
            this.AD_w3manualSkillRadio.UseVisualStyleBackColor = true;
            this.AD_w3manualSkillRadio.CheckedChanged += new System.EventHandler(this.AD_w3manualSkillRadio_CheckedChanged);
            // 
            // AD_w3Skill13Button
            // 
            this.AD_w3Skill13Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w3Skill13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill13Button.Location = new System.Drawing.Point(142, 23);
            this.AD_w3Skill13Button.Name = "AD_w3Skill13Button";
            this.AD_w3Skill13Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill13Button.TabIndex = 13;
            this.AD_w3Skill13Button.Tag = "12";
            this.AD_w3Skill13Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill13Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3autoSkillRadio
            // 
            this.AD_w3autoSkillRadio.AutoSize = true;
            this.AD_w3autoSkillRadio.Checked = true;
            this.AD_w3autoSkillRadio.Location = new System.Drawing.Point(78, 3);
            this.AD_w3autoSkillRadio.Name = "AD_w3autoSkillRadio";
            this.AD_w3autoSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.AD_w3autoSkillRadio.TabIndex = 13;
            this.AD_w3autoSkillRadio.TabStop = true;
            this.AD_w3autoSkillRadio.Text = "Auto";
            this.AD_w3autoSkillRadio.UseVisualStyleBackColor = true;
            this.AD_w3autoSkillRadio.CheckedChanged += new System.EventHandler(this.AD_w3autoSkillRadio_CheckedChanged);
            // 
            // AD_w3Skill14Button
            // 
            this.AD_w3Skill14Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w3Skill14Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill14Button.Location = new System.Drawing.Point(174, 23);
            this.AD_w3Skill14Button.Name = "AD_w3Skill14Button";
            this.AD_w3Skill14Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill14Button.TabIndex = 14;
            this.AD_w3Skill14Button.Tag = "13";
            this.AD_w3Skill14Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill14Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill15Button
            // 
            this.AD_w3Skill15Button.BackColor = System.Drawing.Color.Transparent;
            this.AD_w3Skill15Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w3Skill15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill15Button.Location = new System.Drawing.Point(206, 23);
            this.AD_w3Skill15Button.Name = "AD_w3Skill15Button";
            this.AD_w3Skill15Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill15Button.TabIndex = 15;
            this.AD_w3Skill15Button.Tag = "14";
            this.AD_w3Skill15Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill15Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave3LoopCheckBox
            // 
            this.AD_wave3LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.AD_wave3LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_wave3LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.AD_wave3LoopCheckBox.Name = "AD_wave3LoopCheckBox";
            this.AD_wave3LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.AD_wave3LoopCheckBox.TabIndex = 24;
            this.AD_wave3LoopCheckBox.Text = "Loop";
            this.AD_wave3LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AD_wave3LoopCheckBox.UseVisualStyleBackColor = true;
            this.AD_wave3LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // AD_w3Skill10Button
            // 
            this.AD_w3Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill10Button.Location = new System.Drawing.Point(206, 75);
            this.AD_w3Skill10Button.Name = "AD_w3Skill10Button";
            this.AD_w3Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill10Button.TabIndex = 10;
            this.AD_w3Skill10Button.Tag = "9";
            this.AD_w3Skill10Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill09Button
            // 
            this.AD_w3Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill09Button.Location = new System.Drawing.Point(174, 75);
            this.AD_w3Skill09Button.Name = "AD_w3Skill09Button";
            this.AD_w3Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill09Button.TabIndex = 9;
            this.AD_w3Skill09Button.Tag = "8";
            this.AD_w3Skill09Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill08Button
            // 
            this.AD_w3Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill08Button.Location = new System.Drawing.Point(142, 75);
            this.AD_w3Skill08Button.Name = "AD_w3Skill08Button";
            this.AD_w3Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill08Button.TabIndex = 8;
            this.AD_w3Skill08Button.Tag = "7";
            this.AD_w3Skill08Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill07Button
            // 
            this.AD_w3Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill07Button.Location = new System.Drawing.Point(110, 75);
            this.AD_w3Skill07Button.Name = "AD_w3Skill07Button";
            this.AD_w3Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill07Button.TabIndex = 7;
            this.AD_w3Skill07Button.Tag = "6";
            this.AD_w3Skill07Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill06Button
            // 
            this.AD_w3Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill06Button.Location = new System.Drawing.Point(78, 75);
            this.AD_w3Skill06Button.Name = "AD_w3Skill06Button";
            this.AD_w3Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill06Button.TabIndex = 6;
            this.AD_w3Skill06Button.Tag = "5";
            this.AD_w3Skill06Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill05Button
            // 
            this.AD_w3Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill05Button.Location = new System.Drawing.Point(206, 51);
            this.AD_w3Skill05Button.Name = "AD_w3Skill05Button";
            this.AD_w3Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill05Button.TabIndex = 5;
            this.AD_w3Skill05Button.Tag = "4";
            this.AD_w3Skill05Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill04Button
            // 
            this.AD_w3Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill04Button.Location = new System.Drawing.Point(174, 51);
            this.AD_w3Skill04Button.Name = "AD_w3Skill04Button";
            this.AD_w3Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill04Button.TabIndex = 4;
            this.AD_w3Skill04Button.Tag = "3";
            this.AD_w3Skill04Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill03Button
            // 
            this.AD_w3Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill03Button.Location = new System.Drawing.Point(142, 51);
            this.AD_w3Skill03Button.Name = "AD_w3Skill03Button";
            this.AD_w3Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill03Button.TabIndex = 3;
            this.AD_w3Skill03Button.Tag = "2";
            this.AD_w3Skill03Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill02Button
            // 
            this.AD_w3Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill02Button.Location = new System.Drawing.Point(110, 51);
            this.AD_w3Skill02Button.Name = "AD_w3Skill02Button";
            this.AD_w3Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill02Button.TabIndex = 2;
            this.AD_w3Skill02Button.Tag = "1";
            this.AD_w3Skill02Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave3Label
            // 
            this.AD_wave3Label.Location = new System.Drawing.Point(6, 7);
            this.AD_wave3Label.Name = "AD_wave3Label";
            this.AD_wave3Label.Size = new System.Drawing.Size(60, 13);
            this.AD_wave3Label.TabIndex = 0;
            this.AD_wave3Label.Text = "Wave 3";
            // 
            // AD_w3Skill01Button
            // 
            this.AD_w3Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill01Button.Location = new System.Drawing.Point(78, 51);
            this.AD_w3Skill01Button.Name = "AD_w3Skill01Button";
            this.AD_w3Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill01Button.TabIndex = 1;
            this.AD_w3Skill01Button.Tag = "0";
            this.AD_w3Skill01Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave2Panel
            // 
            this.AD_wave2Panel.Controls.Add(this.AD_w2bothSkillRadio);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill11Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2manualSkillRadio);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill12Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2autoSkillRadio);
            this.AD_wave2Panel.Controls.Add(this.AD_wave2LoopCheckBox);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill13Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill10Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill14Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill09Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill15Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill08Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill07Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill06Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill05Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill04Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill03Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill02Button);
            this.AD_wave2Panel.Controls.Add(this.AD_wave2Label);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill01Button);
            this.AD_wave2Panel.Location = new System.Drawing.Point(9, 119);
            this.AD_wave2Panel.Name = "AD_wave2Panel";
            this.AD_wave2Panel.Size = new System.Drawing.Size(241, 102);
            this.AD_wave2Panel.TabIndex = 11;
            this.AD_wave2Panel.Tag = "1";
            // 
            // AD_w2bothSkillRadio
            // 
            this.AD_w2bothSkillRadio.AutoSize = true;
            this.AD_w2bothSkillRadio.Location = new System.Drawing.Point(192, 3);
            this.AD_w2bothSkillRadio.Name = "AD_w2bothSkillRadio";
            this.AD_w2bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.AD_w2bothSkillRadio.TabIndex = 13;
            this.AD_w2bothSkillRadio.Text = "Both";
            this.AD_w2bothSkillRadio.UseVisualStyleBackColor = true;
            this.AD_w2bothSkillRadio.CheckedChanged += new System.EventHandler(this.AD_w2bothSkillRadio_CheckedChanged);
            // 
            // AD_w2Skill11Button
            // 
            this.AD_w2Skill11Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w2Skill11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill11Button.Location = new System.Drawing.Point(78, 24);
            this.AD_w2Skill11Button.Name = "AD_w2Skill11Button";
            this.AD_w2Skill11Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill11Button.TabIndex = 11;
            this.AD_w2Skill11Button.Tag = "10";
            this.AD_w2Skill11Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill11Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2manualSkillRadio
            // 
            this.AD_w2manualSkillRadio.AutoSize = true;
            this.AD_w2manualSkillRadio.Location = new System.Drawing.Point(129, 3);
            this.AD_w2manualSkillRadio.Name = "AD_w2manualSkillRadio";
            this.AD_w2manualSkillRadio.Size = new System.Drawing.Size(60, 17);
            this.AD_w2manualSkillRadio.TabIndex = 13;
            this.AD_w2manualSkillRadio.Text = "Manual";
            this.AD_w2manualSkillRadio.UseVisualStyleBackColor = true;
            this.AD_w2manualSkillRadio.CheckedChanged += new System.EventHandler(this.AD_w2manualSkillRadio_CheckedChanged);
            // 
            // AD_w2Skill12Button
            // 
            this.AD_w2Skill12Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w2Skill12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill12Button.Location = new System.Drawing.Point(110, 24);
            this.AD_w2Skill12Button.Name = "AD_w2Skill12Button";
            this.AD_w2Skill12Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill12Button.TabIndex = 12;
            this.AD_w2Skill12Button.Tag = "11";
            this.AD_w2Skill12Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill12Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2autoSkillRadio
            // 
            this.AD_w2autoSkillRadio.AutoSize = true;
            this.AD_w2autoSkillRadio.Checked = true;
            this.AD_w2autoSkillRadio.Location = new System.Drawing.Point(78, 3);
            this.AD_w2autoSkillRadio.Name = "AD_w2autoSkillRadio";
            this.AD_w2autoSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.AD_w2autoSkillRadio.TabIndex = 13;
            this.AD_w2autoSkillRadio.TabStop = true;
            this.AD_w2autoSkillRadio.Text = "Auto";
            this.AD_w2autoSkillRadio.UseVisualStyleBackColor = true;
            this.AD_w2autoSkillRadio.CheckedChanged += new System.EventHandler(this.AD_w2autoSkillRadio_CheckedChanged);
            // 
            // AD_wave2LoopCheckBox
            // 
            this.AD_wave2LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.AD_wave2LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_wave2LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.AD_wave2LoopCheckBox.Name = "AD_wave2LoopCheckBox";
            this.AD_wave2LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.AD_wave2LoopCheckBox.TabIndex = 24;
            this.AD_wave2LoopCheckBox.Text = "Loop";
            this.AD_wave2LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AD_wave2LoopCheckBox.UseVisualStyleBackColor = true;
            this.AD_wave2LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // AD_w2Skill13Button
            // 
            this.AD_w2Skill13Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w2Skill13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill13Button.Location = new System.Drawing.Point(142, 24);
            this.AD_w2Skill13Button.Name = "AD_w2Skill13Button";
            this.AD_w2Skill13Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill13Button.TabIndex = 13;
            this.AD_w2Skill13Button.Tag = "12";
            this.AD_w2Skill13Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill13Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill10Button
            // 
            this.AD_w2Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill10Button.Location = new System.Drawing.Point(206, 76);
            this.AD_w2Skill10Button.Name = "AD_w2Skill10Button";
            this.AD_w2Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill10Button.TabIndex = 10;
            this.AD_w2Skill10Button.Tag = "9";
            this.AD_w2Skill10Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill14Button
            // 
            this.AD_w2Skill14Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w2Skill14Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill14Button.Location = new System.Drawing.Point(174, 24);
            this.AD_w2Skill14Button.Name = "AD_w2Skill14Button";
            this.AD_w2Skill14Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill14Button.TabIndex = 14;
            this.AD_w2Skill14Button.Tag = "13";
            this.AD_w2Skill14Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill14Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill09Button
            // 
            this.AD_w2Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill09Button.Location = new System.Drawing.Point(174, 76);
            this.AD_w2Skill09Button.Name = "AD_w2Skill09Button";
            this.AD_w2Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill09Button.TabIndex = 9;
            this.AD_w2Skill09Button.Tag = "8";
            this.AD_w2Skill09Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill15Button
            // 
            this.AD_w2Skill15Button.BackColor = System.Drawing.Color.Transparent;
            this.AD_w2Skill15Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w2Skill15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill15Button.Location = new System.Drawing.Point(206, 24);
            this.AD_w2Skill15Button.Name = "AD_w2Skill15Button";
            this.AD_w2Skill15Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill15Button.TabIndex = 15;
            this.AD_w2Skill15Button.Tag = "14";
            this.AD_w2Skill15Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill15Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill08Button
            // 
            this.AD_w2Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill08Button.Location = new System.Drawing.Point(142, 76);
            this.AD_w2Skill08Button.Name = "AD_w2Skill08Button";
            this.AD_w2Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill08Button.TabIndex = 8;
            this.AD_w2Skill08Button.Tag = "7";
            this.AD_w2Skill08Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill07Button
            // 
            this.AD_w2Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill07Button.Location = new System.Drawing.Point(110, 76);
            this.AD_w2Skill07Button.Name = "AD_w2Skill07Button";
            this.AD_w2Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill07Button.TabIndex = 7;
            this.AD_w2Skill07Button.Tag = "6";
            this.AD_w2Skill07Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill06Button
            // 
            this.AD_w2Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill06Button.Location = new System.Drawing.Point(78, 76);
            this.AD_w2Skill06Button.Name = "AD_w2Skill06Button";
            this.AD_w2Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill06Button.TabIndex = 6;
            this.AD_w2Skill06Button.Tag = "5";
            this.AD_w2Skill06Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill05Button
            // 
            this.AD_w2Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill05Button.Location = new System.Drawing.Point(206, 52);
            this.AD_w2Skill05Button.Name = "AD_w2Skill05Button";
            this.AD_w2Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill05Button.TabIndex = 5;
            this.AD_w2Skill05Button.Tag = "4";
            this.AD_w2Skill05Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill04Button
            // 
            this.AD_w2Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill04Button.Location = new System.Drawing.Point(174, 52);
            this.AD_w2Skill04Button.Name = "AD_w2Skill04Button";
            this.AD_w2Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill04Button.TabIndex = 4;
            this.AD_w2Skill04Button.Tag = "3";
            this.AD_w2Skill04Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill03Button
            // 
            this.AD_w2Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill03Button.Location = new System.Drawing.Point(142, 52);
            this.AD_w2Skill03Button.Name = "AD_w2Skill03Button";
            this.AD_w2Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill03Button.TabIndex = 3;
            this.AD_w2Skill03Button.Tag = "2";
            this.AD_w2Skill03Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill02Button
            // 
            this.AD_w2Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill02Button.Location = new System.Drawing.Point(110, 52);
            this.AD_w2Skill02Button.Name = "AD_w2Skill02Button";
            this.AD_w2Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill02Button.TabIndex = 2;
            this.AD_w2Skill02Button.Tag = "1";
            this.AD_w2Skill02Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave2Label
            // 
            this.AD_wave2Label.Location = new System.Drawing.Point(6, 7);
            this.AD_wave2Label.Name = "AD_wave2Label";
            this.AD_wave2Label.Size = new System.Drawing.Size(60, 13);
            this.AD_wave2Label.TabIndex = 0;
            this.AD_wave2Label.Text = "Wave 2";
            // 
            // AD_w2Skill01Button
            // 
            this.AD_w2Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill01Button.Location = new System.Drawing.Point(78, 52);
            this.AD_w2Skill01Button.Name = "AD_w2Skill01Button";
            this.AD_w2Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill01Button.TabIndex = 1;
            this.AD_w2Skill01Button.Tag = "0";
            this.AD_w2Skill01Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_manualSkillRadio
            // 
            this.AD_manualSkillRadio.AutoSize = true;
            this.AD_manualSkillRadio.Location = new System.Drawing.Point(138, 12);
            this.AD_manualSkillRadio.Name = "AD_manualSkillRadio";
            this.AD_manualSkillRadio.Size = new System.Drawing.Size(60, 17);
            this.AD_manualSkillRadio.TabIndex = 8;
            this.AD_manualSkillRadio.Tag = "1";
            this.AD_manualSkillRadio.Text = "Manual";
            this.AD_manualSkillRadio.UseVisualStyleBackColor = true;
            this.AD_manualSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // AD_autoSkillRadio
            // 
            this.AD_autoSkillRadio.AutoSize = true;
            this.AD_autoSkillRadio.Checked = true;
            this.AD_autoSkillRadio.Location = new System.Drawing.Point(86, 12);
            this.AD_autoSkillRadio.Name = "AD_autoSkillRadio";
            this.AD_autoSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.AD_autoSkillRadio.TabIndex = 7;
            this.AD_autoSkillRadio.TabStop = true;
            this.AD_autoSkillRadio.Tag = "0";
            this.AD_autoSkillRadio.Text = "Auto";
            this.AD_autoSkillRadio.UseVisualStyleBackColor = true;
            this.AD_autoSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // AD_wave1Panel
            // 
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill11Button);
            this.AD_wave1Panel.Controls.Add(this.AD_wave1LoopCheckBox);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill12Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill10Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill09Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill13Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill08Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill07Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill14Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill06Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill05Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill15Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill04Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill03Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill02Button);
            this.AD_wave1Panel.Controls.Add(this.AD_wave1Label);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill01Button);
            this.AD_wave1Panel.Location = new System.Drawing.Point(9, 32);
            this.AD_wave1Panel.Name = "AD_wave1Panel";
            this.AD_wave1Panel.Size = new System.Drawing.Size(241, 82);
            this.AD_wave1Panel.TabIndex = 10;
            this.AD_wave1Panel.Tag = "0";
            // 
            // AD_w1Skill11Button
            // 
            this.AD_w1Skill11Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w1Skill11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill11Button.Location = new System.Drawing.Point(78, 4);
            this.AD_w1Skill11Button.Name = "AD_w1Skill11Button";
            this.AD_w1Skill11Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill11Button.TabIndex = 11;
            this.AD_w1Skill11Button.Tag = "10";
            this.AD_w1Skill11Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill11Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave1LoopCheckBox
            // 
            this.AD_wave1LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.AD_wave1LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_wave1LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.AD_wave1LoopCheckBox.Name = "AD_wave1LoopCheckBox";
            this.AD_wave1LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.AD_wave1LoopCheckBox.TabIndex = 11;
            this.AD_wave1LoopCheckBox.Text = "Loop";
            this.AD_wave1LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AD_wave1LoopCheckBox.UseVisualStyleBackColor = true;
            this.AD_wave1LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // AD_w1Skill12Button
            // 
            this.AD_w1Skill12Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w1Skill12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill12Button.Location = new System.Drawing.Point(110, 4);
            this.AD_w1Skill12Button.Name = "AD_w1Skill12Button";
            this.AD_w1Skill12Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill12Button.TabIndex = 12;
            this.AD_w1Skill12Button.Tag = "11";
            this.AD_w1Skill12Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill12Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill10Button
            // 
            this.AD_w1Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill10Button.Location = new System.Drawing.Point(206, 56);
            this.AD_w1Skill10Button.Name = "AD_w1Skill10Button";
            this.AD_w1Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill10Button.TabIndex = 10;
            this.AD_w1Skill10Button.Tag = "9";
            this.AD_w1Skill10Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill09Button
            // 
            this.AD_w1Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill09Button.Location = new System.Drawing.Point(174, 56);
            this.AD_w1Skill09Button.Name = "AD_w1Skill09Button";
            this.AD_w1Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill09Button.TabIndex = 9;
            this.AD_w1Skill09Button.Tag = "8";
            this.AD_w1Skill09Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill13Button
            // 
            this.AD_w1Skill13Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w1Skill13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill13Button.Location = new System.Drawing.Point(142, 4);
            this.AD_w1Skill13Button.Name = "AD_w1Skill13Button";
            this.AD_w1Skill13Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill13Button.TabIndex = 13;
            this.AD_w1Skill13Button.Tag = "12";
            this.AD_w1Skill13Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill13Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill08Button
            // 
            this.AD_w1Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill08Button.Location = new System.Drawing.Point(142, 56);
            this.AD_w1Skill08Button.Name = "AD_w1Skill08Button";
            this.AD_w1Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill08Button.TabIndex = 8;
            this.AD_w1Skill08Button.Tag = "7";
            this.AD_w1Skill08Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill07Button
            // 
            this.AD_w1Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill07Button.Location = new System.Drawing.Point(110, 56);
            this.AD_w1Skill07Button.Name = "AD_w1Skill07Button";
            this.AD_w1Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill07Button.TabIndex = 7;
            this.AD_w1Skill07Button.Tag = "6";
            this.AD_w1Skill07Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill14Button
            // 
            this.AD_w1Skill14Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w1Skill14Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill14Button.Location = new System.Drawing.Point(174, 4);
            this.AD_w1Skill14Button.Name = "AD_w1Skill14Button";
            this.AD_w1Skill14Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill14Button.TabIndex = 14;
            this.AD_w1Skill14Button.Tag = "13";
            this.AD_w1Skill14Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill14Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill06Button
            // 
            this.AD_w1Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill06Button.Location = new System.Drawing.Point(78, 56);
            this.AD_w1Skill06Button.Name = "AD_w1Skill06Button";
            this.AD_w1Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill06Button.TabIndex = 6;
            this.AD_w1Skill06Button.Tag = "5";
            this.AD_w1Skill06Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill05Button
            // 
            this.AD_w1Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill05Button.Location = new System.Drawing.Point(206, 32);
            this.AD_w1Skill05Button.Name = "AD_w1Skill05Button";
            this.AD_w1Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill05Button.TabIndex = 5;
            this.AD_w1Skill05Button.Tag = "4";
            this.AD_w1Skill05Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill15Button
            // 
            this.AD_w1Skill15Button.BackColor = System.Drawing.Color.Transparent;
            this.AD_w1Skill15Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w1Skill15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill15Button.Location = new System.Drawing.Point(206, 4);
            this.AD_w1Skill15Button.Name = "AD_w1Skill15Button";
            this.AD_w1Skill15Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill15Button.TabIndex = 15;
            this.AD_w1Skill15Button.Tag = "14";
            this.AD_w1Skill15Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill15Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill04Button
            // 
            this.AD_w1Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill04Button.Location = new System.Drawing.Point(174, 32);
            this.AD_w1Skill04Button.Name = "AD_w1Skill04Button";
            this.AD_w1Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill04Button.TabIndex = 4;
            this.AD_w1Skill04Button.Tag = "3";
            this.AD_w1Skill04Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill03Button
            // 
            this.AD_w1Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill03Button.Location = new System.Drawing.Point(142, 32);
            this.AD_w1Skill03Button.Name = "AD_w1Skill03Button";
            this.AD_w1Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill03Button.TabIndex = 3;
            this.AD_w1Skill03Button.Tag = "2";
            this.AD_w1Skill03Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill02Button
            // 
            this.AD_w1Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill02Button.Location = new System.Drawing.Point(110, 32);
            this.AD_w1Skill02Button.Name = "AD_w1Skill02Button";
            this.AD_w1Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill02Button.TabIndex = 2;
            this.AD_w1Skill02Button.Tag = "1";
            this.AD_w1Skill02Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave1Label
            // 
            this.AD_wave1Label.Location = new System.Drawing.Point(6, 7);
            this.AD_wave1Label.Name = "AD_wave1Label";
            this.AD_wave1Label.Size = new System.Drawing.Size(60, 13);
            this.AD_wave1Label.TabIndex = 0;
            this.AD_wave1Label.Text = "Wave 1";
            // 
            // AD_w1Skill01Button
            // 
            this.AD_w1Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill01Button.Location = new System.Drawing.Point(78, 32);
            this.AD_w1Skill01Button.Name = "AD_w1Skill01Button";
            this.AD_w1Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill01Button.TabIndex = 1;
            this.AD_w1Skill01Button.Tag = "0";
            this.AD_w1Skill01Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Difficulty (Map 8+)";
            // 
            // AD_difficultyLabel
            // 
            this.AD_difficultyLabel.Location = new System.Drawing.Point(6, 103);
            this.AD_difficultyLabel.Name = "AD_difficultyLabel";
            this.AD_difficultyLabel.Size = new System.Drawing.Size(54, 13);
            this.AD_difficultyLabel.TabIndex = 6;
            this.AD_difficultyLabel.Text = "Difficulty";
            // 
            // AD_enableCheckBox
            // 
            this.AD_enableCheckBox.AutoSize = true;
            this.AD_enableCheckBox.Checked = true;
            this.AD_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AD_enableCheckBox.Location = new System.Drawing.Point(6, 19);
            this.AD_enableCheckBox.Name = "AD_enableCheckBox";
            this.AD_enableCheckBox.Size = new System.Drawing.Size(111, 17);
            this.AD_enableCheckBox.TabIndex = 1;
            this.AD_enableCheckBox.Tag = "0";
            this.AD_enableCheckBox.Text = "Enable Adventure";
            this.AD_enableCheckBox.UseVisualStyleBackColor = true;
            this.AD_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // GC_enableCheckBox
            // 
            this.GC_enableCheckBox.AutoSize = true;
            this.GC_enableCheckBox.Checked = true;
            this.GC_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GC_enableCheckBox.Location = new System.Drawing.Point(6, 29);
            this.GC_enableCheckBox.Name = "GC_enableCheckBox";
            this.GC_enableCheckBox.Size = new System.Drawing.Size(164, 17);
            this.GC_enableCheckBox.TabIndex = 1;
            this.GC_enableCheckBox.Tag = "1";
            this.GC_enableCheckBox.Text = "Enable Tower and Gold Mine";
            this.GC_enableCheckBox.UseVisualStyleBackColor = true;
            this.GC_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // AR_limitLabel
            // 
            this.AR_limitLabel.AutoSize = true;
            this.AR_limitLabel.Location = new System.Drawing.Point(100, 45);
            this.AR_limitLabel.Name = "AR_limitLabel";
            this.AR_limitLabel.Size = new System.Drawing.Size(70, 13);
            this.AR_limitLabel.TabIndex = 22;
            this.AR_limitLabel.Text = "times per visit";
            // 
            // label18
            // 
            this.label18.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(170, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "pts";
            // 
            // AR_useRubyLabel
            // 
            this.AR_useRubyLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AR_useRubyLabel.AutoSize = true;
            this.AR_useRubyLabel.Location = new System.Drawing.Point(157, 22);
            this.AR_useRubyLabel.Name = "AR_useRubyLabel";
            this.AR_useRubyLabel.Size = new System.Drawing.Size(31, 13);
            this.AR_useRubyLabel.TabIndex = 12;
            this.AR_useRubyLabel.Text = "times";
            // 
            // AR_limitNumericBox
            // 
            this.AR_limitNumericBox.Location = new System.Drawing.Point(58, 42);
            this.AR_limitNumericBox.Name = "AR_limitNumericBox";
            this.AR_limitNumericBox.Size = new System.Drawing.Size(37, 20);
            this.AR_limitNumericBox.TabIndex = 21;
            this.AR_limitNumericBox.Tag = "2";
            this.AR_limitNumericBox.ValueChanged += new System.EventHandler(this.limitNumericBox_ValueChanged);
            // 
            // AR_stopArenaNumericBox
            // 
            this.AR_stopArenaNumericBox.Location = new System.Drawing.Point(116, 44);
            this.AR_stopArenaNumericBox.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.AR_stopArenaNumericBox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AR_stopArenaNumericBox.Name = "AR_stopArenaNumericBox";
            this.AR_stopArenaNumericBox.Size = new System.Drawing.Size(51, 20);
            this.AR_stopArenaNumericBox.TabIndex = 11;
            this.AR_stopArenaNumericBox.Value = new decimal(new int[] {
            4300,
            0,
            0,
            0});
            this.AR_stopArenaNumericBox.ValueChanged += new System.EventHandler(this.AR_stopArenaNumericBox_ValueChanged);
            // 
            // AR_useRubyNumericBox
            // 
            this.AR_useRubyNumericBox.Location = new System.Drawing.Point(116, 19);
            this.AR_useRubyNumericBox.Name = "AR_useRubyNumericBox";
            this.AR_useRubyNumericBox.Size = new System.Drawing.Size(37, 20);
            this.AR_useRubyNumericBox.TabIndex = 11;
            this.AR_useRubyNumericBox.ValueChanged += new System.EventHandler(this.AR_useRubyNumericBox_ValueChanged);
            // 
            // AR_limitCheckBox
            // 
            this.AR_limitCheckBox.Location = new System.Drawing.Point(8, 44);
            this.AR_limitCheckBox.Name = "AR_limitCheckBox";
            this.AR_limitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.AR_limitCheckBox.TabIndex = 20;
            this.AR_limitCheckBox.Tag = "2";
            this.AR_limitCheckBox.Text = "Limit";
            this.AR_limitCheckBox.UseVisualStyleBackColor = true;
            this.AR_limitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // AR_stopArenaCheckBox
            // 
            this.AR_stopArenaCheckBox.AutoSize = true;
            this.AR_stopArenaCheckBox.Location = new System.Drawing.Point(6, 46);
            this.AR_stopArenaCheckBox.Name = "AR_stopArenaCheckBox";
            this.AR_stopArenaCheckBox.Size = new System.Drawing.Size(111, 17);
            this.AR_stopArenaCheckBox.TabIndex = 0;
            this.AR_stopArenaCheckBox.Text = "Stop Arena When";
            this.AR_stopArenaCheckBox.UseVisualStyleBackColor = true;
            this.AR_stopArenaCheckBox.CheckedChanged += new System.EventHandler(this.AR_stopArenaCheckBox_CheckedChanged);
            // 
            // AR_useRubyCheckBox
            // 
            this.AR_useRubyCheckBox.AutoSize = true;
            this.AR_useRubyCheckBox.Location = new System.Drawing.Point(6, 21);
            this.AR_useRubyCheckBox.Name = "AR_useRubyCheckBox";
            this.AR_useRubyCheckBox.Size = new System.Drawing.Size(107, 17);
            this.AR_useRubyCheckBox.TabIndex = 0;
            this.AR_useRubyCheckBox.Text = "Enter using Ruby";
            this.AR_useRubyCheckBox.UseVisualStyleBackColor = true;
            this.AR_useRubyCheckBox.CheckedChanged += new System.EventHandler(this.AR_useRubyCheckBox_CheckedChanged);
            // 
            // AR_skillGroupBox
            // 
            this.AR_skillGroupBox.Controls.Add(this.AR_leaderComboBox);
            this.AR_skillGroupBox.Controls.Add(this.AR_masteryLabel);
            this.AR_skillGroupBox.Location = new System.Drawing.Point(6, 28);
            this.AR_skillGroupBox.Name = "AR_skillGroupBox";
            this.AR_skillGroupBox.Size = new System.Drawing.Size(254, 43);
            this.AR_skillGroupBox.TabIndex = 26;
            this.AR_skillGroupBox.TabStop = false;
            this.AR_skillGroupBox.Tag = "2";
            this.AR_skillGroupBox.Text = "Skill Management";
            this.AR_skillGroupBox.Visible = false;
            // 
            // AR_leaderComboBox
            // 
            this.AR_leaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AR_leaderComboBox.Enabled = false;
            this.AR_leaderComboBox.FormattingEnabled = true;
            this.AR_leaderComboBox.Items.AddRange(new object[] {
            "Universal",
            "Defensive",
            "Offensive",
            "Support",
            "Magic"});
            this.AR_leaderComboBox.Location = new System.Drawing.Point(197, 14);
            this.AR_leaderComboBox.Name = "AR_leaderComboBox";
            this.AR_leaderComboBox.Size = new System.Drawing.Size(46, 21);
            this.AR_leaderComboBox.TabIndex = 18;
            this.AR_leaderComboBox.Tag = "2";
            this.AR_leaderComboBox.Visible = false;
            this.AR_leaderComboBox.SelectedIndexChanged += new System.EventHandler(this.masteryComboBox_SelectedIndexChanged);
            // 
            // AR_masteryLabel
            // 
            this.AR_masteryLabel.AutoSize = true;
            this.AR_masteryLabel.Enabled = false;
            this.AR_masteryLabel.Location = new System.Drawing.Point(145, 18);
            this.AR_masteryLabel.Name = "AR_masteryLabel";
            this.AR_masteryLabel.Size = new System.Drawing.Size(40, 13);
            this.AR_masteryLabel.TabIndex = 17;
            this.AR_masteryLabel.Text = "Leader";
            this.AR_masteryLabel.Visible = false;
            // 
            // AR_enableCheckBox
            // 
            this.AR_enableCheckBox.AutoSize = true;
            this.AR_enableCheckBox.Checked = true;
            this.AR_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AR_enableCheckBox.Location = new System.Drawing.Point(9, 19);
            this.AR_enableCheckBox.Name = "AR_enableCheckBox";
            this.AR_enableCheckBox.Size = new System.Drawing.Size(90, 17);
            this.AR_enableCheckBox.TabIndex = 1;
            this.AR_enableCheckBox.Tag = "2";
            this.AR_enableCheckBox.Text = "Enable Arena";
            this.AR_enableCheckBox.UseVisualStyleBackColor = true;
            this.AR_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // RD_RoundNumericUpDown
            // 
            this.RD_RoundNumericUpDown.Location = new System.Drawing.Point(349, 18);
            this.RD_RoundNumericUpDown.Name = "RD_RoundNumericUpDown";
            this.RD_RoundNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.RD_RoundNumericUpDown.TabIndex = 36;
            this.RD_RoundNumericUpDown.Tag = "6";
            this.RD_RoundNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_RoundNumericUpDown.ValueChanged += new System.EventHandler(this.RD_RoundNumericUpDown_ValueChanged);
            // 
            // RD_DragonLimit_lbl
            // 
            this.RD_DragonLimit_lbl.AutoSize = true;
            this.RD_DragonLimit_lbl.Location = new System.Drawing.Point(395, 23);
            this.RD_DragonLimit_lbl.Name = "RD_DragonLimit_lbl";
            this.RD_DragonLimit_lbl.Size = new System.Drawing.Size(85, 13);
            this.RD_DragonLimit_lbl.TabIndex = 28;
            this.RD_DragonLimit_lbl.Text = "times per dragon";
            // 
            // RD_SummonLvl_CheckBox
            // 
            this.RD_SummonLvl_CheckBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RD_SummonLvl_CheckBox.FormattingEnabled = true;
            this.RD_SummonLvl_CheckBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.RD_SummonLvl_CheckBox.Location = new System.Drawing.Point(135, 42);
            this.RD_SummonLvl_CheckBox.Name = "RD_SummonLvl_CheckBox";
            this.RD_SummonLvl_CheckBox.Size = new System.Drawing.Size(51, 21);
            this.RD_SummonLvl_CheckBox.TabIndex = 40;
            this.RD_SummonLvl_CheckBox.SelectedIndexChanged += new System.EventHandler(this.RD_SummonLvl_CheckBox_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Dragon Summon Level : ";
            // 
            // RD_OwnerDragon
            // 
            this.RD_OwnerDragon.AutoSize = true;
            this.RD_OwnerDragon.Location = new System.Drawing.Point(6, 19);
            this.RD_OwnerDragon.Name = "RD_OwnerDragon";
            this.RD_OwnerDragon.Size = new System.Drawing.Size(105, 17);
            this.RD_OwnerDragon.TabIndex = 33;
            this.RD_OwnerDragon.Text = "Summon Dragon";
            this.RD_OwnerDragon.UseVisualStyleBackColor = true;
            this.RD_OwnerDragon.CheckedChanged += new System.EventHandler(this.RD_OwnerDragon_CheckedChanged);
            // 
            // RD_skillGroupBox
            // 
            this.RD_skillGroupBox.Controls.Add(this.RD_bothSkillRadio);
            this.RD_skillGroupBox.Controls.Add(this.RD_team2Panel);
            this.RD_skillGroupBox.Controls.Add(this.RD_manualSkillRadio);
            this.RD_skillGroupBox.Controls.Add(this.RD_autoSkillRadio);
            this.RD_skillGroupBox.Controls.Add(this.RD_team1Panel);
            this.RD_skillGroupBox.Enabled = false;
            this.RD_skillGroupBox.Location = new System.Drawing.Point(227, 60);
            this.RD_skillGroupBox.Name = "RD_skillGroupBox";
            this.RD_skillGroupBox.Size = new System.Drawing.Size(267, 248);
            this.RD_skillGroupBox.TabIndex = 25;
            this.RD_skillGroupBox.TabStop = false;
            this.RD_skillGroupBox.Tag = "2";
            this.RD_skillGroupBox.Text = "Skill Management";
            // 
            // RD_bothSkillRadio
            // 
            this.RD_bothSkillRadio.AutoSize = true;
            this.RD_bothSkillRadio.Location = new System.Drawing.Point(200, 14);
            this.RD_bothSkillRadio.Name = "RD_bothSkillRadio";
            this.RD_bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.RD_bothSkillRadio.TabIndex = 7;
            this.RD_bothSkillRadio.Tag = "2";
            this.RD_bothSkillRadio.Text = "Both";
            this.RD_bothSkillRadio.UseVisualStyleBackColor = true;
            this.RD_bothSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // RD_team2Panel
            // 
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill11Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill12Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill13Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill14Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill15Button);
            this.RD_team2Panel.Controls.Add(this.RD_team2LoopCheckBox);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill10Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill09Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill08Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill07Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill06Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill05Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill04Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill03Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill02Button);
            this.RD_team2Panel.Controls.Add(this.RD_team2Label);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill01Button);
            this.RD_team2Panel.Location = new System.Drawing.Point(6, 156);
            this.RD_team2Panel.Name = "RD_team2Panel";
            this.RD_team2Panel.Size = new System.Drawing.Size(241, 82);
            this.RD_team2Panel.TabIndex = 9;
            this.RD_team2Panel.Tag = "6";
            // 
            // RD_t2Skill11Button
            // 
            this.RD_t2Skill11Button.BackColor = System.Drawing.Color.Transparent;
            this.RD_t2Skill11Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RD_t2Skill11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill11Button.Location = new System.Drawing.Point(78, 4);
            this.RD_t2Skill11Button.Name = "RD_t2Skill11Button";
            this.RD_t2Skill11Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill11Button.TabIndex = 31;
            this.RD_t2Skill11Button.Tag = "10";
            this.RD_t2Skill11Button.UseVisualStyleBackColor = false;
            this.RD_t2Skill11Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill12Button
            // 
            this.RD_t2Skill12Button.BackColor = System.Drawing.Color.Transparent;
            this.RD_t2Skill12Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RD_t2Skill12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill12Button.Location = new System.Drawing.Point(110, 4);
            this.RD_t2Skill12Button.Name = "RD_t2Skill12Button";
            this.RD_t2Skill12Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill12Button.TabIndex = 32;
            this.RD_t2Skill12Button.Tag = "11";
            this.RD_t2Skill12Button.UseVisualStyleBackColor = false;
            this.RD_t2Skill12Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill13Button
            // 
            this.RD_t2Skill13Button.BackColor = System.Drawing.Color.Transparent;
            this.RD_t2Skill13Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RD_t2Skill13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill13Button.Location = new System.Drawing.Point(142, 4);
            this.RD_t2Skill13Button.Name = "RD_t2Skill13Button";
            this.RD_t2Skill13Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill13Button.TabIndex = 33;
            this.RD_t2Skill13Button.Tag = "12";
            this.RD_t2Skill13Button.UseVisualStyleBackColor = false;
            this.RD_t2Skill13Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill14Button
            // 
            this.RD_t2Skill14Button.BackColor = System.Drawing.Color.Transparent;
            this.RD_t2Skill14Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RD_t2Skill14Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill14Button.Location = new System.Drawing.Point(174, 4);
            this.RD_t2Skill14Button.Name = "RD_t2Skill14Button";
            this.RD_t2Skill14Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill14Button.TabIndex = 34;
            this.RD_t2Skill14Button.Tag = "13";
            this.RD_t2Skill14Button.UseVisualStyleBackColor = false;
            this.RD_t2Skill14Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill15Button
            // 
            this.RD_t2Skill15Button.BackColor = System.Drawing.Color.Transparent;
            this.RD_t2Skill15Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RD_t2Skill15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill15Button.Location = new System.Drawing.Point(206, 4);
            this.RD_t2Skill15Button.Name = "RD_t2Skill15Button";
            this.RD_t2Skill15Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill15Button.TabIndex = 35;
            this.RD_t2Skill15Button.Tag = "14";
            this.RD_t2Skill15Button.UseVisualStyleBackColor = false;
            this.RD_t2Skill15Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_team2LoopCheckBox
            // 
            this.RD_team2LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RD_team2LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_team2LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.RD_team2LoopCheckBox.Name = "RD_team2LoopCheckBox";
            this.RD_team2LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.RD_team2LoopCheckBox.TabIndex = 12;
            this.RD_team2LoopCheckBox.Text = "Loop";
            this.RD_team2LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RD_team2LoopCheckBox.UseVisualStyleBackColor = true;
            this.RD_team2LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // RD_t2Skill10Button
            // 
            this.RD_t2Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill10Button.Location = new System.Drawing.Point(206, 56);
            this.RD_t2Skill10Button.Name = "RD_t2Skill10Button";
            this.RD_t2Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill10Button.TabIndex = 10;
            this.RD_t2Skill10Button.Tag = "9";
            this.RD_t2Skill10Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill09Button
            // 
            this.RD_t2Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill09Button.Location = new System.Drawing.Point(174, 56);
            this.RD_t2Skill09Button.Name = "RD_t2Skill09Button";
            this.RD_t2Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill09Button.TabIndex = 9;
            this.RD_t2Skill09Button.Tag = "8";
            this.RD_t2Skill09Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill08Button
            // 
            this.RD_t2Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill08Button.Location = new System.Drawing.Point(142, 56);
            this.RD_t2Skill08Button.Name = "RD_t2Skill08Button";
            this.RD_t2Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill08Button.TabIndex = 8;
            this.RD_t2Skill08Button.Tag = "7";
            this.RD_t2Skill08Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill07Button
            // 
            this.RD_t2Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill07Button.Location = new System.Drawing.Point(110, 56);
            this.RD_t2Skill07Button.Name = "RD_t2Skill07Button";
            this.RD_t2Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill07Button.TabIndex = 7;
            this.RD_t2Skill07Button.Tag = "6";
            this.RD_t2Skill07Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill06Button
            // 
            this.RD_t2Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill06Button.Location = new System.Drawing.Point(78, 56);
            this.RD_t2Skill06Button.Name = "RD_t2Skill06Button";
            this.RD_t2Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill06Button.TabIndex = 6;
            this.RD_t2Skill06Button.Tag = "5";
            this.RD_t2Skill06Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill05Button
            // 
            this.RD_t2Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill05Button.Location = new System.Drawing.Point(206, 32);
            this.RD_t2Skill05Button.Name = "RD_t2Skill05Button";
            this.RD_t2Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill05Button.TabIndex = 5;
            this.RD_t2Skill05Button.Tag = "4";
            this.RD_t2Skill05Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill04Button
            // 
            this.RD_t2Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill04Button.Location = new System.Drawing.Point(174, 32);
            this.RD_t2Skill04Button.Name = "RD_t2Skill04Button";
            this.RD_t2Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill04Button.TabIndex = 4;
            this.RD_t2Skill04Button.Tag = "3";
            this.RD_t2Skill04Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill03Button
            // 
            this.RD_t2Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill03Button.Location = new System.Drawing.Point(142, 32);
            this.RD_t2Skill03Button.Name = "RD_t2Skill03Button";
            this.RD_t2Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill03Button.TabIndex = 3;
            this.RD_t2Skill03Button.Tag = "2";
            this.RD_t2Skill03Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill02Button
            // 
            this.RD_t2Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill02Button.Location = new System.Drawing.Point(110, 32);
            this.RD_t2Skill02Button.Name = "RD_t2Skill02Button";
            this.RD_t2Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill02Button.TabIndex = 2;
            this.RD_t2Skill02Button.Tag = "1";
            this.RD_t2Skill02Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_team2Label
            // 
            this.RD_team2Label.Location = new System.Drawing.Point(6, 7);
            this.RD_team2Label.Name = "RD_team2Label";
            this.RD_team2Label.Size = new System.Drawing.Size(60, 13);
            this.RD_team2Label.TabIndex = 0;
            this.RD_team2Label.Text = "Team 2";
            // 
            // RD_t2Skill01Button
            // 
            this.RD_t2Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill01Button.Location = new System.Drawing.Point(78, 32);
            this.RD_t2Skill01Button.Name = "RD_t2Skill01Button";
            this.RD_t2Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill01Button.TabIndex = 1;
            this.RD_t2Skill01Button.Tag = "0";
            this.RD_t2Skill01Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_manualSkillRadio
            // 
            this.RD_manualSkillRadio.AutoSize = true;
            this.RD_manualSkillRadio.Enabled = false;
            this.RD_manualSkillRadio.Location = new System.Drawing.Point(138, 14);
            this.RD_manualSkillRadio.Name = "RD_manualSkillRadio";
            this.RD_manualSkillRadio.Size = new System.Drawing.Size(60, 17);
            this.RD_manualSkillRadio.TabIndex = 6;
            this.RD_manualSkillRadio.Tag = "1";
            this.RD_manualSkillRadio.Text = "Manual";
            this.RD_manualSkillRadio.UseVisualStyleBackColor = true;
            this.RD_manualSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // RD_autoSkillRadio
            // 
            this.RD_autoSkillRadio.AutoSize = true;
            this.RD_autoSkillRadio.Checked = true;
            this.RD_autoSkillRadio.Location = new System.Drawing.Point(86, 14);
            this.RD_autoSkillRadio.Name = "RD_autoSkillRadio";
            this.RD_autoSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.RD_autoSkillRadio.TabIndex = 5;
            this.RD_autoSkillRadio.TabStop = true;
            this.RD_autoSkillRadio.Tag = "0";
            this.RD_autoSkillRadio.Text = "Auto";
            this.RD_autoSkillRadio.UseVisualStyleBackColor = true;
            this.RD_autoSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // RD_team1Panel
            // 
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill11Button);
            this.RD_team1Panel.Controls.Add(this.RD_team1LoopCheckBox);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill12Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill10Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill13Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill09Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill14Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill08Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill15Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill07Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill06Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill05Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill04Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill03Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill02Button);
            this.RD_team1Panel.Controls.Add(this.RD_team1Label);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill01Button);
            this.RD_team1Panel.Location = new System.Drawing.Point(6, 42);
            this.RD_team1Panel.Name = "RD_team1Panel";
            this.RD_team1Panel.Size = new System.Drawing.Size(241, 82);
            this.RD_team1Panel.TabIndex = 8;
            this.RD_team1Panel.Tag = "5";
            // 
            // RD_t1Skill11Button
            // 
            this.RD_t1Skill11Button.BackColor = System.Drawing.Color.Transparent;
            this.RD_t1Skill11Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RD_t1Skill11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill11Button.Location = new System.Drawing.Point(78, 4);
            this.RD_t1Skill11Button.Name = "RD_t1Skill11Button";
            this.RD_t1Skill11Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill11Button.TabIndex = 31;
            this.RD_t1Skill11Button.Tag = "10";
            this.RD_t1Skill11Button.UseVisualStyleBackColor = false;
            this.RD_t1Skill11Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_team1LoopCheckBox
            // 
            this.RD_team1LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RD_team1LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_team1LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.RD_team1LoopCheckBox.Name = "RD_team1LoopCheckBox";
            this.RD_team1LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.RD_team1LoopCheckBox.TabIndex = 12;
            this.RD_team1LoopCheckBox.Text = "Loop";
            this.RD_team1LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RD_team1LoopCheckBox.UseVisualStyleBackColor = true;
            this.RD_team1LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // RD_t1Skill12Button
            // 
            this.RD_t1Skill12Button.BackColor = System.Drawing.Color.Transparent;
            this.RD_t1Skill12Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RD_t1Skill12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill12Button.Location = new System.Drawing.Point(110, 4);
            this.RD_t1Skill12Button.Name = "RD_t1Skill12Button";
            this.RD_t1Skill12Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill12Button.TabIndex = 32;
            this.RD_t1Skill12Button.Tag = "11";
            this.RD_t1Skill12Button.UseVisualStyleBackColor = false;
            this.RD_t1Skill12Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill10Button
            // 
            this.RD_t1Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill10Button.Location = new System.Drawing.Point(206, 56);
            this.RD_t1Skill10Button.Name = "RD_t1Skill10Button";
            this.RD_t1Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill10Button.TabIndex = 10;
            this.RD_t1Skill10Button.Tag = "9";
            this.RD_t1Skill10Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill13Button
            // 
            this.RD_t1Skill13Button.BackColor = System.Drawing.Color.Transparent;
            this.RD_t1Skill13Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RD_t1Skill13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill13Button.Location = new System.Drawing.Point(142, 4);
            this.RD_t1Skill13Button.Name = "RD_t1Skill13Button";
            this.RD_t1Skill13Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill13Button.TabIndex = 33;
            this.RD_t1Skill13Button.Tag = "12";
            this.RD_t1Skill13Button.UseVisualStyleBackColor = false;
            this.RD_t1Skill13Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill09Button
            // 
            this.RD_t1Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill09Button.Location = new System.Drawing.Point(174, 56);
            this.RD_t1Skill09Button.Name = "RD_t1Skill09Button";
            this.RD_t1Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill09Button.TabIndex = 9;
            this.RD_t1Skill09Button.Tag = "8";
            this.RD_t1Skill09Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill14Button
            // 
            this.RD_t1Skill14Button.BackColor = System.Drawing.Color.Transparent;
            this.RD_t1Skill14Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RD_t1Skill14Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill14Button.Location = new System.Drawing.Point(174, 4);
            this.RD_t1Skill14Button.Name = "RD_t1Skill14Button";
            this.RD_t1Skill14Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill14Button.TabIndex = 34;
            this.RD_t1Skill14Button.Tag = "13";
            this.RD_t1Skill14Button.UseVisualStyleBackColor = false;
            this.RD_t1Skill14Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill08Button
            // 
            this.RD_t1Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill08Button.Location = new System.Drawing.Point(142, 56);
            this.RD_t1Skill08Button.Name = "RD_t1Skill08Button";
            this.RD_t1Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill08Button.TabIndex = 8;
            this.RD_t1Skill08Button.Tag = "7";
            this.RD_t1Skill08Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill15Button
            // 
            this.RD_t1Skill15Button.BackColor = System.Drawing.Color.Transparent;
            this.RD_t1Skill15Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RD_t1Skill15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill15Button.Location = new System.Drawing.Point(206, 4);
            this.RD_t1Skill15Button.Name = "RD_t1Skill15Button";
            this.RD_t1Skill15Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill15Button.TabIndex = 35;
            this.RD_t1Skill15Button.Tag = "14";
            this.RD_t1Skill15Button.UseVisualStyleBackColor = false;
            this.RD_t1Skill15Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill07Button
            // 
            this.RD_t1Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill07Button.Location = new System.Drawing.Point(110, 56);
            this.RD_t1Skill07Button.Name = "RD_t1Skill07Button";
            this.RD_t1Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill07Button.TabIndex = 7;
            this.RD_t1Skill07Button.Tag = "6";
            this.RD_t1Skill07Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill06Button
            // 
            this.RD_t1Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill06Button.Location = new System.Drawing.Point(78, 56);
            this.RD_t1Skill06Button.Name = "RD_t1Skill06Button";
            this.RD_t1Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill06Button.TabIndex = 6;
            this.RD_t1Skill06Button.Tag = "5";
            this.RD_t1Skill06Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill05Button
            // 
            this.RD_t1Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill05Button.Location = new System.Drawing.Point(206, 32);
            this.RD_t1Skill05Button.Name = "RD_t1Skill05Button";
            this.RD_t1Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill05Button.TabIndex = 5;
            this.RD_t1Skill05Button.Tag = "4";
            this.RD_t1Skill05Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill04Button
            // 
            this.RD_t1Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill04Button.Location = new System.Drawing.Point(174, 32);
            this.RD_t1Skill04Button.Name = "RD_t1Skill04Button";
            this.RD_t1Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill04Button.TabIndex = 4;
            this.RD_t1Skill04Button.Tag = "3";
            this.RD_t1Skill04Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill03Button
            // 
            this.RD_t1Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill03Button.Location = new System.Drawing.Point(142, 32);
            this.RD_t1Skill03Button.Name = "RD_t1Skill03Button";
            this.RD_t1Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill03Button.TabIndex = 3;
            this.RD_t1Skill03Button.Tag = "2";
            this.RD_t1Skill03Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill02Button
            // 
            this.RD_t1Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill02Button.Location = new System.Drawing.Point(110, 32);
            this.RD_t1Skill02Button.Name = "RD_t1Skill02Button";
            this.RD_t1Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill02Button.TabIndex = 2;
            this.RD_t1Skill02Button.Tag = "1";
            this.RD_t1Skill02Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_team1Label
            // 
            this.RD_team1Label.Location = new System.Drawing.Point(6, 6);
            this.RD_team1Label.Name = "RD_team1Label";
            this.RD_team1Label.Size = new System.Drawing.Size(60, 13);
            this.RD_team1Label.TabIndex = 0;
            this.RD_team1Label.Text = "Team 1";
            // 
            // RD_t1Skill01Button
            // 
            this.RD_t1Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill01Button.Location = new System.Drawing.Point(78, 32);
            this.RD_t1Skill01Button.Name = "RD_t1Skill01Button";
            this.RD_t1Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill01Button.TabIndex = 1;
            this.RD_t1Skill01Button.Tag = "0";
            this.RD_t1Skill01Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_enableCheckBox
            // 
            this.RD_enableCheckBox.AutoSize = true;
            this.RD_enableCheckBox.Checked = true;
            this.RD_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RD_enableCheckBox.Location = new System.Drawing.Point(6, 19);
            this.RD_enableCheckBox.Name = "RD_enableCheckBox";
            this.RD_enableCheckBox.Size = new System.Drawing.Size(84, 17);
            this.RD_enableCheckBox.TabIndex = 1;
            this.RD_enableCheckBox.Tag = "3";
            this.RD_enableCheckBox.Text = "Enable Raid";
            this.RD_enableCheckBox.UseVisualStyleBackColor = true;
            this.RD_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // RD_DragonLimitCheckBox
            // 
            this.RD_DragonLimitCheckBox.Location = new System.Drawing.Point(296, 19);
            this.RD_DragonLimitCheckBox.Name = "RD_DragonLimitCheckBox";
            this.RD_DragonLimitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.RD_DragonLimitCheckBox.TabIndex = 26;
            this.RD_DragonLimitCheckBox.Tag = "4";
            this.RD_DragonLimitCheckBox.Text = "Limit";
            this.RD_DragonLimitCheckBox.UseVisualStyleBackColor = true;
            this.RD_DragonLimitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // GB_WaitForKeys
            // 
            this.GB_WaitForKeys.AutoSize = true;
            this.GB_WaitForKeys.ForeColor = System.Drawing.Color.Blue;
            this.GB_WaitForKeys.Location = new System.Drawing.Point(6, 109);
            this.GB_WaitForKeys.Name = "GB_WaitForKeys";
            this.GB_WaitForKeys.Size = new System.Drawing.Size(72, 17);
            this.GB_WaitForKeys.TabIndex = 11;
            this.GB_WaitForKeys.Text = "Wait on 0";
            this.toolTip.SetToolTip(this.GB_WaitForKeys, "Wait Key");
            this.GB_WaitForKeys.UseVisualStyleBackColor = true;
            this.GB_WaitForKeys.CheckedChanged += new System.EventHandler(this.GB_WaitForKeys_CheckedChanged);
            // 
            // ST_hotTimeProfileComboBox
            // 
            this.ST_hotTimeProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ST_hotTimeProfileComboBox.FormattingEnabled = true;
            this.ST_hotTimeProfileComboBox.Location = new System.Drawing.Point(27, 42);
            this.ST_hotTimeProfileComboBox.Name = "ST_hotTimeProfileComboBox";
            this.ST_hotTimeProfileComboBox.Size = new System.Drawing.Size(112, 21);
            this.ST_hotTimeProfileComboBox.TabIndex = 4;
            this.toolTip.SetToolTip(this.ST_hotTimeProfileComboBox, "Profile to change");
            this.ST_hotTimeProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.ST_hotTimeProfileComboBox_SelectedIndexChanged);
            // 
            // ST_AutoProfileCheckBox
            // 
            this.ST_AutoProfileCheckBox.AutoSize = true;
            this.ST_AutoProfileCheckBox.Location = new System.Drawing.Point(6, 22);
            this.ST_AutoProfileCheckBox.Name = "ST_AutoProfileCheckBox";
            this.ST_AutoProfileCheckBox.Size = new System.Drawing.Size(162, 17);
            this.ST_AutoProfileCheckBox.TabIndex = 3;
            this.ST_AutoProfileCheckBox.Text = "Auto change profile 100/100";
            this.toolTip.SetToolTip(this.ST_AutoProfileCheckBox, "create new profile befor use this function.");
            this.ST_AutoProfileCheckBox.UseVisualStyleBackColor = true;
            this.ST_AutoProfileCheckBox.CheckedChanged += new System.EventHandler(this.ST_autoProfileCheckBox_CheckedChanged);
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.pictureBox1);
            this.summaryGroupBox.Controls.Add(this.pictureBox10);
            this.summaryGroupBox.Controls.Add(this.goldmineCountLabel);
            this.summaryGroupBox.Controls.Add(this.HeroCountLabel);
            this.summaryGroupBox.Controls.Add(this.raidPictureBox);
            this.summaryGroupBox.Controls.Add(this.goldChamberPictureBox);
            this.summaryGroupBox.Controls.Add(this.arenaPictureBox);
            this.summaryGroupBox.Controls.Add(this.adventurePictureBox);
            this.summaryGroupBox.Controls.Add(this.raidCountLabel);
            this.summaryGroupBox.Controls.Add(this.goldChamberCountLabel);
            this.summaryGroupBox.Controls.Add(this.arenaCountLabel);
            this.summaryGroupBox.Controls.Add(this.adventureCountLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(4, 553);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(349, 130);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Modes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SevenKnightsAI.Properties.Resources.icon_hero_356;
            this.pictureBox1.Location = new System.Drawing.Point(240, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Arena");
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SevenKnightsAI.Properties.Resources.goldmineIcon;
            this.pictureBox10.Location = new System.Drawing.Point(125, 73);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 18;
            this.pictureBox10.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox10, "Gold Chamber");
            // 
            // goldmineCountLabel
            // 
            this.goldmineCountLabel.AutoSize = true;
            this.goldmineCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldmineCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.goldmineCountLabel.Location = new System.Drawing.Point(171, 82);
            this.goldmineCountLabel.Name = "goldmineCountLabel";
            this.goldmineCountLabel.Size = new System.Drawing.Size(12, 16);
            this.goldmineCountLabel.TabIndex = 17;
            this.goldmineCountLabel.Text = "-";
            // 
            // raidPictureBox
            // 
            this.raidPictureBox.Image = global::SevenKnightsAI.Properties.Resources.raidIcon;
            this.raidPictureBox.Location = new System.Drawing.Point(6, 76);
            this.raidPictureBox.Name = "raidPictureBox";
            this.raidPictureBox.Size = new System.Drawing.Size(32, 32);
            this.raidPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.raidPictureBox.TabIndex = 11;
            this.raidPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.raidPictureBox, "Raid");
            // 
            // goldChamberPictureBox
            // 
            this.goldChamberPictureBox.Image = global::SevenKnightsAI.Properties.Resources.towerIcon;
            this.goldChamberPictureBox.Location = new System.Drawing.Point(125, 19);
            this.goldChamberPictureBox.Name = "goldChamberPictureBox";
            this.goldChamberPictureBox.Size = new System.Drawing.Size(32, 32);
            this.goldChamberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goldChamberPictureBox.TabIndex = 10;
            this.goldChamberPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.goldChamberPictureBox, "Gold Chamber");
            // 
            // arenaPictureBox
            // 
            this.arenaPictureBox.Image = global::SevenKnightsAI.Properties.Resources.arenaIcon;
            this.arenaPictureBox.Location = new System.Drawing.Point(240, 19);
            this.arenaPictureBox.Name = "arenaPictureBox";
            this.arenaPictureBox.Size = new System.Drawing.Size(32, 32);
            this.arenaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arenaPictureBox.TabIndex = 9;
            this.arenaPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.arenaPictureBox, "Arena");
            // 
            // adventurePictureBox
            // 
            this.adventurePictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_adventure;
            this.adventurePictureBox.Location = new System.Drawing.Point(6, 19);
            this.adventurePictureBox.Name = "adventurePictureBox";
            this.adventurePictureBox.Size = new System.Drawing.Size(32, 32);
            this.adventurePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adventurePictureBox.TabIndex = 8;
            this.adventurePictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.adventurePictureBox, "Adventure");
            // 
            // raidCountLabel
            // 
            this.raidCountLabel.AutoSize = true;
            this.raidCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raidCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.raidCountLabel.Location = new System.Drawing.Point(46, 82);
            this.raidCountLabel.Name = "raidCountLabel";
            this.raidCountLabel.Size = new System.Drawing.Size(12, 16);
            this.raidCountLabel.TabIndex = 4;
            this.raidCountLabel.Text = "-";
            // 
            // goldChamberCountLabel
            // 
            this.goldChamberCountLabel.AutoSize = true;
            this.goldChamberCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldChamberCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.goldChamberCountLabel.Location = new System.Drawing.Point(171, 29);
            this.goldChamberCountLabel.Name = "goldChamberCountLabel";
            this.goldChamberCountLabel.Size = new System.Drawing.Size(12, 16);
            this.goldChamberCountLabel.TabIndex = 3;
            this.goldChamberCountLabel.Text = "-";
            // 
            // arenaCountLabel
            // 
            this.arenaCountLabel.AutoSize = true;
            this.arenaCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.arenaCountLabel.Location = new System.Drawing.Point(280, 29);
            this.arenaCountLabel.Name = "arenaCountLabel";
            this.arenaCountLabel.Size = new System.Drawing.Size(12, 16);
            this.arenaCountLabel.TabIndex = 2;
            this.arenaCountLabel.Text = "-";
            // 
            // adventureCountLabel
            // 
            this.adventureCountLabel.AutoSize = true;
            this.adventureCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adventureCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.adventureCountLabel.Location = new System.Drawing.Point(46, 29);
            this.adventureCountLabel.Name = "adventureCountLabel";
            this.adventureCountLabel.Size = new System.Drawing.Size(12, 16);
            this.adventureCountLabel.TabIndex = 1;
            this.adventureCountLabel.Text = "-";
            // 
            // aiPause
            // 
            this.aiPause.Enabled = false;
            this.aiPause.Location = new System.Drawing.Point(16, 51);
            this.aiPause.Name = "aiPause";
            this.aiPause.Size = new System.Drawing.Size(102, 30);
            this.aiPause.TabIndex = 8;
            this.aiPause.Text = "&Pause";
            this.aiPause.UseVisualStyleBackColor = true;
            this.aiPause.Click += new System.EventHandler(this.aiPause_Click);
            // 
            // aiButton
            // 
            this.aiButton.Location = new System.Drawing.Point(16, 15);
            this.aiButton.Name = "aiButton";
            this.aiButton.Size = new System.Drawing.Size(102, 30);
            this.aiButton.TabIndex = 3;
            this.aiButton.Text = "Start AI";
            this.aiButton.UseVisualStyleBackColor = true;
            this.aiButton.Click += new System.EventHandler(this.aiButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Silver;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripLabel,
            this.profileToolStripLabel,
            this.statusToolStripLabel,
            this.splitterStatusLabel,
            this.tsslCursorPosition,
            this.tsPixel,
            this.tsslBuildInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 693);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(502, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // adminToolStripLabel
            // 
            this.adminToolStripLabel.Name = "adminToolStripLabel";
            this.adminToolStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // profileToolStripLabel
            // 
            this.profileToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profileToolStripLabel.Name = "profileToolStripLabel";
            this.profileToolStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusToolStripLabel
            // 
            this.statusToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusToolStripLabel.Name = "statusToolStripLabel";
            this.statusToolStripLabel.Size = new System.Drawing.Size(103, 17);
            this.statusToolStripLabel.Text = "Status: AI Stopped";
            // 
            // splitterStatusLabel
            // 
            this.splitterStatusLabel.Name = "splitterStatusLabel";
            this.splitterStatusLabel.Size = new System.Drawing.Size(292, 17);
            this.splitterStatusLabel.Spring = true;
            // 
            // tsslCursorPosition
            // 
            this.tsslCursorPosition.Name = "tsslCursorPosition";
            this.tsslCursorPosition.Size = new System.Drawing.Size(0, 17);
            // 
            // tsPixel
            // 
            this.tsPixel.Name = "tsPixel";
            this.tsPixel.Size = new System.Drawing.Size(55, 17);
            this.tsPixel.Text = "Nulled.io";
            // 
            // tsslBuildInfo
            // 
            this.tsslBuildInfo.Name = "tsslBuildInfo";
            this.tsslBuildInfo.Size = new System.Drawing.Size(37, 17);
            this.tsslBuildInfo.Text = "Build:";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(225, 46);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(80, 23);
            this.saveSettingsButton.TabIndex = 5;
            this.saveSettingsButton.Text = "Save Profile";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // Event
            // 
            this.Event.Name = "Event";
            // 
            // Time
            // 
            this.Time.Name = "Time";
            // 
            // Details
            // 
            this.Details.Name = "Details";
            // 
            // topheaderPictureBox
            // 
            this.topheaderPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topheaderPictureBox.Image = global::SevenKnightsAI.Properties.Resources.title_spike;
            this.topheaderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.topheaderPictureBox.Name = "topheaderPictureBox";
            this.topheaderPictureBox.Size = new System.Drawing.Size(510, 90);
            this.topheaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topheaderPictureBox.TabIndex = 0;
            this.topheaderPictureBox.TabStop = false;
            // 
            // LG_logTextBox
            // 
            this.LG_logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LG_logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LG_logTextBox.Location = new System.Drawing.Point(0, 0);
            this.LG_logTextBox.Name = "LG_logTextBox";
            this.LG_logTextBox.ReadOnly = true;
            this.LG_logTextBox.Size = new System.Drawing.Size(478, 333);
            this.LG_logTextBox.TabIndex = 1;
            this.LG_logTextBox.Text = "";
            this.LG_logTextBox.TextChanged += new System.EventHandler(this.LG_logTextBox_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage18);
            this.tabControl1.Controls.Add(this.tabPage22);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 456);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage4.Controls.Add(this.groupBox10);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.ImageKey = "icon-2pages.gif";
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(500, 429);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Report";
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(331, 278);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(163, 145);
            this.groupBox10.TabIndex = 26;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "...";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.logsBox);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Location = new System.Drawing.Point(6, 202);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 221);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Log";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.timer);
            this.groupBox1.Controls.Add(this.botstatusLabel);
            this.groupBox1.Location = new System.Drawing.Point(184, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 70);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Time :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabControl2);
            this.tabPage5.ImageKey = "offer_inter.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(500, 429);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Mode";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage23);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage17);
            this.tabControl2.Location = new System.Drawing.Point(-4, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(508, 429);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tabControl5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(500, 403);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Adventure";
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage1);
            this.tabControl5.Controls.Add(this.tabPage15);
            this.tabControl5.Controls.Add(this.tabPage16);
            this.tabControl5.Location = new System.Drawing.Point(-4, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(508, 404);
            this.tabControl5.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox23);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(500, 378);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Control";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.GB_WaitForKeys);
            this.groupBox23.Controls.Add(this.AD_EnHottime_Checkbox);
            this.groupBox23.Controls.Add(this.checkBox5);
            this.groupBox23.Controls.Add(this.AD_NoHeroUp_Checkbox);
            this.groupBox23.Controls.Add(this.AD_Pause100);
            this.groupBox23.Controls.Add(this.AD_limitLabel);
            this.groupBox23.Controls.Add(this.ST_AutoShutdownCheckBox);
            this.groupBox23.Controls.Add(this.AD_limitNumericBox);
            this.groupBox23.Controls.Add(this.AD_limitCheckBox);
            this.groupBox23.Controls.Add(this.AD_enableCheckBox);
            this.groupBox23.Controls.Add(this.AD_StopOnFullItems_Checkbox);
            this.groupBox23.Controls.Add(this.AD_StopOnFullHeroes_Checkbox);
            this.groupBox23.Location = new System.Drawing.Point(8, 13);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(486, 134);
            this.groupBox23.TabIndex = 0;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Adventure";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(6, 40);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(156, 17);
            this.checkBox5.TabIndex = 32;
            this.checkBox5.Text = "Buy Key when out of stock.";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.groupBox26);
            this.tabPage15.Controls.Add(this.groupBox27);
            this.tabPage15.Controls.Add(this.AD_skillGroupBox);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(500, 378);
            this.tabPage15.TabIndex = 0;
            this.tabPage15.Text = "Map Option";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.AD_RubyBooster_Checkbox);
            this.groupBox26.Controls.Add(this.AD_bootmodeCheckBox);
            this.groupBox26.Controls.Add(this.AD_UseFriendCheckBox);
            this.groupBox26.Location = new System.Drawing.Point(6, 186);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(213, 90);
            this.groupBox26.TabIndex = 1;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Other Option";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.AD_difficultyComboBox2nd);
            this.groupBox27.Controls.Add(this.AD_difficultyLabel);
            this.groupBox27.Controls.Add(this.label1);
            this.groupBox27.Controls.Add(this.AD_difficultyComboBox);
            this.groupBox27.Controls.Add(this.AD_worldLabel);
            this.groupBox27.Controls.Add(this.AD_stageLabel);
            this.groupBox27.Controls.Add(this.AD_worldComboBox);
            this.groupBox27.Controls.Add(this.AD_stageComboBox);
            this.groupBox27.Controls.Add(this.AD_sequenceButton);
            this.groupBox27.Controls.Add(this.AD_continuousCheckBox);
            this.groupBox27.Location = new System.Drawing.Point(6, 6);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(211, 177);
            this.groupBox27.TabIndex = 0;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Map Setting";
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.groupBox28);
            this.tabPage16.Controls.Add(this.ADCH_ChangeHeroGroupBox);
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(500, 378);
            this.tabPage16.TabIndex = 1;
            this.tabPage16.Text = "Change Hero Option";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.AD_CheckingHeroes_Checkbox);
            this.groupBox28.Controls.Add(this.AD_elementHeroesCheckBox);
            this.groupBox28.Controls.Add(this.AD_StopOnLV30_Checkbox);
            this.groupBox28.Location = new System.Drawing.Point(5, 6);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(200, 175);
            this.groupBox28.TabIndex = 19;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Option";
            // 
            // ADCH_ChangeHeroGroupBox
            // 
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_masteryLabel);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_leaderComboBox);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_formationComboBox);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_teamLabel);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_formationLabel);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_teamComboBox2);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_formationPanel);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_teamComboBox);
            this.ADCH_ChangeHeroGroupBox.Location = new System.Drawing.Point(211, 6);
            this.ADCH_ChangeHeroGroupBox.Name = "ADCH_ChangeHeroGroupBox";
            this.ADCH_ChangeHeroGroupBox.Size = new System.Drawing.Size(259, 175);
            this.ADCH_ChangeHeroGroupBox.TabIndex = 18;
            this.ADCH_ChangeHeroGroupBox.TabStop = false;
            this.ADCH_ChangeHeroGroupBox.Text = "Change Hero Option";
            // 
            // tabPage23
            // 
            this.tabPage23.Controls.Add(this.groupBox21);
            this.tabPage23.Location = new System.Drawing.Point(4, 22);
            this.tabPage23.Name = "tabPage23";
            this.tabPage23.Size = new System.Drawing.Size(500, 403);
            this.tabPage23.TabIndex = 6;
            this.tabPage23.Text = "Tower & Gold Mine";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.GC_enableCheckBox);
            this.groupBox21.Location = new System.Drawing.Point(6, 3);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(488, 59);
            this.groupBox21.TabIndex = 1;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Tower && Gold Mine Control";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox20);
            this.tabPage7.Controls.Add(this.groupBox29);
            this.tabPage7.Controls.Add(this.groupBox11);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(500, 403);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Arena";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.AR_limitLabel);
            this.groupBox20.Controls.Add(this.AR_enableCheckBox);
            this.groupBox20.Controls.Add(this.AR_limitNumericBox);
            this.groupBox20.Controls.Add(this.AR_limitCheckBox);
            this.groupBox20.Location = new System.Drawing.Point(6, 4);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(488, 74);
            this.groupBox20.TabIndex = 2;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Arena Control";
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.GC_masteryComboBox);
            this.groupBox29.Controls.Add(this.AR_stopArenaCheckBox);
            this.groupBox29.Controls.Add(this.label18);
            this.groupBox29.Controls.Add(this.GC_teamLabel);
            this.groupBox29.Controls.Add(this.AR_useRubyCheckBox);
            this.groupBox29.Controls.Add(this.GC_masteryLabel);
            this.groupBox29.Controls.Add(this.AR_useRubyLabel);
            this.groupBox29.Controls.Add(this.GC_formationLabel);
            this.groupBox29.Controls.Add(this.AR_useRubyNumericBox);
            this.groupBox29.Controls.Add(this.GC_formationComboBox);
            this.groupBox29.Controls.Add(this.AR_stopArenaNumericBox);
            this.groupBox29.Controls.Add(this.GC_formationPanel);
            this.groupBox29.Controls.Add(this.GC_teamComboBox);
            this.groupBox29.Location = new System.Drawing.Point(6, 84);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(488, 79);
            this.groupBox29.TabIndex = 0;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Arena Option";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.GC_limitLabel);
            this.groupBox11.Controls.Add(this.GC_limitNumericBox);
            this.groupBox11.Controls.Add(this.GC_UseFriendCheckBox);
            this.groupBox11.Controls.Add(this.GC_limitCheckBox);
            this.groupBox11.Controls.Add(this.AR_skillGroupBox);
            this.groupBox11.Location = new System.Drawing.Point(6, 239);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(458, 89);
            this.groupBox11.TabIndex = 27;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Useless - Need to be deleted";
            this.groupBox11.Visible = false;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.AD_StopOnDragon_Checkbox);
            this.tabPage8.Controls.Add(this.RD_skillGroupBox);
            this.tabPage8.Controls.Add(this.groupBox32);
            this.tabPage8.Controls.Add(this.groupBox31);
            this.tabPage8.Controls.Add(this.groupBox19);
            this.tabPage8.Controls.Add(this.RD_leaderComboBox);
            this.tabPage8.Controls.Add(this.label2);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(500, 403);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Raid";
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.RD_ReadNick);
            this.groupBox32.Controls.Add(this.RD_DragonHP);
            this.groupBox32.Controls.Add(this.label6);
            this.groupBox32.Controls.Add(this.RD_DragonLV);
            this.groupBox32.Controls.Add(this.label5);
            this.groupBox32.Controls.Add(this.label4);
            this.groupBox32.Controls.Add(this.RD_DragonLVLimit);
            this.groupBox32.Controls.Add(this.RD_LevelCheckBox);
            this.groupBox32.Controls.Add(this.RD_DragonHPLimit);
            this.groupBox32.Location = new System.Drawing.Point(8, 58);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(213, 121);
            this.groupBox32.TabIndex = 39;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Dragon Option";
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.AD_SummonAuto);
            this.groupBox31.Controls.Add(this.RD_SummonLvl_CheckBox);
            this.groupBox31.Controls.Add(this.RD_OwnerDragon);
            this.groupBox31.Controls.Add(this.label21);
            this.groupBox31.Location = new System.Drawing.Point(8, 185);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(213, 179);
            this.groupBox31.TabIndex = 44;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Summon Dragon";
            // 
            // AD_SummonAuto
            // 
            this.AD_SummonAuto.AutoSize = true;
            this.AD_SummonAuto.Location = new System.Drawing.Point(6, 80);
            this.AD_SummonAuto.Name = "AD_SummonAuto";
            this.AD_SummonAuto.Size = new System.Drawing.Size(135, 30);
            this.AD_SummonAuto.TabIndex = 41;
            this.AD_SummonAuto.Text = "Auto summon dragon\r\nwhen point reach 1000";
            this.AD_SummonAuto.UseVisualStyleBackColor = true;
            this.AD_SummonAuto.CheckedChanged += new System.EventHandler(this.AD_SummonAuto_CheckedChanged);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.RD_RoundNumericUpDown);
            this.groupBox19.Controls.Add(this.RD_enableCheckBox);
            this.groupBox19.Controls.Add(this.RD_DragonLimit_lbl);
            this.groupBox19.Controls.Add(this.RD_DragonLimitCheckBox);
            this.groupBox19.Location = new System.Drawing.Point(8, 5);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(486, 47);
            this.groupBox19.TabIndex = 3;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Raid";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.SP_skillGroupBox);
            this.tabPage9.Controls.Add(this.evanGroupBox);
            this.tabPage9.Controls.Add(this.checkBox3);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(500, 403);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Dungeon";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(500, 403);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "Other";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(498, 404);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(490, 378);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Exploration";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.EX_SendAgainCheckBox);
            this.groupBox12.Controls.Add(this.EX_EnableCheckBox);
            this.groupBox12.Location = new System.Drawing.Point(6, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(478, 108);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Exploration Control";
            // 
            // EX_SendAgainCheckBox
            // 
            this.EX_SendAgainCheckBox.AutoSize = true;
            this.EX_SendAgainCheckBox.Location = new System.Drawing.Point(6, 61);
            this.EX_SendAgainCheckBox.Name = "EX_SendAgainCheckBox";
            this.EX_SendAgainCheckBox.Size = new System.Drawing.Size(81, 17);
            this.EX_SendAgainCheckBox.TabIndex = 1;
            this.EX_SendAgainCheckBox.Text = "Send Again";
            this.EX_SendAgainCheckBox.UseVisualStyleBackColor = true;
            this.EX_SendAgainCheckBox.CheckedChanged += new System.EventHandler(this.EX_SendAgainCheckBox_CheckedChanged);
            // 
            // EX_EnableCheckBox
            // 
            this.EX_EnableCheckBox.AutoSize = true;
            this.EX_EnableCheckBox.Location = new System.Drawing.Point(6, 28);
            this.EX_EnableCheckBox.Name = "EX_EnableCheckBox";
            this.EX_EnableCheckBox.Size = new System.Drawing.Size(113, 17);
            this.EX_EnableCheckBox.TabIndex = 0;
            this.EX_EnableCheckBox.Text = "Collect Exploration";
            this.EX_EnableCheckBox.UseVisualStyleBackColor = true;
            this.EX_EnableCheckBox.CheckedChanged += new System.EventHandler(this.EX_EnableCheckBox_CheckedChanged);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.groupBox13);
            this.tabPage10.Controls.Add(this.groupBox14);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(490, 378);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Unknown Area";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.radioButton1);
            this.groupBox13.Controls.Add(this.radioButton2);
            this.groupBox13.Controls.Add(this.radioButton3);
            this.groupBox13.Controls.Add(this.panel2);
            this.groupBox13.Enabled = false;
            this.groupBox13.Location = new System.Drawing.Point(220, 59);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(267, 137);
            this.groupBox13.TabIndex = 27;
            this.groupBox13.TabStop = false;
            this.groupBox13.Tag = "2";
            this.groupBox13.Text = "Skill Management";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(200, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Tag = "2";
            this.radioButton1.Text = "Both";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(138, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "Manual";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(86, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "0";
            this.radioButton3.Text = "Auto";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.checkBox7);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.button24);
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button26);
            this.panel2.Controls.Add(this.button27);
            this.panel2.Controls.Add(this.button28);
            this.panel2.Controls.Add(this.button29);
            this.panel2.Controls.Add(this.button30);
            this.panel2.Controls.Add(this.button31);
            this.panel2.Controls.Add(this.button32);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button33);
            this.panel2.Location = new System.Drawing.Point(6, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 82);
            this.panel2.TabIndex = 8;
            this.panel2.Tag = "5";
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button19.Location = new System.Drawing.Point(78, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(23, 23);
            this.button19.TabIndex = 31;
            this.button19.Tag = "10";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox7.Location = new System.Drawing.Point(8, 23);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(40, 20);
            this.checkBox7.TabIndex = 12;
            this.checkBox7.Text = "Loop";
            this.checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button20.Location = new System.Drawing.Point(110, 4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(23, 23);
            this.button20.TabIndex = 32;
            this.button20.Tag = "11";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button21.Location = new System.Drawing.Point(206, 56);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(23, 23);
            this.button21.TabIndex = 10;
            this.button21.Tag = "9";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button22.Location = new System.Drawing.Point(142, 4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(23, 23);
            this.button22.TabIndex = 33;
            this.button22.Tag = "12";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button23.Location = new System.Drawing.Point(174, 56);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(23, 23);
            this.button23.TabIndex = 9;
            this.button23.Tag = "8";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button24.Location = new System.Drawing.Point(174, 4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(23, 23);
            this.button24.TabIndex = 34;
            this.button24.Tag = "13";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button25.Location = new System.Drawing.Point(142, 56);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(23, 23);
            this.button25.TabIndex = 8;
            this.button25.Tag = "7";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Transparent;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button26.Location = new System.Drawing.Point(206, 4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(23, 23);
            this.button26.TabIndex = 35;
            this.button26.Tag = "14";
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button27.Location = new System.Drawing.Point(110, 56);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(23, 23);
            this.button27.TabIndex = 7;
            this.button27.Tag = "6";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button28.Location = new System.Drawing.Point(78, 56);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(23, 23);
            this.button28.TabIndex = 6;
            this.button28.Tag = "5";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button29.Location = new System.Drawing.Point(206, 32);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(23, 23);
            this.button29.TabIndex = 5;
            this.button29.Tag = "4";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button30.Location = new System.Drawing.Point(174, 32);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(23, 23);
            this.button30.TabIndex = 4;
            this.button30.Tag = "3";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button31.Location = new System.Drawing.Point(142, 32);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(23, 23);
            this.button31.TabIndex = 3;
            this.button31.Tag = "2";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button32.Location = new System.Drawing.Point(110, 32);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(23, 23);
            this.button32.TabIndex = 2;
            this.button32.Tag = "1";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Team 1";
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button33.Location = new System.Drawing.Point(78, 32);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(23, 23);
            this.button33.TabIndex = 1;
            this.button33.Tag = "0";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.checkBox8);
            this.groupBox14.Enabled = false;
            this.groupBox14.Location = new System.Drawing.Point(6, 6);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(481, 47);
            this.groupBox14.TabIndex = 26;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Unknown Area";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(6, 19);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(133, 17);
            this.checkBox8.TabIndex = 1;
            this.checkBox8.Tag = "3";
            this.checkBox8.Text = "Enable Unknown Area";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.RS_buyKeysGroupBox);
            this.tabPage17.Controls.Add(this.RS_sendHonorsGroupBox);
            this.tabPage17.Controls.Add(this.RS_collectQuestsGroupBox);
            this.tabPage17.Controls.Add(this.RS_sellingGroupBox);
            this.tabPage17.Controls.Add(this.RS_inboxGroupBox);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(500, 403);
            this.tabPage17.TabIndex = 5;
            this.tabPage17.Text = "Resources";
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.tabControl6);
            this.tabPage18.ImageKey = "favicon.ico";
            this.tabPage18.Location = new System.Drawing.Point(4, 23);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Size = new System.Drawing.Size(500, 429);
            this.tabPage18.TabIndex = 2;
            this.tabPage18.Text = "Setting";
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage19);
            this.tabControl6.Controls.Add(this.tabPage20);
            this.tabControl6.Controls.Add(this.tabPage21);
            this.tabControl6.Location = new System.Drawing.Point(-4, 0);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(508, 433);
            this.tabControl6.TabIndex = 0;
            // 
            // tabPage19
            // 
            this.tabPage19.Controls.Add(this.ST_blueStacksGroupBox);
            this.tabPage19.Controls.Add(this.groupBox38);
            this.tabPage19.Location = new System.Drawing.Point(4, 22);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage19.Size = new System.Drawing.Size(500, 407);
            this.tabPage19.TabIndex = 0;
            this.tabPage19.Text = "Option";
            // 
            // ST_blueStacksGroupBox
            // 
            this.ST_blueStacksGroupBox.Controls.Add(this.ST_forceActiveCheckBox);
            this.ST_blueStacksGroupBox.Controls.Add(this.ST_toggleBlueStacksButton);
            this.ST_blueStacksGroupBox.Controls.Add(this.ST_foregroundMode);
            this.ST_blueStacksGroupBox.Location = new System.Drawing.Point(37, 141);
            this.ST_blueStacksGroupBox.Name = "ST_blueStacksGroupBox";
            this.ST_blueStacksGroupBox.Size = new System.Drawing.Size(190, 105);
            this.ST_blueStacksGroupBox.TabIndex = 7;
            this.ST_blueStacksGroupBox.TabStop = false;
            this.ST_blueStacksGroupBox.Text = "BlueStacks";
            // 
            // ST_forceActiveCheckBox
            // 
            this.ST_forceActiveCheckBox.AutoSize = true;
            this.ST_forceActiveCheckBox.Location = new System.Drawing.Point(53, 16);
            this.ST_forceActiveCheckBox.Name = "ST_forceActiveCheckBox";
            this.ST_forceActiveCheckBox.Size = new System.Drawing.Size(92, 17);
            this.ST_forceActiveCheckBox.TabIndex = 1;
            this.ST_forceActiveCheckBox.Text = "Always on top";
            this.ST_forceActiveCheckBox.UseVisualStyleBackColor = true;
            this.ST_forceActiveCheckBox.CheckedChanged += new System.EventHandler(this.ST_forceActiveCheckBox_CheckedChanged);
            // 
            // ST_toggleBlueStacksButton
            // 
            this.ST_toggleBlueStacksButton.Enabled = false;
            this.ST_toggleBlueStacksButton.Location = new System.Drawing.Point(6, 37);
            this.ST_toggleBlueStacksButton.Name = "ST_toggleBlueStacksButton";
            this.ST_toggleBlueStacksButton.Size = new System.Drawing.Size(174, 39);
            this.ST_toggleBlueStacksButton.TabIndex = 0;
            this.ST_toggleBlueStacksButton.Text = "Hide BlueStacks";
            this.ST_toggleBlueStacksButton.UseVisualStyleBackColor = true;
            this.ST_toggleBlueStacksButton.Click += new System.EventHandler(this.ST_toggleBlueStacksButton_Click);
            // 
            // ST_foregroundMode
            // 
            this.ST_foregroundMode.AutoSize = true;
            this.ST_foregroundMode.Location = new System.Drawing.Point(45, 82);
            this.ST_foregroundMode.Name = "ST_foregroundMode";
            this.ST_foregroundMode.Size = new System.Drawing.Size(110, 17);
            this.ST_foregroundMode.TabIndex = 9;
            this.ST_foregroundMode.Text = "Foreground Mode";
            this.ST_foregroundMode.UseVisualStyleBackColor = true;
            this.ST_foregroundMode.CheckedChanged += new System.EventHandler(this.ST_foregroundMode_CheckedChanged);
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.label79);
            this.groupBox38.Controls.Add(this.ST_delayLabel);
            this.groupBox38.Controls.Add(this.ST_opacityLabel);
            this.groupBox38.Controls.Add(this.ST_opacityTrackBar);
            this.groupBox38.Controls.Add(this.ST_delayTrackBar);
            this.groupBox38.Controls.Add(this.ST_delayValueLabel);
            this.groupBox38.Controls.Add(this.ST_reconnectInterruptCheckBox);
            this.groupBox38.Controls.Add(this.ST_reconnectNumericUpDown);
            this.groupBox38.Location = new System.Drawing.Point(8, 6);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(486, 119);
            this.groupBox38.TabIndex = 0;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "Delay Setting";
            // 
            // label79
            // 
            this.label79.Location = new System.Drawing.Point(-136, 13);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(49, 13);
            this.label79.TabIndex = 13;
            this.label79.Text = "Delay";
            // 
            // tabPage20
            // 
            this.tabPage20.Controls.Add(this.groupBox24);
            this.tabPage20.Controls.Add(this.groupBox39);
            this.tabPage20.Location = new System.Drawing.Point(4, 22);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Size = new System.Drawing.Size(500, 407);
            this.tabPage20.TabIndex = 2;
            this.tabPage20.Text = "Profile";
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.ST_NoMoreProfileComboBox);
            this.groupBox24.Controls.Add(this.ST_hotTimeProfileComboBox);
            this.groupBox24.Controls.Add(this.ST_AutoProfileCheckBox);
            this.groupBox24.Controls.Add(this.checkBox22);
            this.groupBox24.Location = new System.Drawing.Point(8, 84);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(481, 136);
            this.groupBox24.TabIndex = 0;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Change Profile When";
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(6, 78);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(128, 17);
            this.checkBox22.TabIndex = 1;
            this.checkBox22.Text = "No more hero to lv up";
            this.checkBox22.UseVisualStyleBackColor = true;
            this.checkBox22.Visible = false;
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.ST_hotTimeProfileCheckBox);
            this.groupBox39.Controls.Add(this.saveSettingsButton);
            this.groupBox39.Controls.Add(this.ST_manageProfileButton);
            this.groupBox39.Controls.Add(this.ST_currentProfileComboBox);
            this.groupBox39.Controls.Add(this.ST_currentProfileLabel);
            this.groupBox39.Location = new System.Drawing.Point(8, 3);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Size = new System.Drawing.Size(481, 75);
            this.groupBox39.TabIndex = 7;
            this.groupBox39.TabStop = false;
            this.groupBox39.Text = "Profile";
            // 
            // tabPage21
            // 
            this.tabPage21.Controls.Add(this.groupBox3);
            this.tabPage21.Location = new System.Drawing.Point(4, 22);
            this.tabPage21.Name = "tabPage21";
            this.tabPage21.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage21.Size = new System.Drawing.Size(500, 407);
            this.tabPage21.TabIndex = 1;
            this.tabPage21.Text = "Remote Bot";
            // 
            // tabPage22
            // 
            this.tabPage22.Controls.Add(this.label84);
            this.tabPage22.Controls.Add(this.linkLabel9);
            this.tabPage22.Controls.Add(this.linkLabel10);
            this.tabPage22.Controls.Add(this.linkLabel11);
            this.tabPage22.Controls.Add(this.linkLabel12);
            this.tabPage22.Controls.Add(this.linkLabel13);
            this.tabPage22.Controls.Add(this.linkLabel14);
            this.tabPage22.ImageKey = "award_star_gold_3.png";
            this.tabPage22.Location = new System.Drawing.Point(4, 23);
            this.tabPage22.Name = "tabPage22";
            this.tabPage22.Size = new System.Drawing.Size(500, 429);
            this.tabPage22.TabIndex = 3;
            this.tabPage22.Text = "About";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label84.ForeColor = System.Drawing.Color.Red;
            this.label84.Location = new System.Drawing.Point(8, 12);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(86, 17);
            this.label84.TabIndex = 20;
            this.label84.Text = "Thanks you.";
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(32, 109);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(110, 13);
            this.linkLabel9.TabIndex = 17;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "https://www.nulled.to";
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(32, 172);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(170, 13);
            this.linkLabel10.TabIndex = 18;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "https://www.nulled.to/user/4-lostit";
            // 
            // linkLabel11
            // 
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Location = new System.Drawing.Point(32, 139);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(210, 13);
            this.linkLabel11.TabIndex = 19;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "https://www.nulled.to/user/513548-daelus";
            // 
            // linkLabel12
            // 
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.Location = new System.Drawing.Point(32, 45);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(230, 13);
            this.linkLabel12.TabIndex = 15;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "https://github.com/dreammed/SevenKnightsAI";
            // 
            // linkLabel13
            // 
            this.linkLabel13.AutoSize = true;
            this.linkLabel13.Location = new System.Drawing.Point(32, 199);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(204, 13);
            this.linkLabel13.TabIndex = 16;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "https://www.nulled.to/user/600594-xhum";
            // 
            // linkLabel14
            // 
            this.linkLabel14.AutoSize = true;
            this.linkLabel14.Location = new System.Drawing.Point(32, 81);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(247, 13);
            this.linkLabel14.TabIndex = 14;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "https://github.com/Nulled-Daelus/SevenKnightsAI";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mode.ico");
            this.imageList1.Images.SetKeyName(1, "mode22.ico");
            this.imageList1.Images.SetKeyName(2, "favicon2.ico");
            this.imageList1.Images.SetKeyName(3, "favicon.ico");
            this.imageList1.Images.SetKeyName(4, "offer_inter.png");
            this.imageList1.Images.SetKeyName(5, "award_star_gold_3.png");
            this.imageList1.Images.SetKeyName(6, "icon-2pages.gif");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.screenshotButton);
            this.groupBox2.Controls.Add(this.aiButton);
            this.groupBox2.Controls.Add(this.aiPause);
            this.groupBox2.Location = new System.Drawing.Point(359, 553);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 130);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // screenshotButton
            // 
            this.screenshotButton.Location = new System.Drawing.Point(16, 87);
            this.screenshotButton.Name = "screenshotButton";
            this.screenshotButton.Size = new System.Drawing.Size(102, 27);
            this.screenshotButton.TabIndex = 17;
            this.screenshotButton.Text = "&Save Profile";
            this.screenshotButton.UseVisualStyleBackColor = true;
            this.screenshotButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ST_NoMoreProfileComboBox
            // 
            this.ST_NoMoreProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ST_NoMoreProfileComboBox.FormattingEnabled = true;
            this.ST_NoMoreProfileComboBox.Location = new System.Drawing.Point(27, 101);
            this.ST_NoMoreProfileComboBox.Name = "ST_NoMoreProfileComboBox";
            this.ST_NoMoreProfileComboBox.Size = new System.Drawing.Size(112, 21);
            this.ST_NoMoreProfileComboBox.TabIndex = 5;
            this.toolTip.SetToolTip(this.ST_NoMoreProfileComboBox, "Profile to change");
            // 
            // MainForm
            // 
            this.AcceptButton = this.aiButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(502, 715);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.topheaderPictureBox);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seven Knights AI Black";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GC_limitNumericBox)).EndInit();
            this.GC_formationPanel.ResumeLayout(false);
            this.GC_formationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonLVLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonHPLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonHP)).EndInit();
            this.SP_skillGroupBox.ResumeLayout(false);
            this.SP_skillGroupBox.PerformLayout();
            this.SP_wave3Panel.ResumeLayout(false);
            this.SP_wave3Panel.PerformLayout();
            this.SP_wave2Panel.ResumeLayout(false);
            this.SP_wave2Panel.PerformLayout();
            this.SP_wave1Panel.ResumeLayout(false);
            this.evanGroupBox.ResumeLayout(false);
            this.evanGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_evanLimitNumericBox)).EndInit();
            this.RS_collectQuestsGroupBox.ResumeLayout(false);
            this.RS_collectQuestsGroupBox.PerformLayout();
            this.RS_sendHonorsGroupBox.ResumeLayout(false);
            this.RS_sendHonorsGroupBox.PerformLayout();
            this.RS_giftsGroupBox.ResumeLayout(false);
            this.RS_giftsGroupBox.PerformLayout();
            this.RS_buyKeysGroupBox.ResumeLayout(false);
            this.RS_buyKeysGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyRubiesNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyHonorsNumericBox)).EndInit();
            this.RS_inboxGroupBox.ResumeLayout(false);
            this.RS_inboxGroupBox.PerformLayout();
            this.RS_sellingGroupBox.ResumeLayout(false);
            this.RS_sellingGroupBox.PerformLayout();
            this.RS_itemRadioPanel.ResumeLayout(false);
            this.RS_itemRadioPanel.PerformLayout();
            this.RS_heroRadioPanel.ResumeLayout(false);
            this.RS_heroRadioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_itemAmountNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_heroAmountNumericBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_opacityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_reconnectNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_delayTrackBar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AD_limitNumericBox)).EndInit();
            this.AD_formationPanel.ResumeLayout(false);
            this.AD_formationPanel.PerformLayout();
            this.AD_skillGroupBox.ResumeLayout(false);
            this.AD_skillGroupBox.PerformLayout();
            this.AD_wave3Panel.ResumeLayout(false);
            this.AD_wave3Panel.PerformLayout();
            this.AD_wave2Panel.ResumeLayout(false);
            this.AD_wave2Panel.PerformLayout();
            this.AD_wave1Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AR_limitNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AR_stopArenaNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AR_useRubyNumericBox)).EndInit();
            this.AR_skillGroupBox.ResumeLayout(false);
            this.AR_skillGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RD_RoundNumericUpDown)).EndInit();
            this.RD_skillGroupBox.ResumeLayout(false);
            this.RD_skillGroupBox.PerformLayout();
            this.RD_team2Panel.ResumeLayout(false);
            this.RD_team1Panel.ResumeLayout(false);
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raidPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldChamberPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventurePictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topheaderPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.tabPage16.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.ADCH_ChangeHeroGroupBox.ResumeLayout(false);
            this.ADCH_ChangeHeroGroupBox.PerformLayout();
            this.tabPage23.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabPage18.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.tabPage19.ResumeLayout(false);
            this.ST_blueStacksGroupBox.ResumeLayout(false);
            this.ST_blueStacksGroupBox.PerformLayout();
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.tabPage20.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.tabPage21.ResumeLayout(false);
            this.tabPage22.ResumeLayout(false);
            this.tabPage22.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		
		private global::System.Windows.Forms.ToolStripStatusLabel adminToolStripLabel;

		
		private global::System.Windows.Forms.Label adventureCountLabel;



		
		private global::System.Windows.Forms.PictureBox adventurePictureBox;


		
		private global::System.Windows.Forms.RadioButton AD_autoSkillRadio;

		
		private global::System.Windows.Forms.RadioButton AD_bothSkillRadio;

		
		private global::System.Windows.Forms.CheckBox AD_continuousCheckBox;

		
		private global::System.Windows.Forms.ComboBox AD_difficultyComboBox;

		
		private global::System.Windows.Forms.Label AD_difficultyLabel;

		
		private global::System.Windows.Forms.CheckBox AD_elementHeroesCheckBox;

		
		private global::System.Windows.Forms.CheckBox AD_enableCheckBox;

		
		private global::System.Windows.Forms.ComboBox AD_formationComboBox;

		
		private global::System.Windows.Forms.Label AD_formationLabel;

		
		private global::System.Windows.Forms.Panel AD_formationPanel;

		
		private global::System.Windows.Forms.CheckBox AD_limitCheckBox;

		
		private global::System.Windows.Forms.Label AD_limitLabel;

		
		private global::System.Windows.Forms.NumericUpDown AD_limitNumericBox;



		
		private global::System.Windows.Forms.RadioButton AD_manualSkillRadio;

		
		private global::System.Windows.Forms.ComboBox AD_leaderComboBox;

		
		private global::System.Windows.Forms.Label AD_masteryLabel;

		
		private global::System.Windows.Forms.CheckBox AD_pos1CheckBox;

		
		private global::System.Windows.Forms.CheckBox AD_pos2CheckBox;

		
		private global::System.Windows.Forms.CheckBox AD_pos3CheckBox;

		
		private global::System.Windows.Forms.CheckBox AD_pos4CheckBox;

		
		private global::System.Windows.Forms.CheckBox AD_pos5CheckBox;

		
		private global::System.Windows.Forms.Button AD_sequenceButton;

		
		private global::System.Windows.Forms.GroupBox AD_skillGroupBox;

		
		private global::System.Windows.Forms.ComboBox AD_stageComboBox;

		
		private global::System.Windows.Forms.Label AD_stageLabel;

		
		private global::System.Windows.Forms.ComboBox AD_teamComboBox;

		
		private global::System.Windows.Forms.Label AD_teamLabel;

		
		private global::System.Windows.Forms.Button AD_w1Skill01Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill02Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill03Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill04Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill05Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill06Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill07Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill08Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill09Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill10Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill01Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill02Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill03Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill04Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill05Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill06Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill07Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill08Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill09Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill10Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill01Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill02Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill03Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill04Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill05Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill06Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill07Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill08Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill09Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill10Button;

		
		private global::System.Windows.Forms.Label AD_wave1Label;

		
		private global::System.Windows.Forms.CheckBox AD_wave1LoopCheckBox;

		
		private global::System.Windows.Forms.Panel AD_wave1Panel;

		
		private global::System.Windows.Forms.Label AD_wave2Label;

		
		private global::System.Windows.Forms.CheckBox AD_wave2LoopCheckBox;

		
		private global::System.Windows.Forms.Panel AD_wave2Panel;

		
		private global::System.Windows.Forms.Label AD_wave3Label;

		
		private global::System.Windows.Forms.CheckBox AD_wave3LoopCheckBox;

		
		private global::System.Windows.Forms.Panel AD_wave3Panel;

		
		private global::System.Windows.Forms.ComboBox AD_worldComboBox;

		
		private global::System.Windows.Forms.Label AD_worldLabel;

		
		private global::System.Windows.Forms.Button aiButton;

		
		private global::System.Windows.Forms.Label arenaCountLabel;



		
		private global::System.Windows.Forms.PictureBox arenaPictureBox;


		
		private global::System.Windows.Forms.CheckBox AR_enableCheckBox;

		
		private global::System.Windows.Forms.CheckBox AR_limitCheckBox;

		
		private global::System.Windows.Forms.Label AR_limitLabel;

		
		private global::System.Windows.Forms.NumericUpDown AR_limitNumericBox;


		
		private global::System.Windows.Forms.ComboBox AR_leaderComboBox;

		
		private global::System.Windows.Forms.Label AR_masteryLabel;

		
		private global::System.Windows.Forms.GroupBox AR_skillGroupBox;

		
		private global::System.Windows.Forms.CheckBox AR_useRubyCheckBox;

		
		private global::System.Windows.Forms.Label AR_useRubyLabel;

		
		private global::System.Windows.Forms.NumericUpDown AR_useRubyNumericBox;

		
		private global::System.ComponentModel.IContainer components;


		
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Details;

		
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Event;



		
		private global::System.Windows.Forms.CheckBox GC_enableCheckBox;

		
		private global::System.Windows.Forms.ComboBox GC_formationComboBox;

		
		private global::System.Windows.Forms.Label GC_formationLabel;

		
		private global::System.Windows.Forms.Panel GC_formationPanel;

		
		private global::System.Windows.Forms.CheckBox GC_limitCheckBox;

		
		private global::System.Windows.Forms.Label GC_limitLabel;

		
		private global::System.Windows.Forms.NumericUpDown GC_limitNumericBox;



		
		private global::System.Windows.Forms.ComboBox GC_masteryComboBox;

		
		private global::System.Windows.Forms.Label GC_masteryLabel;

		
		private global::System.Windows.Forms.CheckBox GC_pos1CheckBox;

		
		private global::System.Windows.Forms.CheckBox GC_pos2CheckBox;

		
		private global::System.Windows.Forms.CheckBox GC_pos3CheckBox;

		
		private global::System.Windows.Forms.CheckBox GC_pos4CheckBox;

		
		private global::System.Windows.Forms.CheckBox GC_pos5CheckBox;


		
		private global::System.Windows.Forms.ComboBox GC_teamComboBox;

		
		private global::System.Windows.Forms.Label GC_teamLabel;



























		
		private global::System.Windows.Forms.Label goldChamberCountLabel;

		
		private global::System.Windows.Forms.PictureBox goldChamberPictureBox;













		
		private global::System.Windows.Forms.ToolStripStatusLabel profileToolStripLabel;

		
		private global::System.Windows.Forms.Label raidCountLabel;

		
		private global::System.Windows.Forms.PictureBox raidPictureBox;


		
		private global::System.Windows.Forms.RadioButton RD_autoSkillRadio;

		
		private global::System.Windows.Forms.RadioButton RD_bothSkillRadio;

		
		private global::System.Windows.Forms.CheckBox RD_enableCheckBox;





		
		private global::System.Windows.Forms.RadioButton RD_manualSkillRadio;

		
		private global::System.Windows.Forms.GroupBox RD_skillGroupBox;

		
		private global::System.Windows.Forms.Button RD_t1Skill01Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill02Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill03Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill04Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill05Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill06Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill07Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill08Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill09Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill10Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill01Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill02Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill03Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill04Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill05Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill06Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill07Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill08Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill09Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill10Button;

		
		private global::System.Windows.Forms.Label RD_team1Label;

		
		private global::System.Windows.Forms.CheckBox RD_team1LoopCheckBox;

		
		private global::System.Windows.Forms.Panel RD_team1Panel;

		
		private global::System.Windows.Forms.Label RD_team2Label;

		
		private global::System.Windows.Forms.CheckBox RD_team2LoopCheckBox;

		
		private global::System.Windows.Forms.Panel RD_team2Panel;



		
		private global::System.Windows.Forms.CheckBox RS_buyKeyHonorsCheckBox;

		
		private global::System.Windows.Forms.ComboBox RS_buyKeyHonorsComboBox;

		
		private global::System.Windows.Forms.Label RS_buyKeyHonorsLabel;

		
		private global::System.Windows.Forms.NumericUpDown RS_buyKeyHonorsNumericBox;

		
		private global::System.Windows.Forms.CheckBox RS_buyKeyRubiesCheckBox;

		
		private global::System.Windows.Forms.ComboBox RS_buyKeyRubiesComboBox;

		
		private global::System.Windows.Forms.Label RS_buyKeyRubiesLabel;

		
		private global::System.Windows.Forms.NumericUpDown RS_buyKeyRubiesNumericBox;

		
		private global::System.Windows.Forms.GroupBox RS_buyKeysGroupBox;

		
		private global::System.Windows.Forms.GroupBox RS_collectQuestsGroupBox;

		
		private global::System.Windows.Forms.GroupBox RS_giftsGroupBox;

		
		private global::System.Windows.Forms.RadioButton RS_heroAllRadioButton;

		
		private global::System.Windows.Forms.NumericUpDown RS_heroAmountNumericBox;

		
		private global::System.Windows.Forms.RadioButton RS_heroAmountRadioButton;

		
		private global::System.Windows.Forms.Panel RS_heroRadioPanel;

		
		private global::System.Windows.Forms.ComboBox RS_heroStarsComboBox;

		
		private global::System.Windows.Forms.CheckBox RS_InboxKeys;

		
		private global::System.Windows.Forms.GroupBox RS_inboxGroupBox;

		
		private global::System.Windows.Forms.CheckBox RS_inboxHonors;

		
		private global::System.Windows.Forms.CheckBox RS_inboxMaterials;



		
		private global::System.Windows.Forms.RadioButton RS_itemAllRadioButton;

		
		private global::System.Windows.Forms.NumericUpDown RS_itemAmountNumericBox;

		
		private global::System.Windows.Forms.RadioButton RS_itemAmountRadioButton;

		
		private global::System.Windows.Forms.Panel RS_itemRadioPanel;

		
		private global::System.Windows.Forms.ComboBox RS_itemStarsComboBox;

		
		private global::System.Windows.Forms.CheckBox RS_luckyBoxCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_luckyChestCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_questsBattleCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_questsHeroCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_questsItemCheckBox;

		
		private global::System.Windows.Forms.Label RS_questsNormalLabel;

		
		private global::System.Windows.Forms.CheckBox RS_questsSocialCheckBox;

		
		private global::System.Windows.Forms.Label RS_questsSpecialLabel;

		
		private global::System.Windows.Forms.CheckBox RS_sellHeroesCheckBox;

		
		private global::System.Windows.Forms.GroupBox RS_sellingGroupBox;

		
		private global::System.Windows.Forms.CheckBox RS_sellItemsCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_sendHonorsFacebook;

		
		private global::System.Windows.Forms.GroupBox RS_sendHonorsGroupBox;

		
		private global::System.Windows.Forms.CheckBox RS_sendHonorsInGame;

		
		private global::System.Windows.Forms.CheckBox RS_specialQuestsDailyCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_specialQuestsMonthlyCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_specialQuestsWeeklyCheckBox;



		
		private global::System.Windows.Forms.Button saveSettingsButton;


		
		private global::System.Windows.Forms.ToolStripStatusLabel splitterStatusLabel;

		
		private global::System.Windows.Forms.StatusStrip statusStrip;



		
		private global::System.Windows.Forms.ComboBox ST_currentProfileComboBox;

		
		private global::System.Windows.Forms.Label ST_currentProfileLabel;

		
		private global::System.Windows.Forms.Label ST_delayLabel;

		
		private global::System.Windows.Forms.TrackBar ST_delayTrackBar;

		
		private global::System.Windows.Forms.Label ST_delayValueLabel;



		
		private global::System.Windows.Forms.CheckBox ST_hotTimeProfileCheckBox;

		
		private global::System.Windows.Forms.ComboBox ST_hotTimeProfileComboBox;

		
		private global::System.Windows.Forms.Button ST_manageProfileButton;

		
		private global::System.Windows.Forms.Label ST_opacityLabel;

		
		private global::System.Windows.Forms.TrackBar ST_opacityTrackBar;








		
		private global::System.Windows.Forms.CheckBox ST_reconnectInterruptCheckBox;

		
		private global::System.Windows.Forms.NumericUpDown ST_reconnectNumericUpDown;


		
		private global::System.Windows.Forms.GroupBox summaryGroupBox;


		
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Time;

		
		private global::System.Windows.Forms.ToolTip toolTip;



		
		private global::System.Windows.Forms.PictureBox topheaderPictureBox;


        private System.Windows.Forms.Button aiPause;
        private System.Windows.Forms.ToolStripStatusLabel tsPixel;
		private System.Windows.Forms.ToolStripStatusLabel tsslCursorPosition;
		private System.Windows.Forms.Label RD_DragonLimit_lbl;
		private System.Windows.Forms.CheckBox RD_DragonLimitCheckBox;
		private System.Windows.Forms.CheckBox AD_StopOnFullHeroes_Checkbox;
        private System.Windows.Forms.Label HeroCountLabel;
        private System.Windows.Forms.CheckBox AD_CheckingHeroes_Checkbox;
		private System.Windows.Forms.ToolStripStatusLabel tsslBuildInfo;
        private System.Windows.Forms.ComboBox AD_difficultyComboBox2nd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AD_StopOnFullItems_Checkbox;
        private System.Windows.Forms.CheckBox ST_AutoProfileCheckBox;
        private System.Windows.Forms.CheckBox AD_StopOnLV30_Checkbox;
        private System.Windows.Forms.ComboBox RD_leaderComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AD_EnHottime_Checkbox;
        private System.Windows.Forms.CheckBox AD_UseFriendCheckBox;
        private System.Windows.Forms.CheckBox GC_UseFriendCheckBox;
        private System.Windows.Forms.CheckBox RD_OwnerDragon;
        private System.Windows.Forms.NumericUpDown RD_DragonLV;
        private System.Windows.Forms.CheckBox RD_LevelCheckBox;
        private System.Windows.Forms.NumericUpDown RD_RoundNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RD_DragonHP;
        private System.Windows.Forms.NumericUpDown RD_DragonLVLimit;
        private System.Windows.Forms.NumericUpDown RD_DragonHPLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AD_teamComboBox2;
        private System.Windows.Forms.Button AD_w3Skill15Button;
        private System.Windows.Forms.Button AD_w3Skill11Button;
        private System.Windows.Forms.Button AD_w3Skill12Button;
        private System.Windows.Forms.Button AD_w3Skill13Button;
        private System.Windows.Forms.Button AD_w3Skill14Button;
        private System.Windows.Forms.Button RD_t2Skill11Button;
        private System.Windows.Forms.Button RD_t2Skill12Button;
        private System.Windows.Forms.Button RD_t2Skill13Button;
        private System.Windows.Forms.Button RD_t2Skill14Button;
        private System.Windows.Forms.Button RD_t2Skill15Button;
        private System.Windows.Forms.Button RD_t1Skill11Button;
        private System.Windows.Forms.Button RD_t1Skill12Button;
        private System.Windows.Forms.Button RD_t1Skill13Button;
        private System.Windows.Forms.Button RD_t1Skill14Button;
        private System.Windows.Forms.Button RD_t1Skill15Button;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown AR_stopArenaNumericBox;
        private System.Windows.Forms.CheckBox AR_stopArenaCheckBox;
        private System.Windows.Forms.Button AD_w2Skill11Button;
        private System.Windows.Forms.Button AD_w2Skill12Button;
        private System.Windows.Forms.Button AD_w2Skill13Button;
        private System.Windows.Forms.Button AD_w2Skill14Button;
        private System.Windows.Forms.Button AD_w2Skill15Button;
        private System.Windows.Forms.Button AD_w1Skill11Button;
        private System.Windows.Forms.Button AD_w1Skill12Button;
        private System.Windows.Forms.Button AD_w1Skill13Button;
        private System.Windows.Forms.Button AD_w1Skill14Button;
        private System.Windows.Forms.Button AD_w1Skill15Button;
        private System.Windows.Forms.CheckBox AD_bootmodeCheckBox;
        private System.Windows.Forms.RadioButton AD_w2bothSkillRadio;
        private System.Windows.Forms.RadioButton AD_w2manualSkillRadio;
        private System.Windows.Forms.RadioButton AD_w2autoSkillRadio;
        private System.Windows.Forms.RadioButton AD_w3bothSkillRadio;
        private System.Windows.Forms.RadioButton AD_w3manualSkillRadio;
        private System.Windows.Forms.RadioButton AD_w3autoSkillRadio;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.CheckBox ST_AutoShutdownCheckBox;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label arenaWinLabel2;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label goldmineGoldAmountLabel2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label adventureKeysLabel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label towerKeysLabel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label arenaKeysLabel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label honorLabel2;
        private System.Windows.Forms.Label topazLabel2;
        private System.Windows.Forms.Label rubyLabel2;
        private System.Windows.Forms.Label goldLabel2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label h30Label2;
        private System.Windows.Forms.Label arenaLoseLabel2;
        private System.Windows.Forms.ComboBox RD_SummonLvl_CheckBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox RS_InboxCurrency;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.CheckBox GB_WaitForKeys;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label goldmineCountLabel;
        private System.Windows.Forms.Label botstatusLabel;
        private System.Windows.Forms.RichTextBox logsBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label rankArenaLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label dragoncountlabel;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox RD_ReadNick;
        private System.Windows.Forms.RichTextBox LG_logTextBox;
        private System.Windows.Forms.CheckBox AD_Pause100;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ST_TelegramChatIDTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ST_TelegramTokenTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox ST_TelegramEnableCheckBox;
        private System.Windows.Forms.CheckBox AD_RubyBooster_Checkbox;
        private System.Windows.Forms.CheckBox AD_StopOnDragon_Checkbox;
        private System.Windows.Forms.CheckBox AD_NoHeroUp_Checkbox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox evanGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox SP_evanCheckBox;
        private System.Windows.Forms.NumericUpDown SP_evanLimitNumericBox;
        private System.Windows.Forms.RadioButton SP_evanHardRadioButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton SP_evanNorRadioButton;
        private System.Windows.Forms.GroupBox SP_skillGroupBox;
        private System.Windows.Forms.Panel SP_wave3Panel;
        private System.Windows.Forms.RadioButton SP_w3bothSkillRadio;
        private System.Windows.Forms.Button SP_w3Skill11Button;
        private System.Windows.Forms.RadioButton SP_w3manualSkillRadio;
        private System.Windows.Forms.Button SP_w3Skill12Button;
        private System.Windows.Forms.RadioButton SP_w3autoSkillRadio;
        private System.Windows.Forms.Button SP_w3Skill13Button;
        private System.Windows.Forms.Button SP_w3Skill14Button;
        private System.Windows.Forms.Button SP_w3Skill15Button;
        private System.Windows.Forms.CheckBox SP_wave3LoopCheckBox;
        private System.Windows.Forms.Button SP_w3Skill10Button;
        private System.Windows.Forms.Button SP_w3Skill09Button;
        private System.Windows.Forms.Button SP_w3Skill08Button;
        private System.Windows.Forms.Button SP_w3Skill07Button;
        private System.Windows.Forms.Button SP_w3Skill06Button;
        private System.Windows.Forms.Button SP_w3Skill05Button;
        private System.Windows.Forms.Button SP_w3Skill04Button;
        private System.Windows.Forms.Button SP_w3Skill03Button;
        private System.Windows.Forms.Button SP_w3Skill02Button;
        private System.Windows.Forms.Label SP_wave3Label;
        private System.Windows.Forms.Button SP_w3Skill01Button;
        private System.Windows.Forms.RadioButton SP_bothSkillRadio;
        private System.Windows.Forms.Panel SP_wave2Panel;
        private System.Windows.Forms.RadioButton SP_w2bothSkillRadio;
        private System.Windows.Forms.RadioButton SP_w2manualSkillRadio;
        private System.Windows.Forms.RadioButton SP_w2autoSkillRadio;
        private System.Windows.Forms.Button SP_w2Skill11Button;
        private System.Windows.Forms.CheckBox SP_wave2LoopCheckBox;
        private System.Windows.Forms.Button SP_w2Skill12Button;
        private System.Windows.Forms.Button SP_w2Skill10Button;
        private System.Windows.Forms.Button SP_w2Skill13Button;
        private System.Windows.Forms.Button SP_w2Skill09Button;
        private System.Windows.Forms.Button SP_w2Skill14Button;
        private System.Windows.Forms.Button SP_w2Skill08Button;
        private System.Windows.Forms.Button SP_w2Skill15Button;
        private System.Windows.Forms.Button SP_w2Skill07Button;
        private System.Windows.Forms.Button SP_w2Skill06Button;
        private System.Windows.Forms.Button SP_w2Skill05Button;
        private System.Windows.Forms.Button SP_w2Skill04Button;
        private System.Windows.Forms.Button SP_w2Skill03Button;
        private System.Windows.Forms.Button SP_w2Skill02Button;
        private System.Windows.Forms.Label SP_wave2Label;
        private System.Windows.Forms.Button SP_w2Skill01Button;
        private System.Windows.Forms.RadioButton SP_manualSkillRadio;
        private System.Windows.Forms.RadioButton SP_autoSkillRadio;
        private System.Windows.Forms.Panel SP_wave1Panel;
        private System.Windows.Forms.Button SP_w1Skill11Button;
        private System.Windows.Forms.CheckBox SP_wave1LoopCheckBox;
        private System.Windows.Forms.Button SP_w1Skill10Button;
        private System.Windows.Forms.Button SP_w1Skill12Button;
        private System.Windows.Forms.Button SP_w1Skill09Button;
        private System.Windows.Forms.Button SP_w1Skill08Button;
        private System.Windows.Forms.Button SP_w1Skill13Button;
        private System.Windows.Forms.Button SP_w1Skill07Button;
        private System.Windows.Forms.Button SP_w1Skill06Button;
        private System.Windows.Forms.Button SP_w1Skill14Button;
        private System.Windows.Forms.Button SP_w1Skill05Button;
        private System.Windows.Forms.Button SP_w1Skill04Button;
        private System.Windows.Forms.Button SP_w1Skill15Button;
        private System.Windows.Forms.Button SP_w1Skill03Button;
        private System.Windows.Forms.Button SP_w1Skill02Button;
        private System.Windows.Forms.Label SP_wave1Label;
        private System.Windows.Forms.Button SP_w1Skill01Button;
        private System.Windows.Forms.CheckBox SP_UseTicket1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.GroupBox ADCH_ChangeHeroGroupBox;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.TabPage tabPage18;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage tabPage19;
        private System.Windows.Forms.TabPage tabPage20;
        private System.Windows.Forms.GroupBox groupBox39;
        private System.Windows.Forms.TabPage tabPage21;
        private System.Windows.Forms.TabPage tabPage22;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.LinkLabel linkLabel12;
        private System.Windows.Forms.LinkLabel linkLabel13;
        private System.Windows.Forms.LinkLabel linkLabel14;
        private System.Windows.Forms.GroupBox groupBox38;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox ST_foregroundMode;
        private System.Windows.Forms.Button ST_toggleBlueStacksButton;
        private System.Windows.Forms.CheckBox ST_forceActiveCheckBox;
        private System.Windows.Forms.GroupBox ST_blueStacksGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button screenshotButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage23;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStripLabel;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox EX_SendAgainCheckBox;
        private System.Windows.Forms.CheckBox EX_EnableCheckBox;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox AD_SummonAuto;
        private System.Windows.Forms.ComboBox ST_NoMoreProfileComboBox;
    }
}
