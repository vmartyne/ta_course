using System;
using System.Text.RegularExpressions;

namespace Homework_Person
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirthday;
        private string _inn;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 30)
                    throw new ArgumentException("First name should contain 1 to 30 characters.");

                if (!Regex.IsMatch(value, @"^[a-zA-Z]{1,30}$"))
                    throw new ArgumentException("First name should only contain Latin letters.");

                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 30)
                    throw new ArgumentException("Last name should contain 1 to 30 characters.");

                if (!Regex.IsMatch(value, @"^[a-zA-Z]{1,30}$"))
                    throw new ArgumentException("Last name should only contain Latin letters.");

                _lastName = value;
            }
        }

        public DateTime dateOfBirthday
        {
            get { return _dateOfBirthday; }
            set
            {
                if (value > DateTime.Today)
                    throw new ArgumentException("Date of birth cannot be in the future.");

                _dateOfBirthday = value;
            }
        }

        public string inn
        {
            get { return _inn; }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Z]{2}\d{10}$"))
                    throw new ArgumentException("INN must satisfy the pattern: <upper_case><upper_case><10digit>");

                _inn = value;
            }
        }
    }

}

