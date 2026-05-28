using System ;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> Musica= new Stack<string>();

        Musica.Push("Cuando el agua esta hirviendo");
        Musica.Push("Recorde");
        Musica.Push("Ama De Mi Sol");
        Musica.Push("Gil");
        Musica.Push("Olimpo");

        string actual = Musica.Peek();
        Console.WriteLine($"Tope actual de cancion : {actual}");
        Console.WriteLine(Musica.Count);

        string retirado = Musica.Pop();
        Console.WriteLine($"Se retiro: {retirado}");
        Console.WriteLine(Musica.Count);

        Console.WriteLine(Musica.Peek());
        // los cambios para guardar
    }
}
