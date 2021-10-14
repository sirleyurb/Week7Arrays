using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajale hommikusöögi menüüd
            //programm palub kasutajal teha valikut
            //programm kuvab kasutaja valikut konsoolis

            string[] menu = {"Omlett", "Pannkoogid", "Keedumuna", "Puder", "Singivõileib"};
            Console.WriteLine($"Meie menüüs on {menu.Length} valikut.");

            menu[4] = "Juustuvõileib";
            menu[3] = "Kaerapuder";

            Console.WriteLine("Tänases menüüs on:");

            for (int i = 0; i < menu.Length; i++)
            {
                if(menu[i] == "Puder")
                {
                    menu[i] = "Kaerapuder";
                }
            else if (menu[i] == "Singivõileib")
                {
                    menu[i] = "Juustuvõileib";
                }

                Console.WriteLine(menu[i]);  
            }

            Console.WriteLine("Tee oma valik (sisesta numbrid 1-5):");
            int userChoice = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine($"Olete valinud {menu[userChoice]}");

            /*foreach(string menuElement in menu)
            {
                Console.WriteLine(menuElement);
            }
            */
        }
    }
}
