﻿using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureFightPM
    {
        #region Public Fields

        public static readonly PixelMapping AtTurn1Of1 = new PixelMapping
        {
            X = 560,
            Y = 27,
            Color = 5056798,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn1Of2 = new PixelMapping
        {
            X = 475,
            Y = 27,
            Color = 4662552,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn1Of3_1 = new PixelMapping
        {
            X = 443,
            Y = 29,
            Color = 2103881,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn1Of3_2 = new PixelMapping
        {
            X = 457,
            Y = 23,
            Color = 16117499,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn2Of2 = new PixelMapping
        {
            X = 563,
            Y = 17,
            Color = 16711166,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn2Of3_1 = new PixelMapping
        {
            X = 498,
            Y = 29,
            Color = 2300738,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn2Of3_2 = new PixelMapping
        {
            X = 512,
            Y = 23,
            Color = 16315132,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn3Of3_1 = new PixelMapping
        {
            X = 552,
            Y = 29,
            Color = 2104148,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn3Of3_2 = new PixelMapping
        {
            X = 567,
            Y = 23,
            Color = 16249339,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 825,
            Y = 25,
            Color = 3552323,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn1Of1 = new PixelMapping
        {
            X = 563,
            Y = 21,
            Color = 3875857,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn1Of2 = new PixelMapping
        {
            X = 480,
            Y = 21,
            Color = 4402197,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn1Of3 = new PixelMapping
        {
            X = 450,
            Y = 21,
            Color = 4204819,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn2Of2 = new PixelMapping
        {
            X = 566,
            Y = 21,
            Color = 15855080,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn2Of3 = new PixelMapping
        {
            X = 508,
            Y = 19,
            Color = 16382456,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn3Of3 = new PixelMapping
        {
            X = 563,
            Y = 21,
            Color = 4205337,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_AweakButton = new PixelMapping
        {
            X = 804,
            Y = 80,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_AweakOff = new PixelMapping
        {
            X = 802,
            Y = 78,
            Color = 5454884,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_AweakOn = new PixelMapping
        {
            X = 802,
            Y = 78,
            Color = 6830618,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle LootHero = new Rectangle
        {
            X = 837,
            Y = 7,
            Width = 44,
            Height = 39
        };
        public static readonly Rectangle LootItem = new Rectangle
        {
            X = 916,
            Y = 8,
            Width = 44,
            Height = 39
        };
        public static readonly Rectangle LootGold = new Rectangle
        {
            X = 673,
            Y = 4,
            Width = 95,
            Height = 44
        };

        #endregion Public Fields
    }
}