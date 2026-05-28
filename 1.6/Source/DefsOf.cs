using RimWorld;

namespace ProgressionRobotics2
{
    [DefOf]
    public static class DefsOf
    {
        public static IncidentDef GiveQuest_Random;

        static DefsOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(DefsOf));
        }
    }
}
