using System;
using System.Collections.Generic;
using System.Linq;
using Character_Builder.Data;
using Character_Builder.Models;
using Character_Builder.Utils;

namespace Character_Builder.Internal
{
    public abstract class RaceStrategy
    {
        public abstract void ApplyAttribute(CharacterAttributesModel characterAttributes);
        //public abstract void ApplyLanguage();
        //public abstract void ApplySpell();
        public abstract void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies);
        public abstract List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context);
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

        public override List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureIDList(context, CharacterRaceEnumModel.Dragonborn.ToString());
        }
    }

    public class DwarfRace : RaceStrategy
    {
        public override void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Constitution, true, 2);
        }

        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> characterProficiencies)
        { }

        public override List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureIDList(context, CharacterRaceEnumModel.Dwarf.ToString());
        }
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

        public override List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureIDList(context, CharacterRaceEnumModel.Elf.ToString());
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

        public override List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureIDList(context, CharacterRaceEnumModel.Gnome.ToString());
        }
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

        public override List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureIDList(context, CharacterRaceEnumModel.Half_Elf.ToString());
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

        public override List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureIDList(context, CharacterRaceEnumModel.Half_Orc.ToString());
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

        public override List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureIDList(context, CharacterRaceEnumModel.Halfling.ToString());
        }
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

        public override List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureIDList(context, CharacterRaceEnumModel.Human.ToString());
        }
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

        public override List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureIDList(context, CharacterRaceEnumModel.Tiefling.ToString());
        }
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

        public List<CharacterFeatureModel> GetRaceFeatureIDList(ApplicationDbContext context)
        {
            return _raceStrategy.GetRaceFeatureIDList(context);
        }
    }

    #region Character_Race_Helper
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

        public static List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context, string raceName)
        {
            var race_feature_ID_list = new List<CharacterFeatureModel>();

            var race_entity = context.Races.Where(x => x.Name == raceName).SelectMany(x => x.RaceFeatures);

            foreach (var item in race_entity)
            {
                var tmp_feature_model = new CharacterFeatureModel
                {
                    FeatureType = FeatureTypes.Race,
                    ID = item.Id
                };

                race_feature_ID_list.Add(tmp_feature_model);
            }

            return race_feature_ID_list;
        }
    }
    #endregion
}
