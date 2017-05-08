using System;

namespace Skill_Calculator
{
    public class Berserker
    {
        public int skillpointsleft, level, fame, statpointsleft;
        public double strength = 15, dexterity = 15, focus = 5, vitality = 5;
        public string strength_text, dexterity_text, focus_text, vitality_text;

        public string[] fame_ranks = { "2000", "3000", "4000", "5000", "7000", "9000", "12000", "14000", "16000", "18000", "19000", "22000", "23000", "26000", "27000", "29000", "31000", "34000", "35000", "37000", "40000", "41000", "44000", "46000", "48000", "50000", "52000", "55000", "56000", "59000", "62000", "63000", "9005000", "full" };

        double[] armor_player_bylevel_forset = { 0, 8, 10, 12, 14, 17, 20, 22, 25, 28, 31, 34, 37, 40, 43, 46, 50, 53, 56, 60, 63, 67, 70, 74, 77, 81, 85, 88, 92, 96, 100, 103, 107, 111, 115, 119, 123, 127, 131, 135, 139, 143, 147, 151, 155, 159, 163, 167, 171, 176, 180, 184, 188, 192, 197, 201, 205, 209, 214, 218, 222, 226, 231, 235, 239, 244, 248, 253, 257, 261, 266, 270, 274, 279, 283, 288, 292, 297, 301, 305, 310, 314, 319, 323, 328, 332, 337, 341, 346, 350, 355, 359, 364, 368, 373, 377, 382, 386, 391, 395, 400, 405, 409, 414, 418, 423 };
        double[] damage_minion_bylevel = { 0, 24, 30, 37, 44, 51, 58, 66, 74, 83, 92, 101, 110, 120, 131, 142, 153, 164, 177, 189, 202, 215, 229, 243, 258, 273, 288, 304, 321, 338, 355, 373, 392, 411, 430, 450, 471, 492, 514, 536, 558, 582, 605, 630, 655, 680, 706, 733, 760, 788, 817, 846, 876, 906, 937, 968, 1001, 1034, 1067, 1101, 1136, 1172, 1208, 1245, 1283, 1321, 1360, 1400, 1440, 1481, 1523, 1566, 1609, 1653, 1698, 1744, 1790, 1837, 1885, 1934, 1984, 2034, 2085, 2137, 2190, 2243, 2297, 2353, 2409, 2466, 2523, 2582, 2641, 2701, 2763, 2825, 2888, 2951, 3016, 3082, 3148, 3216, 3284, 3353, 3423, 3495 };
        double[] damage_monster = { 0, 10, 14, 19, 23.9, 29, 34.5, 40.200001, 46.299999, 52.599998, 59.299999, 66.400002, 73.800003, 81.5, 89.599998, 98.099998, 106.900002, 116.099998, 125.699997, 135.699997, 146.100006, 157, 168.199997, 179.899994, 192, 204.600006, 217.699997, 231.199997, 245.199997, 259.600006, 274.600006, 290.100006, 306.100006, 322.600006, 339.600006, 357.200012, 375.299988, 394, 413.299988, 433.100006, 453.600006, 474.600006, 496.200012, 518.5, 541.400024, 564.900024, 589.099976, 613.900024, 639.400024, 665.599976, 692.5, 720, 748.299988, 777.299988, 807, 837.5, 868.700012, 900.700012, 933.5, 967, 1001.400024, 1036.5, 1072.5, 1109.300049, 1147, 1185.5, 1224.800049, 1265.099976, 1306.199951, 1348.199951, 1391.099976, 1435, 1479.800049, 1525.5, 1572.199951, 1619.900024, 1668.5, 1718.099976, 1768.800049, 1820.400024, 1873.099976, 1926.900024, 1981.699951, 2037.5, 2094.5, 2152.5, 2211.600098, 2271.899902, 2333.300049, 2395.800049, 2459.5, 2524.300049, 2590.399902, 2657.600098, 2726.100098, 2795.800049, 2866.699951, 2938.800049, 3012.300049, 3087, 3163, 3240.300049, 3318.899902, 3398.800049, 3480.100098, 3562.800049 };
        double[] armor_monster_bylevel = { 0, 4, 7, 8, 11, 14, 18, 21, 25, 28, 32, 37, 41, 46, 50, 55, 61, 66, 72, 77, 83, 90, 96, 102, 109, 116, 123, 131, 138, 146, 154, 162, 170, 179, 188, 196, 206, 215, 224, 234, 244, 254, 264, 275, 286, 296, 307, 319, 330, 342, 354, 366, 378, 390, 403, 416, 429, 442, 456, 469, 483, 497, 511, 526, 540, 555, 570, 585, 601, 616, 632, 648, 664, 680, 697, 714, 731, 748, 765, 783, 800, 818, 836, 855, 873, 892, 911, 930, 949, 969, 988, 1008, 1028, 1049, 1069, 1090, 1111, 1132, 1153, 1175, 1196, 1218, 1240, 1262, 1285, 1307 };

