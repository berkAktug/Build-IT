using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class RaceFeature : Feature
    {
        public int RaceId { get; set; }

        public virtual Race Race { get; set; }
    }
}
