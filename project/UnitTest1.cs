using NUnit.Framework;

namespace nunitproject
{
    [TestFixture]
    public class UnitTest1 : Base
    {


        [Test]
        public void TestMethod1()
        {
            System.Diagnostics.Process.Start("/bin/bash", "ls -al");
        }


        [TearDown]
        public void x()
        {
            System.Console.WriteLine("After method");
        }

        [SetUp]
        public void y()
        {

            System.Console.WriteLine("Before method ");
        }

    }
}
