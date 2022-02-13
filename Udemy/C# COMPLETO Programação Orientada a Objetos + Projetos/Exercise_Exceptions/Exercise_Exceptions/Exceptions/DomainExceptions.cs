using System;

namespace Exercise_Exceptions_DomainExceptions.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
