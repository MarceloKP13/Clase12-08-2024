using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12_08_2024
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            /*Persona1 persona1 = new Persona1("Marcelo", 22);

            persona1.Nombre = "Marcelo";
            string nombre = persona1.Nombre;
            Console.WriteLine(persona1.Nombre);

            Estudiante student = new Estudiante("Marcelo", 3,8, 20);

            student.saludar();
            student.imprimirDatos();*/

            ////////////////////////////////////////////////////////////////////////////////////////
            
            /*Crear lista de objetos
             List + <>
            Palabra reservada lis y dentro de < el nombre de la clase de la que vamos a ahcer un lista de objetos>
            1. Listi<Estudiante> se indica al programa que voy acrear una lista de tipo Perosna
            2.listEs, es el nombre de la lista
            3.new List<Estudaite> creamos la lista*/

            List<Estudiante> listEs = new List<Estudiante>();
            listEs.Add(new Estudiante("Marcelo",22,4,2));
            listEs.Add(new Estudiante("Jose", 17,8,1));
            listEs.Add(new Estudiante("Maria", 20, 4, 2));
            listEs.Add(new Estudiante("Juan", 16, 11, 1));
            listEs.Add(new Estudiante("Sammy", 14, 9, 4));
            listEs.Add(new Estudiante("Lennin", 18, 7, 1));



            foreach (Estudiante i in listEs)
                /*foreach se utiliza para iterar en colecciones de datos
            () dentr colocalmos:
            1. el tipo de dato, en este caso Estudiante
            2. nombre de la variable que va a iterar por cada objeto en este caso es [i]
            3. in significa dentre, se indica donde voy a iterar en este caso se va a iteraren este caso voy 
            a iterar en una lista de objetos que es [ListEs]
            */
                //i puede acceder a los atributos y metodos de la clase
                //Imprimir todo los estudiantes de primer semestre
                /*if (i.nivelSemestre == 1) 
            {
                    Console.WriteLine(i.nombre);
                    i.imprimirDatos();*/
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //imprimir personas que sean mayores de edad

                /*bool esMayor = i.CalcularEdad;
            if (esMayor)
            {
                i.CalcularEdad();
            }*/

                /* Console.WriteLine(i.CalcularEdad());*/

                Persona1 p = new Persona1("Marce",22);



            Console.ReadKey();

        }
    }
}
