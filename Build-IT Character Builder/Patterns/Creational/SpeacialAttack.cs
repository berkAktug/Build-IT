using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Patterns.Creational
{
    
    /// <summary>
    /// An abstract product.
    /// </summary>
    public abstract class SpeacialAttack { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class MagicSA : SpeacialAttack { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class EndureSA : SpeacialAttack { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class SneakAttackSA : SpeacialAttack { }
}
