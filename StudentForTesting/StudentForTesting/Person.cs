using System;

namespace StudentForTesting
{
    public class Person : IEquatable<Person>
    {
        private string _address;
        private string _name;

        /// <summary>
        /// Name of Person
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
        /// Address of Person
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
        /// Gender of Student
        /// </summary>
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return Name + " " + Address + " " + Gender;
        }

        public bool Equals(Person other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(_address, other._address) && string.Equals(_name, other._name) && Gender == other.Gender;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_address != null ? _address.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_name != null ? _name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int) Gender;
                return hashCode;
            }
        }
    }
}