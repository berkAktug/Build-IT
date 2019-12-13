using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class SubClassFeature : Feature
    {
        public int SubClassId { get; set; }
        public int LevelRequirement { get; set; }

        public virtual SubClass SubClass { get; set; }
    }
}
