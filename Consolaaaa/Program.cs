using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cadena = new Queue<string>();
            Console.WriteLine("Escribe algo y presiona Enter.");
            Console.WriteLine("Presioná Enter sin escrbir nada para ver todo lo que has escrito.");
            Console.WriteLine(" ");

            while (true)
            {
                string UserInput = Console.ReadLine();

                if (UserInput != string.Empty)
                {
                    cadena.Enqueue(UserInput);
                }
                else
                {
                    while (cadena.Count > 0)
                    {
                        string dato = (string)cadena.Dequeue();
                        Console.WriteLine(dato);
                    }

                    break;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Este fue el fin de tu queue. Presiona Enter para cerrar el programa");
            Console.ReadLine();
        }
    }
}
