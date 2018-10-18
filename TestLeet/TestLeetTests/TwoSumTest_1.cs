using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLeet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestLeetTests
{
    [TestClass()]
    public class TwoSumTest_1
    {
        //Arrange: 初始化目標物件、相依物件、方法參數、預期結果，或是預期與相依物件的互動方式
        //Act: 呼叫目標物件的方法
        //Assert: 驗證是否符合預期
            [TestMethod()]
            public void TwoSumTestTest_input_2_7_11_15_output_9()
            {
                ////arrange
                Two_Sum solution = new Two_Sum();

                int[] array = new int[] { 2, 7, 11, 15 };
                int target = 9;

                ////act
                int[] result = solution.GetSolution(array, target);

                ////assert
                Assert.IsTrue(result.Contains(0));
                Assert.IsTrue(result.Contains(1));


            }
        }
    }