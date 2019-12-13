using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class CharacterClassFeature : Feature
    {
        public int CharacterClassId { get; set; }
        public int LevelRequirement { get; set; }

        public virtual CharacterClass CharacterClass { get; set; }
    }
}
