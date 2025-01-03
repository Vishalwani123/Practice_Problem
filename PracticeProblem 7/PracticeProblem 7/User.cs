using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PracticeProblem_7
{
    public class User
    {
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(20)]
        public string userName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6)]
        public string password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]

        public string email { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [Range(18, 70, ErrorMessage = " user must be at least 18 years old.")]
        public string DataOfBirth { get; set; }
    }

    public class userBasic
    {
        public void userBasicInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the details of User : ");
            Console.WriteLine();
            Console.WriteLine("Enter your username: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password : ");
            string pass = Console.ReadLine();
            Console.WriteLine("Enter your email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your Date of Birth : ");
            string dob = Console.ReadLine();

            var user = new User()
            {
                userName = name,
                password = pass,
                email = email,
                DataOfBirth = dob
            };

            var context = new ValidationContext(user);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(user, context, results, true);

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
