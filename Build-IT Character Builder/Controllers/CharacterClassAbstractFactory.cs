using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    /// <summary>
    /// The Abstract Factory class, which defines methods for creating abstract objects.
    /// </summary>
    public abstract class CharacterClassFactory
    {
        public abstract CharacterClass CreateCharacterClass();
    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class RougeFactory : CharacterClassFactory
    {
        public override CharacterClass CreateCharacterClass()
        {
            return new RogueClass();
        }
    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class WizardFactory : CharacterClassFactory
    {
        public override CharacterClass CreateCharacterClass()
        {
            return new WizardClass();
        }
    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class FighterFactory : CharacterClassFactory
    {
        public override CharacterClass CreateCharacterClass()
        {
            return new FighterClass();
        }
    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class ClericFactory : CharacterClassFactory
    {
        public override CharacterClass CreateCharacterClass()
        {
            return new ClericClass();
        }
    }
}
