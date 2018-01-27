using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidRewardPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 745,
            Y = 81,
            Color = 3744769,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 494,
            Y = 395,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping OkButtonBorder = new PixelMapping
        {
            X = 396,
            Y = 386,
            Color = 16244639,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 426,
            Y = 138,
            Color = 14195472,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 421,
            Y = 397,
            Color = 16761123,
            Type = MappingType.ANCHOR
        };
    }
}