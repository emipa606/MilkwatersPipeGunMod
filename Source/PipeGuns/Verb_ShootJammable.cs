using RimWorld;
using UnityEngine;
using Verse;
using Verse.Sound;

namespace PipeGuns;

public class Verb_ShootJammable : Verb_Shoot
{
    private static readonly SoundDef JamSoundDef = DefDatabase<SoundDef>.GetNamed("Milkwater_Jam");

    protected override bool TryCastShot()
    {
        if (!Rand.Chance(PipeGunsMod.instance.Settings.JamChance))
        {
            return base.TryCastShot();
        }

        MoteMaker.ThrowText(CasterPawn.DrawPos, CasterPawn.Map, "PiGu.jammed".Translate(), Color.red, 3.65f);
        JamSoundDef.PlayOneShot(new TargetInfo(CasterPawn.Position, CasterPawn.Map));
        return false;
    }
}