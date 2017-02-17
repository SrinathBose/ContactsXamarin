using System;
namespace Contact
{
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
