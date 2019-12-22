using Character_Builder.Data;
using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public class HalflingSpells : ISpells
    {
        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            var halflingSpellList = new List<SpellModel>();

            Spell halflingSpell = context.Spells.Where(x => x.Name.Equals("Minor Illusion")).FirstOrDefault();
            var spell = new SpellModel
            {
                Level = halflingSpell.Level,
                CastingTime = halflingSpell.CastingTime,
                CastingTimeType = halflingSpell.CastingTimeType,
                Components = halflingSpell.Components,
                Description = halflingSpell.Description,
                School = halflingSpell.School,
                SpellRange = halflingSpell.Range,
                SpellRangeType = halflingSpell.RangeType,
                Title = halflingSpell.Name
            };
            halflingSpellList.Add(spell);
            return halflingSpellList;
        }
    }

    public class DragonbornSpells : ISpells
    {
        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            var dragonbornSpellList = new List<SpellModel>();

            Spell dragonbornSpell = context.Spells.Where(x => x.Name.Equals("Fire Storm")).FirstOrDefault();
            var spell = new SpellModel
            {
                Level = dragonbornSpell.Level,
                CastingTime = dragonbornSpell.CastingTime,
                CastingTimeType = dragonbornSpell.CastingTimeType,
                Components = dragonbornSpell.Components,
                Description = dragonbornSpell.Description,
                School = dragonbornSpell.School,
                SpellRange = dragonbornSpell.Range,
                SpellRangeType = dragonbornSpell.RangeType,
                Title = dragonbornSpell.Name
            };
            dragonbornSpellList.Add(spell);

            return dragonbornSpellList;
        }
    }

    public class ElfSpells : ISpells
    {
        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            var elfSpellList = new List<SpellModel>();

            for (int i = 0; i < 3; i++)
            {
                Spell elfspell = new Spell();
                switch (i)
                {
                    case 1:
                        elfspell = context.Spells.Where(x => x.Name.Equals("Find the Path")).FirstOrDefault();
                        break;
                    case 2:
                        elfspell = context.Spells.Where(x => x.Name.Equals("Druidcraft")).FirstOrDefault();
                        break;
                    case 3:
                        elfspell = context.Spells.Where(x => x.Name.Equals("Fly")).FirstOrDefault();
                        break;
                    default:
                        break;
                }

                var spell = new SpellModel
                {
                    Level = elfspell.Level,
                    CastingTime = elfspell.CastingTime,
                    CastingTimeType = elfspell.CastingTimeType,
                    Components = elfspell.Components,
                    Description = elfspell.Description,
                    School = elfspell.School,
                    SpellRange = elfspell.Range,
                    SpellRangeType = elfspell.RangeType,
                    Title = elfspell.Name
                };
                elfSpellList.Add(spell);
            }

            return elfSpellList;
        }
    }
}
