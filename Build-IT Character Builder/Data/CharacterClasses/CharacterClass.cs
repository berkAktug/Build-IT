using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class CharacterClass : Details
    {
        public virtual ICollection<CharacterClassFeature> CharacterClassFeatures{ get; set; }
    }
}
