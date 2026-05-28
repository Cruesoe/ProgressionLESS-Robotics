using HarmonyLib;
using Verse;

namespace ProgressionRobotics2
{
    public class ProgressionRobotics2Mod : Mod
    {
        public ProgressionRobotics2Mod(ModContentPack pack) : base(pack)
        {
            new Harmony("ProgressionRobotics2Mod").PatchAll();
        }
    }
}