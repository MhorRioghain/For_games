using System;

namespace Skill_Calculator
{
    public class Engineer
    {
        public int skillpointsleft, level, fame, statpointsleft;
        public double strength = 15, dexterity = 15, focus = 5, vitality = 5;
        public string strength_text, dexterity_text, focus_text, vitality_text;

        public string[] fame_ranks = { "2000", "3000", "4000", "5000", "7000", "9000", "12000", "14000", "16000", "18000", "19000", "22000", "23000", "26000", "27000", "29000", "31000", "34000", "35000", "37000", "40000", "41000", "44000", "46000", "48000", "50000", "52000", "55000", "56000", "59000", "62000", "63000", "9005000", "full" };

        double[] armor_player_bylevel_forset = { 0, 8, 10, 12, 14, 17, 20, 22, 25, 28, 31, 34, 37, 40, 43, 46, 50, 53, 56, 60, 63, 67, 70, 74, 77, 81, 85, 88, 92, 96, 100, 103, 107, 111, 115, 119, 123, 127, 131, 135, 139, 143, 147, 151, 155, 159, 163, 167, 171, 176, 180, 184, 188, 192, 197, 201, 205, 209, 214, 218, 222, 226, 231, 235, 239, 244, 248, 253, 257, 261, 266, 270, 274, 279, 283, 288, 292, 297, 301, 305, 310, 314, 319, 323, 328, 332, 337, 341, 346, 350, 355, 359, 364, 368, 373, 377, 382, 386, 391, 395, 400, 405, 409, 414, 418, 423 };
        double[] damage_minion_bylevel = { 0, 24, 30, 37, 44, 51, 58, 66, 74, 83, 92, 101, 110, 120, 131, 142, 153, 164, 177, 189, 202, 215, 229, 243, 258, 273, 288, 304, 321, 338, 355, 373, 392, 411, 430, 450, 471, 492, 514, 536, 558, 582, 605, 630, 655, 680, 706, 733, 760, 788, 817, 846, 876, 906, 937, 968, 1001, 1034, 1067, 1101, 1136, 1172, 1208, 1245, 1283, 1321, 1360, 1400, 1440, 1481, 1523, 1566, 1609, 1653, 1698, 1744, 1790, 1837, 1885, 1934, 1984, 2034, 2085, 2137, 2190, 2243, 2297, 2353, 2409, 2466, 2523, 2582, 2641, 2701, 2763, 2825, 2888, 2951, 3016, 3082, 3148, 3216, 3284, 3353, 3423, 3495 };
        double[] damage_monster = { 0, 10, 14, 19, 23.9, 29, 34.5, 40.200001, 46.299999, 52.599998, 59.299999, 66.400002, 73.800003, 81.5, 89.599998, 98.099998, 106.900002, 116.099998, 125.699997, 135.699997, 146.100006, 157, 168.199997, 179.899994, 192, 204.600006, 217.699997, 231.199997, 245.199997, 259.600006, 274.600006, 290.100006, 306.100006, 322.600006, 339.600006, 357.200012, 375.299988, 394, 413.299988, 433.100006, 453.600006, 474.600006, 496.200012, 518.5, 541.400024, 564.900024, 589.099976, 613.900024, 639.400024, 665.599976, 692.5, 720, 748.299988, 777.299988, 807, 837.5, 868.700012, 900.700012, 933.5, 967, 1001.400024, 1036.5, 1072.5, 1109.300049, 1147, 1185.5, 1224.800049, 1265.099976, 1306.199951, 1348.199951, 1391.099976, 1435, 1479.800049, 1525.5, 1572.199951, 1619.900024, 1668.5, 1718.099976, 1768.800049, 1820.400024, 1873.099976, 1926.900024, 1981.699951, 2037.5, 2094.5, 2152.5, 2211.600098, 2271.899902, 2333.300049, 2395.800049, 2459.5, 2524.300049, 2590.399902, 2657.600098, 2726.100098, 2795.800049, 2866.699951, 2938.800049, 3012.300049, 3087, 3163, 3240.300049, 3318.899902, 3398.800049, 3480.100098, 3562.800049 };
        double[] armor_monster_bylevel = { 0, 4, 7, 8, 11, 14, 18, 21, 25, 28, 32, 37, 41, 46, 50, 55, 61, 66, 72, 77, 83, 90, 96, 102, 109, 116, 123, 131, 138, 146, 154, 162, 170, 179, 188, 196, 206, 215, 224, 234, 244, 254, 264, 275, 286, 296, 307, 319, 330, 342, 354, 366, 378, 390, 403, 416, 429, 442, 456, 469, 483, 497, 511, 526, 540, 555, 570, 585, 601, 616, 632, 648, 664, 680, 697, 714, 731, 748, 765, 783, 800, 818, 836, 855, 873, 892, 911, 930, 949, 969, 988, 1008, 1028, 1049, 1069, 1090, 1111, 1132, 1153, 1175, 1196, 1218, 1240, 1262, 1285, 1307 };
        double[] health_player_generic = { 0, 200, 240, 280, 320, 360, 400, 440, 480, 520, 560, 600, 640, 680, 720, 760, 800, 840, 880, 920, 960, 1000, 1040, 1080, 1120, 1160, 1200, 1240, 1280, 1320, 1360, 1400, 1440, 1480, 1520, 1560, 1600, 1640, 1680, 1720, 1760, 1800, 1840, 1880, 1920, 1960, 2000, 2040, 2080, 2120, 2160, 2200, 2240, 2280, 2320, 2360, 2400, 2440, 2480, 2520, 2560, 2600, 2640, 2680, 2720, 2760, 2800, 2840, 2880, 2920, 2960, 3000, 3040, 3080, 3120, 3160, 3200, 3240, 3280, 3320, 3360, 3400, 3440, 3480, 3520, 3560, 3600, 3640, 3680, 3720, 3760, 3800, 3840, 3880, 3920, 3960, 4000, 4040, 4080, 4120, 4160, 4200, 4240, 4280, 4320, 4360 };
        double[] mana_player_generic = { 0, 47.5, 48.5, 49.5, 50.5, 51.5, 52.5, 53.5, 54.5, 55.5, 56.5, 57.5, 58.5, 59.5, 60.5, 61.5, 62.5, 63.5, 64.5, 65.5, 66.5, 67.5, 68.5, 69.5, 70.5, 71.5, 72.5, 73.5, 74.5, 75.5, 76.5, 77.5, 78.5, 79.5, 80.5, 81.5, 82.5, 83.5, 84.5, 85.5, 86.5, 87.5, 88.5, 89.5, 90.5, 91.5, 92.5, 93.5, 94.5, 95.5, 96.5, 97.5, 98.5, 99.5, 100.5, 101.5, 102.5, 103.5, 104.5, 105.5, 106.5, 107.5, 108.5, 109.5, 110.5, 111.5, 112.5, 113.5, 114.5, 115.5, 116.5, 117.5, 118.5, 119.5, 120.5, 121.5, 122.5, 123.5, 124.5, 125.5, 126.5, 127.5, 128.5, 129.5, 130.5, 131.5, 132.5, 133.5, 134.5, 135.5, 136.5, 137.5, 138.5, 139.5, 140.5, 141.5, 142.5, 143.5, 144.5, 145.5, 146.5 }; double[] health_monster_bylevel = { 0, 11, 16, 21, 30, 37, 44, 53, 61, 71, 82, 93, 105, 118, 133, 148, 164, 182, 200, 220, 240, 262, 286, 310, 336, 363, 392, 422, 453, 486, 520, 556, 593, 633, 673, 716, 760, 806, 853, 902, 954, 1007, 1062, 1119, 1178, 1239, 1302, 1367, 1434, 1503, 1574, 1648, 1724, 1802, 1882, 1965, 2050, 2138, 2228, 2320, 2415, 2512, 2612, 2715, 2820, 2928, 3039, 3152, 3268, 3387, 3509, 3633, 3761, 3891, 4024, 4161, 4300, 4443, 4588, 4737, 4889, 5044, 5202, 5363, 5528, 5696, 5868, 6043, 6221, 6403, 6588, 6776, 6969, 7165, 7364, 7567, 7774, 7985, 8199, 8417, 8639, 8865, 9095, 9328, 9566, 9807 };

