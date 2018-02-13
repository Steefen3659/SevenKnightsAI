using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class ExplorationSendAgainPM
    {
        public static readonly PixelMapping PopupPoint1 = new PixelMapping
        {
            X = 140,
            Y = 157,
            Color = 2628371,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping PopupPoint2 = new PixelMapping
        {
            X = 446,
            Y = 83,
            Color = 16758803,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 539,
            Y = 474,
            Color = 16761637,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 539,
            Y = 474,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedCross = new PixelMapping
        {
            X = 251,
            Y = 470,
            Color = 14564616,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ClosButton = new PixelMapping
        {
            X = 251,
            Y = 470,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}
