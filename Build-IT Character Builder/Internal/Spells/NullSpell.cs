using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    //our null object class implementing IMobile interface as a singleton  
    public sealed class NullSpells : ISpells
    {
        private static List<SpellModel> instance = null;
        private static readonly object padlock = new object();

        NullSpells() { }

        public static List<SpellModel> Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new List<SpellModel>();

                        var spell = new SpellModel
                        {
                            Level = 0,
                            School = "",
                            CastingTime = 0,
                            CastingTimeType = "",
                            Components = "",
                            Description = "",
                            SpellRange = 0,
                            SpellRangeType = "",
                            Title = "Character Has no spells.. Damn Muggots.."
                        };

                        instance.Add(spell);
                    }
                }
                return instance;
            }
        }

        public List<SpellModel> GetSpellList(Data.ApplicationDbContext context, int PlayerLevel)
        {
            return Instance;
        }
    }
}
