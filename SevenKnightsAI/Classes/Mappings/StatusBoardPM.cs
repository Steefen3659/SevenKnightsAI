using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class StatusBoardPM
    {
        public static readonly PixelMapping LeftTabCon = new PixelMapping
        {
            X = 110,
            Y = 32,
            Color = 5652766,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping RightTabCol = new PixelMapping
        {
            X = 716,
            Y = 16,
            Color = 3351053,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping ContentsTab = new PixelMapping
        {
            X = 320,
            Y = 112,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping ContentsTabSelect = new PixelMapping
        {
            X = 289,
            Y = 105,
            Color = 12679940,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping HottimeTabSelect = new PixelMapping
        {
            X = 475,
            Y = 109,
            Color = 12087812,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping HottimeTab = new PixelMapping
        {
            X = 476,
            Y = 112,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping HeroRateTab = new PixelMapping
        {
            X = 740,
            Y = 112,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping HottimeRedIcon = new PixelMapping
        {
            X = 361,
            Y = 87,
            Color = 12855297,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ActiveButtonColor = new PixelMapping
        {
            X = 760,
            Y = 495,
            Color = 4072212,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ActiveBG = new PixelMapping
        {
            X = 766,
            Y = 523,
            Color = 2428163,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping StatusBar = new PixelMapping
        {
            X = 198,
            Y = 516,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ActiveHottimeButton = new PixelMapping
        {
            X = 760,
            Y = 510,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ConfirmOKtick = new PixelMapping
        {
            X = 530,
            Y = 398,
            Color = 16759838,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoRedCloss = new PixelMapping
        {
            X = 315,
            Y = 394,
            Color = 14171656,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HottimeBG = new PixelMapping
        {
            X = 315,
            Y = 394,
            Color = 14171656,
        };

        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 540,
            Y = 400,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ClosButton = new PixelMapping
        {
            X = 860,
            Y = 48,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}
