using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class OutOfTicketDGPM
    {
        public static readonly PixelMapping BorderTopLeft = new PixelMapping
        {
            X = 268,
            Y = 130,
            Color = 852225,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderBottomRight = new PixelMapping
        {
            X = 512,
            Y = 391,
            Color = 16711397,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 322,
            Y = 396,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping EnterButton = new PixelMapping
        {
            X = 640,
            Y = 394,
            Color = 16097536,
            Type = MappingType.BUTTON
        };
    }
}