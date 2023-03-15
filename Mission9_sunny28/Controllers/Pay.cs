using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission9_sunny28.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mission9_sunny28.Controllers
{
    public class Pay : Controller
    {
        private IPurchaseRepository repo { get; set; }

        private Basket basket { get; set; }
         
        public Pay(IPurchaseRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }

        // Purchase books in cart
        [HttpPost]
        public IActionResult Checkout(Purchase purchase)
        {
            if(basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, the basket is empty!");
            }

            if(ModelState.IsValid)
            {
                purchase.Lines = basket.Items.ToArray();
                repo.SavePurchase(purchase);
                basket.ClearBasket();

                return RedirectToPage("/CompletedPurchase");  
            } else
            {
                return View();
            }
        }
    }
}
