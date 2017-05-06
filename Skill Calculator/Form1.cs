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
        Berserker ber = new Berserker();
        Engineer eng = new Engineer();

        public Form1()
        {
            InitializeComponent();
            famebox.SelectedIndex = 0;
            levelbox.SelectedIndex = 0;
            o_famebox.SelectedIndex = 0;
            o_levelbox.SelectedIndex = 0;
            b_famebox.SelectedIndex = 0;
            b_levelbox.SelectedIndex = 0;
            e_famebox.SelectedIndex = 0;
            e_levelbox.SelectedIndex = 0;
            Embermage_req_lvl();
            Outlander_req_lvl();

            toolTip1.SetToolTip(TEST, outl.death_ritual_text);       
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
            eb_lvl.Text = emb.elemental_boon_reqlevel[emb.elemental_boon_lvl];
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

        public void Outlander_calcpoints(object sender, EventArgs e) 
        {
            outl.level = o_levelbox.SelectedIndex + 1;
            outl.fame = o_famebox.SelectedIndex;
            outl.calc();
            o_skillpoints.Text = Convert.ToString(outl.skillpointsleft);
            o_famepoints.Text = outl.fame_ranks[outl.fame];
            o_statpoints.Text = Convert.ToString(outl.statpointsleft);
            outl.stats_bonuses();
            Outlander_tooltips();
        } 

        public void Outlander_req_lvl() 
        {
            orf_lvl.Text = outl.rapid_fire_reqlevel[outl.rapid_fire_lvl];
            orv_lvl.Text = outl.rune_vault_reqlevel[outl.rune_vault_lvl];
            ocb_lvl.Text = outl.chaos_burst_reqlevel[outl.chaos_burst_lvl];
            ocd_lvl.Text = outl.cursed_daggers_reqlevel[outl.cursed_daggers_lvl];
            ovh_lvl.Text = outl.vortex_hex_reqlevel[outl.vortex_hex_lvl];
            osg_lvl.Text = outl.shattering_glaive_reqlevel[outl.shattering_glaive_lvl];
            ovhail_lvl.Text = outl.venomous_hail_reqlevel[outl.venomous_hail_lvl];
            olrm_lvl.Text = outl.long_range_mastery_reqlevel[outl.long_range_mastery_lvl];
            osm_lvl.Text = outl.shotgonne_mastery_reqlevel[outl.shotgonne_mastery_lvl];
            oa_lvl.Text = outl.akimbo_reqlevel[outl.akimbo_lvl];
            ogt_lvl.Text = outl.glaive_throw_reqlevel[outl.glaive_throw_lvl];
            ots_lvl.Text = outl.tangling_shot_reqlevel[outl.tangling_shot_lvl];
            ogs_lvl.Text = outl.glaive_sweep_reqlevel[outl.glaive_sweep_lvl];
            os_lvl.Text = outl.sandstorm_reqlevel[outl.sandstorm_lvl];
            obw_lvl.Text = outl.bramble_wall_reqlevel[outl.bramble_wall_lvl];
            obl_lvl.Text = outl.burning_leap_reqlevel[outl.burning_leap_lvl];
            ofg_lvl.Text = outl.flaming_glaives_reqlevel[outl.flaming_glaives_lvl];
            odm_lvl.Text = outl.dodge_mastery_reqlevel[outl.dodge_mastery_lvl];
            opb_lvl.Text = outl.poison_burst_reqlevel[outl.poison_burst_lvl];
            ostw_lvl.Text = outl.share_the_wealth_reqlevel[outl.share_the_wealth_lvl];
            opb_lvl.Text = outl.blade_pact_reqlevel[outl.blade_pact_lvl];
            oss_lvl.Text = outl.shadowshot_reqlevel[outl.shadowshot_lvl];
            obb_lvl.Text = outl.bane_breath_reqlevel[outl.bane_breath_lvl];
            orh_lvl.Text = outl.repulsion_hex_reqlevel[outl.repulsion_hex_lvl];
            osp_lvl.Text = outl.stone_pact_reqlevel[outl.stone_pact_lvl];
            oshad_lvl.Text = outl.shadowmantle_reqlevel[outl.shadowmantle_lvl];
            osb_lvl.Text = outl.shadowling_brute_reqlevel[outl.shadowling_brute_lvl];
            omote_lvl.Text = outl.master_of_the_elements_reqlevel[outl.master_of_the_elements_lvl];
            osa_lvl.Text = outl.shadowling_ammo_reqlevel[outl.shadowling_ammo_lvl];
            odr_lvl.Text = outl.death_ritual_reqlevel[outl.death_ritual_lvl];            
        }

        public void Outlander_tooltips() 
        {
            outl.tooltips_text();

            toolTip1.SetToolTip(o_StrengthUD, outl.strength_text);
            toolTip1.SetToolTip(o_DexterityUD, outl.dexterity_text);
            toolTip1.SetToolTip(o_FocusUD, outl.focus_text);
            toolTip1.SetToolTip(o_VitalityUD, outl.vitality_text);

            toolTip1.SetToolTip(orf_panel, outl.rapid_fire_text);
            toolTip1.SetToolTip(orv_panel, outl.rune_vault_text);
            toolTip1.SetToolTip(ocb_panel, outl.chaos_burst_text);
            toolTip1.SetToolTip(ocd_panel, outl.cursed_daggers_text);
            toolTip1.SetToolTip(ovh_panel, outl.vortex_hex_text);
            toolTip1.SetToolTip(osg_panel, outl.shattering_glaive_text);
            toolTip1.SetToolTip(ovhail_panel, outl.venomous_hail_text);
            toolTip1.SetToolTip(olrm_panel, outl.long_range_mastery_text);
            toolTip1.SetToolTip(osm_panel, outl.shotgonne_mastery_text);
            toolTip1.SetToolTip(oa_panel, outl.akimbo_text);
            toolTip1.SetToolTip(ogt_panel, outl.glaive_throw_text);
            toolTip1.SetToolTip(ots_panel, outl.tangling_shot_text);
            toolTip1.SetToolTip(ogs_panel, outl.glaive_sweep_text);
            toolTip1.SetToolTip(os_panel, outl.sandstorm_text);
            toolTip1.SetToolTip(obw_panel, outl.bramble_wall_text);
            toolTip1.SetToolTip(obl_panel, outl.burning_leap_text);
            toolTip1.SetToolTip(ofg_panel, outl.flaming_glaives_text);
            toolTip1.SetToolTip(odm_panel, outl.dodge_mastery_text);
            toolTip1.SetToolTip(opb_panel, outl.poison_burst_text);
            toolTip1.SetToolTip(ostw_panel, outl.share_the_wealth_text);
            toolTip1.SetToolTip(obp_panel, outl.blade_pact_text);
            toolTip1.SetToolTip(oss_panel, outl.shadowshot_text);
            toolTip1.SetToolTip(obb_panel, outl.bane_breath_text);
            toolTip1.SetToolTip(orh_panel, outl.repulsion_hex_text);
            toolTip1.SetToolTip(osp_panel, outl.stone_pact_text);
            toolTip1.SetToolTip(oshad_panel, outl.shadowmantle_text);
            toolTip1.SetToolTip(osb_panel, outl.shadowling_brute_text);
            toolTip1.SetToolTip(omote_panel, outl.master_of_the_elements_text);
            toolTip1.SetToolTip(osa_panel, outl.shadowling_ammo_text);
            toolTip1.SetToolTip(odr_panel, outl.death_ritual_text);   
        }

        public void Berserker_calcpoints(object sender, EventArgs e)
        {
            ber.level = b_levelbox.SelectedIndex + 1;
            ber.fame = b_famebox.SelectedIndex;
            ber.calc();
            b_skillpoints.Text = Convert.ToString(ber.skillpointsleft);
            b_famepoints.Text = ber.fame_ranks[ber.fame];
            b_statpoints.Text = Convert.ToString(ber.statpointsleft);
            ber.stats_bonuses();
            Berserker_tooltips();
        } //complete

        public void Berserker_req_lvl()
        {

        }

        public void Berserker_tooltips()
        {

        }

        public void Engineer_calcpoints(object sender, EventArgs e)
        {
            eng.level = e_levelbox.SelectedIndex + 1;
            eng.fame = e_famebox.SelectedIndex;
            eng.calc();
            e_skillpoints.Text = Convert.ToString(eng.skillpointsleft);
            e_famepoints.Text = eng.fame_ranks[eng.fame];
            e_statpoints.Text = Convert.ToString(eng.statpointsleft);
            eng.stats_bonuses();
            Engineer__tooltips();
        } //complete

        public void Engineer_req_lvl()
        {

        }

        public void Engineer__tooltips()
        {

        }

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

        private void Outlander_reset_stats_Click(object sender, EventArgs e)
        {
            o_StrengthUD.Value = 10;
            o_DexterityUD.Value = 15;
            o_FocusUD.Value = 10;
            o_VitalityUD.Value = 5;
        }

        private void Outlander_reset_skills_Click(object sender, EventArgs e)
        {
            rapid_fire.Value = 0;
            rune_vault.Value = 0;
            chaos_burst.Value = 0;
            cursed_daggers.Value = 0;
            vortex_hex.Value = 0;
            shattering_glaive.Value = 0;
            venomous_hail.Value = 0;
            long_rage_mastery.Value = 0;
            shotgonne_mastery.Value = 0;
            akimbo.Value = 0;
            glaive_throw.Value = 0;
            tangling_shot.Value = 0;
            glaive_sweep.Value = 0;
            sandstorm.Value = 0;
            bramble_wall.Value = 0;
            burning_leap.Value = 0;
            flaming_glaive.Value = 0;
            dodge_mastery.Value = 0;
            poison_burst.Value = 0;
            share_the_wealth.Value = 0;
            blade_pact.Value = 0;
            shadowshot.Value = 0;
            bane_breath.Value = 0;
            repulsion_hex.Value = 0;
            stone_pact.Value = 0;
            shadowmantle.Value = 0;
            shadowling_brute.Value = 0;
            master_os_the_elements.Value = 0;
            shadowling_ammo.Value = 0;
            death_ritual.Value = 0;
        } 

        private void Outlander_stats_ValueChanged(object sender, EventArgs e) 
        {
            outl.strength = (int)o_StrengthUD.Value;
            outl.dexterity = (int)o_DexterityUD.Value;
            outl.focus = (int)o_FocusUD.Value;
            outl.vitality = (int)o_VitalityUD.Value;
            Outlander_calcpoints(sender, e);
        }

        private void Outlander_skills_ValueChanged(object sender, EventArgs e)
        {
            outl.rapid_fire_lvl = (int)rapid_fire.Value;
			outl.rune_vault_lvl = (int)rune_vault.Value;
			outl.chaos_burst_lvl = (int)chaos_burst.Value;
			outl.cursed_daggers_lvl = (int)cursed_daggers.Value;
			outl.vortex_hex_lvl = (int)vortex_hex.Value;
			outl.shattering_glaive_lvl = (int)shattering_glaive.Value;
			outl.venomous_hail_lvl = (int)venomous_hail.Value;
			outl.long_range_mastery_lvl = (int)long_rage_mastery.Value;
			outl.shotgonne_mastery_lvl = (int)shotgonne_mastery.Value;
			outl.akimbo_lvl = (int)akimbo.Value;
			outl.glaive_throw_lvl = (int)glaive_throw.Value;
			outl.tangling_shot_lvl = (int)tangling_shot.Value;
			outl.glaive_sweep_lvl = (int)glaive_sweep.Value;
			outl.sandstorm_lvl = (int)sandstorm.Value;
			outl.bramble_wall_lvl = (int)bramble_wall.Value;
			outl.burning_leap_lvl = (int)burning_leap.Value;
			outl.flaming_glaives_lvl = (int)flaming_glaive.Value;
			outl.dodge_mastery_lvl = (int)dodge_mastery.Value;
			outl.poison_burst_lvl = (int)poison_burst.Value;
			outl.share_the_wealth_lvl = (int)share_the_wealth.Value;
			outl.blade_pact_lvl = (int)blade_pact.Value;
			outl.shadowshot_lvl = (int)shadowshot.Value;
			outl.bane_breath_lvl = (int)bane_breath.Value;
			outl.repulsion_hex_lvl = (int)repulsion_hex.Value;
			outl.stone_pact_lvl = (int)stone_pact.Value;
			outl.shadowmantle_lvl = (int)shadowmantle.Value;
			outl.shadowling_brute_lvl = (int)shadowling_brute.Value;
			outl.master_of_the_elements_lvl = (int)master_os_the_elements.Value;
			outl.shadowling_ammo_lvl = (int)shadowling_ammo.Value;
            outl.death_ritual_lvl = (int)death_ritual.Value;
            Outlander_calcpoints(sender, e);
            Outlander_req_lvl();
        }

        private void Berserker_reset_stats_Click(object sender, EventArgs e)
        {

        }

        private void Berserker_reset_skills_Click(object sender, EventArgs e)
        {

        }

        private void Berserker_stats_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Berserker_skills_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Engineer_reset_stats_Click(object sender, EventArgs e)
        {

        }

        private void Engineer_reset_skills_Click(object sender, EventArgs e)
        {

        }

        private void Engineer_stats_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Engineer_skills_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
