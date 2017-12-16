using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroJoinPM
    {
        #region Public Fields

        public static readonly PixelMapping JoinButton = new PixelMapping
        {
            X = 840,
            Y = 478,
            Color = 16049284,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping JoinButtonIcon = new PixelMapping
        {
            //X = 861,
            //Y = 456,
            //Color = 15058003,
            X = 840,
            Y = 478,
            Color = 16049284,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SellButton = new PixelMapping
        {
            X = 594,
            Y = 489,
            Color = 16049282,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping KeyLockButton = new PixelMapping
        {
            X = 210,
            Y = 480,
            Color = 8680526,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OffensiveIcon1 = new PixelMapping
        {
            X = 46,
            Y = 51,
            Color = 14273915,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OffensiveIcon2 = new PixelMapping
        {
            X = 53,
            Y = 94,
            Color = 9727284,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SupportIcon1 = new PixelMapping
        {
            X = 71,
            Y = 55,
            Color = 13088876,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SupportIcon2 = new PixelMapping
        {
            X = 69,
            Y = 88,
            Color = 3021059,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MagicIcon1 = new PixelMapping
        {
            X = 57,
            Y = 56,
            Color = 13811826,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MagicIcon2 = new PixelMapping
        {
            X = 86,
            Y = 67,
            Color = 13019745,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DeffIcon1 = new PixelMapping
        {
            X = 53,
            Y = 62,
            Color = 13613934,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DeffIcon2 = new PixelMapping
        {
            X = 91,
            Y = 75,
            Color = 8545842,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping UniversalIcon1 = new PixelMapping
        {
            X = 93,
            Y = 93,
            Color = 9990456,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping UniversalIcon2 = new PixelMapping
        {
            X = 69,
            Y = 79,
            Color = 11965265,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LeaderButton = new PixelMapping
        {
            X = 710,
            Y = 482,
            Color = 0,
            Type = MappingType.BUTTON
        };
        
        #endregion Public Fields
    }
}