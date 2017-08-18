using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentForTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class StudentTest
    {
        private Student student = new Student("Bo", "Roskilde", Gender.Male, 1);

        [TestMethod]
        public void TestConstructor()
        {
            Student st = new Student("Bo", "Roskilde", Gender.Male, 1);
      
            Assert.AreEqual("Bo", st.Name);
            Assert.AreEqual("Roskilde", st.Address);
            Assert.AreEqual(Gender.Male, st.Gender);
            Assert.AreEqual(1, st.Semester);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNameNull()
        {
            student.Name = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameShort()
        {
            student.Name = "Y";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSemesterLow()
        {
            student.Semester = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSemesterHigh()
        {
            student.Semester = 9;
        }
    }
}
