using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerDependencyInjectionDemo.Model
{
    public class SellerRepository : ISellerRepository
    {
        public List<Seller> sellerList;
        public SellerRepository()
        {
            sellerList = new List<Seller>() { new Seller(1, "Nani","a","tcs","qq","dfh","fdg","rfgt", "nani@gmail.com", 456),
                                                  new Seller(2, "Vijay","a","tcs","qq","dfh","fdg","rfgt", "vijay@gmail.com", 123),
                                                  new Seller(3, "Ajay", "a","tcs","qq","dfh","fdg","rfgt","ajay@gmail.com", 768)
                                                };

        }
        public Seller GetSeller(int id)
        {
            Seller res = sellerList.FirstOrDefault(e => e.Id == id);

            return res;
        }
    }
}
