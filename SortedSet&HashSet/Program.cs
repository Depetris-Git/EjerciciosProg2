using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> ListaInputs = new SortedSet<string>();
            string UserInput = "";
            Console.WriteLine("Escribe una frase y presiona Enter para guardar dicha frase.");
            Console.WriteLine("El programa le avisará si ya había agregado la clave con antelación o no.");
            Console.WriteLine("Presione Enter sin escribir nada para terminar\n");
            while (true)
            {
                UserInput = Console.ReadLine();
                if (UserInput != "")
                {
                    if (ListaInputs.Contains(UserInput))
                    {
                        Console.WriteLine("\nYa ingresó ["+UserInput+"] anteriormente");
                        Console.WriteLine("Ingrese otra frase y presione Enter para continuar\n" +
                            "O presione Enter sin ingresar nada para salir\n");
                    }
                    else
                    {
                        ListaInputs.Add(UserInput);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
