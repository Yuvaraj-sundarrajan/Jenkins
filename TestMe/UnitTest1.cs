using jendemo;
namespace TestMe
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Testme obj1 = new Testme();
            string Result = obj1.SayJenkins(2);
            Assert.AreEqual("Hello JenkinsHello Jenkins",Result);
        }

        [Test]
        public void Test2()
        {
            Testme obj1 = new Testme();
            string Result = obj1.SayJenkins(1);
            Assert.AreEqual("Hello Jenkins", Result);
        }
    }
}