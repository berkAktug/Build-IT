using System;
using System.Collections.Generic;
using System.Linq;
using Character_Builder.Data;
using Character_Builder.Models;
using Character_Builder.Utils;

namespace Character_Builder.Internal
{
    public class DragornbornRace : IRace
    {
        public void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Strength, true, 2);
            RaceHelper.AdjustAttribute(characterAttributes.Charisma, true, 1);
        }

        public void ApplyProficiency(List<ProficiencyEnumModel> characterProficiencies)
        { }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureList(context, RaceEnumModel.Dragonborn.ToString());
        }

        public List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = new DragonbornSpells();
            return spellHelper.GetSpellList(context, 0);
        }
    }

    public class DwarfRace : IRace
    {
        public void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Constitution, true, 2);
        }
        public void ApplyProficiency(List<ProficiencyEnumModel> characterProficiencies)
        { }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureList(context, RaceEnumModel.Dwarf.ToString());
        }

        public List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }

    public class ElfRace : IRace
    {
        public void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Dexterity, true, 2);
        }

        public void ApplyProficiency(List<ProficiencyEnumModel> characterProficiencies)
        {
            RaceHelper.AddProficiency(characterProficiencies, ProficiencyEnumModel.Perception);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureList(context, RaceEnumModel.Elf.ToString());
        }

        public List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = new ElfSpells();
            return spellHelper.GetSpellList(context, 0);
        }
    }

    public class GnomeRace : IRace
    {
        public void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Intelligence, true, 2);
        }

        public void ApplyProficiency(List<ProficiencyEnumModel> characterProficiencies)
        { }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureList(context, RaceEnumModel.Gnome.ToString());
        }

        public List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }

    public class HalfElfRace : IRace
    {
        public void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            // Temporary Solution as officially half elfs can choice their attribute bonueses.
            RaceHelper.AdjustAttribute(characterAttributes.Dexterity, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Wisdom, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Charisma, true, 2);
        }

        public void ApplyProficiency(List<ProficiencyEnumModel> characterProficiencies)
        {
            // Temporary Solution as officially half elfs can choice their attribute bonueses.
            RaceHelper.AddProficiency(characterProficiencies, ProficiencyEnumModel.Perception);
            RaceHelper.AddProficiency(characterProficiencies, ProficiencyEnumModel.Persuasion);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureList(context, RaceEnumModel.Half_Elf.ToString());
        }

        public List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }

    public class HalfOrcRace : IRace
    {
        public void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Strength, true, 2);
            RaceHelper.AdjustAttribute(characterAttributes.Constitution, true, 1);
        }

        public void ApplyProficiency(List<ProficiencyEnumModel> characterProficiencies)
        {
            RaceHelper.AddProficiency(characterProficiencies, ProficiencyEnumModel.Intimidation);
        }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureList(context, RaceEnumModel.Half_Orc.ToString());
        }

        public List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }

    public class HalflingRace : IRace
    {
        public void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Dexterity, true, 2);
        }

        public void ApplyProficiency(List<ProficiencyEnumModel> characterProficiencies)
        { }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureList(context, RaceEnumModel.Halfling.ToString());
        }

        public List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = new HalflingSpells();
            return spellHelper.GetSpellList(context, 0);

        }
    }

    public class HumanRace : IRace
    {
        public void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Strength, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Dexterity, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Constitution, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Intelligence, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Wisdom, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Charisma, true, 1);
        }

        public void ApplyProficiency(List<ProficiencyEnumModel> characterProficiencies)
        { }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureList(context, RaceEnumModel.Human.ToString());
        }

        public List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }

    public class TieflingRace : IRace
    {
        public void ApplyAttribute(CharacterAttributesModel characterAttributes)
        {
            RaceHelper.AdjustAttribute(characterAttributes.Intelligence, true, 1);
            RaceHelper.AdjustAttribute(characterAttributes.Charisma, true, 2);
        }

        public void ApplyProficiency(List<ProficiencyEnumModel> characterProficiencies)
        { }

        public List<FeatureModel> GetFeatureList(ApplicationDbContext context)
        {
            return RaceHelper.GetFeatureList(context, RaceEnumModel.Tiefling.ToString());
        }

        public List<SpellModel> GetSpellList(ApplicationDbContext context)
        {
            var spellHelper = NullSpells.Instance;
            return spellHelper;
        }
    }


}
