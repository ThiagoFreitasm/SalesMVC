using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //Criando uma dependencia DBCONTEXT(SalesWebMvcContext.cs)
        //O readyonly é uma boa pratica para previnir que essa dependencia nao seja alterada.
        private readonly SalesWebMvcContext _context;

        //Constructor
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            //Usando o Linq
            //Retornar um vendedor que possue o id instanciado na linha 31, se o vendedor nao existir vai retornar null.
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            //Remoçao do obj do DBSET
            _context.Seller.Remove(obj);
            //Confirmar a efetivacao no BD
            _context.SaveChanges();
        }
    }
}
