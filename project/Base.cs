using NUnit.Framework;
using System;
namespace nunitproject
{
   
    [SetUpFixture]
    public class Base
    {
        protected String driver = "hi";

        [OneTimeSetUp]
        public static void OneTimeSet() {
            TestContext.WriteLine("Before class");
            System.Console.WriteLine("Hello 2");
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown(){
            TestContext.WriteLine("After class");
            System.Console.WriteLine("Hello 2");
        }


       
        
    }
}
