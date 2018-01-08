using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class OutOfTicketDGPM
    {
        public static readonly PixelMapping BorderTopLeft = new PixelMapping
        {
            X = 756,
            Y = 491,
            Color = 3216157,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderBottomRight = new PixelMapping
        {
            X = 697,
            Y = 28,
            Color = 3748123,
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