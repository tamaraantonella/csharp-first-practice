using System;
namespace primer_programa
{
    class Program
    {
    // programa principal (función principal)
    static void Main(string[] args)
    {
      //2. Hacer un programa para ingresar un número
      //y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero
      // “Negativo” si el número es menor a cero o
      //“Cero” si el número es igual a cero.
      int numero;
      Console.WriteLine("Ingrese un número");
      numero = int.Parse(Console.ReadLine());
      if(numero > 0)
        Console.WriteLine("Es positivo");
      else if(numero <0)
        Console.WriteLine("Es negativo");
      else
        Console.WriteLine("Cero");
    }
    }
}