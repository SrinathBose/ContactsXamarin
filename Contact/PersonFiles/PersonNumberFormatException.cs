using System;
namespace Contact
{
    public class PersonNumberFormatException : Exception
    {
        public PersonNumberFormatException()
        {
        }

        public override string Message
        {
            get
            {
                return "Please, Enter Valid Phone Number";
            }
        }
    }

    public class PersonNullDataException : Exception
    {
        public PersonNullDataException()
        {
        }

        public override string Message
        {
            get
            {
                return "Please, Fill Up All Fields";
            }
        }
    }
}
