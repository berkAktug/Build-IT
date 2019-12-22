using Character_Builder.Data;
using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public class SpellHelper
    {
        public static List<SpellModel> GetSpellListByLevel(ApplicationDbContext context,
            string spellschoolName, int PlayerLevel)
        {
            var spellList = new List<SpellModel>();

            IQueryable<Spell> schoolSpells;

            if (PlayerLevel <= 5)
            {
                schoolSpells = context.Spells
                        .Where(x => x.School.Equals(spellschoolName))
                        .Where(s => s.Level <= 3);
            }
            else if (PlayerLevel <= 10)
            {
                schoolSpells = context.Spells
                        .Where(x => x.School.Equals(spellschoolName))
                        .Where(s => s.Level <= 5);
            }
            else if (PlayerLevel <= 15)
            {
                schoolSpells = context.Spells
                        .Where(x => x.School.Equals(spellschoolName))
                        .Where(s => s.Level <= 7);
            }
            else
            {
                schoolSpells = context.Spells
                        .Where(x => x.School.Equals(spellschoolName));
            }

            foreach (var item in schoolSpells)
            {
                var spell = new SpellModel
                {
                    Level = item.Level,
                    School = item.School,
                    CastingTime = item.CastingTime,
                    CastingTimeType = item.CastingTimeType,
                    Components = item.Components,
                    Description = item.Description,
                    SpellRange = item.Range,
                    SpellRangeType = item.RangeType,
                    Title = item.Name
                };
                spellList.Add(spell);
            }

            return spellList;
        }
    }
}
