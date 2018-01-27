using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class BattleModesPM
    {
        #region Public Fields

        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 654,
            Y = 412,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 860,
            Y = 473,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CelestialTowerButton = new PixelMapping
        {
            X = 858,
            Y = 86,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SpecialDungeonButton = new PixelMapping
        {
            X = 268,
            Y = 209,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RaidButton = new PixelMapping
        {
            X = 662,
            Y = 108,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping BorderBottomRight = new PixelMapping
        {
            X = 16,
            Y = 527,
            Color = 6767900,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderTopLeft = new PixelMapping
        {
            X = 948,
            Y = 8,
            Color = 2365708,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BossFightButton = new PixelMapping
        {
            X = 720,
            Y = 425,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CastleRushButton = new PixelMapping
        {
            X = 800,
            Y = 190,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 218;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping GoldPlusButton = new PixelMapping
        {
            X = 550,
            Y = 29,
            Color = 11573327,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestRedScroll = new PixelMapping
        {
            X = 44,
            Y = 476,
            Color = 15866131,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GuildWarButton = new PixelMapping
        {
            X = 260,
            Y = 400,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 227;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly int RUBY_OFFSET_X = 223;

        public static readonly int RUBY_OFFSET_Y = 0;

        #endregion Public Fields
    }
}