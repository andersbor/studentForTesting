using System;

namespace StudentForTesting
{
    public class Teacher : Person, IEquatable<Teacher>
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

        public bool Equals(Teacher other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return base.Equals(other) && _salary == other._salary;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Teacher) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ _salary;
            }
        }
    }
}
