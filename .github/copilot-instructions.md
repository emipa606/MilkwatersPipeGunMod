# Copilot Instructions for Milkwater's Pipe Gun Mod (Continued)

## Mod Overview and Purpose

Milkwater's Pipe Gun Mod (Continued) enhances the gameplay of RimWorld by introducing a series of low-cost, makeshift firearms known as pipe guns. Adapted from the popular Fallout series, these weapons offer players affordable alternatives to their standard counterparts, perfect for single-use scenarios or when resources are limited. The mod provides a fresh crafting experience and motivates players to engage more actively in weapon production, especially since these guns are prone to jamming, adding a layer of strategic decision-making.

## Key Features and Systems

- **New Weapons**: The mod introduces four types of pipe guns:
  - **Pipe Revolver**: Crafted with 15 steel and 1 component.
  - **Pipe Pistol**: Crafted with 15 steel and 1 component.
  - **Pipe Rifle**: Crafted with 30 steel and 2 components.
  - **Pipe LMG**: Crafted with 50 steel and 4 components, featuring a bayonet for stab damage.
  - **Pipe Shotgun**: Newly added, crafted with 30 steel and 2 components.

- **Jamming Mechanic**: All pipe guns have a 15% chance to jam. This mechanic simulates the use of lower-quality materials and provides a gameplay balance by matching vanilla weapons at a reduced reliability.

- **Crafting and Availability**: These weapons are integrated into the normal research tree. Raiders may also use them, providing additional opportunities for acquisition.

## Coding Patterns and Conventions

- **C# Practices**: Utilize `Verb_ShootJammable` for implementing the jamming mechanic in firearms. Ensure code is modular and adhere to SOLID principles:
  - **Single Responsibility**: `Verb_ShootJammable` should only handle the shooting and jamming logic.
  - **Open/Closed**: Make classes extensible for future enhancements.

- **XML File Structure**: Organized into logical segments:
  - `SoundDefs.xml` for sound definitions.
  - `Weapons_Ranged.xml` for weapon configs.
  - `About.xml` for mod metadata.
  
- **Naming Conventions**: Use `PascalCase` for public members and `camelCase` for local variables and parameters within methods.

## XML Integration

- Define new weapons in `Weapons_Ranged.xml`:
  xml
  <ThingDef ParentName="BaseGun">
    <defName>PipeRevolver</defName>
    <!-- Additional properties -->
  </ThingDef>
  

- Integrate sound effects via `SoundDefs.xml`:
  xml
  <SoundDef>
    <defName>PipeGun_Fire</defName>
    <!-- Sound properties -->
  </SoundDef>
  

- Ensure all XML elements are properly matched to avoid parsing errors.

## Harmony Patching

- Use Harmony for runtime adjustments without altering original game code:
  csharp
  [HarmonyPatch(typeof(Verb_Shoot))]
  [HarmonyPatch("TryCastShot")]
  class Patch_Verb_Shoot_TryCastShot
  {
      static void Prefix()
      {
          // Custom jamming logic
      }
  }
  

- Always ensure patches are non-destructive and reversible.

## Suggestions for Copilot

- Automate JSON-to-XML conversion for weapon attributes.
- Use data-driven approach to add new weapons by creating weapon templates in XML.
- Implement methods or extensions in C# (e.g., utility method for jamming probability).
- Create code snippets for repetitive XML patterns, such as `ThingDef` entries.
- Suggest potential improvements for upcoming mod settings feature to customize jamming chances.

By adhering to these guidelines and patterns, you can ensure the development of Milkwater's Pipe Gun Mod continues to be robust, flexible, and easily maintainable.


This Copilot instruction file provides a comprehensive guideline for anyone looking to contribute to or understand the functionality and development patterns of Milkwater's Pipe Gun Mod (Continued). It lays the groundwork for a consistent and effective modding workflow.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).

