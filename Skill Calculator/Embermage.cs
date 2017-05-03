using System;

namespace Skill_Calculator
{
    public class Embermage
    {
        public int skillpointsleft, level, fame, statpointsleft;
        public double strength = 5, dexterity = 10, focus = 15, vitality = 10;
        public string strength_text, dexterity_text, focus_text, vitality_text;
 
        public string[] fame_ranks = {"2000", "3000", "4000", "5000", "7000", "9000", "12000", "14000", "16000", "18000", "19000", "22000", "23000", "26000", "27000", "29000", "31000", "34000", "35000", "37000", "40000", "41000", "44000", "46000", "48000", "50000", "52000", "55000", "56000", "59000", "62000", "63000", "9005000", "full"};
                
        int[] armor_player_bylevel_forset = { 0, 8, 10, 12, 14, 17, 20, 22, 25, 28, 31, 34, 37, 40, 43, 46, 50, 53, 56, 60, 63, 67, 70, 74, 77, 81, 85, 88, 92, 96, 100, 103, 107, 111, 115, 119, 123, 127, 131, 135, 139, 143, 147, 151, 155, 159, 163, 167, 171, 176, 180, 184, 188, 192, 197, 201, 205, 209, 214, 218, 222, 226, 231, 235, 239, 244, 248, 253, 257, 261, 266, 270, 274, 279, 283, 288, 292, 297, 301, 305, 310, 314, 319, 323, 328, 332, 337, 341, 346, 350, 355, 359, 364, 368, 373, 377, 382, 386, 391, 395, 400, 405, 409, 414, 418, 423};
        int[] damage_minion_bylevel = { 0, 24, 30, 37, 44, 51, 58, 66, 74, 83, 92, 101, 110, 120, 131, 142, 153, 164, 177, 189, 202, 215, 229, 243, 258, 273, 288, 304, 321, 338, 355, 373, 392, 411, 430, 450, 471, 492, 514, 536, 558, 582, 605, 630, 655, 680, 706, 733, 760, 788, 817, 846, 876, 906, 937, 968, 1001, 1034, 1067, 1101, 1136, 1172, 1208, 1245, 1283, 1321, 1360, 1400, 1440, 1481, 1523, 1566, 1609, 1653, 1698, 1744, 1790, 1837, 1885, 1934, 1984, 2034, 2085, 2137, 2190, 2243, 2297, 2353, 2409, 2466, 2523, 2582, 2641, 2701, 2763, 2825, 2888, 2951, 3016, 3082, 3148, 3216, 3284, 3353, 3423, 3495};
        double[] damage_monster = { 0, 10, 14, 19, 23.9, 29, 34.5, 40.200001, 46.299999, 52.599998, 59.299999, 66.400002, 73.800003, 81.5, 89.599998, 98.099998, 106.900002, 116.099998, 125.699997, 135.699997, 146.100006, 157, 168.199997, 179.899994, 192, 204.600006, 217.699997, 231.199997, 245.199997, 259.600006, 274.600006, 290.100006, 306.100006, 322.600006, 339.600006, 357.200012, 375.299988, 394, 413.299988, 433.100006, 453.600006, 474.600006, 496.200012, 518.5, 541.400024, 564.900024, 589.099976, 613.900024, 639.400024, 665.599976, 692.5, 720, 748.299988, 777.299988, 807, 837.5, 868.700012, 900.700012, 933.5, 967, 1001.400024, 1036.5, 1072.5, 1109.300049, 1147, 1185.5, 1224.800049, 1265.099976, 1306.199951, 1348.199951, 1391.099976, 1435, 1479.800049, 1525.5, 1572.199951, 1619.900024, 1668.5, 1718.099976, 1768.800049, 1820.400024, 1873.099976, 1926.900024, 1981.699951, 2037.5, 2094.5, 2152.5, 2211.600098, 2271.899902, 2333.300049, 2395.800049, 2459.5, 2524.300049, 2590.399902, 2657.600098, 2726.100098, 2795.800049, 2866.699951, 2938.800049, 3012.300049, 3087, 3163, 3240.300049, 3318.899902, 3398.800049, 3480.100098, 3562.800049 };
        double[] armor_monster_bylevel = { 0, 4, 7, 8, 11, 14, 18, 21, 25, 28, 32, 37, 41, 46, 50, 55, 61, 66, 72, 77, 83, 90, 96, 102, 109, 116, 123, 131, 138, 146, 154, 162, 170, 179, 188, 196, 206, 215, 224, 234, 244, 254, 264, 275, 286, 296, 307, 319, 330, 342, 354, 366, 378, 390, 403, 416, 429, 442, 456, 469, 483, 497, 511, 526, 540, 555, 570, 585, 601, 616, 632, 648, 664, 680, 697, 714, 731, 748, 765, 783, 800, 818, 836, 855, 873, 892, 911, 930, 949, 969, 988, 1008, 1028, 1049, 1069, 1090, 1111, 1132, 1153, 1175, 1196, 1218, 1240, 1262, 1285, 1307 };
        double[] mana_player_generic = { 0, 47.5, 48.5, 49.5, 50.5, 51.5, 52.5, 53.5, 54.5, 55.5, 56.5, 57.5, 58.5, 59.5, 60.5, 61.5, 62.5, 63.5, 64.5, 65.5, 66.5, 67.5, 68.5, 69.5, 70.5, 71.5, 72.5, 73.5, 74.5, 75.5, 76.5, 77.5, 78.5, 79.5, 80.5, 81.5, 82.5, 83.5, 84.5, 85.5, 86.5, 87.5, 88.5, 89.5, 90.5, 91.5, 92.5, 93.5, 94.5, 95.5, 96.5, 97.5, 98.5, 99.5, 100.5, 101.5, 102.5, 103.5, 104.5, 105.5, 106.5, 107.5, 108.5, 109.5, 110.5, 111.5, 112.5, 113.5, 114.5, 115.5, 116.5, 117.5, 118.5, 119.5, 120.5, 121.5, 122.5, 123.5, 124.5, 125.5, 126.5, 127.5, 128.5, 129.5, 130.5, 131.5, 132.5, 133.5, 134.5, 135.5, 136.5, 137.5, 138.5, 139.5, 140.5, 141.5, 142.5, 143.5, 144.5, 145.5, 146.5 };
        double[] health_player_generic = { 0, 200, 240, 280, 320, 360, 400, 440, 480, 520, 560, 600, 640, 680, 720, 760, 800, 840, 880, 920, 960, 1000, 1040, 1080, 1120, 1160, 1200, 1240, 1280, 1320, 1360, 1400, 1440, 1480, 1520, 1560, 1600, 1640, 1680, 1720, 1760, 1800, 1840, 1880, 1920, 1960, 2000, 2040, 2080, 2120, 2160, 2200, 2240, 2280, 2320, 2360, 2400, 2440, 2480, 2520, 2560, 2600, 2640, 2680, 2720, 2760, 2800, 2840, 2880, 2920, 2960, 3000, 3040, 3080, 3120, 3160, 3200, 3240, 3280, 3320, 3360, 3400, 3440, 3480, 3520, 3560, 3600, 3640, 3680, 3720, 3760, 3800, 3840, 3880, 3920, 3960, 4000, 4040, 4080, 4120, 4160, 4200, 4240, 4280, 4320, 4360 }; 
        double[] rapid_fire_a = { 0, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53 };

