using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListsProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList Traductor = new SortedList();
            Traductor.Add("hola", "hello");
            Traductor.Add("adiós", "good bye");
            Traductor.Add("chau", "bye");
            Traductor.Add("vemos", "see");
            Traductor.Add("luego", "later");
            Traductor.Add("nosotros", "we");
            Traductor.Add("yo", "I");
            Traductor.Add("soy", "am");
            Traductor.Add("es", "is");
            Traductor.Add("son", "are");
            Traductor.Add("estás", "are");
            Traductor.Add("sos", "are");
            Traductor.Add("ahora", "now");
            Traductor.Add("programa", "program");
            Traductor.Add("como", "how");
            Traductor.Add("tú", "you");
            Traductor.Add("mi", "my");
            Traductor.Add("mí", "me");
            Traductor.Add("para", "for");
            Traductor.Add("hermoso", "beautiful");
            Traductor.Add("día", "day");
            Traductor.Add("un", "a");

            Console.WriteLine("Escribe una frase en español usando SÓLO estas palabras: ");
            Console.WriteLine("");
            Console.WriteLine("hola, adiós, chau, vemos, luego, nosotros," +
                "\n yo, soy, es, son, estás, sos, ahora,\n" +
                "programa, como, tú, mi, mí, para, un, hermoso, día");
            Console.WriteLine("");
            string UserInput = Console.ReadLine();
            Console.WriteLine(" ");
            for (int i = 0; i < (UserInput.Split(' ')).Length; i++)
            { 
                if (Traductor.ContainsKey((UserInput.Split(' '))[i].ToLower()))
                {
                    Console.WriteLine(Traductor[(UserInput.Split(' '))[i].ToLower()]+" ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Fin del mensaje... se tradujo como pudo");
            Console.WriteLine("Presiona Enter para cerrar el programa");
            Console.ReadLine();
        }
    }
}
