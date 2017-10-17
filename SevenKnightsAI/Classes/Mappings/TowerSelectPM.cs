using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TowerSelectPM
    {
        public static readonly PixelMapping GoldChamberButton = new PixelMapping
        {
            X = 739,
            Y = 368,
            Color = 16578507,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping PreviewBorderLeft = new PixelMapping
        {
            X = 322,
            Y = 294,
            Color = 6903862,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PreviewBorderRight = new PixelMapping
        {
            X = 922,
            Y = 294,
            Color = 1839114,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 750,
            Y = 380,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyDisabled = new PixelMapping
        {
            X = 696,
            Y = 376,
            Color = 8141105,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GoldMindCheck = new PixelMapping
        {
            X = 800,
            Y = 432,
            Color = 2233357,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectButton = new PixelMapping
        {
            X = 755,
            Y = 551,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly Rectangle GoldMineCalc = new Rectangle
        {
            X = 794,
            Y = 465,
            Width = 101,
            Height = 31
        };
        public static readonly Rectangle GoldMineGoldAmount = new Rectangle
        {
            X = 792,
            Y = 465,
            Width = 61,
            Height = 32
        };

        public static readonly Rectangle GoldMineAvailable = new Rectangle
        {
            X = 869,
            Y = 463,
            Width = 25,
            Height = 31
        };
    }
}