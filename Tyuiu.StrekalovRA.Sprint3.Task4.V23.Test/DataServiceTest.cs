using Tyuiu.StrekalovRA.Sprint3.Task4.V23.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DS = new DataService();
        [TestMethod]
        public void Test()
        {
            var A = DS.Calculate(-3, -1);
            Assert.AreEqual(A, 26.277);
        }
    }
}