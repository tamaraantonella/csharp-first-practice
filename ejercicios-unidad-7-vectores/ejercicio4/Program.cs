using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
      // -  Número de Artículo (1 a 15)
      // - Cantidad Vendida 
      // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
      // Se pide determinar e informar:
      // a) El número de artículo que más se vendió en total.
      // b) Los números de artículos que no registraron ventas.
      // c) Cuantas unidades se vendieron del número de artículo 10.
      int articulo,cantidad,max=0, indiceMax=0;

      int[] articulos = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
      int[] cantidadVendida = new int[15];
      Console.WriteLine("Ingrese el numero de articulo");
      articulo = int.Parse(Console.ReadLine());
      while (articulo > 0 && articulo <= 15) {
        Console.WriteLine("Ingrese la cantidad vendida");
        cantidad = int.Parse(Console.ReadLine());
        cantidadVendida[articulo-1] += cantidad;
        Console.WriteLine("Ingrese el numero de articulo");
        articulo = int.Parse(Console.ReadLine());
       }

       for (int i = 0; i < 15; i++)
       {
        if (cantidadVendida[i] > max) {
          max = cantidadVendida[i];
          indiceMax = i;
        }
      }
      for (int i = 0; i < 15; i++)
      {
        if(cantidadVendida[i] == 0){
          Console.WriteLine("El articulo {0} no se vendio", articulos[i]);
        }
      }
      Console.WriteLine("Se vendieron " + cantidadVendida[9] +" del articulo 10");
      Console.WriteLine("El articulo que mas se vendio fue el {0} con {1} unidades", articulos[indiceMax], max);


    }
  }
}