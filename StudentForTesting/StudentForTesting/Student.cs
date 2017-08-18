using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForTesting
{
    public class Student
    {
        private string _name;

        public string Name

        {
            get { return _name; }
            set
            {
                if (value == null) throw new ArgumentNullException("name", "Name is null") ;
                if (value.Length < 2) throw new ArgumentException("Name length must be at least 2 characters");
                _name = value; }
        }
    }
}
