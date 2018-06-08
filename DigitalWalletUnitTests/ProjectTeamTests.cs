using System;
using NUnit.Framework;
using DigitalWalletClassLib;
using DigitalWalletUnitTests.Mocking;

namespace DigitalWalletUnitTests
{
    [TestFixture]
    public class ProjectTeamTests
    {
        private ProjectTeam fpt;

        [SetUp]
        public void SetUp()
        {
            fpt = new FakeProjectTeam("9009", "Salt Lake", "9876");
        }
        [Test]
        public void ProjectTeam_Constructor_IsCalled_AttributesSet()
        {
            Assert.AreEqual("9009", fpt._teamID);
            Assert.AreEqual("Salt Lake", fpt._teamName);
            Assert.AreEqual("9876", fpt._accountNo);

        }
    }
}
