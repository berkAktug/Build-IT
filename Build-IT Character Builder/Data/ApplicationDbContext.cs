using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Character_Builder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<CharacterClassFeature> CharacterClassFeatures { get; set; }

        public DbSet<Race> Races { get; set; }
        public DbSet<RaceFeature> RaceFeatures { get; set; }

        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<BackgroundFeature> BackgroundFeatures { get; set; }

        public DbSet<CharacterSpell> CharacterSpells { get; set; }
        public DbSet<Spell> Spells { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CharacterSpell>().HasKey(cs => new { cs.CharacterId, cs.SpellId});
        }
    }
}
