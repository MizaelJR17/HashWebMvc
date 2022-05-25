using System;

namespace HashWebMvc.Services.Exceptios
{
    public class DbConcurrencyException : ApplicationException
    {

        public DbConcurrencyException(string message) : base(message)
        {

        }


    }

}
