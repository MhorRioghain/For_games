using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCalculator
{
    public partial class Form1 : Form
    {
        Alchemist alc = new Alchemist();

        Font f = new Font("Arial", 9.0f);

        public Form1()
        {
            InitializeComponent();
            a_famebox.SelectedIndex = 0;
            a_levelbox.SelectedIndex = 0;
            Alchemist_req_lvl();
            Destroyer_req_lvl();
            Vanquisher_req_lvl();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            int THeight, TWidth = 450;

            Graphics g = CreateGraphics();
            THeight = (int)g.MeasureString(toolTip1.GetToolTip(e.AssociatedControl), f, TWidth).Height;
            e.ToolTipSize = new Size(TWidth, THeight);
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            Color c = Color.Lime;

            switch (tabControl1.SelectedIndex)
            {
                case 0: c = Color.LightSkyBlue; break;
                case 1: c = Color.Honeydew; break;
                case 2: c = Color.Maroon; break;
                default: break;
            }

            switch ((string)e.AssociatedControl.Parent.Tag)
            {
                case "1": toolTip1.BackColor = Color.FromArgb(21, 9, 9); break;
                case "2": toolTip1.BackColor = Color.FromArgb(16, 12, 38); break;
                case "3": toolTip1.BackColor = Color.FromArgb(47, 13, 26); break;
                default: break;
            }

            e.DrawBackground();
            Pen pen = new Pen(c, 3);
            e.Graphics.DrawLines(pen, new Point[] { new Point(0, e.Bounds.Height + 1), new Point(0, 0), new Point(e.Bounds.Width + 1, 0) });
            e.Graphics.DrawLines(pen, new Point[] { new Point(0, e.Bounds.Height - 1), new Point(e.Bounds.Width - 1, e.Bounds.Height - 1), new Point(e.Bounds.Width - 1, 0) });
            e.Graphics.DrawString(e.ToolTipText, f, Brushes.AntiqueWhite, e.Bounds);
        }

        private void Alchemist_calcpoints(object sender, EventArgs e)
        {
            alc.level = a_levelbox.SelectedIndex + 1;
            alc.fame = a_famebox.SelectedIndex;
            alc.calc();
            a_skillpoints.Text = Convert.ToString(alc.skillpointsleft);
            a_famepoints.Text = alc.fame_ranks[alc.fame];
            a_statpoints.Text = Convert.ToString(alc.statpointsleft);
            alc.stats_bonuses();
            Alchemist_tooltips();
        }

        private void Destroyer_calcpoints(object sender, EventArgs e)
        {
            
        }

        private void Vanquisher_calcpoints(object sender, EventArgs e)
        {

        }

        public void Alchemist_req_lvl()
        {
            aeb_lvl.Text = alc.ember_bolt_reqlvl[alc.ember_bolt_lvl];
            amwe_lvl.Text = alc.magic_weapon_reqlvl[alc.magic_weapon_lvl];
            ais_lvl.Text = alc.iceshock_reqlvl[alc.iceshock_lvl];
            acs_lvl.Text = alc.critical_strikes_reqlvl[alc.critical_strikes_lvl];
            aa_lvl.Text = alc.adventurer_reqlvl[alc.adventurer_lvl];
            ael_lvl.Text = alc.ember_lightning_reqlvl[alc.ember_lightning_lvl];
            aosm_lvl.Text = alc.offensive_spell_reqlvl[alc.offensive_spell_lvl];
            aelan_lvl.Text = alc.ember_lance_reqlvl[alc.ember_lance_lvl];
            ap_lvl.Text = alc.pyre_reqlel[alc.pyre_lvl];
            aas_lvl.Text = alc.advanced_spellcasting_reqlvl[alc.advanced_spellcasting_lvl];
            aes_lvl.Text = alc.ember_strike_reqlvl[alc.ember_strike_lvl];
            ani_lvl.Text = alc.nether_imp_reqlvl[alc.nether_imp_lvl];
            atm_lvl.Text = alc.thorned_minions_reqlvl[alc.thorned_minions_lvl];
            apm_lvl.Text = alc.pet_mastery_reqlvl[alc.pet_mastery_lvl];
            asag_lvl.Text = alc.alchemical_golem_reqlvl[alc.alchemical_golem_lvl];
            acsm_lvl.Text = alc.charm_spell_reqlvl[alc.charm_spell_lvl];
            at_lvl.Text = alc.terror_reqlvl[alc.terror_lvl];
            arwe_lvl.Text = alc.ranged_weapon_reqlvl[alc.ranged_weapon_lvl];
            abb_lvl.Text = alc.burning_bind_reqlvl[alc.burning_bind_lvl];
            ab_lvl.Text = alc.barter_reqlvl[alc.barter_lvl];
            asbm_lvl.Text = alc.beam_golem_reqlvl[alc.beam_golem_lvl];
            ath_lvl.Text = alc.treasure_hunter_reqlvl[alc.treasure_hunter_lvl];
            aeshock_lvl.Text = alc.ember_shock_reqlvl[alc.ember_shock_lvl];
            aae_lvl.Text = alc.armor_expertise_reqlvl[alc.armor_expertise_lvl];
            aeshield_lvl.Text = alc.ember_shield_reqlvl[alc.ember_shield_lvl];
            amarwe_lvl.Text = alc.martial_weapons_reqlvl[alc.martial_weapons_lvl];
            ai_lvl.Text = alc.infuse_reqlvl[alc.infuse_lvl];
            adsm_lvl.Text = alc.defensive_spell_reqlvl[alc.defensive_spell_lvl];
            af_lvl.Text = alc.frailty_reqlvl[alc.frailty_lvl];
            adw_lvl.Text = alc.dual_wielding_reqlvl[alc.dual_wielding_lvl];
            aep_lvl.Text = alc.ember_phase_reqlvl[alc.ember_phase_lvl];
            abp_lvl.Text = alc.block_and_parry_reqlvl[alc.block_and_parry_lvl];
            aesen_lvl.Text = alc.ember_sentry_reqlvl[alc.ember_sentry_lvl];
        }

        public void Destroyer_req_lvl()
        {

        }

        public void Vanquisher_req_lvl()
        {

        }

        public void Alchemist_tooltips()
        {
            alc.tooltips_text();

            toolTip1.SetToolTip(a_StrengthUD, alc.strength_text);
            toolTip1.SetToolTip(a_DexterityUD, alc.dexterity_text);
            toolTip1.SetToolTip(a_FocusUD, alc.focus_text);
            toolTip1.SetToolTip(a_VitalityUD, alc.vitality_text);

            toolTip1.SetToolTip(aeb_panel, alc.ember_bolt_text);
            toolTip1.SetToolTip(amwe_panel, alc.magic_weapon_text);
            toolTip1.SetToolTip(ais_panel, alc.iceshock_text);
            toolTip1.SetToolTip(acs_panel, alc.critical_strikes_text);
            toolTip1.SetToolTip(aa_panel, alc.adventurer_text);
            toolTip1.SetToolTip(ael_panel, alc.ember_lightning_text);
            toolTip1.SetToolTip(aosm_panel, alc.offensive_spell_text);
            toolTip1.SetToolTip(aelan_panel, alc.ember_lance_text);
            toolTip1.SetToolTip(ap_panel, alc.pyre_text);
            toolTip1.SetToolTip(aas_panel, alc.advanced_spellcasting_text);
            toolTip1.SetToolTip(aes_panel, alc.ember_strike_text);
            toolTip1.SetToolTip(ani_panel, alc.nether_imp_text);
            toolTip1.SetToolTip(atm_panel, alc.thorned_minions_text);
            toolTip1.SetToolTip(apm_panel, alc.pet_mastery_text);
            toolTip1.SetToolTip(asag_panel, alc.alchemical_golem_text);
            toolTip1.SetToolTip(acsm_panel, alc.charm_spell_text);
            toolTip1.SetToolTip(at_panel, alc.terror_text);
            toolTip1.SetToolTip(arwe_panel, alc.ranged_weapon_text);
            toolTip1.SetToolTip(abb_panel, alc.burning_bind_text);
            toolTip1.SetToolTip(ab_panel, alc.barter_text);
            toolTip1.SetToolTip(asbm_panel, alc.beam_golem_text);
            toolTip1.SetToolTip(ath_panel, alc.treasure_hunter_text);
            toolTip1.SetToolTip(aeshock_panel, alc.ember_shock_text);
            toolTip1.SetToolTip(aae_panel, alc.armor_expertise_text);
            toolTip1.SetToolTip(aeshield_panel, alc.ember_shield_text);
            toolTip1.SetToolTip(amarwe_panel, alc.martial_weapons_text);
            toolTip1.SetToolTip(ai_panel, alc.infuse_text);
            toolTip1.SetToolTip(adsm_panel, alc.defensive_spell_text);
            toolTip1.SetToolTip(af_panel, alc.frailty_text);
            toolTip1.SetToolTip(adw_panel, alc.dual_wielding_text);
            toolTip1.SetToolTip(aep_panel, alc.ember_phase_text);
            toolTip1.SetToolTip(abp_panel, alc.block_and_parry_text);
            toolTip1.SetToolTip(aesen_panel, alc.ember_sentry_text);            
        }

        public void Destroyer_tooltips()
        {

        }

        public void Vanquisher_tooltips()
        {

        }

        private void Alchemist_skills_ValueChanged(object sender, EventArgs e)
        {
            alc.ember_bolt_lvl = (int)ember_bolt.Value;
            alc.magic_weapon_lvl = (int)magic_weapon.Value;
            alc.iceshock_lvl = (int)iceshock.Value;
            alc.critical_strikes_lvl = (int)critical_strikes.Value;
            alc.adventurer_lvl = (int)adventurer.Value;
            alc.ember_lightning_lvl = (int)ember_lightning.Value;
            alc.offensive_spell_lvl = (int)offensive_spell.Value;
            alc.ember_lance_lvl = (int)ember_lance.Value;
            alc.pyre_lvl = (int)pyre.Value;
            alc.advanced_spellcasting_lvl = (int)advanced_spellcasting.Value;
            alc.ember_strike_lvl = (int)ember_strike.Value;
            alc.nether_imp_lvl = (int)nether_imp.Value;
            alc.thorned_minions_lvl = (int)thorned_minions.Value;
            alc.pet_mastery_lvl = (int)pet_mastery.Value;
            alc.alchemical_golem_lvl = (int)alchemical_golem.Value;
            alc.charm_spell_lvl = (int)charm_spell.Value;
            alc.terror_lvl = (int)terror.Value;
            alc.ranged_weapon_lvl = (int)ranged_weapon.Value;
            alc.burning_bind_lvl = (int)burning_bind.Value;
            alc.barter_lvl = (int)barter.Value;
            alc.beam_golem_lvl = (int)beam_golem.Value;
            alc.treasure_hunter_lvl = (int)treasure_hunter.Value;
            alc.ember_shock_lvl = (int)ember_shock.Value;
            alc.armor_expertise_lvl = (int)armor_expertise.Value;
            alc.ember_shield_lvl = (int)ember_shield.Value;
            alc.martial_weapons_lvl = (int)martial_weapons.Value;
            alc.infuse_lvl = (int)infuse.Value;
            alc.defensive_spell_lvl = (int)defensive_spell.Value;
            alc.frailty_lvl = (int)frailty.Value;
            alc.dual_wielding_lvl = (int)dual_wielding.Value;
            alc.ember_phase_lvl = (int)ember_phase.Value;
            alc.block_and_parry_lvl = (int)block_and_parry.Value;
            alc.ember_sentry_lvl = (int)ember_sentry.Value;
            Alchemist_calcpoints(sender, e);
            Alchemist_req_lvl();
        }

        private void Destroyer_skills_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Vanquisher_skills_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Alchemist_stats_ValueChanged(object sender, EventArgs e)
        {
            alc.strength = (int)a_StrengthUD.Value;
            alc.dexterity = (int)a_DexterityUD.Value;
            alc.focus = (int)a_FocusUD.Value;
            alc.vitality = (int)a_VitalityUD.Value;
            Alchemist_calcpoints(sender, e);
        }

        private void Destroyer_stats_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Vanquisher_stats_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Alchemist_reset_stats_Click(object sender, EventArgs e)
        {
            a_StrengthUD.Value = 5;
            a_DexterityUD.Value = 10;
            a_FocusUD.Value = 15;
            a_VitalityUD.Value = 10;
        }

        private void Alchemist_reset_skills_Click(object sender, EventArgs e)
        {
            ember_bolt.Value = 0;
            magic_weapon.Value = 0;
            iceshock.Value = 0;
            critical_strikes.Value = 0;
            adventurer.Value = 0;
            ember_lightning.Value = 0;
            offensive_spell.Value = 0;
            ember_lance.Value = 0;
            pyre.Value = 0;
            advanced_spellcasting.Value = 0;
            ember_strike.Value = 0;
            nether_imp.Value = 0;
            thorned_minions.Value = 0;
            pet_mastery.Value = 0;
            alchemical_golem.Value = 0;
            charm_spell.Value = 0;
            terror.Value = 0;
            ranged_weapon.Value = 0;
            burning_bind.Value = 0;
            barter.Value = 0;
            beam_golem.Value = 0;
            treasure_hunter.Value = 0;
            ember_shock.Value = 0;
            armor_expertise.Value = 0;
            ember_shield.Value = 0;
            martial_weapons.Value = 0;
            infuse.Value = 0;
            defensive_spell.Value = 0;
            frailty.Value = 0;
            dual_wielding.Value = 0;
            ember_phase.Value = 0;
            block_and_parry.Value = 0;
            ember_sentry.Value = 0;
        }

        
    }
}
