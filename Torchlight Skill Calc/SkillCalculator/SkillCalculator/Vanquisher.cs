using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCalculator
{
    class Vanquisher
    {
        public int skillpointsleft, level, fame, statpointsleft;
        public double strength = 15, dexterity = 5, focus = 5, vitality = 15;
        public string strength_text, dexterity_text, focus_text, vitality_text;

        public string[] fame_ranks = { "1600", "2160", "3200", "4340", "5510", "6770", "8060", "9430", "10840", "12310", "13780", "15320", "16890", "18440", "20100", "21720", "23400", "25080", "26750", "28530", "30240", "31990", "33800", "35560", "37370", "39230", "41040", "42890", "44780", "46610", "48480", "50380", "52320", "54180", "56070", "58000", "59940", "61930", "63820", "65740", "67680", "69650", "71630", "73650", "75560", "77480", "79570", "81530", "83520", "85520", "87560", "89450", "91510", "93440", "full" };

        double weapon_damage, critical_damage, double_chance, critical_chance, fumble_recovery, max_mana, magic_damage, execute_chance, max_health, armor_bonus, block_chance;
        
        public int ranged_weapon_lvl = 0;
        public string ranged_weapon_text;
        public string[] ranged_weapon_reqlvl = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "full" };
        int[] ranged_weapon_a = { 0, -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
        int[] ranged_weapon_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int ricochet_lvl = 0;
        public string ricochet_text;
        public string[] ricochet_reqlvl = { "1", "2", "3", "4", "7", "10", "13", "17", "21", "26" };
        int[] ricochet_mana = { 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        int[] ricochet_a = { 0, 88, 100, 112, 124, 136, 148, 160, 172, 184, 196 };

        public int frost_pilum_lvl = 0;
        public string frost_pilum_text;
        public string[] frost_pilum_reqlvl = { "5", "6", "7", "9", "11", "13", "16", "19", "23", "28", "full" };
        int[] frost_pilum_mana = { 0, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        int[] frost_pilum_a = { 0, 68, 74, 80, 86, 92, 98, 104, 110, 116, 122 };
        int[] frost_pilum_b = { 0, 69, 72, 75, 78, 82, 85, 88, 91, 95, 98 };

        public int critical_strikes_lvl = 0;
        public string critical_strikes_text;
        public string[] critical_strikes_reqlvl = { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "full" };
        int[] critical_strikes_a = { 0, 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 };
        int[] critikal_strikes_b = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int adventurer_lvl = 0;
        public string adventurer_text;
        public string[] adventurer_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] adventurer_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int[] adventurer_b = { 0, 8, 16, 24, 32, 40, 48, 56, 64, 72, 80 };

        public int seeking_shot_lvl = 0;
        public string seeking_shot_text;
        public string[] seeking_shot_reqlvl = { "10", "11", "12", "13", "15", "17", "20", "23", "26", "30", "full" };
        int[] seeking_shot_mana = { 0, 10, 11, 12, 13, 15, 17, 19, 21, 23, 25 };
        int[] seeking_shot_a = { 0, 40, 44, 48, 52, 54, 56, 60, 64, 68, 72 };

        public int offensive_spell_lvl = 0;
        public string offensive_spell_text;
        public string[] offensive_spell_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] offensive_spell_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int explosive_shot_lvl = 0;
        public string explosive_shot_text;
        public string[] explosive_shot_reqlvl = { "15", "16", "17", "18", "19", "21", "23", "25", "28", "31", "full" };
        int[] explosive_shot_mana = { 0, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        double[] explosive_shot_a = { 4.5, 4.5, 4.75, 5, 5.25, 5.5, 5.75, 6, 6.25, 6.5, 6.75 };
        int[] explosive_shot_b = { 0, 92, 100, 108, 116, 124, 132, 140, 148, 156, 164 };

        public int block_and_parry_lvl = 0;
        public string block_and_parry_text;
        public string[] block_and_parry_reqlvl = { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "full" };
        int[] block_and_parry_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        public int arrow_hail_lvl = 0;
        public string arrow_hail_text;
        public string[] arrow_hail_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] arrow_hail = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        string[] arrow_hail_b = { "0", "+350-466", "+370-493", "+390-520", "+411-548", "+433-577", "+454-605", "+477-636", "+499-666", "+523-698", "+547-730" };

        public int needle_arc_lvl = 0;
        public string needle_arc_text;
        public string[] needle_arc_reqlvl = { "1", "2", "3", "5", "7", "10", "13", "17", "21", "26", "full" };
        int[] needle_arc_mana = { 0, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14 };
        int[] needle_arc_a = { 5, 5, 5, 5, 5, 7, 7, 7, 7, 7, 7, 7 };
        string[] needle_arc_b = { "0", "+12-20", "+17-28", "+21-36", "+31-52", "+36-61", "+52-87", "+69-117", "+95-162", "+126-214", "+169-287" };
        int[] needle_arc_c = { 0, 27, 28, 29, 31, 32, 35, 38, 42, 45, 51 };
        int[] needle_arc_d = { 0, 5, 7, 9, 13, 15, 21, 28, 38, 51, 68 };

        public int stab_lvl = 0;
        public string stab_text;
        public string[] stab_reqlvl = { "5", "6", "7", "9", "11", "13", "16", "19", "23", "28", "full" };
        int[] stab_mana = { 0, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        string[] stab_a = { "0", "+94-117", "+113-141", "+132-165", "+170-212", "+210-263", "+253-316", "+325-406", "+405-507", "+524-655", "+692-864" };

        public int armor_expertise_lvl = 0;
        public string armor_expertise_text;
        public string[] armor_expertise_reqlvl = { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "full" };
        int[] armor_expertise_a = { 0, -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
        int[] armor_expertise_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int wind_of_justice_lvl = 0;
        public string wind_of_justice_text;
        public string[] wind_of_justice_reqlvl = { "10", "11", "12", "13", "15", "17", "20", "23", "26", "30", "full" };
        int[] wind_of_justice_mana = { 0, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        string[] wind_of_justice_a = { "0", "+29-58", "+33-65", "+36-71", "+39-78", "+46-92", "+54-108", "+67-133", "+81-161", "+96-191", "+118-235" };
        int[] wind_of_justice_b = { 0, 50, 55, 59, 63, 68, 72, 77, 81, 86, 90 };
        int[] wind_of_justice_c = { 0, 55, 58, 62, 66, 70, 74, 78, 82, 86, 90 };

        public int defensive_spell_lvl = 0;
        public string defensive_spell_text;
        public string[] defensive_spell_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] defensive_spell_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int martial_weapons_lvl = 0;
        public string martial_weapons_text;
        public string[] martial_weapons_reqlvl = { "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "full" };
        int[] martial_weapons_a = { 0, -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
        int[] martial_weapons_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int barter_lvl = 0;
        public string barter_text;
        public string[] barter_reqlvl = { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "full" };
        int[] barter_a = { 0, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60 };

        public int venomous_dirks_lvl = 0;
        public string venomous_dirks_text;
        public string[] venomous_dirks_reqlvl = { "20", "21", "22", "23", "24", "25", "27", "29", "31", "33", "full" };
        int[] venomous_dirks_mana = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38 };
        int[] venomous_dirks_a = { 0, 20, 23, 26, 29, 32, 33, 36, 39, 42, 45 };
        string[] venomous_dirks_b = { "0", "+52-71", "+56-76", "+59-81", "+63-86", "+67-91", "+71-96", "+79-107", "+87-119", "+96-131", "+105-144" };

        public int treasure_hunter_lvl = 0;
        public string treasure_hunter_text;
        public string[] treasure_hunter_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] treasure_hunter_a = { 0, 3, 5, 8, 10, 13, 15, 18, 20, 23, 25 };

        public int hamstring_lvl = 0;
        public string hamstring_text;
        public string[] hamstring_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] hamstring_mana = { 0, 25, 25, 27, 29, 31, 33, 35, 37, 39, 41 };
        int[] hamstring_a = { 0, 63, 63, 66, 69, 72, 75, 78, 81, 84, 87 };
        int[] hamstring_b = { 0, -21, -21, -22, -23, -24, -25, -26, -26, -28, -29 };
        int[] hamstring_c = { 0, 26, 26, 27, 28, 30, 31, 32, 33, 35, 36 };
        int[] hamstring_d = { 0, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14 };
        int[] hamstring_e = { 0, 61, 64, 68, 71, 75, 79, 83, 86, 91, 95 };

        public int lightning_bomb_lvl = 0;
        public string lightning_bomb_text;
        public string[] lightning_bomb_reqlvl = { "1", "2", "3", "5", "7", "10", "13", "17", "21", "26", "full" };
        int[] lightning_bomb_mana = { 0, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        string[] lightning_bomb_a = { "0", "+12-20", "+19-33", "+26-46", "+41-72", "+58-101", "+83-144", "+110-193", "+153-247", "+202-353", "+271-474" };

        public int dual_wielding_lvl = 0;
        public string dual_wielding_text;
        public string[] dual_wielding_reqlvl = { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "full" };
        int[] dual_wielding_a = { 0, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60 };

        public int flame_trap_lvl = 0; 
        public string flame_trap_text;
        public string[] flame_trap_reqlvl = { "5", "6", "7", "9", "11", "13", "16", "19", "23", "28", "full" };
        int[] flame_trap_mana = { 0, 11, 13, 15, 17, 19, 21, 23, 25, 26, 27 };
        int[] flame_trap_a = { 0, 0, 6, 12, 18, 24, 30, 37, 42, 48, 54 };
        int[] flame_trap_b = { 0, 11, 12, 12, 13, 15, 16, 16, 17, 19, 20 };

        public int charm_spell_lvl = 0;
        public string charm_spell_text;
        public string[] charm_spell_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] charm_spell_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int flechette_trap_lvl = 0;
        public string flechette_trap_text;
        public string[] flechette_trap_reqlvl = { "15", "16", "17", "18", "19", "21", "23", "25", "28", "31", "full" };
        int[] flechette_trap_mana = { 0, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
        int[] flechette_trap_a = { 0, 0, 6, 12, 18, 24, 30, 37, 42, 48, 54 };
        int[] flechette_trap_b = { 0, 11, 12, 12, 13, 15, 16, 16, 17, 19, 20 };

        public int pet_mastery_lvl = 0;
        public string pet_mastery_text;
        public string[] pet_mastery_reqlvl = { "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "full" };
        int[] pet_mastery_a = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int magic_weapon_lvl = 0;
        public string magic_weapon_text;
        public string[] magic_weapon_reqlvl = { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "full" };
        int[] magic_weapon_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] magic_weapon_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int devouring_trap_lvl = 0;
        public string devouring_trap_text;
        public string[] devouring_trap_reqlvl = { "20", "21", "22", "23", "24", "25", "27", "29", "31", "33", "full" };
        int[] devouring_trap_mana = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38 };
        int[] devouring_trap_a = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        int[] devouring_trap_b = { 0, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        int[] devouring_trap_c = { 0, 16, 17, 18, 20, 22, 23, 24, 26, 28, 29 };

        public int shock_trap_lvl = 0;
        public string shock_trap_text;
        public string[] shock_trap_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] shock_trap_mana = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        int[] shock_trap_a = { 0, 0, 7, 14, 21, 28, 35, 42, 49, 56, 63 };
        int[] shock_trap_b = { 0, 12, 14, 16, 18, 22, 25, 28, 31, 35, 39 };

        public int advanced_spellcasting_lvl = 0;
        public string advanced_spellcasting_text;
        public string[] advanced_spellcasting_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] advanced_spellcasting_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] advanced_spellcasting_b = { 0, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12 };

        public int _lvl = 0;
        public string _text;
        public string[] _reqlvl;

        public int _lvl = 0;
        public string _text;
        public string[] _reqlvl;

        public int _lvl = 0;
        public string _text;
        public string[] _reqlvl;

        public int _lvl = 0;
        public string _text;
        public string[] _reqlvl;

        public int _lvl = 0;
        public string _text;
        public string[] _reqlvl;

        public int _lvl = 0;
        public string _text;
        public string[] _reqlvl;

        public int _lvl = 0;
        public string _text;
        public string[] _reqlvl;



        /*
         * 
         * adventurer
         * offensive_spell
         * block_and_parry
         * armor_expertise
         * defensive_spell
         * martial_weapons
         * barter
         * treasure_hunter
         * dual_wielding
         * pet_mastery
         * magic_weapon
         * advanced_spellcasting
         */

        public Vanquisher()
        { 

        }
    }
}
