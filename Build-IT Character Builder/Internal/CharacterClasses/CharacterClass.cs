using System.Collections.Generic;
using Character_Builder.Data;
using Character_Builder.Models;

namespace Character_Builder.Internal
{
    /// <summary>
    /// An abstract product.
    /// </summary>
    public abstract class CharacterClass
    {
        protected int protectedLevel;

        protected CharacterClass(int protectedLevel)
        {
            this.protectedLevel = protectedLevel;
        }

        public abstract List<FeatureModel> GetFeatureList(ApplicationDbContext context);

        public abstract List<SpellModel> GetSpellList(ApplicationDbContext context);

        public abstract string GetClassName();

        public abstract int GetHitPoints();
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class BarbarianClass : CharacterClass
    {
        private readonly string _ClassName;

        public BarbarianClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Barbarian.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(12, protectedLevel);
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class BardClass : CharacterClass
    {
        private readonly string _ClassName;

        public BardClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Bard.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(8, protectedLevel);
        }

        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellListHelper = new BardSpells();
            return spellListHelper.GetSpellList(context, protectedLevel);
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class ClericClass : CharacterClass
    {
        private readonly string _ClassName;

        public ClericClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Cleric.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(8, protectedLevel);
        }

        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellListHelper = new ClericSpells();
            return spellListHelper.GetSpellList(context, protectedLevel);
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class DruidClass : CharacterClass
    {
        private readonly string _ClassName;

        public DruidClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Druid.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(8, protectedLevel);
        }

        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellListHelper = new DruidSpells();
            return spellListHelper.GetSpellList(context, protectedLevel);
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class FighterClass : CharacterClass
    {
        private readonly string _ClassName;

        public FighterClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Fighter.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(10, protectedLevel);
        }


        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class MonkClass : CharacterClass
    {
        private readonly string _ClassName;

        public MonkClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Monk.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(8, protectedLevel);
        }

        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class PaladinClass : CharacterClass
    {
        private readonly string _ClassName;

        public PaladinClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Paladin.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(10, protectedLevel);
        }

        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class RangerClass : CharacterClass
    {
        private readonly string _ClassName;

        public RangerClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Ranger.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(10, protectedLevel);
        }
        
        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class RogueClass : CharacterClass
    {
        private readonly string _ClassName;

        public RogueClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Rogue.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(8, protectedLevel);
        }
        
        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class SorcererClass : CharacterClass
    {
        private readonly string _ClassName;

        public SorcererClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Sorcerer.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(6, protectedLevel);
        }

        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellListHelper = new SorcererSpells();
            return spellListHelper.GetSpellList(context, protectedLevel);
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class WarlockClass : CharacterClass
    {
        private readonly string _ClassName;

        public WarlockClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Warlock.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(8, protectedLevel);
        }

        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellListHelper = new WarlockSpells();
            return spellListHelper.GetSpellList(context, protectedLevel);
        }
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class WizardClass : CharacterClass
    {
        private readonly string _ClassName;

        public WizardClass(int protectedLevel) : base(protectedLevel)
        {
            _ClassName = CharacterClassEnumModel.Wizard.ToString();
        }

        public override string GetClassName()
        {
            return _ClassName;
        }

        public override List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureList(context, _ClassName, protectedLevel);
        }

        public override int GetHitPoints()
        {
            return CharacterClassHelper.GetHitPoints(6, protectedLevel);
        }

        public override List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellListHelper = new WizardSpells();
            return spellListHelper.GetSpellList(context, protectedLevel);
        }
    }
}
