using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKnightsAI.Classes.Mappings
{
    class ExplorationCompletePopupPM
    {
        public static readonly PixelMapping PopupPoint1 = new PixelMapping
        {
            X = 317,
            Y = 100,
            Color = 15838739,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping PopupPoint2 = new PixelMapping
        {
            X = 632,
            Y = 117,
            Color = 16101395,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 420,
            Y = 446,
            Color = 16758039,
            Type = MappingType.BOTH
        };
    }
}
