using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.
      //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
      int numero;
      bool primo = false;
      Console.WriteLine("Ingrese un numero");
      numero=int.Parse(Console.ReadLine());
      if(numero > 0 && numero < 4)
        Console.WriteLine("El numero es primo");
      for (int i = 2; i < numero; i++)
      {
        if (numero % i == 0)
        {
          primo = true;
          break;
        }
      }
      if (primo)
        Console.WriteLine("El numero no es primo");
      else
        Console.WriteLine("El numero es primo");
    }
    }
}