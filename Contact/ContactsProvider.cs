using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Contact
{
	public class ContactsProvider
	{
        ObservableCollection<Person> contactObserver;
        public ObservableCollection<Person> Getcontacts()
		{
            if (contactObserver == null)
            {
                contactObserver = new ObservableCollection<Person>();
            }

            contactObserver.Add( Person.CreatePersonWithData("Srinath", "8148004133", "XXXYYYZZZ"));
            contactObserver.Add( Person.CreatePersonWithData("Mala", "9543395322", "AAABBBCCC"));
            contactObserver.Add( Person.CreatePersonWithData("Bose", "9787010426", "SSSDDDFFF"));
            contactObserver.Add( Person.CreatePersonWithData("Latha", "8270471060", "LLLKKKJJJ"));
            contactObserver.Add( Person.CreatePersonWithData("Ambika", "7810997499", "QQQWWWEEE"));

            contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContactFromPreferences("person1"));
            contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContactFromPreferences("person2"));
            contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContactFromPreferences("person3"));
            contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContactFromPreferences("person4"));
            contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContactFromPreferences("person5"));

            return contactObserver;
		}
	}
}
