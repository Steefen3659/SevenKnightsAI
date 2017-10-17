using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopBuyPopupPM
    {
        public static readonly PixelMapping BuyButton = new PixelMapping
        {
            X = 529,
            Y = 410,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 385,
            Y = 418,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 259,
            Y = 186,
            Color = 16772008,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 699,
            Y = 186,
            Color = 16772008,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RedCross = new PixelMapping
        {
            X = 324,
            Y = 416,
            Color = 14302728,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 523,
            Y = 419,
            Color = 16762151,
            Type = MappingType.ANCHOR
        };
    }
}