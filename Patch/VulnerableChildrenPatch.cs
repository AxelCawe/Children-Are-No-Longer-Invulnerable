using Children_Are_No_Longer_Invulnerable.Helper;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.MountAndBlade;

namespace Children_Are_No_Longer_Invulnerable.Patch
{
    [HarmonyPatch(typeof(Agent), "EquipItemsFromSpawnEquipment", typeof(bool))]
    public static class Agent_EquipItemFromSpawnEquipmentPatch
    {
        [HarmonyPostfix]
        public static void Postfix(Agent __instance)
        {
            if (__instance.IsHuman && __instance.Age < 18f)
                HelperExtension.DisableInvulnerability(__instance);
        }
    }
}
