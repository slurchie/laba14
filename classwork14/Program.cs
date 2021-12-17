using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commercial;

namespace classwork14
{
    class Program
    {       
            static void Main(string[] args)
            {
            BankAccount account = new BankAccount(4364, Commercial.Type.Сберегательный, 1000);
            account.DumpToScreen();

            RNumbers rational = new RNumbers(7,6);
            object[] obj = typeof(RNumbers).GetCustomAttributes(false);
            Console.WriteLine((obj[0] as DeveloperInfoAttribute).Date);

        }
        void DisplayInfo()
        { object[] objArray = typeof(RNumbers).GetCustomAttributes(false);
            foreach (var item in objArray)
            {
                DeveloperInfoAttribute attr = item as DeveloperInfoAttribute;
                if (attr != null)
                {
                    Console.WriteLine($"Имя разработчика: {attr.Developer}");
                    Console.WriteLine($"Дата: {attr.Date}");
                }

            }
}
    }
}
