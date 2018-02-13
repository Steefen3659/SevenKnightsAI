using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SellItemConfirmPopupPM
    {
        public static readonly PixelMapping DimmedBG_1 = new PixelMapping
        {
            X = 872,
            Y = 200,
            Color = 4272914,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DimmedBG_2 = new PixelMapping
        {
            X = 64,
            Y = 449,
            Color = 4931877,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 316,
            Y = 393,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedCross = new PixelMapping
        {
            X = 316,
            Y = 393,
            Color = 14433544,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SellButton = new PixelMapping
        {
            X = 532,
            Y = 398,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 532,
            Y = 398,
            Color = 16759838,
            Type = MappingType.ANCHOR
        };
    }
}