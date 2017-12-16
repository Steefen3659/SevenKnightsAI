using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class InboxPM
    {
        public static readonly PixelMapping AttachCollectButton = new PixelMapping
        {
            X = 855,
            Y = 226,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AttachCollectButtonBackground = new PixelMapping
        {
            X = 851,
            Y = 238,
            Color = 16770306,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CharacterBody = new PixelMapping
        {
            X = 193,
            Y = 311,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectAllButton = new PixelMapping
        {
            X = 845,
            Y = 506,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CollectAllButtonBackground = new PixelMapping
        {
            X = 847,
            Y = 517,
            Color = 16769794,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CurrencyTab = new PixelMapping //currency tab
        {
            X = 620,
            Y = 124,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping CurrencyTabRedIcon = new PixelMapping //currency tab
        {
            X = 583,
            Y = 103,
            Color = 12920833,
            Type = MappingType.ANCHOR
        };

        public static readonly int GOLD_OFFSET_X = 276;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping HonorsTab = new PixelMapping
        {
            X = 359,
            Y = 129,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping HonorsTabRedIcon = new PixelMapping
        {
            X = 323,
            Y = 102,
            Color = 12919815,
            Type = MappingType.ANCHOR
        };

        public static readonly int HONOR_OFFSET_X = 279;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping KeysTab = new PixelMapping //material tab
        {
            X = 496,
            Y = 131,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping KeysTabRedIcon = new PixelMapping //material tab
        {
            X = 452,
            Y = 108,
            Color = 12920833,
            Type = MappingType.ANCHOR
        };

        public static readonly int KEY_OFFSET_X = 274;

        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping MailButton = new PixelMapping
        {
            X = 60,
            Y = 490,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping MailIcon = new PixelMapping
        {
            X = 73,
            Y = 494,
            Color = 15394275,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MaterialTab = new PixelMapping
        {
            X = 740,
            Y = 122,
            Color = 0,
            Type = MappingType.BUTTON
        };
        
        public static readonly PixelMapping MaterialTabRedIcon = new PixelMapping
        {
            X = 705,
            Y = 110,
            Color = 12920833,
            Type = MappingType.ANCHOR
        };

        public static readonly int RUBY_OFFSET_X = 277;

        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping TicketTab = new PixelMapping
        {
            X = 895,
            Y = 135,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping TicketTabRedIcon = new PixelMapping
        {
            X = 839,
            Y = 102,
            Color = 12920833,
            Type = MappingType.ANCHOR
        };
    }
}