using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLeet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeet.Tests
{
    //Arrange: 初始化目標物件、相依物件、方法參數、預期結果，或是預期與相依物件的互動方式222
    //Act: 呼叫目標物件的方法
    //Assert: 驗證是否符合預期
    [TestClass()]
    public class ExcelSheetColumnNumberTaskTests
    {
        [TestMethod()]
        public void TitleToNumberTest_input_a_output_1()
        {
            ////arrange
            ExcelSheetColumnNumberTask target = new ExcelSheetColumnNumberTask();
            String s = "A";
            int expected = 1;

            ////act
            int actual;
            actual = target.TitleToNumber(s);

            ////assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TitleToNumberTest_input_zy_output_701()
        {
            ////arrange
            ExcelSheetColumnNumberTask target = new ExcelSheetColumnNumberTask();
            String s = "ZY";
            int expected = 701;

            ////act
            int actual;
            actual = target.TitleToNumber(s);

            ////assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TitleToNumberTest_input_abc_output_731()
        {
            ////arrange
            ExcelSheetColumnNumberTask target = new ExcelSheetColumnNumberTask();
            String s = "ABC";
            int expected = 731;

            ////act
            int actual;
            actual = target.TitleToNumber(s);

            ////assert
            Assert.AreEqual(expected, actual);

        }
    }
}