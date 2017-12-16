using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class NoticePM
    {
        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 920,
            Y = 27,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping TopBorderLeft = new PixelMapping
        {
            X = 39,
            Y = 30,
            Color = 16763904,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TopBorderRight = new PixelMapping
        {
            X = 922,
            Y = 517,
            Color = 16763904,
            Type = MappingType.ANCHOR
        };
    }
}