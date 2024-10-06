using Tyuiu.StrekalovRA.Sprint3.Task7.V30.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var R = DS.GetMassFunction(1, 4);
            double[] Values_ = new double[4 - 1 + 1] { 6.64, 10.3, 16.17, 28.1 };
            CollectionAssert.AreEqual(Values_, R);
        }
    }
}