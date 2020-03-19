using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homeWorkLesson8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = new XDocument();

            XElement myContacts = new XElement("MyContacts");

            myContacts.Add(new XElement("Contact", new XAttribute("Name", "Vasya"), new XAttribute("TelephoneNumber", 444555)));
            myContacts.Add(new XElement("Contact", new XAttribute("Name", "Petya"), new XAttribute("TelephoneNumber", 344532)));
            myContacts.Add(new XElement("Contact", new XAttribute("Name", "Olya"), new XAttribute("TelephoneNumber", 123123)));

            document.Add(myContacts);

            document.Save("TelephoneBook.xml");

            Console.ReadKey();

        }
    }
}
