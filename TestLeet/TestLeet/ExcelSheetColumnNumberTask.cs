using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeet
{
    public class ExcelSheetColumnNumberTask
    {
        /// <summary>
        /// Given a column title as appear in an Excel sheet, return its corresponding column number.
        ///  For example:  
        ///     A -> 1   ,   B -> 2 ,    C -> 3
        ///     Z -> 26 AA -> 27  AB -> 28 
        ///     Case 1 Input "A" Output 1
        ///     Case 2 Input "AB Output 28
        ///     Case 3 Input "ZY" Output 701
        ///     ABC = 1x26^2 + 2x26^1 + 3  
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// 
        public int TitleToNumber(string s)
        {
            int result = 0;
            int diff = 'A' - 1; //65 -1 = 64

            int temp = 'Z' - 'A' + 1;

            for (int i = 0; i < s.Length; i++)
            {
                int x = (int)s[i] - diff;

                //result += x * Convert.ToInt32(Math.Pow(temp, s.Length - i - 1));
                result += (int)(x * Math.Pow(temp, s.Length - i - 1));

            }

            return result;
        }

    }
}
