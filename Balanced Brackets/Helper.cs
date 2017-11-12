using System;
using System.Collections.Generic;
using System.Text;

namespace Balanced_Brackets
{
    internal static class Helper
    {
        public static bool Contains(this char[] array, char input)
        {
            foreach (var val in array)
            {
                if (val == input)
                    return true;
            }

            return false;
        }
    }
}
