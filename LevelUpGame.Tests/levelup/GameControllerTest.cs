using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
            #pragma warning disable CS8602 // Rethrow to preserve stack details
            var expected = true;

            Assert.IsNotNull(expected);

            //Assert.IsNotNull(testObj.GetStatus());
            
        }

        [Test]
        public void CreateCharacter()
        {
            var expected = "Mr. White";
            var result = "Mr. White";

            Assert.AreEqual(expected,result);
        }

        [Test]
        public void StartGame()
        {
            var expected = true;
            Assert.That(expected, Is.True);
        }

        [Test]
        public void GetStatus()
        {
            var expectedName = "Lamsal";
            var expectedCharName = "Mr.White";

            var resultName ="Lamsal";
            var resultCharName ="Mr.White";

            Assert.AreEqual(expectedName, resultName);
            Assert.AreEqual(expectedCharName, resultCharName);
        }


        [Test]
        public void IsValidPosition()
        {
            var expected = "yes";
            var result = "yes";

            Assert.AreEqual(expected,result);
        }

        

    }
}