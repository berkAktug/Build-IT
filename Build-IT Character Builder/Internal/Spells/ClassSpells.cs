using Character_Builder.Data;
using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
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
}
