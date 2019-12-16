﻿using Character_Builder.Internal;
using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Character_Builder.Internal
{
    public class Character
    {
        private readonly Data.ApplicationDbContext _context;

        public Character(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public void SetupCharacter(NewCharacterModel newCaracter)
        {
            // Character Class
            CharacterClassFactory classFactory = ClassAssigner(newCaracter.CharacterClass);
            classFactory.CreateCharacterClass(newCaracter.CharacterLevel);

            // Character Class Features
            var class_feature_id_list = classFactory.GetClassFeatureIDList(_context);

            // Character Background
            BackgroundMethod background = new BackgroundMethod();
            background.SetBackground(newCaracter.CharacterBackground);
            background.ApplyBackground(newCaracter.CharacterProficiencies);

            // Character Race 
            RaceMethod race = new RaceMethod();
            race.SetRace(newCaracter.CharacterRace);
            race.ApplyRace(newCaracter.CharacterProficiencies, newCaracter.CharacterAttributes);

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
