// See https://aka.ms/new-console-template for more information
using System;
namespace primer_programa
{
    class Program
    {
    // programa principal (función principal)
    static void Main(string[] args)
    {
      int a, b;
      Console.WriteLine("Enter the first number:");
      a=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the second number:");
      b=int.Parse(Console.ReadLine());
      int resultado= a+b;
      Console.WriteLine(resultado);
  }
    }
}

