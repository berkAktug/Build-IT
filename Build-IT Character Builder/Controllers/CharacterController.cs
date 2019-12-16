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

        private readonly UserManager<IdentityUser> _userManager;

        public CharacterController(Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
               
        public IActionResult CharacterBuilder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetupNewCharacter([FromBody] InsertCharacterModel newCharacter)
        {
            var charName = newCharacter.CharacterName;
            var charClass = _getCharacterClass(newCharacter.CharacterClassName);
            //var charLevel = newCharacter.CharacterLevel;
            var charBackground = _getCharacterBackground(newCharacter.CharacterBackground);
            var charRace = _getCharacterRace(newCharacter.CharacterRace);
            var charProficiency = _getCharacterProfiencies(newCharacter.CharacterProficiencies);
            var charAttributes = newCharacter.CharacterAttributes;

            var charToBuild = new NewCharacterModel
            {
                CharacterName = charName,
                CharacterBackground = charBackground,
                CharacterClass = charClass,
                //CharacterLevel = charLevel,
                CharacterLevel = 3,
                CharacterProficiencies = charProficiency,
                CharacterRace = charRace,
                CharacterAttributes = charAttributes
            };

            Character newChar = new Character();

            newChar.SetupCharacter(charToBuild);


            //var rand = new Random();

            //IdentityUser current_user = await _userManager.FindByEmailAsync(User.Identity.Name);

            //// Create Character
            //var id_character = rand.Next();
            //var data_character = new Data.Character
            //{
            //    Id = id_character,

            //    FeatId = _context.Feats.FirstOrDefault().Id,
            //    CharacterClassId = _context.CharacterClasses.FirstOrDefault().Id,
            //    RaceId = _context.Races.FirstOrDefault().Id,
            //    SubClassId = _context.SubClasses.FirstOrDefault().Id,

            //    UserId = current_user.Id,
            //    Name = "Testbug",

            //    AC = 15,
            //    HP = 20,
            //    AttribStr = 15,
            //    AttribDex = 15,
            //    AttribCon = 15,
            //    AttribInt = 15,
            //    AttribWis = 15,
            //    AttribCha = 15,
            //};

            //_context.Characters.Add(data_character);

            //_context.SaveChanges();

            return new JsonResult(new { isSuccess = true });
        }

        #region Enum Helpers
        // TODO: MAKE DEFAULT ENUM FOR THINGS CANNOT BE PARSED.
        private List<CharacterProficiencyEnumModel> _getCharacterProfiencies(List<string> characterProficiencies)
        {
            var proficiency_list = new List<CharacterProficiencyEnumModel>(); 
            foreach(var item in characterProficiencies)
            {
                var characterProficiency = EnumUtils.ParseEnum<CharacterProficiencyEnumModel>(item);
                proficiency_list.Add(characterProficiency);
            }
            return proficiency_list;
        }

        // TODO: MAKE DEFAULT ENUM FOR THINGS CANNOT BE PARSED.
        private CharacterBackgroundEnumModel _getCharacterBackground(string backgroundName)
        {
            var character_background = EnumUtils.ParseEnum<CharacterBackgroundEnumModel>(backgroundName);
            return character_background;
        }

        // TODO: MAKE DEFAULT ENUM FOR THINGS CANNOT BE PARSED.
        private CharacterRaceEnumModel _getCharacterRace(string raceName)
        {
            var character_race = EnumUtils.ParseEnum<CharacterRaceEnumModel>(raceName);
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