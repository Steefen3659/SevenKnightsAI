using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class SpecialDungeonReady
    {
        public static readonly PixelMapping Cardlogo = new PixelMapping
        {
            X = 744,
            Y = 36,
            Color = 12036777,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping KeyPlus = new PixelMapping
        {
            X = 706,
            Y = 28,
            Color = 12690781,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BackButton = new PixelMapping
        {
            X = 58,
            Y = 25,
            Color = 13188876,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping KeyPlusButton = new PixelMapping
        {
            X = 705,
            Y = 28,
            Color = 12690781,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AllTab = new PixelMapping
        {
            X = 99,
            Y = 69,
            Color = 2692103,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping DailyTab = new PixelMapping
        {
            X = 218,
            Y = 67,
            Color = 2823432,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AdventTab = new PixelMapping
        {
            X = 335,
            Y = 67,
            Color = 2823432,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping EventTab = new PixelMapping
        {
            X = 455,
            Y = 67,
            Color = 2823432,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AwakenTab = new PixelMapping
        {
            X = 468,
            Y = 68,
            Color = 2757895,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Row1Select = new PixelMapping
        {
            X = 300,
            Y = 160,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Row2Select = new PixelMapping
        {
            X = 300,
            Y = 260,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Row3Select = new PixelMapping
        {
            X = 300,
            Y = 360,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Row4Select = new PixelMapping
        {
            X = 300,
            Y = 460,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SelectMode = new PixelMapping
        {
            X = 828,
            Y = 83,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ModeR1 = new PixelMapping
        {
            X = 840,
            Y = 125,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ModeR2 = new PixelMapping
        {
            X = 840,
            Y = 165,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ModeR3 = new PixelMapping
        {
            X = 840,
            Y = 200,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 761,
            Y = 498,
            Color = 5514254,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping CardlogoBG = new PixelMapping
        {
            X = 747,
            Y = 32,
            Color = 1840148,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReadyButtonBG = new PixelMapping
        {
            X = 628,
            Y = 496,
            Color = 1313284,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoRedcross = new PixelMapping
        {
            X = 316,
            Y = 394,
            Color = 14171656,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping MaxKeyPlusBG = new PixelMapping
        {
            X = 706,
            Y = 28,
            Color = 3748125,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MaxCardPlusBG = new PixelMapping
        {
            X = 832,
            Y = 28,
            Color = 3682075,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MaxYellowTik = new PixelMapping
        {
            X = 418,
            Y = 399,
            Color = 16758810,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ScrollAreaDown = new PixelMapping           // จุดล่าง
        {
            X = 290,
            Y = 477,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ScrollAreaUp = new PixelMapping             //จุดบน
        {
            X = 290,
            Y = 150,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly int KEY_OFFSET_X = 550;

        public static readonly int KEY_OFFSET_Y = 0;
    }
}
