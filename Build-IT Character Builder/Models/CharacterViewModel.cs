using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Build_IT_Character_Builder.Models
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
        SpiritReaver,
        FarTraveler,
        BountyHunter,
        Artisan,
        Urchin,
        Soldier,
        Sailor,
        Sage,
        Outlander,
        Noble,
        Hermit,
        GuildArtisan,
        FolkHero,
        Entertainer,
        Criminal,
        Charlatan,
        Acolyte,
        NONE
    }

    public enum CharacterRaceEnumModel
    {
        Dragonborn,
        Dwarf,
        Elf,
        Gnome,
        HalfElf,
        HalfOrc,
        Halfling,
        Human,
        Tiefling,
        NONE
    }

    public class CharacterProficiencyModel
    {
        public bool isArcana { get; set; }
        public bool isHistory { get; set; }
        public bool isInvestigation { get; set; }
        public bool isNature { get; set; }
        public bool isReligion { get; set; }
        public bool isAnimalHandling { get; set; }
        public bool isInsight { get; set; }
        public bool isMedicine { get; set; }
        public bool isPerception { get; set; }
        public bool isSurvival { get; set; }
        public bool isDeception { get; set; }
        public bool isIntimidation { get; set; }
        public bool isPerformance { get; set; }
        public bool isPersuasion { get; set; }
        public bool isAthletics { get; set; }
        public bool isAcrobatics { get; set; }
        public bool isSleightOfHand { get; set; }
        public bool isStealth { get; set; }

        public bool isInitiative { get; set; }
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
        public CharacterProficiencyModel CharacterProficiency { get; set; }
    }
}
