using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class QuestSelectPM
    {
        #region Public Fields

        public static readonly PixelMapping QuestAvailable = new PixelMapping
        {
            X = 515,
            Y = 223,
            Color = 13051905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestButton = new PixelMapping
        {
            X = 558,
            Y = 270,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestIcon = new PixelMapping
        {
            X = 554,
            Y = 253,
            Color = 15382115,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SpecialQuestAvailable = new PixelMapping
        {
            X = 365,
            Y = 223,
            Color = 12920833,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SpecialQuestButton = new PixelMapping
        {
            X = 402,
            Y = 270,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SpecialQuestIcon = new PixelMapping
        {
            X = 394,
            Y = 261,
            Color = 13739614,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TitleBorderLeft = new PixelMapping
        {
            X = 268,
            Y = 180,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TitleBorderRight = new PixelMapping
        {
            X = 690,
            Y = 180,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        #endregion Public Fields
    }
}