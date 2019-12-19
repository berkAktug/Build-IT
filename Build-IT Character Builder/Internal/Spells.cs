using Character_Builder.Data;
using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public interface ISpells
    {
        List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel);
    }

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

    public class BardSpells : ISpells
    {
        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            var spellList1 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.illusion.ToString(), PlayerLevel);

            var spellList2 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.enchantment.ToString(), PlayerLevel);

            var spellList3 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.transmutation.ToString(), PlayerLevel);

            var spellList4 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.conjuration.ToString(), PlayerLevel);

            IEnumerable<SpellModel> resultList = spellList1.Union(spellList2.Union(spellList3.Union(spellList4)));

            return resultList.ToList();
        }
    }

    public class ClericSpells : ISpells
    {
        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            var spellList1 = SpellHelper.GetSpellListByLevel(context, 
                SpellSchoolEnumModel.divination.ToString(), PlayerLevel);

            var spellList2 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.evocation.ToString(), PlayerLevel);

            var spellList3 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.necromancy.ToString(), PlayerLevel);

            IEnumerable<SpellModel> resultList = spellList1.Union(spellList2.Union(spellList3));

            return resultList.ToList();
        }
    }

    public class DruidSpells : ISpells
    {
        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            var spellList1 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.enchantment.ToString(), PlayerLevel);

            var spellList2 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.divination.ToString(), PlayerLevel);

            var spellList3 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.conjuration.ToString(), PlayerLevel);

            IEnumerable<SpellModel> resultList = spellList1.Union(spellList2.Union(spellList3));

            return resultList.ToList();
        }
    }

    public class SorcererSpells : ISpells
    {
        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            var spellList1 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.evocation.ToString(), PlayerLevel);

            var spellList2 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.enchantment.ToString(), PlayerLevel);

            var spellList3 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.illusion.ToString(), PlayerLevel);

            var spellList4 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.divination.ToString(), PlayerLevel);

            IEnumerable<SpellModel> resultList = spellList1.Union(spellList2.Union(spellList3.Union(spellList4)));

            return resultList.ToList();
        }
    }

    public class WarlockSpells : ISpells
    {
        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            return SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.abjuration.ToString(), PlayerLevel);
        }
    }

    public class WizardSpells : ISpells
    {
        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            var spellList1 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.evocation.ToString(), PlayerLevel);

            var spellList2 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.enchantment.ToString(), PlayerLevel);

            var spellList3 = SpellHelper.GetSpellListByLevel(context,
                SpellSchoolEnumModel.illusion.ToString(), PlayerLevel);

            IEnumerable<SpellModel> resultList = spellList1.Union(spellList2.Union(spellList3));

            return resultList.ToList();
        }
    }

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

        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            return Instance;
        }
    }



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
