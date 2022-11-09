
using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
      // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
      // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
      int n ,numerosImpares = 0, mayorGrupo=0, gruposOrdenados=0;
      bool orderFlag;
      for (int i = 1; i <= 5; i++)
      {
        int impares = 0, total = 0, minimo;
        n = int.Parse(Console.ReadLine());
        minimo=n;
        //asumo ordenamiento
        orderFlag = true;
        while (n != 0) {
          total++;
          if (n % 2 != 0) {
            impares++;
          }
          if(n<=minimo){
            minimo=n;
          } else{
            orderFlag = false;
          }
          n= int.Parse(Console.ReadLine());
        }
        int porcentaje = impares * 100 / total;
        if(porcentaje > numerosImpares) {
          numerosImpares = porcentaje;
          mayorGrupo = i;
        }
        if(orderFlag){
          gruposOrdenados ++;
        }

      }
      Console.WriteLine("El grupo con mayor porcentaje de números impares es el " + mayorGrupo);
      Console.WriteLine("Hay " + gruposOrdenados + " grupos ordenados de mayor a menor");
    }
    }
}