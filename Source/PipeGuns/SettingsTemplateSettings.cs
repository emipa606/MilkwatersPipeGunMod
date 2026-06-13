using Verse;

namespace PipeGuns;

/// <summary>
///     Definition of the settings for the mod
/// </summary>
internal class PipeGunsSettings : ModSettings
{
    public float JamChance = 0.15f;

    /// <summary>
    ///     Saving and loading the values
    /// </summary>
    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref JamChance, "JamChance", 0.15f);
    }
}