using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //4. Hacer un programa para ingresar tres números
      //emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
      int first, second, third;
      Console.WriteLine("Ingrese el primer numero");
      first=int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese el segundo numero");
      second=int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese el tercer numero");
      third=int.Parse(Console.ReadLine());
      int suma = first + second;
      if(suma > second * third){
        Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero");
      }
      else{
        Console.WriteLine("La suma de los dos primeros no es mayor al producto del segundo con el tercero");
      }




    }
    }
}
