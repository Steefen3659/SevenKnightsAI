using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TowerLostPM
    {
        public static readonly PixelMapping GetStrongerButton = new PixelMapping
        {
            X = 891,
            Y = 257,
            Color = 15852171,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 889,
            Y = 362,
            Color = 5120784,
            Type = MappingType.BOTH
        };
    }
}