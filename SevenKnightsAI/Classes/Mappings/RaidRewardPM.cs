using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidRewardPM
    {
        public static readonly PixelMapping MemberListBackground = new PixelMapping //M Letter Member Word
        {
            X = 45,
            Y = 84,
            Color = 16754182,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardButton = new PixelMapping
        {
            X = 782,
            Y = 421,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RewardButtonBackground = new PixelMapping
        {
            X = 782,
            Y = 421,
            Color = 14259459,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardButtonRedIcon = new PixelMapping
        {
            X = 760,
            Y = 401,
            Color = 12789252,
            Type = MappingType.ANCHOR
        };
    }
}