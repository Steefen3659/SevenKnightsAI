using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SharedPM
    {
        #region Public Fields

        public static readonly PixelMapping BackButton = new PixelMapping
        {
            X = 58,
            Y = 28,
            Color = 12925963,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BackButtonAnchor = new PixelMapping
        {
            X = 62,
            Y = 36,
            Color = 12005898,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_AutoSkillButton = new PixelMapping
        {
            X = 128,
            Y = 496,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_AutoSkillOff = new PixelMapping
        {
            X = 127,
            Y = 524,
            Color = 7033650,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_AutoSkillOnBottom = new PixelMapping
        {
            //X = 128,
            //Y = 525,
            //Color = 7481611,
            X = 130,
            Y = 496,
            Color = 7748889,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_AutoSkillOnTop = new PixelMapping
        {
            //X = 128,
            //Y = 466,
            //Color = 3547410,
            X = 120,
            Y = 496,
            Color = 8866079,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_ChatButton = new PixelMapping
        {
            X = 925,
            Y = 121,
            Color = 14272898,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Fight_PauseButton = new PixelMapping
        {
            X = 922,
            Y = 181,
            Color = 5317647,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Fight_Skill1 = new PixelMapping
        {
            X = 576,
            Y = 436,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill1_Q1_1 = new PixelMapping
        {
            X = 590,
            Y = 419,
            Color = 16244104,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill1_Q1_2 = new PixelMapping
        {
            X = 587,
            Y = 426,
            Color = 12157741,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill2 = new PixelMapping
        {
            X = 668,
            Y = 444,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill2_Q1_1 = new PixelMapping
        {
            X = 675,
            Y = 420,
            Color = 16707492,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill2_Q1_2 = new PixelMapping
        {
            X = 674,
            Y = 429,
            Color = 15519103,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill3 = new PixelMapping
        {
            X = 762,
            Y = 420,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill3_Q1_1 = new PixelMapping
        {
            X = 759,
            Y = 428,
            Color = 14597744,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill3_Q1_2 = new PixelMapping
        {
            X = 744,
            Y = 444,
            Color = 6578782,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill4 = new PixelMapping
        {
            X = 826,
            Y = 441,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill4_Q1_1 = new PixelMapping
        {
            X = 847,
            Y = 421,
            Color = 16571254,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill4_Q1_2 = new PixelMapping
        {
            X = 850,
            Y = 406,
            Color = 15651203,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill5 = new PixelMapping
        {
            X = 921,
            Y = 434,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill5_Q1_1 = new PixelMapping
        {
            X = 932,
            Y = 421,
            Color = 16770702,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill5_Q1_2 = new PixelMapping
        {
            X = 931,
            Y = 428,
            Color = 14596966,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill6 = new PixelMapping
        {
            X = 569,
            Y = 495,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill6_Q1_1 = new PixelMapping
        {
            X = 590,
            Y = 477,
            Color = 16770443,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill6_Q1_2 = new PixelMapping
        {
            X = 589,
            Y = 484,
            Color = 14991981,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill7 = new PixelMapping
        {
            X = 665,
            Y = 502,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill7_Q1_1 = new PixelMapping
        {
            X = 676,
            Y = 475,
            Color = 16705428,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill7_Q1_2 = new PixelMapping
        {
            X = 673,
            Y = 484,
            Color = 15254375,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill8 = new PixelMapping
        {
            X = 737,
            Y = 497,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill8_Q1_1 = new PixelMapping
        {
            X = 759,
            Y = 477,
            Color = 16771221,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill8_Q1_2 = new PixelMapping
        {
            X = 759,
            Y = 482,
            Color = 13608787,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill9 = new PixelMapping
        {
            X = 828,
            Y = 507,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill9_Q1_1 = new PixelMapping
        {
            X = 847,
            Y = 475,
            Color = 16705428,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill9_Q1_2 = new PixelMapping
        {
            X = 845,
            Y = 485,
            Color = 15453565,
            Type = MappingType.ANCHOR
        };
        
        public static readonly PixelMapping Fight_Skill10 = new PixelMapping
        {
            X = 919,
            Y = 508,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill10_Q1_1 = new PixelMapping
        {
            X = 932,
            Y = 476,
            Color = 16771995,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill10_Q1_2 = new PixelMapping
        {
            X = 931,
            Y = 485,
            Color = 14925157,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill11 = new PixelMapping
        {
            X = 581,
            Y = 386,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping Fight_Skill11_Q1_1 = new PixelMapping
        {
            X = 590,
            Y = 364,
            Color = 16772253,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill11_Q1_2 = new PixelMapping
        {
            X = 589,
            Y = 374,
            Color = 14134609,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill12 = new PixelMapping
        {
            X = 662,
            Y = 381,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill12_Q1_1 = new PixelMapping
        {
            X = 695,
            Y = 365,
            Color = 16770700,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill12_Q1_2 = new PixelMapping
        {
            X = 694,
            Y = 372,
            Color = 14794344,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill13 = new PixelMapping
        {
            X = 747,
            Y = 381,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill13_Q1_1 = new PixelMapping
        {
            X = 772,
            Y = 367,
            Color = 16702843,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill13_Q1_2 = new PixelMapping
        {
            X = 771,
            Y = 370,
            Color = 13674579,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill14 = new PixelMapping
        {
            X = 832,
            Y = 381,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill14_Q1_1 = new PixelMapping
        {
            X = 850,
            Y = 367,
            Color = 16702842,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill14_Q1_2 = new PixelMapping
        {
            X = 848,
            Y = 374,
            Color = 14664054,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill15 = new PixelMapping
        {
            X = 920,
            Y = 381,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill15_Q1_1 = new PixelMapping
        {
            X = 927,
            Y = 365,
            Color = 16771738,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill15_Q1_2 = new PixelMapping
        {
            X = 926,
            Y = 372,
            Color = 14729592,
            Type = MappingType.ANCHOR
        };
        /* Skill 5 Special Dungeon*/
        public static readonly PixelMapping Fight_Skill16 = new PixelMapping
        {
            X = 603,
            Y = 495,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill16_Q1_1 = new PixelMapping
        {
            X = 618,
            Y = 476,
            Color = 16772513,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill16_Q1_2 = new PixelMapping
        {
            X = 617,
            Y = 484,
            Color = 14927485,
            Type = MappingType.ANCHOR
        };
        /* Skill 5 Special Dungeon*/
        public static readonly PixelMapping Fight_SpeedButton = new PixelMapping
        {
            X = 44,
            Y = 496,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_SpeedOff = new PixelMapping
        {
            X = 43,
            Y = 491,
            Color = 5586469,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_SpeedOn = new PixelMapping
        {
            X = 50,
            Y = 486,
            Color = 4465168,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Friends_DimmedBG_1 = new PixelMapping
        {
            X = 751,
            Y = 28,
            Color = 4207374,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Friends_DimmedBG_2 = new PixelMapping
        {
            X = 450,
            Y = 112,
            Color = 1122080,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Friends_PopupBorder = new PixelMapping
        {
            X = 260,
            Y = 203,
            Color = 16772008,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Full_DimmedBG = new PixelMapping
        {
            X = 137,
            Y = 51,
            Color = 328706,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Full_NoButton = new PixelMapping
        {
            X = 330,
            Y = 395,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Full_ProceedButton = new PixelMapping
        {
            X = 480,
            Y = 395,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Full_SellButton = new PixelMapping
        {
            X = 594,
            Y = 395,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping GiftFull_CancelButton = new PixelMapping
        {
            X = 375,
            Y = 396,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping GiftFull_DimmedBG = new PixelMapping
        {
            X = 885,
            Y = 18,
            Color = 4930058,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GiftFull_PopupBorder = new PixelMapping
        {
            X = 260,
            Y = 200,
            Color = 16639654,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GiftFull_RedCross = new PixelMapping
        {
            X = 314,
            Y = 394,
            Color = 14171656,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Hero_BlackBar = new PixelMapping
        {
            X = 856,
            Y = 35,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Hero_BottomLeftBorder = new PixelMapping
        {
            X = 170,
            Y = 533,
            //Color = 10972681,
            Color = 11170319,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Hero_LeaderButton = new PixelMapping
        {
            X = 710,
            Y = 479,
            Color = 13999149,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Hero_Level30_1 = new PixelMapping
        {
            X = 658,
            Y = 74,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Hero_Level30_2 = new PixelMapping
        {
            X = 664,
            Y = 82,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Hero_Level30_3 = new PixelMapping
        {
            X = 657,
            Y = 93,
            Color = 16514043,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle Hero_R_Level_30 = new Rectangle
        {
            X = 627,
            Y = 60,
            Width = 145,
            Height = 42
            //X = 636,
            //Y = 63,
            //Width = 134,
            //Height = 39
        };

        public static readonly PixelMapping Loot_HeroButton = new PixelMapping
        {
            X = 51,
            Y = 499,
            Color = 2231301,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Loot_LobbyButton = new PixelMapping
        {
            X = 890,
            Y = 489,
            Color = 16177007,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Lost_LobbyButton = new PixelMapping
        {
            X = 892,
            Y = 476,
            Color = 16177007,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Lost_Moon = new PixelMapping
        {
            X = 533,
            Y = 88,
            Color = 16777215,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Lost_PurpleBase = new PixelMapping
        {
            X = 357,
            Y = 425,
            Color = 6178988,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping PrepareFight_ManageButton = new PixelMapping
        {
            X = 366,
            Y = 478,
            Color = 12752445,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PrepareFight_Mastery_1 = new PixelMapping
        {
            X = 396,
            Y = 152,
            Color = 15782941,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PrepareFight_Mastery_2 = new PixelMapping
        {
            X = 399,
            Y = 162,
            Color = 15519773,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PrepareFight_Mastery_3 = new PixelMapping
        {
            X = 400,
            Y = 159,
            Color = 16769568,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PrepareFight_MasteryButton = new PixelMapping
        {
            X = 382,
            Y = 182,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PrepareFight_StartButton = new PixelMapping
        {
            X = 650,
            Y = 500,
            Color = 5973262,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PrepareFight_TeamAButton = new PixelMapping
        {
            X = 166,
            Y = 84,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PrepareFight_TeamBButton = new PixelMapping
        {
            X = 264,
            Y = 84,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PrepareFight_TeamCButton = new PixelMapping
        {
            X = 365,
            Y = 84,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Quests_Background = new PixelMapping
        {
            X = 410,
            Y = 63,
            Color = 12905957,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Quests_CharacterArmor = new PixelMapping
        {
            X = 84,
            Y = 368,
            Color = 16777213,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle R_GoldBase = new Rectangle
        {
            X = 196,
            Y = 19,
            Width = 103,
            Height = 22
        };

        public static readonly Rectangle R_HonorBase = new Rectangle
        {
            X = 530,
            Y = 19,
            Width = 84,
            Height = 22
        };

        public static readonly Rectangle R_KeyNormalBase = new Rectangle
        {
            X = 50,
            Y = 19,
            Width = 67,
            Height = 21
        };

        public static readonly Rectangle R_KeyOnTopTimeBase = new Rectangle
        {
            X = 50,
            Y = 9,
            Width = 67,
            Height = 20
        };

        public static readonly Rectangle R_RubyBase = new Rectangle
        {
            X = 380,
            Y = 19,
            Width = 73,
            Height = 22
        };

        public static readonly Rectangle R_TimeBase = new Rectangle
        {
            X = 68,
            Y = 28,
            Width = 50,
            Height = 20
        };

        public static readonly Rectangle R_TopazBase = new Rectangle
        {
            X = 1,
            Y = 19,
            Width = 53,
            Height = 20
        };

        public static readonly PixelMapping Rewards_OkButton = new PixelMapping
        {
            X = 486,
            Y = 396,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Rewards_PopupBorder = new PixelMapping
        {
            X = 260,
            Y = 200,
            Color = 16639654,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Rewards_YellowTick = new PixelMapping
        {
            X = 421,
            Y = 401,
            Color = 16756754,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ShopPopup_DimmedBG = new PixelMapping
        {
            X = 60,
            Y = 24,
            Color = 3871492,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping UseFriendButton = new PixelMapping
        {
            X = 797,
            Y = 151,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping FriendClick = new PixelMapping
        {
            X = 470,
            Y = 470,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HelpFriendOK = new PixelMapping
        {
            X = 480,
            Y = 420,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HelpFriendTik = new PixelMapping
        {
            X = 420,
            Y = 422,
            Color = 0xffb517,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HelpFriendBorder = new PixelMapping
        {
            X = 189,
            Y = 368,
            Color = 0x8b673a,
            Type = MappingType.ANCHOR
        };
        #endregion Public Fields
    }
}