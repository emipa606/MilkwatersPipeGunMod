# GitHub Copilot Instructions for Milkwater's Pipe Gun Mod (Continued)

Welcome to the GitHub Copilot instructions for the Milkwater's Pipe Gun Mod (Continued). This mod adds four new pipe guns to the game, which are cheaper and have a 15% chance to jam. The mod also includes mod settings to adjust the jam chance.

## Mod Overview and Purpose

The Milkwater's Pipe Gun Mod (Continued) adds four new pipe guns to the game. These guns are cheaper and have a 15% chance to jam, which can make them unreliable for continued use. The mod also includes mod settings to adjust the jam chance.

## Key Features and Systems

The mod adds four new pipe guns to the game:

* Pipe Revolver
* Pipe Pistol
* Pipe Rifle
* Pipe LMG
* Pipe Shotgun

Each of these guns is based on a vanilla gun, with the same stats but with a 15% chance to jam. The only mechanically different weapon is the pipe LMG, which has a bayonet for stab damage.

## Coding Patterns and Conventions

The mod is written in C# and XML. The code follows the standard RimWorld coding patterns and conventions. The mod includes three C# files and four XML files.

## XML Integration

The mod includes four XML files, which define the new pipe guns and their stats. The XML files are located in the `Defs` folder of the mod. The `SoundDefs.xml` file defines the sounds for the new pipe guns, while the `Weapons_Ranged.xml` file defines the stats for the new pipe guns.

## Harmony Patching

The mod uses Harmony patching to modify the vanilla game code. The `Verb_ShootJammable.cs` file defines the `Verb_ShootJammable` class, which is used to add the jam chance to the pipe guns. The `SettingsTemplateSettings.cs` and `SettingsTemplateMod.cs` files define the mod settings and the UI for the mod settings.

## Suggestions for Copilot

* When working with XML files, use the `Defs` folder as a reference to find the correct XML structure.
* When working with Harmony patching, use the `Harmony` library as a reference to find the correct patching methods.
* When working with mod settings, use the `ModSettings` class as a reference to find the correct methods for exposing data and saving settings.

Feel free to use GitHub Copilot to help you with your coding tasks. If you have any questions or suggestions, please leave a comment and I will read it!

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
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

