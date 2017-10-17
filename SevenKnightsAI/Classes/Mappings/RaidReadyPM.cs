using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidReadyPM
    {
        #region Public Fields

        public static readonly Rectangle EnteredCount = new Rectangle
        {
            X = 490,
            Y = 10,
            Height = 35,
            Width = 50
        };

        public static readonly PixelMapping DragonHead = new PixelMapping
        {
            X = 597,
            Y = 128,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 740,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBorderLeft = new PixelMapping
        {
            X = 555,
            Y = 475,
            Color = 16376483,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReadyButtonBorderRight = new PixelMapping
        {
            X = 924,
            Y = 475,
            Color = 16376483,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AwakenBlueIcon = new PixelMapping
        {
            X = 503,
            Y = 40,
            Color = 2844825,
            Type = MappingType.ANCHOR
        };

        // Awaken หน้ากดเริ่มตีเข้าสู Flight
        public static readonly PixelMapping AwakenDragonImg = new PixelMapping
        {
            X = 589,
            Y = 128,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AwakenedReadyButton = new PixelMapping
        {
            X = 775,
            Y = 497,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}