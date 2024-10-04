using Tyuiu.StrekalovRA.Sprint3.Task0.V21.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var R = DS.GetSumSeries(1.5, 1, 13);
            Assert.AreEqual(-63.8, R);
        }
    }
}