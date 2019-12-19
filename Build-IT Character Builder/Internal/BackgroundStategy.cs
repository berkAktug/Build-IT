using Character_Builder.Data;
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
        public abstract void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList);
        public abstract List<FeatureModel> GetFeatureList(ApplicationDbContext context);

        //public abstract void ApplyLanguage(List<CharacterProficiencyEnumModel> proficiencyList);
        //public abstract void ApplyTools(List<CharacterProficiencyEnumModel> proficiencyList);
    }

    public class AcolyteBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Insight,
                ProficiencyEnumModel.Religion);
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Acolyte.ToString());
        }
    }

    public class ArchaeologistBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.History,
                ProficiencyEnumModel.Survival);
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Archaeologist.ToString());
        }
    }

    public class BountyHunterBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.History,
                ProficiencyEnumModel.Survival);
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.BountyHunter.ToString());
        }
    }

    public class CharlatanBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Deception,
                ProficiencyEnumModel.SleightOfHand);
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Charlatan.ToString());
        }
    }

    public class CriminalBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Deception,
                ProficiencyEnumModel.Stealth);
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Criminal.ToString());
        }
    }

    public class EntertainerBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Acrobatics,
                ProficiencyEnumModel.Performance);
        }
        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Entertainer.ToString());
        }
    }

    public class FarTravellerBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Insight,
                ProficiencyEnumModel.Perception);
        }
        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.FarTraveler.ToString());
        }

    }

    public class FolkHeroBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.AnimalHandling,
                ProficiencyEnumModel.Survival);
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.FolkHero.ToString());
        }

    }

    public class GuildArtisanBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Insight,
                ProficiencyEnumModel.Persuasion);
        }
        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.GuildArtisan.ToString());
        }

    }

    public class HermitBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Medicine,
                ProficiencyEnumModel.Religion);
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Hermit.ToString());
        }

    }

    public class NobleBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.History,
                ProficiencyEnumModel.Persuasion);
        }
        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Noble.ToString());
        }
    }

    public class OutlanderBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Athletics,
                ProficiencyEnumModel.Survival);
        }
        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Outlander.ToString());
        }
    }

    public class SageBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Arcana,
                ProficiencyEnumModel.History);
        }
        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Sage.ToString());
        }
    }

    public class SailorBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Athletics,
                ProficiencyEnumModel.History);
        }
        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Sailor.ToString());
        }
    }

    public class SoldierBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Athletics,
                ProficiencyEnumModel.Intimidation);
        }
        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Soldier.ToString());
        }

    }

    public class StojanowPrisonerBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Deception,
                ProficiencyEnumModel.Perception);
        }
        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.StojanowPrisoner.ToString());
        }

    }

    public class UrchinBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.SleightOfHand,
                ProficiencyEnumModel.Stealth);
        }
        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Urchin.ToString());
        }

    }

    public class BackgroundMethod
    {
        private BackgroundStategy _backgroundStrategy;

        public void SetBackgroundWithName(string backgroundName)
        {
            var character_background = EnumUtils.ParseEnum<BackgroundEnumModel>(backgroundName);
            SetBackground(character_background);
        }

        public void SetBackground(BackgroundEnumModel backgroundEnum)
        {
            switch (backgroundEnum)
            {
                case BackgroundEnumModel.Acolyte:
                    _backgroundStrategy = new AcolyteBackground();
                    break;
                case BackgroundEnumModel.Archaeologist:
                    _backgroundStrategy = new ArchaeologistBackground();
                    break;
                case BackgroundEnumModel.BountyHunter:
                    _backgroundStrategy = new BountyHunterBackground();
                    break;
                case BackgroundEnumModel.Charlatan:
                    _backgroundStrategy = new CharlatanBackground();
                    break;
                case BackgroundEnumModel.Criminal:
                    _backgroundStrategy = new CriminalBackground();
                    break;
                case BackgroundEnumModel.Entertainer:
                    _backgroundStrategy = new EntertainerBackground();
                    break;
                case BackgroundEnumModel.FarTraveler:
                    _backgroundStrategy = new FarTravellerBackground();
                    break;
                case BackgroundEnumModel.FolkHero:
                    _backgroundStrategy = new FolkHeroBackground();
                    break;
                case BackgroundEnumModel.GuildArtisan:
                    _backgroundStrategy = new GuildArtisanBackground();
                    break;
                case BackgroundEnumModel.Hermit:
                    _backgroundStrategy = new HermitBackground();
                    break;
                case BackgroundEnumModel.Noble:
                    _backgroundStrategy = new NobleBackground();
                    break;
                case BackgroundEnumModel.Outlander:
                    _backgroundStrategy = new OutlanderBackground();
                    break;
                case BackgroundEnumModel.Sage:
                    _backgroundStrategy = new SageBackground();
                    break;
                case BackgroundEnumModel.Sailor:
                    _backgroundStrategy = new SailorBackground();
                    break;
                case BackgroundEnumModel.Soldier:
                    _backgroundStrategy = new SoldierBackground();
                    break;
                case BackgroundEnumModel.StojanowPrisoner:
                    _backgroundStrategy = new StojanowPrisonerBackground();
                    break;
                case BackgroundEnumModel.Urchin:
                    _backgroundStrategy = new UrchinBackground();
                    break;
                case BackgroundEnumModel.NONE:
                default:
                    new NotImplementedException();
                    break;
            }
        }

        public void ApplyBackground(List<ProficiencyEnumModel> proficiencyList)
        {
            _backgroundStrategy.ApplyProficiency(proficiencyList);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return _backgroundStrategy.GetFeatureList(context);
        }
    }

    public class BackgroundHelper
    {
        public static void AddProficiency(List<ProficiencyEnumModel> proficiencyList,
            ProficiencyEnumModel prof1, ProficiencyEnumModel prof2)
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

        public static List<FeatureModel> GetFeatureList(ApplicationDbContext context, string backgroundName)
        {
            var backgroundFeatureList = new List<FeatureModel>();

            var background_entity = context.Backgrounds
                                    .Where(x => x.Name == backgroundName)
                                    .SelectMany(x => x.BackgroundFeatures);

            foreach (var item in background_entity)
            {
                var background_feature = new FeatureModel
                {
                    Title = item.Name,
                    Description = item.Description,
                    FeatureType = FeatureTypes.CharacterClass
                };

                backgroundFeatureList.Add(background_feature);
            }
            return backgroundFeatureList;
        }
    }
}
 