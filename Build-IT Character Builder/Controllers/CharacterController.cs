using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Character_Builder.Internal;
using Character_Builder.Models;
using Character_Builder.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
            //var charLevel = newCharacter.CharacterLevel;
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
                //CharacterLevel = charLevel,
                CharacterLevel = 3,
                CharacterProficiencies = charProficiency,
                CharacterRace = charRace,
                CharacterAttributes = attrib
            };

            Character newChar = new Character(_context);

            CharacterModel finishedCharacter = newChar.SetupCharacter(charToBuild);

            // Adjust excel according to finished Character
            newChar.saveToExcel(charToBuild);

            return new JsonResult(new { isSuccess = true });
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