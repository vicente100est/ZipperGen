using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace zipper.tests
{
    [TestClass]
    public class ZipperTest
    {
        [TestMethod]
        public void ZippThrowsExceptionOnInvalidTarget()
        {
            Assert.ThrowsException<System.IO.DirectoryNotFoundException>(() => {
                zipper.ZipperLogic.Zip("", ":::");
            });
        }
    }
}
