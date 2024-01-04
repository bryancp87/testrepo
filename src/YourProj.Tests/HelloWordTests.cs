using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.AWS.Tests
{
    [TestClass]
    public class HelloWordTests
    {
        [TestMethod]
        public void Class1_Add_Test()
        {
            // Arrange
            var hw = new HelloWord();
            // Act
            var actual = hw.SayIt();

            // Assert
            Assert.AreEqual("Hello, world!", actual);
        }
    }
}
