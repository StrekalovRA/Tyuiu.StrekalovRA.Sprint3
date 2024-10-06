using Tyuiu.StrekalovRA.Sprint3.Task5.V6.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DS = new DataService();
        [TestMethod]
        public void Test() {
            var A = DS.GetSumSumSeries(1, 1, 3, 10);
            Assert.AreEqual(A, 40.917);
        }
    }
}