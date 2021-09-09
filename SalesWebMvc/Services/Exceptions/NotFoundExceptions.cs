using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundExceptions: ApplicationException
    {
        //Contructor para receber a messagem
        public NotFoundExceptions(string message) : base(message)
        {

        }
    }
}
