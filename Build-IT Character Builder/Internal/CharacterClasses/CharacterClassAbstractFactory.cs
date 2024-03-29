﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Character_Builder.Data;
using Character_Builder.Models;

namespace Character_Builder.Internal
{
    /// <summary>
    /// The Abstract Factory class, which defines methods for creating abstract objects.
    /// </summary>
    public abstract class CharacterClassFactory
    {
        public abstract CharacterClass CreateCharacterClass(int level);

        public abstract List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context);

        public abstract string GetCharacterClassName();

        public abstract List<SpellModel> GetSpellsList(ApplicationDbContext context);

        public abstract int GetCharacterAC();

        public abstract int GetCharacterHP();
    }


    /// <summary>
    /// An abstract product.
    /// </summary>
    public class BarbarianFactory : CharacterClassFactory
    {
        private BarbarianClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new BarbarianClass(level);

            return _Class;
        }

        public override int GetCharacterAC()
        {
            return 17;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
        }


    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class BardFactory : CharacterClassFactory
    {
        private BardClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new BardClass(level);

            return _Class;
        }

        public override int GetCharacterAC()
        {
            return 15;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
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

        public override int GetCharacterAC()
        {
            return 18;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
        }

    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class Druidactory : CharacterClassFactory
    {
        private DruidClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new DruidClass(level);

            return _Class;
        }

        public override int GetCharacterAC()
        {
            return 16;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
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

        public override int GetCharacterAC()
        {
            return 19;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
        }

    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class MonkFactory : CharacterClassFactory
    {
        private MonkClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new MonkClass(level);

            return _Class;
        }

        public override int GetCharacterAC()
        {
            return 18;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
        }

    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class PaladinFactory : CharacterClassFactory
    {
        private PaladinClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new PaladinClass(level);

            return _Class;
        }

        public override int GetCharacterAC()
        {
            return 19;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
        }

    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class RangerFactory : CharacterClassFactory
    {
        private RangerClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new RangerClass(level);

            return _Class;
        }

        public override int GetCharacterAC()
        {
            return 15;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
        }

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

        public override int GetCharacterAC()
        {
            return 14;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
        }

    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class SorcererFactory : CharacterClassFactory
    {
        private SorcererClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new SorcererClass(level);

            return _Class;
        }

        public override int GetCharacterAC()
        {
            return 13;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
        }

    }

    /// <summary>
    /// An abstract product.
    /// </summary>
    public class WarlockFactory : CharacterClassFactory
    {
        private WarlockClass _Class;

        public override CharacterClass CreateCharacterClass(int level)
        {
            _Class = new WarlockClass(level);

            return _Class;
        }

        public override int GetCharacterAC()
        {
            return 16;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
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

        public override int GetCharacterAC()
        {
            return 12;
        }

        public override string GetCharacterClassName()
        {
            return _Class.GetClassName();
        }

        public override int GetCharacterHP()
        {
            return _Class.GetHitPoints();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            return _Class.GetFeatureList(context);
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            return _Class.GetSpellList(context);
        }

    }

    public class NoClassFactory : CharacterClassFactory
    {
        public override CharacterClass CreateCharacterClass(int level)
        {
            throw new NotImplementedException();
        }

        public override int GetCharacterAC()
        {
            throw new NotImplementedException();
        }

        public override string GetCharacterClassName()
        {
            throw new NotImplementedException();
        }

        public override int GetCharacterHP()
        {
            throw new NotImplementedException();
        }

        public override List<FeatureModel> GetClassFeatureIDList(ApplicationDbContext context)
        {
            throw new NotImplementedException();
        }

        public override List<SpellModel> GetSpellsList(ApplicationDbContext context)
        {
            throw new NotImplementedException();
        }

    }
}
