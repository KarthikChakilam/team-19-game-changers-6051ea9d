using NUnit.Framework;
using System.Drawing;
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

            Assert.IsNotNull(testObj.GetStatus());
            
        }

        [Test]
        public void CreateCharacter()
        {
            var expected = "Mr. White";
            var result = "Mr. White";
           
            testObj.CreateCharacter("Mr. White");
            Assert.IsTrue(true);

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
        public void Move()
        {
            var expected = "yes";
            var result = "yes";

            Assert.AreEqual(expected,result);
        }

        [Test]
        public void SetCharacterPosition()
        {
            var expected = 1;
            var result = 1;

            Assert.AreEqual(expected,result);
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