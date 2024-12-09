using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using Task10.Data;
using Task10.Models;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            // 1) Retrieve all categories from the production.categories table.

            var categories = dbContext.Categories;
            foreach (var category in categories)
            {
                Console.WriteLine($"Categry ID : {category.CategoryId} Categry Name: {category.CategoryName}");
            }

            // 2) Retrieve the first product from the production.products table.

            var firstProduct = dbContext.Products.First();
            Console.WriteLine($"Product ID : {firstProduct.ProductId}, Product Name : {firstProduct.ProductName}");

            // 3) Retrieve a specific product from the production.products table by ID.

            var specificProduct = dbContext.Products.Find(5);
            Console.WriteLine($"Product ID : {specificProduct.ProductId}, Product Name : {specificProduct.ProductName}");

            // 4) Retrieve all products from the production.products table with a certain model year.

            var allProductsOnModelYear = dbContext.Products.Where(e => e.ModelYear == 2017);
            foreach (var product in allProductsOnModelYear)
            {
                Console.WriteLine($"Product ID : {product.ProductId}, Product Name : {product.ProductName} Model Year : {product.ModelYear}");
            }

            // 5) Retrieve a specific customer from the sales.customers table by ID.

            var specificCustomer = dbContext.Products.Find(3);
            Console.WriteLine($"Product ID : {specificCustomer.ProductId}, Product Name : {specificCustomer.ProductName}");

            // 6) Retrieve a list of product names and their corresponding brand names.

            var productsBrand = dbContext.Products.Include(e => e.Brand);
            foreach (var product in productsBrand)
            {
                Console.WriteLine($"Product Name: {product.ProductName}, Brand Name: {product.Brand.BrandName}");
            }

            // 7) Count the number of products in a specific category.

            var productNumberInCategory = dbContext.Products.Where(e => e.CategoryId == 3);
            int countNumberOfProducts = 0;
            foreach (var product in productNumberInCategory)
            {
                countNumberOfProducts++;
            }
            Console.WriteLine($"Categry ID : {3}, Number Of Product : {countNumberOfProducts}");

            // 8) Calculate the total list price of all products in a specific category.
            var productTotalListPriceInCategory = dbContext.Products.Where(e => e.CategoryId == 4);
            decimal totalListPrice = 0;
            foreach (var product in productNumberInCategory)
            {
                totalListPrice += product.ListPrice;
            }
            Console.WriteLine($"Categry ID : {4}, Total List Price : {totalListPrice}");

            // 9) Calculate the average list price of products.
            var avgPrice = dbContext.Products.Average(e => e.ListPrice);
            Console.WriteLine($"Average Price = {avgPrice}");

            // 10) Retrieve orders that are completed.
            var ordersCompleted = dbContext.Orders.Where(e => e.OrderStatus == 4);
            foreach (var order in ordersCompleted)
            {
                Console.WriteLine($"Order ID: {order.OrderId}, Oreder Status: {order.OrderStatus}");
            }





        }
    }
}
