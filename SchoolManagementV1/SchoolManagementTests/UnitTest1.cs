using System;
using NUnit.Framework;
using SchoolManagement;

namespace SchoolManagementTests
{
    public class Tests
    {
        [Test]
        public void Lastname_Set_Is_Get_As_Uppercase()
        {
            Student student = new Student("Pascal", "Hurni");
            string theLastName = student.lastName;

            Assert.AreEqual("HURNI", theLastName);

        }

        [Test]
        public void FirstName_Set_With_Lower_Case()
        {
            Assert.Throws<Exception>(delegate
            {
                Student student = new Student("pierre", "paul");
            });

        }

    }
}