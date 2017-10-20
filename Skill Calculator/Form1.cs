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
            Berserker_req_lvl();
            Engineer_req_lvl();

            toolTip1.SetToolTip(TEST, ber.wolfpack_text);
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
            obp_lvl.Text = outl.blade_pact_reqlevel[outl.blade_pact_lvl];
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
        }

        public void Berserker_req_lvl()
        {
            bev_lvl.Text = ber.eviscerate_reqlevel[ber.eviscerate_lvl];
            bh_lvl.Text = ber.howl_reqlevel[ber.howl_lvl];
            braze_lvl.Text = ber.raze_reqlevel[ber.raze_lvl];
            bw_lvl.Text = ber.wolfstrike_reqlevel[ber.wolfstrike_lvl];
            bbr_lvl.Text = ber.battle_rage_reqlevel[ber.battle_rage_lvl];
            brup_lvl.Text = ber.rupture_reqlevel[ber.rupture_lvl];
            brav_lvl.Text = ber.ravage_reqlevel[ber.ravage_lvl];
            bbh_lvl.Text = ber.blood_hunger_reqlevel[ber.blood_hunger_lvl];
            bex_lvl.Text = ber.executioner_reqlevel[ber.executioner_lvl];
            bram_lvl.Text = ber.rampage_reqlevel[ber.rampage_lvl];
            bfb_lvl.Text = ber.frost_breath_reqlevel[ber.frost_breath_lvl];
            bst_lvl.Text = ber.stormclaw_reqlevel[ber.stormclaw_lvl];
            bsh_lvl.Text = ber.storm_hatchet_reqlevel[ber.storm_hatchet_lvl];
            bnr_lvl.Text = ber.northern_rage_reqlevel[ber.northern_rage_lvl];
            bis_lvl.Text = ber.ice_shield_reqlevel[ber.ice_shield_lvl];
            bpf_lvl.Text = ber.permafrost_reqlevel[ber.permafrost_lvl];
            bgs_lvl.Text = ber.glacial_shatter_reqlevel[ber.glacial_shatter_lvl];
            bcsm_lvl.Text = ber.cold_steel_mastery_reqlevel[ber.cold_steel_mastery_lvl];
            bss_lvl.Text = ber.shatter_storm_reqlevel[ber.shatter_storm_lvl];
            brr_lvl.Text = ber.rage_retaliation_reqlevel[ber.rage_retaliation_lvl];
            bsb_lvl.Text = ber.shadow_burst_reqlevel[ber.shadow_burst_lvl];
            bws_lvl.Text = ber.wolf_shade_reqlevel[ber.wolf_shade_lvl];
            bshad_lvl.Text = ber.shadowbind_reqlevel[ber.shadowbind_lvl];
            bsr_lvl.Text = ber.savage_rush_reqlevel[ber.savage_rush_lvl];
            bcs_lvl.Text = ber.chain_snare_reqlevel[ber.chain_snare_lvl];
            bbs_lvl.Text = ber.battle_standard_reqlevel[ber.battle_standard_lvl];
            bwp_lvl.Text = ber.wolfpack_reqlevel[ber.wolfpack_lvl];
            bfm_lvl.Text = ber.frenzy_mastery_reqlevel[ber.frenzy_mastery_lvl];
            bsa_lvl.Text = ber.shred_armor_reqlevel[ber.shred_armor_lvl];
            brw_lvl.Text = ber.red_wolf_reqlevel[ber.red_wolf_lvl];
        }

        public void Berserker_tooltips()
        {
            ber.tooltips_text();

            toolTip1.SetToolTip(bev_panel, ber.eviscerate_text);
            toolTip1.SetToolTip(bh_panel, ber.howl_text);
            toolTip1.SetToolTip(braze_panel, ber.raze_text);
            toolTip1.SetToolTip(bw_panel, ber.wolfstrike_text);
            toolTip1.SetToolTip(bbr_panel, ber.battle_rage_text);
            toolTip1.SetToolTip(brup_panel, ber.rupture_text);
            toolTip1.SetToolTip(brav_panel, ber.ravage_text);
            toolTip1.SetToolTip(bbh_panel, ber.blood_hunger_text);
            toolTip1.SetToolTip(bex_panel, ber.executioner_text);
            toolTip1.SetToolTip(bram_panel, ber.rampage_text);
            toolTip1.SetToolTip(bfb_panel, ber.frost_breath_text);
            toolTip1.SetToolTip(bst_panel, ber.stormclaw_text);
            toolTip1.SetToolTip(bsh_panel, ber.storm_hatchet_text);
            toolTip1.SetToolTip(bnr_panel, ber.northern_rage_text);
            toolTip1.SetToolTip(bis_panel, ber.ice_shield_text);
            toolTip1.SetToolTip(bpf_panel, ber.permafrost_text);
            toolTip1.SetToolTip(bgs_panel, ber.glacial_shatter_text);
            toolTip1.SetToolTip(bcsm_panel, ber.cold_steel_mastery_text);
            toolTip1.SetToolTip(bss_panel, ber.shatter_storm_text);
            toolTip1.SetToolTip(brr_panel, ber.rage_retaliation_text);
            toolTip1.SetToolTip(bsb_panel, ber.shadow_burst_text);
            toolTip1.SetToolTip(bws_panel, ber.wolf_shade_text);
            toolTip1.SetToolTip(bshad_panel, ber.shadowbind_text);
            toolTip1.SetToolTip(bsr_panel, ber.savage_rush_text);
            toolTip1.SetToolTip(bcs_panel, ber.chain_snare_text);
            toolTip1.SetToolTip(bbs_panel, ber.battle_standard_text);
            toolTip1.SetToolTip(bwp_panel, ber.wolfpack_text);
            toolTip1.SetToolTip(bfm_panel, ber.frenzy_mastery_text);
            toolTip1.SetToolTip(bsa_panel, ber.shred_armor_text);
            toolTip1.SetToolTip(brw_panel, ber.red_wolf_text);
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
            Engineer_tooltips();
        }

        public void Engineer_req_lvl()
        {
            efh_lvl.Text = eng.flame_hammer_reqlevel[eng.flame_hammer_lvl];
            ess_lvl.Text = eng.seismic_slam_reqlevel[eng.seismic_slam_lvl];
            eeh_lvl.Text = eng.ember_hammer_reqlevel[eng.ember_hammer_lvl];
            eo_lvl.Text = eng.onslaught_reqlevel[eng.onslaught_lvl];
            eer_lvl.Text = eng.ember_reach_reqlevel[eng.ember_reach_lvl];
            esb_lvl.Text = eng.storm_burst_reqlevel[eng.storm_burst_lvl];
            ee_lvl.Text = eng.emberquake_reqlevel[eng.emberquake_lvl];
            ehl_lvl.Text = eng.heavy_lifting_reqlevel[eng.heavy_lifting_lvl];
            es_lvl.Text = eng.supercharge_reqlevel[eng.supercharge_lvl];
            ecdg_lvl.Text = eng.coup_de_grace_reqlevel[eng.coup_de_grace_lvl];
            ehb_lvl.Text = eng.healing_bot_reqlevel[eng.healing_bot_lvl];
            ebc_lvl.Text = eng.blast_cannon_reqlevel[eng.blast_cannon_lvl];
            esm_lvl.Text = eng.spider_mines_reqlevel[eng.spider_mines_lvl];
            egb_lvl.Text = eng.gun_bot_reqlevel[eng.gun_bot_lvl];
            esg_lvl.Text = eng.shock_grenade_reqlevel[eng.shock_grenade_lvl];
            ef_lvl.Text = eng.fusillade_reqlevel[eng.fusillade_lvl];
            esbot_lvl.Text = eng.sledgebot_reqlevel[eng.sledgebot_lvl];
            ebw_lvl.Text = eng.bulwark_reqlevel[eng.bulwark_lvl];
            efas_lvl.Text = eng.fire_and_spark_reqlevel[eng.fire_and_spark_lvl];
            ecd_lvl.Text = eng.charge_domination_reqlevel[eng.charge_domination_lvl];
            eshb_lvl.Text = eng.shield_bash_reqlevel[eng.shield_bash_lvl];
            eff_lvl.Text = eng.forcefield_reqlevel[eng.forcefield_lvl];
            eol_lvl.Text = eng.overload_reqlevel[eng.overload_lvl];
            edf_lvl.Text = eng.dynamo_field_reqlevel[eng.dynamo_field_lvl];
            et_lvl.Text = eng.tremor_reqlevel[eng.tremor_lvl];
            efb_lvl.Text = eng.fire_bash_reqlevel[eng.fire_bash_lvl];
            eic_lvl.Text = eng.immobilization_copter_reqlevel[eng.immobilization_copter_lvl];
            esab_lvl.Text = eng.sword_and_board_reqlevel[eng.sword_and_board_lvl];
            eaof_lvl.Text = eng.aegis_of_fate_reqlevel[eng.aegis_of_fate_lvl];
            ecr_lvl.Text = eng.charge_reconstitution_reqlevel[eng.charge_reconstitution_lvl];
        }

        public void Engineer_tooltips()
        {
            eng.tooltips_text();

            toolTip1.SetToolTip(efh_panel, eng.flame_hammer_text);
            toolTip1.SetToolTip(ess_panel, eng.seismic_slam_text);
            toolTip1.SetToolTip(eeh_panel, eng.ember_hammer_text);
            toolTip1.SetToolTip(eo_panel, eng.onslaught_text);
            toolTip1.SetToolTip(eer_panel, eng.ember_reach_text);
            toolTip1.SetToolTip(esb_panel, eng.storm_burst_text);
            toolTip1.SetToolTip(ee_panel, eng.emberquake_text);
            toolTip1.SetToolTip(ehl_panel, eng.heavy_lifting_text);
            toolTip1.SetToolTip(es_panel, eng.supercharge_text);
            toolTip1.SetToolTip(ecdg_panel, eng.coup_de_grace_text);
            toolTip1.SetToolTip(ehb_panel, eng.healing_bot_text);
            toolTip1.SetToolTip(ebc_panel, eng.blast_cannon_text);
            toolTip1.SetToolTip(esm_panel, eng.spider_mines_text);
            toolTip1.SetToolTip(egb_panel, eng.gun_bot_text);
            toolTip1.SetToolTip(esg_panel, eng.shock_grenade_text);
            toolTip1.SetToolTip(ef_panel, eng.fusillade_text);
            toolTip1.SetToolTip(esbot_panel, eng.sledgebot_text);
            toolTip1.SetToolTip(ebw_panel, eng.bulwark_text);
            toolTip1.SetToolTip(efas_panel, eng.fire_and_spark_text);
            toolTip1.SetToolTip(ecd_panel, eng.charge_domination_text);
            toolTip1.SetToolTip(eshb_panel, eng.shield_bash_text);
            toolTip1.SetToolTip(eff_panel, eng.forcefield_text);
            toolTip1.SetToolTip(eol_panel, eng.overload_text);
            toolTip1.SetToolTip(edf_panel, eng.dynamo_field_text);
            toolTip1.SetToolTip(et_panel, eng.tremor_text);
            toolTip1.SetToolTip(efb_panel, eng.fire_bash_text);
            toolTip1.SetToolTip(eic_panel, eng.immobilization_copter_text);
            toolTip1.SetToolTip(esab_panel, eng.sword_and_board_text);
            toolTip1.SetToolTip(eaof_panel, eng.aegis_of_fate_text);
            toolTip1.SetToolTip(ecr_panel, eng.charge_reconstitution_text);
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font f = new Font("Arial", 9.0f);
            Color c = Color.Lime;

            if (tabControl1.SelectedTab == tabPage1) c = Color.Crimson;
            if (tabControl1.SelectedTab == tabPage2) c = Color.Goldenrod;
            if (tabControl1.SelectedTab == tabPage3) c = Color.DeepSkyBlue;
            if (tabControl1.SelectedTab == tabPage4) c = Color.LightSeaGreen;            
            Pen pen = new Pen(c, 3); //Color.Maroon
            e.DrawBackground();            
            //e.DrawBorder();
            e.Graphics.DrawLines(pen, new Point[] {new Point (0, e.Bounds.Height + 1), new Point (0, 0),new Point (e.Bounds.Width + 1, 0)});
            e.Graphics.DrawLines(pen, new Point[] {new Point (0, e.Bounds.Height - 1), new Point (e.Bounds.Width - 1, e.Bounds.Height - 1),new Point (e.Bounds.Width - 1, 0)});
            //e.Graphics.DrawRectangle(pen, e.Bounds);
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
            b_StrengthUD.Value = 15;
            b_DexterityUD.Value = 15;
            b_FocusUD.Value = 5;
            b_VitalityUD.Value = 5;
        } 

        private void Berserker_reset_skills_Click(object sender, EventArgs e)
        {
            eviscerate.Value = 0;
            howl.Value = 0;
            raze.Value = 0;
            wolfstrike.Value = 0;
            battle_rage.Value = 0;
            rupture.Value = 0;
            ravage.Value = 0;
            blood_hunger.Value = 0;
            executioner.Value = 0;
            rampage.Value = 0;
            frost_breath.Value = 0;
            stormclaw.Value = 0;
            storm_hatchet.Value = 0;
            northern_rage.Value = 0;
            ice_shield.Value = 0;
            permafrost.Value = 0;
            glacial_shatter.Value = 0;
            cold_steel_mastery.Value = 0;
            shatter_storm.Value = 0;
            rage_retaliation.Value = 0;
            shadow_burst.Value = 0;
            wolf_shade.Value = 0;
            shadowbind.Value = 0;
            savage_rush.Value = 0;
            chain_snare.Value = 0;
            battle_standard.Value = 0;
            wolfpack.Value = 0;
            frenzy_mastery.Value = 0;
            shred_armor.Value = 0;
            red_wolf.Value = 0;
        } 

        private void Berserker_stats_ValueChanged(object sender, EventArgs e)
        {
            ber.strength = (int)b_StrengthUD.Value;
            ber.dexterity = (int)b_DexterityUD.Value;
            ber.focus = (int)b_FocusUD.Value;
            ber.vitality = (int)b_VitalityUD.Value;
            Berserker_calcpoints(sender, e);
        } 

        private void Berserker_skills_ValueChanged(object sender, EventArgs e)
        {
            ber.eviscerate_lvl = (int)eviscerate.Value;
            ber.howl_lvl = (int)howl.Value;
            ber.raze_lvl = (int)raze.Value;
            ber.wolfstrike_lvl = (int)wolfstrike.Value;
            ber.battle_rage_lvl = (int)battle_rage.Value;
            ber.rupture_lvl = (int)rupture.Value;
            ber.ravage_lvl = (int)ravage.Value;
            ber.blood_hunger_lvl = (int)blood_hunger.Value;
            ber.executioner_lvl = (int)executioner.Value;
            ber.rampage_lvl = (int)rampage.Value;
            ber.frost_breath_lvl = (int)frost_breath.Value;
            ber.stormclaw_lvl = (int)stormclaw.Value;
            ber.storm_hatchet_lvl = (int)storm_hatchet.Value;
            ber.northern_rage_lvl = (int)northern_rage.Value;
            ber.ice_shield_lvl = (int)ice_shield.Value;
            ber.permafrost_lvl = (int)permafrost.Value;
            ber.glacial_shatter_lvl = (int)glacial_shatter.Value;
            ber.cold_steel_mastery_lvl = (int)cold_steel_mastery.Value;
            ber.shatter_storm_lvl = (int)shatter_storm.Value;
            ber.rage_retaliation_lvl = (int)rage_retaliation.Value;
            ber.shadow_burst_lvl = (int)shadow_burst.Value;
            ber.wolf_shade_lvl = (int)wolf_shade.Value;
            ber.shadowbind_lvl = (int)shadowbind.Value;
            ber.savage_rush_lvl = (int)savage_rush.Value;
            ber.chain_snare_lvl = (int)chain_snare.Value;
            ber.battle_standard_lvl = (int)battle_standard.Value;
            ber.wolfpack_lvl = (int)wolfpack.Value;
            ber.frenzy_mastery_lvl = (int)frenzy_mastery.Value;
            ber.shred_armor_lvl = (int)shred_armor.Value;
            ber.red_wolf_lvl = (int)red_wolf.Value;
        } 

        private void Engineer_reset_stats_Click(object sender, EventArgs e)
        {
            e_StrengthUD.Value = 15;
            e_DexterityUD.Value = 5;
            e_FocusUD.Value = 5;
            e_VitalityUD.Value = 15;
        } 

        private void Engineer_reset_skills_Click(object sender, EventArgs e)
        {
            flame_hammer.Value = 0;
            seismic_slam.Value = 0;
            ember_hammer.Value = 0;
            onslaught.Value = 0;
            ember_reach.Value = 0;
            storm_burst.Value = 0;
            emberquake.Value = 0;
            heavy_lifting.Value = 0;
            supercharge.Value = 0;
            coup_de_grace.Value = 0;
            healing_bot.Value = 0;
            blast_cannon.Value = 0;
            spider_mines.Value = 0;
            gun_bot.Value = 0;
            shock_grenade.Value = 0;
            fusillade.Value = 0;
            sledgebot.Value = 0;
            bulwark.Value = 0;
            fire_and_spark.Value = 0;
            charge_domination.Value = 0;
            shield_bash.Value = 0;
            forcefield.Value = 0;
            overload.Value = 0;
            dynamo_field.Value = 0;
            tremor.Value = 0;
            fire_bash.Value = 0;
            immobilization_copter.Value = 0;
            sword_and_board.Value = 0;
            aegis_of_fate.Value = 0;
            charge_reconstitution.Value = 0;
        } 

        private void Engineer_stats_ValueChanged(object sender, EventArgs e)
        {
            eng.strength = (int)e_StrengthUD.Value;
            eng.dexterity = (int)e_DexterityUD.Value;
            eng.focus = (int)e_FocusUD.Value;
            eng.vitality = (int)e_VitalityUD.Value;
            Engineer_calcpoints(sender, e);
        } 

        private void Engineer_skills_ValueChanged(object sender, EventArgs e)
        {
            eng.flame_hammer_lvl = (int)flame_hammer.Value;
            eng.seismic_slam_lvl = (int)seismic_slam.Value;
            eng.ember_hammer_lvl = (int)ember_hammer.Value;
            eng.onslaught_lvl = (int)onslaught.Value;
            eng.ember_reach_lvl = (int)ember_reach.Value;
            eng.storm_burst_lvl = (int)storm_burst.Value;
            eng.emberquake_lvl = (int)emberquake.Value;
            eng.heavy_lifting_lvl = (int)heavy_lifting.Value;
            eng.supercharge_lvl = (int)supercharge.Value;
            eng.coup_de_grace_lvl = (int)coup_de_grace.Value;
            eng.healing_bot_lvl = (int)healing_bot.Value;
            eng.blast_cannon_lvl = (int)blast_cannon.Value;
            eng.spider_mines_lvl = (int)spider_mines.Value;
            eng.gun_bot_lvl = (int)gun_bot.Value;
            eng.shock_grenade_lvl = (int)shock_grenade.Value;
            eng.fusillade_lvl = (int)fusillade.Value;
            eng.sledgebot_lvl = (int)sledgebot.Value;
            eng.bulwark_lvl = (int)bulwark.Value;
            eng.fire_and_spark_lvl = (int)fire_and_spark.Value;
            eng.charge_domination_lvl = (int)charge_domination.Value;
            eng.shield_bash_lvl = (int)shield_bash.Value;
            eng.forcefield_lvl = (int)forcefield.Value;
            eng.overload_lvl = (int)overload.Value;
            eng.dynamo_field_lvl = (int)dynamo_field.Value;
            eng.tremor_lvl = (int)tremor.Value;
            eng.fire_bash_lvl = (int)fire_bash.Value;
            eng.immobilization_copter_lvl = (int)immobilization_copter.Value;
            eng.sword_and_board_lvl = (int)sword_and_board.Value;
            eng.aegis_of_fate_lvl = (int)aegis_of_fate.Value;
            eng.charge_reconstitution_lvl = (int)charge_reconstitution.Value;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            int THeight, TWidth = 450;
            Font f = new Font("Arial", 9.0f);
            Graphics g = CreateGraphics();
            THeight = (int)g.MeasureString(toolTip1.GetToolTip(e.AssociatedControl), f, TWidth).Height;
            e.ToolTipSize = new Size(TWidth, THeight);
        }
    }
}
