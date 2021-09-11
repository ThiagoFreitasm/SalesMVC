using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        //Constructor
        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            //Para fazer uma chamada asincrona dentro do método temos que avisar o compilador que 
            //se trata de uma chamada asincrona incluindo o AWAIT após o return.
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
