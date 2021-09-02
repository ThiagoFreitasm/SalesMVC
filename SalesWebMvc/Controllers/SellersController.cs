using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
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

        public IActionResult Create()
        {
            return View();
        }
        //Indicar que a acado de baixo é de pos e nao de get. Para isso coloca a acao abaixo entre []
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof (Index));
        }
    }
}
