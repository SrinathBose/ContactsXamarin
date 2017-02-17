using Xamarin.Forms;
using SQLite;
using System;

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

        public bool InsertPersonIntoDataBase(string nameStr, string numberStr, string addressStr)
        {
            PersonTable newContact = new PersonTable();
            newContact.nameString = nameStr;
            newContact.numberLong = Convert.ToInt64(numberStr);
            newContact.addressString = addressStr;

            connection.Insert(newContact);

            return true;
        }

    }
}
