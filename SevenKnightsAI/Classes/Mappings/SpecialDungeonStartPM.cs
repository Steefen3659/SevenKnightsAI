using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class SpecialDungeonStartPM
    {
        public static readonly PixelMapping Cardlogo = new PixelMapping
        {
            X = 744,
            Y = 36,
            Color = 12036777,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Masterry = new PixelMapping
        {
            X = 375,
            Y = 175,
            Color = 8078362,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping KeyPlus = new PixelMapping
        {
            X = 556,
            Y = 29,
            Color = 11573327,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping CardPlus = new PixelMapping
        {
            X = 696,
            Y = 27,
            Color = 13808234,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping SpecialBG = new PixelMapping
        {
            X = 243,
            Y = 67,
            Color = 13994756,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping StartButton = new PixelMapping
        {
            X = 664,
            Y = 494,
            Color = 5120782,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping KeyPlusBG = new PixelMapping
        {
            X = 705,
            Y = 28,
            Color = 3748123,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CardEnterButton = new PixelMapping
        {
            X = 392,
            Y = 389,
            Color = 12757364,
            Type = MappingType.BOTH
        };
    }
}
