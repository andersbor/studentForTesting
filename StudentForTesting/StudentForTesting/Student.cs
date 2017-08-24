using System;

namespace StudentForTesting
{
    /// <summary>
    /// Gender type: Male, Female
    /// </summary>
    public enum Gender
    {
        Male, Female   
    }

    public class Student : Person
    {
        private int _semester;

        /// <summary>
        /// Constructs an object of the type Student
        /// </summary>
        /// <param name="name">Name of student</param>
        /// <param name="address">Address of student</param>
        /// <param name="gender">Gender of student</param>
        /// <param name="semester">Semester of student</param>
        public Student(string name, string address, Gender gender, int semester)
        {
            Name = name;
            Address = address;
            Gender = gender;
            Semester = semester;
        }

        /// <summary>
        /// Semester of student, must 1 &lt;= semester &lt;= 8
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">if semester is either to low or to high</exception>
        public int Semester
        {
            get { return _semester; }
            set
            {
                if (1 <= value && value <= 8) _semester = value;
                else throw new ArgumentOutOfRangeException("semester", value, "Illegal semester");
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + Semester;
        }
    }
}
