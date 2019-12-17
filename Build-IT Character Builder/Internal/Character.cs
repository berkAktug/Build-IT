using Character_Builder.Models;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
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

            foreach (var item in tmp_class_feature_id_lists)
            {
                var feature_class = _context.CharacterClassFeatures.Find(item.ID);
                tmp_class_feature_list_name.Add(feature_class.Name);
                tmp_class_feature_list_desc.Add(feature_class.Description);
                tmp_class_feature_list_level.Add(feature_class.LevelRequirement);
            }

            List<CharacterFeatureModel> tmp_race_feature_id_lists = race.GetFeatureIDList(_context);
            // Yazdir
            List<string> tmp_race_feature_list_name = new List<string>();
            // Yazdir
            List<string> tmp_race_feature_list_desc = new List<string>();

            foreach (var item in tmp_race_feature_id_lists)
            {
                var feature_race = _context.RaceFeatures.Find(item.ID);
                tmp_race_feature_list_name.Add(feature_race.Name);
                tmp_race_feature_list_desc.Add(feature_race.Description);
            }

            var tmp_background_feature_id_lists = background.GetFeatureIDlist(_context);
            // Yazdir
            List<string> tmp_background_feature_list_name = new List<string>();
            // Yazdir
            List<string> tmp_background_feature_list_desc = new List<string>();


            foreach (var item in tmp_background_feature_id_lists)
            {
                var feature_background = _context.BackgroundFeatures.Find(item.ID);
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

        public void saveToExcel(NewCharacterModel character)
        {
            var newFile = @"DD_CharacterSheet.xlsx";

            using (var fs = new FileStream(newFile, FileMode.Create, FileAccess.Write))
            {

                IWorkbook workbook = new XSSFWorkbook();

                ISheet sheet1 = workbook.CreateSheet("CharacterSheet");

                //D&D Banner
                IRow row = sheet1.CreateRow(0);
                row.Height = 30 * 80;
                row.CreateCell(0).SetCellValue("DUNGEONS & DRAGONS");
                sheet1.AutoSizeColumn(0);

                //Character name
                row = sheet1.CreateRow(1);
                row.Height = 10 * 80;
                var charName = character.CharacterName;
                row.CreateCell(0).SetCellValue("Character Name: " + charName);

                //Class & Level
                row = sheet1.GetRow(1);
                row.Height = 10 * 160;
                var className = character.CharacterClass;
                var level = character.CharacterLevel;
                row.CreateCell(1).SetCellValue("Class & Level: " + className + "\t" + level);

                //Race & Level
                row = sheet1.CreateRow(2);
                row.Height = 10 * 160;
                var race = character.CharacterRace;
                row.CreateCell(1).SetCellValue("Race: " + race);

                //Attributes
                row = sheet1.CreateRow(3);
                row.Height = 10 * 20;
                var Str = character.CharacterAttributes.Strength;
                row.CreateCell(0).SetCellValue("Strength: " + Str);

                row = sheet1.CreateRow(4);
                row.Height = 10 * 20;
                var Dex = character.CharacterAttributes.Dexterity;
                row.CreateCell(0).SetCellValue("Dexterity: " + Dex);

                row = sheet1.CreateRow(5);
                row.Height = 10 * 20;
                var Con = character.CharacterAttributes.Constitution;
                row.CreateCell(0).SetCellValue("Constitution: " + Con);

                row = sheet1.CreateRow(6);
                row.Height = 10 * 20;
                var Int = character.CharacterAttributes.Intelligence;
                row.CreateCell(0).SetCellValue("Intelligence: " + Int);

                row = sheet1.CreateRow(7);
                row.Height = 10 * 20;
                var Wis = character.CharacterAttributes.Wisdom;
                row.CreateCell(0).SetCellValue("Wisdom: " + Wis);

                row = sheet1.CreateRow(8);
                row.Height = 10 * 20;
                var Cha = character.CharacterAttributes.Charisma;
                row.CreateCell(0).SetCellValue("Charisma: " + Cha);

                //background
                row = sheet1.GetRow(3);
                row.Height = 10 * 20;
                var background = character.CharacterBackground;
                row.CreateCell(1).SetCellValue("Background: " + background);

                //background
                row = sheet1.GetRow(4);
                row.Height = 10 * 20;
                var proficiencies = character.CharacterProficiencies;
                row.CreateCell(1).SetCellValue("Background: " + background);

                //var style1 = workbook.CreateCellStyle();
                //style1.FillForegroundColor = HSSFColor.Blue.Index2;
                //style1.FillPattern = FillPattern.SolidForeground;

                //var style2 = workbook.CreateCellStyle();
                //style2.FillForegroundColor = HSSFColor.Yellow.Index2;
                //style2.FillPattern = FillPattern.SolidForeground;

                workbook.Write(fs);
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
