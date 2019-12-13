using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Character_Builder.Models;

// FOR USER IDENTITY
using Microsoft.AspNetCore.Identity;

namespace Character_Builder.Controllers
{
    public class HomeController : Controller
    {
        private readonly Data.ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public async Task<IActionResult> ContactAsync()
        {
            ViewData["Message"] = "Your contact page.";

            var rand = new Random();

            //var id_feat = rand.Next();
            //var data_feat = new Data.Feat
            //{
            //    Id = id_feat,
            //    Name = "Mobile Feat",
            //    Description = "Makes you run fastteeeeeeerr"
            //};

            //_context.Feats.Add(data_feat);

            //var id_feature_feat = rand.Next();
            //var data_featfeature = new Data.FeatFeature
            //{
            //    Id = id_feature_feat,
            //    FeatId = id_feat,
            //    Name = "Mobile",
            //    Description = "Run you fools",
            //};

            ////data_featfeature.FeatId = _context.Feats.FirstOrDefault().Id;

            //_context.FeatFeatures.Add(data_featfeature);

            ////_context.SaveChanges();

            ////Create SubClass
            //var id_subclass = rand.Next();
            //var data_subclass = new Data.SubClass
            //{
            //    Id = id_subclass,
            //    Name = "New Sub class",
            //    Description = " New Sub Class Description"
            //};

            //// Create SubClassFeature
            //var id_feature_subclass = rand.Next();
            //var data_subclassfeature = new Data.SubClassFeature
            //{
            //    Id = id_feature_subclass,
            //    SubClassId = id_subclass,
            //    Description = "new Sub class Feature Description",
            //    Name = "New sub class feature",
            //    LevelRequirement = 0
            //};
            //data_subclassfeature.SubClass = data_subclass;

            ////data_subclass.Features.Add(data_subclassfeature);
            //_context.SubClasses.Add(data_subclass);
            //_context.SubClassFeatures.Add(data_subclassfeature);


            //var id_race = rand.Next();
            //// Create Race
            //var data_race = new Data.Race
            //{
            //    Id = id_race,
            //    Name = "Elf",
            //    Description = "Göttürler"
            //};

            //_context.Races.Add(data_race);

            //var id_racefeature = rand.Next();
            //// Create Race Feature
            //var data_racefeature = new Data.RaceFeature
            //{
            //    Id = id_racefeature,
            //    Name = "Darkvision",
            //    Description = "30ft darkvision",
            //    RaceId = id_race
            //};

            //_context.RaceFeatures.Add(data_racefeature);

            //var id_class = rand.Next();
            //// Create Class
            //var data_class = new Data.CharacterClass
            //{
            //    Id = id_class,
            //    Name = "Fighter",
            //    Description = "He who fights."
            //};
            //_context.CharacterClasses.Add(data_class);

            //// Create Feature
            //var id_feature_class = rand.Next();
            //var data_classfeature = new Data.CharacterClassFeature
            //{
            //    Id = id_feature_class,
            //    CharacterClassId = id_class,
            //    Name = "Second Wind",
            //    Description = "HEals things..",
            //    LevelRequirement = 1,
            //    //CharacterClass = data_class
            //};

            //_context.CharacterClassFeatures.Add(data_classfeature);

            ////_context.CharacterClasses.Find(id_class).CharacterClassFeatures.Add(data_classfeature);

            //var id_spell = rand.Next();
            //// Create spell
            //var data_spell = new Data.Spell
            //{
            //    Id = id_spell,
            //    Level = 0,
            //    Name = "Minor illusion",
            //    Components = "S",
            //    Description = "Does things.",
            //    Duration = 0,
            //    DurationType = "instant",
            //    Range = 30,
            //    RangeType = "ft",
            //    School = "Illusion",
            //};
            //_context.Spells.Add(data_spell);

            IdentityUser current_user = await _userManager.FindByEmailAsync(User.Identity.Name);

            // Create Character
            var id_character = rand.Next();
            var data_character = new Data.Character
            {
                Id = id_character,
                //FeatId = id_feat,
                //CharacterClassId = id_class,
                //RaceId = id_race,
                //SubClassId = id_subclass,

                FeatId = _context.Feats.FirstOrDefault().Id,
                CharacterClassId = _context.CharacterClasses.FirstOrDefault().Id,
                RaceId = _context.Races.FirstOrDefault().Id,
                SubClassId = _context.SubClasses.FirstOrDefault().Id,

                // TEMPORARY SOLUTION
                UserId = current_user.Id,
                Name = "Testbug",

                AC = 15,
                HP = 20,
                AttribStr = 15,
                AttribDex = 15,
                AttribCon = 15,
                AttribInt = 15,
                AttribWis = 15,
                AttribCha = 15,

                //Feat = data_feat,
                //Race = data_race,
                //SubClass = data_subclass,
                //CharacterClass = data_class,
            };

            _context.Characters.Add(data_character);

            _context.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
