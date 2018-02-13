using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class ExplorationPopupPM
    {
        public static readonly PixelMapping PopupPoint1 = new PixelMapping
        {
            X = 749,
            Y = 420,
            Color = 1838855,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping PopupPoint2 = new PixelMapping
        {
            X = 931,
            Y = 231,
            Color = 3484708,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping Reward1 = new PixelMapping
        {
            X = 684,
            Y = 186,
            Color = 13930755,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward2 = new PixelMapping
        {
            X = 686,
            Y = 242,
            Color = 14062339,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward3 = new PixelMapping
        {
            X = 691,
            Y = 295,
            Color = 13799171,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward4 = new PixelMapping
        {
            X = 691,
            Y = 350,
            Color = 13799171,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Reward1Collected = new PixelMapping
        {
            X = 689,
            Y = 184,
            Color = 4073985,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward2Collected = new PixelMapping
        {
            X = 690,
            Y = 240,
            Color = 4073985,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward3Collected = new PixelMapping
        {
            X = 691,
            Y = 297,
            Color = 4073985,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward4Collected = new PixelMapping
        {
            X = 686,
            Y = 353,
            Color = 4073985,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ClosButton = new PixelMapping
        {
            X = 733,
            Y = 133,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}
