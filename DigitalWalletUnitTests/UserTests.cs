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
        public void CreateProjectTeam_IsCalled_UserType_IsTeacher()
        {
            
            var x = fu.CreateProjectTeam("1111", "salt lake", "0001");
            Assert.IsTrue(x._accountNo == "0001" && x._teamID == "1111" && x._teamName == "salt lake");

        }
        [Test]
        public void CreateProjectTeam_IsCalled_UserType_IsStudent()
        {
            try
            {
                fu2.CreateProjectTeam("1111", "salt lake", "0001");
                Assert.Fail();
            }
            catch(AssertionException)
            {
                throw;
            }

            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Contains("You do not have permission to do that"));
            }
            
        }
        [Test]
        public void UpdateProjectTeam_IsCalled_UserType_IsTeacher()
        {
            /*fu.UpdateProjectTeam("9009");
            Assert.AreEqual("9009", fpt._teamID);
            Assert.AreEqual("lake of salt", fpt._teamName);
            Assert.AreEqual("6789", fpt._accountNo);*/
            Assert.Fail();
        }
        [Test]
        public void UpdateProjectTeam_IsCalled_UserType_IsStudent()
        {
            try
            {
                fu2.UpdateProjectTeam("1111");
                Assert.Fail();
            }
            catch (AssertionException)
            {
                throw;
            }

            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Contains("You do not have permission to do that"));
            }
        }
    }
}
