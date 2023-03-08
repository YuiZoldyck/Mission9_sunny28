using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission9_sunny28.Models;

namespace Mission9_sunny28.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
       private IBookstoreRepository repo { get; set; }

        public CategoriesViewComponent (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["Category"];

            var categories = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(categories);
        }
    }
}