        public int flame_hummer_lvl = 0;
        public string flame_hummer_text;
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
            skillpointsleft = (level + fame);
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

            /*if((num==0)||(num==1))
		if (skill1!=0) {
			textskill1.innerHTML = "<img src='/pic/skills/skillicon_flamehammer.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Огненный молот</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill1+"/15<br/><br/>";
			textskill1.innerHTML +="<br/>Это оружие сокрушает врагов, а при ударе образуются 4 осколка, которые самостоятельно ищут цели в радиусе 5 метров. При расходовании одного Заряда количество взрывов увеличивается до трех.</a><br/>";
		 	textskill1.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill1+"</a><br>";
		 	textskill1.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+flame_hammer_mana[skill1-1]+"</a><br>";
		 	textskill1.innerHTML +="<a style='color:#1F90FF'>Наносит " + flame_hammer_a[skill1] + "% от урона текущего оружия в сек.</a><br \/>";
			textskill1.innerHTML +="<a style='color:#1F90FF'>"+ flame_hammer_b[skill1] + "% шанс поджечь цель на 3 сек.</a><br \/>";		 
		 	textskill1.innerHTML +=texttemp+"Образуется 5 огненных осколков, летящих на 8 м.<br></a>";
		 	textskill1.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill1.innerHTML +=texttemp+"Образуется 6 огненных осколков, летящих на 11 м.<br></a>";
		 	textskill1.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill1.innerHTML +=texttemp+"Образуется 7 огненных осколков, летящих на 14 м.<br/></a>";
		 	textskill1.innerHTML +="<br/><a style='color:#ffff00'>Необходим топор, меч, молот, посох или копье</a><br>";
             * 
        var seismic_slam_damage_instant = Math.ceil(seismic_slam_b[skill2] * damage_monster[level] / 100);
		var seismic_slam_damage_dot = Math.ceil(seismic_slam_c[skill2] * damage_monster[level] / 100) * 5;
			textskill2.innerHTML = "<img src='/pic/skills/skillicon_seismicslam.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Сейсмический топот</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill2+"/15<br/><br/>";
			textskill2.innerHTML +="<br/>С помощью механических средств вы топчете и сжигаете всех окружающих вас врагов в радиусе 4 метров.</a><br/>";
		 	textskill2.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill2+"</a><br>";
		 	textskill2.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+seismic_slam_mana[skill2-1]+"</a><br>";
			textskill2.innerHTML +="<a style='color:#1F90FF'>"+ seismic_slam_a[skill2] + "% шанс оглушить цель на 2 сек.</a><br \/>";
			textskill2.innerHTML +="<a style='color:#1F90FF'>+" + seismic_slam_damage_instant + " урон Огнем*</a><br \/>";
			textskill2.innerHTML +="<a style='color:#1F90FF'>+100% шанс прервать действия врага</a><br \/>";
			textskill2.innerHTML +="<a style='color:#1F90FF'>"+seismic_slam_damage_dot + " урон Огнем в теч. 5 сек.*</a><br \/>";		
		 	textskill2.innerHTML +=texttemp+"Радиус воспламенения до 6 м<br></a>";
		 	textskill2.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill2.innerHTML +=texttemp+"Радиус воспламенения до 8 м<br></a>";
		 	textskill2.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill2.innerHTML +=texttemp+"Радиус воспламенения до 10 м<br/></a>";
		 	textskill2.innerHTML +="<br><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		 
		    textskill3.innerHTML = "<img src='/pic/skills/skillicon_ember_hammer.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Эмберитовый молот</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill3+"/15<br/><br/>";
			textskill3.innerHTML +="<br/>Мощный боковой удар с выбросом эмберитовой энергии в виде дуги в 270 градусов. Энергия уничтожает вражеские щиты. Не увеличивает число Зарядов.</a><br/>";
		 	textskill3.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill3+"</a><br>";
		 	textskill3.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+ember_hammer_mana[skill3-1]+"</a><br>";
            textskill3.innerHTML +="<a style='color:#1F90FF'>Наносит " + ember_hammer_a[skill3] + "% от урона текущего оружия в сек. электричеством</a><br \/>";
			textskill3.innerHTML +="<a style='color:#1F90FF'>100% шанс разбить щит врага</a><br \/>";
		 	textskill3.innerHTML +=texttemp+"+5% к урону за каждый Заряд.<br></a>";
		 	textskill3.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill3.innerHTML +=texttemp+"+10% к урону за каждый Заряд.<br></a>";
		 	textskill3.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill3.innerHTML +=texttemp+"+15% к урону за каждый Заряд.<br/></a>";
		 	textskill3.innerHTML +="<br/><a style='color:#ffff00'>Необходим топор, меч, молот, посох или копье</a><br>";
		 
			textskill4.innerHTML = "<img src='/pic/skills/skillicon_onslaught.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Натиск</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill4+"/15<br/><br/>";
			textskill4.innerHTML +="<br/>Вы прыгаете вперед и втыкаете оружие в землю. Враги, находящиеся в зоне поражения, получают урон, их скорость падает. Применение натиска приносит половину Заряда.</a><br/>";
		 	textskill4.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill4+"</a><br>";
		 	textskill4.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+onslaught_mana[skill4-1]+"</a><br>";
			textskill4.innerHTML +="<a style='color:#1F90FF'>Наносит " + onslaught_a[skill4] + "% от урона текущего оружия в сек. электричеством</a><br \/>";
			textskill4.innerHTML +="<a style='color:#1F90FF'>-50% от скорости атаки в теч. " + onslaught_b[skill4] + " сек.</a><br \/>";
			textskill4.innerHTML +="<a style='color:#1F90FF'>-50% от скорости движения в теч. " + onslaught_b[skill4] + " сек.</a><br \/>";
			textskill4.innerHTML +="<a style='color:#1F90FF'>-50% от скорости применения заклинаний в теч. " + onslaught_b[skill4] + " сек.</a><br \/>";
		 	textskill4.innerHTML +=texttemp+"Затраты маны снижены на 20%<br></a>";
		 	textskill4.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill4.innerHTML +=texttemp+"Затраты маны снижены на 40%<br></a>";
		 	textskill4.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill4.innerHTML +=texttemp+"Затраты маны снижены на 60%<br/></a>";
		 	textskill4.innerHTML +="<br/><a style='color:#ffff00'>Необходимо оружие ближнего боя в правой руке</a><br>";
		 
		  	textskill5.innerHTML = "<img src='/pic/skills/skillicon_pull.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Эмберитовый захват</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill5+"/15<br/><br/>";
			textskill5.innerHTML +="<br/>Энергетический поток притягивает врага на дистанцию удара. Каждый ваш Заряд на 20% увеличивает шанс оглушить врага на 3 сек., однако само применение навыка не увеличивает и не уменьшает уровень Заряда.</a><br/>";
		 	textskill5.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill5+"</a><br>";
		 	textskill5.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+ember_reach_mana[skill5-1]+"</a><br>";
		 	textskill5.innerHTML +="<a style='color:#FF00FF'>Радиус действия: " + ember_reach_a[skill5] + " м</a><br \/>";
		 if (skill5 >= 2)textskill5.innerHTML +="<a style='color:#1F90FF'>+" + ember_reach_b[skill5] + "% к получаемому Физич. урону в теч. " + ember_reach_c[skill5] + " сек.</a><br \/>";
		 	textskill5.innerHTML +=texttemp+"Затраты маны снижены на 20%. Эффект длится 4 сек.<br></a>";
		 	textskill5.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill5.innerHTML +=texttemp+"Затраты маны снижены на 40%. Эффект длится 6 сек.<br></a>";
		 	textskill5.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill5.innerHTML +=texttemp+"Затраты маны снижены на 60%. Эффект длится 8 сек.<br/></a>";

		    textskill6.innerHTML = "<img src='/pic/skills/skillicon_shock_dash.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Штормовой порыв</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill6+"/15<br/><br/>";
			textskill6.innerHTML +="<br/>Порыв ветра отбрасывает врагов назад. Из вашего костюма вырывается 3 потока энергии, которые поражают врагов на большой дистанции. Кроме того, каждая цель (до 5) восстанавливает ваш уровень маны на 5%.</a><br/>";
		 	textskill6.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill6+"</a><br>";
		 	textskill6.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+storm_burst_mana[skill6-1]+"</a><br>";
		 	textskill6.innerHTML +="<a style='color:#FF00FF'>Время между активациями: 2 сек.</a><br>";
			textskill6.innerHTML +="<a style='color:#1F90FF'>Наносит " + storm_burst_a[skill6] + "% от урона текущего оружия в сек.</a><br \/>";
			textskill6.innerHTML +="<a style='color:#1F90FF'>+" + storm_burst_b[skill6] + " к отбрасыванию</a><br \/>";
			textskill6.innerHTML +="<a style='color:#1F90FF'>Дополнительный эффект:</a><br \/>";
			textskill6.innerHTML +="<a style='color:#1F90FF'>Наносит " + storm_burst_d[skill6] + "% от урона текущего оружия в сек. электричеством</a><br \/>";
		 if (skill6 >= 10)
		 		{
			textskill6.innerHTML +="<a style='color:#1F90FF'>"+storm_burst_c[skill6] + "% шанс обездвижить цель на 3 сек.</a><br \/>";
				}		 
		 	textskill6.innerHTML +=texttemp+"Число зарядов увеличено до 6<br></a>";
		 	textskill6.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill6.innerHTML +=texttemp+"20% шанс обездвижить врагов<br></a>";
		 	textskill6.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill6.innerHTML +=texttemp+"Время активации снижено до 1 сек.<br/></a>";
		 
	   var emberquake_damage = Math.floor(Math.ceil(emberquake_a[skill7] * damage_monster[level] / 100) * emberquake_b[skill7]);
		    textskill7.innerHTML = "<img src='/pic/skills/skillicon_emberquake.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Эмберитовая дрожь</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill7+"/15<br/><br/>";
			textskill7.innerHTML +="<br/>После мощного удара в земле появляется 8 трещин с лавой; потоки лавы ищут и уничтожают врагов заклинателя.</a><br/>";
		 	textskill7.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill7+"</a><br>";
		 	textskill7.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+emberquake_mana[skill7-1]+"</a><br>";
			textskill7.innerHTML +="<a style='color:#1F90FF'>+" + emberquake_damage + " урон Огнем*</a><br \/>";
			textskill7.innerHTML +="<a style='color:#1F90FF'>"+emberquake_c[skill7] + "% шанс поджечь цель</a><br \/>";
			textskill7.innerHTML +="<a style='color:#1F90FF'>Наносит " + emberquake_d[skill7] + "% от урона текущего оружия в сек.</a><br \/>";
		 	textskill7.innerHTML +=texttemp+"Урон огнем увеличен на 20%<br></a>";
		 	textskill7.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill7.innerHTML +=texttemp+"Урон огнем увеличен на 40%<br></a>";
		 	textskill7.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill7.innerHTML +=texttemp+"Урон огнем увеличен на 60%<br/></a>";
		 	textskill7.innerHTML +="<br/><a style='color:#ffff00'>Необходим топор, меч, молот, посох или копье</a><br/><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		 
		    textskill8.innerHTML = "<img src='/pic/skills/skillicon_2hmastery.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Подъем тяжестей(Пассивный навык)</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill8+"/15<br/><br/>";
			textskill8.innerHTML +="<br/>Ваше умение обращаться с гигантским оружием позволяет быстрее атаковать и повышает шанс оглушить врага.</a><br/>";
		 	textskill8.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill8+"</a><br>";
		 	textskill8.innerHTML +="<a style='color:#1F90FF'>+" + heavy_lifting_a[skill8] + "% к скорости атаки</a><br \/>";
			textskill8.innerHTML +="<a style='color:#1F90FF'>"+heavy_lifting_a[skill8] + "% шанс оглушить цель на 3 сек.</a><br \/>";
            textskill8.innerHTML +="<br/><a style='color:#ffff00'>Необходим двуручный топор, двуручный молот, двуручный меч, копье или пушка</a><br>";
             * 
		    textskill9.innerHTML = "<img src='/pic/skills/skillicon_thunder_hammer.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Конденсатор (Пассивный навык)</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill9+"/15<br/><br/>";
			textskill9.innerHTML +="<br/>При атаке в ближнем бою можно передать избыток энергии в оружие - и в течение 10 секунд удары будут сильнее. При этом ваш уровень Заряда повышается.</a><br/>";
		 	textskill9.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill9+"</a><br>";
			textskill9.innerHTML +="<a style='color:#1F90FF'>Supercharge surges do " + supercharge_a[skill9] + "%. Уровень Заряда повышается на " + supercharge_b[skill9] + "%.</a><br \/>";
			textskill9.innerHTML +="<a style='color:#1F90FF'>"+supercharge_c[skill9] + "% шанс сотворить заклинание &quot;Конденсатор&quot; при атаке</a><br \/>";
		    textskill9.innerHTML +="<br><a style='color:#ffff00'>Необходимо оружие ближнего боя</a><br>";
             * 
		    textskill10.innerHTML = "<img src='/pic/skills/skillicon_coupdegrace.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Удар милосердия (Пассивный навык)</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill10+"/15<br/><br/>";
			textskill10.innerHTML +="<br/>При нанесении удара оглушенной цели электрический заряд помогает вам ее прикончить. Частота применения - не более 1 раза в сек.</a><br/>";
		 	textskill10.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill10+"</a><br>";
			textskill10.innerHTML +="<a style='color:#1F90FF'>Урон в " + coup_de_grace_a[skill10] + " раз(а) превышает вашу силу.</a><br \/>";            textskill10.innerHTML +="<a style='color:#1F90FF'>+" + coup_de_grace_b[skill10] + " к Электр. урону</a><br \/>";
		 
	    var healing_bot_hp_regen = Math.ceil(Math.ceil(healing_bot_c[skill11] * health_player_generic[level] / 100 * 4) / 62.5)
		var healing_bot_mana_regen = Math.ceil(Math.ceil(healing_bot_e[skill11] * mana_player_generic[level] / 100 * 4) / 62.5)
			textskill11.innerHTML = "<img src='/pic/skills/skillicon_supportbot.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Робот-медик</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill11+"/15<br/><br/>";
			textskill11.innerHTML +="<br/>Маленький робот излучает энергию, которая исцеляет вас и ваших союзников.</a><br/>";
		 	textskill11.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill11+"</a><br>";
		 	textskill11.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+healing_bot_mana[skill11-1]+"</a><br>";
		    textskill11.innerHTML +="<a style='color:#FF00FF'>Время между активациями: 10 сек.</a><br>";
		    textskill11.innerHTML +="<a style='color:#1F90FF'>Робот действует каждые " + healing_bot_a[skill11] + " сек. в радиусе " + healing_bot_b[skill11] + " м</a><br \/>";
			textskill11.innerHTML +="<a style='color:#1F90FF'>Восполняется "+healing_bot_hp_regen + " ед. здоровья в теч. 4 сек.*</a><br \/>";
		  if (skill11 >= 5) {
			textskill11.innerHTML +="<a style='color:#1F90FF'>+" + healing_bot_mana_regen + " к запасу маны в теч. 4 сек.*</a><br \/>";
				}
		  if (skill11 >= 10) {
			textskill11.innerHTML +="<a style='color:#1F90FF'>"+healing_bot_d[skill11] + "% к люб. броне в теч. 10 сек.</a><br \/>";
				}		
		 	textskill11.innerHTML +=texttemp+"Заряд энергии также восстанавливает уровень маны.<br></a>";
		 	textskill11.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill11.innerHTML +=texttemp+"Уровень брони инженера и его союзников повышается на 8%<br></a>";
		 	textskill11.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill11.innerHTML +=texttemp+"Уровень брони инженера и его союзников повышается на 16%<br/></a>";
		 	textskill11.innerHTML +="<br/><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		 
			textskill12.innerHTML = "<img src='/pic/skills/skillicon_blastcannon.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Огненный снаряд</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill12+"/15<br/><br/>";
			textskill12.innerHTML +="<br/>Вы ведете обстрел снарядами дальнего действия. На высоких уровнях навыка взрывы делают врагов более восприимчивыми к огненному и физическому урону.</a><br/>";
		 	textskill12.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill12+"</a><br>";
		 	textskill12.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+blast_cannon_mana[skill12-1]+"</a><br>";
		    textskill12.innerHTML +="<a style='color:#1F90FF'>Наносит " + blast_cannon_a[skill12] + "% от урона текущего оружия в сек.</a><br \/>";
		if (skill12 >= 2)
		 {
			textskill12.innerHTML +="<a style='color:#1F90FF'>+" + blast_cannon_c[skill12] + "% к получаемому Физич. урону в теч. 4 сек.</a><br \/>";
			textskill12.innerHTML +="<a style='color:#1F90FF'>+" + blast_cannon_c[skill12] + "% к получаемому Огнен. урону в теч. 4 сек.</a><br \/>";
		 }
		  if (skill12 >= 5) {
			textskill12.innerHTML +="<a style='color:#1F90FF'>"+blast_cannon_b[skill12] + "% шанс ослепить цель на 4 сек.</a><br \/>";
				}
		 	textskill12.innerHTML +=texttemp+"Шанс ослепить врагов на 4 сек.: 25%<br></a>";
		 	textskill12.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill12.innerHTML +=texttemp+"Шанс ослепить врагов на 4 сек.: 50%<br></a>";
		 	textskill12.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill12.innerHTML +=texttemp+"Шанс ослепить врагов на 4 сек.: 75%<br/></a>";
		 	textskill12.innerHTML +="<br/><a style='color:#ffff00'>Необходима пушка</a><br/>";
		 
      	var spider_mines_dam_physical = Math.ceil(spider_mines_b[skill13] * damage_minion_bylevel[level] / 100);
		var spider_mines_dam_fire =  Math.ceil(spider_mines_c[skill13] * damage_minion_bylevel[level] / 100) * 3;
		    textskill13.innerHTML = "<img src='/pic/skills/skillicon_spidermine.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Мины-пауки</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill13+"/15<br/><br/>";
			textskill13.innerHTML +="<br/>Три робота-паука подбегают к ближайшим врагам и взрываются; радиус взрыва составляет 3 метра. Усовершенствованные роботы наносят на 20% больше повреждений; радиус их взрыва составляет 5 метров, время оглушения цели 2 сек., доп. урон электричеством.</a><br/>";
		 	textskill13.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill13+"</a><br>";
		 	textskill13.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+spider_mines_mana[skill13-1]+"</a><br>";

	  		textskill13.innerHTML +="<a style='color:#FF00FF'>Время между активациями:&nbsp;"+spider_mines_f[skill13]+" сек.</a><br>";
	        textskill13.innerHTML +="<a style='color:#1F90FF'>"+spider_mines_a[skill13] + "%-шанс взрыва усовершенствованного робота</a><br \/>";
			textskill13.innerHTML +="<a style='color:#1F90FF'>Помощники наносят " + spider_mines_dam_physical + " Физич. урона*</a><br \/>";
			textskill13.innerHTML +="<a style='color:#1F90FF'>Помощники наносят " + spider_mines_dam_fire + " Огнен. урона в теч. 3 сек.*</a><br \/>";
			textskill13.innerHTML +="<a style='color:#1F90FF'>Время вызова: "+spider_mines_d[skill13] + " сек.</a><br \/>";		
		 	textskill13.innerHTML +=texttemp+"Затраты маны снижены на 20%<br></a>";
		 	textskill13.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill13.innerHTML +=texttemp+"Затраты маны снижены на 40%<br></a>";
		 	textskill13.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill13.innerHTML +=texttemp+"Затраты маны снижены на 60%<br/></a>";
		 	textskill13.innerHTML +="<br/><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		 
	    var gun_bot_mindam = Math.ceil(gun_bot_b[skill14] * damage_minion_bylevel[level] / 100);
		var gun_bot_maxdam = Math.ceil(gun_bot_c[skill14] * damage_minion_bylevel[level] / 100);
		    textskill14.innerHTML = "<img src='/pic/skills/skillicon_gunturret.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Робот-артиллерист</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill14+"/15<br/><br/>";
			textskill14.innerHTML +="<br/>Вы выпускаете на поле боя небольшого робота, который производит 5 выстрелов в сек. по врагам. С каждым новым уровнем навыка урон, наносимый роботом, повышается.</a><br/>";
		 	textskill14.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill14+"</a><br>";
		 	textskill14.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+gun_bot_mana[skill14-1]+"</a><br>";
            textskill14.innerHTML +="<a style='color:#FF00FF'>Время между активациями:&nbsp;"+gun_bot_e[skill14]+" мин.</a><br>";
            textskill14.innerHTML +="<a style='color:#1F90FF'>Время вызова: 1 мин.</a><br \/>";
		if (skill14 >= 2)
		 {	textskill14.innerHTML +="<a style='color:#1F90FF'>+" + gun_bot_a[skill14] + "% к люб. урону</a><br \/>"; }

			textskill14.innerHTML +="<a style='color:#1F90FF'>Помощники наносят " + gun_bot_mindam + "-" + gun_bot_maxdam + " Физич. урона*</a><br \/>";
	 	 	textskill14.innerHTML +=texttemp+"Радиус обстрела увеличен вдвое.<br>Время между активациями сокращено до 2.5 мин.<br></a>";
		 	textskill14.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill14.innerHTML +=texttemp+"Меткие выстрелы пронзают врагов.<br>Время между активациями сокращено до 2 мин.<br></a>";
		 	textskill14.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill14.innerHTML +=texttemp+"Интенсивность обстрела утраивается.<br>Время между активациями сокращено до 1.5 мин.<br/></a>";
		 	textskill14.innerHTML +="<br><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		 
        var shock_grenade_mindam = Math.ceil(shock_grenade_d[skill15] * damage_monster[level] / 100) * 4;
		var shock_grenade_maxdam = Math.ceil(shock_grenade_e[skill15] * damage_monster[level] / 100) * 4;
		  	textskill15.innerHTML = "<img src='/pic/skills/skillicon_shockgrenade.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Шоковая граната</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill15+"/15<br/><br/>";
			textskill15.innerHTML +="<br/>Вы бросаете гранату, взрыв которой наносит урон электричеством и оглушает врагов в радиусе 4 м. Для двух дополнительных гранат требуется один Заряд.</a><br/>";
		 	textskill15.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill15+"</a><br>";
		 	textskill15.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+shock_grenade_mana[skill15-1]+"</a><br>";
            textskill15.innerHTML +="<a style='color:#1F90FF'>"+shock_grenade_a[skill15] + "% шанс бить цель током в теч. 4 сек.</a><br \/>";
			textskill15.innerHTML +="<a style='color:#1F90FF'>"+shock_grenade_b[skill15] + "% шанс оглушить цель на " + shock_grenade_c[skill15] + " сек.</a><br \/>";
			textskill15.innerHTML +="<a style='color:#1F90FF'>Электр. урон: "+shock_grenade_mindam + "-" + shock_grenade_maxdam + " в теч. 4 сек.*</a><br \/>";
			textskill15.innerHTML +="<a style='color:#1F90FF'>+100% шанс прервать действия врага</a><br \/>";
		 	textskill15.innerHTML +=texttemp+"Радиус действия шоковой гранаты до 5 м<br></a>";
		 	textskill15.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill15.innerHTML +=texttemp+"Время оглушения шоковой гранатой до 5 сек.<br></a>";
		 	textskill15.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill15.innerHTML +=texttemp+"Радиус действия шоковой гранаты увеличен до 6 м, эффект оглушения - до 6 сек.<br/></a>";
		 	textskill15.innerHTML +="<br><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		 
			textskill16.innerHTML = "<img src='/pic/skills/skillicon_fusillade.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Расстрел</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill16+"/15<br/><br/>";
			textskill16.innerHTML +="<br/>Вы непрерывно обстреливаете противника ракетами дальнего действия. Пока вы удерживаете кнопку мышки, персонаж стреляет залпами по 2 ракеты.</a><br/>";
		 	textskill16.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill16+"</a><br>";
		 	textskill16.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+fusillade_mana[skill16-1]+" в сек.</a><br>";
		    textskill16.innerHTML +="<a style='color:#1F90FF'>Наносит " + fusillade_a[skill16] + "% от урона текущего оружия в сек. Огнем</a><br \/>";
		   	textskill16.innerHTML +=texttemp+"В каждом залпе 3 ракеты.<br></a>";
		 	textskill16.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill16.innerHTML +=texttemp+"Ракеты взрываются в радиусе 3 м<br></a>";
		 	textskill16.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill16.innerHTML +=texttemp+"В каждом залпе 4 ракеты.<br/></a>";
		 	//textskill16.innerHTML +="<br/><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		 	textskill16.innerHTML +="<br/><a style='color:#ffff00'>Необходима пушка</a><br/>";
		 
            var sledgebot_mindam = Math.ceil(sledgebot_c[skill17] * damage_minion_bylevel[level] / 100);
		var sledgebot_maxdam = Math.ceil(sledgebot_d[skill17] * damage_minion_bylevel[level] / 100);
		    textskill17.innerHTML = "<img src='/pic/skills/skillicon_hammerbot.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Робот-кувалда</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill17+"/15<br/><br/>";
			textskill17.innerHTML +="<br/>Вы создаете мощного робота-кувалду, который превращает врагов в кашицу.</a><br/>";
		 	textskill17.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill17+"</a><br>";
		 	textskill17.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+sledgebot_mana[skill17-1]+"</a><br>";
		 	textskill17.innerHTML +="<a style='color:#FF00FF'>Время между активациями: 1.5 мин.</a><br>";
            textskill17.innerHTML +="<a style='color:#1F90FF'>Время вызова: "+sledgebot_a[skill17] + " сек.</a><br \/>";
		if (skill17>=2)
			{
			textskill17.innerHTML +="<a style='color:#1F90FF'>+" + sledgebot_b[skill17] + "% к люб. урону</a><br \/>";
			textskill17.innerHTML +="<a style='color:#1F90FF'>+" + sledgebot_b[skill17] + "% к люб. броне</a><br \/>";
			}
			textskill17.innerHTML +="<a style='color:#1F90FF'>Помощники наносят " + sledgebot_mindam + "-" + sledgebot_maxdam + " Physical Damage*</a><br \/>";
 		 	textskill17.innerHTML +=texttemp+"Робот-кувалда приобретает круговую атаку<br></a>";
		 	textskill17.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill17.innerHTML +=texttemp+"Робот-кувалда приобретает сокрушающую атаку<br></a>";
		 	textskill17.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill17.innerHTML +=texttemp+"Робот-кувалда атакует врагов ракетами<br/></a>";
		 	textskill17.innerHTML +="<br/><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		
		    textskill18.innerHTML = "<img src='/pic/skills/skillicon_armor.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Бастион (Пассивный навык)</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill18+"/15<br/><br/>";
			textskill18.innerHTML +="<br/>Опыт обращения с доспехами позволяет использовать их максимально эффективно. Урон, наносимый врагами, уменьшается.</a><br/>";
		 	textskill18.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill18+"</a><br>";
			textskill18.innerHTML +="<a style='color:#1F90FF'>+" + bulwark_a[skill18] + "% к Физич. броне</a><br \/>";
			textskill18.innerHTML +="<a style='color:#1F90FF'>-" + bulwark_b[skill18] + "% от получаемого Физич. урона</a><br \/>";
		 
		    textskill19.innerHTML = "<img src='/pic/skills/skillicon_fireandspark.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Искра и огонь (Пассивный навык)</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill19+"/15<br/><br/>";
			textskill19.innerHTML +="<br/>Искра, чтобы все заработало... а огонь - чтобы все сдохли.</a><br/>";
		 	textskill19.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill19+"</a><br>";
			textskill19.innerHTML +="<a style='color:#1F90FF'>+" + fire_and_spark_a[skill19] + "% к Огнен. урону</a><br \/>";
			textskill19.innerHTML +="<a style='color:#1F90FF'>+" + fire_and_spark_a[skill19] + "% к Электр. урону</a><br \/>";
		
		    textskill20.innerHTML = "<img src='/pic/skills/skillicon_chargedomination.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Доминирование (Пассивный навык)</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill20+"/15<br/><br/>";
			textskill20.innerHTML +="<br/>После смерти врага у вас появляется возможность поглотить его энергию и заполнить индикатор Заряда. Перерыв между применениями способности 3 сек.</a><br/>";
		 	textskill20.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill20+"</a><br>";
		    textskill20.innerHTML +="<a style='color:#1F90FF'>Шанс пополнить заряд: "+charge_domination_a[skill20] + "%</a><br \/>";
		   
		    textskill21.innerHTML = "<img src='/pic/skills/skillicon_shieldbash.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Удар щитом</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill21+"/15<br/><br/>";
			textskill21.innerHTML +="<br/>Вы бьете щитом находящихся перед вами врагов, оглушая и отбрасывая их, а также замедляя атаки. Урон в 5 раз больше показателя брони щита. Каждый Заряд увеличивает урон на 10%.</a><br/>";
		 	textskill21.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill21+"</a><br>";
		 	textskill21.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+shield_bash_mana[skill21-1]+"</a><br>";
		    textskill21.innerHTML +="<a style='color:#1F90FF'>" + shield_bash_a[skill21] + " Заряда за каждый удар</a><br \/>";
			textskill21.innerHTML +="<a style='color:#1F90FF'>"+shield_bash_b[skill21] + "% шанс оглушить цель на " + shield_bash_c[skill21] + " сек.</a><br \/>";
			textskill21.innerHTML +="<a style='color:#1F90FF'>+25 к отбрасыванию</a><br \/>";
			textskill21.innerHTML +="<a style='color:#1F90FF'>-" + shield_bash_d[skill21] + "% от скорости атаки в теч. 2 сек.</a><br \/>";
		  	textskill21.innerHTML +=texttemp+"Урон в 7,5 раз больше показателя брони<br></a>";
		 	textskill21.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill21.innerHTML +=texttemp+"Урон в 10 раз больше показателя брони<br></a>";
		 	textskill21.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill21.innerHTML +=texttemp+"Урон в 12,5 раз больше показателя брони<br/></a>";
		    textskill21.innerHTML +="<br><a style='color:#ffff00'>Необходимо держать в руках щит</a><br>";
		 
        var forcefield_absorb = Math.ceil(forcefield_a[skill22] * health_monster_bylevel[level] / 100);
		    textskill22.innerHTML = "<img src='/pic/skills/skillicon_forcefield.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Силовое поле</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill22+"/15<br/><br/>";
			textskill22.innerHTML +="<br/>Ваши доспехи излучают эмберитовую энергию, которая образует защитное поле вокруг вас и (вдвое слабее) вокруг ваших союзников. Нейтрализовав определенное количество урона, защитное поле исчезает. Силовое поле использует все доступные Заряды; поглощаемый урон увеличивается на 50% за каждый Заряд.</a><br/>";
		 	textskill22.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill22+"</a><br>";
		 	textskill22.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+forcefield_mana[skill22-1]+"</a><br>";
		 	textskill22.innerHTML +="<a style='color:#FF00FF'>Время между активациями: 8 сек.</a><br>";
		    textskill22.innerHTML +="<a style='color:#1F90FF'>Поглощение "+forcefield_absorb + " очков Люб. урона в теч. 30 сек.*</a><br \/>";
		 if (skill22>=2){textskill22.innerHTML +="<a style='color:#1F90FF'>Сопротивление отбрасыванию: "+forcefield_b[skill22] + "%</a><br \/>";}		
		 	textskill22.innerHTML +=texttemp+"Затраты маны и время применения снижены на 20%<br></a>";
		 	textskill22.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill22.innerHTML +=texttemp+"Союзники получают полноценный щит<br></a>";
		 	textskill22.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill22.innerHTML +=texttemp+"Затраты маны и время применения снижены на 50%<br/></a>";
		 	textskill22.innerHTML +="<br/><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		
        var overload_mindam = Math.ceil(overload_b[skill23] * damage_monster[level] / 100);
		var overload_maxdam = Math.ceil(overload_c[skill23] * damage_monster[level] / 100);
		  	textskill23.innerHTML = "<img src='/pic/skills/skillicon_overload.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Перегрузка</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill23+"/15<br/><br/>";
			textskill23.innerHTML +="<br/>Вы перегружаете электрические цепи брони, создавая мощный разряд эмберитовой энергии, который наносит электрический удар 5 врагам в радиусе 6 метров. При перегрузке расходуются все доступные Заряды; наносимый урон увеличивается на 50% за каждый Заряд.</a><br/>";
		 	textskill23.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill23+"</a><br>";
		 	textskill23.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+overload_mana[skill23-1]+"</a><br>";
		    textskill23.innerHTML +="<a style='color:#FF00FF'>Время между активациями: 1.4 сек.</a><br>";
		    textskill23.innerHTML +="<a style='color:#1F90FF'>Наносит " + overload_a[skill23] + "% от урона текущего оружия в сек.</a><br \/>";
			textskill23.innerHTML +="<a style='color:#1F90FF'>"+overload_mindam + "-" + overload_maxdam + " к Электр. урону*</a><br \/>";
			textskill23.innerHTML +="<a style='color:#1F90FF'>+50 к отбрасыванию</a><br \/>";
		if (skill23>=2){textskill23.innerHTML +="<a style='color:#1F90FF'>"+overload_d[skill23] + "% шанс оглушить цель на 2 сек.</a><br \/>";}
		 	textskill23.innerHTML +=texttemp+"Электроудар: до 7 врагов в радиусе 8 м<br></a>";
		 	textskill23.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill23.innerHTML +=texttemp+"Электроудар: до 9 врагов в радиусе 10 м<br></a>";
		 	textskill23.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill23.innerHTML +=texttemp+"Электроудар: до 11 врагов в радиусе 12 м<br/></a>";
		 	textskill23.innerHTML +="<br/><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		
      var dynamo_field_dam = Math.ceil(dynamo_field_b[skill24] * damage_monster[level] / 100) * 2;
		    textskill24.innerHTML = "<img src='/pic/skills/skillicon_dynamofield.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Магнитное поле</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill24+"/15<br/><br/>";
			textskill24.innerHTML +="<br/>Вы преобразуете энергию своей брони в электрический разряд, который поражает врагов в радиусе 5 метров. За каждого врага, которому нанесен урон (до 5), ваш уровень заряда повышается.</a><br/>";
		 	textskill24.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill24+"</a><br>";
		 	textskill24.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+dynamo_field_mana[skill24-1]+"</a><br>";
		    textskill24.innerHTML +="<a style='color:#1F90FF'>" + dynamo_field_a[skill24] + " Заряда за каждого получившего урон врага</a><br \/>";
			textskill24.innerHTML +="<a style='color:#1F90FF'>"+dynamo_field_dam + " Электр. урона в теч. 2 сек.*</a><br \/>";
			textskill24.innerHTML +="<a style='color:#1F90FF'>+" + dynamo_field_c[skill24] + "% шанс прервать действия врага</a><br \/>";
		 	textskill24.innerHTML +=texttemp+"Радиус поля: 7 м;<br>вероятность прерывания: 70%.<br></a>";
		 	textskill24.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill24.innerHTML +=texttemp+"Радиус поля: 9 м;<br>вероятность прерывания: 90%.<br></a>";
		 	textskill24.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill24.innerHTML +=texttemp+"Радиус поля: 11 м;<br>вероятность прерывания: 110%.<br/></a>";
		 	textskill24.innerHTML +="<br/><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
		 
       		textskill25.innerHTML = "<img src='/pic/skills/skillicon_tremor.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Землетрясение</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill25+"/15<br/><br/>";
			textskill25.innerHTML +="<br/>Вы выпускаете поток энергии из костюма в землю, создавая мощную ударную волну, которая сбивает с ног и ослабляет врагов в пределах 24 метров. Данный эффект достигается только в том случае, если израсходован один Заряд.</a><br/>";
		 	textskill25.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill25+"</a><br>";
		 	textskill25.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+tremor_mana[skill25-1]+"</a><br>";
		 	textskill25.innerHTML +="<a style='color:#FF00FF'>Время между активациями: 10 сек.</a><br>";
			textskill25.innerHTML +="<a style='color:#1F90FF'>Наносит " + tremor_a[skill25] + "% от урона текущего оружия в сек.</a><br \/>";
			textskill25.innerHTML +="<a style='color:#1F90FF'>+30 к отбрасыванию</a><br \/>";
			textskill25.innerHTML +="<a style='color:#1F90FF'>"+tremor_b[skill25] + "% шанс прервать действия врага</a><br \/>";
			textskill25.innerHTML +="<a style='color:#1F90FF'>-" + tremor_c[skill25] + "% от Физич. урона в теч. 10 сек.</a><br \/>";
				if (skill25 >= 5) {
			textskill25.innerHTML +="<a style='color:#1F90FF'>"+tremor_d[skill25] + "% шанс обратить цель в бегство на 10 сек.</a><br \/>";
				}
				if (skill25 >= 10) {
			textskill25.innerHTML +="<a style='color:#1F90FF'>-" + tremor_e[skill25] + "% от Физич. урона в теч. 10 сек.</a><br \/>";
				}
				if (skill25 >= 15) {
			textskill25.innerHTML +="<a style='color:#1F90FF'>"+tremor_f[skill25] + "% шанс оглушить цель на 2 сек.</a><br \/>";
				}			 
		 	textskill25.innerHTML +=texttemp+"В 20% случаев заклинание на 10 секунд обращает врагов в бегство<br></a>";
		 	textskill25.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill25.innerHTML +=texttemp+"Ослабленные враги наносят на 20% меньше физического урона<br></a>";
		 	textskill25.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill25.innerHTML +=texttemp+"Все цели оглушены на 2 секунды<br/></a>";
		 
        	textskill26.innerHTML = "<img src='/pic/skills/skillicon_firebash.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Огненный удар</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill26+"/15<br/><br/>";
			textskill26.innerHTML +="<br/>С помощью щита вы направляете на врага мощный поток энергии на расстояние 6 метров. Наносимый урон зависит от показателя брони щита. При использовании одного Заряда физический урон утраивается, радиус действия увеличивается до 9 метров.</a><br/>";
		 	textskill26.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill26+"</a><br>";
		 	textskill26.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+fire_bash_mana[skill26-1]+"</a><br>";
		    textskill26.innerHTML +="<a style='color:#1F90FF'>"+fire_bash_a[skill26] + "% к урону</a><br \/>";
			textskill26.innerHTML +="<a style='color:#1F90FF'>+35 к отбрасыванию</a><br \/>";
				if (skill26 >= 15) {
			textskill26.innerHTML +="<a style='color:#1F90FF'>-" + fire_bash_b[skill26] + "% от Огнен. урона в теч. 5 сек.</a><br \/>";
				}
            textskill26.innerHTML +=texttemp+"Время горения увеличено до 5 сек.<br></a>";
		 	textskill26.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill26.innerHTML +=texttemp+"Угол сектора увеличен на 40 градусов<br></a>";
		 	textskill26.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill26.innerHTML +=texttemp+"Горящие цели получают на 50% огненного урона больше<br/></a>";
		 	textskill26.innerHTML +="<br/><a style='color:#ffff00'>Необходимо держать в руках щит.</a><br>";
		 
        var immobilization_copter_damage = Math.floor(Math.ceil(immobilization_copter_c[skill27] * damage_minion_bylevel[level] / 100) * 0.15);
        	textskill27.innerHTML = "<img src='/pic/skills/skillicon_slowcopter.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Обездвижив. вертолет</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill27+"/15<br/><br/>";
			textskill27.innerHTML +="<br/>Вы выпускаете вертолет, который обездвиживает врагов своим лучом. Одновременно можно воздействовать на 3 цели.</a><br/>";
		 	textskill27.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill27+"</a><br>";
		 	textskill27.innerHTML +="<a style='color:#FF00FF'>Расход маны:&nbsp;"+immobilization_copter_mana[skill27-1]+"</a><br>";
		 	textskill27.innerHTML +="<a style='color:#FF00FF'>Время между активациями: 10 сек.</a><br>";
		    textskill27.innerHTML +="<a style='color:#1F90FF'>-" + immobilization_copter_a[skill27] + "% от скорости движения в теч. 0.2 сек.</a><br \/>";
			textskill27.innerHTML +="<a style='color:#1F90FF'>-" + immobilization_copter_b[skill27] + "% от скорости атаки в теч. 0.2 сек.</a><br \/>";
			textskill27.innerHTML +="<a style='color:#1F90FF'>-" + immobilization_copter_b[skill27] + "% от скорости применения заклинаний в теч. 0.2 сек.</a><br \/>";
				if (skill27 >= 10) {
			textskill27.innerHTML +="<a style='color:#1F90FF'>" + immobilization_copter_damage + " к Электр. урона в теч. 0.2 сек.*</a><br \/>";
				}
				if (skill27 >= 15) {
			textskill27.innerHTML +="<a style='color:#1F90FF'>+" + immobilization_copter_d[skill27] + "% шанс прервать действия врага</a><br \/>";
				}
		 	textskill27.innerHTML +=texttemp+"Одновременно можно воздействовать на 5 целей<br></a>";
		 	textskill27.innerHTML +=texttemp2+"Преимущество II уровня<br></a>";
		 	textskill27.innerHTML +=texttemp+"Замедленные враги также получают урон электричеством<br></a>";
		 	textskill27.innerHTML +=texttemp2+"Преимущество III уровня<br></a>";
		 	textskill27.innerHTML +=texttemp+"Действия целей постоянно прерываются<br/></a>";
			
		    textskill28.innerHTML = "<img src='/pic/skills/skillicon_swordandboard.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Щит и меч (Пассивный навык)</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill28+"/15<br/><br/>";
			textskill28.innerHTML +="<br/>Умение обращаться со щитом переходит из категории &quot;защита&quot; в категорию &quot;нападение&quot;. Ваши атаки в ближнем бою наносят дополнительный урон, напрямую зависящий от показателя брони вашего щита.</a><br/>";
		 	textskill28.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill28+"</a><br>";
		   	textskill28.innerHTML +="<a style='color:#1F90FF'>Урон в рукопашной: +"+sword_and_board_a[skill28] + "% от параметра брони щита</a><br \/>";
		    textskill28.innerHTML +="<br/><a style='color:#ffff00'>Необходим щит и любое оружие ближнего боя</a><br>";
             * 
		    textskill29.innerHTML = "<img src='/pic/skills/skillicon_aegis_of_fate.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Эгида судьбы (Пассивный навык)</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill29+"/15<br/><br/>";
			textskill29.innerHTML +="<br/>При атаке врагов броня может окружить вас защитной сферой, которая предотвратит нанесение урона. Эта сфера способна нейтрализовать урон, который на 100 ед. больше показателя брони, умноженного на два. Пока эффект действует, ваша устойчивость к отбрасыванию повышается на 50%.</a><br/>";
		 	textskill29.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill29+"</a><br>";
		    textskill29.innerHTML +="<a style='color:#1F90FF'>"+aegis_of_fate_a[skill29] + "% шанс сотворить заклинание &quot;Эгида&quot; при получении удара</a><br \/>";		

       var charge_reconstitution_hp_regen = Math.ceil(Math.ceil(charge_reconstitution_a[skill30] * health_player_generic[level] / 100 * 2) / 62.5);
            textskill30.innerHTML = "<img src='/pic/skills/skillicon_charge_of_recon.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'>&nbsp;Конвертация заряда (Пассивный навык)</a><br/><a style='color:#ffffff; font-size: 13px;'>&nbsp;Ур. "+skill30+"/15<br/><br/>";
			textskill30.innerHTML +="<br/>При использовании Заряда на применение навыков вы частично восстанавливаете здоровье.</a><br/>";
		 	textskill30.innerHTML +="<a style='color:#C3C300'>Текущий ур.:&nbsp;"+skill30+"</a><br>";
		  	textskill30.innerHTML +="<a style='color:#1F90FF'>Восполняется "+charge_reconstitution_hp_regen + " ед. здоровья в теч. 2 сек.*</a><br \/>";		  
			textskill30.innerHTML +="<br/><a style='color:#1F90FF; font-size: 10px;'>*улучшается вместе с уровнем игрока</a><br>";
        }
*/
        }
    }
}