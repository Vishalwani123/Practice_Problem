using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem5
{
    public class list1
    {
        List<Contact> l1 = new List<Contact>();
        public void AddContact(Contact contact)
        {
            l1.Add(contact);
            Console.WriteLine("Contact added successfully!");
        }
        public void EditContact(string firstName, string lastName)
        {
            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i].FirstName.Equals(firstName) && l1[i].LastName.Equals(lastName))
                {
                    Console.WriteLine("You can edit contact : ");

                    Console.Write("New Address: ");
                    l1[i].Address = Console.ReadLine();

                    Console.Write("New City: ");
                    l1[i].City = Console.ReadLine();

                    Console.Write("New State: ");
                    l1[i].State = Console.ReadLine();

                    Console.Write("New Zip: ");
                    l1[i].Zip = Console.ReadLine();

                    Console.Write("New Phone Number: ");
                    l1[i].PhoneNumber = Console.ReadLine();

                    Console.Write("New Email: ");
                    l1[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully!");
                    return;

                }
                
            }
            Console.WriteLine("Contact not found!");
        }
        public void DeleteContact(string firstName, string lastName)
        {
            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i].FirstName.Equals(firstName) && l1[i].LastName.Equals(lastName))
                {
                    l1.RemoveAt(i);
                    Console.WriteLine("Contact deleted successfully!");
                    return;
                }

            }
            Console.WriteLine("Contact not found!");
        }
        public void DisplayAllContacts()
        {
            if (l1.Count == 0)
            {
                Console.WriteLine("No contacts in Address Book.");
                return;
            }

            Console.WriteLine("All Contacts:");
            foreach (var contact in l1)
            {
                contact.DisplayContact();
            }
        }


    }
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void DisplayContact()
        {
            Console.WriteLine("The contact details are :");
            Console.WriteLine("The Name of Person is : "+FirstName+" "+LastName+" ");
            Console.WriteLine("The Address : "+Address+" "+City+" "+State+" "+Zip);
            Console.WriteLine("The phone number is : "+PhoneNumber);
            Console.WriteLine("The Email is : "+Email);
        }
    }
    public class Modify
    {
        list1 ls = new list1();
        public void AddContact()
        {
            Contact ct = new Contact();

            Console.WriteLine(" Enter contact details:");
            Console.Write("First Name: ");
            ct.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            ct.LastName = Console.ReadLine();

            Console.Write("Address: ");
            ct.Address = Console.ReadLine();

            Console.Write("City: ");
            ct.City = Console.ReadLine();

            Console.Write("State: ");
            ct.State = Console.ReadLine();

            Console.Write("Zip: ");
            ct.Zip = Console.ReadLine();

            Console.Write("Phone Number: ");
            ct.PhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            ct.Email = Console.ReadLine();

            ls.AddContact(ct);
        }
        public void EditContact()
        {
            Console.Write(" Enter First Name of the contact to edit: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name of the contact to edit: ");
            string lastName = Console.ReadLine();

            ls.EditContact(firstName, lastName);
        }
        public void DeleteContact()
        {
            Console.Write("Enter First Name of the contact to delete: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name of the contact to delete: ");
            string lastName = Console.ReadLine();

            ls.DeleteContact(firstName, lastName);
        }
        public void DisplayAllContacts()
        {
            ls.DisplayAllContacts();
        }
    }
    public class Start
    {
        public void start1()
        {
            Modify md = new Modify();
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. View All Contacts");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string c = Console.ReadLine();

                switch (c)
                {
                    case "1":
                        md.AddContact();
                        break;
                    case "2":
                        md.EditContact();
                        break;
                    case "3":
                        md.DeleteContact();
                        break;
                    case "4":
                        md.DisplayAllContacts();
                        break;
                    case "5":
                        Console.WriteLine("\nExiting Address Book. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice! Please try again.");
                        break;
                }
            }
        }
 
    }
}
