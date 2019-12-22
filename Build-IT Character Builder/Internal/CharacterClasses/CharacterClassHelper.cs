using Character_Builder.Models;
using System.Collections.Generic;
using System.Linq;

namespace Character_Builder.Internal
{
    public class CharacterClassHelper
    {
        public static List<FeatureModel> GetFeatureList(Data.ApplicationDbContext context, string className, int classLevel)
        {
            var classFeatureList = new List<FeatureModel>();

            var levelized_features = context.CharacterClasses
                                        .Where(x => x.Name == className)
                                        .SelectMany(x => x.CharacterClassFeatures)
                                        .Where(feature => feature.LevelRequirement <= classLevel);

            foreach (var item in levelized_features)
            {
                var class_feature = new FeatureModel
                {
                    Title = item.Name,
                    Description = item.Description,
                    LevelRequirement = item.LevelRequirement,
                    FeatureType = FeatureTypes.CharacterClass
                };
                classFeatureList.Add(class_feature);
            }

            return classFeatureList;
        }

        internal static int GetHitPoints(int hitDice, int protectedLevel)
        {
            return ((hitDice / 2 + 1) * protectedLevel);
        }
    }
}
