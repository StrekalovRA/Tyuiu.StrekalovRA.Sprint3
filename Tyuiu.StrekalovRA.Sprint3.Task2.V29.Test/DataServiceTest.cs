using Tyuiu.StrekalovRA.Sprint3.Task2.V29.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var R = DS.GetSumSeries(0.5, 1, 18);
            Assert.AreEqual(-0.186, R);
        }
    }
}