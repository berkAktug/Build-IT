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

    public enum CharacterBackgroundEnumModel
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

    public enum CharacterRaceEnumModel
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

    public enum CharacterGenderEnumModel
    {
        Male,
        Female
    }

    public enum CharacterProficiencyEnumModel
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

    public class CharacterAttributesModel
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }

    public class CharacterViewModel
    {
        public string CharacterName { get; set; }
        public CharacterClassEnumModel CharacterClass { get; set; }
        public int CharacterClassLevel { get; set; }
        public CharacterBackgroundEnumModel CharacterBackground { get; set; }
        public CharacterRaceEnumModel CharacterRace { get; set; }
        public CharacterAttributesModel CharacterAttributes { get; set; }
        public CharacterProficiencyEnumModel CharacterProficiency { get; set; }
    }

    public class SpellModel
    {
        public string Title { get; set; }
        public string ClassSpell { get; set; }
        public string SpellSchool { get; set; }
        public int Level { get; set; }
        public string Components { get; set; }
        public string Description { get; set; }
        public int CastingTime { get; set; }
    }

    public class FeatureModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class CharacterModel
    {
        public string Name { get; set; }
        public CharacterClassEnumModel CharClass { get; set; }
        public List<CharacterProficiencyEnumModel> Proficiency { get; set; }
        public CharacterAttributesModel Attributes { get; set; }
        public int Level { get; set; }
        public CharacterRaceEnumModel Race { get; set; }
        public int HitPoints { get; set; }
        public int ArmourClass { get; set; }
        public int ProficiencyBonus { get; set; }
        public List<FeatureModel> Features { get; set; }
        public List<SpellModel> Spells { get; set; }
    }

    public class NewCharacterModel
    {
        public string CharacterName { get; set; }
        public int CharacterLevel { get; set; }
        public CharacterClassEnumModel CharacterClass { get; set; }
        public CharacterBackgroundEnumModel CharacterBackground { get; set; }
        public CharacterRaceEnumModel CharacterRace { get; set; }
        public List<CharacterProficiencyEnumModel> CharacterProficiencies { get; set; }
        public CharacterAttributesModel CharacterAttributes { get; set; }
    }

    public class InsertCharacterModel
    {
        public string CharacterName { get; set; }
        public string CharacterClassName { get; set; }
        public string CharacterGender { get; set; }
        //public int    CharacterLevel { get; set; }
        public string CharacterBackground { get; set; }
        public string CharacterRace { get; set; }
        public List<string> CharacterProficiencies { get; set; }
        public CharacterAttributesModel CharacterAttributes { get; set; }
    }
}
