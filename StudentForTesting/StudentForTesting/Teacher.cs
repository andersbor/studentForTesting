using System;

namespace StudentForTesting
{
    public class Teacher
    {
        private string _address;
        private string _name;
        private int _salary;

        public Teacher(string name, string address, int salary, Gender gender)
        {
            Name = name;
            Address = address;
            Salary = salary;
            Gender = gender;
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

        public Gender Gender { get; set; }

        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("salary", value, "salary less than 0");
                _salary = value;
            }
        }

       
    }
}
