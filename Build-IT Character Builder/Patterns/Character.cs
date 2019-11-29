using Character_Builder.Models;
using Character_Builder.Patterns.Creational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Character_Builder.Patterns
{
    public enum BonusTypes
    {
        AttackBonus,
        DamageBonus,
        SpellDCBonus,
        ArmourClassBonus,
        HitPointsBonus,
        StrengthBonus,
        DexterityBonus,
        ConstitutionBonus,
        IntelligenceBonus,
        WisdomBonus,
        CharismaBonus,
        InititiaveBonus,
        AdvantageDice
    }

    public enum PenaltyTypes
    {
        AttackPenalty,
        DamagePenalty,
        SpellDCPenalty,
        ArmourClassPenalty,
        HitPointsPenalty,
        StrengthPenalty,
        DexterityPenalty,
        ConstitutionPenalty,
        IntelligencePenalty,
        WisdomPenalty,
        CharismaPenalty,
        InititiavePenalty,
        DisadvantageDice
    }

    public abstract class Features
    {
        public string Title;
        public string Description;
        public int MinLevel;
        public int Bonus;
        public BonusTypes bonusType;
        public int Penalty;
        public PenaltyTypes penaltyType;
    }


    public class Character
    {

        public void SetupCharacter(NewCharacterModel chartoBuild)
        {
            CharacterClassAbstractFactory.CharacterClassFactory factory;
            switch (chartoBuild.CharacterClass)
            {
                case CharacterClassEnumModel.Barbarian:
                    break;
                case CharacterClassEnumModel.Bard:
                    break;
                case CharacterClassEnumModel.Cleric:
                    break;
                case CharacterClassEnumModel.Druid:
                    break;
                case CharacterClassEnumModel.Fighter:
                    factory = new CharacterClassAbstractFactory.FighterFactory();
                    break;
                case CharacterClassEnumModel.Monk:
                    break;
                case CharacterClassEnumModel.Paladin:
                    break;
                case CharacterClassEnumModel.Ranger:
                    break;
                case CharacterClassEnumModel.Rogue:
                    factory = new CharacterClassAbstractFactory.RougeFactory();
                    break;
                case CharacterClassEnumModel.Sorcerer:
                    break;
                case CharacterClassEnumModel.Warlock:
                    break;
                case CharacterClassEnumModel.Wizard:
                    factory = new CharacterClassAbstractFactory.WizardFactory();
                    break;
                case CharacterClassEnumModel.NONE:
                default:
                    break;
            }
        }
    }
}
