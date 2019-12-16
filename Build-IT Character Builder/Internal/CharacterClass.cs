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

        public abstract List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
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

        public override List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context)
        {
            return CharacterClassHelper.GetFeatureIDList(context, _ClassName, protectedLevel);
        }
    }

    #region Character_Class_Helper
    public class CharacterClassHelper
    {
        public static List<CharacterFeatureModel> GetFeatureIDList(ApplicationDbContext context, string className, int classLevel)
        {
            List<CharacterFeatureModel> classFeatureIDList = new List<CharacterFeatureModel>();

            var class_entity = context.CharacterClasses.Where(x => x.Name == className);

            var levelized_features = class_entity
                                        .SelectMany(x => x.CharacterClassFeatures)
                                        .Where(feature => feature.LevelRequirement <= classLevel);

            foreach (var item in levelized_features)
            {
                CharacterFeatureModel classFeature = new CharacterFeatureModel
                {
                    FeatureType = FeatureTypes.CharacterClass,
                    ID = item.Id
                };
                classFeatureIDList.Add(classFeature);
            }

            return classFeatureIDList;
        }
    }
    #endregion
}
