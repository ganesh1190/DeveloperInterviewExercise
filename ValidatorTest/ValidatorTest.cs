using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidatorTest
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Validator v = new Validator();
            var isvalid =v.isValid("-v");
            Assert.IsTrue(Validator.Type.version== isvalid);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Validator v = new Validator();
            var isvalid = v.isValid("--v");
            Assert.IsTrue(Validator.Type.version == isvalid);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Validator v = new Validator();
            var isvalid = v.isValid("/v");
            Assert.IsTrue(Validator.Type.version== isvalid);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Validator v = new Validator();
            var isvalid = v.isValid("-s");
            Assert.IsTrue(Validator.Type.size== isvalid);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Validator v = new Validator();
            var isvalid = v.isValid("--s");
            Assert.IsTrue(Validator.Type.size == isvalid);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Validator v = new Validator();
            var isvalid = v.isValid("/s");
            Assert.IsTrue(Validator.Type.size == isvalid);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Validator v = new Validator();
            var isvalid = v.isValid("invalidString");
            Assert.IsTrue(Validator.Type.InValid == isvalid);
        }

    }
}
