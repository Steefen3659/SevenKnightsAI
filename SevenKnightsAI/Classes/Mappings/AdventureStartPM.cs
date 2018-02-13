using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureStartPM
    {
        #region Public Fields

        public static readonly int GOLD_OFFSET_X = 364;
        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly int KEY_OFFSET_X = 363;
        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping KeyPlusButton = new PixelMapping
        {
            X = 492,
            Y = 28,
            Color = 12690781,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point1 = new PixelMapping //Question Mark Auto Repeat
        {
            X = 610,
            Y = 415,
            Color = 16777075,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping //Question Mark Boost Mode
        {
            X = 816,
            Y = 414,
            Color = 16777065,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AutoRepeatOn = new PixelMapping
        {
            X = 456,
            Y = 431,
            Color = 16706638,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AutoRepeatOff = new PixelMapping
        {
            X = 453,
            Y = 430,
            Color = 2824978,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle R_MapNumber = new Rectangle
        {
            X = 250,
            Y = 12,
            Width = 100,
            Height = 33
        };

        public static readonly PixelMapping UseFriendOn = new PixelMapping
        {
            X = 837,
            Y = 171,
            Color = 16630547,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping UseFriendOff = new PixelMapping
        {
            X = 837,
            Y = 171,
            Color = 6113333,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BootmodeOn = new PixelMapping
        {
            X = 657,
            Y = 438,
            Color = 16776316,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BootmodeOff = new PixelMapping
        {
            X = 657,
            Y = 438,
            Color = 3218706,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping UsedBootModeButton = new PixelMapping
        {
            X = 660,
            Y = 430,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AutoSettingsBTN = new PixelMapping
        {
            X = 366,
            Y = 393,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}