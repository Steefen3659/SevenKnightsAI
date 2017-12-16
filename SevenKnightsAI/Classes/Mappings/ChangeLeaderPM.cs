using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ChangeLeaderPM
    {
        #region Public Fields

        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 527,
            Y = 417,
            Color = 16049284,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping CancelButton = new PixelMapping
        {
            //X = 861,
            //Y = 456,
            //Color = 15058003,
            X = 323,
            Y = 411,
            Color = 15154182,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderTopLeft = new PixelMapping
        {
            X = 225,
            Y = 109,
            Color = 5260087,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderBottomRight = new PixelMapping
        {
            X = 738,
            Y = 432,
            Color = 3350289,
            Type = MappingType.ANCHOR
        };

        #endregion Public Fields
    }
}