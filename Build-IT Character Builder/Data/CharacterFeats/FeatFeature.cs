﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class FeatFeature : Feature
    {
        public int FeatId { get; set; }

        public virtual Feat Feat { get; set; }
    }
}
