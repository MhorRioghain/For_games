using System;

namespace Skill_Calculator
{
    public class Outlander
    {
        public int skillpointsleft, level, fame, statpointsleft;
        public double strength = 10, dexterity = 15, focus = 10, vitality = 5;
        public string strength_text, dexterity_text, focus_text, vitality_text;

        public string[] fame_ranks = { "2000", "3000", "4000", "5000", "7000", "9000", "12000", "14000", "16000", "18000", "19000", "22000", "23000", "26000", "27000", "29000", "31000", "34000", "35000", "37000", "40000", "41000", "44000", "46000", "48000", "50000", "52000", "55000", "56000", "59000", "62000", "63000", "9005000", "full" };

        double[] armor_player_bylevel_forset = { 0, 8, 10, 12, 14, 17, 20, 22, 25, 28, 31, 34, 37, 40, 43, 46, 50, 53, 56, 60, 63, 67, 70, 74, 77, 81, 85, 88, 92, 96, 100, 103, 107, 111, 115, 119, 123, 127, 131, 135, 139, 143, 147, 151, 155, 159, 163, 167, 171, 176, 180, 184, 188, 192, 197, 201, 205, 209, 214, 218, 222, 226, 231, 235, 239, 244, 248, 253, 257, 261, 266, 270, 274, 279, 283, 288, 292, 297, 301, 305, 310, 314, 319, 323, 328, 332, 337, 341, 346, 350, 355, 359, 364, 368, 373, 377, 382, 386, 391, 395, 400, 405, 409, 414, 418, 423 };
        double[] damage_minion_bylevel = { 0, 24, 30, 37, 44, 51, 58, 66, 74, 83, 92, 101, 110, 120, 131, 142, 153, 164, 177, 189, 202, 215, 229, 243, 258, 273, 288, 304, 321, 338, 355, 373, 392, 411, 430, 450, 471, 492, 514, 536, 558, 582, 605, 630, 655, 680, 706, 733, 760, 788, 817, 846, 876, 906, 937, 968, 1001, 1034, 1067, 1101, 1136, 1172, 1208, 1245, 1283, 1321, 1360, 1400, 1440, 1481, 1523, 1566, 1609, 1653, 1698, 1744, 1790, 1837, 1885, 1934, 1984, 2034, 2085, 2137, 2190, 2243, 2297, 2353, 2409, 2466, 2523, 2582, 2641, 2701, 2763, 2825, 2888, 2951, 3016, 3082, 3148, 3216, 3284, 3353, 3423, 3495 };
        double[] damage_monster = { 0, 10, 14, 19, 23.9, 29, 34.5, 40.200001, 46.299999, 52.599998, 59.299999, 66.400002, 73.800003, 81.5, 89.599998, 98.099998, 106.900002, 116.099998, 125.699997, 135.699997, 146.100006, 157, 168.199997, 179.899994, 192, 204.600006, 217.699997, 231.199997, 245.199997, 259.600006, 274.600006, 290.100006, 306.100006, 322.600006, 339.600006, 357.200012, 375.299988, 394, 413.299988, 433.100006, 453.600006, 474.600006, 496.200012, 518.5, 541.400024, 564.900024, 589.099976, 613.900024, 639.400024, 665.599976, 692.5, 720, 748.299988, 777.299988, 807, 837.5, 868.700012, 900.700012, 933.5, 967, 1001.400024, 1036.5, 1072.5, 1109.300049, 1147, 1185.5, 1224.800049, 1265.099976, 1306.199951, 1348.199951, 1391.099976, 1435, 1479.800049, 1525.5, 1572.199951, 1619.900024, 1668.5, 1718.099976, 1768.800049, 1820.400024, 1873.099976, 1926.900024, 1981.699951, 2037.5, 2094.5, 2152.5, 2211.600098, 2271.899902, 2333.300049, 2395.800049, 2459.5, 2524.300049, 2590.399902, 2657.600098, 2726.100098, 2795.800049, 2866.699951, 2938.800049, 3012.300049, 3087, 3163, 3240.300049, 3318.899902, 3398.800049, 3480.100098, 3562.800049 };
        double[] armor_monster_bylevel = { 0, 4, 7, 8, 11, 14, 18, 21, 25, 28, 32, 37, 41, 46, 50, 55, 61, 66, 72, 77, 83, 90, 96, 102, 109, 116, 123, 131, 138, 146, 154, 162, 170, 179, 188, 196, 206, 215, 224, 234, 244, 254, 264, 275, 286, 296, 307, 319, 330, 342, 354, 366, 378, 390, 403, 416, 429, 442, 456, 469, 483, 497, 511, 526, 540, 555, 570, 585, 601, 616, 632, 648, 664, 680, 697, 714, 731, 748, 765, 783, 800, 818, 836, 855, 873, 892, 911, 930, 949, 969, 988, 1008, 1028, 1049, 1069, 1090, 1111, 1132, 1153, 1175, 1196, 1218, 1240, 1262, 1285, 1307 }; double[] eviscerate_a = { 0, 88, 91, 94, 97, 100, 103, 106, 109, 112, 115, 118, 121, 124, 127, 130 };
        double[] mana_player_generic = { 0, 47.5, 48.5, 49.5, 50.5, 51.5, 52.5, 53.5, 54.5, 55.5, 56.5, 57.5, 58.5, 59.5, 60.5, 61.5, 62.5, 63.5, 64.5, 65.5, 66.5, 67.5, 68.5, 69.5, 70.5, 71.5, 72.5, 73.5, 74.5, 75.5, 76.5, 77.5, 78.5, 79.5, 80.5, 81.5, 82.5, 83.5, 84.5, 85.5, 86.5, 87.5, 88.5, 89.5, 90.5, 91.5, 92.5, 93.5, 94.5, 95.5, 96.5, 97.5, 98.5, 99.5, 100.5, 101.5, 102.5, 103.5, 104.5, 105.5, 106.5, 107.5, 108.5, 109.5, 110.5, 111.5, 112.5, 113.5, 114.5, 115.5, 116.5, 117.5, 118.5, 119.5, 120.5, 121.5, 122.5, 123.5, 124.5, 125.5, 126.5, 127.5, 128.5, 129.5, 130.5, 131.5, 132.5, 133.5, 134.5, 135.5, 136.5, 137.5, 138.5, 139.5, 140.5, 141.5, 142.5, 143.5, 144.5, 145.5, 146.5 }; double[] health_player_generic = { 0, 200, 240, 280, 320, 360, 400, 440, 480, 520, 560, 600, 640, 680, 720, 760, 800, 840, 880, 920, 960, 1000, 1040, 1080, 1120, 1160, 1200, 1240, 1280, 1320, 1360, 1400, 1440, 1480, 1520, 1560, 1600, 1640, 1680, 1720, 1760, 1800, 1840, 1880, 1920, 1960, 2000, 2040, 2080, 2120, 2160, 2200, 2240, 2280, 2320, 2360, 2400, 2440, 2480, 2520, 2560, 2600, 2640, 2680, 2720, 2760, 2800, 2840, 2880, 2920, 2960, 3000, 3040, 3080, 3120, 3160, 3200, 3240, 3280, 3320, 3360, 3400, 3440, 3480, 3520, 3560, 3600, 3640, 3680, 3720, 3760, 3800, 3840, 3880, 3920, 3960, 4000, 4040, 4080, 4120, 4160, 4200, 4240, 4280, 4320, 4360 }; double[] rapid_fire_a = { 0, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53 };

