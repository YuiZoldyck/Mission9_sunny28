using System;
using Microsoft.AspNetCore.Mvc;
using Mission9_sunny28.Models;

namespace Mission9_sunny28.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;

        public CartSummaryViewComponent(Basket temp)
        {
            basket = temp;
        }

        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
