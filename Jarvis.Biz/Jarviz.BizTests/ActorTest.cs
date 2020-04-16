using NUnit.Framework;
using Jarvis.Biz;

namespace Jarviz.BizTests
{
    public class ActorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetOccupation()
        {
            //Arrange
            var currentActor = new Actor();
            var expected = "Actor";

            //Act
            var actual = currentActor.GetOccupation();

            //Assert         
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestParameterizedConstructor()
        {
            // Arrange
            var currentActor = new Actor("Johnny Boy");
            var expectedValue = "Johnny Boy";

            // Act
            var result = currentActor?.ActorName;

            // Assert
            Assert.AreEqual(expectedValue, result);


        }
    }
}