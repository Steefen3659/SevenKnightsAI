using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopPurchaseCompletePopupPM
    {
        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 485,
            Y = 396,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 259,
            Y = 205,
            Color = 16772008,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 532,
            Y = 153,
            Color = 16758803,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ShopBGMiMic = new PixelMapping
        {
            X = 829,
            Y = 94,
            Color = 3480093,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 421,
            Y = 400,
            Color = 16757782,
            Type = MappingType.ANCHOR
        };
    }
}