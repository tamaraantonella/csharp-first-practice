using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos
      // Luego hacer un programa que pida el precio de un artículo
      //y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
      int precio=0, cantidad=0;
      solicitar(ref precio, ref cantidad);
      int resultado = producto(precio, cantidad);
      Console.WriteLine("El monto total a pagar es: {0}", resultado);

    }
    static int producto(int a, int b)
    {
      return a * b;
    }
    static void solicitar(ref int p , ref int c) {
      Console.WriteLine("Ingrese el precio del producto");
      p = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese la cantidad vendida");
      c = int.Parse(Console.ReadLine());
     }
  }
}