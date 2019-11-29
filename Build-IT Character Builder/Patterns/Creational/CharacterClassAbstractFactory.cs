using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Patterns.Creational
{
    public class CharacterClassAbstractFactory
    {


        /// <summary>
        /// The Abstract Factory class, which defines methods for creating abstract objects.
        /// </summary>
        public abstract class CharacterClassFactory
        {
            public abstract CharacterClass CreateCharacterClass();
            public abstract SpeacialAttack CreateSpeacialAttack();
            public abstract Weapons CreateWeapon();
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

            public override SpeacialAttack CreateSpeacialAttack()
            {
                return new SneakAttackSA();
            }

            public override Weapons CreateWeapon()
            {
                return new DaggerWeapon();
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

            public override SpeacialAttack CreateSpeacialAttack()
            {
                return new MagicSA();
            }

            public override Weapons CreateWeapon()
            {
                return new WandWeapon();
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

            public override SpeacialAttack CreateSpeacialAttack()
            {
                return new EndureSA();
            }

            public override Weapons CreateWeapon()
            {
                return new BastardSwordWeapon();
            }
        }
    }
}
