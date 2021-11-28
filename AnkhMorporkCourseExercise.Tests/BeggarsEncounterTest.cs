using System;
using Moq;
using NUnit.Framework;

namespace AnkhMorporkCourseExercise.Tests
{
    [TestFixture]
    public class BeggarsEncounterTest
    {
        public BeggarsEncounter BeggarsEncounter;
        private Beggar[] beggars = new[] { new Beggar("Twitcher", 3) };
       
        public BeggarsEncounterTest()
        {
            Mock<Random> rnd = new Mock<Random>();
            rnd.Setup(r => r.Next(0, 11)).Returns(0);
            BeggarsEncounter = new BeggarsEncounter(beggars, rnd.Object);
        }

        [Test]
        public void Decline_PlayerIsNull_ThrowsException()
        {
            Player player = null;
            Assert.Throws(typeof(NullReferenceException), () => BeggarsEncounter.Decline(player));
        }

        [Test]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(0, ExpectedResult = 0)]
        public double Decline_WhenCalled_ZeroMoneyAmount(int moneyAmount)
        {
            Player player = new Player();
            player.moneyAmount = moneyAmount;

            BeggarsEncounter.Decline(player);
            return player.moneyAmount;
        }

        [Test]
        public void Acception_WhenCalles_Success()
        {
            Player player = new Player();

            BeggarsEncounter.Acception(player);
            Assert.That(player.moneyAmount == 97);
        }
    }
}
