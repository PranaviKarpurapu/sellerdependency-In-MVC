using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerDependencyInjectionDemo.Model
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pswd { get; set; }
        public string Compname { get; set; }
        public string Gstin { get; set; }
        public string Det { get; set; }
        public string Sadd { get; set; }
        public string Cweb { get; set; }

        public string Email { get; set; }
        public int Phno { get; set; }

        public Seller(int id, string name, string pswd, string compname, string gstin, string det, string sadd, string cweb, string email, int phno)
        {
            this.Id = id;
            this.Name = name;
            this.Pswd = pswd;
            this.Compname = compname;
            this.Gstin = gstin;
            this.Det = det;
            this.Sadd = sadd;
            this.Cweb = cweb;
            this.Email = email;
            this.Phno = phno;
        }
    }
}
