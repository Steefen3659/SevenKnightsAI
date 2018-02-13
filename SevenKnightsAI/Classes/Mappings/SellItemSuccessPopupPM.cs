using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SellItemSuccessPopupPM
    {
        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 451,
            Y = 398,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 451,
            Y = 398,
            Color = 16760609,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 94,
            Y = 18,
            Color = 4868419,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 456,
            Y = 142,
            Color = 15970066,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 484,
            Y = 319,
            Color = 16108130,
            Type = MappingType.ANCHOR
        };
    }
}