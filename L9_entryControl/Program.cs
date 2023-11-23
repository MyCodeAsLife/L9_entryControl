using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_entryControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string userInput;

            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine("Чтобы выйти из программы напишите слово - exit");
                userInput = Console.ReadLine();

                if (userInput == "exit")
                    isOpen = false;
            }

        }
    }
}
