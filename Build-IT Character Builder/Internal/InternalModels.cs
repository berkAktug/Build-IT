﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public enum FeatureTypes
    {
        CharacterClass,
        Background,
        Race
    }


    public class CharacterFeatureModel
    {
        public FeatureTypes FeatureType { get; set; }
        public int ID { get; set; }
    }
}
