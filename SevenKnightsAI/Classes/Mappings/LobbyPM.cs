using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class LobbyPM
    {
        #region Public Fields

        public static readonly PixelMapping StatusBoard = new PixelMapping //evan hair
        {
            X = 54,
            Y = 246,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping MasteryButton = new PixelMapping
        {
            X = 291,
            Y = 81,
            Color = 11438155,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Mastery_1 = new PixelMapping
        {
            X = 396,
            Y = 152,
            Color = 15782941,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Mastery_2 = new PixelMapping
        {
            X = 399,
            Y = 162,
            Color = 15454237,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Mastery_3 = new PixelMapping
        {
            X = 400,
            Y = 159,
            Color = 16769568,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 883,
            Y = 496,
            Color = 5056515,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BattleButton = new PixelMapping
        {
            X = 717,
            Y = 497,
            Color = 6235918,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CostumeButton = new PixelMapping
        {
            X = 508,
            Y = 487,
            Color = 3093560,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 0;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping GuildButton = new PixelMapping
        {
            X = 293,
            Y = 485,
            Color = 15987160,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroButton = new PixelMapping
        {
            X = 38,
            Y = 491,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 0;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping InboxAvailable = new PixelMapping
        {
            X = 808,
            Y = 8,
            Color = 13051905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping InboxButton = new PixelMapping
        {
            X = 827,
            Y = 28,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int KEY_OFFSET_X = 0;

        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping LuckyBoxAvailable_1 = new PixelMapping
        {
            X = 903,
            Y = 269,
            Color = 15592677,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LuckyBoxAvailable_2 = new PixelMapping
        {
            X = 910,
            Y = 260,
            Color = 16448248,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LuckyBoxButton = new PixelMapping
        {
            X = 907,
            Y = 245,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping LuckyBoxLastOne_1 = new PixelMapping
        {
            X = 891,
            Y = 262,
            Color = 16711422,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LuckyBoxLastOne_2 = new PixelMapping
        {
            X = 891,
            Y = 270,
            Color = 15658476,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MaysLuckyChestAvailable_1 = new PixelMapping
        {
            X = 903,
            Y = 183,
            Color = 16316143,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MaysLuckyChestAvailable_2 = new PixelMapping
        {
            X = 910,
            Y = 174,
            Color = 16579578,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MaysLuckyChestButton = new PixelMapping
        {
            X = 909,
            Y = 156,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping MenuButtonYellowLeft = new PixelMapping
        {
            X = 747,
            Y = 37,
            Color = 11236654,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MenuButtonYellowRight = new PixelMapping
        {
            X = 790,
            Y = 32,
            Color = 12223286,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestAvailable = new PixelMapping
        {
            X = 93,
            Y = 451,
            Color = 13051905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestButton = new PixelMapping
        {
            X = 120,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        //public static readonly int RUBY_OFFSET_X = 10;
        public static readonly int RUBY_OFFSET_X = 0;

        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping RudysGiftButton = new PixelMapping
        {
            X = 910,
            Y = 402,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ShopButton = new PixelMapping
        {
            X = 709,
            Y = 461,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SocialAvailable = new PixelMapping
        {
            X = 177,
            Y = 450,
            Color = 13051905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SocialButton = new PixelMapping
        {
            X = 209,
            Y = 492,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int TOPAZ_OFFSET_X = 0;

        public static readonly int TOPAZ_OFFSET_Y = 0;

        public static readonly Rectangle OwnerLocation = new Rectangle
        {
            X = 209,
            Y = 168,
            Width = 200,
            Height = 30
        };

        /* Exploration */

        public static readonly PixelMapping ExplorationAvailable1 = new PixelMapping
        {
            X = 902,
            Y = 221,
            Color = 16506764,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ExplorationAvailable2 = new PixelMapping
        {
            X = 906,
            Y = 268,
            Color = 6703915,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ExplorationLobbyButton = new PixelMapping
        {
            X = 910,
            Y = 235,
            Color = 14399071,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}