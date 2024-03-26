using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class MathLibrary
    {
        public static List<int> GetLeapYears(int start, int end)
        {
            var leapYears = new List<int>();
            int jump = 1;
            for (var year = start; year <= end; year += jump)
            {
                if (IsLeapYear(year))
                {
                    leapYears.Add(year);
                    jump = (jump != 4) ? 4 : jump;
                }
            }
            return leapYears;
        }
        
        public static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
