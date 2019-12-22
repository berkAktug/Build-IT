using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public interface IBackground
    {
        void ApplyProficiency(List<ProficiencyEnumModel> proficiencyList);
        List<FeatureModel> GetFeatureList(Data.ApplicationDbContext context);

        //public abstract void ApplyLanguage(List<CharacterProficiencyEnumModel> proficiencyList);
        //public abstract void ApplyTools(List<CharacterProficiencyEnumModel> proficiencyList);
    }
}
