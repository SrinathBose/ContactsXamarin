using System;
using System.Collections.Generic;
using Contact.IOS;
using Foundation;
using Newtonsoft.Json;

[assembly:Xamarin.Forms.Dependency(typeof(SaveContact))]

namespace Contact.IOS
{
	public class SaveContact : IContactPreferences
	{
        public void SaveContactToPreferences(Person newContact , string key)
		{
            var jsonData = JsonConvert.SerializeObject(newContact);
            //NSUserDefaults.StandardUserDefaults.Se
            NSUserDefaults.StandardUserDefaults.SetString(jsonData,key);
   		}
       
        public Person GetContact(string key)
        {
            var retrievedValue = NSUserDefaults.StandardUserDefaults.StringForKey(key);
            Console.WriteLine(" Retrieved Value Is = {0} ", retrievedValue);

            Person newPerson = JsonConvert.DeserializeObject<Person>(retrievedValue);

            Console.WriteLine("Name Is {0} ", newPerson.Name);
            Console.WriteLine("Number Is {0} ", newPerson.Number);
            Console.WriteLine("Address Is {0} ", newPerson.Address);

            return newPerson;
        }
	}
}
