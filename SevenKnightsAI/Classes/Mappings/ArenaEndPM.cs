using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaEndPM
    {
        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 900,
            Y = 366,
            Color = 5448719,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GetStrongerButton = new PixelMapping
        {
            X = 900,
            Y = 60,
            Color = 15522425,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping LobbyButton = new PixelMapping
        {
            X = 904,
            Y = 478,
            Color = 16177007,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Opponentbutton = new PixelMapping
        {
            X = 900,
            Y = 262,
            Color = 5317647,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButton = new PixelMapping
        {
            X = 900,
            Y = 164,
            Color = 5711118,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButtonBG = new PixelMapping
        {
            X = 902,
            Y = 146,
            Color = 4668960,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LobbyButtonBG = new PixelMapping
        {
            X = 904,
            Y = 474,
            Color = 4734753,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RankUpTik = new PixelMapping
        {
            X = 439,
            Y = 398,
            Color = 16758553,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle ArenaScore = new Rectangle
        {
            X = 206,
            Y = 465,
            Width = 158,
            Height = 55
        };
    }
}