using System;
using System.Collections.Generic;

namespace Contact
{
	public class ContactsProvider
	{
		public ContactsProvider()
		{
		}

		public List<Person> getcontacts()
		{
			List<Person> contacts = new List<Person>{
				new Person("Srinath", 8148004133, "XXXYYYZZZ"),
				new Person("Mala", 9543395322, "AAABBBCCC"),
				new Person("Bose", 9787010426, "SSSDDDFFF"),
				new Person("Latha", 8270471060, "LLLKKKJJJ"),
				new Person("Ambika", 7810997499, "QQQWWWEEE") };

			return contacts;
		}
	}
}
