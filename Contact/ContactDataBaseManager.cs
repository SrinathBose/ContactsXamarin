using Xamarin.Forms;
using SQLite;
using System;
using System.Collections.Generic;

namespace Contact
{
    public class ContactDataBaseManager
    {
        SQLiteConnection connection;
        public ContactDataBaseManager()
        {
            string databasePath = DependencyService.Get<IDatabaseHelper>().GetDatabasePath();
            connection = new SQLiteConnection(databasePath);
            connection.CreateTable<PersonTable>();
        }

        public void InsertPersonIntoDataBase(Person newPerson)
        {
            PersonTable newContact = new PersonTable();
            newContact.nameString = newPerson.nameString;
            newContact.numberLong = newPerson.numberLong;
            newContact.addressString = newPerson.addressString;

            connection.Insert(newContact);
        }

        public List<Person> GetPersonFromDatabase()
        {
            var result = connection.Table<PersonTable>();
            List<Person> persons = new List<Person>();

            foreach (var x in result)
                persons.Add(new Person(x.nameString,x.numberLong,x.addressString));
            
            return persons;
        }
    }
}
