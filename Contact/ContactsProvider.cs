using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Contact
{
	public class ContactsProvider
	{
        ObservableCollection<Person> contactObserver;
        public ObservableCollection<Person> getcontacts()
		{
            contactObserver = new ObservableCollection<Person>();

            contactObserver.Add(new Person("Srinath", 8148004133, "XXXYYYZZZ"));
            contactObserver.Add(new Person("Mala", 9543395322, "AAABBBCCC"));
            contactObserver.Add(new Person("Bose", 9787010426, "SSSDDDFFF"));
            contactObserver.Add(new Person("Latha", 8270471060, "LLLKKKJJJ"));
            contactObserver.Add(new Person("Ambika", 7810997499, "QQQWWWEEE"));

            DependencyService.Get<IContactPreferences>().SaveContactToPreferences(new Person("Raj", 9876512345, "CCCFFFFTTT"),"person1");

            contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContact("person1"));
            contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContact("person2"));
            contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContact("person3"));
            contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContact("person4"));
            contactObserver.Add(DependencyService.Get<IContactPreferences>().GetContact("person5"));


            return contactObserver;
		}
	}
}
