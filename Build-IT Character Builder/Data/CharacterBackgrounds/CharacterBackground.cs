﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class Background
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BackgroundFeature> BackgroundFeatures { get; set; }
    }
}
