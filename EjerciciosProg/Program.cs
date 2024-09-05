// See https://aka.ms/new-console-template for more information
static void Main()
{
    Queue<string> cadena = new Queue<string>();
    Console.WriteLine("Escribe algo y presiona Enter.");
    Console.WriteLine("Presioná Enter sin escrbir nada para ver todo lo que has escrito");

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
                string dato = (string) cadena.Dequeue();
                Console.WriteLine(dato);
            }

            break;
        }
    }

    Console.ReadLine();
    

}