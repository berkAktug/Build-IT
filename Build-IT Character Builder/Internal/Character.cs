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

        public CharacterModel SetupCharacter(NewCharacterModel newCharacter)
        {
            var FeatureList = new List<FeatureModel>();
            var SpellList = new List<SpellModel>();

            // Character Class
            CharacterClassFactory classFactory = ClassAssigner(newCharacter.CharacterClass);
            classFactory.CreateCharacterClass(newCharacter.CharacterLevel);

            // Character Class Spells
            SpellList.Union(classFactory.GetSpellsList(_context));

            // Character Class Features
            FeatureList.Union(classFactory.GetClassFeatureIDList(_context));

            // Character Background
            BackgroundMethod background = new BackgroundMethod();
            background.SetBackground(newCharacter.CharacterBackground);
            background.ApplyBackground(newCharacter.CharacterProficiencies);

            // Character Background Features
            FeatureList.Union(background.GetFeatureList(_context));

            // Character Race 
            RaceMethod race = new RaceMethod();
            race.SetRace(newCharacter.CharacterRace);
            race.ApplyRace(newCharacter.CharacterProficiencies, newCharacter.CharacterAttributes);

            // Character Race Features
            FeatureList.Union(race.GetFeatureList(_context));

            var finishedCharacter = new CharacterModel
            {
                ArmourClass = 15, // GET THIS AC FROM CLASS FACTORY.
                Attributes = newCharacter.CharacterAttributes,
                CharacterClass = newCharacter.CharacterClass,
                Features = FeatureList,
                HitPoints = 40, // GET THIS HP FROM CLASS FACTORY
                Race = newCharacter.CharacterRace,
                Spells = SpellList,
                Level = newCharacter.CharacterLevel,
                Name = newCharacter.CharacterName,
                Proficiencies = newCharacter.CharacterProficiencies,
                ProficiencyBonus = 2 // GET THIS FROM CLASS FACTORY!
            };

            return finishedCharacter;
        }

        public void saveToExcel(NewCharacterModel character)
        {
            var newFile = @"DD_CharacterSheet.xlsx";

            using (var fs = new FileStream(newFile, FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();

                ISheet sheet1 = workbook.CreateSheet("CharacterSheet");

                //int row_base = 10;
                short row_stat = 10 * 20;

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
                row.Height = row_stat;
                var Str = character.CharacterAttributes.Strength;
                row.CreateCell(0).SetCellValue("Strength: " + Str);

                row = sheet1.CreateRow(4);
                row.Height = row_stat;
                var Dex = character.CharacterAttributes.Dexterity;
                row.CreateCell(0).SetCellValue("Dexterity: " + Dex);

                row = sheet1.CreateRow(5);
                row.Height = row_stat;
                var Con = character.CharacterAttributes.Constitution;
                row.CreateCell(0).SetCellValue("Constitution: " + Con);

                row = sheet1.CreateRow(6);
                row.Height = row_stat;
                var Int = character.CharacterAttributes.Intelligence;
                row.CreateCell(0).SetCellValue("Intelligence: " + Int);

                row = sheet1.CreateRow(7);
                row.Height = row_stat;
                var Wis = character.CharacterAttributes.Wisdom;
                row.CreateCell(0).SetCellValue("Wisdom: " + Wis);

                row = sheet1.CreateRow(8);
                row.Height = row_stat;
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
