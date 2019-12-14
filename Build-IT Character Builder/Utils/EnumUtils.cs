using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Character_Builder.Utils
{
    public class EnumUtils
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
