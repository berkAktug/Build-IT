﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class Background : Details
    {

        public virtual ICollection<BackgroundFeature> BackgroundFeatures { get; set; }
    }
}
