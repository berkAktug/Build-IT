using Character_Builder.Data;
using Character_Builder.Models;
using System.Collections.Generic;

namespace Character_Builder.Internal
{

    public class AcolyteBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Insight,
                ProficiencyEnumModel.Religion);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Acolyte.ToString());
        }
    }

    public class ArchaeologistBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.History,
                ProficiencyEnumModel.Survival);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Archaeologist.ToString());
        }
    }

    public class BountyHunterBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.History,
                ProficiencyEnumModel.Survival);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.BountyHunter.ToString());
        }
    }

    public class CharlatanBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Deception,
                ProficiencyEnumModel.SleightOfHand);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Charlatan.ToString());
        }
    }

    public class CriminalBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Deception,
                ProficiencyEnumModel.Stealth);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Criminal.ToString());
        }
    }

    public class EntertainerBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Acrobatics,
                ProficiencyEnumModel.Performance);
        }
        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Entertainer.ToString());
        }
    }

    public class FarTravellerBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Insight,
                ProficiencyEnumModel.Perception);
        }
        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.FarTraveler.ToString());
        }

    }

    public class FolkHeroBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.AnimalHandling,
                ProficiencyEnumModel.Survival);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.FolkHero.ToString());
        }

    }

    public class GuildArtisanBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Insight,
                ProficiencyEnumModel.Persuasion);
        }
        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.GuildArtisan.ToString());
        }

    }

    public class HermitBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Medicine,
                ProficiencyEnumModel.Religion);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Hermit.ToString());
        }

    }

    public class NobleBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.History,
                ProficiencyEnumModel.Persuasion);
        }
        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Noble.ToString());
        }
    }

    public class OutlanderBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Athletics,
                ProficiencyEnumModel.Survival);
        }
        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Outlander.ToString());
        }
    }

    public class SageBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Arcana,
                ProficiencyEnumModel.History);
        }
        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Sage.ToString());
        }
    }

    public class SailorBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Athletics,
                ProficiencyEnumModel.History);
        }
        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Sailor.ToString());
        }
    }

    public class SoldierBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Athletics,
                ProficiencyEnumModel.Intimidation);
        }
        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Soldier.ToString());
        }

    }

    public class StojanowPrisonerBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.Deception,
                ProficiencyEnumModel.Perception);
        }
        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.StojanowPrisoner.ToString());
        }

    }

    public class UrchinBackground : IBackground
    {
        public void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList)
        {
            BackgroundHelper.AddProficiency(proficiencyList, ProficiencyEnumModel.SleightOfHand,
                ProficiencyEnumModel.Stealth);
        }
        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return BackgroundHelper.GetFeatureList(context, BackgroundEnumModel.Urchin.ToString());
        }

    }
}
 