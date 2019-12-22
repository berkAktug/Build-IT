using Character_Builder.Data;
using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public class RaceHelper
    {
        public static void AddProficiency(List<ProficiencyEnumModel> proficiencyList,
            ProficiencyEnumModel proficiency)
        {
            if (!proficiencyList.Contains(proficiency))
            {
                proficiencyList.Add(proficiency);
            }
        }

        public static void AdjustAttribute(int attribute, bool isIncrement, int modifier)
        {
            if (isIncrement)
            {
                attribute += modifier;
                if (attribute > 20)
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

        public static List<FeatureModel> GetFeatureList(ApplicationDbContext context, string raceName)
        {
            var raceFeatureList = new List<FeatureModel>();

            var race_id = context.Races
                                    .Where(x => x.Name == raceName).Select(x => x.Id).First();
            //.SelectMany(x => x.RaceFeatures);
            IQueryable<RaceFeature> race_entity = context.RaceFeatures.Where(x => x.RaceId == race_id);

            foreach (RaceFeature item in race_entity)
            {
                var race_feature = new FeatureModel
                {
                    //Title = item.Race.Name,
                    Title = raceName,
                    Description = item.Description,
                    FeatureType = FeatureTypes.CharacterClass
                };

                raceFeatureList.Add(race_feature);
            }
            return raceFeatureList;
        }
    }
}
