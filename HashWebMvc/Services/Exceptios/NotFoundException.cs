using System;

namespace HashWebMvc.Services.Exceptios
{
    public class NotFoundException : ApplicationException
    {

        public NotFoundException(string message) : base(message)
        {

        }
    }
}
