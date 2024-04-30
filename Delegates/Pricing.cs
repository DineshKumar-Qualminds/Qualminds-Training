using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegates
    {
        // Creating Delegate
        public delegate decimal PricingStrategy(decimal price);

        // Product class
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        // Pricing class
        public class Pricing
        {
            public static decimal ApplyDiscount(decimal price)
            {
                return price * 0.9m; // 10% discount
            }

            public static decimal ApplyTax(decimal price)
            {
                return price * 1.15m; // 15% tax
            }
        }

        class PriceDetails
        {
            static void Main(string[] args)
            {
                Product product = new Product { Name = "Phone", Price = 1000 };

                PricingStrategy discountObj, taxObj, combinedObject;

                discountObj = new PricingStrategy(Pricing.ApplyDiscount);
                taxObj = new PricingStrategy(Pricing.ApplyTax);

                combinedObject = discountObj + taxObj;

                Console.WriteLine($"Product: {product.Name}");
                Console.WriteLine($"Initial Price: {product.Price}");

                // Single delegate for applying discount
                Console.WriteLine($"Price after Discount: {discountObj(product.Price)}");

                // Single delegate for applying tax
                Console.WriteLine($"Price after Tax: {taxObj(product.Price)}");

                // Multicasting a delegate
                Console.WriteLine($"Price after Discount and Tax: {combinedObject(product.Price)}");

                Console.ReadKey();
            }
        }
    }


