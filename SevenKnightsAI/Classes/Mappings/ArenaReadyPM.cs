using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaReadyPM
    {
        #region Public Fields

        public static readonly int HONOR_OFFSET_X = 228;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 738,
            Y = 503,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBackground = new PixelMapping
        {
            X = 906,
            Y = 519,
            Color = 4727055,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RecordBorder = new PixelMapping
        {
            X = 740,
            Y = 67,
            Color = 1708300,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardBackground = new PixelMapping
        {
            X = 642,
            Y = 407,
            Color = 8465931,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectBorder = new PixelMapping
        {
            X = 917,
            Y = 389,
            Color = 15718040,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RubyPlus = new PixelMapping
        {
            X = 694,
            Y = 28,
            Color = 12756580,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle ArenaScore = new Rectangle
        {
            X = 850,
            Y = 190,
            Width = 65,
            Height = 25
        };

        public static readonly int RUBY_OFFSET_X = 229;

        public static readonly int RUBY_OFFSET_Y = 0;

        #endregion Public Fields
    }
}