        public int eviscerate_lvl = 0;
        public string eviscerate_text;
        double[] eviscerate_a = { 0, 88, 91, 94, 97, 100, 103, 106, 109, 112, 115, 118, 121, 124, 127, 130 };
        double[] eviscerate_b = { 0, 15, 16, 17, 18, 28.5, 30, 31.5, 33, 34.5, 72, 75, 78, 81, 84, 87 };
        double[] eviscerate_c = { 0, 6, 6, 6, 6, 4, 4, 4, 4, 4, 2, 2, 2, 2, 2, 2 };
        double[] eviscerate_mana = { 0, 11, 12, 13, 14, 15, 17, 19, 22, 24, 27, 31, 34, 37, 42, 46 };
        public string[] eviscerate_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int howl_lvl = 0;
        public string howl_text;
        double[] howl_a = { 0, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43 };
        double[] howl_b = { 0, 15, 17, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42 };
        double[] howl_c = { 0, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10, 11, 11, 12, 12, 13 };
        double[] howl_d = { 0, 5, 5, 5, 5, 7.5, 7.5, 7.5, 7.5, 7.5, 10, 10, 10, 10, 10, 12.5 };
        double[] howl_mana = { 0, 13, 14, 15, 16, 18, 19, 21, 23, 25, 29, 32, 34, 38, 43, 47 };
        public string[] howl_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int raze_lvl = 0;
        public string raze_text;
        double[] raze_a = { 0, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195, 200, 205, 210 };
        double[] raze_b = { 0, 0, 0, 0, 0, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15 };
        double[] raze_c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 25, 25, 25, 25, 25, 25 };
        double[] raze_d = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 65 };
        double[] raze_e = { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75 };
        double[] raze_mana = { 0, 16, 16, 17, 17, 18, 19, 20, 22, 24, 27, 30, 33, 36, 39, 43 };
        public string[] raze_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int wolfstrike_lvl = 0;
        public string wolfstrike_text;
        double[] wolfstrike_a = { 0, 88, 92, 96, 100, 104, 108, 112, 116, 120, 124, 128, 132, 136, 140, 144 };
        double[] wolfstrike_b = { 0, 41, 42, 43, 44, 46, 49, 53, 57, 63, 69, 78, 86, 95, 105, 115 };
        double[] wolfstrike_c = { 0, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75 };
        double[] wolfstrike_mana = { 0, 18, 19, 20, 20, 20, 22, 23, 24, 27, 29, 31, 34, 38, 41, 45 };
        public string[] wolfstrike_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int battle_rage_lvl = 0;
        public string battle_rage_text;
        double[] battle_rage_a = { 0, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10 };
        double[] battle_rage_b = { 0, 0, 0, 0, 0, 2, 2.5, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7 };
        double[] battle_rage_c = { 0, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6 };
        double[] battle_rage_mana = { 0, 21, 21, 21, 22, 22, 23, 24, 25, 27, 29, 32, 35, 37, 41, 44 };
        public string[] battle_rage_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int rupture_lvl = 0;
        public string rupture_text;
        double[] rupture_a = { 0, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92 };
        double[] rupture_b = { 0, 200, 215, 230, 245, 260, 275, 290, 305, 320, 335, 350, 365, 380, 395, 410 };
        double[] rupture_mana = { 0, 31, 31, 31, 31, 32, 33, 35, 36, 38, 41, 44, 48, 51, 55, 58 };
        public string[] rupture_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int ravage_lvl = 0;
        public string ravage_text;
        double[] ravage_a = { 0, 25, 26.5, 28, 29.5, 31, 32.5, 34, 35.5, 37, 38.5, 40, 41.5, 43, 44.5, 46 };
        double[] ravage_b = { 0, 0, 0, 0, 0, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
        double[] ravage_c = { 0, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 };
        double[] ravage_d = { 0, 4, 4, 4, 4, 4, 4, 4, 4, 4, 6, 6, 6, 6, 6, 6 };
        double[] ravage_mana = { 0, 40, 41, 41, 42, 44, 46, 47, 49, 51, 55, 57, 60, 63, 68, 71 };
        public string[] ravage_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int blood_hunger_lvl = 0;
        public string blood_hunger_text;
        double[] blood_hunger_a = { 0, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12 };
        public string[] blood_hunger_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int executioner_lvl = 0;
        public string executioner_text;
        double[] executioner_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
        double[] executioner_b = { 0, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48 };
        public string[] executioner_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int rampage_lvl = 0;
        public string rampage_text;
        double[] rampage_a = { 0, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33 };
        public string[] rampage_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int frost_breath_lvl = 0;
        public string frost_breath_text;
        double[] frost_breath_a = { 0, 15, 16.5, 18, 19.5, 21, 23.5, 25, 26.5, 28, 29.5, 31, 32.5, 34, 35.5, 37 };
        double[] frost_breath_b = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        double[] frost_breath_mana = { 0, 12, 13, 14, 16, 17, 19, 22, 24, 26, 30, 34, 37, 41, 46, 50 };
        public string[] frost_breath_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int stormclaw_lvl = 0;
        public string stormclaw_text;
        double[] stormclaw_a = { 0, 40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82 };
        double[] stormclaw_mana = { 0, 18, 19, 21, 22, 24, 25, 28, 31, 34, 39, 43, 46, 52, 58, 64 };
        public string[] stormclaw_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int storm_hatchet_lvl = 0;
        public string storm_hatchet_text;
        double[] storm_hatchet_a = { 0, 85, 88, 91, 94, 97, 100, 103, 106, 109, 112, 115, 118, 121, 124, 127 };
        double[] storm_hatchet_b = { 0, 1.6, 1.6, 1.6, 1.6, 2.2, 2.2, 2.2, 2.2, 2.2, 2.8, 2.8, 2.8, 2.8, 2.8, 3.4 };
        double[] storm_hatchet_c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 100 };
        double[] storm_hatchet_d = { 0, 5, 6, 7, 8, 9, 10, 11, 12, 13, 7, 7.5, 8, 8.5, 9, 19 };
        double[] storm_hatchet_mana = { 0, 15, 15, 16, 16, 17, 18, 19, 21, 23, 26, 28, 31, 34, 37, 41 };
        public string[] storm_hatchet_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int northern_rage_lvl = 0;
        public string northern_rage_text;
        double[] northern_rage_a = { 0, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
        double[] northern_rage_b = { 0, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170 };
        double[] northern_rage_c = { 0, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10 };
        double[] northern_rage_d = { 0, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43 };
        double[] northern_rage_mana = { 0, 29, 29, 30, 30, 31, 34, 36, 38, 41, 45, 49, 53, 59, 64, 70 };
        public string[] northern_rage_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int ice_shield_lvl = 0;
        public string ice_shield_text;
        double[] ice_shield_a = { 0, 44, 48, 52, 56, 60, 64, 68, 72, 76, 80, 84, 88, 92, 96, 100 };
        double[] ice_shield_b = { 0, 55, 61, 65, 70, 75, 80, 85, 90, 95, 100, 105, 110, 115, 120, 125 };
        double[] ice_shield_c = { 0, 50, 50, 50, 50, 75, 75, 75, 75, 75, 100, 100, 100, 100, 100, 125 };
        double[] ice_shield_mana = { 0, 30, 31, 31, 32, 33, 34, 35, 37, 39, 43, 47, 51, 55, 60, 64 };
        public string[] ice_shield_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int permafrost_lvl = 0;
        public string permafrost_text;
        double[] permafrost_a = { 0, 8, 9, 10, 11, 12, 13.1, 14.3, 15.6, 17.1, 18.1, 21.5, 24, 27.5, 32, 38.5 };
        double[] permafrost_b = { 0, 10, 9.5, 9, 8.5, 8, 7.5, 7, 6.5, 6, 5.5, 5, 4.5, 4, 3.5, 3 };
        double[] permafrost_c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 25, 25, 25, 25, 25, 50 };
        double[] permafrost_d = { 0, 0, 0, 0, 0, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 };
        double[] permafrost_mana = { 0, 29, 29, 31, 31, 32, 32, 33, 35, 37, 40, 44, 46, 50, 53, 57 };
        public string[] permafrost_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int glacial_shatter_lvl = 0;
        public string glacial_shatter_text;
        double[] glacial_shatter_a = { 0, 70, 73, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98 };
        double[] glacial_shatter_b = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 12, 14, 16, 18, 20 };
        double[] glacial_shatter_c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 22, 24, 26, 28, 30 };
        double[] glacial_shatter_d = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58 };
        double[] glacial_shatter_e = { 0, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68 };
        double[] glacial_shatter_mana = { 0, 25, 26, 26, 27, 27, 28, 29, 31, 32, 34, 36, 38, 40, 42, 44 };
        public string[] glacial_shatter_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int cold_steel_mastery_lvl = 0;
        public string cold_steel_mastery_text;
        double[] cold_steel_mastery_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
        double[] cold_steel_mastery_b = { 0, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60, 66, 72, 78, 84, 90 };
        public string[] cold_steel_mastery_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int shatter_storm_lvl = 0;
        public string shatter_storm_text;
        double[] shatter_storm_a = { 0, 3, 3.1, 3.2, 3.3, 3.4, 3.5, 3.6, 3.7, 3.8, 3.9, 4.0, 4.1, 4.2, 4.3, 4.4 };
        double[] shatter_storm_b = { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75 };
        public string[] shatter_storm_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93 ", "full" };

        public int rage_retaliation_lvl = 0;
        public string rage_retaliation_text;
        double[] rage_retaliation_a = { 0, 2, 1.8, 1.6, 1.4, 1.2, 1, 0.8, 0.6, 0.4, 0.2, 0, 0, 0, 0, 0 };
        double[] rage_retaliation_b = { 0, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 130, 140, 150, 160 };
        public string[] rage_retaliation_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int shadow_burst_lvl = 0;
        public string shadow_burst_text;
        double[] shadow_burst_a = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 68 };
        double[] shadow_burst_b = { 0, 25, 25, 25, 25, 50, 50, 50, 50, 50, 75, 75, 75, 75, 75, 100 };
        double[] shadow_burst_c = { 0, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12 };
        double[] shadow_burst_d = { 0, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 5 };
        double[] shadow_burst_mana = { 0, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 25, 28, 31, 34, 38 };
        public string[] shadow_burst_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int wolf_shade_lvl = 0;
        public string wolf_shade_text;
        double[] wolf_shade_a = { 0, 5, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };
        double[] wolf_shade_b = { 0, 5, 7, 9, 11, 13, 15, 17, 19, 21, 24, 25, 27, 29, 32, 33 };
        double[] wolf_shade_c = { 0, 15, 15, 15, 15, 30, 30, 30, 30, 30, 45, 45, 45, 45, 45, 60 };
        double[] wolf_shade_d = { 0, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
        double[] wolf_shade_e = { 0, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150 };
        double[] wolf_shade_mana = { 0, 30, 31, 32, 33, 35, 38, 42, 46, 52, 58, 65, 71, 79, 87, 96 };
        public string[] wolf_shade_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int shadowbind_lvl = 0;
        public string shadowbind_text;
        double[] shadowbind_a = { 0, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43 };
        double[] shadowbind_b = { 0, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12, 12.5, 13, 13.5, 14, 14.5, 15 };
        double[] shadowbind_mana = { 0, 10, 10, 10, 11, 11, 11, 12, 13, 14, 16, 18, 19, 21, 24, 27 };
        public string[] shadowbind_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };

        public int savage_rush_lvl = 0;
        public string savage_rush_text;
        double[] savage_rush_a = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        double[] savage_rush_b = { 0, 10, 10, 10, 10, 20, 20, 20, 20, 20, 30, 30, 30, 30, 30, 40 };
        double[] savage_rush_c = { 0, 4, 4, 4, 4, 6, 6, 6, 6, 6, 8, 8, 8, 8, 8, 10 };
        double[] savage_rush_d = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        double[] savage_rush_mana = { 0, 12, 12, 13, 13, 14, 14, 15, 16, 17, 19, 21, 23, 25, 27, 30 };
        public string[] savage_rush_reqlevel = { "21", "22", "23", "24", "26", "29", "33", "37", "43", "49", "58", "66", "75", "85", "95", "full" };

        public int chain_snare_lvl = 0;
        public string chain_snare_text;
        double[] chain_snare_a = { 0, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76 };
        double[] chain_snare_b = { 0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
        double[] chain_snare_c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 100 };
        double[] chain_snare_mana = { 0, 14, 14, 15, 15, 15, 16, 16, 17, 18, 20, 22, 24, 26, 28, 30 };
        public string[] chain_snare_reqlevel = { "28", "29", "30", "31", "33", "35", "38", "42", "46", "53", "62", "69", "77", "87", "96", "full" };

        public int battle_standard_lvl = 0;
        public string battle_standard_text;
        double[] battle_standard_a = { 0, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 50 };
        double[] battle_standard_b = { 0, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 };
        double[] battle_standard_c = { 0, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98 };
        double[] battle_standard_d = { 0, 0, 0, 0, 0, 24, 26, 28, 30, 32, 35, 37, 40, 42, 45, 48 };
        double[] battle_standard_mana = { 0, 23, 23, 24, 24, 25, 25, 26, 27, 29, 31, 34, 36, 39, 41, 44 };
        public string[] battle_standard_reqlevel = { "35", "36", "37", "38", "40", "42", "45", "48", "52", "59", "66", "74", "81", "89", "97", "full" };

        public int wolfpack_lvl = 0;
        public string wolfpack_text;
        double[] wolfpack_a = { 0, 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };
        double[] wolfpack_b = { 0, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60 };
        double[] wolfpack_c = { 0, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
        double[] wolfpack_mana = { 0, 44, 45, 45, 46, 48, 50, 51, 54, 56, 60, 62, 66, 69, 74, 52 };
        public string[] wolfpack_reqlevel = { "42", "43", "44", "46", "48", "51", "54", "58", "62", "67", "72", "78", "84", "91", "98", "full" };

        public int frenzy_mastery_lvl = 0;
        public string frenzy_mastery_text;
        double[] frenzy_mastery_a = { 0, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12, 12.5, 13, 13.5 };
        public string[] frenzy_mastery_reqlevel = { "1", "2", "3", "6", "10", "14", "19", "25", "32", "40", "49", "58", "68", "79", "92", "full" };

        public int shred_armor_lvl = 0;
        public string shred_armor_text;
        double[] shred_armor_a = { 0, 10, 13.333, 16.667, 20, 23.333, 26.667, 30, 33.333, 36.667, 40, 43.333, 46.667, 50, 53.333, 56.667 };
        double[] shred_armor_b = { 0, 10, 13.333, 16.667, 20, 23.333, 26.667, 30, 33.333, 36.667, 40, 43.333, 46.667, 50, 53.333, 56.667 };
        public string[] shred_armor_reqlevel = { "7", "8", "9", "11", "13", "17", "22", "28", "35", "43", "52", "60", "70", "81", "93", "full" };

        public int red_wolf_lvl = 0;
        public string red_wolf_text;
        double[] red_wolf_a = { 0, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95 };
        double[] red_wolf_b = { 0, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100, 105, 110, 115, 120 };
        public string[] red_wolf_reqlevel = { "14", "15", "16", "18", "20", "23", "27", "32", "38", "46", "55", "63", "72", "83", "94", "full" };


        double weapon_damage, critical_damage, double_chance, critical_chance, fumble_recovery,
                max_mana, magic_damage, execute_chance, max_health, armor_bonus, block_chance;

        public Berserker()
	    {
	    }

        public void calc()
        {
            skillpointsleft = (level + fame) - eviscerate_lvl - howl_lvl - raze_lvl - wolfstrike_lvl - battle_rage_lvl -
                rupture_lvl - ravage_lvl - blood_hunger_lvl - executioner_lvl - rampage_lvl -
                frost_breath_lvl - stormclaw_lvl - storm_hatchet_lvl - northern_rage_lvl - ice_shield_lvl -
                permafrost_lvl - glacial_shatter_lvl - cold_steel_mastery_lvl - shatter_storm_lvl - rage_retaliation_lvl -
                shadow_burst_lvl - wolf_shade_lvl - shadowbind_lvl - savage_rush_lvl - chain_snare_lvl -
                battle_standard_lvl - wolfpack_lvl - frenzy_mastery_lvl - shred_armor_lvl - red_wolf_lvl;
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

            int eviscerate_damage= (int)(Math.Ceiling(eviscerate_b[eviscerate_lvl]*damage_monster[level]/100)*eviscerate_c[eviscerate_lvl]);
            eviscerate_text = "Вы рвете на части всех досягаемых врагов впереди и вызываете у них 6-секундное кровотечение. Радиус" + Environment.NewLine +
                "сектора - 2,7 м, угол - 120 градусов. Применение навыка уменьшает скорость увеличения Заряда на 67%.            " + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + eviscerate_mana[eviscerate_lvl] + Environment.NewLine +
                "Наносит " + eviscerate_a[eviscerate_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                "Физич. урон: " + eviscerate_damage + " в теч. " + eviscerate_c[eviscerate_lvl] + " сек.*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус увеличен до 3 м, угол - до 180 градусов. Кровотечение интенсивнее, но длится на 4 сек. меньше." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус увеличен до 3,3 м, угол - до 240 градусов. Кровотечение интенсивнее, но длится на 2 сек. меньше" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус увеличен до 4 м" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока" + Environment.NewLine + Environment.NewLine +
                "Необходимо оружие ближнего боя в правой руке";

            howl_text = "Вы яростно воете, вселяя ужас в души врагов. Противники" + Environment.NewLine +
                "на несколько секунд замедляются и становятся уязвимее.       " + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + howl_mana[howl_lvl] + Environment.NewLine +
                "Дальность: " + howl_d[howl_lvl] + " м" + Environment.NewLine +
                "-" + howl_a[howl_lvl] + "% от скорости движения в теч. " + howl_c[howl_lvl] + " сек." + Environment.NewLine +
                "-" + howl_a[howl_lvl] + "% от скорости атаки в теч. " + howl_c[howl_lvl] + " сек." + Environment.NewLine +
                "-" + howl_b[howl_lvl] + "% от скорости применения заклинаний в теч. " + howl_c[howl_lvl] + " сек." + Environment.NewLine +
                "+" + howl_a[howl_lvl] + "% к получаемому люб. урону в теч. " + howl_c[howl_lvl] + " сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Дальность увеличена до 7,5 м" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Дальность увеличена до 10 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Дальность увеличена до 10,5 м" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            raze_text = "Наносит огромный урон выбранной цели. С каждым" + Environment.NewLine +
                "последующим ударом ваша сила возрастает. Уровень      " + Environment.NewLine +
                "Заряда при этом не повышается." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + raze_mana[raze_lvl] + Environment.NewLine +
                "Наносит " + raze_a[raze_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                "+100% шанс прервать действия врага" + Environment.NewLine +
                "+" + raze_e[raze_lvl] + "% к люб. урону в теч. 2 сек." + Environment.NewLine;
		    if (raze_lvl >= 5)
			{
                raze_text += "-" + raze_b[raze_lvl] + "% от скорости движения в теч. 4 сек." + Environment.NewLine +
                    "-" + raze_b[raze_lvl] + "% от скорости атаки в теч. 4 сек." + Environment.NewLine +
                    "-" + raze_b[raze_lvl] + "% от скорости применения заклинаний в теч. 4 сек." + Environment.NewLine;
			}
		    if (raze_lvl >= 10)
			{
                raze_text += "+" + raze_c[raze_lvl] + "% к шансу промаха в теч. 4 сек." + Environment.NewLine;
			}
			if (raze_lvl == 15)
			{
                raze_text += raze_d[raze_lvl] + "% шанс оглушить цель на 4 сек." + Environment.NewLine;
			}
            raze_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Цель замедлена" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Точность атак цели снижена" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Цель оглушена";

            wolfstrike_text = "Вы бросаетесь вперед на 6 метров, раздирая когтями всех врагов," + Environment.NewLine +
                "которые стоят на пути.                                                                                       " + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + wolfstrike_mana[wolfstrike_lvl] + Environment.NewLine +
                "Наносит " + wolfstrike_a[wolfstrike_lvl] + "% от урона текущего оружия в сек. физич. уроном" + Environment.NewLine +
                "+" + wolfstrike_b[wolfstrike_lvl] + " к отбрасыванию" + Environment.NewLine +
                "+" + wolfstrike_c[wolfstrike_lvl] + "% шанс оглушить цель на 3 сек." + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Дистанция броска увеличена до 7 метров" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Дистанция броска увеличена до 8 метров" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Дистанция броска увеличена до 9 метров";

            battle_rage_text = "Вы приходите в ярость, и наносимый вами урон зависит" + Environment.NewLine +
                "от числа врагов в радиусе 4 метров. Время действия - 60 сек." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + battle_rage_mana[battle_rage_lvl] + Environment.NewLine +
                "Время между активациями: 50 сек." + Environment.NewLine +
                "+" + battle_rage_a[battle_rage_lvl] + "% люб. урона за каждого монстра в радиусе" + battle_rage_c[battle_rage_lvl] + " м" + Environment.NewLine;
		    if (battle_rage_lvl >= 5)			 
            {
                battle_rage_text += "-" + battle_rage_b[battle_rage_lvl] + "% получаемого физич. урона за каждого монстра в радиусе" + battle_rage_c[battle_rage_lvl] + " м" + Environment.NewLine;
            }
            battle_rage_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Наносимый вам урон снижается" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус действия увеличен до 5 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус действия увеличен до 6 м";

            int rupture_damage = (int)Math.Ceiling(rupture_b[rupture_lvl] * damage_monster[level] / 100);
            rupture_text = "Мощным ударом вы отбрасываете врага назад," + Environment.NewLine +
                "и после небольшой паузы он взрывается, нанося" + Environment.NewLine +
                "повреждения всем находящимся в радиусе 4 м" + Environment.NewLine +
                "противникам." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + rupture_mana[rupture_lvl] + Environment.NewLine +
                rupture_a[rupture_lvl] + "% шанс оглушить цель на 3 сек." + Environment.NewLine +
                "+35 к отбрасыванию" + Environment.NewLine +
                "Дополнительный эффект: " + Environment.NewLine +
                rupture_damage + " Физический урон*" + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус взрыва увеличен до 5 м" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус взрыва увеличен до 6 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус взрыва увеличен до 7 м" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока";

            int ravage_armor = (int)Math.Floor(ravage_c[ravage_lvl] * armor_monster_bylevel[level] / 100);
            ravage_text = "Вы наносите 3 страшных удара каждому врагу в радиусе 4 м. После каждого" + Environment.NewLine +
                "удара уровень брони врагов снижается.                                                                         " + Environment.NewLine +
                "Расход маны: " + ravage_mana[ravage_lvl] + Environment.NewLine +
                "Наносит " + ravage_a[ravage_lvl] + "% от урона текущего оружия в сек." + Environment.NewLine +
                "-" + ravage_armor + " от всех видов брони в теч. " + ravage_d[ravage_lvl] + " сек.*" + Environment.NewLine +
                "+ 8% шанс прервать действия врага" + Environment.NewLine;
		    if (ravage_lvl >= 5)
		 	{
                ravage_text += "Сопротивление отбрасыванию: " + ravage_b[ravage_lvl] + "% в теч. 1 сек." + Environment.NewLine +
                    ravage_b[ravage_lvl] + " сопротивление замедлению на 1 сек." + Environment.NewLine;
   			}
            ravage_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "При использовании заклинания на вас не действуют эффекты замедления" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Время ослабления брони увеличено до 6 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус действия увеличен до 5 м" + Environment.NewLine + Environment.NewLine +
                "*улучшается вместе с уровнем игрока" + Environment.NewLine + Environment.NewLine +
                "Необходимо оружие ближнего боя в правой руке";

            blood_hunger_text = "Нанося противнику критические повреждения оружием ближнего боя, вы" + Environment.NewLine +
                "исцеляете себя с помощью жизненной энергии врага.                            " + Environment.NewLine + Environment.NewLine +
                "Каждый критический удар повышает ваш уровень здоровья на " + blood_hunger_a[blood_hunger_lvl] + "% от макс." + Environment.NewLine + " ";

            executioner_text = "Ярость помогает наносить урон оружием в обеих руках" + Environment.NewLine +
                "одновременно. В случае успешной атаки с двух рук скорость   " + Environment.NewLine +
                "повышения уровня Заряда ненадолго увеличивается." + Environment.NewLine + Environment.NewLine +
                "+ " + executioner_a[executioner_lvl] + "% к шансу казнить цель" + Environment.NewLine +
                "+ " + executioner_b[executioner_lvl] + "% к скорости увеличения Заряда в теч. 2 сек.";
              
            rampage_text="При уничтожении врага оружием ближнего боя у вас"+Environment.NewLine+
                "может начаться адреналиновое буйство." + Environment.NewLine +Environment.NewLine+
                "25% к скорости атаки на 5 сек." + Environment.NewLine +
                "25% к скорости применения заклинаний на 5 сек." + Environment.NewLine +
                "12% к скорости передвижения на 5 сек." + Environment.NewLine +
                "Шанс на буйство после уничтожения врага:"+rampage_a[rampage_lvl] + "%";

            frost_breath_text = "Призвав на помощь холодные северные ветра, вы замораживаете" + Environment.NewLine +
                "врага ледяным дыханием - противник обездвиживается и становится" + Environment.NewLine +
                "уязвимым. Зона действия - сектор с углом 90 градусов и радиусом 5 м." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + frost_breath_mana[frost_breath_lvl] + Environment.NewLine +
                "Наносит " + frost_breath_a[frost_breath_lvl] + "% от урона текущего оружия в сек. льдом" + Environment.NewLine +
                frost_breath_b[frost_breath_lvl] + "% шанс заморозить цель на 4 сек." + Environment.NewLine +
                "80% шанс обездвижить цель на 4 сек." + Environment.NewLine +
                "+ " + frost_breath_b[frost_breath_lvl] + "% к получаемому люб. урону в теч. 4 сек. " + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус сектора увеличен до 6 м, а угол - до 120 градусов." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус сектора увеличен до 7 м, а угол - до 150 градусов" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус сектора увеличен до 8 м, а угол - до 150 градусов. Позволяет" + Environment.NewLine +
                "похищать здоровье и ману.";

            stormclaw_text = "Вы насыщаете оружие электрической энергией. Когда оно" + Environment.NewLine +
                "наносит удар, из него вырывается молния, которая поражает       " + Environment.NewLine +
                "до 2 находящихся рядом врагов." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + stormclaw_mana[stormclaw_lvl] + Environment.NewLine +
                "Время между активациями: 20 сек." + Environment.NewLine +
                "Наносит " + stormclaw_a[stormclaw_lvl] + "% урона от оружия электричеством" + Environment.NewLine +
                "50% шанс эффекта \"Молния\" вокруг цели " + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Молния поражает до 3 врагов" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Молния поражает до 4 врагов" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Молния поражает до 5 врагов" + Environment.NewLine + Environment.NewLine +
                "Срабатывает при базовых атаках оружием ближнего боя";

            storm_hatchet_text = "Вы высекаете из оружия дикую северную молнию, создавая электрический" + Environment.NewLine +
                "метательный топор с радиусом действия 15 м.                                                           " + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + storm_hatchet_mana[storm_hatchet_lvl] + Environment.NewLine +
                "Каждое попадание увеличивает уровень индикатора Зарядов на " + storm_hatchet_d[storm_hatchet_lvl] + "%" + Environment.NewLine +
                "Наносит " + storm_hatchet_a[storm_hatchet_lvl] + "% от урона текущего оружия в сек. электричеством" + Environment.NewLine +
                "-100% от скорости движения в теч. " + storm_hatchet_b[storm_hatchet_lvl] + " сек. " + Environment.NewLine;
		    if (storm_hatchet_lvl == 15)
		 	{
                storm_hatchet_text += storm_hatchet_c[storm_hatchet_lvl] + "% шанс разбить щит врага" + Environment.NewLine;
			}
            storm_hatchet_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Дистанция полета увеличена до 20 метров; топорик летит быстрее" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Вы бросаете 3 топорика одновременно" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Топорики разбивают щиты";
                 
            int northern_rage_mindam = (int)Math.Ceiling(northern_rage_a[northern_rage_lvl] * damage_monster[level] / 100);
            int northern_rage_maxdam = (int)Math.Ceiling(northern_rage_b[northern_rage_lvl] * damage_monster[level] / 100);
            northern_rage_text = "Вы кидаете ледяные осколки, которые отбрасывают врагов" + Environment.NewLine +
                "назад и замораживают.                                                                        " + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + northern_rage_mana[northern_rage_lvl] + Environment.NewLine +
                "Наносит 20% от урона текущего оружия в сек." + Environment.NewLine +
                "+" + northern_rage_mindam + "-" + northern_rage_maxdam + " к лед. урону*" + Environment.NewLine +
                "80% шанс заморозить цель на " + northern_rage_c[northern_rage_lvl] + " сек." + Environment.NewLine +
                northern_rage_d[northern_rage_lvl] + "% шанс разбить щит врага " + Environment.NewLine +
                "+25 к отбрасыванию" + Environment.NewLine;
            if (northern_rage_lvl > 5)
            {
                northern_rage_text += "От заклинателя расходятся 4 ледяные волны, пронзающие врагов. " + Environment.NewLine;
            }
            northern_rage_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Число волн увеличено до 4; распространяются дальше." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Число волн увеличено до 5; распространяются дальше." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Число волн увеличено до 6; распространяются дальше." + Environment.NewLine + Environment.NewLine +
                "* улучшается вместе с уровнем игрока";

            ice_shield_text = "Вы призываете ледяную стену, которая отражает снаряды обратно во врагов." + Environment.NewLine +
                "Если в стену попадает снаряд, появляется шанс увеличить уровень индикатора      " + Environment.NewLine +
                "Зарядов на 10%. Время действия стены - 10 сек." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + ice_shield_mana[ice_shield_lvl] + Environment.NewLine +
                "Время между активациями: 8 сек." + Environment.NewLine +
                ice_shield_a[ice_shield_lvl] + "%-шанс, что при попадании в стену Заряд увеличится." + Environment.NewLine +
                ice_shield_b[ice_shield_lvl] + "% шанс отразить снаряд с силой " + ice_shield_c[ice_shield_lvl] + "% от урона оружия в сек. 10 сек. " + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Стена отражает 75% урона, который наносят снаряды." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Стена отражает 100% урона, который наносят снаряды." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Стена отражает 125% урона, который наносят снаряды.";
            
            int permafrost_damage = (int)Math.Floor((int)Math.Ceiling(permafrost_a[permafrost_lvl] * damage_monster[level] / 100) * permafrost_b[permafrost_lvl]);
            permafrost_text = "Вокруг вас распространяется суровый северный мороз," + Environment.NewLine +
                "который медленно высасывает жизненную энергию из      " + Environment.NewLine +
                "врагов, находящихся в радиусе 16 метров." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + permafrost_mana[permafrost_lvl] + Environment.NewLine +
                "Время между активациями: " + permafrost_b[permafrost_lvl] + " сек. " + Environment.NewLine +
                "Лед. урон: " + permafrost_damage + " в теч. " + permafrost_b[permafrost_lvl] + " сек.* " + Environment.NewLine;
		    if (permafrost_lvl >= 5) 
            {
                permafrost_text += permafrost_d[permafrost_lvl] + "% шанс заморозить цель на 6 сек. " + Environment.NewLine;
            }
		    if (permafrost_lvl >= 10) 
            {
                permafrost_text = permafrost_c[permafrost_lvl] + "% шанс обездвижить цель на 6 сек. " + Environment.NewLine;
            }
            permafrost_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Доп. 25% шанс заморозить врагов на 6 сек." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Доп. 25% шанс полностью заморозить врагов на 6 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Шанс обездвижить врага увеличен до 50%" + Environment.NewLine + Environment.NewLine +
                "* улучшается вместе с уровнем игрока";

            int glacial_shatter_mindam_fire = (int)Math.Ceiling(glacial_shatter_b[glacial_shatter_lvl] * damage_monster[level] / 100) * 3;
		    int glacial_shatter_maxdam_fire = (int)Math.Ceiling(glacial_shatter_c[glacial_shatter_lvl] * damage_monster[level] / 100) * 3;
		    int glacial_shatter_mindam_ice = (int)Math.Ceiling(glacial_shatter_d[glacial_shatter_lvl] * damage_monster[level] / 100);
		    int glacial_shatter_maxdam_ice = (int)Math.Ceiling(glacial_shatter_e[glacial_shatter_lvl] * damage_monster[level] / 100);
            glacial_shatter_text = "В выбранной точке земля раскалывается, и появляется" + Environment.NewLine +
                "5 гейзеров, которые ослепляют и наносят урон врагам        " + Environment.NewLine +
                "паром и горячей водой." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + glacial_shatter_mana[glacial_shatter_lvl] + Environment.NewLine +
                "33% шанс ослепить цель на " + glacial_shatter_a[glacial_shatter_lvl] + "% в теч. 5 сек. " + Environment.NewLine +
                "+" + glacial_shatter_mindam_ice + "-" + glacial_shatter_maxdam_ice + " к лед. урону* " + Environment.NewLine +
                "+7 к отбрасыванию " + Environment.NewLine +
                "+35% к шансу прервать действие врага " + Environment.NewLine;
		    if (glacial_shatter_lvl >= 10) 
            {
                glacial_shatter_text += "Огн. урон: " + glacial_shatter_mindam_fire + "-" + glacial_shatter_maxdam_fire + " в теч. 3 сек.* " + Environment.NewLine;
            }
            glacial_shatter_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Создается 7 гейзеров" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Заклинание также поджигает врагов" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Создается 9 гейзеров" + Environment.NewLine + Environment.NewLine +
                "* улучшается вместе с уровнем игрока";

            cold_steel_mastery_text = "Прочнее стали только холодная сталь." + Environment.NewLine + Environment.NewLine +
                "+" + cold_steel_mastery_a[cold_steel_mastery_lvl] + "% к Физ. урону                                          " + Environment.NewLine +
                "+" + cold_steel_mastery_b[cold_steel_mastery_lvl] + "% к Лед. урону";

            shatter_storm_text = "Уничтожив замороженного врага, вы накрываете" + Environment.NewLine +
                "находящихся в радиусе 4 м противников взрывной    " + Environment.NewLine +
                "ледяной волной, делая их уязвимыми для" + Environment.NewLine +
                "дальнейших ледяных атак." + Environment.NewLine + Environment.NewLine +
                "100% шанс обездвижить цель на " + shatter_storm_a[shatter_storm_lvl] + " сек. " + Environment.NewLine +
                shatter_storm_b[shatter_storm_lvl] + "% шанс заморозить цель на 10 сек. " + Environment.NewLine +
                "-" + shatter_storm_b[shatter_storm_lvl] + "% к Лед. броне в теч. " + shatter_storm_a[shatter_storm_lvl] + " сек.";

            rage_retaliation_text = "Когда враг наносит вам урон в ближнем бою, ваша" + Environment.NewLine +
                "ярость принимает материальное воплощение и наносит      " + Environment.NewLine +
                "ответный удар. Урон равен 120% от урона вашего" + Environment.NewLine +
                "оружия в секунду. В секунду поражается не более одной" + Environment.NewLine +
                "цели." + Environment.NewLine + Environment.NewLine;
		    if (rage_retaliation_lvl <= 10)
			{
                rage_retaliation_text += "Минимальное время между атаками: " + rage_retaliation_a[rage_retaliation_lvl] + " сек." + Environment.NewLine;
            }
		    if (rage_retaliation_lvl == 11)
			{
                rage_retaliation_text += "Задержки между атаками нет." + Environment.NewLine;
            }
            if (rage_retaliation_lvl >= 12)
            {
                rage_retaliation_text += "Урон: " + rage_retaliation_b[rage_retaliation_lvl] + "% от урона вашего оружия в сек. Задержки между атаками нет." + Environment.NewLine;
            }

            shadow_burst_text = "Вы превращаетесь в волка-призрака и пролетаете сквозь врагов," + Environment.NewLine +
                "нанося им урон и одновременно исцеляя себя. Исцеление происходит        " + Environment.NewLine +
                "только при столкновении с двумя первыми целями." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + shadow_burst_mana[shadow_burst_lvl] + Environment.NewLine +
                "Восстанавливает " + shadow_burst_c[shadow_burst_lvl] + "% здоровья за " + shadow_burst_d[shadow_burst_lvl] + " пораженные цели" + Environment.NewLine +
                "Наносит " + shadow_burst_a[shadow_burst_lvl] + "% от урона текущего оружия в сек. электричеством " + Environment.NewLine + Environment.NewLine +
                shadow_burst_b[shadow_burst_lvl] + "% шанс разбить щит врага " + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Исцеление происходит при столкновении с 3 целями. Шанс уничтожить" + Environment.NewLine +
                "щит увеличен до 50%." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Исцеление происходит при столкновении с 4 целями. Шанс уничтожить" + Environment.NewLine +
                "щит увеличен до 75%." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Исцеление происходит при столкновении с 5 целями. Шанс уничтожить" + Environment.NewLine +
                "щит увеличен до 100%.";        
            
            int wolf_shade_mindam = (int)Math.Ceiling(wolf_shade_d[wolf_shade_lvl] * damage_minion_bylevel[level] / 100);
            int wolf_shade_maxdam = (int)Math.Ceiling(wolf_shade_e[wolf_shade_lvl] * damage_minion_bylevel[level] / 100);
            wolf_shade_text = "Призванный волк-призрак впивается ледяными клыками" + Environment.NewLine +
                "во врагов и передает их жизненную энергию вам. Его можно     " + Environment.NewLine +
                "призвать раз в минуту." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + wolf_shade_mana[wolf_shade_lvl] + Environment.NewLine +
                "Время между активациями: 60 сек." + Environment.NewLine +
                "+" + wolf_shade_a[wolf_shade_lvl] + "% к люб. урону  " + Environment.NewLine +
                "+" + wolf_shade_b[wolf_shade_lvl] + "% здоровья хозяину при каждом ударе " + Environment.NewLine +
                "Время вызова: " + wolf_shade_c[wolf_shade_lvl] + " сек. " + Environment.NewLine +
                "Помощники наносят " + wolf_shade_mindam + "-" + wolf_shade_maxdam + " Физич. урона* " + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Продолжительность вызова увеличена до 30 сек." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Продолжительность вызова увеличена до 45 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Продолжительность вызова увеличена до 60 сек." + Environment.NewLine + Environment.NewLine +
                "* улучшается вместе с уровнем игрока";

            shadowbind_text = "Вы связываете узами тьмы врагов, которые" + Environment.NewLine +
                "находятся в радиусе 5 м от вас. При последующих     " + Environment.NewLine +
                "атаках в ближнем бою все эти враги получают" + Environment.NewLine +
                "часть урона, который вы наносите одной цели." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + shadowbind_mana[shadowbind_lvl] + Environment.NewLine +
                "Время между активациями: 5 сек." + Environment.NewLine +
                "Цели получают " + shadowbind_a[shadowbind_lvl] + "% урона в течение " + shadowbind_b[shadowbind_lvl] + " сек." + Environment.NewLine +
                "Помощники наносят " + wolf_shade_mindam + "-" + wolf_shade_maxdam + " Физич. урона* " + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Радиус зоны действия увеличен до 7 м" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус зоны действия увеличен до 9 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Радиус зоны действия увеличен до 11 м" + Environment.NewLine + Environment.NewLine +
                "Необходимо оружие ближнего боя";
            
            int savage_rush_damage = (int)Math.Ceiling(savage_rush_d[savage_rush_lvl] * damage_monster[level] / 100) * 5;
            savage_rush_text = "Вами овладевает дух волка-призрака! Пока" + Environment.NewLine +
                "действует навык, вы скачете от врага к врагу и     " + Environment.NewLine +
                "наносите им ужасные раны." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + savage_rush_mana[savage_rush_lvl] + " в сек." + Environment.NewLine +
                "Наносит " + savage_rush_a[savage_rush_lvl] + "% урона от оружия " + Environment.NewLine +
                "+20% к скорости движения " + Environment.NewLine +
                "-" + savage_rush_b[savage_rush_lvl] + "% от люб. брони в теч. " + savage_rush_c[savage_rush_lvl] + " сек. " + Environment.NewLine +
                savage_rush_damage + " Физич. урона в теч. 5 сек.* " + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "-20% к броне врагов на 6 сек." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "-30% к броне врагов на 8 сек." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "-40% к броне врагов на 10 сек." + Environment.NewLine + Environment.NewLine +
                "* улучшается вместе с уровнем игрока";

            chain_snare_text = "Ловит всех врагов в радиусе 6 м и быстро подтягивает их к вам." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + chain_snare_mana[chain_snare_lvl] + Environment.NewLine +
                "Наносит " + chain_snare_a[chain_snare_lvl] + "% от урона текущего оружия в сек. " + Environment.NewLine +
                "Притягивает цель " + Environment.NewLine +
                "75% шанс оглушить цель на " + chain_snare_b[chain_snare_lvl] + " сек. " + Environment.NewLine;
		    if (chain_snare_lvl >= 15) 
            {
                chain_snare_text += chain_snare_c[chain_snare_lvl] + "% шанс разбить щит врага " + Environment.NewLine;
            }
            chain_snare_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Время оглушения увеличено до 2 сек." + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус действия увеличен до 9 м." + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Разбивает щиты.";

            battle_standard_text = "Древнее знамя вашего племени повышает боевой дух и ваших"+Environment.NewLine+
                "союзников. Уклонение, сопротивление отбрасыванию и скорость    "+Environment.NewLine+
                "роста заряда увеличиваются. Радиус действия 9 м." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + battle_standard_mana[battle_standard_lvl] + Environment.NewLine +
                "Время между активациями: 15 сек." + Environment.NewLine +
                "Время вызова: " + battle_standard_a[battle_standard_lvl] + " сек. " + Environment.NewLine +
                "+" + battle_standard_b[battle_standard_lvl] + "% к шансу уклонения в теч. 4 сек. " + Environment.NewLine +
                "Сопротивление отбрасыванию: " + battle_standard_c[battle_standard_lvl] + "% в теч. 4 сек. " + Environment.NewLine +
                "+" + battle_standard_b[battle_standard_lvl] + "% к скорости увеличения Заряда в теч. 4 сек. " + Environment.NewLine;
		    if (battle_standard_lvl >= 5) 
            {
                battle_standard_text += "Восполняется " + battle_standard_d[battle_standard_lvl] + " ед. маны в теч. 4 сек. " + Environment.NewLine;
            }
            battle_standard_text += Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Скорость повышения уровня маны увеличивается" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Радиус действия увеличен до 15 м" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Время действия удваивается";

            int wolfpack_mindam = (int)Math.Ceiling(wolfpack_b[wolfpack_lvl] * damage_monster[level] / 100);
		    int wolfpack_maxdam = (int)Math.Ceiling(wolfpack_c[wolfpack_lvl] * damage_monster[level] / 100);
            wolfpack_text = "Окружающих вас врагов атакует стая из 5 волков-призраков." + Environment.NewLine + Environment.NewLine +
                "Расход маны: " + wolfpack_mana[wolfpack_lvl] + Environment.NewLine;
			if (wolfpack_lvl >= 2) 
            {
                wolfpack_text += "Наносит " + wolfpack_a[wolfpack_lvl] + "% от урона текущего оружия в сек. " + Environment.NewLine;
            }
            wolfpack_text += "+" + wolfpack_mindam + "-" + wolfpack_maxdam + " к Физич. урону* " + Environment.NewLine + Environment.NewLine +
                "Преимущество I уровня" + Environment.NewLine + "Волки могут наносить урон нескольким целям" + Environment.NewLine +
                "Преимущество II уровня" + Environment.NewLine + "Появляется еще 2 волка" + Environment.NewLine +
                "Преимущество III уровня" + Environment.NewLine + "Расход маны снижен" + Environment.NewLine + Environment.NewLine +
                "* улучшается вместе с уровнем игрока";             /* 
            frenzy_mastery_tex
             * int red_wolf_mindam = (int)Math.Ceiling(red_wolf_a[raze_lvl0] * damage_monster[level] / 100);
		int red_wolf_maxdam = (int)Math.Ceiling(red_wolf_b[raze_lvl0] * damage_monster[level] / 100);
            textraze_lvl0.innerHTML = "<img src='/pic/skills/skillicon_redt
             * texthowl_lvl8.innerHTML = "<img src='/pic/skills/skillicon_attackmagic.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'> Мастер бешенства (Пассивный навык)" + Environment.NewLine +<a style='color:#ffffff; font-size: 13px;'> Ур. "+howl_lvl8+"/15  ";
			texthowl_lvl8.innerHTML +=" Вам все сложнее сдерживать свою звериную натуру. Продолжительность приступов бешенства (связанных с заполнением индикатора Заряда) увеличивается." + Environment.NewLine +
		 	texthowl_lvl8.innerHTML +="<a style='color:#C3C300'>Текущий ур.: "+howl_lvl8+ Environment.NewLine +
		  	texthowl_lvl8.innerHTML +="<a style='color:#1F90FF'>Приступ бешенства длится до " + frenzy_mastery_a[howl_lvl8] + " сек. " + Environment.NewLine +
             * 
            shred_armor_text
             * int shred_armor_armor_per_hit = (int)Math.Ceiling(shred_armor_a[howl_lvl9] * armor_monster_bylevel[level] / 100);
		 int shred_armor_armor = (int)Math.Ceiling(shred_armor_b[howl_lvl9] * armor_player_bylevel_forset[level] / 100);
		    texthowl_lvl9.innerHTML = "<img src='/pic/skills/skillicon_fateaegis.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'> Броня в клочья (Пассивный навык)" + Environment.NewLine +<a style='color:#ffffff; font-size: 13px;'> Ур. "+howl_lvl9+"/15  ";
			texthowl_lvl9.innerHTML +=" Вы яростно крушите вражескую броню, а отлетающие кусочки при этом прикрепляете к своей. С каждым ударом противник становится слабее, а ваш показатель брони растет." + Environment.NewLine +
		 	texthowl_lvl9.innerHTML +="<a style='color:#C3C300'>Текущий ур.: "+howl_lvl9+ Environment.NewLine +
		  	texthowl_lvl9.innerHTML +="<a style='color:#1F90FF'>-" + shred_armor_armor_per_hit + " от всех видов брони за каждый удар* " + Environment.NewLine +
			texthowl_lvl9.innerHTML +="<a style='color:#1F90FF'>+" + shred_armor_armor + " к Физич. броне в теч. 3 сек.* " + Environment.NewLine +
             * 
            red_wolf_textwolf.png' class='class2CSS' width='40' height='40'><a style='color:#ffffff; font-size: 15px; font-weight:bold;'> Рыжий волк (Пассивный навык)" + Environment.NewLine +<a style='color:#ffffff; font-size: 13px;'> Ур. "+raze_lvl0+"/15  ";
			textraze_lvl0.innerHTML +=" Когда вы наносите противнику критические повреждения, на поле боя может появиться воплощение вашей ярости и порвать в клочья одного или двух врагов." + Environment.NewLine +
		 	textraze_lvl0.innerHTML +="<a style='color:#C3C300'>Текущий ур.: "+raze_lvl0+ Environment.NewLine +
		  	textraze_lvl0.innerHTML +="<a style='color:#1F90FF'>+" + red_wolf_mindam + "-" + red_wolf_maxdam + " к Физич. урону* " + Environment.NewLine +
            */
        }
    }
}

