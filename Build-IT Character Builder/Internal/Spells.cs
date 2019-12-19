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
    public class NullSpells : ISpells
    {
        public List<SpellModel> GetSpellList(ApplicationDbContext context, int PlayerLevel)
        {
            var spellList = new List<SpellModel>();

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

            spellList.Add(spell);

            return spellList;
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
