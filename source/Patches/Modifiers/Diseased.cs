using HarmonyLib;

namespace TownOfSushi.Modifiers
{
    public class Diseased
    {
        [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.MurderPlayer))]
        public class PlayerControl_MurderPlayer
        {
            public static void Postfix(PlayerControl __instance, [HarmonyArgument(0)] PlayerControl target)
            {
                if (target.Is(ModifierEnum.Diseased))
                    __instance.SetKillTimer(GameOptionsManager.Instance.currentNormalGameOptions.KillCooldown * CustomGameOptions.DiseasedMultiplier);
            }
        }
    }
}