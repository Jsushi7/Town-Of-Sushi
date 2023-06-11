using System;
using HarmonyLib;
using TownOfRoles.Roles;
using TownOfRoles.Roles.Cultist;
using Object = UnityEngine.Object;

namespace TownOfRoles.CultistRoles.SnitchMod
{
    [HarmonyPatch(typeof(Object), nameof(Object.Destroy), typeof(Object))]
    public static class HUDClose
    {
        public static void Postfix(Object obj)
        {
            if (ExileController.Instance == null || obj != ExileController.Instance.gameObject) return;
            foreach (var role in Role.GetRoles(RoleEnum.CultistSnitch))
            {
                var Snitch = (CultistSnitch) role;
                Snitch.LastInvestigated = DateTime.UtcNow;
            }
        }
    }
}