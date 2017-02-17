using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Contact
{
    public enum ProviderType
    {
        Database,
        Preferences
    }
	public class ContactsProvider
	{
        public ProviderType providerType;
        ObservableCollection<Person> contactObserver;
        public ContactsProvider() { }
        public ContactsProvider(ProviderType type)
        {
            this.providerType = type;
        }

        public ObservableCollection<Person> Getcontacts()
        {
            if (contactObserver == null)
                contactObserver = new ObservableCollection<Person>();

            contactObserver.Add(Person.CreatePersonWithData("Srinath", "8148004133", "XXXYYYZZZ"));
            contactObserver.Add(Person.CreatePersonWithData("Mala", "9543395322", "AAABBBCCC"));
            contactObserver.Add(Person.CreatePersonWithData("Bose", "9787010426", "SSSDDDFFF"));
            contactObserver.Add(Person.CreatePersonWithData("Latha", "8270471060", "LLLKKKJJJ"));
            contactObserver.Add(Person.CreatePersonWithData("Ambika", "7810997499", "QQQWWWEEE"));

            if (providerType == ProviderType.Preferences)
            {
                contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContactFromPreferences("person1"));
                contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContactFromPreferences("person2"));
                contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContactFromPreferences("person3"));
                contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContactFromPreferences("person4"));
                contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContactFromPreferences("person5"));
            }            
            else
            {
                List<Person> persons = new ContactDataBaseManager().GetPersonFromDatabase();

                foreach (Person p in persons)
                    contactObserver.Add(p);
            }

            return contactObserver;
        }
    }
}
