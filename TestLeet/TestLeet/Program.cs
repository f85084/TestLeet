using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeet
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { 11, 2, 15, 7 };
            int target = 9;
            int[] result = null;

            // First int means the excepted second value, the second int means the index of first value
            Dictionary<int, int> exceptValueMap = new Dictionary<int, int>();
                for (int index1 = 0; index1 < nums.Count(); index1++)
                {
                    // the value in array matches the excepted value
                    if (exceptValueMap.ContainsKey(nums[index1]))
                    {
                      result = new int[] { exceptValueMap[nums[index1]], index1 };
                    }
                    // check whether the value has already exist in the dictionary
                    else if (!exceptValueMap.ContainsKey(target - nums[index1]))
                    {
                        exceptValueMap.Add(target - nums[index1], index1);
                    }
                }
            for (int i = 0; i < 2; i++)
            Console.WriteLine(result[i]);
            Console.ReadLine();
            Console.ReadLine();





        }
    }
}
