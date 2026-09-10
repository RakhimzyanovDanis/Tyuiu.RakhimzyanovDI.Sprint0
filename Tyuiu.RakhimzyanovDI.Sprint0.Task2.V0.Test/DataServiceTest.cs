using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RakhimzyanovDI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.RakhimzyanovDI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Данис";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Данис", res);
        }
    }
}
