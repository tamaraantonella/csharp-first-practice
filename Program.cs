// See https://aka.ms/new-console-template for more information
using System;
namespace primer_programa
{
    class Program
    {
    // programa principal (función principal)
    static void Main(string[] args)
    {
      int a;
      Console.WriteLine("Ingresar un nùmero para elevar al cuadrado");
      a = int.Parse(Console.ReadLine());
      Console.WriteLine("El cuadrado de " + a + " es " + a*a);
    }
    }
}

