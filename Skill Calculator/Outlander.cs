using System;

namespace Skill_Calculator
{
    public class Outlander
    {
        public int skillpointsleft, level, fame, statpointsleft;
        public int strength = 0, dexterity = 0, focus = 0, defence = 0;
        public int strength_old = 5, dexterity_old = 10, focus_old = 15, defence_old = 10;

        public int[] fame_ranks = { 2000, 3000, 4000, 5000, 7000, 9000, 12000, 14000, 16000, 18000, 19000, 22000, 23000, 26000, 27000, 29000, 31000, 34000, 35000, 37000, 40000, 41000, 44000, 46000, 48000, 50000, 52000, 55000, 56000, 59000, 62000, 63000, 9005000, 0 };
         
        public Outlander()
        {

        }

        public void calc()
        {
            skillpointsleft = (level + fame);
            statpointsleft = ((level - 1) * 5) - strength - dexterity - focus - defence;
        }

        public void tooltips_text()
        { }
    }
}