﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Patterns.Creational
{

    /// <summary>
    /// An abstract product.
    /// </summary>
    public abstract class Weapons { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class DaggerWeapon : Weapons { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class WandWeapon : Weapons { }

    /// <summary>
    /// A concrete product
    /// </summary>
    public class BastardSwordWeapon : Weapons { }
}
