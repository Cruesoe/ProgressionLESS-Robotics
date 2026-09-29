using HarmonyLib;
using Verse;

namespace ProgressionLESSRobotics
{
    public class ProgressionLESSRoboticsMod : Mod
    {
        public ProgressionLESSRoboticsMod(ModContentPack pack) : base(pack)
        {
            new Harmony("cruesoe.progressionlessrobotics").PatchAll();
        }
    }
}