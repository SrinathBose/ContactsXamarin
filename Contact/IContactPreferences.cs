using System.Collections.Generic;
namespace Contact
{
	public interface IContactPreferences
	{
        void SaveContactToPreferences(Person newContact, string key);
        Person GetContact(string key);
	}
}