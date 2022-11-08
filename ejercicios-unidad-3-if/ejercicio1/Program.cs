using System;
namespace primer_programa
{
    class Program
    {
    // programa principal (función principal)
    static void Main(string[] args)
    {
      //1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
      int numero;
      Console.WriteLine("Ingrese un número");
      numero = int.Parse(Console.ReadLine());
      if(numero > 10)
        Console.WriteLine("Es mayor a 10");
      else
        Console.WriteLine("Es menor a 10");
    }
    }
}
