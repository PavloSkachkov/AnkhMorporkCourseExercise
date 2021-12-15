using AnkhMorporkCourseExercise.Models;
using NUnit.Framework;

namespace AnkhMorporkCourseExercise.Tests
{
    [TestFixture]
    class PlayerTest
    {
        private Player _player;

        [SetUp]
        public void SetUp()
        {
            _player = new Player();
        }

        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(1, 0.1, 1.1)]
        [TestCase(1, 0, 1)]
        public void Player_IncreaseMoneyAmount_WhenCalled(decimal a, decimal b, decimal expectedResult)
        {
            _player.CurrentMoneyAmount = a;
            _player.IncreaseMoneyAmount(b);

            Assert.That(_player.CurrentMoneyAmount, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(1, 1, 0)]
        [TestCase(1, 0.1, 0.9)]
        [TestCase(1, 0, 1)]
        public void Player_DecreaseMoneyAmount_WhenCalled(decimal a, decimal b, decimal expectedResult)
        {
            _player.CurrentMoneyAmount = a;
            _player.DecreaseMoneyAmount(b);

            Assert.That(_player.CurrentMoneyAmount, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(0)]
        public void Player_Kill_WhenCalled(decimal expectedResult)
        {
            _player.Kill();

            Assert.That(_player.CurrentMoneyAmount, Is.EqualTo(expectedResult));
        }
    }
}
