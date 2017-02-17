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
}
