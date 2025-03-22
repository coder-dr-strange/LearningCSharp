using System;
using System.Reflection;
class Program
{
static void Main()
    {
        Books book1 = new Books();
        book1.Books(Materia, Boericke, isbn, 500);

        Console.WriteLine("What" + Title + "Who" + Boericke + ISBN + "How much" + Price);
        Console.ReadLine();

        Books book2 = new Books();
        book2.Books(Organon, Hahnemann, isbn, 100);

        Console.WriteLine("What" + Title + "Who" + Boericke + ISBN + "How much" + Price);
        Console.ReadLine();


    }




} 