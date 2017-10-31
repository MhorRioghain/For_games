using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCalculator
{          
    public class Alchemist
    {
        public int skillpointsleft, level, fame, statpointsleft;
        public double strength = 15, dexterity = 5, focus = 5, vitality = 15;
        public string strength_text, dexterity_text, focus_text, vitality_text;

        public string[] fame_ranks = { "1600", "2160", "3200", "4340", "5510", "6770", "8060", "9430", "10840", "12310", "13780", "15320", "16890", "18440", "20100", "21720", "23400", "25080", "26750", "28530", "30240", "31990", "33800", "35560", "37370", "39230", "41040", "42890", "44780", "46610", "48480", "50380", "52320", "54180", "56070", "58000", "59940", "61930", "63820", "65740", "67680", "69650", "71630", "73650", "75560", "77480", "79570", "81530", "83520", "85520", "87560", "89450", "91510", "93440", "full" };

        double weapon_damage, critical_damage, double_chance, critical_chance, fumble_recovery, max_mana, magic_damage, execute_chance, max_health, armor_bonus, block_chance;

        public int ember_bolt_lvl = 0;
        public string ember_bolt_text;
        public string[] ember_bolt_reqlvl = { "1", "2", "3", "5", "7", "10", "13", "17", "21", "26", "full" };
        int[] ember_bolt_mana = { 0, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16 };
        string[] ember_bolt_a = { "0", "+10-14", "+18-25", "+21-35", "+26-37", "+34-49", "+47-68", "+62-89", "+85-122", "+110-159", "+147-211" };
        int[] ember_bolt_b = { 0, 10, 20, 20, 20, 20, 20, 20, 20, 20, 20 };

        public int magic_weapon_lvl = 0;
        public string magic_weapon_text;
        public string[] magic_weapon_reqlvl = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "full" };
        int[] magic_weapon_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] magic_weapon_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int iceshock_lvl = 0;
        public string iceshock_text;
        public string[] iceshock_reqlvl = { "5", "6", "7", "9", "11", "13", "16", "19", "23", "28", "full" };
        int[] iceshock_mana = { 0, 8, 9, 10, 11, 12, 13, 14, 15, 17, 19 };
        string[] iceshock_a = { "0", "+25-34", "+30-41", "+35-48", "+44-62", "+55-77", "+66-92", "+85-118", "+106-148", "+136-191", "+180-252" };
        int[] iceshock_b = { 0, 63, 65, 68, 73, 78, 83, 90, 98, 108, 120 };

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

        public int ember_lightning_lvl = 0;
        public string ember_lightning_text;
        public string[] ember_lightning_reqlvl = { "10", "11", "12", "13", "15", "17", "20", "23", "26", "30", "full" };
        int[] ember_lightning_mana = { 0, 9, 10, 11, 12, 13, 14, 15, 17, 19, 21 };
        string[] ember_lightning_a = { "0", "+54-221", "+60-246", "+66-270", "+72-295", "+86-349", "+100-409", "+124-505", "+150-612", "+178-726", "+218-892" };

        public int offensive_spell_lvl = 0;
        public string offensive_spell_text;
        public string[] offensive_spell_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] offensive_spell_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int ember_lance_lvl = 0;
        public string ember_lance_text;
        public string[] ember_lance_reqlvl = { "15", "16", "17", "18", "19", "21", "23", "25", "28", "31", "full" };
        int[] ember_lance_mana = { 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
        string[] ember_lance_a = { "0", "+61-152", "+66-165", "+71-178", "+77-192", "+83-206", "+94-235", "+107-266", "+120-298", "+141-351", "+163-407" };

        public int pyre_lvl = 0;
        public string pyre_text;
        public string[] pyre_reqlel = { "20", "21", "22", "23", "24", "25", "27", "29", "31", "33", "full" };
        int[] pyre_mana = { 0, 15, 16, 17, 19, 21, 23, 25, 27, 29, 31 };
        int[] pyre_a = { 0, 90, 96, 103, 109, 116, 122, 136, 151, 167, 183 };

        public int advanced_spellcasting_lvl = 0;
        public string advanced_spellcasting_text;
        public string[] advanced_spellcasting_reqlvl = { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "full" };
        int[] advanced_spellcasting_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] advanced_spellcasting_b = { 0, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12 };

        public int ember_strike_lvl = 0;
        public string ember_strike_text;
        public string[] ember_strike_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] ember_strike_mana = { 0, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };
        string[] ember_strike_a = { "0", "+305-488", "+323-516", "+340-544", "+359-634", "+378-604", "+396-634", "+416-666", "+436-697", "+457-731", "+478-764" };

        public int nether_imp_lvl = 0;
        public string nether_imp_text;
        public string[] nether_imp_reqlvl = { "1", "2", "3", "5", "7", "10", "13", "17", "21", "26", "full" };
        int[] nether_imp_mana = { 0, 15, 13, 14, 16, 17, 18, 19, 20, 21 };
        int[] nether_imp_a = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6 };
        int[] nether_imp_b = { 0, 0, 0, 20, 20, 40, 40, 60, 60, 80, 80 };
        int[] nether_imp_c = { 0, 0, 0, 5, 5, 10, 10, 15, 15, 20, 20 };

        public int thorned_minions_lvl = 0;
        public string thorned_minions_text;
        public string[] thorned_minions_reqlvl = { "5", "6", "7", "9", "11", "13", "16", "19", "23", "28", "full" };
        int[] thorned_minions_mana = { 0, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32 };
        int[] thorned_minions_a = { 0, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };
        int[] thorned_minions_b = { 0, 10, 12, 14, 16, 18, 20, 22, 24, 26, 30 };

        public int pet_mastery_lvl = 0;
        public string pet_mastery_text;
        public string[] pet_mastery_reqlvl = { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "full" };
        int[] pet_mastery_a = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int alchemical_golem_lvl = 0;
        public string alchemical_golem_text;
        public string[] alchemical_golem_reqlvl = { "10", "11", "12", "13", "15", "17", "20", "23", "26", "30", "full" };
        int[] alchemical_golem_mana = { 0, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38 };
        string[] alchemical_golem_a = { "0", "+18-25", "+21-31", "+26-37", "+34-49", "+47-68", "+62-89", "+85-122", "+110-159", "+147-211" };

        public int charm_spell_lvl = 0;
        public string charm_spell_text;
        public string[] charm_spell_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] charm_spell_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int terror_lvl = 0;
        public string terror_text;
        public string[] terror_reqlvl = { "15", "16", "17", "18", "19", "21", "23", "25", "28", "31", "full" };
        int[] terror_mana = { 0, 8, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int[] terror_a = { 0, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24 };
        int[] terror_b = { 0, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7 };

        public int ranged_weapon_lvl = 0;
        public string ranged_weapon_text;
        public string[] ranged_weapon_reqlvl = { "15", "16", "17", "18", ",19", "20", "21", "22", "23", "24", "full" };
        int[] ranged_weapon_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] ranged_weapon_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int burning_bind_lvl = 0;
        public string burning_bind_text;
        public string[] burning_bind_reqlvl = { "20", "21", "22", "23", "24", "25", "27", "29", "31", "33", "full" };
        int[] burning_bind_mana = { 0, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32 };
        int[] burning_bind_a = { 0, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140 };
        int[] burning_bind_b = { 0, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33 };
        int[] burning_bind_c = { 0, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20 };

        public int barter_lvl = 0;
        public string barter_text;
        public string[] barter_reqlvl = { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "full" };
        int[] barter_a = { 0, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60 };

        public int beam_golem_lvl = 0;
        public string beam_golem_text;
        public string[] beam_golem_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] beam_golem_mana = { 0, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58 };

        public int treasure_hunter_lvl = 0;
        public string treasure_hunter_text;
        public string[] treasure_hunter_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] treasure_hunter_a = { 0, 3, 5, 8, 10, 13, 15, 18, 20, 23, 25 };

        public int ember_shock_lvl = 0;
        public string ember_shock_text;
        public string[] ember_shock_reqlvl = { "1", "2", "3", "5", "7", "10", "13", "17", "21", "26", "full" };
        int[] ember_shock_mana = { 0, 8, 10, 12, 14, 16, 18, 20, 22, 24, 28 };
        string[] ember_shock_a = { "0", "+49-77", "+68-108", "+88-139", "+129-205", "+151-239", "+216-343", "+288-459", "+400-636", "+528-840", "+528-840", "+710-1129" };

        public int armor_expertise_lvl = 0;
        public string armor_expertise_text;
        public string[] armor_expertise_reqlvl = { "1", "2", "3", "5", "7", "10", "13", "17", "21", "26", "full" };
        int[] armor_expertise_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] armor_expertise_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int ember_shield_lvl = 0;
        public string ember_shield_text;
        public string[] ember_shield_reqlvl = { "5", "6", "7", "9", "11", "13", "16", "19", "23", "28", "full" };
        int[] ember_shield_mana = { 0, 12, 13, 14, 15, 16, 17, 18, 19, 21, 23 };
        int[] ember_shield_a = { 0, 129, 162, 194, 226, 258, 291, 323, 355, 387, 420 };

        public int martial_weapons_lvl = 0;
        public string martial_weapons_text;
        public string[] martial_weapons_reqlvl = { "10", "11", "12", "13", "15", "17", "20", "23", "26", "30", "full" };
        int[] martial_weapons_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] martial_weapons_b = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 };

        public int infuse_lvl = 0;
        public string infuse_text;
        public string[] infuse_reqlvl = { "10", "11", "12", "13", "15", "17", "20", "23", "26", "30", "full" };
        int[] infuse_mana = { 0, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
        int[] infuse_a = { 0, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75 };

        public int defensive_spell_lvl = 0;
        public string defensive_spell_text;
        public string[] defensive_spell_reqlvl = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "full" };
        int[] defensive_spell_a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int frailty_lvl = 0;
        public string frailty_text;
        public string[] frailty_reqlvl = { "15", "16", "17", "18", "19", "21", "23", "25", "28", "31", "full" };
        int[] frailty_mana = { 0, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        int[] frailty_a = { 0, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65 };
        int[] frailty_b = { 0, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int[] frailty_c = { 0, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28 };
        int[] frailty_d = { 0, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4 };

        public int dual_wielding_lvl = 0;
        public string dual_wielding_text;
        public string[] dual_wielding_reqlvl = { "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "full" };
        int[] dual_wielding_a = { 0, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60 };

        public int ember_phase_lvl = 0;
        public string ember_phase_text;
        public string[] ember_phase_reqlvl = { "20", "21", "22", "23", "24", "25", "27", "29", "31", "33", "full" };
        int[] ember_phase_mana = { 0, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
        string[] ember_phase_a = { "+78-155", "+83-165", "+88-176", "+94-187", "+100-199", "+105-210", "+117-234", "+130-260", "+143-286", "+157-314" };
        int[] ember_phase_b = { 0, 42, 44, 46, 48, 50, 52, 56, 60, 64, 68 };

        public int block_and_parry_lvl = 0;
        public string block_and_parry_text;
        public string[] block_and_parry_reqlvl = { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "full" };
        int[] block_and_parry_a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        public int ember_sentry_lvl = 0;
        public string ember_sentry_text;
        public string[] ember_sentry_reqlvl = { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "full" };
        int[] ember_sentry_mana = { 0, 20, 22, 24, 26, 28, 30, 32, 27, 34, 36 };

        public Alchemist()
        {
 
        }

        public void calc()
        {
            skillpointsleft = (level + fame) - ember_bolt_lvl - magic_weapon_lvl - iceshock_lvl - critical_strikes_lvl - adventurer_lvl - ember_lightning_lvl - offensive_spell_lvl - ember_lance_lvl - pyre_lvl - advanced_spellcasting_lvl - ember_strike_lvl - nether_imp_lvl - thorned_minions_lvl - pet_mastery_lvl - alchemical_golem_lvl - charm_spell_lvl - terror_lvl - ranged_weapon_lvl - burning_bind_lvl - barter_lvl - beam_golem_lvl - treasure_hunter_lvl - ember_shock_lvl - armor_expertise_lvl - ember_shield_lvl - martial_weapons_lvl - infuse_lvl - defensive_spell_lvl - frailty_lvl - dual_wielding_lvl - ember_phase_lvl - block_and_parry_lvl - ember_sentry_lvl;
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

            ember_bolt_text = "";
            magic_weapon_text = "";
            iceshock_text = "";
            critical_strikes_text = "";
            adventurer_text = "";
            ember_lightning_text = "";
            offensive_spell_text = "";
            ember_lance_text = "";
            pyre_text = "";
            advanced_spellcasting_text = "";
            ember_strike_text = "";
            nether_imp_text = "";
            thorned_minions_text = "";
            pet_mastery_text = "";
            alchemical_golem_text = "";
            charm_spell_text = "";
            terror_text = "";
            ranged_weapon_text = "";
            burning_bind_text = "";
            barter_text = "";
            beam_golem_text = "";
            treasure_hunter_text = "";
            ember_shock_text = "";
            armor_expertise_text = "";
            ember_shield_text = "";
            martial_weapons_text = "";
            infuse_text = "";
            defensive_spell_text = "";
            frailty_text = "";
            dual_wielding_text = "";
            ember_phase_text = "";
            block_and_parry_text = "";
            ember_sentry_text = "";
        }
    }
}

//aeb,amwe,ais,acs,aa,ael,aosm,aelan,ap,aas,aes,
//ani,atm,apm,asag,acsm,at,arwe,abb,ab,asbm,ath
//aeshock,aae,aeshild,amarwe,ai,adsm,af,adw,aep,abp,aesen*/