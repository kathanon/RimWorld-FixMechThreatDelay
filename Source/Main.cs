using HarmonyLib;
using Verse;

namespace FixMechThreatDelay {
    [StaticConstructorOnStartup]
    public class Main {
        static Main() {
            var harmony = new Harmony("kathanon.FixMechThreatDelay");
            harmony.PatchAll();
        }
    }
}
