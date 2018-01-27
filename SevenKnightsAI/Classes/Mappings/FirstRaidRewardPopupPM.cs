using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class FirstRaidRewardPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 296,
            Y = 28,
            Color = 262914,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 422,
            Y = 397,
            Color = 16761123,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping OkButtonBorder = new PixelMapping
        {
            X = 396,
            Y = 385,
            Color = 16706216,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 316,
            Y = 259,
            Color = 16184823,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 422,
            Y = 397,
            Color = 16761123,
            Type = MappingType.ANCHOR
        };
    }
}