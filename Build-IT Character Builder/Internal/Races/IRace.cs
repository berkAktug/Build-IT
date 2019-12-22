using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public interface IRace
    {
        void ApplyAttribute(CharacterAttributesModel characterAttributes);
        //void ApplySpell();
        void ApplyProficiency(List<ProficiencyEnumModel> characterProficiencies);
        List<FeatureModel> GetFeatureList(Data.ApplicationDbContext context);
        List<SpellModel> GetSpellList(Data.ApplicationDbContext context);
    }
}
