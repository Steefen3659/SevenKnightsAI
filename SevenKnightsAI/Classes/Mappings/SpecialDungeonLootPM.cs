using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class SpecialDungeonLootPM
    {
        public static readonly PixelMapping LobbyButton = new PixelMapping
        {
            X = 884,
            Y = 481,
            Color = 9663538,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping AgainButton = new PixelMapping
        {
            X = 885,
            Y = 385,
            Color = 15584617,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Item = new PixelMapping
        {
            X = 479,
            Y = 234,
            Color = 16776392,
            Type = MappingType.ANCHOR
        };
    }
}
