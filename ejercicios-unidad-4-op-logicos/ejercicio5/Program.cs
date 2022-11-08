using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //5. Hacer un programa para ingresar 4 números.
      //Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

      int first, second, third,fourth;
      Console.WriteLine("Ingrese el primer numero");
      first=int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese el segundo numero");
      second=int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese el tercer numero");
      third=int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese el cuarto numero");
      fourth=int.Parse(Console.ReadLine());
      if(first > second && second > third && third > fourth)
        Console.WriteLine("Los números se encuentran ordenados");
      else
        Console.WriteLine("Los numero no se encuentran ordenados");





    }
    }
}