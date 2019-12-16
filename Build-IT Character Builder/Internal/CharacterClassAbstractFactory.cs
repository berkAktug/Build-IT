using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Character_Builder.Data;

namespace Character_Builder.Internal
{
    /// <summary>
    /// The Abstract Factory class, which defines methods for creating abstract objects.
    /// </summary>
    public abstract class CharacterClassFactory
    {
        public abstract CharacterClass CreateCharacterClass(int level);

        public abstract List<int> GetCharacterFeatureIDs(ApplicationDbContext context);
    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class RougeFactory : CharacterClassFactory
    {
        private RogueClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new RogueClass(level);

            return _Class;
        }

        public override List<int> GetCharacterFeatureIDs(ApplicationDbContext context)
        {
            return _Class.GetFeatureIDList(context);
        }
    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class WizardFactory : CharacterClassFactory
    {
        private WizardClass _Class;
        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new WizardClass(level);

            return _Class;
        }

        public override List<int> GetCharacterFeatureIDs(ApplicationDbContext context)
        {
            return _Class.GetFeatureIDList(context);
        }
    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class FighterFactory : CharacterClassFactory
    {
        private FighterClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new FighterClass(level);

            return _Class;
        }

        public override List<int> GetCharacterFeatureIDs(ApplicationDbContext context)
        {
            return _Class.GetFeatureIDList(context);
        }
    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class ClericFactory : CharacterClassFactory
    {
        private ClericClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new ClericClass(level);

            return _Class;
        }

        public override List<int> GetCharacterFeatureIDs(ApplicationDbContext context)
        {
            return _Class.GetFeatureIDList(context);
        }
    }

    public class NoClassFactory : CharacterClassFactory
    {
        public override CharacterClass CreateCharacterClass(int level)
        {
            throw new NotImplementedException();
        }

        public override List<int> GetCharacterFeatureIDs(ApplicationDbContext context)
        {
            throw new NotImplementedException();
        }
    }
}
