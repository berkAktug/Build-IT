﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Data
{
    public class Character
    {
        public int Id { get; set; }
        public int CharacterClassId { get; set; }
        public int RaceId { get; set; }
        public int BackgroundId { get; set; }

        // Meta Data
        public string Name { get; set; }
        public int AC { get; set; }
        public int HP { get; set; }
        public int AttribStr { get; set; }
        public int AttribDex { get; set; }
        public int AttribCon { get; set; }
        public int AttribInt { get; set; }
        public int AttribWis { get; set; }
        public int AttribCha { get; set; }

        public virtual CharacterClass CharacterClass { get; set; }
        public virtual Race Race { get; set; }
        public virtual Background Background { get; set; }

        public virtual ICollection<CharacterSpell> CharacterSpells { get; set; }
    }
}
