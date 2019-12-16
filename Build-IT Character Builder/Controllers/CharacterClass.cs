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

        public abstract List<int> GetFeatures(ApplicationDbContext _context);

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

        public override List<int> GetFeatures(ApplicationDbContext _context)
        {
            List<int> class_feature_ID_list = new List<int>();

            var class_entity = _context.CharacterClasses.Where(x => x.Name == _ClassName);

            var levelized_features = class_entity
                                        .SelectMany(x => x.CharacterClassFeatures)
                                        .Where(feature => feature.LevelRequirement <= protectedLevel);

            foreach (var item in levelized_features)
            {
                class_feature_ID_list.Add(item.Id);
            }

            return class_feature_ID_list;
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

        public override List<int> GetFeatures(ApplicationDbContext _context)
        {
            List<int> class_feature_ID_list = new List<int>();

            var class_entity = _context.CharacterClasses.Where(x => x.Name == _ClassName);

            var levelized_features = class_entity
                                        .SelectMany(x => x.CharacterClassFeatures)
                                        .Where(feature => feature.LevelRequirement <= protectedLevel);

            foreach (var item in levelized_features)
            {
                class_feature_ID_list.Add(item.Id);
            }

            return class_feature_ID_list;
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

        public override List<int> GetFeatures(ApplicationDbContext _context)
        {
            List<int> class_feature_ID_list = new List<int>();

            var class_entity = _context.CharacterClasses.Where(x => x.Name == _ClassName);

            var levelized_features = class_entity
                                        .SelectMany(x => x.CharacterClassFeatures)
                                        .Where(feature => feature.LevelRequirement <= protectedLevel);

            foreach (var item in levelized_features)
            {
                class_feature_ID_list.Add(item.Id);
            }

            return class_feature_ID_list;
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

        public override List<int> GetFeatures(ApplicationDbContext _context)
        {
            List<int> class_feature_ID_list = new List<int>();

            var class_entity = _context.CharacterClasses.Where(x => x.Name == _ClassName);

            var levelized_features = class_entity
                                        .SelectMany(x => x.CharacterClassFeatures)
                                        .Where(feature => feature.LevelRequirement <= protectedLevel);

            foreach (var item in levelized_features)
            {
                class_feature_ID_list.Add(item.Id);
            }

            return class_feature_ID_list;
        }

    }
}
