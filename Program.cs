using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Management System");
            ContactPersonInformation contactPersonInformation = new ContactPersonInformation();
           // contactPersonInformation.AddingContactDetails("Abhishek", "Narwariya", "a", "b", "c", 1, 2, "Abhishek525@gmail.com");
            //contactPersonInformation.AddingContactDetails("Lakshay", "lodhi", "a", "b", "d", 3, 5, "lakshay525@gmail.com");
            contactPersonInformation.DisplayContactDetails();
        }
    }
}