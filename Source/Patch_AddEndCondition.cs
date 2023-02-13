using HarmonyLib;
using RimWorld;
using Verse.AI.Group;

namespace FixMechThreatDelay;
[HarmonyPatch]
public static class Patch_AddEndCondition {
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LordToil), MethodType.Constructor)]
    public static void Constructor(LordToil __instance) {
        if (__instance is LordToil_ExitMap 
                || __instance is LordToil_EnterShuttleOrLeave
                || __instance.GetType().Name.StartsWith("LordToil_ExitMap")) {
            __instance.AddFailCondition(() => __instance.lord.ownedPawns.Count == 0);
        }
    }
}
