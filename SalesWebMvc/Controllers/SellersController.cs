using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        //Declarando dependencia para o SellerServices
        private readonly SellerService _sellerService;
        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        //Exemplo do MVC acontecendo
        public IActionResult Index()  //Controlador
        {
            var list = _sellerService.FindAll(); //Model
            return View(list); //View
        }
    }
}
