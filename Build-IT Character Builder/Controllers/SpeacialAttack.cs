using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    
    /// <summary>
    /// An abstract product.
    /// </summary>
    public abstract class SpeacialMove { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class MagicAttack : SpeacialMove { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class SecondWind : SpeacialMove { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class SneakAttack : SpeacialMove { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class DivineIntervention : SpeacialMove { }

}
