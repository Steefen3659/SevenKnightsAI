using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopBuyFailedPopupPM
    {
        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 323,
            Y = 415,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PopupBorderLeft = new PixelMapping
        {
            X = 531,
            Y = 341,
            Color = 8806948,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderRight = new PixelMapping
        {
            X = 579,
            Y = 359,
            Color = 12554292,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 519,
            Y = 421,
            Color = 16759581,
            Type = MappingType.ANCHOR
        };
    }
}