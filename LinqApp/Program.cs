using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Linq.About);




            //var aproduct = from p in Linq.Products
            //               where p.Id == 1
            //               select p;

            //var prod = Linq.Products[0];
            //    prod.Print(); //extension method


            //var productswithvendors = from p in Linq.Products
            //                          join v in Linq.Vendors
            //                          on p.VendorId equals v.Id
            //                          select new
            //                          {
            //                             vendorname = v.Name, productname = p.Name, pp = p.Price
            //                          };

            //foreach (var i in productswithvendors)
            //{
            //    Console.WriteLine($"{i.vendorname} {i.productname} {i.pp}");
            //}


            var prodsgt200 = Linq.Products.Where(i => i.Price > 200).OrderBy(x => x.Name).ToArray();
            foreach (var i in prodsgt200)
            {
                i.Print();
            }

            var products = from p in Linq.Products
                           orderby p.Name
                           where p.Price > 200
                           select p;

            foreach (var i in products)
            {
                Console.WriteLine(i);
            }

            var vendsdiscgt1 = Linq.Vendors.Where(i => i.Discount >= 0.1m).OrderByDescending(x => x.Name);
            foreach (var i in vendsdiscgt1)
            {
                i.Print();
            }

            var vendors = from v in Linq.Vendors
                          where v.Discount >= 0.1m
                          orderby v.Name descending
                          select v;

            foreach (var i in vendors)
            {
                Console.WriteLine(i);
            }


        }
    }
}
