using System;
using System.Collections.Generic;
using Character_Builder.Internal;
using Character_Builder.Models;
using Character_Builder.Utils;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Character_Builder.Controllers
{
    public class CharacterController : Controller
    {
        private readonly Data.ApplicationDbContext _context;

        public CharacterController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult CharacterBuilder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetupNewCharacter([FromBody] NewCharacterViewModel newCharacter)
        {
            var charName = newCharacter.CharacterName;
            var charClass = _getCharacterClass(newCharacter.CharacterClassName);
            var charLevel = newCharacter.CharacterLevel;
            var charBackground = _getCharacterBackground(newCharacter.CharacterBackground);
            var charRace = _getCharacterRace(newCharacter.CharacterRace);
            var charProficiency = _getCharacterProfiencies(newCharacter.CharacterProficiencies);
            var charAttributes = newCharacter.CharacterAttributes;

            CharacterAttributesModel attrib = new CharacterAttributesModel();
            attrib.Strength = charAttributes[0];
            attrib.Dexterity = charAttributes[1];
            attrib.Constitution = charAttributes[2];
            attrib.Intelligence = charAttributes[3];
            attrib.Wisdom = charAttributes[4];
            attrib.Charisma = charAttributes[5];

            var charToBuild = new NewCharacterModel
            {
                CharacterName = charName,
                CharacterBackground = charBackground,
                CharacterClass = charClass,
                CharacterLevel = charLevel,
                CharacterProficiencies = charProficiency,
                CharacterRace = charRace,
                CharacterAttributes = attrib
            };

            Character newChar = new Character(_context);

            CharacterModel finishedCharacter = newChar.SetupCharacter(charToBuild);

            // Adjust excel according to finished Character

            return saveToExcel(finishedCharacter);
        }

        public ActionResult saveToExcel(CharacterModel character)
        {
            string fileName = string.Format("DD_CharacterSheet-{0:d}.xlsx", DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();

                ISheet sheet1 = workbook.CreateSheet("CharacterSheet");

                var style1 = workbook.CreateCellStyle();
                style1.FillForegroundColor = HSSFColor.Yellow.Index2;
                style1.FillPattern = FillPattern.SolidForeground;

                var style2 = workbook.CreateCellStyle();
                style2.FillForegroundColor = HSSFColor.LightGreen.Index;
                style2.FillPattern = FillPattern.SolidForeground;


                //D&D Banner
                IRow row = sheet1.CreateRow(0);
                row.Height = (short)-1;
                row.CreateCell(0).SetCellValue("DUNGEONS & DRAGONS");
                row.GetCell(0).CellStyle = style1;

                //Character name
                row = sheet1.CreateRow(1);
                row.Height = (short)-1;
                var charName = character.Name;
                row.CreateCell(0).SetCellValue("Character Name: " + charName);
                row.GetCell(0).CellStyle = style1;

                //Class & Level
                row = sheet1.GetRow(1);
                row.Height = (short)-1;
                var className = character.CharacterClass;
                var level = character.Level;
                row.CreateCell(1).SetCellValue("Class & Level: " + className + "    [" + level + "]");
                row.GetCell(1).CellStyle = style1;

                //Race & Level
                row = sheet1.CreateRow(2);
                row.Height = (short)-1;
                var race = character.Race;
                row.CreateCell(1).SetCellValue("Race: " + race);
                row.GetCell(1).CellStyle = style1;

                


                // 2th column row counter
                int row_counter = 3;
                //background
                row = sheet1.CreateRow(row_counter);
                row.Height = (short)-1;
                var background = character.Background;
                row.CreateCell(1).SetCellValue("Background: " + background);
                row.GetCell(1).CellStyle = style1;

                //proficiencies
                //row = sheet1.GetRow(++row_counter);
                //row.Height = (short)-1;
                var proficiencies = character.Proficiencies;
                string profStr = "";
                foreach (var proficiency in proficiencies)
                {
                    row = sheet1.CreateRow(++row_counter);
                    row = sheet1.GetRow(row_counter);
                    row.Height = (short)-1;
                    profStr = proficiency.ToString();

                    //profStr = profStr.Substring(0, profStr.Length - 5);
                    row.CreateCell(1).SetCellValue("Proficient in: " + profStr);
                    row.GetCell(1).CellStyle = style1;
                }

                //armour class
                row = sheet1.CreateRow(++row_counter);
                row = sheet1.GetRow(row_counter);
                row.Height = (short)-1;
                var armClass = character.ArmourClass;
                row.CreateCell(1).SetCellValue("Armour Class: " + armClass);
                row.GetCell(1).CellStyle = style1;

                // Hit Points
                row = sheet1.CreateRow(++row_counter);
                row = sheet1.GetRow(row_counter);
                row.Height = (short)-1;
                var HitPoints = character.HitPoints;
                row.CreateCell(1).SetCellValue("HP: " + HitPoints);
                row.GetCell(1).CellStyle = style1;


                //features
                var features = character.Features;
                string featStr = "";
                foreach (var feat in features)
                {
                    row = sheet1.CreateRow(++row_counter);
                    row = sheet1.GetRow(row_counter);
                    row.Height = (short)-1;

                    featStr = feat.Title.Trim() + ": ";
                    featStr += feat.Description.Trim() +  " ;";

                    row.CreateCell(1).SetCellValue("Feature: " + featStr);
                    row.GetCell(1).CellStyle = style1;
                }

                
                //spells
                var spells = character.Spells;
                string spellStr = "";
                foreach (var spell in spells)
                {
                    row = sheet1.CreateRow(++row_counter);
                    row = sheet1.GetRow(row_counter);
                    row.Height = (short)-1;
                    spellStr = "Spell Name:";
                    spellStr += spell.Title.Trim() + " Level:";
                    spellStr += spell.Level.ToString() + " School:";
                    spellStr += spell.School.Trim() + " Components";
                    spellStr += spell.Components.Trim() + " Casting Time:";
                    spellStr += spell.CastingTime.ToString() + " " + spell.CastingTimeType.Trim();

                    //spellStr = spellStr.Substring(0, spellStr.Length - 5);
                    //row.CreateCell(1).SetCellValue("Spells(" + spells.Count + "): " + spellStr);
                    row.CreateCell(1).SetCellValue(spellStr);
                    row.GetCell(1).CellStyle = style1;
                }
                //spellStr = spellStr.Substring(0, spellStr.Length - 5);
                //row.CreateCell(1).SetCellValue("Spells(" + spells.Count + "): " + spellStr);
                //row.GetCell(1).CellStyle = style1;

                //Attributes
                row = sheet1.GetRow(3);
                row.Height = (short)-1;
                var Str = character.Attributes.Strength;
                row.CreateCell(0).SetCellValue("Strength: " + Str);
                row.GetCell(0).CellStyle = style2;

                row = sheet1.GetRow(4);
                row.Height = (short)-1;
                var Dex = character.Attributes.Dexterity;
                row.CreateCell(0).SetCellValue("Dexterity: " + Dex);
                row.GetCell(0).CellStyle = style2;

                row = sheet1.GetRow(5);
                row.Height = (short)-1;
                var Con = character.Attributes.Constitution;
                row.CreateCell(0).SetCellValue("Constitution: " + Con);
                row.GetCell(0).CellStyle = style2;

                row = sheet1.GetRow(6);
                row.Height = (short)-1;
                var Int = character.Attributes.Intelligence;
                row.CreateCell(0).SetCellValue("Intelligence: " + Int);
                row.GetCell(0).CellStyle = style2;

                row = sheet1.GetRow(7);
                row.Height = (short)-1;
                var Wis = character.Attributes.Wisdom;
                row.CreateCell(0).SetCellValue("Wisdom: " + Wis);
                row.GetCell(0).CellStyle = style2;

                row = sheet1.GetRow(8);
                row.Height = (short)-1;
                var Cha = character.Attributes.Charisma;
                row.CreateCell(0).SetCellValue("Charisma: " + Cha);
                row.GetCell(0).CellStyle = style2;


                sheet1.AutoSizeColumn(0);
                sheet1.AutoSizeColumn(1);

                workbook.Write(fs);
            }

            return Json(new { fileName = fileName });
        }

        [HttpGet]
        public ActionResult Download(string fileName)
        {
            string path = fileName;
            byte[] fileByteArray = System.IO.File.ReadAllBytes(path);
            return File(fileByteArray, "application/vnd.ms-excel", fileName);
        }

        #region Enum Helpers
        // TODO: MAKE DEFAULT ENUM FOR THINGS CANNOT BE PARSED.
        private List<ProficiencyEnumModel> _getCharacterProfiencies(List<string> characterProficiencies)
        {
            var proficiency_list = new List<ProficiencyEnumModel>(); 
            foreach(var item in characterProficiencies)
            {
                var characterProficiency = EnumUtils.ParseEnum<ProficiencyEnumModel>(item);
                proficiency_list.Add(characterProficiency);
            }
            return proficiency_list;
        }

        // TODO: MAKE DEFAULT ENUM FOR THINGS CANNOT BE PARSED.
        private BackgroundEnumModel _getCharacterBackground(string backgroundName)
        {
            var character_background = EnumUtils.ParseEnum<BackgroundEnumModel>(backgroundName);
            return character_background;
        }

        // TODO: MAKE DEFAULT ENUM FOR THINGS CANNOT BE PARSED.
        private RaceEnumModel _getCharacterRace(string raceName)
        {
            var character_race = EnumUtils.ParseEnum<RaceEnumModel>(raceName);
            return character_race;
        }
        
        // TODO: MAKE DEFAULT ENUM FOR THINGS CANNOT BE PARSED.
        private CharacterClassEnumModel _getCharacterClass(string className)
        {
            var character_class = EnumUtils.ParseEnum<CharacterClassEnumModel>(className);
            return character_class;
        }
        #endregion
    }

}