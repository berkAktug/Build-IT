using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Character_Builder.Behavioural;
using Character_Builder.Models;
using Microsoft.AspNetCore.Mvc;

namespace Character_Builder.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult CharacterBuilder()
        {
            return View();
        }

        public IActionResult TestBuilder()
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

            Character newChar = new Character();

            newChar.SetCharacter(newCharacter);


            return new JsonResult(new { isSuccess = true });
        }


        #region Enum Helpers
        private CharacterProficiencyModel _getCharacterProfiencies(List<string> characterProficiencies)
        {
            var proficiencies = new CharacterProficiencyModel
            {
                isArcana = false,
                isHistory = false,
                isInvestigation = false,
                isNature = false,
                isReligion = false,
                isAnimalHandling = false,
                isInsight = false,
                isMedicine = false,
                isPerception = false,
                isSurvival = false,
                isDeception = false,
                isIntimidation = false,
                isPerformance = false,
                isPersuasion = false,
                isAthletics = false,
                isAcrobatics = false,
                isSleightOfHand = false,
                isStealth = false,
                isInitiative = false
            };

            foreach (var item in characterProficiencies)
            {
                switch (item)
                {
                    case "Arcana":
                        proficiencies.isArcana = true;
                        break;
                    case "History":
                        proficiencies.isHistory = true;
                        break;
                    case "Investigation":
                        proficiencies.isInvestigation = true;
                        break;
                    case "Nature":
                        proficiencies.isNature = true;
                        break;
                    case "Religion":
                        proficiencies.isReligion = true;
                        break;
                    case "AnimalHandling":
                        proficiencies.isAnimalHandling = true;
                        break;
                    case "Insight":
                        proficiencies.isInsight = true;
                        break;
                    case "Medicine":
                        proficiencies.isMedicine = true;
                        break;
                    case "Survival":
                        proficiencies.isSurvival = true;
                        break;
                    case "Deception":
                        proficiencies.isDeception = true;
                        break;
                    case "Intimidation":
                        proficiencies.isIntimidation = true;
                        break;
                    case "Performances":
                        proficiencies.isPerformance = true;
                        break;
                    case "Persuasion":
                        proficiencies.isPersuasion = true;
                        break;
                    case "Athletics":
                        proficiencies.isAthletics = true;
                        break;
                    case "Acrobatics":
                        proficiencies.isAcrobatics = true;
                        break;
                    case "SleightOfHand":
                        proficiencies.isSleightOfHand = true;
                        break;
                    case "Stealth":
                        proficiencies.isStealth = true;
                        break;
                    case "Initiative":
                        proficiencies.isInitiative = true;
                        break;
                }
            }

            return proficiencies;
        }


        private CharacterBackgroundEnumModel _getCharacterBackground(string backgroundName)
        {
            switch (backgroundName)
            {
                case "Acolyte":
                    return CharacterBackgroundEnumModel.Acolyte;
                case "Artisan":
                    return CharacterBackgroundEnumModel.Artisan;
                case "BountyHunter":
                    return CharacterBackgroundEnumModel.BountyHunter;
                case "Charlatan":
                    return CharacterBackgroundEnumModel.Charlatan;
                case "Criminal":
                    return CharacterBackgroundEnumModel.Criminal;
                case "Entertainer":
                    return CharacterBackgroundEnumModel.Entertainer;
                case "FarTraveler":
                    return CharacterBackgroundEnumModel.FarTraveler;
                case "FolkHero":
                    return CharacterBackgroundEnumModel.FolkHero;
                case "GuildArtisan":
                    return CharacterBackgroundEnumModel.GuildArtisan;
                case "Hermit":
                    return CharacterBackgroundEnumModel.Hermit;
                case "Noble":
                    return CharacterBackgroundEnumModel.Noble;
                case "Outlander":
                    return CharacterBackgroundEnumModel.Outlander;
                case "Sage":
                    return CharacterBackgroundEnumModel.Sage;
                case "Sailor":
                    return CharacterBackgroundEnumModel.Sailor;
                case "Soldier":
                    return CharacterBackgroundEnumModel.Soldier;
                case "SpiritReaver":
                    return CharacterBackgroundEnumModel.SpiritReaver;
                case "Urchin":
                    return CharacterBackgroundEnumModel.Urchin;
            }
            return CharacterBackgroundEnumModel.NONE;
        }

        private CharacterRaceEnumModel _getCharacterRace(string raceName)
        {
            switch (raceName)
            {
                case "Dragonborn":
                    return CharacterRaceEnumModel.Dragonborn;
                case "Dwarf":
                    return CharacterRaceEnumModel.Dwarf;
                case "Elf":
                    return CharacterRaceEnumModel.Elf;
                case "Gnome":
                    return CharacterRaceEnumModel.Gnome;
                case "Half_Elf":
                    return CharacterRaceEnumModel.Half_Elf;
                case "Half_Orc":
                    return CharacterRaceEnumModel.Half_Orc;
                case "Halfling":
                    return CharacterRaceEnumModel.Halfling;
                case "Human":
                    return CharacterRaceEnumModel.Human;
                case "Tiefling":
                    return CharacterRaceEnumModel.Tiefling;
            }
            return CharacterRaceEnumModel.NONE;
        }

        private CharacterClassEnumModel _getCharacterClass(string className)
        {
            switch (className)
            {
                case "Barbarian":
                    return CharacterClassEnumModel.Barbarian;
                case "Bard":
                    return CharacterClassEnumModel.Bard;
                case "Cleric":
                    return CharacterClassEnumModel.Cleric;
                case "Druid":
                    return CharacterClassEnumModel.Druid;
                case "Fighter":
                    return CharacterClassEnumModel.Fighter;
                case "Monk":
                    return CharacterClassEnumModel.Monk;
                case "Paladin":
                    return CharacterClassEnumModel.Paladin;
                case "Ranger":
                    return CharacterClassEnumModel.Ranger;
                case "Rogue":
                    return CharacterClassEnumModel.Rogue;
                case "Sorcerer":
                    return CharacterClassEnumModel.Sorcerer;
                case "Warlock":
                    return CharacterClassEnumModel.Warlock;
                case "Wizard":
                    return CharacterClassEnumModel.Wizard;
            }

            return CharacterClassEnumModel.NONE;
        }
        #endregion
    }

}