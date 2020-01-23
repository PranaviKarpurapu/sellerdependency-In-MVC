using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerDependencyInjectionDemo.Model
{
    public interface ISellerRepository
    {
        Seller GetSeller(int id);
    }
}
