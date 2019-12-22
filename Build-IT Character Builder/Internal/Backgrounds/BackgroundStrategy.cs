using Character_Builder.Models;
using Character_Builder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public class BackgroundMethod
    {
        private IBackground _backgroundStrategy;

        public void SetBackgroundWithName(string backgroundName)
        {
            var character_background = EnumUtils.ParseEnum<BackgroundEnumModel>(backgroundName);
            SetBackground(character_background);
        }

        public void SetBackground(BackgroundEnumModel backgroundEnum)
        {
            switch (backgroundEnum)
            {
                case BackgroundEnumModel.Acolyte:
                    _backgroundStrategy = new AcolyteBackground();
                    break;
                case BackgroundEnumModel.Archaeologist:
                    _backgroundStrategy = new ArchaeologistBackground();
                    break;
                case BackgroundEnumModel.BountyHunter:
                    _backgroundStrategy = new BountyHunterBackground();
                    break;
                case BackgroundEnumModel.Charlatan:
                    _backgroundStrategy = new CharlatanBackground();
                    break;
                case BackgroundEnumModel.Criminal:
                    _backgroundStrategy = new CriminalBackground();
                    break;
                case BackgroundEnumModel.Entertainer:
                    _backgroundStrategy = new EntertainerBackground();
                    break;
                case BackgroundEnumModel.FarTraveler:
                    _backgroundStrategy = new FarTravellerBackground();
                    break;
                case BackgroundEnumModel.FolkHero:
                    _backgroundStrategy = new FolkHeroBackground();
                    break;
                case BackgroundEnumModel.GuildArtisan:
                    _backgroundStrategy = new GuildArtisanBackground();
                    break;
                case BackgroundEnumModel.Hermit:
                    _backgroundStrategy = new HermitBackground();
                    break;
                case BackgroundEnumModel.Noble:
                    _backgroundStrategy = new NobleBackground();
                    break;
                case BackgroundEnumModel.Outlander:
                    _backgroundStrategy = new OutlanderBackground();
                    break;
                case BackgroundEnumModel.Sage:
                    _backgroundStrategy = new SageBackground();
                    break;
                case BackgroundEnumModel.Sailor:
                    _backgroundStrategy = new SailorBackground();
                    break;
                case BackgroundEnumModel.Soldier:
                    _backgroundStrategy = new SoldierBackground();
                    break;
                case BackgroundEnumModel.StojanowPrisoner:
                    _backgroundStrategy = new StojanowPrisonerBackground();
                    break;
                case BackgroundEnumModel.Urchin:
                    _backgroundStrategy = new UrchinBackground();
                    break;
                case BackgroundEnumModel.NONE:
                default:
                    new NotImplementedException();
                    break;
            }
        }

        public void ApplyBackground(List<ProficiencyEnumModel> proficiencyList)
        {
            _backgroundStrategy.ApplyProficiency(proficiencyList);
        }

        public List<FeatureModel> GetFeatureList(Data.ApplicationDbContext context)
        {
            return _backgroundStrategy.GetFeatureList(context);
        }
    }
}
