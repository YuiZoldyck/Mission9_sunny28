using System;
using System.Linq;

namespace Mission9_sunny28.Models
{
    public interface IPurchaseRepository
    {
        public IQueryable<Purchase> Purchases { get; }
        public void SavePurchase(Purchase purchase);
        
    }
}
