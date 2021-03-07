using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volumen_de__un_cilindro
{
    class Program
    {
        static void Main(string[] args)
        {

            double altura;
            double diametro;
            double radio;
            double volumen;
            double cuadrado;



            Console.WriteLine("Volumen de un cilindro.");
            Console.WriteLine(" ");

            Console.WriteLine("Escribe el valor de la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el valor del diametro: ");
            diametro  = Convert.ToDouble(Console.ReadLine());


            radio = diametro / 2;
            cuadrado= Math.Pow (radio,2);


            volumen = 3.1416 * cuadrado * altura;


            Console.WriteLine("Este es el volumen del cilindro: " + volumen );
                      

            Console.ReadKey();


        }
    }
}
