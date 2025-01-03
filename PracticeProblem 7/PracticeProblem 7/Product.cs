using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PracticeProblem_7
{
    public class Product
    {
        [Required(ErrorMessage = "ProductID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "ProductID must be integer type")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "ProductName is required")]
        [MaxLength(100)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "QuantityInStock is required")]
        [Range(0, int.MaxValue, ErrorMessage = "QuantityInStock must be Non-Negative Integer type")]
        public int QuantityInStock { get; set; }

        [Required(ErrorMessage = "UnitPrice is required")]
        [Range(0, int.MaxValue, ErrorMessage = "UnitPrice must be positive number")]
        public double UnitPrice { get; set; }

        [Required(ErrorMessage = "SupplierEmail is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string SupplierEmail { get; set; }

    }

    public class ProductBasic
    {
        public void ProductBasicInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the details of Product : ");
            Console.WriteLine();
            Console.WriteLine("Enter your ProductID: ");
            int productID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your ProductName : ");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter your QuantityInStock : ");
            int quantityInStock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your UnitPrice : ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your SupplierEmail : ");
            string supplierEmail = Console.ReadLine();

            var product = new Product()
            {
                ProductID = productID,
                ProductName = productName,
                QuantityInStock = quantityInStock,
                UnitPrice = unitPrice,
                SupplierEmail = supplierEmail
            };

            var context = new ValidationContext(product);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(product, context, results, true);

            if (isValid)
            {
                Console.WriteLine();
                Console.WriteLine("User Data is Valid.");

            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("User Data is Invalid.");
                Console.WriteLine();
                Console.WriteLine(context);
                Console.WriteLine();

                foreach (var validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }

            }
        }
    }
}
