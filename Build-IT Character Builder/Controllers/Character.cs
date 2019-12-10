using Character_Builder.Internal.CharacterClassAbstractFactory;
using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Character_Builder.Internal
{
    public enum ModifiedStatType
    {
        Attack,
        Damage,
        SpellDC,
        ArmourClass,
        HitPoints,
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma,
        Inititiave,
        Dice
    }

    public enum ModifierType
    {
        Bonus,
        Penalty
    }

    //public abstract class Features
    //{
    //    public string Title;
    //    public string Description;
    //    public int MinLevel;
    //    public int modifier;
    //    public ModifiedStatType modifiedStat;
    //}
    
    public class Character
    {
        public void SetupCharacter(NewCharacterModel chartoBuild)
        {
            CharacterClassFactory classFactory;
            switch (chartoBuild.CharacterClass)
            {
                case CharacterClassEnumModel.Barbarian:
                    break;
                case CharacterClassEnumModel.Bard:
                    break;
                case CharacterClassEnumModel.Cleric:
                    classFactory = new ClericFactory();
                    break;
                case CharacterClassEnumModel.Druid:
                    break;
                case CharacterClassEnumModel.Fighter:
                    classFactory = new FighterFactory();
                    break;
                case CharacterClassEnumModel.Monk:
                    break;
                case CharacterClassEnumModel.Paladin:
                    break;
                case CharacterClassEnumModel.Ranger:
                    break;
                case CharacterClassEnumModel.Rogue:
                    classFactory = new RougeFactory();
                    break;
                case CharacterClassEnumModel.Sorcerer:
                    break;
                case CharacterClassEnumModel.Warlock:
                    break;
                case CharacterClassEnumModel.Wizard:
                    classFactory = new WizardFactory();
                    break;
                case CharacterClassEnumModel.NONE:
                default:
                    break;
            }
        }
    }
}
