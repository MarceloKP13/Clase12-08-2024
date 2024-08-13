using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12_08_2024
{
    public class Mate
    {
        public int num1DelaClaseMate;
        public int num2DelaClaseMate;

        public void pedirDatos()
        {
            Console.WriteLine("Ingrese un numero entero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero entero: ");
            num2 = int.Parse(Console.ReadLine());
        }
    }
}
