using System.Security.Cryptography.X509Certificates;

namespace ContactManger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactManger contactManger = new ContactManger();
            Console.Clear();
            Console.WriteLine("------------------------------------Simple Contact Manger------------------------------------");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. View All Contacts");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string option = Console.ReadLine();
            switch (option) 
            { 
            
            
            
            }

            




        }
        public void Add(ContactManger manger)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------Enter Details ------------------------------------");
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Phone Number: ");
            string number = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            string Email = Console.ReadLine();
            manger.AddContact(name,number,Email);

        }




    }
}
