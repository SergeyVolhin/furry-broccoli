using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Buyer
    {
        public string lastName;
        public string firstName;
        public string middleName;
        public string adress;
        internal long bankAccount;
        internal long creditCard;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer = new Buyer();
            buyer.lastName = "Вольхин";
            buyer.middleName = "Алексеевич";
            buyer.firstName = "Сергей";
            buyer.adress = "ул.Нескажукакая д.22";
            buyer.creditCard = 1923716417823;
            buyer.bankAccount = 91827346123;
            Console.WriteLine(buyer.lastName);
            Console.WriteLine(buyer.firstName);
            Console.WriteLine(buyer.middleName);
            Console.WriteLine(buyer.adress);
            Console.WriteLine(buyer.creditCard);
            Console.WriteLine(buyer.bankAccount);
            Console.ReadKey();
        }
    }
}
