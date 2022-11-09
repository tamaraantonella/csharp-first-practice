
using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
      //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
      int[] numeros = new int[10];
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("Ingrese un numero");
        numeros[i] = int.Parse(Console.ReadLine());
      }
      int maximo = numeros[0];
      for (int i = 0; i < 10; i++)
      {
        if (numeros[i] > maximo) {
          maximo = numeros[i];
        }
      }
      Console.WriteLine("El numero maximo es " + maximo);
    }
    }
}