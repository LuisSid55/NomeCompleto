using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nome;
            String Sobre;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Digite seu nome: ");
            Console.ResetColor();
            Nome = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite seu sobrenome: ");
            Console.ResetColor();
            Sobre = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Formato Padrão:   ");
            Console.ResetColor();
            Console.WriteLine($"{Nome} {Sobre}");
            Sobre = Sobre.ToUpper();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Formato Catálogo: ");
            Console.ResetColor();
            Console.WriteLine($"{Sobre}, {Nome}");
            Console.WriteLine();
        }
    }
}
