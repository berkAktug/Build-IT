using Character_Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Internal
{
    public interface ISpells
    {
        List<SpellModel> GetSpellList(Data.ApplicationDbContext context, int PlayerLevel);
    }
}
