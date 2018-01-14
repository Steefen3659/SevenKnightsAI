using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidLobbyPM
    {
        public static readonly PixelMapping SummonTab = new PixelMapping
        {
            X = 119,
            Y = 80,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping AttackedTab = new PixelMapping
        {
            X = 390,
            Y = 88,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping DefeatedTab = new PixelMapping
        {
            X = 804,
            Y = 75,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping DefeatedTabSelect = new PixelMapping
        {
            X = 804,
            Y = 75,
            Color = 13534724,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping EnterButton = new PixelMapping
        {
            X = 868,
            Y = 200,
            Color = 13873749,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GreenIconOnNewTab = new PixelMapping
        {
            X = 214,
            Y = 69,
            Color = 45085,
            Type = MappingType.ANCHOR
        };
        /* Attack Team Setting */
        public static readonly PixelMapping ManageParty1Border = new PixelMapping
        {
            X = 49,
            Y = 477,
            Color = 5258020,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty1Button = new PixelMapping
        {
            X = 108,
            Y = 483,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ManageParty2Border = new PixelMapping
        {
            X = 231,
            Y = 511,
            Color = 8872503,
            Type = MappingType.ANCHOR
        };
        /* End Team Attack Setting */
        public static readonly PixelMapping ManageParty2Button = new PixelMapping
        {
            X = 234,
            Y = 485,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping NewTab = new PixelMapping
        {
            X = 535,
            Y = 83,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedIconOnDefeatedTab = new PixelMapping
        {
            X = 717,
            Y = 58,
            Color = 12854533,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RefreshButton = new PixelMapping
        {
            X = 809,
            Y = 134,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AwakenedRaidEnter = new PixelMapping //Summon Button
        {
            X = 708,
            Y = 421,
            Color = 3546898,
            Type = MappingType.BOTH
        };


        public static readonly PixelMapping AwakenedRaidTab = new PixelMapping
        {
            X = 154,
            Y = 86,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AwakenedShard = new PixelMapping
        {
            X = 480,
            Y = 319,
            Color = 16643809,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle RaidLvl = new Rectangle
        {
            X = 191,
            Y = 175,
            Width = 70,
            Height = 25
        };

        public static readonly Rectangle RaidPoint = new Rectangle
        {
            X = 360,
            Y = 199,
            Width = 100,
            Height = 20
        };
        // จุดตรวจสอบจากบนลงล่าง ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // ตรวจชื่อ   (เช็คเสร็จแล้ว)
        public static readonly Rectangle RaidNameUpToDownL0 = new Rectangle
        {
            X = 297,
            Y = 207,
            Height = 22,
            Width = 145
        };

        public static readonly Rectangle RaidNameUpToDownL1 = new Rectangle
        {
            X = 297,
            Y = 282,
            Height = 22,
            Width = 145
        };

        public static readonly Rectangle RaidNameUpToDownL2 = new Rectangle
        {
            X = 297,
            Y = 356,
            Height = 22,
            Width = 145
        };

        public static readonly Rectangle RaidNameUpToDownL3 = new Rectangle
        {
            X = 297,
            Y = 429,
            Height = 22,
            Width = 145
        };

        // ปุ่มหัวมังกร (เช็คเสร็จแล้ว)
        public static readonly PixelMapping RaidUpToDownBtn0 = new PixelMapping
        {
            X = 868,
            Y = 202,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidUpToDownBtn1 = new PixelMapping
        {
            X = 868,
            Y = 276,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidUpToDownBtn2 = new PixelMapping
        {
            X = 868,
            Y = 350,
            Color = 13939542,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidUpToDownBtn3 = new PixelMapping
        {
            X = 868,
            Y = 424,
            Color = 13939542,
            Type = MappingType.BOTH
        };


        // จุดตรวจสอบ Level จากบนลงล่าง
        public static readonly Rectangle RaidLvlUpToDownL0 = new Rectangle
        {
            X = 191,
            Y = 175,
            Width = 70,
            Height = 25
        };

        public static readonly Rectangle RaidLvlUpToDownL1 = new Rectangle
        {
            X = 191,
            Y = 248,
            Width = 70,
            Height = 25
        };

        public static readonly Rectangle RaidLvlUpToDownL2 = new Rectangle
        {
            X = 191,
            Y = 322,
            Width = 70,
            Height = 25
        };

        public static readonly Rectangle RaidLvlUpToDownL3 = new Rectangle
        {
            X = 191,
            Y = 396,
            Width = 70,
            Height = 25
        };

        // จุดที่ใช้ตรวจสอบ เลือดบน ลงล่าง
        public static readonly Rectangle RaidHPUpToDownL0F = new Rectangle
        {
            X = 590,
            Y = 209,
            Width = 80,
            Height = 25
        };

        public static readonly Rectangle RaidHPUpToDownL1F = new Rectangle
        {
            X = 588,
            Y = 283,
            Width = 81,
            Height = 27
        };

        public static readonly Rectangle RaidHPUpToDownL2F = new Rectangle
        {
            X = 589,
            Y = 358,
            Width = 80,
            Height = 26
        };

        public static readonly Rectangle RaidHPUpToDownL3F = new Rectangle
        {
            X = 590,
            Y = 432, 
            Width = 78,
            Height = 26
        };

        public static readonly Rectangle RaidHPUpToDownL0B = new Rectangle
        {
            X = 679,
            Y = 211,
            Width = 85,
            Height = 25
        };

        public static readonly Rectangle RaidHPUpToDownL1B = new Rectangle
        {
            X = 678,
            Y = 285,
            Width = 85,
            Height = 25
        };

        public static readonly Rectangle RaidHPUpToDownL2B = new Rectangle
        {
            X = 678,
            Y = 358,
            Width = 85,
            Height = 25 
        };

        public static readonly Rectangle RaidHPUpToDownL3B = new Rectangle
        {
            X = 677,
            Y = 432,
            Width = 85,
            Height = 25
        };


        // *************************************** ล่าง ขึ้นบน*******************************************************
        // จุดที่ใช้ตรวจสอบชื่อ (ตรวจเสร็จแล้ว)
        public static readonly Rectangle RaidNameDownToUpL0 = new Rectangle
        {
            X = 295,
            Y = 208,
            Width = 200,
            Height = 30
        };

        public static readonly Rectangle RaidNameDownToUpL1 = new Rectangle
        {
            X = 295,
            Y = 281,
            Width = 200,
            Height = 30
        };

        public static readonly Rectangle RaidNameDownToUpL2 = new Rectangle
        {
            X = 295,
            Y = 356,
            Width = 200,
            Height = 30
        };

        public static readonly Rectangle RaidNameDownToUpL3 = new Rectangle
        {
            X = 295,
            Y = 428,
            Width = 200,
            Height = 30
        };

        // จุดที่ใช้ตรวจสอบปุ่ม(หัวมังกร)
        // (ตรวจเสร็จแล้ว)
        public static readonly PixelMapping RaidDownToUpBtn0 = new PixelMapping
        {
            X = 868,
            Y = 202,
            Color = 13807956,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidDownToUpBtn1 = new PixelMapping
        {
            X = 868,
            Y = 276,
            Color = 13807956,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidDownToUpBtn2 = new PixelMapping
        {
            X = 868,
            Y = 350,
            //Color = 13807956,  ต่างจาก 2 อันแรก
            Color = 13873749,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidDownToUpBtn3 = new PixelMapping
        {
            X = 868,
            Y = 424,
            //Color = 13807956,  ต่างจาก 2 อันแรก
            Color = 13873749,
            Type = MappingType.BOTH
        };

        // จุดตรวจสอบ Level จากล่าง ขึ้นบน
        public static readonly Rectangle RaidLvlDownToUpL0 = new Rectangle
        {
            X = 191,
            Y = 175,
            Width = 70,
            Height = 25
        };

        public static readonly Rectangle RaidLvlDownToUpL1 = new Rectangle
        {
            X = 191,
            Y = 250,
            Width = 70,
            Height = 25
        };

        public static readonly Rectangle RaidLvlDownToUpL2 = new Rectangle
        {

            X = 191,
            Y = 324,
            Width = 70,
            Height = 25
        };

        public static readonly Rectangle RaidLvlDownToUpL3 = new Rectangle
        {
            X = 191,
            Y = 398,
            Width = 70,
            Height = 25
        };

        // จุดที่ใช้ตรวจสอบ HP ล่าง ขึ้นบน
        public static readonly Rectangle RaidHPDownToUpL0F = new Rectangle
        {
            X = 590,
            Y = 209,
            Width = 80,
            Height = 25
        };

        public static readonly Rectangle RaidHPDownToUpL1F = new Rectangle
        {
            X = 588,
            Y = 283,
            Width = 81,
            Height = 27
        };

        public static readonly Rectangle RaidHPDownToUpL2F = new Rectangle
        {
            X = 589,
            Y = 358,
            Width = 80,
            Height = 26
        };

        public static readonly Rectangle RaidHPDownToUpL3F = new Rectangle
        {
            X = 590,
            Y = 432,
            Width = 78,
            Height = 26
        };

        public static readonly Rectangle RaidHPDownToUpL0B = new Rectangle
        {
            X = 679,
            Y = 211,
            Width = 85,
            Height = 25
        };

        public static readonly Rectangle RaidHPDownToUpL1B = new Rectangle
        {
            X = 678,
            Y = 285,
            Width = 85,
            Height = 25
        };

        public static readonly Rectangle RaidHPDownToUpL2B = new Rectangle
        {
            X = 678,
            Y = 358,
            Width = 85,
            Height = 25 
        };

        public static readonly Rectangle RaidHPDownToUpL3B = new Rectangle
        {
            X = 677,
            Y = 432,
            Width = 85,
            Height = 25
        };

        //--------------------------------------- จุดสำหรับ Scoll หน้าจอ-----------------
        public static readonly PixelMapping ScrollAreaDown = new PixelMapping       
        {
            X = 450,                        
            Y = 430,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ScrollAreaUp = new PixelMapping
        {
            X = 450,
            Y = 200,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}