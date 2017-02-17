using System;
using System.Collections.Generic;
using Contact.IOS;
using Foundation;
using Newtonsoft.Json;

[assembly:Xamarin.Forms.Dependency(typeof(ContactManager))]

namespace Contact.IOS
{
	public class ContactManager : IContactPreferences
	{
        public void AddContactToPreferences(Person newContact , string key)
		{
            var jsonData = JsonConvert.SerializeObject(newContact);
            NSUserDefaults.StandardUserDefaults.SetString(jsonData,key);
   		}
       
        public Person GetContactFromPreferences(string key)
        {
            var retrievedValue = NSUserDefaults.StandardUserDefaults.StringForKey(key);
            Person newPerson = JsonConvert.DeserializeObject<Person>(retrievedValue);
            return newPerson;
        }
	}
}