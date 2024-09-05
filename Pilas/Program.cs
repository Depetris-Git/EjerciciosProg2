using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pila = new Stack<string>();
            Console.WriteLine("Escribe algo y presiona Enter.");
            Console.WriteLine("Presioná Enter sin escrbir nada para ver todo lo que has escrito.");
            Console.WriteLine(" ");

            while (true)
            {
                string UserInput = Console.ReadLine();

                if (UserInput != string.Empty)
                {
                    pila.Push(UserInput);
                }
                else
                {
                    int max = pila.Count;
                    for (int i = 0; i < max; i++)
                    {
                        string dato = (string)pila.Pop();
                        Console.WriteLine(dato);
                    }

                    break;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Este fue el fin de tu pila. Presiona Enter para cerrar el programa");
            Console.ReadLine();
        }
    }
}
