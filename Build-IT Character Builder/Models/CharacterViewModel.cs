using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Models
{

    public class CharacterFeatureIdModel
    {
        public FeatureTypes FeatureType { get; set; }
        public int ID { get; set; }
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
        public BackgroundEnumModel CharacterBackground { get; set; }
        public RaceEnumModel CharacterRace { get; set; }
        public CharacterAttributesModel CharacterAttributes { get; set; }
        public ProficiencyEnumModel CharacterProficiency { get; set; }
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
        public FeatureTypes FeatureType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? LevelRequirement { get; set; }
    }

    public class CharacterModel
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public CharacterClassEnumModel CharacterClass { get; set; }
        public List<ProficiencyEnumModel> Proficiencies { get; set; }
        public CharacterAttributesModel Attributes { get; set; }
        public RaceEnumModel Race { get; set; }
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
        public BackgroundEnumModel CharacterBackground { get; set; }
        public RaceEnumModel CharacterRace { get; set; }
        public List<ProficiencyEnumModel> CharacterProficiencies { get; set; }
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

    public class NewCharacterViewModel
    {
        public string CharacterName { get; set; }
        public string CharacterClassName { get; set; }
        public string CharacterGender { get; set; }
        public int CharacterLevel { get; set; }
        public string CharacterBackground { get; set; }
        public string CharacterRace { get; set; }
        public List<string> CharacterProficiencies { get; set; }
        public List<int> CharacterAttributes { get; set; }
    }
}
