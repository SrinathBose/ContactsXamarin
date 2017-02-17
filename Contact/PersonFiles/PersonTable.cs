using System;
using SQLite;

namespace Contact
{
    public class PersonTable
    {
        public string nameString { get; set; }
        [PrimaryKey]
        public long numberLong { get; set; }
        public string addressString { get; set; }
    }
}
