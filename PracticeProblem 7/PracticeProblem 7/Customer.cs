using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PracticeProblem_7
{
    public class Customer
    {

        [Required(ErrorMessage = "FirstName is required")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        [RegularExpression(@"^\\+?[0 - 9]{1, 4}\\s?[0 - 9]{10}$", ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }

    public class CustomerBasic
    {
        public void CustomerBasicInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the details of Customer : ");
            Console.WriteLine();
            Console.WriteLine("Enter your FirstName: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your LastName : ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter your PhoneNumber : ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your Email : ");
            string email = Console.ReadLine();

            var customer = new Customer()
            {
                FirstName = firstname,
                LastName = lastname,
                PhoneNumber = phoneNumber,
                Email = email
            };

            var context = new ValidationContext(customer);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(customer, context, results, true);

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
