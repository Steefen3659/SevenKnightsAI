using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SellItemsLobbyPM
    {

        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 88,
            Y = 28,
            Color = 2102790,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 241,
            Y = 448,
            Color = 10915424,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping BackButton = new PixelMapping
        {
            X = 19,
            Y = 29,
            Color = 12663051,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ItemTab = new PixelMapping
        {
            X = 512,
            Y = 83,
            Color = 1772806,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AccTab = new PixelMapping
        {
            X = 641,
            Y = 80,
            Color = 1904134,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping JewelTab = new PixelMapping
        {
            X = 816,
            Y = 79,
            Color = 1969926,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ItemTabSelected = new PixelMapping
        {
            X = 512,
            Y = 82,
            Color = 12087812,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AccTabSelected = new PixelMapping
        {
            X = 641,
            Y = 80,
            Color = 12416516,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping JewelTabSelected = new PixelMapping
        {
            X = 816,
            Y = 79,
            Color = 12548100,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RefreshButton = new PixelMapping
        {
            X = 412,
            Y = 403,
            Color = 9270606,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BulkButton = new PixelMapping
        {
            X = 295,
            Y = 442,
            Color = 0,
            Type = MappingType.BUTTON
        };
        //Button in Bulk Regist
        public static readonly PixelMapping Star1 = new PixelMapping
        {
            X = 309,
            Y = 410,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star2 = new PixelMapping
        {
            X = 302,
            Y = 368,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star3 = new PixelMapping
        {
            X = 306,
            Y = 328,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star4 = new PixelMapping
        {
            X = 306,
            Y = 289,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star5 = new PixelMapping
        {
            X = 311,
            Y = 247,
            Color = 0,
            Type = MappingType.BUTTON
        };
        // Star in First Box
        public static readonly PixelMapping Star1Exists = new PixelMapping
        {
            X = 79,
            Y = 167,
            Color = 15773732,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Star2Exists = new PixelMapping
        {
            X = 69,
            Y = 167,
            Color = 16777071,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Star3Exists = new PixelMapping
        {
            X = 93,
            Y = 166,
            Color = 14388505,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Star4Exists = new PixelMapping
        {
            X = 99,
            Y = 166,
            Color = 14388505,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Star5Exists = new PixelMapping
        {
            X = 103,
            Y = 166,
            Color = 13926421,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping SellButton = new PixelMapping
        {
            X = 215,
            Y = 488,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}
