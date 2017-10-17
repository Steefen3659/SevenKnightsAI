using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidFightPM
    {
        public static readonly PixelMapping DragonIcon = new PixelMapping
        {
            X = 104,
            Y = 59,
            Color = 16711421,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping DragonAwakeye = new PixelMapping
        {
            X = 96,
            Y = 33,
            Color = 16197143,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SkipButton = new PixelMapping
        {
            X = 45,
            Y = 313,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping SkipOff = new PixelMapping
        {
            X = 36,
            Y = 309,
            Color = 12231283,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SkipOn = new PixelMapping
        {
            X = 37,
            Y = 310,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TeamTransition_1 = new PixelMapping
        {
            X = 706,
            Y = 15,
            Color = 7625021,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TeamTransition_2 = new PixelMapping
        {
            X = 610,
            Y = 152,
            Color = 11043157,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TeamTransition_3 = new PixelMapping
        {
            X = 111,
            Y = 215,
            Color = 6708057,
            Type = MappingType.ANCHOR
        };
    }
}