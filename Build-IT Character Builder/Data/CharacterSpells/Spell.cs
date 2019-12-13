using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public string Description { get; set; }
        public string Components { get; set; }
        public int Range { get; set; }
        public string RangeType { get; set; }
        public int Duration { get; set; }
        public string DurationType { get; set; }
        public string School { get; set; }
    }
}
