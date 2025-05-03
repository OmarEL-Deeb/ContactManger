using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManger
{
    internal class ContactManger
    {
        List<Contact> contacts= new List<Contact>();

        public void AddContact(string name , string phone, string email)
        {
            var newcontact = new Contact(name,phone,email);
            contacts.Add(newcontact);
            LogAction("Added", newcontact);
        }
        public void EditContact (string oldname, string newname , string newphone,string newemail)
        {
            var contact = contacts.Find(c=>c.Name.Equals(oldname,StringComparison.OrdinalIgnoreCase));
                if (contact != null)
            {
                contact.Name = newname;
                contact.Phone_Number = newphone;
                contact.Email = newemail;
            }
            LogAction("Edited", contact);
        }
        public void DeleteContact(string name)
        {
            var contact = contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (contact != null)
            {
                contacts.Remove(contact);

            }
            LogAction("Deleted", contact);

        }
        public void VewContacts()
        {
            if (contacts.Count == 0)
            { Console.WriteLine("\"No contacts available.\""); }
            else 
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact); 
                }
            }
        }
        private void LogAction(string action, Contact contact)
        {
            string log = $"{DateTime.Now}: {action} - {contact}";
            
            Console.WriteLine(log); 
        }


    }


}
