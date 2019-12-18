using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class Spell : Details
    {
        public int Level { get; set; }

        public string Components { get; set; }

        public int Range { get; set; }
        public string RangeType { get; set; }

        public int Duration { get; set; }
        public string DurationType { get; set; }

        public int CastingTime { get; set; }
        public string CastingTimeType { get; set; }

        public string School { get; set; }
    }
}
