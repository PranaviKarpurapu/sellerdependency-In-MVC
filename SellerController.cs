using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using SellerDependencyInjectionDemo.Model;

namespace SellerDependencyInjectionDemo.Controler
{
    public class SellerController : Controller
    {
        private readonly ISellerRepository sRepository;
        //dependency injected object
        //By declaring readonly we can only assign the variable once in constructor
        public SellerController(ISellerRepository empRepository)
        {
            sRepository = empRepository;
        }


        public IActionResult Search(int? id)
            {
                int ID = (int)((id == null) ? 1 : id);
                Seller ser = sRepository.GetSeller(ID);

            //ViewData["id"] = ser.Id;
            //ViewData["name"] = ser.Name;
            //ViewData["password"] = ser.Pswd;
            //ViewData["gstin"] = ser.Gstin;
            //ViewData["compname"] = ser.Compname;
            //ViewData["det"] = ser.Det;
            //ViewData["cweb"] = ser.Cweb;
            //ViewData["sadd"] = ser.Sadd;
            //ViewData["email"] = ser.Email;
            //ViewData["phno"] = ser.Phno;
            ViewData["Seller"] = ser;

            return View();
        }
    }
}
