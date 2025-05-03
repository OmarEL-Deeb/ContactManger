using System.Security.Cryptography.X509Certificates;

namespace ContactManger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactManger contactManger = new ContactManger();

            bool running = true;
            while (running)
            {
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
                    case ("1"):
                        Add(contactManger);


                        break;
                    case ("2"):
                        Edit(contactManger);
                        break;

                    case "3":
                        Delete(contactManger);
                        break;
                    case "4":
                        contactManger.VewContacts();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;

                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }





        }             
        public static void Add(ContactManger manger)
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
        public static void Edit (ContactManger manger)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------Enter Details ------------------------------------");
            Console.WriteLine("Enter Name You want to chang : ");
            string oldname = Console.ReadLine();
            Console.WriteLine("Enter New  Name  : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter  New Phone Number: ");
            string number = Console.ReadLine();
            Console.WriteLine("Enter New Email :");
            string Email = Console.ReadLine();
            manger.EditContact(oldname,name, number, Email);

        }
        private static  void Delete(ContactManger manager)
        {
            Console.Write("Enter the name of the contact to delete: ");
            string name = Console.ReadLine();
            manager.DeleteContact(name);
        }




    }
}
