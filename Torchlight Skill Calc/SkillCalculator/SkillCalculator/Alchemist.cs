using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCalculator
{          
    class Alchemist
    {
        public int skillpointsleft, level, fame, statpointsleft;
        public double strength = 15, dexterity = 5, focus = 5, vitality = 15;
        public string strength_text, dexterity_text, focus_text, vitality_text;

        public string[] fame_ranks = { "2000", "3000", "4000", "5000", "7000", "9000", "12000", "14000", "16000", "18000", "19000", "22000", "23000", "26000", "27000", "29000", "31000", "34000", "35000", "37000", "40000", "41000", "44000", "46000", "48000", "50000", "52000", "55000", "56000", "59000", "62000", "63000", "9005000", "full" };

        public int ember_bolt_lvl;
        public string ember_bolt_text;
        public string[] ember_bolt_reqlevel = { "1", "2", "3", "5", "7", "10", "13", "17", "21", "26", "full" };
        double[] ember_bolt_mana = { 0, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16 };
        string[] ember_bolt_a = { "0", "+10-14", "+18-25", "+21-35", "+26-37", "+34-49", "+47-68", "+62-89", "+85-122", "+110-159", "+147-211" };
        double[] ember_bolt_b = { 0, 10, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
        
        public int magic_weapon_exp_lvl;
        public string magic_weapon_exp_text;
        public string[] magic_weapon_exp_reqlevel = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "full" };
        double[] magic_weapon_a = { 0, -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
        string[] magic_weapon_b = { "+4", "+8", "+12", "+16", "+20", "+24", "+28", "+32", "+36", "+40" };

        public int iceshock_lvl;
        public string iceshock_text;
        public string[] iceshock_reqlevel = { "5", "6", "7", "9", "11", "13", "16", "19", "23", "28", "full" };
        double[] iceshock_mana = { 0, 8, 9, 10, 11, 12, 13, 14, 15, 17, 19 };
        string[] iceshock_a = { "0", "+25-34", "+30-41", "+35-48", "+44-62", "+55-77", "+66-92", "+85-118", "+106-148", "+136-191", "+180-252" };
        double[] iceshock_b = { 0, 63, 65, 68, 73, 78, 83, 90, 98, 108, 120 };

        public int critical_strikes_lvl;
        public string critical_strikes_text;
        public string[] crtical_strikes_reqlevel = { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "full" };

    }
}
