using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace Skill_Calculator
{
    public partial class Form1 : Form
    {
        Embermage emb = new Embermage();
        Outlander outl = new Outlander();

        public Form1()
        {
            InitializeComponent();
            famebox.SelectedIndex = 0;
            levelbox.SelectedIndex = 0;
            o_famebox.SelectedIndex = 0;
            o_levelbox.SelectedIndex = 0;
            Embermage_req_lvl();
            Outlander_req_lvl();
        }

        public void Embermage_calcpoints(object sender, EventArgs e)
        {
            emb.level = levelbox.SelectedIndex + 1;
            emb.fame = famebox.SelectedIndex;
            emb.calc();
            skillpoints.Text = Convert.ToString(emb.skillpointsleft);
            famepoints.Text = emb.fame_ranks[emb.fame];
            statpoints.Text = Convert.ToString(emb.statpointsleft);
            emb.stats_bonuses();
            Embermage_tooltips();
        }

        public void Embermage_req_lvl()
        {
            ms_lvl.Text = emb.magma_spear_reqlevel[emb.magma_spear_lvl];
            mm_lvl.Text = emb.magma_mace_reqlevel[emb.magma_mace_lvl];
            fb_lvl.Text = emb.firebombs_reqlevel[emb.firebombs_lvl];
            bp_lvl.Text = emb.blazing_pillar_reqlevel[emb.blazing_pillar_lvl];
            ic_lvl.Text = emb.infernal_collapse_reqlevel[emb.infernal_collapse_lvl];
            ia_lvl.Text = emb.immolation_aura_reqlevel[emb.immolation_aura_lvl];
            fs_lvl.Text = emb.immolation_aura_reqlevel[emb.immolation_aura_lvl];
            cm_lvl.Text = emb.charge_mastery_reqlevel[emb.charge_mastery_lvl];
            ea_lvl.Text = emb.elemental_attunement_reqlevel[emb.elemental_attunement_lvl];
            fbr_lvl.Text = emb.fire_brand_reqlevel[emb.fire_brand_lvl];
            ib_lvl.Text = emb.icy_blast_reqlevel[emb.icy_blast_lvl];
            hs_lvl.Text = emb.hailstorm_reqlevel[emb.hailstorm_lvl];
            fp_lvl.Text = emb.frost_phase_reqlevel[emb.frost_phase_lvl];
            eb_lbl.Text = emb.elemental_boon_reqlevel[emb.elemental_boon_lvl];
            fw_lvl.Text = emb.frost_wave_reqlevel[emb.frost_wave_lvl];
            ip_lvl.Text = emb.ice_prison_reqlevel[emb.ice_prison_lvl];
            aa_lvl.Text = emb.astral_ally_reqlevel[emb.astral_ally_lvl];
            sm_lvl.Text = emb.staff_mastery_reqlevel[emb.staff_mastery_lvl];
            ff_lvl.Text = emb.frozen_fate_reqlevel[emb.frozen_fate_lvl];
            ibr_lvl.Text = emb.ice_brand_reqlevel[emb.ice_brand_lvl];
            pb_lvl.Text = emb.prismatic_bolt_reqlevel[emb.prismatic_bolt_lvl];
            sb_lvl.Text = emb.shocking_burst_reqlevel[emb.shocking_burst_lvl];
            tl_lvl.Text = emb.thunder_locus_reqlevel[emb.thunder_locus_lvl];
            ab_lvl.Text = emb.arc_beam_reqlevel[emb.arc_beam_lvl];
            db_lvl.Text = emb.deaths_bounty_reqlevel[emb.deaths_bounty_lvl];
            sbo_lvl.Text = emb.shockbolts_reqlevel[emb.shockbolts_lvl];
            so_lvl.Text = emb.shocking_orb_reqlevel[emb.shocking_orb_lvl];
            pr_lvl.Text = emb.prismatic_rift_reqlevel[emb.prismatic_rift_lvl];
            wc_lvl.Text = emb.wand_chaos_reqlevel[emb.wand_chaos_lvl];
            lb_lvl.Text = emb.lightning_brand_reqlevel[emb.lightning_brand_lvl];
        }

        public void Embermage_tooltips()
        {
            emb.tooltips_text();

            toolTip1.SetToolTip(StrengthUD, emb.strength_text);
            toolTip1.SetToolTip(DexterityUD, emb.dexterity_text);
            toolTip1.SetToolTip(FocusUD, emb.focus_text);
            toolTip1.SetToolTip(VitalityUD, emb.vitality_text);

            toolTip1.SetToolTip(ms_panel, emb.magma_spear_text);                        
            toolTip1.SetToolTip(mm_panel, emb.magma_mace_text);
            toolTip1.SetToolTip(fb_panel, emb.firebombs_text);            
            toolTip1.SetToolTip(bp_panel, emb.blazing_pillar_text);
            toolTip1.SetToolTip(ic_panel, emb.infernal_collapse_text);
            toolTip1.SetToolTip(ia_panel, emb.immolation_aura_text);
            toolTip1.SetToolTip(fs_panel, emb.firestorm_text);
            toolTip1.SetToolTip(cm_panel, emb.charge_mastery_text);
            toolTip1.SetToolTip(ea_panel, emb.elemental_attunement_text);
            toolTip1.SetToolTip(fbr_panel, emb.fire_brand_text);
            toolTip1.SetToolTip(ib_panel, emb.icy_blast_text);
            toolTip1.SetToolTip(hs_panel, emb.hailstorm_text);
            toolTip1.SetToolTip(fp_panel, emb.frost_phase_text);
            toolTip1.SetToolTip(eb_panel, emb.elemental_boon_text);
            toolTip1.SetToolTip(fw_panel, emb.frost_wave_text);
            toolTip1.SetToolTip(ip_panel, emb.ice_prison_text);
            toolTip1.SetToolTip(aa_panel, emb.astral_ally_text);
            toolTip1.SetToolTip(sm_panel, emb.staff_mastery_text);
            toolTip1.SetToolTip(ff_panel, emb.frozen_fate_text);
            toolTip1.SetToolTip(ibr_panel, emb.ice_brand_text);
            toolTip1.SetToolTip(pb_panel, emb.prismatic_bolt_text);
            toolTip1.SetToolTip(sb_panel, emb.shocking_burst_text);
            toolTip1.SetToolTip(tl_panel, emb.thunder_locus_text);
            toolTip1.SetToolTip(ab_panel, emb.arc_beam_text);
            toolTip1.SetToolTip(db_panel, emb.deaths_bounty_text);
            toolTip1.SetToolTip(sbo_panel, emb.shockbolts_text);
            toolTip1.SetToolTip(so_panel, emb.shocking_orb_text);
            toolTip1.SetToolTip(pr_panel, emb.prismatic_rift_text);
            toolTip1.SetToolTip(wc_panel, emb.wand_chaos_text);
            toolTip1.SetToolTip(lb_panel, emb.lightning_brand_text);
        }

        public void Outlander_calcpoints(object sender, EventArgs e) { }

        public void Outlander_req_lvl() { }

        public void Outlander_tooltips() { }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font f = new Font("Arial", 9.0f);  
            e.DrawBackground();
            e.DrawBorder();
            e.Graphics.DrawString(e.ToolTipText, f, Brushes.AntiqueWhite, e.Bounds);   
        }      

        private void Embermage_reset_stats_Click(object sender, EventArgs e)
        {
            StrengthUD.Value = 5;
            DexterityUD.Value = 10;
            FocusUD.Value = 15;
            VitalityUD.Value = 10;
        }

        private void Embermage_reset_skills_Click(object sender, EventArgs e)
        {
            magma_spear.Value = 0;
            magma_mace.Value = 0;
            firebombs.Value = 0;
            blazing_pillar.Value = 0;
            infernal_collapse.Value = 0;
            immolation_aura.Value = 0;
            firestorm.Value = 0;
            charge_mastery.Value = 0;
            elemental_attunement.Value = 0;
            fire_brand.Value = 0;
            icy_blast.Value = 0;
            hailstorm.Value = 0;
            frost_phase.Value = 0;
            elemental_boon.Value = 0;
            frost_wave.Value = 0;
            ice_prison.Value = 0;
            astral_ally.Value = 0;
            staff_mastery.Value = 0;
            frozen_fate.Value = 0;
            ice_brand.Value = 0;
            prismatic_bolt.Value = 0;
            shocking_burst.Value = 0;
            thunder_locus.Value = 0;
            arc_beam.Value = 0;
            deaths_bounty.Value = 0;
            shockbolts.Value = 0;
            shocking_orb.Value = 0;
            prismatic_rift.Value = 0;
            wand_chaos.Value = 0;
            lightning_brand.Value = 0;
        }

        private void Embermage_stats_ValueChanged(object sender, EventArgs e)
        {
            emb.strength = (int)StrengthUD.Value;
            emb.dexterity = (int)DexterityUD.Value;
            emb.focus = (int)FocusUD.Value;
            emb.vitality = (int)VitalityUD.Value;
            Embermage_calcpoints(sender, e);
        }    

        private void Embermage_skills_ValueChanged(object sender, EventArgs e)
        {
            emb.magma_spear_lvl = (int)magma_spear.Value;
            emb.magma_mace_lvl = (int)magma_mace.Value;
            emb.firebombs_lvl = (int)firebombs.Value;
            emb.blazing_pillar_lvl = (int)blazing_pillar.Value;
            emb.infernal_collapse_lvl = (int)infernal_collapse.Value;
            emb.immolation_aura_lvl = (int)immolation_aura.Value;
            emb.firestorm_lvl = (int)firestorm.Value;
            emb.charge_mastery_lvl = (int)charge_mastery.Value;
            emb.elemental_attunement_lvl = (int)elemental_attunement.Value;
            emb.fire_brand_lvl = (int)fire_brand.Value;
            emb.icy_blast_lvl = (int)icy_blast.Value;
            emb.hailstorm_lvl = (int)hailstorm.Value;
            emb.frost_phase_lvl = (int)frost_phase.Value;
            emb.elemental_boon_lvl = (int)elemental_boon.Value;
            emb.frost_wave_lvl = (int)frost_wave.Value;
            emb.ice_prison_lvl = (int)ice_prison.Value;
            emb.astral_ally_lvl = (int)astral_ally.Value;
            emb.staff_mastery_lvl = (int)staff_mastery.Value;
            emb.frozen_fate_lvl = (int)frozen_fate.Value;
            emb.ice_brand_lvl = (int)ice_brand.Value;
            emb.prismatic_bolt_lvl = (int)prismatic_bolt.Value;
            emb.shocking_burst_lvl = (int)shocking_burst.Value;
            emb.thunder_locus_lvl = (int)thunder_locus.Value;
            emb.arc_beam_lvl = (int)arc_beam.Value;
            emb.deaths_bounty_lvl = (int)deaths_bounty.Value;
            emb.shockbolts_lvl = (int)shockbolts.Value;
            emb.shocking_orb_lvl = (int)shocking_orb.Value;
            emb.prismatic_rift_lvl = (int)prismatic_rift.Value;
            emb.wand_chaos_lvl = (int)wand_chaos.Value;
            emb.lightning_brand_lvl = (int)lightning_brand.Value;
            Embermage_calcpoints(sender, e);
            Embermage_req_lvl();
        }

        private void Outlander_stats_ValueChanged(object sender, EventArgs e)
        {
            outl.strength = (int)o_StrengthUD.Value;
            outl.vitality = (int)o_VitalityUD.Value;
        }

        private void Outlander_skills_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
