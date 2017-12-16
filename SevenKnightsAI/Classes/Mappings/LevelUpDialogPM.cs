using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class LevelUpDialogPM
    {
        public static readonly PixelMapping CharacterEye = new PixelMapping
        {
            X = 127,
            Y = 118,
            Color = 11572101,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping InboxButton = new PixelMapping
        {
            X = 619,
            Y = 489,
            Color = 13410361,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 843,
            Y = 484,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 781,
            Y = 488,
            Color = 16766520,
            Type = MappingType.ANCHOR
        };
    }
}