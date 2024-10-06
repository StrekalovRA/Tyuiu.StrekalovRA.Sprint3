using Tyuiu.StrekalovRA.Sprint3.Task6.V4.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DS = new DataService();
        [TestMethod] public void TestMethod1() { Assert.AreEqual(8, DS.GetSumTheDivisors(14, 20)); }
        [TestMethod] public void TestMethod2() { Assert.AreEqual(12, DS.GetSumTheDivisors(1, 20)); }
        [TestMethod] public void TestMethod3() { Assert.AreEqual(73, DS.GetSumTheDivisors(40, 70)); }
        [TestMethod] public void TestMethod4() { Assert.AreEqual(4046, DS.GetSumTheDivisors(100, 1000)); }
    }
}