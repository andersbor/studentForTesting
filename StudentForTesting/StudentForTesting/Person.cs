using System;

namespace StudentForTesting
{
    public class Person
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
    }
}