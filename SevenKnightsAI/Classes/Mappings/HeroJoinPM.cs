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

        #endregion Public Fields
    }
}