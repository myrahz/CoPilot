﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoPilot
{
    internal static class SkillInfo
    {
        private static DateTime lastUpdate = DateTime.MinValue;
        internal static Skill enduringCry = new Skill();
        internal static Skill rallyingCry = new Skill();
        internal static Skill boneOffering = new Skill();
        internal static Skill spiritOffering = new Skill();
        internal static Skill fleshOffering = new Skill();
        internal static Skill phaserun = new Skill();
        internal static Skill moltenShell = new Skill();
        internal static Skill steelSkin = new Skill();
        internal static Skill boneArmour = new Skill();
        internal static Skill arcaneCloak = new Skill();
        internal static Skill bloodRage = new Skill();
        internal static Skill chaosGolem = new Skill();
        internal static Skill flameGolem = new Skill();
        internal static Skill iceGolem = new Skill();
        internal static Skill lightningGolem = new Skill();
        internal static Skill stoneGolem = new Skill();
        internal static Skill carrionGolem = new Skill();
        internal static Skill ursaGolem = new Skill();
        internal static Skill vortex = new Skill();
        internal static Skill divineIre = new Skill();
        internal static Skill scourgeArror = new Skill();
        internal static Skill bladeFlurry = new Skill();
        internal static Skill doedreEffigy = new Skill();
        internal static Skill tempestShield = new Skill();
        internal static Skill brandRecall = new Skill();
        internal static Skill cyclone = new Skill();
        internal static Skill iceNova = new Skill();
		internal static Skill smokeMine = new Skill();
        internal static Skill flameDash = new Skill();



        internal static void UpdateSkillInfo()
        {
            if ((DateTime.Now - lastUpdate).TotalMilliseconds < 10000)
                return;
            lastUpdate = DateTime.Now;
            foreach (var skill in CoPilot.instance.skills)
            {
                if (!skill.IsOnSkillBar)
                    continue;
                if(skill.InternalName == "enduring_cry")
                {
                    enduringCry.Id = skill.Id;
                }
                else if (skill.InternalName == "inspiring_cry")
                {
                    rallyingCry.Id = skill.Id;
                    rallyingCry.BuffName = "inspiring_cry";
                }
                else if (skill.InternalName == "bone_offering")
                {
                    boneOffering.Id = skill.Id;
                    boneOffering.BuffName = "active_offering";
                }
                else if (skill.InternalName == "spirit_offering")
                {
                    spiritOffering.Id = skill.Id;
                    spiritOffering.BuffName = "active_offering";
                }
                else if (skill.InternalName == "flesh_offering")
                {
                    fleshOffering.Id = skill.Id;
                    fleshOffering.BuffName = "active_offering";
                }
                else if (skill.InternalName == "new_phase_run")
                {
                    phaserun.Id = skill.Id;
                    phaserun.BuffName = "new_phase_run";
                }
                else if (skill.InternalName == "molten_shell_barrier")
                {
                    moltenShell.Id = skill.Id;
                    moltenShell.BuffName = "fire_shield";
                }
                else if (skill.InternalName == "steelskin")
                {
                    steelSkin.Id = skill.Id;
                    steelSkin.BuffName = "quick_guard";
                }
                else if (skill.InternalName == "bone_armour")
                {
                    boneArmour.Id = skill.Id;
                    boneArmour.BuffName = "bone_armour";
                }
                else if (skill.InternalName == "arcane_cloak")
                {
                    arcaneCloak.Id = skill.Id;
                    arcaneCloak.BuffName = "arcane_cloak";
                }
                else if (skill.InternalName == "blood_rage")
                {
                    bloodRage.Id = skill.Id;
                    bloodRage.BuffName = "blood_rage";
                }
                else if (skill.InternalName == "summon_chaos_elemental")
                {
                    chaosGolem.Id = skill.Id;
                }
                else if (skill.InternalName == "summon_fire_elemental")
                {
                    flameGolem.Id = skill.Id;
                }
                else if (skill.InternalName == "summon_ice_elemental")
                {
                    iceGolem.Id = skill.Id;
                }
                else if (skill.InternalName == "summon_lightning_golem")
                {
                    lightningGolem.Id = skill.Id;
                }
                else if (skill.InternalName == "summon_rock_golem")
                {
                    stoneGolem.Id = skill.Id;
                }
                else if (skill.InternalName == "summon_bone_golem")
                {
                    carrionGolem.Id = skill.Id;
                }
                else if (skill.InternalName == "summon_beastial_ursa")
                {
                    ursaGolem.Id = skill.Id;
                }
                else if (skill.InternalName == "frost_bolt_nova")
                {
                    vortex.Id = skill.Id;
                }
                else if (skill.InternalName == "divine_tempest")
                {
                    divineIre.Id = skill.Id;
                    divineIre.BuffName = "divine_tempest_stage";
                }
                else if (skill.InternalName == "virulent_arrow")
                {
                    scourgeArror.Id = skill.Id;
                    scourgeArror.BuffName = "virulent_arrow_counter";
                }
                else if (skill.InternalName == "charged_attack_channel")
                {
                    bladeFlurry.Id = skill.Id;
                    bladeFlurry.BuffName = "charged_attack";
                }
                else if (skill.InternalName == "curse_pillar")
                {
                    doedreEffigy.Id = skill.Id;
                }
                else if (skill.InternalName == "tempest_shield")
                {
                    tempestShield.Id = skill.Id;
                    tempestShield.BuffName = "lightning_shield";
                }
                else if (skill.InternalName == "sigil_recall")
                {
                    brandRecall.Id = skill.Id;
                }
                else if (skill.InternalName == "cyclone_channelled")
                {
                    cyclone.Id = skill.Id;
                }
                else if (skill.InternalName == "ice_nova")
                {
                    iceNova.Id = skill.Id;
                } 
				else if (skill.InternalName == "smoke_mine")
                {
                    smokeMine.Id = skill.Id;
                }
                else if (skill.InternalName == "flame_dash")
                {
                    flameDash.Id = skill.Id;
                }
            }
        }
    }
}
