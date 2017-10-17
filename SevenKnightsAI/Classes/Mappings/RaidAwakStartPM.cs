using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class RaidAwakStartPM
    {
        public static readonly PixelMapping ManageParty1Border = new PixelMapping
        {
            X = 36,
            Y = 509,
            Color = 10520923,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty2Border = new PixelMapping
        {
            X = 292,
            Y = 509,
            Color = 10520923,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping StartButton = new PixelMapping
        {
            X = 740,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AwakenDragonImg = new PixelMapping
        {
            X = 448,
            Y = 30,
            Color = 1451306,
            Type = MappingType.ANCHOR
        };

    }
}
