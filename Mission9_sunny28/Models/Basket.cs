using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Mission9_sunny28.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        // Add new item to the basket
        public virtual void AddItem (Book book, int qty)
        {
            BasketLineItem line = Items
                .Where(x => x.Book.BookId == book.BookId)
                .FirstOrDefault();

            if(line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        // Removes a single book from basket
        public virtual void RemoveItem (Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        // Deletes everything in basket
        public virtual void ClearBasket ()
        {
            Items.Clear();
        }

        // Calculate the total of the books
        public virtual double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);
            return sum;
        }
    }

    public class BasketLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
