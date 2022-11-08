using System;
namespace primer_programa
{
    class Program
    {
    // programa principal (función principal)
    static void Main(string[] args)
    {
      //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
      int n1, n2, n3, n4;
      Console.WriteLine("Ingrese numero 1");
      n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese numero 2");
      n2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese numero 3");
      n3 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese numero 4");
      n4 = int.Parse(Console.ReadLine());

      if(n1 > 100)
        Console.WriteLine(n1 +" es mayor a 100");
      if(n2 > 100)
        Console.WriteLine(n2 +" es mayor a 100");
      if(n3 > 100)
        Console.WriteLine(n3 +" es mayor a 100");
      if(n4 > 100)
        Console.WriteLine(n4 +" es mayor a 100");

    }
    }
}
