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
            List<String> values = new List<String> { "SICA3a", "SI-3a", "SI-CAa", "SI-CA3", "SI-CA3a ", " SI-CA3a", "si-ca3a", "" };
            Student student = new Student("Pascal", "Hurni");
            foreach (String value in values)
            {
                Assert.Throws<Exception>(delegate
                {
                    student.ClassName = value;
                });
            }

        }

        [Test]
        public void Set_ClassName_Empty_String()
        {
            Set_ClassName_Throws_Exception("");
        }
        [Test]
        public void Set_ClassName_Incorrect_First_Part()
        {
            Set_ClassName_Throws_Exception("si-MI3a");
            Set_ClassName_Throws_Exception("SP-MI3a");
            Set_ClassName_Throws_Exception("SIMI3a");
            Set_ClassName_Throws_Exception("MI3a");
        }
        [Test]
        public void Set_ClassName_Incorrect_Second_Part()
        {
            Set_ClassName_Throws_Exception("SI-CE3a");
            Set_ClassName_Throws_Exception("SI-ca3a");
            Set_ClassName_Throws_Exception("SI-3a");
        }

        [Test]
        public void Set_ClassName_Incorrect_Third_Part()
        {
            Set_ClassName_Throws_Exception("SI-CA5b");
            Set_ClassName_Throws_Exception("SI-CA0b");
            Set_ClassName_Throws_Exception("SI-CAb");
            Set_ClassName_Throws_Exception("SI-CA-1b");
        }

        [Test]
        public void Set_ClassName_Incorrect_Fourth_Part()
        {
            Set_ClassName_Throws_Exception("SI-CA3X");
            Set_ClassName_Throws_Exception("SI-CA3");
            Set_ClassName_Throws_Exception("SI-CA32");
            Set_ClassName_Throws_Exception("SI-CA3a ");
        }

        public void Set_ClassName_Throws_Exception(string value)
        {
            Student student = new Student("Pascal", "Hurni");
            Assert.Throws<Exception>(delegate
            {
                student.ClassName = value;
            });

        }

    }
}