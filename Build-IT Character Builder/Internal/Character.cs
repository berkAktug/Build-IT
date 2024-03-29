﻿using Character_Builder.Models;
using System;
using System.Collections.Generic;


namespace Character_Builder.Internal
{
    public class Character
    {
        private readonly Data.ApplicationDbContext _context;

        public Character(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public CharacterModel SetupCharacter(NewCharacterModel newCharacter)
        {
            var FeatureList = new List<FeatureModel>();
            var SpellList = new List<SpellModel>();

            // Character Class
            CharacterClassFactory classFactory = ClassAssigner(newCharacter.CharacterClass);
            classFactory.CreateCharacterClass(int.Parse(newCharacter.CharacterLevel));

            int CharacterHP = classFactory.GetCharacterHP();
            int CharacterAC = classFactory.GetCharacterAC();
            int ProficiencyBonus = _GetProficiencyBonus(newCharacter.CharacterLevel);

            // Character Class Spells
            var classSpells = classFactory.GetSpellsList(_context);

            foreach (var item in classSpells)
            {
                SpellList.Add(item);
            }

            // Character Class Features
            var classFeatures = classFactory.GetClassFeatureIDList(_context);

            foreach (var item in classFeatures)
            {
                FeatureList.Add(item);
            }

            // Character Background
            BackgroundMethod background = new BackgroundMethod();
            background.SetBackground(newCharacter.CharacterBackground);
            background.ApplyBackground(newCharacter.CharacterProficiencies);

            // Character Background Features
            var backgroundFeatures = background.GetFeatureList(_context);

            foreach (var item in backgroundFeatures)
            {
                FeatureList.Add(item);
            }
            
            // Character Race 
            RaceMethod race = new RaceMethod();
            race.SetRace(newCharacter.CharacterRace);
            race.ApplyRace(newCharacter.CharacterProficiencies, newCharacter.CharacterAttributes);

            // Character Race Features
            var raceFeatures = race.GetFeatureList(_context);

            foreach (var item in raceFeatures)
            {
                FeatureList.Add(item);
            }

            var finishedCharacter = new CharacterModel
            {
                ArmourClass = CharacterAC,
                Attributes = newCharacter.CharacterAttributes,
                Background = newCharacter.CharacterBackground,
                CharacterClass = newCharacter.CharacterClass,
                Features = FeatureList,
                HitPoints = CharacterHP, 
                Race = newCharacter.CharacterRace,
                Spells = SpellList,
                Level = newCharacter.CharacterLevel,
                Name = newCharacter.CharacterName,
                Proficiencies = newCharacter.CharacterProficiencies,
                ProficiencyBonus = ProficiencyBonus 
            };

            return finishedCharacter;
        }

        private int _GetProficiencyBonus(string characterLevel)
        {
            int charlevelInt = int.Parse(characterLevel);

            if (charlevelInt < 5)
            {
                return 2;
            }
            else if (charlevelInt < 9)
            {
                return 3;
            }
            else if (charlevelInt < 12)
            {
                return 4;
            }
            else if (charlevelInt < 15)
            {
                return 5;
            }
            else
            {
                return 6;
            }
        }


        private CharacterClassFactory ClassAssigner(CharacterClassEnumModel characterClass)
        {
            CharacterClassFactory classFactory;
            switch (characterClass)
            {
                case CharacterClassEnumModel.Barbarian:
                    return classFactory = new BarbarianFactory();
                case CharacterClassEnumModel.Bard:
                    return classFactory = new BardFactory();
                case CharacterClassEnumModel.Cleric:
                    return classFactory = new ClericFactory();
                case CharacterClassEnumModel.Druid:
                    return classFactory = new Druidactory();
                case CharacterClassEnumModel.Fighter:
                    return classFactory = new FighterFactory();
                case CharacterClassEnumModel.Monk:
                    return classFactory = new MonkFactory();
                case CharacterClassEnumModel.Paladin:
                    return classFactory = new PaladinFactory();
                case CharacterClassEnumModel.Ranger:
                    return classFactory = new RangerFactory();
                case CharacterClassEnumModel.Rogue:
                    return classFactory = new RougeFactory();
                case CharacterClassEnumModel.Sorcerer:
                    return classFactory = new SorcererFactory();
                case CharacterClassEnumModel.Warlock:
                    return classFactory = new WarlockFactory();
                case CharacterClassEnumModel.Wizard:
                    return classFactory = new WizardFactory();
                case CharacterClassEnumModel.NONE:
                    new NotImplementedException();
                    break;
                default:
                    break;
            }
            return classFactory = new NoClassFactory();
        }
    }
}
