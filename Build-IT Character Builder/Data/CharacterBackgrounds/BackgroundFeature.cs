using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class BackgroundFeature : Feature
    {
        public int BackgroundId { get; set; }

        public virtual Background Background { get; set; }
    }
}
