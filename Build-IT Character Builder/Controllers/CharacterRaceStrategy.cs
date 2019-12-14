using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Character_Builder.Models;
using Character_Builder.Utils;

namespace Character_Builder.Internal
{
    public abstract class RaceStrategy
    {
        public abstract void ApplyAttribute(CharacterAttributesModel characterAttributes);
        //public abstract void ApplyRaceFeature();
        //public abstract void ApplyLanguage();
        //public abstract void ApplySpell();
        public abstract void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies);
    }

    public class DragornbornRace : RaceStrategy
    {
        public override void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Strength, true, 2);
            RaceHelper.AdjustAttribute(characterAttributes.Charisma, true, 1);
        }

        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies)
        { }
    }

    public class DwarfRace : RaceStrategy
    {
        public override void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Constitution, true, 2);
        }

        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies)
        { }
    }

    public class ElfRace : RaceStrategy
    {
        public override void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Dexterity, true, 2);
        }

        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies)
        {
            RaceHelper.AddProficiency(characterProficiencies, CharacterProficiencyEnumModel.Perception);
        }
    }

    public class GnomeRace : RaceStrategy
    {
        public override void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Intelligence, true, 2);
        }

        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies)
        { }
    }

    public class HalfElfRace : RaceStrategy
    {
        public override void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            // Temporary Solution as officially half elfs can choice their attribute bonueses.
            RaceHelper.AdjustAttribute(characterAttributes.Dexterity, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Wisdom, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Charisma, true, 2);
        }

        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies)
        {
            // Temporary Solution as officially half elfs can choice their attribute bonueses.
            RaceHelper.AddProficiency(characterProficiencies, CharacterProficiencyEnumModel.Perception);
            RaceHelper.AddProficiency(characterProficiencies, CharacterProficiencyEnumModel.Persuasion);
        }
    }

    public class HalfOrcRace : RaceStrategy
    {
        public override void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Strength, true, 2);
            RaceHelper.AdjustAttribute(characterAttributes.Constitution, true, 1);
        }

        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies)
        {
            RaceHelper.AddProficiency(characterProficiencies, CharacterProficiencyEnumModel.Intimidation);
        }
    }

    public class HalflingRace : RaceStrategy
    {
        public override void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Dexterity, true, 2);
        }

        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies)
        { }
    }

    public class HumanRace : RaceStrategy
    {
        public override void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Strength, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Dexterity, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Constitution, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Intelligence, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Wisdom, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Charisma, true, 1);
        }

        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies)
        { }
    }

    public class TieflingRace : RaceStrategy
    {
        public override void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Intelligence, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Charisma, true, 2);
        }

        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies)
        { }
    }

    public class RaceMethod
    {
        private RaceStrategy _raceStrategy;

        public void SetRaceWithName(string raceName)
        {
            var race_enum = EnumUtils.ParseEnum<CharacterRaceEnumModel>(raceName);
            SetRace(race_enum);
        }

        public void SetRace(CharacterRaceEnumModel raceEnum)
        {
            switch (raceEnum)
            {
                case CharacterRaceEnumModel.Dragonborn:
                    _raceStrategy = new DragornbornRace();
                    break;
                case CharacterRaceEnumModel.Dwarf:
                    _raceStrategy = new DwarfRace();
                    break;
                case CharacterRaceEnumModel.Elf:
                    _raceStrategy = new ElfRace();
                    break;
                case CharacterRaceEnumModel.Gnome:
                    _raceStrategy = new GnomeRace();
                    break;
                case CharacterRaceEnumModel.Half_Elf:
                    _raceStrategy = new HalfElfRace();
                    break;
                case CharacterRaceEnumModel.Half_Orc:
                    _raceStrategy = new HalfOrcRace();
                    break;
                case CharacterRaceEnumModel.Halfling:
                    _raceStrategy = new HalflingRace();
                    break;
                case CharacterRaceEnumModel.Human:
                    _raceStrategy = new HumanRace();
                    break;
                case CharacterRaceEnumModel.Tiefling:
                    _raceStrategy = new TieflingRace();
                    break;
                case CharacterRaceEnumModel.NONE:
                default:
                    new NotImplementedException();
                    break;
            }
        }

        public void ApplyRace(List<CharacterProficiencyEnumModel> proficiencyList, 
            CharacterAttributesModel attributeList)
        {
            _raceStrategy.ApplyProficiency(proficiencyList);
            _raceStrategy.ApplyAttribute(attributeList);
        }
    }

    public class RaceHelper
    {
        public static void AddProficiency(List<CharacterProficiencyEnumModel> proficiencyList,
            CharacterProficiencyEnumModel proficiency)
        {
            if(! proficiencyList.Contains(proficiency))
            {
                proficiencyList.Add(proficiency);
            }
        }
        public static void AdjustAttribute(int attribute, bool isIncrement, int modifier)
        {
            if(isIncrement)
            {
                attribute += modifier;
                if(attribute > 20)
                {
                    attribute = 20;
                }
            }
            else
            {
                attribute -= modifier;
                if (attribute < 3)
                {
                    attribute = 3;
                }
            }
        }
    }
}
