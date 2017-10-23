using System;

namespace Skill_Calculator
{
    public class Engineer
    {
        public int skillpointsleft, level, fame, statpointsleft;
        public double strength = 15, dexterity = 5, focus = 5, vitality = 15;
        public string strength_text, dexterity_text, focus_text, vitality_text;

        public string[] fame_ranks = { "2000", "3000", "4000", "5000", "7000", "9000", "12000", "14000", "16000", "18000", "19000", "22000", "23000", "26000", "27000", "29000", "31000", "34000", "35000", "37000", "40000", "41000", "44000", "46000", "48000", "50000", "52000", "55000", "56000", "59000", "62000", "63000", "9005000", "full" };

        double[] armor_player_bylevel_forset = { 0, 8, 10, 12, 14, 17, 20, 22, 25, 28, 31, 34, 37, 40, 43, 46, 50, 53, 56, 60, 63, 67, 70, 74, 77, 81, 85, 88, 92, 96, 100, 103, 107, 111, 115, 119, 123, 127, 131, 135, 139, 143, 147, 151, 155, 159, 163, 167, 171, 176, 180, 184, 188, 192, 197, 201, 205, 209, 214, 218, 222, 226, 231, 235, 239, 244, 248, 253, 257, 261, 266, 270, 274, 279, 283, 288, 292, 297, 301, 305, 310, 314, 319, 323, 328, 332, 337, 341, 346, 350, 355, 359, 364, 368, 373, 377, 382, 386, 391, 395, 400, 405, 409, 414, 418, 423 };
        double[] damage_minion_bylevel = { 0, 24, 30, 37, 44, 51, 58, 66, 74, 83, 92, 101, 110, 120, 131, 142, 153, 164, 177, 189, 202, 215, 229, 243, 258, 273, 288, 304, 321, 338, 355, 373, 392, 411, 430, 450, 471, 492, 514, 536, 558, 582, 605, 630, 655, 680, 706, 733, 760, 788, 817, 846, 876, 906, 937, 968, 1001, 1034, 1067, 1101, 1136, 1172, 1208, 1245, 1283, 1321, 1360, 1400, 1440, 1481, 1523, 1566, 1609, 1653, 1698, 1744, 1790, 1837, 1885, 1934, 1984, 2034, 2085, 2137, 2190, 2243, 2297, 2353, 2409, 2466, 2523, 2582, 2641, 2701, 2763, 2825, 2888, 2951, 3016, 3082, 3148, 3216, 3284, 3353, 3423, 3495 };
        double[] damage_monster = { 0, 10, 14, 19, 23.9, 29, 34.5, 40.200001, 46.299999, 52.599998, 59.299999, 66.400002, 73.800003, 81.5, 89.599998, 98.099998, 106.900002, 116.099998, 125.699997, 135.699997, 146.100006, 157, 168.199997, 179.899994, 192, 204.600006, 217.699997, 231.199997, 245.199997, 259.600006, 274.600006, 290.100006, 306.100006, 322.600006, 339.600006, 357.200012, 375.299988, 394, 413.299988, 433.100006, 453.600006, 474.600006, 496.200012, 518.5, 541.400024, 564.900024, 589.099976, 613.900024, 639.400024, 665.599976, 692.5, 720, 748.299988, 777.299988, 807, 837.5, 868.700012, 900.700012, 933.5, 967, 1001.400024, 1036.5, 1072.5, 1109.300049, 1147, 1185.5, 1224.800049, 1265.099976, 1306.199951, 1348.199951, 1391.099976, 1435, 1479.800049, 1525.5, 1572.199951, 1619.900024, 1668.5, 1718.099976, 1768.800049, 1820.400024, 1873.099976, 1926.900024, 1981.699951, 2037.5, 2094.5, 2152.5, 2211.600098, 2271.899902, 2333.300049, 2395.800049, 2459.5, 2524.300049, 2590.399902, 2657.600098, 2726.100098, 2795.800049, 2866.699951, 2938.800049, 3012.300049, 3087, 3163, 3240.300049, 3318.899902, 3398.800049, 3480.100098, 3562.800049 };
        double[] armor_monster_bylevel = { 0, 4, 7, 8, 11, 14, 18, 21, 25, 28, 32, 37, 41, 46, 50, 55, 61, 66, 72, 77, 83, 90, 96, 102, 109, 116, 123, 131, 138, 146, 154, 162, 170, 179, 188, 196, 206, 215, 224, 234, 244, 254, 264, 275, 286, 296, 307, 319, 330, 342, 354, 366, 378, 390, 403, 416, 429, 442, 456, 469, 483, 497, 511, 526, 540, 555, 570, 585, 601, 616, 632, 648, 664, 680, 697, 714, 731, 748, 765, 783, 800, 818, 836, 855, 873, 892, 911, 930, 949, 969, 988, 1008, 1028, 1049, 1069, 1090, 1111, 1132, 1153, 1175, 1196, 1218, 1240, 1262, 1285, 1307 };
        double[] health_player_generic = { 0, 200, 240, 280, 320, 360, 400, 440, 480, 520, 560, 600, 640, 680, 720, 760, 800, 840, 880, 920, 960, 1000, 1040, 1080, 1120, 1160, 1200, 1240, 1280, 1320, 1360, 1400, 1440, 1480, 1520, 1560, 1600, 1640, 1680, 1720, 1760, 1800, 1840, 1880, 1920, 1960, 2000, 2040, 2080, 2120, 2160, 2200, 2240, 2280, 2320, 2360, 2400, 2440, 2480, 2520, 2560, 2600, 2640, 2680, 2720, 2760, 2800, 2840, 2880, 2920, 2960, 3000, 3040, 3080, 3120, 3160, 3200, 3240, 3280, 3320, 3360, 3400, 3440, 3480, 3520, 3560, 3600, 3640, 3680, 3720, 3760, 3800, 3840, 3880, 3920, 3960, 4000, 4040, 4080, 4120, 4160, 4200, 4240, 4280, 4320, 4360 };
        double[] mana_player_generic = { 0, 47.5, 48.5, 49.5, 50.5, 51.5, 52.5, 53.5, 54.5, 55.5, 56.5, 57.5, 58.5, 59.5, 60.5, 61.5, 62.5, 63.5, 64.5, 65.5, 66.5, 67.5, 68.5, 69.5, 70.5, 71.5, 72.5, 73.5, 74.5, 75.5, 76.5, 77.5, 78.5, 79.5, 80.5, 81.5, 82.5, 83.5, 84.5, 85.5, 86.5, 87.5, 88.5, 89.5, 90.5, 91.5, 92.5, 93.5, 94.5, 95.5, 96.5, 97.5, 98.5, 99.5, 100.5, 101.5, 102.5, 103.5, 104.5, 105.5, 106.5, 107.5, 108.5, 109.5, 110.5, 111.5, 112.5, 113.5, 114.5, 115.5, 116.5, 117.5, 118.5, 119.5, 120.5, 121.5, 122.5, 123.5, 124.5, 125.5, 126.5, 127.5, 128.5, 129.5, 130.5, 131.5, 132.5, 133.5, 134.5, 135.5, 136.5, 137.5, 138.5, 139.5, 140.5, 141.5, 142.5, 143.5, 144.5, 145.5, 146.5 }; double[] health_monster_bylevel = { 0, 11, 16, 21, 30, 37, 44, 53, 61, 71, 82, 93, 105, 118, 133, 148, 164, 182, 200, 220, 240, 262, 286, 310, 336, 363, 392, 422, 453, 486, 520, 556, 593, 633, 673, 716, 760, 806, 853, 902, 954, 1007, 1062, 1119, 1178, 1239, 1302, 1367, 1434, 1503, 1574, 1648, 1724, 1802, 1882, 1965, 2050, 2138, 2228, 2320, 2415, 2512, 2612, 2715, 2820, 2928, 3039, 3152, 3268, 3387, 3509, 3633, 3761, 3891, 4024, 4161, 4300, 4443, 4588, 4737, 4889, 5044, 5202, 5363, 5528, 5696, 5868, 6043, 6221, 6403, 6588, 6776, 6969, 7165, 7364, 7567, 7774, 7985, 8199, 8417, 8639, 8865, 9095, 9328, 9566, 9807 };

