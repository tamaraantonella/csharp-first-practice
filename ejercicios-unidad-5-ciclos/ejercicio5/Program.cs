using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //5. Hacer un programa que solicite 20 números
      //y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares
      int mayor=0,menor=0;
      for (int i = 0; i < 20; i++)
      {
        Console.WriteLine("Ingrese un numero");
        int numeroIngresado = int.Parse(Console.ReadLine());
        if (i == 0) {
          mayor = numeroIngresado;
          menor = numeroIngresado;
        }
        if (numeroIngresado % 2 != 0) {
          if (numeroIngresado < menor) {
            menor = numeroIngresado;
          }
         } else
        {
          if (numeroIngresado > mayor)
          {
            mayor = numeroIngresado;
          }
        }
      }
      Console.WriteLine("El maximo de los impares es " + mayor);
      Console.WriteLine("El minimo de los pares es " + menor);
    }
    }
}