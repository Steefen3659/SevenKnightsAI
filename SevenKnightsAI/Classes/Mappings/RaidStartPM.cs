using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidStartPM
    {
        public static readonly PixelMapping ManageParty1Border = new PixelMapping //Main Attack Top left border
        {
            X = 45,
            Y = 69,
            Color = 13863428,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty1Button = new PixelMapping
        {
            X = 165,
            Y = 512,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ManageParty2Border = new PixelMapping
        {
            X = 535,
            Y = 92,
            Color = 7954740,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty2Button = new PixelMapping //support attack bottom right border
        {
            X = 412,
            Y = 512,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping StartButton = new PixelMapping
        {
            X = 812,
            Y = 477,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping StartButtonBorder = new PixelMapping
        {
            X = 924,
            Y = 478,
            Color = 16705446,
            Type = MappingType.ANCHOR
        };
    }
}