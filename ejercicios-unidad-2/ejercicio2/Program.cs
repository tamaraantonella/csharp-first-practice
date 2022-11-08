using System;
namespace primer_programa
{
    class Program
    {
    // programa principal (función principal)
    static void Main(string[] args)
    {
      int a,cubo;
      Console.WriteLine("Ingresar un número");
      a = int.Parse(Console.ReadLine());
      cubo = a * a * a;
      Console.WriteLine("el cubo de " + a + " es " + cubo);
    }
    }
}

