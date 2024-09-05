using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            Console.WriteLine("Escribe algo y presiona Enter.");
            Console.WriteLine("Presioná Enter sin escrbir nada para pasar a modo de consulta.");
            Console.WriteLine(" ");

            while (true)
            {
                string UserInput = Console.ReadLine();

                if (UserInput != string.Empty)
                {
                    lista.Add(UserInput);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Introduce un número para de índice (empezando por 1) para seleccionar el ítem del la lista empezando por esa posición");
            Console.WriteLine("");
            int posNum;
            while (true)
            {
                string posicion = Console.ReadLine();
                if (posicion != "0")
                {
                    try
                    {
                        posNum = Convert.ToInt32(posicion);
                        Console.WriteLine(lista[posNum-1]);
                    }
                    catch
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("El valor ingresado no es un número");
                        Console.WriteLine("Ingrese un valor numérico:");
                        Console.WriteLine(" ");
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
