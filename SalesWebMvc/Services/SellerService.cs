using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //Criando uma dependencia DBCONTEXT(SalesWebMvcContext.cs)
        //O readyonly é uma boa pratica para previnir que essa dependencia nao seja alterada.
        public readonly SalesWebMvcContext _context;

        //Constructor
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
