using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0;
                double result = ConsoleApp1.Program.Example(x);
            Assert.AreEqual(10, result);
        }
    }
} 