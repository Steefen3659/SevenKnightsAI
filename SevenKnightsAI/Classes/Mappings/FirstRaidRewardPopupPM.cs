using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class FirstRaidRewardPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 885,
            Y = 426,
            Color = 1249024,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 421,
            Y = 396,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping OkButtonBorder = new PixelMapping
        {
            X = 395,
            Y = 388,
            Color = 14007428,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 259,
            Y = 197,
            Color = 15915934,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 421,
            Y = 396,
            Color = 16763176,
            Type = MappingType.ANCHOR
        };
    }
}