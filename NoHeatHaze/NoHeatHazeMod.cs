using HarmonyLib;
using JetBrains.Annotations;

namespace NoHeatHaze
{
    [HarmonyPatch(typeof(HeatHaze), nameof(HeatHaze.Apply))]
    public class NoHeatHazeMod
    {
        [UsedImplicitly]
        public static bool Prefix()
        {
            return false;
        }
    }
}