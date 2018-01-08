using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidRewardPM
    {
        public static readonly PixelMapping MemberListBackground = new PixelMapping //M Letter Member Word
        {
            X = 51,
            Y = 91,
            Color = 16754182,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardButton = new PixelMapping
        {
            X = 822,
            Y = 415,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RewardButtonBackground = new PixelMapping
        {
            X = 822,
            Y = 415,
            Color = 14194179,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardButtonRedIcon = new PixelMapping
        {
            X = 759,
            Y = 397,
            Color = 12920833,
            Type = MappingType.ANCHOR
        };
    }
}