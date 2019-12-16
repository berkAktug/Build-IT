using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Character_Builder.Internal
{
    public class Character
    {
        private readonly Data.ApplicationDbContext _context;

        public Character(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public void SetupCharacter(NewCharacterModel newCharacter)
        {
            var FeatureIDList = new List<CharacterFeatureModel>();

            // Character Class
            CharacterClassFactory classFactory = ClassAssigner(newCharacter.CharacterClass);
            classFactory.CreateCharacterClass(newCharacter.CharacterLevel);
            
            // Character Class Features
            var tmp_class_Id_list = classFactory.GetClassFeatureIDList(_context);
            FeatureIDList.Union(tmp_class_Id_list);

            // Character Background
            BackgroundMethod background = new BackgroundMethod();
            background.SetBackground(newCharacter.CharacterBackground);
            background.ApplyBackground(newCharacter.CharacterProficiencies);

            // Character Race 
            RaceMethod race = new RaceMethod();
            race.SetRace(newCharacter.CharacterRace);
            race.ApplyRace(newCharacter.CharacterProficiencies, newCharacter.CharacterAttributes);

            // Character Race Features
            var tmp_race_Id_list = race.GetFeatureIDList(_context);
            FeatureIDList.Union(tmp_race_Id_list);

            // Yazdir
            var tmp_attrib_str = newCharacter.CharacterAttributes.Strength;
            // Yazdir
            var tmp_attrib_dex = newCharacter.CharacterAttributes.Dexterity;
            // Yazdir
            var tmp_attrib_con = newCharacter.CharacterAttributes.Constitution;
            // Yazdir
            var tmp_attrib_int = newCharacter.CharacterAttributes.Intelligence;
            // Yazdir
            var tmp_attrib_wis = newCharacter.CharacterAttributes.Wisdom;
            // Yazdir
            var tmp_attrib_cha = newCharacter.CharacterAttributes.Charisma;

            // Yazdir
            var tmp_class_name = classFactory.GetCharacterClassName();
            var tmp_class_feature_id_lists = classFactory.GetClassFeatureIDList(_context);
            // Yazdir
            List<string> tmp_class_feature_list_name = new List<string>();
            // Yazdir
            List<string> tmp_class_feature_list_desc = new List<string>();
            // Yazdir
            List<int> tmp_class_feature_list_level = new List<int>();

            foreach (var id in tmp_class_feature_id_lists)
            {
                var feature_class = _context.CharacterClassFeatures.Find(id);
                tmp_class_feature_list_name.Add(feature_class.Name);
                tmp_class_feature_list_desc.Add(feature_class.Description);
                tmp_class_feature_list_level.Add(feature_class.LevelRequirement);
            }

            var tmp_race_feature_id_lists = race.GetFeatureIDList(_context);
            // Yazdir
            List<string> tmp_race_feature_list_name = new List<string>();
            // Yazdir
            List<string> tmp_race_feature_list_desc = new List<string>();

            foreach (var id in tmp_race_feature_id_lists)
            {
                var feature_race = _context.RaceFeatures.Find(id);
                tmp_race_feature_list_name.Add(feature_race.Name);
                tmp_race_feature_list_desc.Add(feature_race.Description);
            }

            var tmp_background_feature_id_lists = background.GetFeatureIDlist(_context);
            // Yazdir
            List<string> tmp_background_feature_list_name = new List<string>();
            // Yazdir
            List<string> tmp_background_feature_list_desc = new List<string>();


            foreach (var id in tmp_background_feature_id_lists)
            {
                var feature_background = _context.BackgroundFeatures.Find(id);
                tmp_background_feature_list_name.Add(feature_background.Name);
                tmp_background_feature_list_desc.Add(feature_background.Description);
            }

            // Yazdir
            var tmp_proficiencies = newCharacter.CharacterProficiencies;

            // Yazdir
            var tmp_race_name = newCharacter.CharacterRace.ToString();

            // Yazdir
            var tmp_character_level = newCharacter.CharacterLevel;
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
