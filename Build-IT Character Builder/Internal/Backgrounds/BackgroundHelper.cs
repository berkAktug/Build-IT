using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
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

        public static List<FeatureModel> GetFeatureList(Data.ApplicationDbContext context, string backgroundName)
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
