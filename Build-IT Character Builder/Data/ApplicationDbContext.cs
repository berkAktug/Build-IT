using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Character_Builder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<CharacterClassFeature> CharacterClassFeatures { get; set; }

        public DbSet<SubClass> SubClasses { get; set; }
        public DbSet<SubClassFeature> SubClassFeatures { get; set; }

        public DbSet<Feat> Feats { get; set; }
        public DbSet<FeatFeature> FeatFeatures { get; set; }

        public DbSet<Race> Races { get; set; }
        public DbSet<RaceFeature> RaceFeatures { get; set; }

        public DbSet<Spell> Spells { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}
    }
}
