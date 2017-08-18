using System;

namespace StudentForTesting
{
    public class Teacher : Person
    {
        private int _salary;

        public Teacher(string name, string address, int salary, Gender gender)
        {
            Name = name;
            Address = address;
            Salary = salary;
            Gender = gender;
        }

        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("salary", value, "salary less than 0");
                _salary = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + Salary;
        }
    }
}
