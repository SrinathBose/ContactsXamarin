using System;
using System.Text.RegularExpressions;

namespace Contact
{
	public class Person
	{
		private string _nameString;
		private long _numberLong;
		private string _addressString;

        private Person() { }
        public Person(string nameString, long numberLong, string addressString)
		{
			_nameString = nameString;
			_numberLong = numberLong;
			_addressString = addressString;
		}

		public string nameString
		{
			get
			{
				return _nameString;
			}
			set
			{
				if (value != null)
					_nameString = value;
			}
		}

		public long numberLong
		{
			get
			{
				return _numberLong;
			}
			set
			{
				if (value != 0)
					_numberLong = value;
			}
		}

		public string addressString
		{
			get
			{
				return _addressString;
			}
			set
			{
				if (value != null)
					_addressString = value;
			}
		}

        public static Person CreatePersonWithData(string nameString, string numberString, string addressstring)
        {

            if (nameString == null || numberString == null || addressstring == null)
                throw new PersonNullDataException();
            else if (nameString.Trim().Equals("") || numberString.Trim().Equals("") || addressstring.Trim().Equals("") )
                throw new PersonNullDataException();
            else if (!Regex.IsMatch(numberString, @"^[0-9]*$"))
                throw new PersonNumberFormatException();
            else
                return new Person(nameString.Trim(), Convert.ToInt64(numberString.Trim()), addressstring.Trim());
        }
	}
}
