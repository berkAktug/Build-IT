using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class Race : Details
    {
        public virtual ICollection<RaceFeature> RaceFeatures { get; set; }
    }
}
