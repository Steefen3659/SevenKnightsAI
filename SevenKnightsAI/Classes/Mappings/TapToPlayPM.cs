using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TapToPlayPM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping 
        {
            X = 148,
            Y = 52,
            Color = 15014422,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping
        {
            X = 477,
            Y = 486,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}