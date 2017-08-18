using System;

namespace StudentForTesting
{
    public enum Gender
    {
        Male, Female
    }

    public class Student
    {
        private string _name;
        private string _address;
        private int _semester;

        public Student(string name, string address, Gender gender, int semester)
        {
            Name = name;
            Address = address;
            Gender = gender;
            Semester = semester;
        }

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

        public string Address
        {
            get { return _address; }
            set
            {
                if (value == null) throw new ArgumentNullException("address", "Address is null");
                _address = value;
            }
        }

        public int Semester
        {
            get { return _semester; }
            set
            {
                if (1 <= value && value <= 8) _semester = value;
                else throw new ArgumentOutOfRangeException("semester", value, "Illegal semester");
            }
        }

        public Gender Gender { get; set; }
    }
}
