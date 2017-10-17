using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureLootGoldPM
    {
        public static readonly PixelMapping GoldLootIcon = new PixelMapping
        {
            X = 474,
            Y = 210,
            Color = 9198114,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle GoldAmount = new Rectangle
        {
            X = 443,
            Y = 311,
            Width = 82,
            Height = 30
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 886,
            Y = 368,
            Color = 9332787,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AgainButton = new PixelMapping
        {
            X = 884,
            Y = 150,
            Color = 5383183,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping NextZoneButton = new PixelMapping
        {
            X = 884,
            Y = 250,
            Color = 4924176,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButton = new PixelMapping
        {
            X = 786,
            Y = 480,
            Color = 5317647,
            Type = MappingType.BOTH
        };
    }
}