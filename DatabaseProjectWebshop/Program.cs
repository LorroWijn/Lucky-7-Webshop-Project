using System;
using System.Linq;
using static DatabaseProjectWebshop.Webshopcontext;

namespace DatabaseProjectWebshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data_Insertion();
            Console.WriteLine("Hello World!");
        }

        static void Data_Insertion()
        {
            // var products = new ExcelQueryFactory(@"D:\GitHub\Klooizooi\Database_Version_1.0\DatabaseProjectWebshop\Files\DataWebshopRip.xlsx");
            // var productsPutIn = from ProductsSheet in products.Worksheet<Product>()
            //                     select ProductsSheet;

            // if (productsPutIn != null)
            // {
            //     foreach (var a in productsPutIn)
            //     {
            //         Product p = new Product
            //         {
            //             //Fill in de LINQ code to insert data in the database here
            //             ProductName = a.ProductName,
            //             ProductPrice = a.ProductPrice,
            //             ProductImage = a.ProductImage,
            //             URL = a.URL,
            //             MainCategory = a.MainCategory,
            //             SubCategory = a.SubCategory,
            //             ProductDescription = a.ProductDescription

            //         };
            //    }
            //}
        }

        static void NewCustomer()
        {
            using (var db = new Webshopcontext())
            {
                Customer c = new Customer
                {
                    // public int Id { get; set; }
                    // public string CustomerFirstName { get; set; }
                    // public string CustomerLastName { get; set; }
                    // public string CustomerAddress { get; set; }
                    // public string CustomerZipCode { get; set; }
                    // public string CustomerCity { get; set; }
                    // public string CustomerUserName { get; set; }
                    // public string CustomerPassword { get; set; }
                    //Hebben we ook geslacht?

                    CustomerFirstName = "",
                    CustomerLastName = "",
                    CustomerGender = "",
                    CustomerUserName = "",
                    CustomerPassword = "",
                    CustomerCity = "",
                    CustomerAddress = "",
                    CustomerZipCode = ""
                };
            }
        }

        static void Category_1()
        {
            //Here comes the select queries written in LINQ language.
        }

        static void Category_2()
        {
            //Here comes the select queries written in LINQ language.
        }

        static void Category_3()
        {
            //Here comes the select queries written in LINQ language.
        }

        static void Category_4()
        {
            //Here comes the select queries written in LINQ language.
        }

        static void searchFunction()
        {
            //Here comes the select queries written in LINQ language for the search fucntion
        }
    }
}
