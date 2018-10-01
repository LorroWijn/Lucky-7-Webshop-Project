using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;

namespace DatabaseProjectWebshop
{
    public class Webshopcontext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        //Database hebben we nog niet dus hier invoeren als we een server hebben
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //This string needs to be changed to the files folder that has db.txt - Change your password to your postgres password!!!
            optionsBuilder.UseNpgsql(File.ReadAllText(@"D:\GitHub\Klooizooi\Database_Version_1.0\DatabaseProjectWebshop\Files\db.txt"));
        }

        // Dit volgende stukje code moeten we doen voor alle foreign key(iets van 8), maar ik heb nu niet genoeg tijd om het te doen
        // protected override void OnModelCreating(ModelBuilder modelBuilder) 
        // {
        //    modelBuilder.Entity("DatabaseProjectWebshop.DatabaseModel.Product", b => 
        //    b.HasOne("DatabaseProjectWebshop.DatabaseModel.Movie", "Movie")
        //    .WithMany("Actors")
        //    .HasForeignKey("MovieId")
        //    .OnDelete(DeleteBehavior.Cascade));
        // }

        // Foreign keys zijn volgens mij allemaal 1-to-1 relationships, omdat we Id's aan elkaar koppelen.
        // Zouden we moeten uitzoeken hoe dat werkt, want daar hebben we geen voorbeeld van uit Development 5.
        public class Product
        {
            public int Id { get; set; }
            // veranderen naar foreign key: public int ProductCategoryId{get;set;}
            // veranderen naar foreign key: public int ProductBrandId{get;set;}
            public string ProductName { get; set; }
            public float ProductPrice { get; set; }
            public string ProductImage { get; set; }
            public string URL { get; set; }
            public string MainCategory { get; set; }
            public string SubCategory {get; set; }
            public string ProductDescription { get; set; }
        }

//ProductNaam	ProductPrice	ProductImage	URL	Maincategory	Subcategory

        public class Customer
        {
            public int Id { get; set; }
            public string CustomerFirstName { get; set; }
            public string CustomerLastName { get; set; }
            public string CustomerGender {get; set;}
            public string CustomerAddress { get; set; }
            public string CustomerZipCode { get; set; }
            public string CustomerCity { get; set; }
            public string CustomerUserName { get; set; }
            public string CustomerPassword { get; set; }
        }

        public class ShoppingCart
        {
            public int Id { get; set; }
            // Foreign key van ProductId maken?: public int ShoppingCartProductId{get;set;}
            // Foreign key van ProductPrice maken?: public int ShoppingCartPrice{get;set;}
            public int ShoppingCartQuantity { get; set; }
            public int ShoppingCartTotal { get; set; }
        }

        public class Wishlist
        {
            public int Id { get; set; }
            // Foreign key van ProductId maken?: public int WishlistProductId{get;set;}
            // Foreign key van ProductPrice maken?: public int WishlistProductPrice{get;set;}
            // Foreign key van customerId maken?: public int WishlistCustomerId{get;set;}
        }

        public class Order
        {
            public int Id { get; set; }
            // Foreign key van customerId maken?: public int OrderCustomerId{get;set;}
            // Foreign key van ShoppingCartId maken?: public int OrderShoppingCartId{get;set;}
            public string OrderDate { get; set; }
            // Is alleen de datum hier genoeg? Moet de precieze tijd er ook bij?
        }

        public class Review
        {
            public int Id { get; set; }
            // Foreign key van customerId maken?: public int ReviewCustomerId{get;set}
            public string ReviewText { get; set; }
            public int ReviewGrade { get; set; }
        }

        public class Category
        {
            public int Id { get; set; }
            public string CategoryName { get; set; }
        }

        public class Brand
        {
            public int Id { get; set; }
            public string BrandName { get; set; }
        }
    }
}

