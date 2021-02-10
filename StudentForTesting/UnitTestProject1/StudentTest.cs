using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentForTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class StudentTest
    {
        private Student _student;

        [TestInitialize]
        public void SetUp()
        {
            _student = new Student("Bo", "Roskilde", GenderType.Male, 1);
        }

        [TestMethod]
        public void TestConstructor()
        {
            Student st = new Student("Bo", "Roskilde", GenderType.Male, 1);

            Assert.AreEqual("Bo", st.Name);
            Assert.AreEqual("Roskilde", st.Address);
            Assert.AreEqual(GenderType.Male, st.Gender);
            Assert.AreEqual(1, st.Semester);
        }

        [TestMethod]
        public void TestName()
        {
            _student.Name = "Bo";
            Assert.AreEqual("Bo", _student.Name);
            Assert.ThrowsException<ArgumentNullException>(() => _student.Name = null);
            Assert.ThrowsException<ArgumentException>(() => _student.Name = "A");
        }

        [TestMethod]
        public void TestSemester()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _student.Semester = 0);
            _student.Semester = 1;
            Assert.AreEqual(1, _student.Semester);
            _student.Semester = 8;
            Assert.AreEqual(8, _student.Semester);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _student.Semester = 9);
        }
        
        [TestMethod]
        public void TestAddress()
        {
            _student.Address = "Roskilde";
            Assert.AreEqual("Roskilde", _student.Address);
            Assert.ThrowsException<ArgumentNullException>(() => _student.Address = null);
        }
    }
}
