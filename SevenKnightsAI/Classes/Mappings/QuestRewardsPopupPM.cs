using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class QuestRewardsPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 210,
            Y = 59,
            Color = 3753280,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestIcon = new PixelMapping
        {
            X = 627,
            Y = 470,
            Color = 15455338,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AragonPic = new PixelMapping
        {
            X = 101,
            Y = 252,
            Color = 16579570,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 800,
            Y = 485,
            Color = 0,
            Type = MappingType.BUTTON
        };

    }
}