using Tyuiu.StrekalovRA.Sprint3.Task3.V6.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DS = new DataService();
        [TestMethod]
        public void Test()
        {
            var A = DS.ReplaceNumOnChar("rr4 h10 a", 'a');
            Assert.AreEqual(A, "rra haa a");
        }
    }
}