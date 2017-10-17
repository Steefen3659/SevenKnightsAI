using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroRemovePM
    {
        public static readonly PixelMapping PositionButton = new PixelMapping
        {
            X = 481,
            Y = 483,
            //Color = 5120527,
            Color = 12420649,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveAllButton = new PixelMapping
        {
            X = 596,
            Y = 484,
            //Color = 14728782,
            Color = 8147744,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveButton = new PixelMapping
        {
            X = 848,
            Y = 485,
            //Color = 11108917,
            Color = 8476706,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveButtonIcon = new PixelMapping
        {
            X = 861,
            Y = 458,
            //Color = 4202769,
            Color = 4466197,
            Type = MappingType.ANCHOR
        };
    }
}