using Tyuiu.StrekalovRA.Sprint3.Task1.V23.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var K = DS.GetMultiplySeries(5, 1, 5);
            Assert.AreEqual(K, 0.071);
        }
    }
}