        public int rapid_fire_lvl = 0;
        public string rapid_fire_text;
        double[] rapid_fire_b = { 0, 2.6, 2.8, 3, 3.2, 3.4, 3.6, 3.8, 4, 4.2, 4.4, 4.6, 4.8, 5, 5.2, 5.4 };
        double[] rapid_fire_c = { 0, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 };
        double[] rapid_fire_mana = { 0, 12, 13, 14, 15, 17, 19, 21, 23, 26, 29, 33, 37, 41, 46, 51 };
        public string[] rapid_fire_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int rune_vault_lvl = 0;
        public string rune_vault_text;
        double[] rune_vault_a = { 0, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52 };
        double[] rune_vault_b = { 0, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92 };
        double[] rune_vault_c = { 0, 3, 3, 3, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6 };
        double[] rune_vault_d = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 30, 30, 30, 30, 30 };
        double[] rune_vault_mana = { 0, 9, 10, 11, 12, 12, 13, 15, 16, 18, 20, 23, 24, 28, 31, 34 };
        public string[] rune_vault_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int chaos_burst_lvl = 0;
        public string chaos_burst_text;
        double[] chaos_burst_a = { 0, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68 };
        double[] chaos_burst_b = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 30, 30, 30, 30, 30, };
        double[] chaos_burst_mana = { 0, 12, 12, 12, 12, 13, 14, 15, 16, 18, 20, 22, 24, 27, 29, 32 };
        public string[] chaos_burst_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int cursed_daggers_lvl = 0;
        public string cursed_daggers_text;
        double[] cursed_daggers_a = { 0, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69 };
        double[] cursed_daggers_b = { 0, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34 };
        double[] cursed_daggers_c = { 0, 3, 3.3, 3.7, 4, 4.3, 4.7, 5, 5.3, 5.7, 6, 6.3, 6.7, 7, 7.3, 7.7 };
        double[] cursed_daggers_mana = { 0, 18, 19, 19, 19, 20, 21, 22, 24, 26, 28, 31, 34, 37, 40, 43 };
        public string[] cursed_daggers_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int vortex_hex_lvl = 0;
        public string vortex_hex_text;
        double[] vortex_hex_a = { 0, 0, 0, 0, 0, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };
        double[] vortex_hex_b = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
        double[] vortex_hex_c = { 0, 2, 4, 6, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };
        double[] vortex_hex_mana = { 0, 30, 31, 31, 32, 33, 34, 35, 37, 39, 43, 47, 51, 55, 60, 64 };
        public string[] vortex_hex_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int shattering_glaive_lvl = 0;
        public string shattering_glaive_text;
        double[] shattering_glaive_a = { 0, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
        double[] shattering_glaive_b = { 0, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195, 200 };
        double[] shattering_glaive_c = { 0, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60 };
        double[] shattering_glaive_d = { 0, 80, 85, 90, 95, 100, 105, 110, 115, 120, 125, 130, 135, 140, 145, 150 };
        double[] shattering_glaive_e = { 0, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 };
        double[] shattering_glaive_f = { 0, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11 };
        double[] shattering_glaive_g = { 0, 0, 0, 0, 0, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 };
        double[] shattering_glaive_mana = { 0, 16, 16, 16, 16, 17, 17, 18, 18, 20, 21, 23, 25, 27, 28, 30, 30 };
        public string[] shattering_glaive_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int venomous_hail_lvl = 0;
        public string venomous_hail_text;
        double[] venomous_hail_a = { 0, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92 };
        double[] venomous_hail_mana = { 0, 33, 34, 34, 35, 36, 37, 38, 40, 42, 45, 46, 49, 52, 55, 56 };
        public string[] venomous_hail_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int long_range_mastery_lvl = 0;
        public string long_range_mastery_text;
        double[] long_range_mastery_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
        double[] long_range_mastery_b = { 0, 0.33, 0.67, 1, 1.33, 1.67, 2, 2.33, 2.67, 3, 3.33, 3.67, 4, 4.33, 4.67, 5 };
        public string[] long_range_mastery_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int shotgonne_mastery_lvl = 0;
        public string shotgonne_mastery_text;
        double[] shotgonne_mastery_a = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60 };
        double[] shotgonne_mastery_b = { 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45 };
        double[] shotgonne_mastery_c = { 0, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90 };
        public string[] shotgonne_mastery_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int akimbo_lvl = 0;
        public string akimbo_text;
        double[] akimbo_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
        double[] akimbo_b = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
        public string[] akimbo_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int glaive_throw_lvl = 0;
        public string glaive_throw_text;
        double[] glaive_throw_a = { 0, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
        double[] glaive_throw_b = { 0, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190 };
        double[] glaive_throw_c = { 0, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53 };
        double[] glaive_throw_d = { 0, 2, 2.2, 2.4, 2.6, 2.8, 3, 3.2, 3.4, 3.6, 3.8, 4, 4.2, 4.4, 4.6, 4.8 };
        double[] glaive_throw_mana = { 0, 10, 11, 12, 13, 14, 16, 18, 20, 22, 25, 28, 31, 34, 38, 42 };
        public string[] glaive_throw_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int tangling_shot_lvl = 0;
        public string tangling_shot_text;
        double[] tangling_shot_a = { 0, 3, 3.2, 3.4, 3.6, 3.8, 4, 4.2, 4.4, 4.6, 4.8, 5, 5.2, 5.4, 5.6, 5.8 };
        double[] tangling_shot_b = { 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        double[] tangling_shot_c = { 0, 50, 50, 50, 50, 65, 65, 65, 65, 65, 80, 80, 80, 80, 80, 95 };
        double[] tangling_shot_d = { 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        double[] tangling_shot_mana = { 0, 11, 11, 11, 12, 12, 13, 14, 15, 17, 19, 22, 24, 26, 29, 31 };
        public string[] tangling_shot_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };
        
        public int glaive_sweep_lvl = 0;
        public string glaive_sweep_text;
        double[] glaive_sweep_a = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58 };
        double[] glaive_sweep_b = { 0, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 95 };
        double[] glaive_sweep_c = { 0, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
        double[] glaive_sweep_d = { 0, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12 };
        double[] glaive_sweep_mana = { 0, 12, 12, 13, 13, 14, 15, 16, 17, 19, 21, 24, 26, 28, 31, 34 };
        public string[] glaive_sweep_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int sandstorm_lvl = 0;
        public string sandstorm_text;
        double[] sandstorm_a = { 0, 1, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9, 2, 2.1, 2.2, 2.3, 2.4 };
        double[] sandstorm_b = { 0, 100, 104, 108, 112, 116, 120, 124, 128, 132, 136, 140, 144, 148, 152, 156 };
        double[] sandstorm_c = { 0, 150, 154, 158, 162, 166, 170, 174, 178, 182, 186, 190, 194, 198, 202, 206 };
        double[] sandstorm_mana = { 0, 18, 19, 19, 19, 21, 22, 23, 25, 27, 29, 32, 35, 38, 42, 45 };
        public string[] sandstorm_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int bramble_wall_lvl = 0;
        public string bramble_wall_text;
        double[] bramble_wall_a = { 0, 10, 13, 16, 19, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
        double[] bramble_wall_b = { 0, 0, 0, 0, 0, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 };
        double[] bramble_wall_c = { 0, 0, 0, 0, 0, 120, 130, 140, 150, 160, 170, 180, 190, 200, 210, 220 };
        double[] bramble_wall_mana = { 0, 29, 29, 29, 30, 30, 32, 33, 35, 37, 40, 44, 49, 51, 57, 61 };
        public string[] bramble_wall_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int burning_leap_lvl = 0;
        public string burning_leap_text;
        double[] burning_leap_a = { 0, 75, 80, 85, 90, 95, 100, 105, 110, 115, 120, 125, 130, 135, 140, 145 };
        double[] burning_leap_b = { 0, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
        double[] burning_leap_c = { 0, 4, 4.3, 4.5, 4.8, 5, 5.3, 5.5, 5.8, 6, 6.3, 6.5, 6.8, 7, 7.3, 7.5 };
        double[] burning_leap_mana = { 0, 34, 34, 35, 35, 36, 37, 39, 40, 42, 46, 49, 53, 57, 61, 65 };
        public string[] burning_leap_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int flaming_glaives_lvl = 0;
        public string flaming_glaives_text;
        double[] flaming_glaives_a = { 0, 70, 73, 76, 79, 82, 85, 88, 91, 94, 97, 100, 103, 106, 109, 112 };
        double[] flaming_glaives_b = { 0, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43 };
        double[] flaming_glaives_c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 30, 30, 30, 30, 45 };
        double[] flaming_glaives_mana = { 0, 25, 26, 26, 27, 27, 28, 29, 31, 32, 34, 36, 38, 40, 42, 44 };
        public string[] flaming_glaives_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int dodge_mastery_lvl = 0;
        public string dodge_mastery_text;
        double[] dodge_mastery_a = { 0, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32 };
        public string[] dodge_mastery_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int poison_burst_lvl = 0;
        public string poison_burst_text;
        double[] poison_burst_a = { 0, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92 };
        double[] poison_burst_b = { 0, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68 };
        public string[] poison_burst_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int share_the_wealth_lvl = 0;
        public string share_the_wealth_text;
        double[] share_the_wealth_a = { 0, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76 };
        public string[] share_the_wealth_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int blade_pact_lvl = 0;
        public string blade_pact_text;
        double[] blade_pact_a = { 0, 15, 17, 18, 20, 21, 23, 24, 26, 27, 29, 30, 32, 33, 35, 36 };
        double[] blade_pact_b = { 0, 15, 16.5, 18, 19.5, 21, 22.5, 24, 25.5, 27, 28.5, 30, 31.5, 33, 34.5, 36 };
        double[] blade_pact_c = { 0, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 }; 
        double[] blade_pact_mana = { 0, 10, 11, 12, 13, 14, 16, 18, 20, 22, 25, 28, 31, 34, 38, 42 };
        public string[] blade_pact_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int shadowshot_lvl = 0;
        public string shadowshot_text;
        double[] shadowshot_a = { 0, 76, 80, 84, 88, 92, 96, 100, 104, 108, 112, 116, 120, 124, 128, 132 };
        double[] shadowshot_b = { 0, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98, 100, 102, 104 };
        double[] shadowshot_mana = { 0, 11, 11, 11, 12, 12, 13, 14, 15, 17, 19, 22, 24, 26, 29, 31 };
        public string[] shadowshot_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int bane_breath_lvl = 0;
        public string bane_breath_text;
        double[] bane_breath_b = { 0, 32, 38, 45, 51, 58, 64, 70, 77, 83, 90, 96, 102, 109, 115, 122 };
        double[] bane_breath_d = { 0, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76 };
        double[] bane_breath_mana = { 0, 15, 15, 16, 16, 17, 18, 19, 21, 23, 26, 28, 31, 34, 37, 41 };
        public string[] bane_breath_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int repulsion_hex_lvl = 0;
        public string repulsion_hex_text;
        double[] repulsion_hex_a = { 0, 1, 0.95, 0.9, 0.85, 0.8, 0.75, 0.7, 0.65, 0.6, 0.55, 0.5, 0.45, 0.4, 0.35, 0.3 };
        double[] repulsion_hex_b = { 0, 40, 44, 48, 52, 56, 60, 64, 69, 72, 76, 80, 84, 88, 92, 96 };
        double[] repulsion_hex_c = { 0, 20, 23, 25, 28, 30, 33, 35, 38, 40, 43, 45, 48, 50, 53, 55 };
        double[] repulsion_hex_d = { 0, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80 };
        double[] repulsion_hex_e = { 0, 0, 0, 0, 0, 10, 10, 10, 10, 10, 20, 20, 20, 20, 20, 30 };
        double[] repulsion_hex_mana = { 0, 27, 27, 28, 28, 29, 31, 33, 35, 38, 41, 45, 49, 54, 59, 64 };
        public string[] repulsion_hex_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int stone_pact_lvl = 0;
        public string stone_pact_text;
        double[] stone_pact_a = { 0, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44 };
        double[] stone_pact_b = { 0, 0, 0, 0, 0, 25, 25, 25, 25, 25, 50, 50, 50, 50, 50, 75 };
        double[] stone_pact_c = { 0, 700, 750, 800, 850, 900, 950, 1000, 1050, 1100, 1150, 1200, 1250, 1300, 1350, 1400 };
        double[] stone_pact_mana = { 0, 21, 21, 21, 22, 22, 23, 24, 25, 27, 29, 32, 35, 37, 41, 44 };
        public string[] stone_pact_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int shadowmantle_lvl = 0;
        public string shadowmantle_text;
        double[] shadowmantle_a = { 0, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75 };
        double[] shadowmantle_b = { 0, 75, 75, 75, 75, 125, 125, 125, 125, 125, 175, 175, 175, 175, 175, 250 };
        double[] shadowmantle_c = { 0, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16 };
        double[] shadowmantle_mana = { 0, 23, 23, 24, 24, 25, 25, 26, 27, 29, 31, 34, 36, 39, 41, 44 };
        public string[] shadowmantle_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int shadowling_brute_lvl = 0;
        public string shadowling_brute_text;
        double[] shadowling_brute_a = { 0, 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };
        double[] shadowling_brute_mana = { 0, 25, 26, 26, 27, 27, 28, 29, 31, 32, 34, 36, 38, 40, 42, 44 };
        public string[] shadowling_brute_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int master_of_the_elements_lvl = 0;
        public string master_of_the_elements_text;
        double[] master_of_the_elements_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
        double[] master_of_the_elements_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60 };
        public string[] master_of_the_elements_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int shadowling_ammo_lvl = 0;
        public string shadowling_ammo_text;
        double[] shadowling_ammo_a = { 0, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68 };
        double[] shadowling_ammo_b = { 0, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40 };
        double[] shadowling_ammo_c = { 0, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60 };
        public string[] shadowling_ammo_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int death_ritual_lvl = 0;
        public string death_ritual_text;
        double[] death_ritual_a = { 0, 11.5, 13, 14.5, 16, 17.5, 19, 20.5, 22, 23.5, 25, 26.5, 28, 29.5, 31, 32.5 };
        double[] death_ritual_b = { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75 };
        public string[] death_ritual_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full"};

        double weapon_damage, critical_damage, double_chance, critical_chance, fumble_recovery,
            max_mana, magic_damage, execute_chance, max_health, armor_bonus, block_chance;

        public Outlander()
        {

        }

        public void calc()
        {
            skillpointsleft = (level + fame) - rapid_fire_lvl - rune_vault_lvl - chaos_burst_lvl - cursed_daggers_lvl - vortex_hex_lvl -
                shattering_glaive_lvl - venomous_hail_lvl - long_range_mastery_lvl - shotgonne_mastery_lvl - akimbo_lvl -
                glaive_throw_lvl - tangling_shot_lvl - glaive_sweep_lvl - sandstorm_lvl - bramble_wall_lvl -
                burning_leap_lvl - flaming_glaives_lvl - dodge_mastery_lvl - poison_burst_lvl - share_the_wealth_lvl -
                blade_pact_lvl - shadowshot_lvl - bane_breath_lvl - repulsion_hex_lvl - stone_pact_lvl -
                shadowmantle_lvl - shadowling_brute_lvl - master_of_the_elements_lvl - shadowling_ammo_lvl - death_ritual_lvl;
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
            
            int rapid_fire_armor = (int)Math.Floor(rapid_fire_c[rapid_fire_lvl] * armor_player_bylevel_forset[level] / 100);
            rapid_fire_text = "Град снарядов поражает цели в радиусе 7 м, отбрасывая врагов назад и лишая их брони." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + rapid_fire_mana[rapid_fire_lvl] + " в сек." + Environment.NewLine +
                "Наносит " + rapid_fire_a[rapid_fire_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                "+" + rapid_fire_b[rapid_fire_lvl] + " к отбрасыванию" + Environment.NewLine +
                "-" + rapid_fire_armor + " от всех видов брони в теч. 8 сек.*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "К каждому второму выстрелу добавляется неприцельный выстрел" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус увеличен до 12 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Цели горят в течение 4 секунд" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока" + Environment.NewLine + Environment.NewLine +
                "Необходим лук, арбалет, дробовик или пистоль.";

            rune_vault_text = "Вы ловко отпрыгиваете от цели, оставляя магический знак, который наносит урон врагам, находящимся в радиусе 4 м, и ослепляет их." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + rune_vault_mana[rune_vault_lvl] + Environment.NewLine +
                "Наносит " + rune_vault_a[rune_vault_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                rune_vault_b[rune_vault_lvl] + "% шанс ослепить цель на " + rune_vault_c[rune_vault_lvl] + " сек." + Environment.NewLine;
			if (rune_vault_lvl >= 10) 
            {
                rune_vault_text += "+" + rune_vault_d[rune_vault_lvl] + " к отбрасыванию";
            }
            rune_vault_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус действия магического знака увеличен до 5 м, ослепление длится до 4 сек. Позволяет похищать здоровье и ману." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Добавлено отбрасывание. Ослепление длится до 5 секунд. Не мешает применять способности, связанные с оружием." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус увеличен до 6 м; ослепление длится до 6 сек. Создает Заряд." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";            
            
            chaos_burst_text = "Атака тремя хаотически движущимися и рикошетящими снарядами." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + chaos_burst_mana[chaos_burst_lvl] + Environment.NewLine +
                "Наносит " + chaos_burst_a[chaos_burst_lvl] + "% от урона текущего оружия в сек.";
			if (chaos_burst_lvl >= 10) 
            {
			    chaos_burst_text += chaos_burst_b[chaos_burst_lvl] + "% шанс отравить цель на 5 сек.";
            }
            chaos_burst_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Скорость снаряда увеличена на 50%" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "В 30% случаев снаряд отравляет цель" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "2 дополнительных снаряда в каждом залпе";            
            
            int cursed_daggers_dam = (int)Math.Ceiling(cursed_daggers_a[cursed_daggers_lvl] * damage_monster[level] / 100) * 4;
            cursed_daggers_text = "Вы бросаете 9 кинжалов, которые, разлетаясь, отравляют врагов, причиняют им урон и уменьшают наносимый вам урон." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + cursed_daggers_mana[cursed_daggers_lvl] + Environment.NewLine +
                "Отравл. урон: " + cursed_daggers_dam + " в теч. 4 сек.*" + Environment.NewLine +
                "-" + cursed_daggers_b[cursed_daggers_lvl] + "%  от люб. урона в теч. 8 сек." + Environment.NewLine +
                "+" + cursed_daggers_c[cursed_daggers_lvl] + " к отбрасыванию" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Число кинжалов увеличено до 11. Вы получаете 0,5% к скорости передвижения за каждое попадание по врагу в теч. 4 сек." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Число кинжалов увеличено до 13. Вы получаете 0,5% к скорости передвижения за каждое попадание по врагу в теч. 4 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Число кинжалов увеличено до 15. Вы получаете 0,5% к скорости передвижения за каждое попадание по врагу в теч. 4 сек." + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";		 	

            int vortex_hex_dam = (int)Math.Ceiling(vortex_hex_a[vortex_hex_lvl] * damage_monster[level] / 100);
		    double vortex_hex_mana_regen = Math.Round(vortex_hex_b[vortex_hex_lvl] * mana_player_generic[level] / 10) / 10;
            vortex_hex_text = "Вы призываете магических кукол, каждая из которых может притянуть к себе и оглушить до 3 врагов. Шанс оглушения целей - до 8%." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + vortex_hex_mana[vortex_hex_lvl] + Environment.NewLine +
                "Время между активациями: 3 сек." + Environment.NewLine +
                "Время вызова: 15 сек." + Environment.NewLine +
                vortex_hex_c[vortex_hex_lvl] + "% шанс оглушить цель на 3 сек." + Environment.NewLine;
			if (vortex_hex_lvl >= 5) 
            {
                vortex_hex_text += "+" + vortex_hex_dam + " к Отравл. урону*" + Environment.NewLine;
            }
			if (vortex_hex_lvl >= 15) 
            {
                vortex_hex_text += "Восполняется " + vortex_hex_mana_regen + " ед. маны в сек.*" + Environment.NewLine;
            }
            vortex_hex_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Притянутые враги получают урон" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Кукла может притянуть к себе до 5 врагов" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Притянутые враги отдают ману заклинателю" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
            
            int shattering_glaive_mindam = (int)Math.Ceiling(shattering_glaive_a[shattering_glaive_lvl] * damage_monster[level] / 100);
		    int shattering_glaive_maxdam = (int)Math.Ceiling(shattering_glaive_b[shattering_glaive_lvl] * damage_monster[level] / 100);
		    int shattering_glaive_mindam_secondary = (int)Math.Ceiling(shattering_glaive_c[shattering_glaive_lvl] * damage_monster[level] / 100);
		    int shattering_glaive_miandam_secondary = (int)Math.Ceiling(shattering_glaive_d[shattering_glaive_lvl] * damage_monster[level] / 100);
		    int shattering_glaive_mindam_fire = (int)Math.Ceiling(100 * damage_monster[level] / 100);
		    int shattering_glaive_maxdam_fire = (int)Math.Ceiling(130 * damage_monster[level] / 100);
            shattering_glaive_text = "Вы бросаете глефу, при попадании осколки разлетаются в радиусе 4,5 метров, нанося урон и замедляя врагов." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + shattering_glaive_mana[shattering_glaive_lvl] + Environment.NewLine +
                "+" + shattering_glaive_mindam + "-" + shattering_glaive_maxdam + " к Физич. урону*" + Environment.NewLine +
                "Дополнительный эффект:" + Environment.NewLine +
                "+" + shattering_glaive_mindam_secondary + "-" + shattering_glaive_miandam_secondary + " к Физич. урону*" + Environment.NewLine +
                "-" + shattering_glaive_e[shattering_glaive_lvl] + "% от скорости движения в теч. 2 сек." + Environment.NewLine +
                "+" + shattering_glaive_f[shattering_glaive_lvl] + " к отбрасыванию" + Environment.NewLine;
			if (shattering_glaive_lvl >= 5) 
            {
                shattering_glaive_text += shattering_glaive_g[shattering_glaive_lvl] + "% шанс обратить цель в бегство на 3 сек." + Environment.NewLine;
			}
			if (shattering_glaive_lvl == 15) 
            {
                shattering_glaive_text += "+" + shattering_glaive_mindam_fire + "-" + shattering_glaive_maxdam_fire + " к Огнен. урону*" + Environment.NewLine;
            }
            shattering_glaive_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "25% шанс на 3 секунды обратить цель в бегство" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус взрыва увеличен до 6 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Из эпицентра взрыва разлетаются потоки огня" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            venomous_hail_text = "Вы выстреливаете в небо, и на землю рядом с целью в радиусе 4 метров падает 8 ядовитых зарядов, наносящих урон врагу." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + venomous_hail_mana[venomous_hail_lvl] + Environment.NewLine +
                "Время между активациями: 2 сек." + Environment.NewLine +
                "Наносит " + venomous_hail_a[venomous_hail_lvl] + "% от урона текущего оружия в сек. ядом" + Environment.NewLine;
            if (venomous_hail_lvl == 15) 
            {
                venomous_hail_text += "100% шанс разбить щит врага" + Environment.NewLine;
            }
            venomous_hail_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Зона поражения увеличена до 5,5 м" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Число зарядов увеличено до 12" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Разбивает щиты" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            long_range_mastery_text = "Ваш опыт владения луками, арбалетами, пистолями и жезлами увеличивает урон, наносимый ими врагу, и повышает дальность стрельбы." + Environment.NewLine + Environment.NewLine +
                "+" + long_range_mastery_a[long_range_mastery_lvl] + "% к урону в стрелковом бою" + Environment.NewLine +
                "+" + long_range_mastery_b[long_range_mastery_lvl] + " м к дальнобойн. (лук, арбалет, пистоль, жезл)" + Environment.NewLine;

            shotgonne_mastery_text = "Ваш опыт стрельбы из дробовиков повышает шансы на ошеломление и дезориентацию цели при попадании." + Environment.NewLine + Environment.NewLine +
                shotgonne_mastery_a[shotgonne_mastery_lvl] + "% шанс оглушить цель на 2 сек." + Environment.NewLine +
                "+" + shotgonne_mastery_b[shotgonne_mastery_lvl] + " к отбрасыванию" + Environment.NewLine +
                shotgonne_mastery_c[shotgonne_mastery_lvl] + "% шанс ослепить цель на 67% в теч. 3 сек." + Environment.NewLine + Environment.NewLine +
                "Необходим дробовик";

            akimbo_text = "Ваше умение обращаться с огнестрельным оружием позволяет стрелять из двух пистолей одновременно... нанося страшный урон врагам." + Environment.NewLine + Environment.NewLine +
                "+" + akimbo_a[akimbo_lvl] + "% к урону при ведении боя с оружием в каждой руке" + Environment.NewLine + Environment.NewLine +
                "Необходимо держать в руках два пистоля";
            
            int glaive_throw_mindam = (int)Math.Ceiling(glaive_throw_a[glaive_throw_lvl] * damage_monster[level] / 100);
		    int glaive_throw_maxdam = (int)Math.Ceiling(glaive_throw_b[glaive_throw_lvl] * damage_monster[level] / 100);
            glaive_throw_text = "Бросок глефы, которая рубит цель, отскакивает, чтобы нанести урон другим врагам, и увеличивает уровень Заряда." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + glaive_throw_mana[glaive_throw_lvl] + "" + Environment.NewLine +
                "+" + glaive_throw_mindam + "-" + glaive_throw_maxdam + " Отравл. урона*" + Environment.NewLine +
                "+80% шанс прервать действия врага" + Environment.NewLine +
                "-" + glaive_throw_c[glaive_throw_lvl] + "% от скорости движения в теч. 2 сек." + Environment.NewLine +
                "Создает " + glaive_throw_d[glaive_throw_lvl] + "% Заряда" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Глефа отскакивает 2 раза" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Глефа отскакивает 3 раза" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Глефа отскакивает 4 раза" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
            
            int tangling_shot_damage = (int)Math.Floor(Math.Ceiling(tangling_shot_b[tangling_shot_lvl] * damage_monster[level] / 100) * tangling_shot_a[tangling_shot_lvl]);
		    int tangling_shot_damage_secondary = (int)Math.Floor(Math.Ceiling(tangling_shot_d[tangling_shot_lvl] * damage_monster[level] / 100) * 3);
            tangling_shot_text = "Вы стреляете проклятым снарядом, который обездвиживает цель. Кроме того, снаряд может обездвижить врагов, которые находятся в радиусе 3,5 м от цели. Обездвиженные враги получают урон в течение некоторого времени." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + tangling_shot_mana[tangling_shot_lvl] + Environment.NewLine +
                "100% шанс обездвижить цель на " + tangling_shot_a[tangling_shot_lvl] + " сек." + Environment.NewLine +
                tangling_shot_damage + " Отравл. урона в теч. " + tangling_shot_a[tangling_shot_lvl] + " сек.*" + Environment.NewLine +
                "Дополнительный эффект:" + Environment.NewLine +
                tangling_shot_c[tangling_shot_lvl] + "% шанс обездвижить цель на 3 сек." + Environment.NewLine +
                tangling_shot_damage_secondary + " Отравл. урона в теч. 3 сек.*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус действия увеличивается до 4,5 м, а шанс обездвиживания - до 65%" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус действия увеличивается до 5,5 м, а шанс обездвиживания - до 80%" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус действия увеличивается до 6,5 м, а шанс обездвиживания - до 95%" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
                         
            int glaive_sweep_damage = (int)Math.Ceiling(glaive_sweep_c[glaive_sweep_lvl] * damage_monster[level] / 100) * 5;
            glaive_sweep_text = "Вы наносите круговой удар глефой, отбрасывая врагов в радиусе 4 метров и оглушая их. Ваш уровень Заряда увеличивается при каждом попадании." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + glaive_sweep_mana[glaive_sweep_lvl] + Environment.NewLine +
                "Наносит " + glaive_sweep_a[glaive_sweep_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                "+40 к отбрасыванию" + Environment.NewLine +
                "+50% шанс прервать действия врага" + Environment.NewLine +
                glaive_sweep_b[glaive_sweep_lvl] + "% шанс оглушить цель на 3 сек." + Environment.NewLine +
                "Создает " + glaive_sweep_d[glaive_sweep_lvl] + "% Заряда" + Environment.NewLine;
		    if (glaive_sweep_lvl >= 5) 
            {
                glaive_sweep_text += glaive_sweep_damage + " Физич. урона в теч. 5 сек.*" + Environment.NewLine;
            }
            glaive_sweep_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Цели истекают кровью" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус действия увеличен до 5,5 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Шанс оглушения увеличивается до 95%" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
            
            int sandstorm_mindam_1 = (int)Math.Ceiling(sandstorm_b[sandstorm_lvl] * damage_monster[level] / 100);
		    int sandstorm_maxdam_1 = (int)Math.Ceiling(sandstorm_c[sandstorm_lvl] * damage_monster[level] / 100);
		    int sandstorm_mindam_2 = (int)Math.Ceiling(70 * damage_monster[level] / 100);
		    int sandstorm_maxdam_2 = (int)Math.Ceiling(100 * damage_monster[level] / 100);
            sandstorm_text = "Вы бросаете глефу, которая превращается в вихрь, наносящий урон врагам и крадущий у них здоровье. Вихрь пролетает 20 м и увеличивает ваш индикатор Заряда на 1,5% за каждое попадание." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + sandstorm_mana[sandstorm_lvl] + Environment.NewLine +
                "+15 к отбрасыванию" + Environment.NewLine +
                "100% шанс оглушить цель на " + sandstorm_a[sandstorm_lvl] + " сек." + Environment.NewLine +
                "+" + sandstorm_mindam_1 + "-" + sandstorm_maxdam_1 + " к Физич. урону*" + Environment.NewLine;
		    if (sandstorm_lvl >= 5) 
            {
                sandstorm_text += sandstorm_mindam_2 + "-" + sandstorm_maxdam_2 + " к Физич. урону*" + Environment.NewLine;
            }
            sandstorm_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Из убитых врагов вылетают чумные мухи" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус увеличен до 40 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус увеличен до 50 м" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";            
            
            int bramble_wall_damage_instant_min = (int)Math.Ceiling(bramble_wall_b[bramble_wall_lvl] * damage_monster[level] / 100);
		    int bramble_wall_damage_instant_max = (int)Math.Ceiling(bramble_wall_c[bramble_wall_lvl] * damage_monster[level] / 100);
		    int bramble_wall_damage_dot = (int)Math.Ceiling(50 * damage_monster[level] / 100) * 3;
            bramble_wall_text = "Вы создаете колючую стену, которая не дает врагам приблизиться к вам." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + bramble_wall_mana[bramble_wall_lvl] + Environment.NewLine +
                "Время между активациями: 2.5 сек." + Environment.NewLine +
                "Побеги живут " + bramble_wall_a[bramble_wall_lvl] + " сек." + Environment.NewLine +
                "+45 к отбрасыванию" + Environment.NewLine;
		    if (bramble_wall_lvl >= 5) 
            {
                bramble_wall_text += "+" + bramble_wall_damage_instant_min + "-" + bramble_wall_damage_instant_max + " Отравл. урона*" + Environment.NewLine;
            }
            if (bramble_wall_lvl >= 15) 
            {
                bramble_wall_text += bramble_wall_damage_dot + " Отравл. урона в теч. 3 сек.*" + Environment.NewLine;
            }
            bramble_wall_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Ползучие побеги наносят врагам урон" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Длина побегов увеличена" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Побеги испускают ядовитый газ" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            burning_leap_text = "Вы прыгаете вперед на 7 метров и наносите удары глефой, отбрасывая врагов назад и поджигая." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + burning_leap_mana[burning_leap_lvl] + Environment.NewLine +
                "Наносит " + burning_leap_a[burning_leap_lvl] + "% от урона текущего оружия в сек. огнем" + Environment.NewLine +
                burning_leap_b[burning_leap_lvl] + "% шанс поджечь цель на " + burning_leap_c[burning_leap_lvl] + " сек." + Environment.NewLine +
                "+45 к отбрасыванию" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Время применения меньше на 10%, радиус действия больше на 9 м" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Время применения меньше на 10%, радиус действия больше на 11 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Время применения меньше на 10%, радиус действия больше на 13 м";            
            
            int flaming_glaives_dam = (int)Math.Ceiling(flaming_glaives_b[flaming_glaives_lvl] * damage_monster[level] / 100) * 6;
            flaming_glaives_text = "Вы бросаете две огненные глефы, они кружат, нанося урон всем врагам в радиусе действия." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + flaming_glaives_mana[flaming_glaives_lvl] + Environment.NewLine +
                "Наносит " + flaming_glaives_a[flaming_glaives_lvl] + "% от урона текущего оружия в сек. огнем" + Environment.NewLine +
                flaming_glaives_dam + " Огнен. урона в теч. 6 сек.*" + Environment.NewLine;
            if (flaming_glaives_lvl >= 10) 
            {
                flaming_glaives_text += "+" + flaming_glaives_c[flaming_glaives_lvl] + "% к получаемому Огенен. урону в теч. 6 сек." + Environment.NewLine +
                    "+" + flaming_glaives_c[flaming_glaives_lvl] + "% к получаемому Отравл. урону в теч. 6 сек." + Environment.NewLine;
            }
            flaming_glaives_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Размер глеф увеличен, поэтому они бьют точнее" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Враги, в которых попала глефа, на 30% уязвимее к действию огня и яда" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Враги, в которых попала глефа, на 45% уязвимее к действию огня и яда" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            dodge_mastery_text = "Вы освоили акробатику и поэтому более эффективно уклоняетесь от ударов." + Environment.NewLine + Environment.NewLine +
                "+" + dodge_mastery_a[dodge_mastery_lvl] + "% к шансу уклонения";

            poison_burst_text = "Вы смазываете оружие ядом, и в случае поражения ваш противник, вполне возможно, взорвется, оставляя после себя облако ядовитого газа, наносящего дополнительный урон в радиусе 6 метров." + Environment.NewLine + Environment.NewLine +
                "Наносит " + poison_burst_a[poison_burst_lvl] + "% от урона текущего оружия в сек. ядом" + Environment.NewLine +
                poison_burst_b[poison_burst_lvl] + "% шанс уничтожить цель заклинанием \"Взрыв\"";

            share_the_wealth_text = "Все питомцы и союзники, которые находятся рядом с вами в радиусе 16 метров, получают часть бонусов от вашего Заряда, а ваши собственные бонусы возрастают на такую же долю." + Environment.NewLine + Environment.NewLine +
                "Общая доля бонусов от заряда: " + share_the_wealth_a[share_the_wealth_lvl] + "%";

            blade_pact_text = "Вы насылаете на врагов древнее проклятие замедляющее движение и уменьшающее защиту. Эффект длится 7 сек. и действует на всех врагов, находящихся в зоне действия заклинания." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + blade_pact_mana[blade_pact_lvl] + Environment.NewLine +
                "-" + blade_pact_a[blade_pact_lvl] + "% от скорости атаки в теч. 3 сек." + Environment.NewLine +
                "-" + blade_pact_b[blade_pact_lvl] + "% от скорости движения в теч. 3 сек." + Environment.NewLine +
                "-" + blade_pact_c[blade_pact_lvl] + "% от Физич. брони в теч. 3 сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Заклинание действует 9 секунд" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Заклинание действует 11 секунд" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Заклинание действует 13 секунд";

            shadowshot_text = "Вы накладываете проклятие на боеприпасы, и при попадании они разделяются на 3 части, каждая из которых ищет новую цель." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + shadowshot_mana[shadowshot_lvl] + Environment.NewLine +
                "Наносит " + shadowshot_a[shadowshot_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                "Дополнительный эффект:" + Environment.NewLine +
                shadowshot_b[shadowshot_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Снаряд разделяется на 4 части" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Снаряд разделяется на 5 частей" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Снаряд разделяется на 6 частей";
            
            int bane_breath_mindam_dot = (int)Math.Ceiling(32 * damage_monster[level] / 100) * 2;
		    int bane_breath_maxdam_dot = (int)Math.Ceiling(bane_breath_b[bane_breath_lvl] * damage_monster[level] / 100) * 2;
		    int bane_breath_mindam_instant = (int)Math.Ceiling(20 * damage_monster[level] / 100);
		    int bane_breath_maxdam_instant = (int)Math.Ceiling(bane_breath_d[bane_breath_lvl] * damage_monster[level] / 100);
		    int bane_breath_mindam_minion = (int)Math.Ceiling(50 * damage_minion_bylevel[level] / 100);
		    int bane_breath_maxdam_minion = (int)Math.Ceiling(80 * damage_minion_bylevel[level] / 100);
            bane_breath_text = "Дыхание смерти отравляет врагов, и если они при этом погибают, то превращаются в теневиков-дьяволов, которые в течение 10 сек. сражаются на вашей стороне. Ритуал смерти способствует повышению боеспособности теневиков." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + bane_breath_mana[bane_breath_lvl] + Environment.NewLine +
                bane_breath_mindam_dot + "-" + bane_breath_maxdam_dot + " Отравл. урона в теч. 2 сек.*" + Environment.NewLine +
                "+" + bane_breath_mindam_instant + "-" + bane_breath_maxdam_instant + " Отравл. урона*" + Environment.NewLine +
                "Взрыв при гибели" + Environment.NewLine +
                "Помощники наносят " + bane_breath_mindam_minion + "-" + bane_breath_maxdam_minion + " Физич. урона*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Теневики двигаются и атакуют на 10% быстрее" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Теневики двигаются и атакуют на 20% быстрее" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Теневики двигаются и атакуют на 30% быстрее" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            repulsion_hex_text = "Вы призываете парящего аватара, который отталкивает находящихся рядом врагов." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + repulsion_hex_mana[repulsion_hex_lvl] + Environment.NewLine +
                "Время между активациями: 35 сек." + Environment.NewLine + Environment.NewLine;
            if (repulsion_hex_lvl == 1)
            {
                repulsion_hex_text += "Заклинание стреляет раз в " + repulsion_hex_a[repulsion_hex_lvl] + " сек." + Environment.NewLine;
            }			
		 	if (repulsion_hex_lvl >= 2)
            {
                repulsion_hex_text += "Заклинание стреляет раз в " + repulsion_hex_a[repulsion_hex_lvl] + " сек. и наводится быстрее" + Environment.NewLine;
            }
            repulsion_hex_text += "Время вызова: " + repulsion_hex_b[repulsion_hex_lvl] + Environment.NewLine +
                "+" + repulsion_hex_c[repulsion_hex_lvl] + " к отбрасыванию" + Environment.NewLine +
                "+" + repulsion_hex_d[repulsion_hex_lvl] + "% шанс прервать действия врага" + Environment.NewLine;
			if (repulsion_hex_lvl >= 5) 
            {
                repulsion_hex_text += repulsion_hex_e[repulsion_hex_lvl] + "% шанс обратить цель в бегство на 5 сек." + Environment.NewLine;
            }
            repulsion_hex_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "В 10% случаев заклинание на 5 секунд обращает врагов в бегство" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "В 20% случаев заклинание на 5 секунд обращает врагов в бегство" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "В 30% случаев заклинание на 5 секунд обращает врагов в бегство";
            
            int stone_pact_hp_regen = (int)Math.Ceiling((int)Math.Ceiling(stone_pact_c[stone_pact_lvl] * health_player_generic[level] / 100 * 3) / 62.5);
            stone_pact_text = "Вы применяете древнее заклинание, защищающее от обычного и магического урона и частично отражающее его во врагов. Эффект длится 20 сек. и действует на всех союзников, находящихся в зоне действия заклинания." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + stone_pact_mana[stone_pact_lvl] + Environment.NewLine +
                "Время между активациями: 8 сек." + Environment.NewLine +
                "+" + stone_pact_a[stone_pact_lvl] + "% ко всем видам брони в теч. 3 сек." + Environment.NewLine +
                "Восполняется " + stone_pact_hp_regen + " ед. здоровья в теч. 3 сек.*" + Environment.NewLine;
			if (stone_pact_lvl >= 5) 
            {
                stone_pact_text += stone_pact_b[stone_pact_lvl] + "% урона приходится на нападающего в теч. 3 сек." + Environment.NewLine;
            }
            stone_pact_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Заклинание отражает во врагов 25% нанесенного урона" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Заклинание отражает во врагов 50% нанесенного урона" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Заклинание отражает во врагов 75% нанесенного урона" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            shadowmantle_text = "Защитное заклинание отражает снаряды и направляет обратно во врагов с вероятностью ослепить их на 6 сек." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + shadowmantle_mana[shadowmantle_lvl] + Environment.NewLine +
                "Время между активациями: " + shadowmantle_c[shadowmantle_lvl] + " сек." + Environment.NewLine +
                shadowmantle_a[shadowmantle_lvl] + "% шанс отразить снаряд с силой " + shadowmantle_b[shadowmantle_lvl] + "% от урона текущего оружия в сек. в теч. 10 сек." + Environment.NewLine +
                shadowmantle_a[shadowmantle_lvl] + "% шанс сотворить заклинание \"Куриная слепота\" при получении удара в теч. 10 сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Заклинание отражает 125% урона от снарядов" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Заклинание отражает 175% урона от снарядов" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Заклинание отражает 250% урона от снарядов";
            
            int shadowling_brute_mindam = (int)Math.Ceiling(110 * damage_minion_bylevel[level] / 100);
		    int shadowling_brute_maxdam = (int)Math.Ceiling(150 * damage_minion_bylevel[level] / 100);
            shadowling_brute_text = "Вы призываете ужасающего теневика-силача, который наносит урон находящимся рядом врагам." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + shadowling_brute_mana[shadowling_brute_lvl] + Environment.NewLine +
                "Время между активациями: 30 сек." + Environment.NewLine;
            if (shadowling_brute_lvl >= 2)
            {
                shadowling_brute_text += "+" + shadowling_brute_a[shadowling_brute_lvl] + "% к люб. урону" + Environment.NewLine;
            }
            shadowling_brute_text += "Помощники наносят " + shadowling_brute_mindam + "-" + shadowling_brute_maxdam + " Физич. урона*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Силач обретает атаку в рывке" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Силач обретает атаку в броске" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "ЗСкорость атаки силача увеличивается на 30%" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            master_of_the_elements_text = "Ваши знания о стихиях позволяют лучше сражаться. Эффект при использовании яда вдвое больше, чем в случае других стихий." + Environment.NewLine + Environment.NewLine +
                "+" + master_of_the_elements_a[master_of_the_elements_lvl] + "% к лед. урону" + Environment.NewLine +
                "+" + master_of_the_elements_a[master_of_the_elements_lvl] + "% к огнен. урону" + Environment.NewLine +
                "+" + master_of_the_elements_b[master_of_the_elements_lvl] + "% к отравл. урону" + Environment.NewLine +
                "+" + master_of_the_elements_a[master_of_the_elements_lvl] + "% к электр. урону";
            
            int shadowling_ammo_mindam = (int)Math.Ceiling(shadowling_ammo_b[shadowling_ammo_lvl] * damage_minion_bylevel[level] / 100);
		    int shadowling_ammo_maxdam = (int)Math.Ceiling(shadowling_ammo_c[shadowling_ammo_lvl] * damage_minion_bylevel[level] / 100);
            shadowling_ammo_text = "Вы накладываете на боеприпасы темные чары. При попадании они иногда превращают убитых врагов в теневиков-нетопырей, которые в течение 10 сек. сражаются на вашей стороне. Ритуал смерти способствует повышению боеспособности теневиков." + Environment.NewLine + Environment.NewLine +
                shadowling_ammo_a[shadowling_ammo_lvl] + "% шанс уничтожить цель заклинанием \"Создать теневика-союзника\"" + Environment.NewLine +
                "Помощники наносят " + shadowling_ammo_mindam + "-" + shadowling_ammo_maxdam + " Физич. урона*" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            death_ritual_text = "Ваши союзники-теневики живут дольше и наносят больший урон." + Environment.NewLine + Environment.NewLine +
                "Теневики живут " + death_ritual_a[death_ritual_lvl] + " сек., урон увеличивается на " + death_ritual_b[death_ritual_lvl] + "%" + Environment.NewLine;
        }
    }
}