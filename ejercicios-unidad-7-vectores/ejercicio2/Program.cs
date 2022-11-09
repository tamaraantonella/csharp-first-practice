using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector.
      // Luego recorrer ese vector para calcular el promedio.
      //Mostrar por pantalla los valores que son mayores al promedio.
      int acc = 0;
      int promedio;
      int[] numeros = new int[10];
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("Ingrese un numero");
        numeros[i] = int.Parse(Console.ReadLine());
        acc+=numeros[i];
      }
      promedio = acc/10;
      for (int i = 0; i < 10; i++)
      {
        if (numeros[i] > promedio) {
          Console.WriteLine("El numero " + numeros[i] + " es mayor al promedio");
        }
      }
    }
    }
}