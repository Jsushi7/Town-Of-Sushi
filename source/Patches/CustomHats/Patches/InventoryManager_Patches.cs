using HarmonyLib;

namespace TownOfSushi.Patches.CustomHats.Patches
{
    [HarmonyPatch(typeof(InventoryManager), nameof(InventoryManager.CheckUnlockedItems))]
    public class InventoryManager_Patches
    {
        public static void Prefix()
        {
            HatLoader.LoadHatsRoutine();
        }
    }
}   