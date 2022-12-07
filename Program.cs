using AddressBook;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----Welcome to AddressBook System Program----");
            Console.WriteLine("Enter the details to create a contact");
            Address obj = new Address();
            obj.create();
            obj.display();
            //Console.ReadLine();
        }
    }
}