        public int flame_hammer_lvl = 0;
        public string flame_hammer_text;
        double[] flame_hammer_a = { 0, 68, 72, 76, 80, 84, 88, 92, 96, 100, 104, 108, 112, 116, 120, 124 };
        double[] flame_hammer_b = { 0, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85 };
        double[] flame_hammer_mana = { 0, 14, 15, 16, 17, 18, 20, 23, 26, 28, 32, 36, 40, 45, 50, 55 };
        public string[] flame_hammer_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int seismic_slam_lvl = 0;
        public string seismic_slam_text;
        double[] seismic_slam_a = { 0, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92 };
        double[] seismic_slam_b = { 0, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
        double[] seismic_slam_c = { 0, 16, 17.2, 18.4, 19.6, 20.8, 22, 23.2, 24.4, 25.6, 26.8, 28, 29.2, 30.4, 32.6, 32.8 };
        double[] seismic_slam_mana = { 0, 12, 12, 12, 13, 13, 15, 16, 17, 20, 22, 25, 27, 30, 33, 36 };
        public string[] seismic_slam_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int ember_hammer_lvl = 0;
        public string ember_hammer_text;
        double[] ember_hammer_a = { 0, 82, 85, 88, 91, 94, 97, 100, 103, 106, 109, 112, 115, 118, 121, 124 };
        double[] ember_hammer_mana = { 0, 16, 16, 17, 17, 18, 19, 20, 22, 24, 27, 30, 33, 36, 39, 43 };
        public string[] ember_hammer_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int onslaught_lvl = 0;
        public string onslaught_text;
        double[] onslaught_a = { 0, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93, 96, 99, 102 };
        double[] onslaught_b = { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        double[] onslaught_c = { 0, 1, 1, 1, 1, 0.8, 0.8, 0.8, 0.8, 0.8, 0.6, 0.6, 0.6, 0.6, 0.6, 0.4 };
        double[] onslaught_mana = { 0, 27, 27, 28, 28, 23, 24, 26, 28, 30, 24, 27, 29, 32, 35, 25 };
        public string[] onslaught_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int ember_reach_lvl = 0;
        public string ember_reach_text;
        double[] ember_reach_a = { 0, 13, 13.5, 14, 14.5, 15, 15.5, 16, 16.5, 17, 17.5, 18, 18.5, 19, 19.5, 20 };
        double[] ember_reach_b = { 0, 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56 };
        double[] ember_reach_c = { 0, 2, 2, 2, 2, 4, 4, 4, 4, 4, 6, 6, 6, 6, 6, 8 };
        double[] ember_reach_d = { 0, 1, 1, 1, 1, 0.8, 0.8, 0.8, 0.8, 0.8, 0.6, 0.6, 0.6, 0.6, 0.6, 0.4 };
        double[] ember_reach_mana = { 0, 14, 14, 15, 15, 12, 12, 12, 13, 14, 12, 13, 14, 15, 16, 12 };
        public string[] ember_reach_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int storm_burst_lvl = 0;
        public string storm_burst_text;
        double[] storm_burst_a = { 0, 60, 64, 68, 72, 76, 80, 84, 88, 92, 96, 100, 104, 108, 112, 116 };
        double[] storm_burst_b = { 0, 55, 56, 57, 58, 60, 62, 65, 68, 72, 79, 86, 94, 101, 109, 117 };
        double[] storm_burst_c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 20, 20, 20, 20, 20 };
        double[] storm_burst_d = { 0, 36, 40, 44, 48, 52, 56, 56, 60, 64, 68, 68, 72, 76, 80, 84 };
        double[] storm_burst_mana = { 0, 25, 25, 26, 26, 27, 27, 29, 30, 32, 34, 37, 40, 43, 45, 48 };
        public string[] storm_burst_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int emberquake_lvl = 0;
        public string emberquake_text;
        double[] emberquake_a = { 0, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30 };
        double[] emberquake_b = { 0, 1, 1, 1, 1, 1.2, 1.2, 1.2, 1.2, 1.2, 1.4, 1.4, 1.4, 1.4, 1.4, 1.6 };
        double[] emberquake_c = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 43, 44, 46, 48 };
        double[] emberquake_d = { 0, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63 };
        double[] emberquake_mana = { 0, 42, 43, 43, 44, 46, 48, 49, 51, 54, 57, 59, 63, 66, 71, 74 };
        public string[] emberquake_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int heavy_lifting_lvl = 0;
        public string heavy_lifting_text;
        double[] heavy_lifting_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
        public string[] heavy_lifting_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int supercharge_lvl = 0;
        public string supercharge_text;
        double[] supercharge_a = { 0, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95 };
        double[] supercharge_b = { 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45 };
        double[] supercharge_c = { 0, 2.5, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5 };
        public string[] supercharge_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int coup_de_grace_lvl = 0;
        public string coup_de_grace_text;
        double[] coup_de_grace_a = { 0, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10 };
        double[] coup_de_grace_b = { 0, 45, 53, 60, 68, 75, 83, 90, 98, 105, 113, 120, 128, 135, 143, 150 };
        public string[] coup_de_grace_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int healing_bot_lvl = 0;
        public string healing_bot_text;
        double[] healing_bot_a = { 0, 12, 11.5, 11, 10.5, 10, 9.5, 9, 8.5, 8, 7.5, 7, 6.5, 6, 5.5, 5 };
        double[] healing_bot_b = { 0, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12, 12.5, 13, 13.5, 14, 14.5, 15 };
        double[] healing_bot_c = { 0, 400, 425, 450, 475, 500, 525, 550, 575, 600, 625, 650, 675, 700, 725, 750 };
        double[] healing_bot_d = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 8, 8, 8, 8, 16 };
        double[] healing_bot_e = { 0, 400, 425, 450, 475, 500, 525, 550, 575, 600, 625, 650, 675, 700, 725, 750 };
        double[] healing_bot_mana = { 0, 25, 26, 27, 29, 33, 36, 39, 44, 49, 56, 63, 69, 77, 86, 96 };
        public string[] healing_bot_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int blast_cannon_lvl = 0;
        public string blast_cannon_text;
        double[] blast_cannon_a = { 0, 120, 122, 124, 126, 128, 130, 132, 134, 136, 138, 140, 142, 144, 146, 148 };
        double[] blast_cannon_b = { 0, 0, 0, 0, 0, 25, 25, 25, 25, 25, 50, 50, 50, 50, 50, 75 };
        double[] blast_cannon_c = { 0, 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28 };
        double[] blast_cannon_mana = { 0, 9, 10, 11, 12, 12, 13, 15, 16, 18, 20, 23, 24, 28, 31, 34 };
        public string[] blast_cannon_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int spider_mines_lvl = 0;
        public string spider_mines_text;
        double[] spider_mines_a = { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75 };
        double[] spider_mines_b = { 0, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66 };
        double[] spider_mines_c = { 0, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
        double[] spider_mines_d = { 0, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 };
        double[] spider_mines_f = { 0, 3, 2.9, 2.8, 2.7, 2.6, 2.5, 2.4, 2.3, 2.2, 2.1, 2, 1.9, 1.8, 1.7, 1.6 };
        double[] spider_mines_mana = { 0, 32, 33, 33, 35, 29, 31, 33, 35, 39, 32, 36, 40, 43, 48, 35 };
        public string[] spider_mines_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int gun_bot_lvl = 0;
        public string gun_bot_text;
        double[] gun_bot_a = { 0, 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };
        double[] gun_bot_b = { 0, 24.75, 24.75, 24.75, 24.75, 24.75, 24.75, 24.75, 24.75, 24.75, 24.75, 24.75, 24.75, 24.75, 24.75, 24.75 };
        double[] gun_bot_c = { 0, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33 };
        double[] gun_bot_d = { 0, 180, 180, 180, 180, 150, 150, 150, 150, 150, 120, 120, 120, 120, 120, 90 };
        double[] gun_bot_e = { 0, 3, 3, 3, 3, 2.5, 2.5, 2.5, 2.5, 2.5, 2, 2, 2, 2, 2, 1.5 };
        double[] gun_bot_mana = { 0, 41, 42, 43, 43, 45, 47, 50, 53, 58, 63, 69, 76, 83, 90, 98 };
        public string[] gun_bot_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int shock_grenade_lvl = 0;
        public string shock_grenade_text;
        double[] shock_grenade_a = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        double[] shock_grenade_b = { 0, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78 };
        double[] shock_grenade_c = { 0, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6 };
        double[] shock_grenade_d = { 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
        double[] shock_grenade_e = { 0, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
        double[] shock_grenade_mana = { 0, 14, 14, 15, 15, 15, 16, 16, 17, 18, 20, 22, 24, 26, 28, 30 };
        public string[] shock_grenade_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int fusillade_lvl = 0;
        public string fusillade_text;
        double[] fusillade_a = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58 };
        double[] fusillade_mana = { 0, 23, 23, 24, 24, 25, 25, 26, 27, 29, 31, 33, 36, 39, 41, 44 };
        public string[] fusillade_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int sledgebot_lvl = 0;
        public string sledgebot_text;
        double[] sledgebot_a = { 0, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72 };
        double[] sledgebot_b = { 0, 0, 5, 10, 15, 20, 25, 35, 40, 45, 50, 55, 60, 65, 70, 75 };
        double[] sledgebot_c = { 0, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110 };
        double[] sledgebot_d = { 0, 160, 160, 160, 160, 160, 160, 160, 160, 160, 160, 160, 160, 160, 160, 160 };
        double[] sledgebot_mana = { 0, 57, 58, 59, 60, 62, 64, 66, 69, 73, 76, 80, 85, 89, 95, 100 };
        public string[] sledgebot_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int bulwark_lvl = 0;
        public string bulwark_text;
        double[] bulwark_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
        double[] bulwark_b = { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public string[] bulwark_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int fire_and_spark_lvl = 0;
        public string fire_and_spark_text;
        double[] fire_and_spark_a = { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75 };
        public string[] fire_and_spark_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int charge_domination_lvl = 0;
        public string charge_domination_text;
        double[] charge_domination_a = { 0, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10 };
        public string[] charge_domination_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int shield_bash_lvl = 0;
        public string shield_bash_text;
        double[] shield_bash_a = { 0, 0.2, 0.22, 0.24, 0.26, 0.28, 0.3, 0.32, 0.34, 0.36, 0.38, 0.4, 0.42, 0.44, 0.46, 0.48 };
        double[] shield_bash_b = { 0, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88 };
        double[] shield_bash_c = { 0, 1, 1.2, 1.4, 1.6, 1.8, 2, 2.2, 2.4, 2.6, 2.8, 3, 3.2, 3.4, 3.6, 3.8 };
        double[] shield_bash_d = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        double[] shield_bash_mana = { 0, 5, 6, 7, 8, 8, 9, 10, 11, 12, 13, 15, 16, 19, 20, 23 };
        public string[] shield_bash_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int forcefield_lvl = 0;
        public string forcefield_text;
        double[] forcefield_a = { 0, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 };
        double[] forcefield_b = { 0, 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };
        double[] forcefield_c = { 0, 1.075, 1.075, 1.075, 1.075, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.5 };
        double[] forcefield_mana = { 0, 32, 33, 34, 35, 28, 30, 33, 36, 41, 46, 52, 56, 63, 69, 48 };
        public string[] forcefield_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int overload_lvl = 0;
        public string overload_text;
        double[] overload_a = { 0, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34 };
        double[] overload_b = { 0, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40 };
        double[] overload_c = { 0, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80 };
        double[] overload_d = { 0, 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };
        double[] overload_mana = { 0, 27, 28, 28, 30, 31, 33, 36, 38, 42, 46, 52, 57, 62, 69, 75 };
        public string[] overload_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int dynamo_field_lvl = 0;
        public string dynamo_field_text;
        double[] dynamo_field_a = { 0, 0.2, 0.22, 0.24, 0.26, 0.28, 0.3, 0.32, 0.34, 0.36, 0.38, 0.4, 0.42, 0.44, 0.46, 0.48 };
        double[] dynamo_field_b = { 0, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38 };
        double[] dynamo_field_c = { 0, 50, 50, 50, 50, 70, 70, 70, 70, 70, 90, 90, 90, 90, 90, 110 };
        double[] dynamo_field_mana = { 0, 10, 11, 12, 13, 13, 15, 16, 17, 19, 20, 22, 23, 24, 25, 27 };
        public string[] dynamo_field_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int tremor_lvl = 0;
        public string tremor_text;
        double[] tremor_a = { 0, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100, 105, 110, 115, 120 };
        double[] tremor_b = { 0, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76, 80, 84, 88, 92, 96 };
        double[] tremor_c = { 0, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38 };
        double[] tremor_d = { 0, 0, 0, 0, 0, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
        double[] tremor_e = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 20, 20, 20, 20, 20 };
        double[] tremor_f = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 100 };
        double[] tremor_mana = { 0, 18, 18, 18, 19, 19, 20, 21, 22, 24, 26, 28, 31, 33, 36, 39 };
        public string[] tremor_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int fire_bash_lvl = 0;
        public string fire_bash_text;
        double[] fire_bash_a = { 0, 100, 105, 110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170 };
        double[] fire_bash_b = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 50 };
        double[] fire_bash_mana = { 0, 20, 20, 21, 21, 22, 22, 23, 24, 26, 27, 30, 32, 35, 36, 39 };
        public string[] fire_bash_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int immobilization_copter_lvl = 0;
        public string immobilization_copter_text;
        double[] immobilization_copter_a = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 46 };
        double[] immobilization_copter_b = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58 };
        double[] immobilization_copter_c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 14, 18, 22, 24, 28 };
        double[] immobilization_copter_d = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 25 };
        double[] immobilization_copter_mana = { 0, 15, 15, 15, 16, 16, 16, 17, 18, 19, 20, 21, 22, 24, 25, 26 };
        public string[] immobilization_copter_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int sword_and_board_lvl = 0;
        public string sword_and_board_text;
        double[] sword_and_board_a = { 0, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90 };
        public string[] sword_and_board_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int aegis_of_fate_lvl = 0;
        public string aegis_of_fate_text;
        double[] aegis_of_fate_a = { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public string[] aegis_of_fate_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int charge_reconstitution_lvl = 0;
        public string charge_reconstitution_text;
        double[] charge_reconstitution_a = { 0, 400, 460, 520, 580, 640, 720, 800, 880, 960, 1020, 1080, 1140, 1200, 1260, 1320 };
        public string[] charge_reconstitution_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        double weapon_damage, critical_damage, double_chance, critical_chance, fumble_recovery,
            max_mana, magic_damage, execute_chance, max_health, armor_bonus, block_chance;

        public Engineer()
        {
        }

        public void calc()
        {
            skillpointsleft = (level + fame) - flame_hammer_lvl - seismic_slam_lvl - ember_hammer_lvl - onslaught_lvl - ember_reach_lvl -
                storm_burst_lvl - emberquake_lvl - heavy_lifting_lvl - supercharge_lvl - coup_de_grace_lvl -
                healing_bot_lvl - blast_cannon_lvl - spider_mines_lvl - gun_bot_lvl - shock_grenade_lvl -
                fusillade_lvl - sledgebot_lvl - bulwark_lvl - fire_and_spark_lvl - charge_domination_lvl -
                shield_bash_lvl - forcefield_lvl - overload_lvl - dynamo_field_lvl - tremor_lvl -
                fire_bash_lvl - immobilization_copter_lvl - sword_and_board_lvl - aegis_of_fate_lvl - charge_reconstitution_lvl;
            statpointsleft = (int)(40 + ((level - 1) * 5) - strength - dexterity - focus - vitality);
        }

        public void stats_bonuses()
        {
            weapon_damage = Math.Round(strength, 2);
            critical_damage = Math.Round(strength * 0.4, 1);

			critical_chance = double_chance = Math.Round(dexterity * (0.2002 - 0.0002 * dexterity), 1);
            if (dexterity >= 500) 
            { 
                critical_chance = 50.1;
                double_chance = 50.1;
            }
			fumble_recovery = Math.Round(25 + dexterity * (0.3003 - 0.0003 * dexterity), 1);
            if (dexterity >= 478)
            {
                fumble_recovery = 100;
            }

            max_mana = Math.Round(47 + level + Math.Floor(focus * 0.5));			
            magic_damage = Math.Round((focus / 2), 1);
            execute_chance = Math.Round(9.8 + focus * (0.2002 - 0.0002 * focus), 1);
            if (focus >= 499)
            {
                execute_chance = 60;
            }

            max_health = Math.Round(160 + (level * 40) + Math.Floor(vitality * 3.6));			
            armor_bonus = Math.Round(vitality * 0.25, 2);
            if (vitality >= 500)
            {
                armor_bonus = 249.75;
            }
            block_chance = Math.Round(vitality * (0.2002 - 0.0002 * vitality), 1);
            if (vitality >= 500)
            {
                block_chance = 50.1;
            }
        }

        public void tooltips_text()
        {
            strength_text = "Урон от оружия: +" + weapon_damage + Environment.NewLine +
                "Критический урон: +" + critical_damage + " %" + Environment.NewLine;
            dexterity_text = "Шанс критического удара: +" + critical_chance + " %" + Environment.NewLine +
                "Шанс уклонения: +" + double_chance + " %" + Environment.NewLine +
                "Точность удара: +" + fumble_recovery + " %";
            focus_text = "Запас Маны (ОМ):  " + max_mana + Environment.NewLine +
                "Урон от магии: +" + magic_damage + " %" + Environment.NewLine +
                "Шанс казни: +" + execute_chance + " %";
            vitality_text = "Запас Здоровья (ОЗ): " + max_health + Environment.NewLine +
                "Бонус к броне: +" + armor_bonus + " %" + Environment.NewLine +
                "Шанс блокировать удар: +" + block_chance + " %";

            flame_hammer_text = "Это оружие сокрушает врагов, а при ударе образуются 4 осколка, которые самостоятельно ищут цели в радиусе 5 метров. При расходовании одного Заряда количество взрывов увеличивается до трех." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + flame_hammer_mana[flame_hammer_lvl] + Environment.NewLine +
                "Наносит " + flame_hammer_a[flame_hammer_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                flame_hammer_b[flame_hammer_lvl] + "% шанс поджечь цель на 3 сек." + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Образуется 5 огненных осколков, летящих на 8 м." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Образуется 6 огненных осколков, летящих на 11 м." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Образуется 7 огненных осколков, летящих на 14 м." + Environment.NewLine + Environment.NewLine +
                "Необходим топор, меч, молот, посох или копье";
            
            int seismic_slam_damage_instant = (int)Math.Ceiling(seismic_slam_b[seismic_slam_lvl] * damage_monster[level] / 100);
            int seismic_slam_damage_dot = (int)Math.Ceiling(seismic_slam_c[seismic_slam_lvl] * damage_monster[level] / 100) * 5;
            seismic_slam_text = "С помощью механических средств вы топчете и сжигаете всех окружающих вас врагов в радиусе 4 метров." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + seismic_slam_mana[seismic_slam_lvl] + Environment.NewLine +
                seismic_slam_a[seismic_slam_lvl] + "% шанс оглушить цель на 2 сек." + Environment.NewLine +
                "+" + seismic_slam_damage_instant + " урон Огнем*" + Environment.NewLine +
                "+100% шанс прервать действия врага" + Environment.NewLine +
                seismic_slam_damage_dot + " урон Огнем в теч. 5 сек.*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус воспламенения до 6 м." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус воспламенения до 8 м." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус воспламенения до 10 м." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            ember_hammer_text = "Мощный боковой удар с выбросом эмберитовой энергии в виде дуги в 270 градусов. Энергия уничтожает вражеские щиты. Не увеличивает число Зарядов." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + ember_hammer_mana[ember_hammer_lvl] + Environment.NewLine +
                "Наносит " + ember_hammer_a[ember_hammer_lvl] + "% от урона текущего оружия в сек. электричеством" + Environment.NewLine +
                "100% шанс разбить щит врага" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "+5% к урону за каждый Заряд." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "+10% к урону за каждый Заряд." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "+15% к урону за каждый Заряд." + Environment.NewLine + Environment.NewLine +
                "Необходим топор, меч, молот, посох или копье";

            onslaught_text = "Вы прыгаете вперед и втыкаете оружие в землю. Враги, находящиеся в зоне поражения, получают урон, их скорость падает. Применение натиска приносит половину Заряда." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + onslaught_mana[onslaught_lvl] + Environment.NewLine +
                "Наносит " + onslaught_a[onslaught_lvl] + "% от урона текущего оружия в сек. электричеством" + Environment.NewLine +
                "-50% от скорости атаки в теч. " + onslaught_b[onslaught_lvl] + " сек." + Environment.NewLine +
                "-50% от скорости движения в теч. " + onslaught_b[onslaught_lvl] + " сек." + Environment.NewLine +
                "-50% от скорости применения заклинаний в теч. " + onslaught_b[onslaught_lvl] + " сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Затраты маны снижены на 20%" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Затраты маны снижены на 40%" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Затраты маны снижены на 60%" + Environment.NewLine + Environment.NewLine +
                "Необходимо оружие ближнего боя в правой руке";

            ember_reach_text = "Энергетический поток притягивает врага на дистанцию удара. Каждый ваш Заряд на 20% увеличивает шанс оглушить врага на 3 сек., однако само применение навыка не увеличивает и не уменьшает уровень Заряда." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + ember_reach_mana[ember_reach_lvl] + Environment.NewLine +
                "Радиус действия: " + ember_reach_a[ember_reach_lvl] + " м" + Environment.NewLine;
            if (ember_reach_lvl >= 2)
            {
                ember_reach_text += "+" + ember_reach_b[ember_reach_lvl] + "% к получаемому Физич. урону в теч. " + ember_reach_c[ember_reach_lvl] + " сек." + Environment.NewLine;
            }
            ember_reach_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Затраты маны снижены на 20%. Эффект длится 4 сек." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Затраты маны снижены на 20%. Эффект длится 6 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Затраты маны снижены на 20%. Эффект длится 8 сек.";

            storm_burst_text = "Порыв ветра отбрасывает врагов назад. Из вашего костюма вырывается 3 потока энергии, которые поражают врагов на большой дистанции. Кроме того, каждая цель (до 5) восстанавливает ваш уровень маны на 5%." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + storm_burst_mana[storm_burst_lvl] + Environment.NewLine +
                "Время между активациями: 2 сек." + Environment.NewLine +
                "Наносит " + storm_burst_a[storm_burst_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                "+" + storm_burst_b[storm_burst_lvl] + " к отбрасыванию" + Environment.NewLine +
                "Дополнительный эффект:" + Environment.NewLine +
                "Наносит " + storm_burst_d[storm_burst_lvl] + "% от урона текущего оружия в сек. электричеством" + Environment.NewLine;
            if (storm_burst_lvl >= 10)
            {
                storm_burst_text += storm_burst_c[storm_burst_lvl] + "% шанс обездвижить цель на 3 сек." + Environment.NewLine;
            }
            storm_burst_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Число зарядов увеличено до 6" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "20% шанс обездвижить врагов" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Время активации снижено до 1 сек.";

		    int emberquake_damage = (int)Math.Floor(Math.Ceiling(emberquake_a[emberquake_lvl] * damage_monster[level] / 100) * emberquake_b[emberquake_lvl]);
            emberquake_text = "После мощного удара в земле появляется 8 трещин с лавой; потоки лавы ищут и уничтожают врагов заклинателя." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + emberquake_mana[emberquake_lvl] + Environment.NewLine +
                "+" + emberquake_damage + " урон Огнем*" + Environment.NewLine +
                emberquake_c[emberquake_lvl] + "% шанс поджечь цель" + Environment.NewLine +
                "Наносит " + emberquake_d[emberquake_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Урон огнем увеличен на 20%" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Урон огнем увеличен на 40%" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Урон огнем увеличен на 60%" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока" + Environment.NewLine + Environment.NewLine +
                "Необходим топор, меч, молот, посох или копье";

            heavy_lifting_text = "Ваше умение обращаться с гигантским оружием позволяет быстрее атаковать и повышает шанс оглушить врага." + Environment.NewLine + Environment.NewLine +
                "+" + heavy_lifting_a[heavy_lifting_lvl] + "% к скорости атаки" + Environment.NewLine +
                heavy_lifting_a[heavy_lifting_lvl] + "% шанс оглушить цель на 3 сек." + Environment.NewLine + Environment.NewLine +
                "Необходим двуручный топор, двуручный молот, двуручный меч, копье или пушка";

            supercharge_text = "При атаке в ближнем бою можно передать избыток энергии в оружие - и в течение 10 секунд удары будут сильнее. При этом ваш уровень Заряда повышается." + Environment.NewLine + Environment.NewLine +
                "Уровень Заряда повышается на " + supercharge_b[supercharge_lvl] + "%." + Environment.NewLine +
                supercharge_c[supercharge_lvl] + "% шанс сотворить заклинание \"Конденсатор\" при атаке" + Environment.NewLine + Environment.NewLine +
                "Необходимо оружие ближнего боя";
            
            coup_de_grace_text = "При нанесении удара оглушенной цели электрический заряд помогает вам ее прикончить. Частота применения - не более 1 раза в сек." + Environment.NewLine + Environment.NewLine +
                "Урон в " + coup_de_grace_a[coup_de_grace_lvl] + " раз(а) превышает вашу силу." + Environment.NewLine +
                "+" + coup_de_grace_b[coup_de_grace_lvl] + " к Электр. урону";
		 
	        int healing_bot_hp_regen = (int)Math.Ceiling((int)Math.Ceiling(healing_bot_c[healing_bot_lvl] * health_player_generic[level] / 100 * 4) / 62.5);
		    int healing_bot_mana_regen = (int)Math.Ceiling((int)Math.Ceiling(healing_bot_e[healing_bot_lvl] * mana_player_generic[level] / 100 * 4) / 62.5);
            healing_bot_text = "Маленький робот излучает энергию, которая исцеляет вас и ваших союзников." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + healing_bot_mana[healing_bot_lvl] + Environment.NewLine +
                "Время между активациями: 10 сек." + Environment.NewLine +
                "Робот действует каждые " + healing_bot_a[healing_bot_lvl] + " сек. в радиусе " + healing_bot_b[healing_bot_lvl] + " м" + Environment.NewLine +
                "Восполняется " + healing_bot_hp_regen + " ед. здоровья в теч. 4 сек.*" + Environment.NewLine;
            if (healing_bot_lvl >= 5) 
            {
                healing_bot_text += "+" + healing_bot_mana_regen + " к запасу маны в теч. 4 сек.*" + Environment.NewLine;
            }
            if (healing_bot_lvl >= 10) 
            {
                healing_bot_text += healing_bot_d[healing_bot_lvl] + "% к люб. броне в теч. 10 сек." + Environment.NewLine;
            }
            healing_bot_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Заряд энергии также восстанавливает уровень маны" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Уровень брони инженера и его союзников повышается на 8%" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Уровень брони инженера и его союзников повышается на 16%" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            blast_cannon_text = "Вы ведете обстрел снарядами дальнего действия. На высоких уровнях навыка взрывы делают врагов более восприимчивыми к огненному и физическому урону." + Environment.NewLine +
                "Расход маны: " + blast_cannon_mana[blast_cannon_lvl] + Environment.NewLine +
                "Наносит " + blast_cannon_a[blast_cannon_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine;
		    if (blast_cannon_lvl >= 2)
            {
                blast_cannon_text += "+" + blast_cannon_c[blast_cannon_lvl] + "% к получаемому Физич. урону в теч. 4 сек." + Environment.NewLine +
                "+" + blast_cannon_c[blast_cannon_lvl] + "% к получаемому Огнен. урону в теч. 4 сек." + Environment.NewLine;
            }
            if (blast_cannon_lvl >= 5) 
            {
                blast_cannon_text += blast_cannon_b[blast_cannon_lvl] + "% шанс ослепить цель на 4 сек." + Environment.NewLine;
            }
            blast_cannon_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Шанс ослепить врагов на 4 сек.: 25%" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Шанс ослепить врагов на 4 сек.: 50%" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Шанс ослепить врагов на 4 сек.: 75%" + Environment.NewLine + Environment.NewLine +
                "Необходима пушка";
		 
      	    int spider_mines_dam_physical = (int)Math.Ceiling(spider_mines_b[spider_mines_lvl] * damage_minion_bylevel[level] / 100);
		    int spider_mines_dam_fire =  (int)Math.Ceiling(spider_mines_c[spider_mines_lvl] * damage_minion_bylevel[level] / 100) * 3;
            spider_mines_text = "Три робота-паука подбегают к ближайшим врагам и взрываются; радиус взрыва составляет 3 метра. Усовершенствованные роботы наносят на 20% больше повреждений; радиус их взрыва составляет 5 метров, время оглушения цели 2 сек., доп. урон электричеством." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + spider_mines_mana[spider_mines_lvl] + Environment.NewLine +
                "Время между активациями: " + spider_mines_f[spider_mines_lvl] + " сек." + Environment.NewLine +
                spider_mines_a[spider_mines_lvl] + "%-шанс взрыва усовершенствованного робота" + Environment.NewLine +
                "Помощники наносят " + spider_mines_dam_physical + " Физич. урона*" + Environment.NewLine +
                "Помощники наносят " + spider_mines_dam_fire + " Огнен. урона в теч. 3 сек.*" + Environment.NewLine +
                "Время вызова: " + spider_mines_d[spider_mines_lvl] + " сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Затраты маны снижены на 20%" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Затраты маны снижены на 40%" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Затраты маны снижены на 60%" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

	        int gun_bot_mindam = (int)Math.Ceiling(gun_bot_b[gun_bot_lvl] * damage_minion_bylevel[level] / 100);
		    int gun_bot_maxdam = (int)Math.Ceiling(gun_bot_c[gun_bot_lvl] * damage_minion_bylevel[level] / 100);
            gun_bot_text = "Вы выпускаете на поле боя небольшого робота, который производит 5 выстрелов в сек. по врагам. С каждым новым уровнем навыка урон, наносимый роботом, повышается." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + gun_bot_mana[gun_bot_lvl] + Environment.NewLine +
                "Время между активациями: " + gun_bot_e[gun_bot_lvl] + " мин." + Environment.NewLine +
                "Время вызова: 1 мин.";
            if (gun_bot_lvl >= 2)
            {
                gun_bot_text += "+" + gun_bot_a[gun_bot_lvl] + "% к люб. урону" + Environment.NewLine;
            }
            gun_bot_text += "Помощники наносят " + gun_bot_mindam + "-" + gun_bot_maxdam + " Физич. урона*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус обстрела увеличен вдвое. Время между активациями сокращено до 2.5 мин." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Меткие выстрелы пронзают врагов. Время между активациями сокращено до 2 мин." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Интенсивность обстрела утраивается. Время между активациями сокращено до 1.5 мин." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
		 
            int shock_grenade_mindam = (int)Math.Ceiling(shock_grenade_d[shock_grenade_lvl] * damage_monster[level] / 100) * 4;
		    int shock_grenade_maxdam = (int)Math.Ceiling(shock_grenade_e[shock_grenade_lvl] * damage_monster[level] / 100) * 4;
            shock_grenade_text = "Вы бросаете гранату, взрыв которой наносит урон электричеством и оглушает врагов в радиусе 4 м. Для двух дополнительных гранат требуется один Заряд." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + shock_grenade_mana[shock_grenade_lvl] + Environment.NewLine +
                shock_grenade_a[shock_grenade_lvl] + "% шанс бить цель током в теч. 4 сек." + Environment.NewLine +
                shock_grenade_b[shock_grenade_lvl] + "% шанс оглушить цель на " + shock_grenade_c[shock_grenade_lvl] + " сек." + Environment.NewLine +
                "Электр. урон: " + shock_grenade_mindam + "-" + shock_grenade_maxdam + " в теч. 4 сек.*" + Environment.NewLine +
                "+100% шанс прервать действия врага" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус действия шоковой гранаты до 5 м" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Время оглушения шоковой гранатой до 5 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус действия шоковой гранаты увеличен до 6 м, эффект оглушения - до 6 сек." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            fusillade_text = "Вы непрерывно обстреливаете противника ракетами дальнего действия. Пока вы удерживаете кнопку мышки, персонаж стреляет залпами по 2 ракеты." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + fusillade_mana[fusillade_lvl] + " в сек." + Environment.NewLine +
                "Наносит " + fusillade_a[fusillade_lvl] + "% от урона текущего оружия в сек. Огнем" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "В каждом залпе 3 ракеты." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Ракеты взрываются в радиусе 3 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "В каждом залпе 4 ракеты." + Environment.NewLine + Environment.NewLine +
                "Необходима пушка";
		 
            int sledgebot_mindam = (int)Math.Ceiling(sledgebot_c[sledgebot_lvl] * damage_minion_bylevel[level] / 100);
		    int sledgebot_maxdam = (int)Math.Ceiling(sledgebot_d[sledgebot_lvl] * damage_minion_bylevel[level] / 100);
            sledgebot_text = "Вы создаете мощного робота-кувалду, который превращает врагов в кашицу." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + sledgebot_mana[sledgebot_lvl] + Environment.NewLine +
                "Время между активациями: 1.5 мин." + Environment.NewLine +
                "Время вызова: " + sledgebot_a[sledgebot_lvl] + " сек." + Environment.NewLine;
            if (sledgebot_lvl >= 2)
            {
                sledgebot_text += "+" + sledgebot_b[sledgebot_lvl] + "% к люб. урону" + Environment.NewLine +
                    "+" + sledgebot_b[sledgebot_lvl] + "% к люб. броне" + Environment.NewLine;
            }
            sledgebot_text += "Помощники наносят " + sledgebot_mindam + "-" + sledgebot_maxdam + " Физич. урона*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Робот-кувалда приобретает круговую атаку" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Робот-кувалда приобретает сокрушающую атаку" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Робот-кувалда атакует врагов ракетами" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            bulwark_text = "Опыт обращения с доспехами позволяет использовать их максимально эффективно. Урон, наносимый врагами, уменьшается." + Environment.NewLine + Environment.NewLine +
                "+" + bulwark_a[bulwark_lvl] + "% к Физич. броне" + Environment.NewLine +
                "-" + bulwark_b[bulwark_lvl] + "% от получаемого Физич. урона" + Environment.NewLine;

            fire_and_spark_text = "Искра, чтобы все заработало... а огонь - чтобы все сдохли." + Environment.NewLine + Environment.NewLine +
                "+" + fire_and_spark_a[fire_and_spark_lvl] + "% к Огнен. урону" + Environment.NewLine +
                "+" + fire_and_spark_a[fire_and_spark_lvl] + "% к Электр. урону" + Environment.NewLine;

            charge_domination_text = "После смерти врага у вас появляется возможность поглотить его энергию и заполнить индикатор Заряда. Перерыв между применениями способности 3 сек." + Environment.NewLine + Environment.NewLine +
                "Шанс пополнить заряд: " + charge_domination_a[charge_domination_lvl] + "%" + Environment.NewLine;

            shield_bash_text = "Вы бьете щитом находящихся перед вами врагов, оглушая и отбрасывая их, а также замедляя атаки. Урон в 5 раз больше показателя брони щита. Каждый Заряд увеличивает урон на 10%." + Environment.NewLine +
                "Расход маны: " + shield_bash_mana[shield_bash_lvl] + Environment.NewLine +
                "" + shield_bash_a[shield_bash_lvl] + " Заряда за каждый удар" + Environment.NewLine +
                shield_bash_b[shield_bash_lvl] + "% шанс оглушить цель на " + shield_bash_c[shield_bash_lvl] + " сек." + Environment.NewLine +
                "+25 к отбрасыванию" + Environment.NewLine +
                "-" + shield_bash_d[shield_bash_lvl] + "% от скорости атаки в теч. 2 сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Урон в 7,5 раз больше показателя брони" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Урон в 10 раз больше показателя брони" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Урон в 12,5 раз больше показателя брони" + Environment.NewLine + Environment.NewLine +
                "Необходимо держать в руках щит";
		 
            int forcefield_absorb = (int)Math.Ceiling(forcefield_a[forcefield_lvl] * health_monster_bylevel[level] / 100);
            forcefield_text = "Ваши доспехи излучают эмберитовую энергию, которая образует защитное поле вокруг вас и (вдвое слабее) вокруг ваших союзников. Нейтрализовав определенное количество урона, защитное поле исчезает. Силовое поле использует все доступные Заряды; поглощаемый урон увеличивается на 50% за каждый Заряд." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + forcefield_mana[forcefield_lvl] + Environment.NewLine +
                "Время между активациями: 8 сек." + Environment.NewLine +
                "Поглощение " + forcefield_absorb + " очков Люб. урона в теч. 30 сек.*" + Environment.NewLine;
            if (forcefield_lvl >= 2)
            {
                forcefield_text += "Сопротивление отбрасыванию: " + forcefield_b[forcefield_lvl] + "%" + Environment.NewLine;
            }
            forcefield_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Затраты маны и время применения снижены на 20%" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Робот-кувалда приобретает сокрушающую атаку" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Затраты маны и время применения снижены на 50%" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
		
            int overload_mindam = (int)Math.Ceiling(overload_b[overload_lvl] * damage_monster[level] / 100);
		    int overload_maxdam = (int)Math.Ceiling(overload_c[overload_lvl] * damage_monster[level] / 100);
            overload_text = "Вы перегружаете электрические цепи брони, создавая мощный разряд эмберитовой энергии, который наносит электрический удар 5 врагам в радиусе 6 метров. При перегрузке расходуются все доступные Заряды; наносимый урон увеличивается на 50% за каждый Заряд." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + overload_mana[overload_lvl] + Environment.NewLine +
                "Время между активациями: 1.4 сек." + Environment.NewLine +
                "Наносит " + overload_a[overload_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                overload_mindam + "-" + overload_maxdam + " к Электр. урону*" + Environment.NewLine +
                "+50 к отбрасыванию" + Environment.NewLine;
            if (overload_lvl >= 2)
            {
                overload_text += overload_d[overload_lvl] + "% шанс оглушить цель на 2 сек." + Environment.NewLine;
            }
            overload_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Электроудар: до 7 врагов в радиусе 8 м" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Электроудар: до 9 врагов в радиусе 10 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Электроудар: до 11 врагов в радиусе 12 м" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
		
            int dynamo_field_dam = (int)Math.Ceiling(dynamo_field_b[dynamo_field_lvl] * damage_monster[level] / 100) * 2;
            dynamo_field_text = "Вы преобразуете энергию своей брони в электрический разряд, который поражает врагов в радиусе 5 метров. За каждого врага, которому нанесен урон (до 5), ваш уровень заряда повышается." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + dynamo_field_mana[dynamo_field_lvl] + Environment.NewLine +
                "" + dynamo_field_a[dynamo_field_lvl] + " Заряда за каждого получившего урон врага" + Environment.NewLine +
                dynamo_field_dam + " Электр. урона в теч. 2 сек.*" + Environment.NewLine +
                "+" + dynamo_field_c[dynamo_field_lvl] + "% шанс прервать действия врага" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус поля: 7 м; вероятность прерывания: 70%." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус поля: 7 м; вероятность прерывания: 90%." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус поля: 7 м; вероятность прерывания: 100%." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            tremor_text = "Вы выпускаете поток энергии из костюма в землю, создавая мощную ударную волну, которая сбивает с ног и ослабляет врагов в пределах 24 метров. Данный эффект достигается только в том случае, если израсходован один Заряд." + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + tremor_mana[tremor_lvl] + Environment.NewLine +
                "Время между активациями: 10 сек." + Environment.NewLine +
                "Наносит " + tremor_a[tremor_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                "+30 к отбрасыванию" + Environment.NewLine +
                tremor_b[tremor_lvl] + "% шанс прервать действия врага" + Environment.NewLine +
                "-" + tremor_c[tremor_lvl] + "% от Физич. урона в теч. 10 сек." + Environment.NewLine;
            if (tremor_lvl >= 5)
            {
                tremor_text += tremor_d[tremor_lvl] + "% шанс обратить цель в бегство на 10 сек." + Environment.NewLine;
            }
            if (tremor_lvl >= 10) 
            {
                tremor_text += "-" + tremor_e[tremor_lvl] + "% от Физич. урона в теч. 10 сек." + Environment.NewLine;
            }
            if (tremor_lvl == 15) 
            {
                tremor_text += tremor_f[tremor_lvl] + "% шанс оглушить цель на 2 сек." + Environment.NewLine;
            }
            tremor_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "В 20% случаев заклинание на 10 секунд обращает врагов в бегство" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Ослабленные враги наносят на 20% меньше физического урона" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Все цели оглушены на 2 секунды";

            fire_bash_text = "С помощью щита вы направляете на врага мощный поток энергии на расстояние 6 метров. Наносимый урон зависит от показателя брони щита. При использовании одного Заряда физический урон утраивается, радиус действия увеличивается до 9 метров." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + fire_bash_mana[fire_bash_lvl] + Environment.NewLine +
                fire_bash_a[fire_bash_lvl] + "% к урону" + Environment.NewLine +
                "+35 к отбрасыванию" + Environment.NewLine;
            if (fire_bash_lvl == 15) 
            {
                fire_bash_text += "-" + fire_bash_b[fire_bash_lvl] + "% от Огнен. урона в теч. 5 сек." + Environment.NewLine;
            }
            overload_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Время горения увеличено до 5 сек." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Угол сектора увеличен на 40 градусов" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Горящие цели получают на 50% огненного урона больше" + Environment.NewLine + Environment.NewLine +
                "Необходимо держать в руках щит.";
		 
            int immobilization_copter_damage = (int)Math.Floor((int)Math.Ceiling(immobilization_copter_c[immobilization_copter_lvl] * damage_minion_bylevel[level] / 100) * 0.15);
            immobilization_copter_text = "Вы выпускаете вертолет, который обездвиживает врагов своим лучом. Одновременно можно воздействовать на 3 цели." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + immobilization_copter_mana[immobilization_copter_lvl] + Environment.NewLine +
                "Время между активациями: 10 сек." + Environment.NewLine +
                "-" + immobilization_copter_a[immobilization_copter_lvl] + "% от скорости движения в теч. 0.2 сек." + Environment.NewLine +
                "-" + immobilization_copter_b[immobilization_copter_lvl] + "% от скорости атаки в теч. 0.2 сек." + Environment.NewLine +
                "-" + immobilization_copter_b[immobilization_copter_lvl] + "% от скорости применения заклинаний в теч. 0.2 сек." + Environment.NewLine;
            if (immobilization_copter_lvl >= 10)
            {
                immobilization_copter_text += "" + immobilization_copter_damage + " к Электр. урона в теч. 0.2 сек.*" + Environment.NewLine;
            }
            if (immobilization_copter_lvl == 15) 
            {
                immobilization_copter_text += "+" + immobilization_copter_d[immobilization_copter_lvl] + "% шанс прервать действия врага" + Environment.NewLine;
            }
            immobilization_copter_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Одновременно можно воздействовать на 5 целей" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Замедленные враги также получают урон электричеством" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Действия целей постоянно прерываются";

            sword_and_board_text = "Умение обращаться со щитом переходит из категории \"защита\" в категорию \"нападение\". Ваши атаки в ближнем бою наносят дополнительный урон, напрямую зависящий от показателя брони вашего щита." + Environment.NewLine + Environment.NewLine +
                "Урон в рукопашной: +" + sword_and_board_a[sword_and_board_lvl] + "% от параметра брони щита" + Environment.NewLine + Environment.NewLine +
                "Необходим щит и любое оружие ближнего боя";

            aegis_of_fate_text = "При атаке врагов броня может окружить вас защитной сферой, которая предотвратит нанесение урона. Эта сфера способна нейтрализовать урон, который на 100 ед. больше показателя брони, умноженного на два. Пока эффект действует, ваша устойчивость к отбрасыванию повышается на 50%." + Environment.NewLine + Environment.NewLine +
                aegis_of_fate_a[aegis_of_fate_lvl] + "% шанс сотворить заклинание \"Эгида\" при получении удара";		
         
            int charge_reconstitution_hp_regen = (int)Math.Ceiling((int)Math.Ceiling(charge_reconstitution_a[charge_reconstitution_lvl] * health_player_generic[level] / 100 * 2) / 62.5);
            charge_reconstitution_text = "При использовании Заряда на применение навыков вы частично восстанавливаете здоровье." + Environment.NewLine + Environment.NewLine +
                "Восполняется " + charge_reconstitution_hp_regen + " ед. здоровья в теч. 2 сек.*" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока" + Environment.NewLine;            
        }
    }
}