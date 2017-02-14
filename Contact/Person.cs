using System;
namespace Contact
{
	public class Person
	{
		private string _nameString;
		private long _numberLong;
		private string _addressString;
		 
		public Person(string nameString, long numberLong, string addressString)
		{
			_nameString = nameString;
			_numberLong = numberLong;
			_addressString = addressString;
		}

		public string Name
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

		public long Number
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

		public string Address
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
	}
}
