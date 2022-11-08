using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
    // 3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
                  // 	i5 (1) 	i7 (2) 	i9 (3)
    // 8 RAM (1) 	USD 800 	USD 900 	USD 1200
    // 16 RAM (2) 	USD 900 	USD 1000 	USD 1400
    // 32 RAM (3) 	USD 1000 	USD 1400 	USD 2000
    // Además, el equipo viene con un disco que permite almacenar 500 GB de información
    // y que se puede ampliar a 1 TB si así lo desea
    // lo cual tiene un costo  adicional de USD 300. 
    //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) 
    //y calcule y emita por pantalla el monto de la máquina seleccionada.
      int ram, procesador,total;
      Console.WriteLine("Ingrese el procesador deseado (1) i5 (2) i7 (3) i9");
      procesador = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese la memoria RAM deseada (1) 8GB (2) 16GB (3) 32GB");
      ram = int.Parse(Console.ReadLine());
      Console.WriteLine("Desea extender el disco? (1) si (0) no");
      int disco = int.Parse(Console.ReadLine());
      if(disco == 1){
        total = 300;
      }
      else{
        total = 0;
      }
      switch (procesador)
      {
        case 1:
          switch (ram)
          {
            case 1:
              total += 800;
              Console.WriteLine(total);
              break;
            case 2:
              total += 900;
              Console.WriteLine(total);
              break;
            case 3:
              total += 1000;
              Console.WriteLine(total);
              break;
          }
          break;
        case 2:
          switch (ram)
          {
            case 1:
              total += 900;
              Console.WriteLine(total);
              break;
            case 2:
              total += 1000;
              Console.WriteLine(total);
              break;
            case 3:
              total += 1400;
              Console.WriteLine(total);
              break;
          }
          break;
        case 3:
          switch (ram)
          {
            case 1:
              total += 1200;
              Console.WriteLine(total);
              break;
            case 2:
              total += 1400;
              Console.WriteLine(total);
              break;
            case 3:
              total += 2000;
              Console.WriteLine(total);
              break;
          }
          break;
        default:
          Console.WriteLine("Opcion no valida");
          break;
      }
    }
    }
}