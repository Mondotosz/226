using System;
using System.Collections.Generic;
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
            Assert.AreEqual("HURNI", student.LastName);
        }

        [Test]
        public void Set_FirstName_With_Correct_Value()
        {
            Student student = new Student("Pascal", "Hurni");
            Assert.AreEqual("Pascal", student.FirstName);
        }

        [Test]
        public void Set_First_Name_With_Incorrect_Value_Throws_Exception()
        {
            Assert.Throws<Exception>(delegate
            {
                Student student = new Student("pascal", "Hurni");
            });

        }

        [Test]
        public void Set_ClassName_With_Correct_Value()
        {
            List<String> values = new List<String> { "SI-MI3b", "SI-C2a", "SI-CA1c", "SI-C4z" };
            Student student = new Student("Pascal", "Hurni");
            foreach (String value in values)
            {
                student.ClassName = value;
                Assert.AreEqual(value, student.ClassName);
            }
        }

        [Test]
        public void Set_Classname_With_Incorrect_Value_Throws_Exception()
        {
            List<String> values = new List<String> { "SP-MI3a", "SI-CE3a", "SI-CA5b", "SI-CA3X", "SICA3a", "SI-3a", "SI-CAa", "SI-CA3", "SI-CA3a ", " SI-CA3a", "si-ca3a", "" };
            Student student = new Student("Pascal", "Hurni");
            foreach (String value in values)
            {
                Assert.Throws<Exception>(delegate
                {
                    student.ClassName = value;
                });
            }

        }

    }
}