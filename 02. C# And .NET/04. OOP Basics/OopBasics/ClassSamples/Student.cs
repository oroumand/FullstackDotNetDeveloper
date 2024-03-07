using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamples
{
    public class Student
    {
        private string _firstName;

        public string GetFirstName() => _firstName;

        public void SetFirstName(string firstName) => _firstName = firstName;

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _lastName = value;
            }
        }

        private string _email;
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string Age { get; set; }

        private string _nationalId;

        public string NationalId
        {
            get
            {
                return _nationalId;
            }
            private set { _nationalId = value; }
        }


        public int FatherName { get; private set; }


        public DateTime GetDate => DateTime.Now;
        public DateTime GetTime() => DateTime.Now.ToLocalTime();

        public string FullName => $"{_firstName} {LastName}";


    }
}
