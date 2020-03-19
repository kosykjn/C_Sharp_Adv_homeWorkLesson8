using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homeWorkLesson8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load("TelephoneBook.xml");

            foreach (XElement element in document.Element("MyContacts").Elements("Contact"))
            {
                Console.WriteLine($"Имя: {element.Attribute("Name").Value}");
                Console.WriteLine($"Номер телефона: {element.Attribute("TelephoneNumber").Value}");

                Console.WriteLine(Environment.NewLine);
            }

            Console.ReadKey();
        }
    }
}
