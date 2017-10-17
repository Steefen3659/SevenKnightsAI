using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdsPM
    {
        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 944,
            Y = 15,
            Color = 16568322,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping CloseAds = new PixelMapping
        {
            X = 944,
            Y = 15,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SkipTodayCheckBox_1 = new PixelMapping
        {
            X = 15,
            Y = 517,
            Color = 5592405,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping SkipTodayCheckBox_2 = new PixelMapping
        {
            X = 22,
            Y = 523,
            Color = 5592405,
            Type = MappingType.BOTH
        };
    }
}