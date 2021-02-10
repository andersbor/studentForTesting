using System;

namespace StudentForTesting
{
    

    public class Student
    {
        private string _name;
        private string _address;
        private int _semester;

        /// <summary>
        /// Constructs an object of the type Student
        /// </summary>
        /// <param name="name">Name of student</param>
        /// <param name="address">Address of student</param>
        /// <param name="genderType">GenderType of student</param>
        /// <param name="semester">Semester of student</param>
        public Student(string name, string address, GenderType genderType, int semester)
        {
            Name = name;
            Address = address;
            GenderType = genderType;
            Semester = semester;
        }

        /// <summary>
        /// Name of Student
        /// </summary>
        /// <exception cref="ArgumentNullException">if name is null</exception>
        /// <exception cref="ArgumentException">if name length is less than 2</exception>
        public string Name

        {
            get { return _name; }
            set
            {
                if (value == null) throw new ArgumentNullException("name", "Name is null");
                if (value.Length < 2) throw new ArgumentException("Name length must be at least 2 characters");
                _name = value;
            }
        }

        /// <summary>
        /// Address of student
        /// </summary>
        /// <exception cref="ArgumentNullException">if address is null</exception>
        public string Address
        {
            get { return _address; }
            set
            {
                if (value == null) throw new ArgumentNullException("address", "Address is null");
                _address = value;
            }
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

        /// <summary>
        /// GenderType of Student
        /// </summary>
        public GenderType GenderType { get; set; }
    }
}
