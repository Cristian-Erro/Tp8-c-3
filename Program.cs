using System;

namespace Tp8_c_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables y array
            
            float[]numeros;
            numeros=new float[6];
            float sumador=0;
            //ciclos for para cargar el array y sumar valores cargados

            for(int i=0;i<=numeros.Length-1;i++){
                System.Console.WriteLine("Ingrese el numero para la posicion "+i);
                numeros[i]=Convert.ToSingle(Console.ReadLine());
            }
            for(int i=0;i<=numeros.Length-1;i++){
                sumador+=numeros[i];
            }
            //muestra el resultado

            Console.Clear();
            System.Console.WriteLine("El promedio de sus numeros es "+(sumador/numeros.Length));
        }
    }
}
