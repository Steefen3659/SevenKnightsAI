using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class NoticePM
    {
        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 945,
            Y = 15,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping TopBorderLeft = new PixelMapping
        {
            X = 418,
            Y = 15,
            Color = 16701202,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TopBorderRight = new PixelMapping
        {
            X = 575,
            Y = 15,
            Color = 16701202,
            Type = MappingType.ANCHOR
        };
    }
}