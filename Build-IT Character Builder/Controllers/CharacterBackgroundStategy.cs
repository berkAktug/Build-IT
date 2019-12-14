using Character_Builder.Models;
using Character_Builder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public abstract class BackgroundStategy
    {
        public abstract void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList);
        //public abstract void ApplyLanguage(List<CharacterProficiencyEnumModel> proficiencyList);
        //public abstract void ApplyTools(List<CharacterProficiencyEnumModel> proficiencyList);
    }

    public class AcolyteBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Insight,
                CharacterProficiencyEnumModel.Religion);
        }
    }

    public class ArchaeologistBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.History,
                CharacterProficiencyEnumModel.Survival);
        }
    }

    public class BountyHunterBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.History,
                CharacterProficiencyEnumModel.Survival);
        }
    }

    public class CharlatanBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Deception,
                CharacterProficiencyEnumModel.SleightOfHand);
        }
    }

    public class CriminalBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Deception,
                CharacterProficiencyEnumModel.Stealth);
        }
    }

    public class EntertainerBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Acrobatics,
                CharacterProficiencyEnumModel.Performance);
        }
    }

    public class FarTravellerBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Insight,
                CharacterProficiencyEnumModel.Perception);
        }
    }

    public class FolkHeroBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.AnimalHandling,
                CharacterProficiencyEnumModel.Survival);
        }
    }

    public class GuildArtisanBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Insight,
                CharacterProficiencyEnumModel.Persuasion);
        }
    }

    public class HermitBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Medicine,
                CharacterProficiencyEnumModel.Religion);
        }
    }

    public class NobleBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.History,
                CharacterProficiencyEnumModel.Persuasion);
        }
    }

    public class OutlanderBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Athletics,
                CharacterProficiencyEnumModel.Survival);
        }
    }

    public class SageBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Arcana,
                CharacterProficiencyEnumModel.History);
        }
    }

    public class SailorBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Athletics,
                CharacterProficiencyEnumModel.History);
        }
    }

    public class SoldierBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Athletics,
                CharacterProficiencyEnumModel.Intimidation);
        }
    }

    public class StojanowPrisonerBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.Deception,
                CharacterProficiencyEnumModel.Perception);
        }
    }

    public class UrchinBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, CharacterProficiencyEnumModel.SleightOfHand,
                CharacterProficiencyEnumModel.Stealth);
        }
    }

    public class BackgroundMethod
    {
        private BackgroundStategy _backgroundStrategy;

        public void SetBackgroundWithName(string backgroundName)
        {
            var character_background = EnumUtils.ParseEnum<CharacterBackgroundEnumModel>(backgroundName);
            SetBackground(character_background);
        }

        public void SetBackground(CharacterBackgroundEnumModel backgroundEnum)
        {
            switch (backgroundEnum)
            {
                case CharacterBackgroundEnumModel.Acolyte:
                    _backgroundStrategy = new AcolyteBackground();
                    break;
                case CharacterBackgroundEnumModel.Archaeologist:
                    _backgroundStrategy = new ArchaeologistBackground();
                    break;
                case CharacterBackgroundEnumModel.BountyHunter:
                    _backgroundStrategy = new BountyHunterBackground();
                    break;
                case CharacterBackgroundEnumModel.Charlatan:
                    _backgroundStrategy = new CharlatanBackground();
                    break;
                case CharacterBackgroundEnumModel.Criminal:
                    _backgroundStrategy = new CriminalBackground();
                    break;
                case CharacterBackgroundEnumModel.Entertainer:
                    _backgroundStrategy = new EntertainerBackground();
                    break;
                case CharacterBackgroundEnumModel.FarTraveler:
                    _backgroundStrategy = new FarTravellerBackground();
                    break;
                case CharacterBackgroundEnumModel.FolkHero:
                    _backgroundStrategy = new FolkHeroBackground();
                    break;
                case CharacterBackgroundEnumModel.GuildArtisan:
                    _backgroundStrategy = new GuildArtisanBackground();
                    break;
                case CharacterBackgroundEnumModel.Hermit:
                    _backgroundStrategy = new HermitBackground();
                    break;
                case CharacterBackgroundEnumModel.Noble:
                    _backgroundStrategy = new NobleBackground();
                    break;
                case CharacterBackgroundEnumModel.Outlander:
                    _backgroundStrategy = new OutlanderBackground();
                    break;
                case CharacterBackgroundEnumModel.Sage:
                    _backgroundStrategy = new SageBackground();
                    break;
                case CharacterBackgroundEnumModel.Sailor:
                    _backgroundStrategy = new SailorBackground();
                    break;
                case CharacterBackgroundEnumModel.Soldier:
                    _backgroundStrategy = new SoldierBackground();
                    break;
                case CharacterBackgroundEnumModel.StojanowPrisoner:
                    _backgroundStrategy = new StojanowPrisonerBackground();
                    break;
                case CharacterBackgroundEnumModel.Urchin:
                    _backgroundStrategy = new UrchinBackground();
                    break;
                case CharacterBackgroundEnumModel.NONE:
                default:
                    new NotImplementedException();
                    break;
            }
        }

        public void ApplyBackground(List<CharacterProficiencyEnumModel> proficiencyList)
        {
            _backgroundStrategy.ApplyProficiency(proficiencyList);

        }
    }

    public class BackgroundHelper
    {
        public static void AddProficiency(List<CharacterProficiencyEnumModel> proficiencyList,
            CharacterProficiencyEnumModel prof1, CharacterProficiencyEnumModel prof2)
        {
            if (!proficiencyList.Contains(prof1))
            {
                proficiencyList.Add(prof1);
            }
            if (!proficiencyList.Contains(prof2))
            {
                proficiencyList.Add(prof2);
            }
        }
    }

}
