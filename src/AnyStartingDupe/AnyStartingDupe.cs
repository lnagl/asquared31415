using Harmony;

namespace AnyStartingDupe
{
    [HarmonyPatch(typeof(MinionStartingStats), MethodType.Constructor, typeof(bool), typeof(string))]
    public class AnyStartingDupe
    {
        public static void Prefix(ref bool is_starter_minion) { is_starter_minion = false; }
    }
}
