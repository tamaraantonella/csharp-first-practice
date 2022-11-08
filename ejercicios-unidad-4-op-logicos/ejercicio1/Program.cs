using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
      // La resta si el primero es mayor que el segundo.
      // La suma si son iguales.
      //  El producto si el primero es menor.
      // Se deberá emitir un cartel por pantalla con el resultado correspondiente.
      int a, b;
      Console.WriteLine("Ingrese numero 1");
      a = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese numero 2");
      b = int.Parse(Console.ReadLine());
      if(a > b)
        Console.WriteLine(a - b);
      else if(a < b)
        Console.WriteLine(a * b);
      else
        Console.WriteLine(a + b);
    }
    }
}