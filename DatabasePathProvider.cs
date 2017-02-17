using System;
using System.IO;
using Contact.IOS;

[assembly: Xamarin.Forms.Dependency(typeof(DatabasePathProvider))]
namespace Contact.IOS
{
    public class DatabasePathProvider : IDatabaseHelper
    {
        public string GetDatabasePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "contacts.db3");
         }
    }
}
