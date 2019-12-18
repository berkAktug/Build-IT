using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Models
{
    public enum CharacterClassEnumModel
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard,
        NONE
    }

    public enum SpellSchoolEnumModel
    {
        abjuration,
        conjuration,
        divination,
        enchantment,
        evocation,
        illusion,
        necromancy,
        transmutation
    }

    public enum BackgroundEnumModel
    {
        Acolyte,
        Archaeologist,
        BountyHunter,
        Charlatan,
        Criminal,
        Entertainer,
        FarTraveler,
        FolkHero,
        GuildArtisan,
        Hermit,
        Noble,
        Outlander,
        Sage,
        Sailor,
        Soldier,
        StojanowPrisoner,
        Urchin,
        NONE
    }

    public enum RaceEnumModel
    {
        Dragonborn,
        Dwarf,
        Elf,
        Gnome,
        Half_Elf,
        Half_Orc,
        Halfling,
        Human,
        Tiefling,
        NONE
    }

    public enum GenderEnumModel
    {
        Male,
        Female
    }

    public enum ProficiencyEnumModel
    {
        Arcana,
        History,
        Investigation,
        Nature,
        Religion,
        AnimalHandling,
        Insight,
        Medicine,
        Perception,
        Survival,
        Deception,
        Intimidation,
        Performance,
        Persuasion,
        Athletics,
        Acrobatics,
        SleightOfHand,
        Stealth,
        Initiative
    }

    public enum FeatureTypes
    {
        CharacterClass,
        Background,
        Race
    }

}
