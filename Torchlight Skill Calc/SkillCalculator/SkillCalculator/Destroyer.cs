using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCalculator
{
    class Destroyer
    {
        public int slash_attack_lvl = 0;
        public string slash_attack_text;
        public string[] slash_attack_reqlvl = { "1", "2", "3", "5", "7", "10", "13", "17", "21", "26", "full" };
        int[] slash_attack_mana = { 0, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int[] slash_attack_a = { 0, 86, 93, 100, 107, 114, 121, 128, 135, 142, 149 };
        int[] slash_attack_b = { 0, 50, 54, 58, 62, 66, 70, 74, 78, 82, 86 };

        public int dual_wielding_lvl = 0;
        public string dual_wielding_text;
        public string[] dual_wielding_reqlvl = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "full" };
        int[] dual_wielding_a = { 0, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60 };

        public int stampede_lvl = 0;
        public string stampede_text;
        public string[] stampede_reqlvl = { "5", "6", "7", "9", "11", "13", "16", "19", "23", "28", "full" };
        int[] stampede_mana = { 0, 14, 16, 17, 18, 20, 22, 24, 26, 28, 30 };
        string[] stampede_a = { "0", "+25-45", "+30-50", "+35-58", "+44-75", "+55-93", "+66-112", "+85-144", "+106-179", "+136-231", "+180-305" };
        int[] stampede_b = { 0, 84, 88, 92, 96, 100, 104, 108, 112, 116, 120 };

        public int adventurer_lvl = 0;
        public string adventurer_text;
        public string[] adventurer_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] adventurer_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int[] adventurer_b = { 0, 8, 16, 24, 32, 40, 48, 56, 64, 72, 80 };

        public int offensive_spell_lvl = 0;
        public string offensive_spell_text;
        public string[] offensive_spell_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] offensive_spell_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int chain_vortex_lvl = 0;
        public string chain_vortex_text;
        public string[] chain_vortex_reqlvl = { "15", "16", "17", "18", "19", "21", "23", "25", "28", "31", "full" };
        int[] chain_vortex_mana = { 0, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42 };
        int[] chain_vortex_a = { 0, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96 };
        int[] chain_vortex_b = { 0, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5 };
        int[] chain_vortex_c = { 0, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46 };

        public int spectral_echo_lvl = 0;
        public string spectral_echo_text;
        public string[] spectral_echo_reqlvl = { "20", "21", "22", "23", "24", "25", "27", "29", "31", "33", "full" };
        int[] spectral_echo_mana = { 0, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
        int[] spectral_echo_a = { 0, 30, 36, 42, 48, 54, 60, 66, 72, 78, 84 };

        public int critical_strikes_lvl = 0;
        public string critical_strikes_text;
        public string[] critical_strikes_reqlvl = { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "full" };
        int[] critical_strikes_a = { 0, 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 };
        int[] critikal_strikes_b = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int treasure_hunter_lvl = 0;
        public string treasure_hunter_text;
        public string[] treasure_hunter_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] treasure_hunter_a = { 0, 3, 5, 8, 10, 13, 15, 18, 20, 23, 25 };

        public int devastate_lvl = 0;
        public string devastate_text;
        public string[] devastate_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] devastate_mana = { 0, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34 };
        int[] devastate_a = { 0, 100, 104, 108, 112, 116, 120, 124, 128, 132, 136 };
        int[] devastate_b = { 0, 22, 22, 24, 26, 28, 30, 31, 34, 36, 38 };
        int[] devastate_c = { 0, 27, 27, 30, 32, 35, 37, 39, 42, 45, 47 };
        int[] devastate_d = { 0, 12, 12, 14, 15, 18, 20, 21, 23, 26, 28 };
        string[] devastate_e = { "0", "+56-125", "+71-144", "+87-164", "+105-186", "+124-210", "+144-234", "+167-261", "+191-290", "+216-320", "+244-352" };

        public int soul_rend_lvl = 0;
        public string soul_rend_text;
        public string[] soul_rend_reqlvl = { "1", "2", "3", "5", "7", "10", "13", "17", "21", "26", "full" };
        int[] soul_rend_mana = { 0, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        int[] soul_rend_a = { 0, 120, 126, 132, 138, 144, 150, 156, 162, 168, 174 };
        int[] soul_rend_b = { 0, 36, 47, 57, 80, 103, 140, 181, 245, 316, 417 };

        public int titan_stomp_lvl = 0;
        public string titan_stomp_text;
        public string[] titan_stomp_reqlvl = { "5", "6", "7", "9", "11", "13", "19", "23", "28", "full" };
        int[] titan_stomp_mana = { 0, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
        string[] titan_stomp_a = { "0", "+19-37", "+23-45", "+27-53", "+34-68", "+42-84", "+50-100", "+65-129", "+81-161", "+104-208", "+137-274" };
        int[] titan_stomp_b = { 0, 67, 70, 73, 76, 79, 79, 82, 85, 88, 91 };
        int[] titan_stomp_c = { 0, 70, 75, 80, 85, 90, 95, 100, 105, 110, 115 };

        public int martial_weapons_lvl = 0;
        public string martial_weapons_text;
        public string[] martial_weapons_reqlvl = { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "full" };
        int[] martial_weapons_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] martial_weapons_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int ranged_weapon_lvl = 0;
        public string ranged_weapon_text;
        public string[] ranged_weapon_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] ranged_weapon_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] ranged_weapon_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int doomquake_lvl = 0;
        public string doomquake_text;
        public string[] doomquake_reqlvl = { "10", "11", "12", "13", "15", "17", "20", "23", "26", "30", "full" };
        int[] doomquake_mana = { 0, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33 };
        string[] doomquake_a = { "0", "+57-66", "+63-73", "+69-81", "+75-88", "+89-104", "+104-122", "+129-150", "+156-182", "+185-216", "+227-265" };
        int[] doomquake_b = { 0, 70, 75, 80, 85, 90, 95, 100, 105, 110, 115 };

        public int frost_shield_lvl = 0;
        public string frost_shield_text;
        public string[] frost_shield_reqlvl = { "15", "16", "17", "18", "19", "21", "23", "25", "28", "31", "full" };
        int[] frost_shield_mana = { 0, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
        int[] frost_shield_a = { 0, 50, 55, 59, 63, 68, 72, 77, 81, 86, 90 };
        int[] frost_shield_b = { 0, 29, 32, 35, 37, 40, 43, 45, 48, 51, 54 };

        public int barter_lvl = 0;
        public string barter_text;
        public string[] barter_reqlvl = { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "full" };
        int[] barter_a = { 0, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60 };

        public int block_and_parry_lvl = 0;
        public string block_and_parry_text;
        public string[] block_and_parry_reqlvl = { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "full" };
        int[] block_and_parry_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        public int seismic_burst_lvl = 0;
        public string seismic_burst_text;
        public string[] seismic_burst_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34" };
        int[] seismic_burst_mana = { 0, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        string[] seismic_burst_a = { "0", "+355-886", "+375-937", "+395-988", "+417-1042", "+439-1096", "+461-1151", "+484-1208", "+507-1266", "+531-1326", "+555-1387" };

        public int shadow_armor_lvl = 0;
        public string shadow_armor_text;
        public string[] shadow_armor_reqlvl = { "1", "2", "3", "5", "7", "10", "13", "17", "21", "26", "full" };
        int[] shadow_armor_a = { 0, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26 };
        int[] shadow_armor_b = { 0, 20, 33, 37, 41, 45, 49, 52, 56, 60, 65 };
        int[] shadow_armor_c = { 0, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31 };

        public int entropic_aura_lvl = 0;
        public string entropic_aura_text;
        public string[] entropic_aura_reqlvl = { "5", "6", "7", "9", "11", "13", "16", "19", "23", "28", "full" };
        int[] entropic_aura_a = { 0, 20, 22, 24, 26, 28, 30, 31, 34, 36, 38 };
        int[] entropic_aura_b = { 0, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 };

        public int armor_expertise_lvl = 0;
        public string armor_expertise_text;
        public string[] armor_expertise_reqlvl = { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "full" };
        int[] armor_expertise_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] armor_expertise_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int magic_weapon_lvl = 0;
        public string magic_weapon_text;
        public string[] magic_weapon_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] magic_weapon_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] magic_weapon_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int shadow_bowman_lvl = 0;
        public string shadow_bowman_text;
        public string[] shadow_bowman_reqlvl = { "10", "11", "12", "13", "15", "17", "20", "23", "26", "30", "full" };
        int[] shadow_bowman_mana = { 0, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32 };
        int[] shadow_bowman_a = { 0, 29, 33, 37, 41, 45, 49, 52, 56, 60, 65 };
        int[] shadow_bowman_b = { 0, 0, 5, 9, 13, 17, 21, 25, 29, 33, 38 };
        int[] shadow_bowman_c = { 0, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46 };

        public int charm_spell_lvl = 0;
        public string charm_spell_text;
        public string[] charm_spell_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] charm_spell_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int pet_mastery_lvl = 0;
        public string pet_mastery_text;
        public string[] pet_mastery_reqlvl = { "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "full" };
        int[] pet_mastery_a = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int aura_of_thorns_lvl = 0;
        public string aura_of_thorns_text;
        public string[] aura_of_thorns_reqlvl = { "20", "21", "22", "23", "24", "25", "27", "29", "31", "33", "full" };
        string[] aura_of_thorns_a = { "0", "+44-218", "+47-233", "+50-248", "+53-264", "+56-280", "+60-296", "+66-330", "+74-366", "+81-403", "+89-442" };

        public int spectral_decay_lvl = 0;
        public string spectral_decay_text;
        public string[] spectral_decay_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] spectral_decay_mana = { 0, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
        int[] spectral_decay_a = { 0, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23 };
        int[] spectral_decay_b = { 0, 25, 33, 41, 49, 58, 66, 74, 82, 90, 100 };
        int[] spectral_decay_c = { 0, 10, 12, 14, 16, 16, 18, 20, 22, 24, 26 };
        int[] spectral_decay_d = { 0, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };

        public int advanced_spellcasting_lvl = 0;
        public string advanced_spellcasting_text;
        public string[] advanced_spellcasting_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] advanced_spellcasting_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] advanced_spellcasting_b = { 0, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12 };

        public Destroyer()
        {

        }
    }
}
