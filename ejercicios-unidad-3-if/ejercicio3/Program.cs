using System;
namespace primer_programa
{
    class Program
    {
    // programa principal (función principal)
    static void Main(string[] args)
    {
      //3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
      // Si el importe es menor a ARS 1000, no hay descuento.
      // Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
      // Si el importe es ARS 5000 o más, aplica un descuento del 18%.
      //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.
      float venta,descuento;
      Console.WriteLine("Ingrese el importe de la venta");
      venta = float.Parse(Console.ReadLine());
      if(venta >= 5000)
        Console.WriteLine("El importe final es " + venta * 0.82 );
      else if(venta >= 1000 && venta < 5000)
        Console.WriteLine("El importe final es " +  venta * 0.90);
      else
        Console.WriteLine("No hubo descuento, el importe es "+ venta);
    }
    }
}
