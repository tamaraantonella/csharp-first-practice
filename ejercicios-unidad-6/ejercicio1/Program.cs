using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //1. Hacer un programa para ingresar 10 números.
      //El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
      int primos = 0, contador;
      for (int i = 0; i < 10; i++) {
        Console.WriteLine("Ingrese un número");
        int numero = int.Parse(Console.ReadLine());
        contador = 0;
        if(numero == 1 || numero == 2)
          primos++;
        else{
          for (int j = 1; j <= numero; j++) {
            if(numero % j == 0)
              contador++;
          }
          if(contador == 2)
            primos++;
        }
      }
      Console.WriteLine("La cantidad de números primos ingresados es: " + primos);
    }
    }
}