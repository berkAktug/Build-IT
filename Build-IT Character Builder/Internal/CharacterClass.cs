using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public abstract string GetClassName();
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class BarbarianClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class BardClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class ClericClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class DruidClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class FighterClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class MonkClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class PaladinClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class RangerClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class RogueClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class SorcererClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class WarlockClass : CharacterClass
    {
        private string _ClassName;

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
    }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class WizardClass : CharacterClass
    {
        private string _ClassName;

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
    }

    #region Character_Class_Helper
    public class CharacterClassHelper
    {
        public static List<FeatureModel> GetFeatureList(ApplicationDbContext context, string className, int classLevel)
        {
            var classFeatureList = new List<FeatureModel>();

            var levelized_features = context.CharacterClasses
                                        .Where(x => x.Name == className)
                                        .SelectMany(x => x.CharacterClassFeatures)
                                        .Where(feature => feature.LevelRequirement <= classLevel);

            foreach (var item in levelized_features)
            {
                var class_feature = new FeatureModel
                {
                    Title = item.CharacterClass.Name,
                    Description = item.Description,
                    LevelRequirement = item.LevelRequirement,
                    FeatureType = FeatureTypes.CharacterClass
                };
                classFeatureList.Add(class_feature);
            }

            return classFeatureList;
        }
    }
    #endregion
}
