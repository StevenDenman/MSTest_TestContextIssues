using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTestContextIssues
{
    [TestClass]
    public class UnitTest3
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            var text = $"{this.GetType().Name} - {System.Reflection.MethodBase.GetCurrentMethod()?.Name}";
            System.Console.WriteLine($"Std: {text}");
            TestContext.WriteLine($"TC: {text}");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var text = $"{this.GetType().Name} - {System.Reflection.MethodBase.GetCurrentMethod()?.Name}";
            System.Console.WriteLine($"Std: {text}");
            TestContext.WriteLine($"TC: {text}");
        }
    }
}