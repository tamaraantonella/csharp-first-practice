
using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
      //El fin de la carga se notifica con un número negativo.
      //Luego mostrar cuántos números tiene cada lista.
      int n, total = 0;
      n = int.Parse(Console.ReadLine());
      while (n >= 0) {
        while (n != 0) {
          total++;
          n= int.Parse(Console.ReadLine());
        }
        Console.WriteLine("La lista tiene " + total + " números");
        total = 0;
        n = int.Parse(Console.ReadLine());
      }

    }
    }
}