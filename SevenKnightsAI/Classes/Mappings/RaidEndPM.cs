using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidEndPM
    {
        public static readonly PixelMapping AgainButton = new PixelMapping
        {
            X = 889,
            Y = 227,
            Color = 11303216,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GetStrongerButton = new PixelMapping
        {
            X = 903,
            Y = 117,
            Color = 15587440,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping LobbyButton = new PixelMapping
        {
            X = 906,
            Y = 472,
            Color = 16177007,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidButton = new PixelMapping
        {
            X = 903,
            Y = 345,
            Color = 15650665,
            Type = MappingType.BOTH
        };
    }
}