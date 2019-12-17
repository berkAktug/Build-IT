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
        public abstract List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context);

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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Acolyte.ToString());
        }
    }

    public class ArchaeologistBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.History,
                ProficiencyEnumModel.Survival);
        }

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Archaeologist.ToString());
        }
    }

    public class BountyHunterBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.History,
                ProficiencyEnumModel.Survival);
        }

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.BountyHunter.ToString());
        }
    }

    public class CharlatanBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Deception,
                ProficiencyEnumModel.SleightOfHand);
        }

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Charlatan.ToString());
        }
    }

    public class CriminalBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Deception,
                ProficiencyEnumModel.Stealth);
        }

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Criminal.ToString());
        }
    }

    public class EntertainerBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Acrobatics,
                ProficiencyEnumModel.Performance);
        }
        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Entertainer.ToString());
        }
    }

    public class FarTravellerBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Insight,
                ProficiencyEnumModel.Perception);
        }
        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.FarTraveler.ToString());
        }

    }

    public class FolkHeroBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.AnimalHandling,
                ProficiencyEnumModel.Survival);
        }

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.FolkHero.ToString());
        }

    }

    public class GuildArtisanBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Insight,
                ProficiencyEnumModel.Persuasion);
        }
        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.GuildArtisan.ToString());
        }

    }

    public class HermitBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Medicine,
                ProficiencyEnumModel.Religion);
        }

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Hermit.ToString());
        }

    }

    public class NobleBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.History,
                ProficiencyEnumModel.Persuasion);
        }
        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Noble.ToString());
        }

    }

    public class OutlanderBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Athletics,
                ProficiencyEnumModel.Survival);
        }
        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Outlander.ToString());
        }

    }

    public class SageBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Arcana,
                ProficiencyEnumModel.History);
        }
        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Sage.ToString());
        }

    }

    public class SailorBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Athletics,
                ProficiencyEnumModel.History);
        }
        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Sailor.ToString());
        }
    }

    public class SoldierBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Athletics,
                ProficiencyEnumModel.Intimidation);
        }
        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Soldier.ToString());
        }

    }

    public class StojanowPrisonerBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Deception,
                ProficiencyEnumModel.Perception);
        }
        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.StojanowPrisoner.ToString());
        }

    }

    public class UrchinBackground : BackgroundStategy
    {
        public override void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.SleightOfHand,
                ProficiencyEnumModel.Stealth);
        }
        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureIDList(context, BackgroundEnumModel.Urchin.ToString());
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

        public List<CharacterFeatureModel> GetFeatureIDlist(ApplicationDbContext context)
        {
            return _backgroundStrategy.GetFeatureIDList(context);
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

        public static List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context, string backgroundName)
        {
            var background_feature_ID_list = new List<CharacterFeatureModel>();

            var background_entity = context.Backgrounds
                .Where(x => x.Name == backgroundName)
                .SelectMany(x => x.BackgroundFeatures);

            foreach (var item in background_entity)
            {
                var tmp_feature_model = new CharacterFeatureModel
                {
                    FeatureType = FeatureTypes.Background,
                    ID = item.Id
                };

                background_feature_ID_list.Add(tmp_feature_model);
            }
            return background_feature_ID_list;
        }
    }
}
