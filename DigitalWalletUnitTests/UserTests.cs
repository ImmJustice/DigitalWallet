using System;
using NUnit.Framework;
using DigitalWalletClassLib;
using DigitalWalletUnitTests.Mocking;

namespace DigitalWalletUnitTests
{
    [TestFixture]
    public class UserTests
    {
        private User fu, fu2;
        private ProjectTeam fpt;

        [SetUp]
        public void Setup()
        {
            fu = new FakeUser("1234", "FakeFirstName", "FakeLastName", "0400 000 000", "1001", "Teacher");
            fu2 = new FakeUser("4321", "FakeStudentName", "FakeStudentSurname", "0444 444 444", "2002", "Student");

            fpt = new FakeProjectTeam("9009", "Salt Lake", "9876");
        }
        [Test]
        [Ignore("Test To Ignore")]
        public void Test_To_Ignore()
        {
        }
        [Test]
        public void User_Constructor_IsCalled_AttributesSet()
        {
            //Test for Teacher
            Assert.AreEqual("1234", fu._accountNo);
            Assert.AreEqual("FakeFirstName", fu._firstName);
            Assert.AreEqual("FakeLastName", fu._lastName);
            Assert.AreEqual("0400 000 000", fu._phoneNo);
            Assert.AreEqual("1001", fu._userID);
            Assert.AreEqual("Teacher", fu._userType);

            //Tests for Student
            Assert.AreEqual("4321", fu2._accountNo);
            Assert.AreEqual("FakeStudentName", fu2._firstName);
            Assert.AreEqual("FakeStudentSurname", fu2._lastName);
            Assert.AreEqual("0444 444 444", fu2._phoneNo);
            Assert.AreEqual("2002", fu2._userID);
            Assert.AreEqual("Student", fu2._userType);
        }
        [Test]
        public void CreateProjectTeam_IsCalled_UserType_IsStudent()
        {
            try
            {
                fu2.CreateProjectTeam();
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Contains("You do not have permission to do that"));
            }
            
        }
    }
}
