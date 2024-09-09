using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase
{
    public class GestionLibros
    {
        //IGNORAR PROFE, ESTO ES DEL VIDEO 006, SIN EJERCICIO
        struct Libro
        {
            public string Titulo;
            public string Autor;
            public int Paginas;
            public int ISBN;
            public string Genero;
        }

        static List<Libro> libros;

        static void Main()
        {
            libros = new List<Libro>();
            string UserInput;
            do
            {
                UserInput = Console.ReadLine().ToUpper();

                switch (UserInput)
                {
                    case "1":
                        Anadir();
                        break;
                    case "2":
                        VerTodos();
                        break;
                    case "3":
                        Buscar();
                        break;
                    case "4":
                        Modificar();
                        break;
                    case "5":
                        Borrar();
                        break;
                    case "6":
                        Ordenar();
                        break;
                    case "S":
                        Salir();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            while (UserInput != "S");

        }
        static void Anadir()
        {
            Libro L;
            Console.WriteLine("Escriba el título del libro:");
            Console.WriteLine(" ");
            L.Titulo = Console.ReadLine();
            Console.WriteLine("Escriba el autor del libro:");
            Console.WriteLine(" ");
            L.Autor = Console.ReadLine();
            Console.WriteLine("Escriba la cantidad de páginas del libro:");
            Console.WriteLine(" ");
            string NumInput;
            int Num;
            while (true)
            {
                NumInput = Console.ReadLine();
                try
                {
                    Num = Convert.ToInt32(NumInput);
                    L.Paginas = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("El valor ingresado no es un número");
                    Console.WriteLine("Ingrese un valor numérico:");
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("Escriba el ISBN del libro:");
            Console.WriteLine(" ");
            while (true)
            {
                NumInput = Console.ReadLine();
                try
                {
                    Num = Convert.ToInt32(NumInput);
                    L.ISBN = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("El valor ingresado no es un número");
                    Console.WriteLine("Ingrese un valor numérico:");
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("Escriba el género del libro:");
            Console.WriteLine(" ");
            L.Genero = Console.ReadLine();

            libros.Add(L);
        }
        static void VerTodos()
        {
            for (int i = 0; i < libros.Count; i++)
            {
                Console.WriteLine("Libro número "+(i + 1)+": ");
                Console.WriteLine("Nombre: "+libros[i].Titulo);
                Console.WriteLine("Autor: "+libros[i].Autor);
                Console.WriteLine("Cantidad de páginas: "+libros[i].Paginas.ToString());
                Console.WriteLine("ISBN: "+libros[i].ISBN.ToString());
                Console.WriteLine("Género/s: "+libros[i].Genero);
                Console.WriteLine(" ");
            }
        }
        static void Buscar()
        {

        }
        static void Modificar()
        {

        }
        static void Borrar()
        {

        }
        static void Ordenar()
        {

        }
        static void Salir()
        {

        }
    }
}
