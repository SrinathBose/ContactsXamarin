namespace Contact
{
	public interface IContactPreferences
	{
        void AddContactToPreferences(Person newContact, string key);
        Person GetContactFromPreferences(string key);
	}
}