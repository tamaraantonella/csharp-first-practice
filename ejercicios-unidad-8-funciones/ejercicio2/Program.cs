using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
      // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
      int esPar=0;
      int numero = 0;
      for (int i = 0; i < 20; i++)
      {
        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
        esPar = par(numero);
        if(esPar == 1){
          Console.WriteLine("El numero {0} es par", numero);
        } else {
          Console.WriteLine("El numero {0} no es par", numero);
        }
      }
    }
    static int par(int n1)
    {
      if (n1 % 2 == 0)
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }
  }
}