        public int magma_spear_lvl = 0, magma_spear_lvl_old = 0;
        public string magma_spear_text;
        double[] magma_spear_a = { 0, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 50, 51 };
        double[] magma_spear_b = { 0, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100, 100 };         
        int[] magma_spear_c = { 0, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93, 96, 99, 102 };
        int[] magma_spear_d = { 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 6, 6, 6, 6, 6, 6 };
        double[] magma_spear_mana = { 0, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 25, 28, 31, 34, 38 };
        public string[] magma_spear_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int magma_mace_lvl = 0, magma_mace_lvl_old = 0;
        public string magma_mace_text;
        double[] magma_mace_a = { 0, 50, 53, 56, 58, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92 };
        double[] magma_mace_b = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 33, 33, 33, 33, 33, 67 };
        double[] magma_mace_c = { 0, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39 }; 
        double[] magma_mace_mana = { 0, 12, 13, 14, 15, 16, 17, 19, 22, 24, 27, 30, 32, 36, 40, 45 };
        public string[] magma_mace_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int firebombs_lvl = 0, firebombs_lvl_old = 0;
        public string firebombs_text;
        double[] firebombs_c = { 0, 2, 2.1, 2.2, 2.3, 2.4, 2.5, 2.6, 2.7, 2.8, 2.9, 3, 3.1, 3.2, 3.3, 3.4 };
        double[] firebombs_d = { 0, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54 };
        double[] firebombs_e = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        double[] firebombs_f = { 0, 2, 2, 2, 2, 1.6, 1.6, 1.6, 1.6, 1.6, 1.2, 1.2, 1.2, 1.2, 1.2, 0.8 }; 
        double[] firebombs_mana = { 0, 17, 17, 18, 18, 19, 20, 22, 24, 26, 29, 33, 36, 39, 42, 47 };
        public string[] firebombs_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int blazing_pillar_lvl = 0, blazing_pillar_lvl_old = 0;
        public string blazing_pillar_text;
        double[] blazing_pillar_b = { 0, 100, 105, 110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170 };
        double[] blazing_pillar_c = { 0, 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };
        double[] blazing_pillar_d = { 0, 9, 8.8, 8.5, 8.3, 8, 7.8, 7.5, 7.3, 7, 6.8, 6.5, 6.3, 6, 5.8, 5.5 }; 
        double[] blazing_pillar_mana = { 0, 18, 19, 19, 19, 20, 21, 22, 24, 26, 28, 31, 34, 37, 40, 43 };
        public string[] blazing_pillar_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int infernal_collapse_lvl = 0, infernal_collapse_lvl_old = 0;
        public string infernal_collapse_text;
        double[] infernal_collapse_a = { 0, 180, 180, 180, 180, 180, 180, 180, 180, 180, 180, 180, 180, 180, 180, 180 };
        double[] infernal_collapse_b = { 0, 240, 252, 263, 276, 288, 300, 312, 324, 336, 348, 360, 372, 384, 396, 408 };
        double[] infernal_collapse_c = { 0, 30, 30, 30, 30, 40, 40, 40, 40, 40, 50, 50, 50, 50, 50, 65 };
        double[] infernal_collapse_d = { 0, 2.5, 2.4, 2.3, 2.2, 2.1, 2, 1.9, 1.8, 1.7, 1.6, 1.5, 1.4, 1.3, 1.2, 1.1 }; 
        double[] infernal_collapse_mana = { 0, 27, 28, 28, 29, 30, 31, 31, 33, 35, 39, 42, 46, 49, 54, 58 };
        public string[] infernal_collapse_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int immolation_aura_lvl = 0, immolation_aura_lvl_old = 0;
        public string immolation_aura_text;
        double[] immolation_aura_a = { 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 10, 10, 10, 10, 10, 15 };
        double[] immolation_aura_b = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        double[] immolation_aura_c = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58 }; 
        double[] immolation_aura_mana = { 0, 23, 23, 24, 24, 25, 25, 26, 27, 29, 31, 34, 36, 39, 41, 44 };
        public string[] immolation_aura_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int firestorm_lvl = 0, firestorm_lvl_old = 0;
        public string firestorm_text;
        double[] firestorm_a = { 0, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38 };
        double[] firestorm_b = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        double[] firestorm_c = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        double[] firestorm_g = { 0, 2.5, 2.4, 2.3, 2.2, 2.1, 2, 1.9, 1.8, 1.7, 1.6, 1.5, 1.4, 1.3, 1.2, 1.1 }; 
        double[] firestorm_mana = { 0, 33, 34, 34, 35, 36, 38, 39, 40, 42, 45, 47, 49, 52, 56, 58 };
        public string[] firestorm_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int charge_mastery_lvl = 0, charge_mastery_lvl_old = 0;
        public string charge_mastery_text;
        double[] charge_mastery_a = { 0, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60, 66, 72, 78, 84, 90 };
        double[] charge_mastery_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60 };
        public string[] charge_mastery_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int elemental_attunement_lvl = 0, elemental_attunement_lvl_old = 0;
        public string elemental_attunement_text;
        double[] elemental_attunement_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        public string[] elemental_attunement_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int fire_brand_lvl = 0, fire_brand_lvl_old = 0;
        public string fire_brand_text;
        double[] fire_brand_a = { 0, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70 };
        double[] fire_brand_b = { 0, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, 210 }; 
        public string[] fire_brand_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int icy_blast_lvl = 0, icy_blast_lvl_old = 0;
        public string icy_blast_text;
        double[] icy_blast_a = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58 };
        double[] icy_blast_b = { 0, 50, 53, 55, 58, 61, 63, 65, 68, 70, 73, 75, 78, 80, 83, 85 };
        double[] icy_blast_c = { 0, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10 };
        double[] icy_blast_d = { 0, 50, 50, 50, 50, 50, 50, 50, 50, 50, 75, 75, 75, 75, 75, 75 };
        double[] icy_blast_e = { 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4 };
        double[] icy_blast_mana = { 0, 11, 12, 13, 14, 15, 18, 20, 22, 24, 27, 31, 34, 37, 42, 46 }; 
        public string[] icy_blast_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int hailstorm_lvl = 0, hailstorm_lvl_old = 0;
        public string hailstorm_text;
        double[] hailstorm_a = { 0, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78 };
        double[] hailstorm_b = { 0, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68 };
        double[] hailstorm_c = { 0, 100, 105, 110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170 };
        double[] hailstorm_d = { 0, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80 };
        double[] hailstorm_e = { 0, 0, 0, 0, 0, 20, 20, 20, 20, 20, 40, 40, 40, 40, 40, 60 };
        double[] hailstorm_f = { 0, 2.5, 2.4, 2.3, 2.2, 2.1, 2, 1.9, 1.8, 1.7, 1.6, 1.5, 1.4, 1.3, 1.2, 1.1 }; 
        double[] hailstorm_mana = { 0, 18, 18, 19, 20, 21, 22, 24, 27, 31, 34, 38, 41, 46, 51, 57 };
        public string[] hailstorm_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int frost_phase_lvl = 0, frost_phase_lvl_old = 0;
        public string frost_phase_text;
        double[] frost_phase_b = { 0, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
        double[] frost_phase_c = { 0, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43 };
        double[] frost_phase_d = { 0, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80 }; 
        double[] frost_phase_mana = { 0, 18, 18, 19, 19, 20, 21, 22, 24, 25, 27, 30, 31, 33, 34, 36 };
        public string[] frost_phase_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int elemental_boon_lvl = 0, elemental_boon_lvl_old = 0;
        public string elemental_boon_text;
        double[] elemental_boon_a = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9, 11, 13.1, 15.2, 17.4, 20 };
        double[] elemental_boon_b = { 0, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38 };
        double[] elemental_boon_c = { 0, 0, 0, 0, 0, 42, 46, 48, 51, 54, 57, 61, 64, 66, 69, 72 };
        double[] elemental_boon_d = { 0, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38 };
        double[] elemental_boon_e = { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0.67 }; 
        double[] elemental_boon_mana = { 0, 18, 19, 19, 19, 20, 21, 22, 24, 26, 28, 31, 34, 37, 40, 28 };
        public string[] elemental_boon_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int frost_wave_lvl = 0, frost_wave_lvl_old = 0;
        public string frost_wave_text;
        double[] frost_wave_c = { 0, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92 };
        double[] frost_wave_d = { 0, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 40 }; 
        double[] frost_wave_mana = { 0, 21, 21, 21, 22, 22, 23, 24, 25, 27, 29, 32, 35, 37, 41, 44 };
        public string[] frost_wave_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int ice_prison_lvl = 0, ice_prison_lvl_old = 0;
        public string ice_prison_text;
        double[] ice_prison_a = { 0, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
        double[] ice_prison_b = { 0, 10, 13, 15, 18, 20, 23, 25, 28, 30, 33, 35, 37, 40, 43, 45 };
        double[] ice_prison_f = { 0, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 2 }; 
        double[] ice_prison_mana = { 0, 32, 32, 33, 33, 35, 35, 36, 37, 40, 43, 47, 50, 54, 57, 61 };
        public string[] ice_prison_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int astral_ally_lvl = 0, astral_ally_lvl_old = 0;
        public string astral_ally_text;
        double[] astral_ally_a = { 0, 20, 20, 20, 20, 30, 30, 30, 30, 30, 40, 40, 40, 40, 40, 50 };
        double[] astral_ally_b = { 0, 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56 };
        double[] astral_ally_e = { 0, 60, 58, 56, 54, 52, 50, 48, 46, 44, 42, 40, 38, 36, 34, 32 }; 
        double[] astral_ally_mana = { 0, 57, 58, 59, 60, 62, 64, 66, 69, 73, 76, 80, 85, 89, 95, 100 };
        public string[] astral_ally_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int staff_mastery_lvl = 0, staff_mastery_lvl_old = 0;
        public string staff_mastery_text;
        double[] staff_mastery_a = { 0, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34 };
        public string[] staff_mastery_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int frozen_fate_lvl = 0, frozen_fate_lvl_old = 0;
        public string frozen_fate_text;
        double[] frozen_fate_a = { 0, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76 };
        double[] frozen_fate_b = { 0, 3, 3.2, 3.4, 3.6, 3.8, 4, 4.2, 4.4, 4.6, 4.8, 5, 5.2, 5.4, 5.6, 5.8 };
        public string[] frozen_fate_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int ice_brand_lvl = 0, ice_brand_lvl_old = 0;
        public string ice_brand_text;
        double[] ice_brand_b = { 0, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, 210 }; 
        public string[] ice_brand_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int prismatic_bolt_lvl = 0, prismatic_bolt_lvl_old = 0;
        public string prismatic_bolt_text;
        double[] prismatic_bolt_b = { 0, 1, 1, 1, 1, 1.1, 1.1, 1.1, 1.1, 1.1, 1.2, 1.2, 1.2, 1.2, 1.2, 1.3 };
        double[] prismatic_bolt_c = { 0, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        double[] prismatic_bolt_d = { 0, 3, 3.2, 3.4, 3.6, 3.8, 4, 4.2, 4.4, 4.6, 4.8, 5, 5.2, 5.4, 5.6, 5.8 }; 
        double[] prismatic_bolt_mana = { 0, 10, 11, 12, 13, 14, 16, 18, 20, 22, 25, 28, 31, 34, 38, 42 };
        public string[] prismatic_bolt_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int shocking_burst_lvl = 0, shocking_burst_lvl_old = 0;
        public string shocking_burst_text;
        double[] shocking_burst_a = { 0, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34 };
        double[] shocking_burst_c = { 0, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72 };
        double[] shocking_burst_d = { 0, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
        double[] shocking_burst_e = { 0, 1, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9, 2, 2.1, 2.2, 2.3, 2.4 };
        double[] shocking_burst_mana = { 0, 19, 20, 21, 22, 23, 25, 27, 30, 34, 38, 42, 46, 51, 57, 63 };
        public string[] shocking_burst_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int thunder_locus_lvl = 0, thunder_locus_lvl_old = 0;
        public string thunder_locus_text;
        double[] thunder_locus_a = { 0, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42 };
        double[] thunder_locus_b = { 0, 100, 105, 110, 115, 90, 94, 98, 101, 105, 96, 99, 102, 106, 109, 112 };
        double[] thunder_locus_c = { 0, 200, 205, 210, 215, 165, 169, 173, 176, 180, 162, 165, 168, 172, 175, 178 }; 
        double[] thunder_locus_mana = { 0, 25, 26, 26, 27, 29, 31, 33, 35, 38, 43, 48, 53, 57, 64, 69 };
        public string[] thunder_locus_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int arc_beam_lvl = 0, arc_beam_lvl_old = 0;
        public string arc_beam_text;
        double[] arc_beam_a = { 0, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        double[] arc_beam_d = { 0, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68 };
        double[] arc_beam_mana = { 0, 17, 18, 20, 21, 23, 25, 29, 33, 40, 46, 51, 58, 66, 74, 81 };
        public string[] arc_beam_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int deaths_bounty_lvl = 0, deaths_bounty_lvl_old = 0;
        public string deaths_bounty_text;
        double[] deaths_bounty_a = { 0, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12 };
        double[] deaths_bounty_b = { 0, 2.5, 2.4, 2.3, 2.2, 2.1, 2, 1.9, 1.8, 1.7, 1.6, 1.5, 1.4, 1.3, 1.2, 1.1 };
        double[] deaths_bounty_mana = { 0, 21, 21, 21, 22, 22, 23, 24, 25, 27, 29, 32, 35, 37, 41, 44 };
        public string[] deaths_bounty_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int shockbolts_lvl = 0, shockbolts_lvl_old = 0;
        public string shockbolts_text;
        double[] shockbolts_a = { 0, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53 }; 
        double[] shockbolts_mana = { 0,  23, 23, 24, 24, 25, 25, 26, 27, 29, 31, 34, 36, 39, 41, 44 };
        public string[] shockbolts_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int shocking_orb_lvl = 0, shocking_orb_lvl_old = 0;
        public string shocking_orb_text;
        double[] shocking_orb_a = { 0, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76, 80, 84, 88, 92, 96 };
        double[] shocking_orb_mana = { 0, 25, 26, 26, 27, 27, 28, 29, 31, 32, 34, 36, 38, 40, 42, 44 };
        public string[] shocking_orb_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int prismatic_rift_lvl = 0, prismatic_rift_lvl_old = 0;
        public string prismatic_rift_text;
        double[] prismatic_rift_a = { 0, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85 };
        public string[] prismatic_rift_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int wand_chaos_lvl = 0, wand_chaos_lvl_old = 0;
        public string wand_chaos_text;
        double[] wand_chaos_a = { 0, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
        public string[] wand_chaos_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int lightning_brand_lvl = 0, lightning_brand_lvl_old = 0;
        public string lightning_brand_text;
        double[] lightning_brand_a = { 0, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70 };
        double[] lightning_brand_b = { 0, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, 210 }; 
        public string[] lightning_brand_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        double weapon_damage, critical_damage, double_chance, critical_chance, fumble_recovery,
            max_mana, magic_damage, execute_chance, max_health, armor_bonus, block_chance;

        public Embermage()
        {
            
        }

        public void calc()
        {
            skillpointsleft = (level + fame) - magma_spear_lvl - magma_mace_lvl - firebombs_lvl - blazing_pillar_lvl - infernal_collapse_lvl -
                 immolation_aura_lvl - firestorm_lvl - charge_mastery_lvl - elemental_attunement_lvl - fire_brand_lvl -
                 icy_blast_lvl - hailstorm_lvl - frost_phase_lvl - elemental_boon_lvl - frost_wave_lvl -
                 ice_prison_lvl - astral_ally_lvl - staff_mastery_lvl - frozen_fate_lvl - ice_brand_lvl -
                 prismatic_bolt_lvl - shocking_burst_lvl - thunder_locus_lvl - arc_beam_lvl - deaths_bounty_lvl -
                 shockbolts_lvl - shocking_orb_lvl - prismatic_rift_lvl - wand_chaos_lvl - lightning_brand_lvl;
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

            int magma_spear_damage = (int)Math.Ceiling(magma_spear_c[magma_spear_lvl] * damage_monster[level] / 100) * magma_spear_d[magma_spear_lvl];
            magma_spear_text = "Вы обстреливаете врагов струей магмы, которая" + Environment.NewLine + "пробивает и поджигает их. Радиус зоны поражения 16 м." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + magma_spear_mana[magma_spear_lvl] + " в сек." + Environment.NewLine +
                "Наносит " + magma_spear_a[magma_spear_lvl] + "% от урона текущего оружия в сек. огнем" + Environment.NewLine +
                magma_spear_b[magma_spear_lvl] + "% шанс на +" + magma_spear_damage + " Огнен. урона в теч. " + magma_spear_d[magma_spear_lvl] + " сек.*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус увеличен до 24 м" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Время горения увеличено до 6 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Магматическое копье отскакивает от препятствий" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            int magma_mace_damage = (int)Math.Ceiling(magma_mace_c[magma_mace_lvl] * damage_monster[level] / 100) * 6;
            magma_mace_text = "Вы призываете огромную огненную палицу, которая оглушает" + Environment.NewLine + 
                "и поджигает врагов в секторе радиусом 5 м. Заряд при этом не создается." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + magma_mace_mana[magma_mace_lvl] + Environment.NewLine +
                "Наносит " + magma_mace_a[magma_mace_lvl] + "% от урона текущего оружия в сек. огнем" + Environment.NewLine +
                "80% шанс оглушить цель на 3 сек." + Environment.NewLine +
                magma_mace_damage + " Огнен. урона в теч. 6 сек.*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Магматическая палица с 25% вероятностью разбивает щиты." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Удар на 3 сек. замедляет атаки врагов на 33%." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Удар на 3 сек. замедляет атаки врагов на 67%." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            int firebombs_mindam = (int)Math.Floor(Math.Ceiling(30 * damage_monster[level] / 100) * firebombs_c[firebombs_lvl]);
            int firebombs_maxdam = (int)Math.Floor(Math.Ceiling(60 * damage_monster[level] / 100) * firebombs_c[firebombs_lvl]);
            firebombs_text = "Атака тремя огненными бомбами, которые поджигают землю на 3 сек." + Environment.NewLine + 
                "Кроме того, иногда попавшие в ловушку враги мечутся в панике и тоже " + Environment.NewLine +
                "возгораются. Уровень Заряда при этом не увеличивается." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + firebombs_mana[firebombs_lvl] + Environment.NewLine +
                "Время между активациями: " + firebombs_f[firebombs_lvl] + " сек." + Environment.NewLine +
                firebombs_mindam + "-" + firebombs_maxdam + " Огнен. урона в теч. " + firebombs_c[firebombs_lvl] + " сек.*" + Environment.NewLine +
                "-" + firebombs_d[firebombs_lvl] + "% от скорости движения в теч. " + firebombs_c[firebombs_lvl] + " сек." + Environment.NewLine +
                firebombs_e[firebombs_lvl] + "% шанс обратить цель в бегство на " + firebombs_c[firebombs_lvl] + " сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Земля горит 4 сек. Время между активациями уменьшено до 1,6 сек." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Земля горит 5 сек. Время между активациями уменьшено до 1,2 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Земля горит 6 сек. Время между активациями уменьшено до 0,8 сек." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            int blazing_pillar_mindam = (int)Math.Ceiling(75 * damage_monster[level] / 100);
            int blazing_pillar_maxdam = (int)Math.Ceiling(blazing_pillar_b[blazing_pillar_lvl] * damage_monster[level] / 100);   
            blazing_pillar_text = "Атака четырьмя огромными огненными столпами." + Environment.NewLine + 
                "Повышает уровень Заряда." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + blazing_pillar_mana[blazing_pillar_lvl] + Environment.NewLine +
                "Время между активациями: " + blazing_pillar_d[blazing_pillar_lvl] + " сек." + Environment.NewLine +
                "+" + blazing_pillar_mindam + "-" + blazing_pillar_maxdam + " к Огнен. урону*" + Environment.NewLine +
                blazing_pillar_c[blazing_pillar_lvl] + "% шанс поджечь цель на 7 сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Вы создаете 5 огненных столпов." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Вы создаете 6 огненных столпов." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Вы создаете 7 огненных столпов." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            int infernal_collapse_mindam = (int)Math.Ceiling(infernal_collapse_a[infernal_collapse_lvl] * damage_monster[level] / 100);
            int infernal_collapse_maxdam = (int)Math.Ceiling(infernal_collapse_b[infernal_collapse_lvl] * damage_monster[level] / 100);
            infernal_collapse_text = "Вы создаете шар из раскаленной материи, который резко расширяется," + Environment.NewLine + 
                "накрывая взрывом сектор радиусом 4 м." + "                                                                   " + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + infernal_collapse_mana[infernal_collapse_lvl] + Environment.NewLine +
                "Время между активациями: " + infernal_collapse_d[infernal_collapse_lvl] + Environment.NewLine +
                "+" + infernal_collapse_mindam + "-" + infernal_collapse_maxdam + " к Огнен. урону*" + Environment.NewLine +
                "+" + infernal_collapse_c[infernal_collapse_lvl] + " к отбрасыванию" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус зоны взрыва увеличен до 5 м. Враги отлетают дальше." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус зоны взрыва увеличен до 6 м. Враги отлетают дальше." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус зоны взрыва увеличен до 7 м. Враги отлетают дальше." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            int immolation_aura_damage = (int)Math.Ceiling(immolation_aura_b[immolation_aura_lvl] * damage_monster[level] / 100);
            immolation_aura_text = "Вас окружает огненный вихрь, наносящий урон" + Environment.NewLine + "врагам, находящимся в радиусе 3 м." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + immolation_aura_mana[immolation_aura_lvl] + Environment.NewLine +
                "Эффект длится " + immolation_aura_c[immolation_aura_lvl] + " сек." + Environment.NewLine +
                immolation_aura_damage + " Огнен. урона в теч. 1 сек.*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Аура поглощает 5% наносимого вам урона." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Аура поглощает 10% наносимого вам урона." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Аура поглощает 15% наносимого вам урона." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            int firestorm_dot_mindam = (int)Math.Ceiling(firestorm_a[firestorm_lvl] * damage_monster[level] / 100) * 6;
		    int firestorm_dot_maxdam = (int)Math.Ceiling(firestorm_b[firestorm_lvl] * damage_monster[level] / 100) * 6;
		    int firestorm_instant_mindam = (int)Math.Ceiling(20 * damage_monster[level] / 100);
		    int firestorm_instant_maxdam = (int)Math.Ceiling(30 * damage_monster[level] / 100);
            firestorm_text = "Небесный огонь поджигает всех врагов в радиусе 15 м. Вражеская" + Environment.NewLine +
                "уязвимость к огню повышается. Уровень Заряда при этом не увеличивается." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + firestorm_mana[firestorm_lvl] + Environment.NewLine +
                "Время между активациями: " + firestorm_g[firestorm_lvl] + " сек." + Environment.NewLine +
                firestorm_dot_mindam + "-" + firestorm_dot_maxdam + " Огнен. урона в теч. 6 сек.*" + Environment.NewLine +
                "+" + firestorm_c[firestorm_lvl] + "% к получаемому Огнен. урону в теч. 6 сек." + Environment.NewLine;
            if (firestorm_lvl >= 10)
            {
                firestorm_text += "+" + firestorm_instant_mindam + "-" + firestorm_instant_maxdam + " к Огнен. урону*" + Environment.NewLine;
            }
            firestorm_text += Environment.NewLine + 
                "Преимущество I уровня" + Environment.NewLine + "Пораженные враги наносят на 30% меньше урона." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Убитые враги распадаются на горящие осколки." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус полета горящих осколков увеличен вдвое." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
            
            charge_mastery_text = "Ваше мастерство позволяет вам быстрее" + Environment.NewLine +
                "набирать Заряд и дольше его сохранять.            " + Environment.NewLine + Environment.NewLine +
                "-" + charge_mastery_a[charge_mastery_lvl] + "% от скорости рассеивания Заряда" + Environment.NewLine +
                "+" + charge_mastery_b[charge_mastery_lvl] + "% к скорости увеличения Заряда";

            elemental_attunement_text = "Эмберлинг находится в тесном контакте с природой, и это позволяет" + Environment.NewLine +
                "ему продлевать действие эффектов магии стихий на врагов.                          " + Environment.NewLine + Environment.NewLine +
                "+" + elemental_attunement_a[elemental_attunement_lvl] + " сек. к времени горения/удара током/заморозки/отравления" + Environment.NewLine +
                elemental_attunement_a[elemental_attunement_lvl] + "% шанс поджечь цель на 1 сек." + Environment.NewLine +
                elemental_attunement_a[elemental_attunement_lvl] + "% шанс заморозить цель на 1 сек." + Environment.NewLine +
                elemental_attunement_a[elemental_attunement_lvl] + "% шанс бить цель током в теч. 1 сек." + Environment.NewLine +
                elemental_attunement_a[elemental_attunement_lvl] + "% шанс отравить цель на 1 сек.";

            int fire_brand_mindam = (int)Math.Ceiling(fire_brand_a[fire_brand_lvl] * damage_monster[level] / 100);
            int fire_brand_maxdam = (int)Math.Ceiling(fire_brand_b[fire_brand_lvl] * damage_monster[level] / 100);
            fire_brand_text = "Атакуя горящего врага, вы наносите ему" + Environment.NewLine +
                "дополнительный огненный урон." + Environment.NewLine + Environment.NewLine +
                "+" + fire_brand_mindam + "-" + fire_brand_maxdam + " к Огнен. урону*" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            icy_blast_text = "Обстрел врагов 5 рикошетящими ледяными снарядами," + Environment.NewLine + 
                "которые замедляют и обездвиживают их.                                      " + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + icy_blast_mana[icy_blast_lvl] + Environment.NewLine +
                "Наносит " + icy_blast_a[icy_blast_lvl] + "% от урона текущего оружия в сек. льдом" + Environment.NewLine +
                icy_blast_b[icy_blast_lvl] + "% шанс заморозить цель на " + icy_blast_c[icy_blast_lvl] + " сек." + Environment.NewLine +
                icy_blast_d[icy_blast_lvl] + "% шанс обездвижить цель на " + icy_blast_e[icy_blast_lvl] + " сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "На 6 сек. наносимый цели урон уменьшается на 20%" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "75% к шансу обездвижить врага в течение 4 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Число зарядов увеличено до 7 на сектор поражения" + Environment.NewLine;

            int hailstorm_mindam = (int)Math.Ceiling(hailstorm_b[hailstorm_lvl] * damage_monster[level] / 100);
            int hailstorm_maxdam = (int)Math.Ceiling(hailstorm_c[hailstorm_lvl] * damage_monster[level] / 100);
            hailstorm_text = "Сверху падают ледяные осколки, наносящие урон врагу в радиусе 15 метров." + Environment.NewLine + 
                "Уровень Заряда при этом не увеличивается.                                                                       "+Environment.NewLine+Environment.NewLine+
                "Расход маны: " + hailstorm_mana[hailstorm_lvl] + Environment.NewLine +
                "Время между активациями: " + hailstorm_f[hailstorm_lvl] + " сек." + Environment.NewLine +
                hailstorm_a[hailstorm_lvl] + "% шанс оглушить цель на 3 сек." + Environment.NewLine +
                "+"+hailstorm_mindam + "-" + hailstorm_maxdam + " к Лед. урону*" + Environment.NewLine+
                hailstorm_d[hailstorm_lvl] + "% шанс заморозить цель на 6 сек." + Environment.NewLine +
                "+" + hailstorm_e[hailstorm_lvl] + "% к получаемому Электр. урону в теч. 6 сек." + Environment.NewLine +
                "+" + hailstorm_e[hailstorm_lvl] + "% к получаемому Лед. урону в теч. 6 сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "На 6 сек. сопротивление жертв ледяным и электрическим атакам ниже на 20%." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "На 6 сек. сопротивление жертв ледяным и электрическим атакам ниже на 40%." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "На 6 сек. сопротивление жертв ледяным и электрическим атакам ниже на 60%." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            int frost_phase_mindam = (int)Math.Ceiling(35 * damage_monster[level] / 100);
            int frost_phase_maxdam = (int)Math.Ceiling(frost_phase_b[frost_phase_lvl] * damage_monster[level] / 100);                       
            frost_phase_text = "Вы мгновенно телепортируетесь, нанося урон" + Environment.NewLine + 
                "холодом врагам в радиусе 2,5 м от обеих точек." + Environment.NewLine + Environment.NewLine+
                "Расход маны: "+frost_phase_mana[frost_phase_lvl] + Environment.NewLine +
                "+" + frost_phase_mindam + "-" + frost_phase_maxdam + " к Лед. урону*" + Environment.NewLine +
                "+" + frost_phase_c[frost_phase_lvl] + " к отбрасыванию" + Environment.NewLine +
                frost_phase_d[frost_phase_lvl] + "% шанс заморозить цель на 3 сек." + Environment.NewLine + Environment.NewLine+
                "Преимущество I уровня" + Environment.NewLine + "Радиус зоны поражения увеличен до 3,75 м." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус зоны поражения увеличен до 5 м." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус зоны поражения увеличен до 6,25 м" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            elemental_boon_text = "Особая аура повышает наносимый вами урон магией стихий и сопротивляемость" + Environment.NewLine +
                "к атакам этой магии. Эффект длится 60 сек. и действует также на всех союзников         " + Environment.NewLine +
                "в радиусе 12 м." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + elemental_boon_mana[elemental_boon_lvl] + Environment.NewLine +
                "Время между активациями: 30 сек." + Environment.NewLine +
                "-" + elemental_boon_b[elemental_boon_lvl] + "% от получаемого Отравл. урона в теч. 15 сек." + Environment.NewLine +
                "-" + elemental_boon_b[elemental_boon_lvl] + "% от получаемого Электр. урона в теч. 15 сек." + Environment.NewLine +
                "-" + elemental_boon_b[elemental_boon_lvl] + "% от получаемого Лед. урона в теч. 15 сек." + Environment.NewLine +
                "-" + elemental_boon_b[elemental_boon_lvl] + "% от получаемого Огнен. урона в теч. 15 сек." + Environment.NewLine +
                "+" + elemental_boon_d[elemental_boon_lvl] + "% к Огнен. урону в теч. 15 сек." + Environment.NewLine +
                "+" + elemental_boon_d[elemental_boon_lvl] + "% к Лед. урону в теч. 15 сек." + Environment.NewLine +
                "+" + elemental_boon_d[elemental_boon_lvl] + "% к Отравл. урону в теч. 15 сек." + Environment.NewLine +
                "+" + elemental_boon_d[elemental_boon_lvl] + "% к Электр. урону в теч. 15 сек." + Environment.NewLine;
            if (elemental_boon_lvl >= 5)
            {
                elemental_boon_text += "+" + elemental_boon_c[elemental_boon_lvl] + " сопротивление замедлению на 15 сек." + Environment.NewLine +
                    "+" + elemental_boon_c[elemental_boon_lvl] + " сопротивление обездвиживанию на 15 сек." + Environment.NewLine;
            }
            if (elemental_boon_lvl >= 10)
            {
                elemental_boon_text += "Восполняется " + elemental_boon_a[elemental_boon_lvl] + " ед. маны в теч. 10 сек." + Environment.NewLine;
            }
            elemental_boon_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Устойчивость к эффектам замедления и обездвиживания." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Уровень маны восстанавливается." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Заклинания можно применять чаще, и они расходуют меньше маны.";                

            int frost_wave_instant_mindam = (int)Math.Ceiling(70 * damage_monster[level] / 100);
            int frost_wave_instant_maxdam = (int)Math.Ceiling(140 * damage_monster[level] / 100);
            int frost_wave_dot = (int)Math.Ceiling(frost_wave_d[frost_wave_lvl] * damage_monster[level] / 100) * 7;
            frost_wave_text = "Атака волной ледяных осколков, которые замораживают" + Environment.NewLine + 
                "и пронзают врагов.                                                                           " + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + frost_wave_mana[frost_wave_lvl] + Environment.NewLine +
                "+" + frost_wave_instant_mindam + "-" + frost_wave_instant_maxdam + " к Лед. урону*" + Environment.NewLine +
                frost_wave_c[frost_wave_lvl] + "% шанс заморозить цель на 7 сек." + Environment.NewLine +
                frost_wave_dot + " Лед. урона в теч. 7 сек.*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Ледяных волн: 3" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Скорость ледяной волны увеличивается" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Ледяных волн: 5" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
                         
            int ice_prison_mindam = (int)Math.Ceiling(30 * damage_monster[level] / 100) * 5;
            int ice_prison_maxdam = (int)Math.Ceiling(50 * damage_monster[level] / 100) * 5;
            ice_prison_text = "Вы заключаете цель в ледяную тюрьму. Враг, в отличие от вас, " + Environment.NewLine +
                "не может пройти через ее стены. Если враг атакует ледяные          " + Environment.NewLine +
                "колонны, они отражают нанесенный урон." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + ice_prison_mana[ice_prison_lvl] + Environment.NewLine +
                "Время между активациями: " + ice_prison_f[ice_prison_lvl] + " сек." + Environment.NewLine +
                "Колонны существуют " + ice_prison_a[ice_prison_lvl] + " сек." + Environment.NewLine +
                ice_prison_b[ice_prison_lvl] + "% урона приходится на нападающего" + Environment.NewLine;
            if (ice_prison_lvl >= 5)
            {
                ice_prison_text += "100% шанс уничтожить цель заклинанием \"раздробить\"" + Environment.NewLine;
            }
            if (ice_prison_lvl >= 10)
            {
                ice_prison_text = ice_prison_mindam + "-" + ice_prison_maxdam + " Лед. урона в теч. 5 сек.*" + Environment.NewLine; 
            }
            ice_prison_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "При разрушении ледяные колонны наносят урон" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Враг, попавший в тюрьму, постоянно получает урон" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Время активации снижено до 2 сек." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            int astral_ally_mindam = (int)Math.Ceiling(100 * (double)damage_minion_bylevel[level] / 100);
            int astral_ally_maxdam = (int)Math.Ceiling(150 * (double)damage_minion_bylevel[level] / 100);
            astral_ally_text = "Вызов астрального клона другого эмберлинга: он" + Environment.NewLine +
                "сражается на вашей стороне, поражая врагов            " + Environment.NewLine +
                "мощными заклинаниями." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + astral_ally_mana[astral_ally_lvl] + Environment.NewLine +
                "Время между активациями: " + astral_ally_e[astral_ally_lvl] + " сек." + Environment.NewLine +
                "Время вызова: " + astral_ally_a[astral_ally_lvl] + " сек." + Environment.NewLine +
                "Помощники наносят " + astral_ally_mindam + "-" + astral_ally_maxdam + " Физич. урона*" + Environment.NewLine +
                "+" + astral_ally_b[astral_ally_lvl] + "% к Люб. урону" + Environment.NewLine +
                "+" + astral_ally_b[astral_ally_lvl] + "% к Физич. броне" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Астральный союзник появляется на 30 сек." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Астральный союзник появляется на 40 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Астральный союзник появляется на 50 сек." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            staff_mastery_text = "Каждый точный удар посохом, магматической палицей, магматическим копьем," + Environment.NewLine + 
                "ледяным залпом и электроразрядами снижает сопротивление врага магии стихий." + Environment.NewLine + Environment.NewLine +
                "-" + staff_mastery_a[staff_mastery_lvl] + "% от Электр. брони в теч. 8 сек." + Environment.NewLine +
                "-" + staff_mastery_a[staff_mastery_lvl] + "% от Отравл. брони в теч. 8 сек." + Environment.NewLine +
                "-" + staff_mastery_a[staff_mastery_lvl] + "% от Лед. брони в теч. 8 сек." + Environment.NewLine +
                "-" + staff_mastery_a[staff_mastery_lvl] + "% от Огнен. брони в теч. 8 сек." + Environment.NewLine + Environment.NewLine +
                "Необходим посох";

            frozen_fate_text = "Уничтожив врага, вы получаете шанс заморозить до 4" + Environment.NewLine +
                "противников, находящихся в радиусе 7 метров.               " + Environment.NewLine + Environment.NewLine +
                frozen_fate_a[frozen_fate_lvl] + "% шанс обездвижить цель на " + frozen_fate_b[frozen_fate_lvl] + " сек.";

            
            int ice_brand_mindam = (int)Math.Ceiling(70 * damage_monster[level] / 100);
            int ice_brand_maxdam = (int)Math.Ceiling(ice_brand_b[ice_brand_lvl] * damage_monster[level] / 100);
            ice_brand_text = "Атакуя замороженного врага, вы наносите ему" + Environment.NewLine +
                "дополнительный ледяной урон.                                  " + Environment.NewLine + Environment.NewLine +
                "+" + ice_brand_mindam + "-" + ice_brand_maxdam + " к Лед. урону*" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
            
            int prismatic_bolt_dam = (int)Math.Floor(Math.Ceiling(12 * damage_monster[level] / 100) * prismatic_bolt_b[prismatic_bolt_lvl]);
            prismatic_bolt_text = "Вы обрушиваете на врагов 5 самонаводящихся" + Environment.NewLine +
                "призматических зарядов.                                              " + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + prismatic_bolt_mana[prismatic_bolt_lvl] + Environment.NewLine +
                "+" + prismatic_bolt_dam + " к Огнен. урону*" + Environment.NewLine +
                "+" + prismatic_bolt_dam + " к Лед. урону*" + Environment.NewLine +
                "+" + prismatic_bolt_dam + " к Электр. урону*" + Environment.NewLine +
                "+" + prismatic_bolt_dam + " к Отравл. урону*" + Environment.NewLine +
                prismatic_bolt_c[prismatic_bolt_lvl] + "% шанс отравить цель на " + prismatic_bolt_d[prismatic_bolt_lvl] + " сек." + Environment.NewLine +
                prismatic_bolt_c[prismatic_bolt_lvl] + "% шанс поджечь цель на " + prismatic_bolt_d[prismatic_bolt_lvl] + " сек." + Environment.NewLine +
                prismatic_bolt_c[prismatic_bolt_lvl] + "% шанс бить цель током в теч. " + prismatic_bolt_d[prismatic_bolt_lvl] + " сек." + Environment.NewLine +
                prismatic_bolt_c[prismatic_bolt_lvl] + "% шанс заморозить цель на " + prismatic_bolt_d[prismatic_bolt_lvl] + " сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Урон увеличен на 10%" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Урон увеличен на 20%" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Урон увеличен на 30%";
                        
            int shocking_burst_mindam = (int)Math.Ceiling(20 * damage_monster[level] / 100);
            int shocking_burst_maxdam = (int)Math.Ceiling(shocking_burst_c[shocking_burst_lvl] * damage_monster[level] / 100);
            shocking_burst_text = "Вы обрушиваете на врагов электрический разряд, который оглушает" + Environment.NewLine +
                "их и наносит урон. Зона действия - сектор с углом 75 градусов и радиусом      " + Environment.NewLine +
                "8 м. Эффект длится, пока вы удерживаете кнопку мыши, и столько же" + Environment.NewLine +
                "времени тратится мана." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + shocking_burst_mana[shocking_burst_lvl] + " в сек." + Environment.NewLine +
                "Наносит " + shocking_burst_a[shocking_burst_lvl] + "% от урона текущего оружия в сек. электричеством" + Environment.NewLine +
                shocking_burst_mindam + "-" + shocking_burst_maxdam + " Электр. урона в теч. 1 сек.*" + Environment.NewLine +
                "Взрыв при гибели" + Environment.NewLine +
                shocking_burst_d[shocking_burst_lvl] + "% шанс оглушить цель на " + shocking_burst_e[shocking_burst_lvl] + " сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Угол сектора увеличен до 105 градусов" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Угол сектора увеличен до 135 градусов" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Угол сектора увеличен до 165 градусов" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
            
            int thunder_locus_mindam = (int)Math.Ceiling(thunder_locus_b[thunder_locus_lvl] * damage_monster[level] / 100);
            int thunder_locus_maxdam = (int)Math.Ceiling(thunder_locus_c[thunder_locus_lvl] * damage_monster[level] / 100);
            thunder_locus_text = "В заданной точке появляется миниатюрный вихрь с громом и молнией." + Environment.NewLine +
                "Противники, находящиеся в радиусе 7 метров, получают урон до тех пор,     " + Environment.NewLine +
                "пока вихрь не исчезнет. Сгусток энергии не повышает уровень Зарядов." + Environment.NewLine + Environment.NewLine+
                "Расход маны: "+thunder_locus_mana[thunder_locus_lvl] + Environment.NewLine +
                "Время между активациями: 10 сек." + Environment.NewLine +
                "Время вызова: " + thunder_locus_a[thunder_locus_lvl] + " сек." + Environment.NewLine +
                "+" + thunder_locus_mindam + "-" + thunder_locus_maxdam + " к Электр. урону*" + Environment.NewLine +Environment.NewLine+
                "Преимущество I уровня" + Environment.NewLine + "Молния поражает двух врагов" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Молния поражает трех врагов" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Молния поражает четырех врагов" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
            
            int arc_beam_mindam = (int)Math.Ceiling(10 * damage_monster[level] / 100);
            int arc_beam_maxdam = (int)Math.Ceiling(20 * damage_monster[level] / 100);
            arc_beam_text = "Ваше оружие излучает направленный поток энергии." + Environment.NewLine +
                "Дополнительный эффект: если противник погибает," + Environment.NewLine +
                "луч расщепляется и наносит урон находящимся рядом врагам." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + arc_beam_mana[arc_beam_lvl] + " в сек." + Environment.NewLine +
                "Наносит " + arc_beam_a[arc_beam_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                "Взрыв при гибели" + Environment.NewLine +
                "+" + arc_beam_mindam + "-" + arc_beam_maxdam + " к Электр. урону*" + Environment.NewLine +
                "+5 к отбрасыванию" + Environment.NewLine +
                "Дополнительный эффект: " + Environment.NewLine +
                "Наносит " + arc_beam_d[arc_beam_lvl] + "% урона от оружия электричеством" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Луч расщепляется до 3 раз" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Луч расщепляется до 4 раз" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Луч расщепляется до 5 раз" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока" + Environment.NewLine + Environment.NewLine +
                "Необходим посох или жезл.";

            int deaths_bounty_hp_regen = (int)Math.Ceiling(deaths_bounty_a[deaths_bounty_lvl] * health_player_generic[level] / 100);
            int deaths_bounty_mana_regen = (int)Math.Floor(deaths_bounty_a[deaths_bounty_lvl] * mana_player_generic[level] / 10) / 10;
            deaths_bounty_text = "Вы связываете жизненную энергию всех врагов, находящихся в радиусе 6 м от цели." + Environment.NewLine +
                "После их гибели здоровье и мана переходят к вам или другим игрокам в виде 3 разрядов." + Environment.NewLine +
                "Количество здоровья и маны указано для одного заряда." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + deaths_bounty_mana[deaths_bounty_lvl] + Environment.NewLine +
                "Время между активациями: " + deaths_bounty_b[deaths_bounty_lvl] + " сек." + Environment.NewLine +
                "Восполняется " + deaths_bounty_hp_regen + " ед. здоровья в сек.*" + Environment.NewLine +
                "Восполняется " + deaths_bounty_mana_regen + " ед. маны в сек.*" + Environment.NewLine;
            if (deaths_bounty_lvl >= 5)
            {
                deaths_bounty_text += "-33% от скорости движения в теч.  2 сек." + Environment.NewLine;                    
            }
            deaths_bounty_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Вы получаете 4 заряда; враги замедляются на 2 сек." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Вы получаете 5 зарядов; скорость применения заклинаний возрастает на 50%" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Вы получаете 6 зарядов; враги оглушаются на 1 сек." + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            shockbolts_text = "4 электрических разряда летят над землей и отскакивают от препятствий" + Environment.NewLine + Environment.NewLine +
                    "Расход маны: " + shockbolts_mana[shockbolts_lvl] + Environment.NewLine +
                    shockbolts_a[shockbolts_lvl] + "% урона от оружия электричеством" + Environment.NewLine;
            if (shockbolts_lvl >= 5)
            {
                shockbolts_text += "10% шанс обездвижить цель на 3 сек." + Environment.NewLine;                    
            }
            shockbolts_text += Environment.NewLine +           
                "Преимущество I уровня" + Environment.NewLine + "10% вероятность того, что разряд обездвижит врага" + Environment.NewLine +              "Преимущество II уровня" + Environment.NewLine + "Скорость разрядов увеличивается" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Вы выпускаете 5 разрядов";

            shocking_orb_text = "Медленно движущийся шар поражает электрическими" + Environment.NewLine +
                "зарядами находящихся рядом врагов.                     " + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + shocking_orb_mana[shocking_orb_lvl] + Environment.NewLine +
                "Наносит " + shocking_orb_a[shocking_orb_lvl] + "% урона от оружия электричеством" + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Вы выпускаете 3 шара" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Шары отскакивают от препятствий" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус поражения увеличен на 50%";

            prismatic_rift_text = "Энергия хаоса телепортирует врага, который нанес вам удар. Кроме того, может" + Environment.NewLine +
                "возникнуть выбранный случайным образом магический эффект.                                  " + Environment.NewLine + Environment.NewLine +
                prismatic_rift_a[prismatic_rift_lvl] + "% шанс сотворить заклинание \"Хаотический разлом\" при получении удара";

            wand_chaos_text = "Нанесение урона врагам жезлом, магматической палицей, магматическим" + Environment.NewLine +
                "копьем, ледяным залпом и электроразрядами может привести к странным      " + Environment.NewLine +
                "случайным нарушениям стихий." + Environment.NewLine + Environment.NewLine +
                wand_chaos_a[wand_chaos_lvl] + "% шанс сотворить заклинание \"Странный эффект\" при атаке";

            int lightning_brand_mindam = (int)Math.Ceiling(lightning_brand_a[lightning_brand_lvl] * damage_monster[level] / 100);
            int lightning_brand_maxdam = (int)Math.Ceiling(lightning_brand_b[lightning_brand_lvl] * damage_monster[level] / 100);
            lightning_brand_text = "Атакуя врага, получившего удар током, вы наносите ему" + Environment.NewLine +
                "дополнительный электрический урон.                                     " + Environment.NewLine + Environment.NewLine +
                lightning_brand_mindam + "-" + lightning_brand_maxdam + " к Электр. урону*" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";
        }
    }
}