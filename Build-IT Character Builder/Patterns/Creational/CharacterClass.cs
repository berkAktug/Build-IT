using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Patterns.Creational
{
    /// <summary>
    /// An abstract product.
    /// </summary>
    public abstract class CharacterClass { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class RogueClass : CharacterClass { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class FighterClass : CharacterClass { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class WizardClass : CharacterClass { }
}
