using Character_Builder.Models;
using Character_Builder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public class RaceMethod
    {
        private IRace _raceStrategy;

        public void SetRaceWithName(string raceName)
        {
            var race_enum = EnumUtils.ParseEnum<RaceEnumModel>(raceName);
            SetRace(race_enum);
        }

        public void SetRace(RaceEnumModel raceEnum)
        {
            switch (raceEnum)
            {
                case RaceEnumModel.Dragonborn:
                    _raceStrategy = new DragornbornRace();
                    break;
                case RaceEnumModel.Dwarf:
                    _raceStrategy = new DwarfRace();
                    break;
                case RaceEnumModel.Elf:
                    _raceStrategy = new ElfRace();
                    break;
                case RaceEnumModel.Gnome:
                    _raceStrategy = new GnomeRace();
                    break;
                case RaceEnumModel.Half_Elf:
                    _raceStrategy = new HalfElfRace();
                    break;
                case RaceEnumModel.Half_Orc:
                    _raceStrategy = new HalfOrcRace();
                    break;
                case RaceEnumModel.Halfling:
                    _raceStrategy = new HalflingRace();
                    break;
                case RaceEnumModel.Human:
                    _raceStrategy = new HumanRace();
                    break;
                case RaceEnumModel.Tiefling:
                    _raceStrategy = new TieflingRace();
                    break;
                case RaceEnumModel.NONE:
                default:
                    new NotImplementedException();
                    break;
            }
        }

        public void ApplyRace(List<ProficiencyEnumModel> proficiencyList,
            CharacterAttributesModel attributeList)
        {
            _raceStrategy.ApplyProficiency(proficiencyList);
            _raceStrategy.ApplyAttribute(attributeList);
        }

        public List<FeatureModel> GetFeatureList(Data.ApplicationDbContext context)
        {
            return _raceStrategy.GetFeatureList(context);
        }
    }
}
