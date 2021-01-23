using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo_4_y_5
{
    class Capitulo_4_Ejercicio_5
    {
      
        public void Average()
        {

            // Declarando Variables
            
            int Age;
            int Sum = 0;
            int Number;
            int Average;
            int Bigger = 0;
            int Younger = 100;
            int People = 0;

            Console.WriteLine("Ingresar cantidad de edades:");
            Number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<Number; i++)
            {
                Console.WriteLine("Ingresar la edad:");
                Age = Convert.ToInt32(Console.ReadLine());

                // Calculamos la Edad más Grande
                if (Age > Bigger)
                {
                    Bigger = Age;
                    People = i;
                }

                // Calculamos la Edad más Joven
                if (Age < Younger)
                {
                    Younger = Age;
                    People -= i;
                }

                // Calculamos el promedio
                Sum += Age;

            }

            // Mostramos el promedio
            Average = Sum / Number;

            Console.WriteLine("La Persona con edad más joven es: {0}", Younger);
            Console.WriteLine("La Persona con edad más grande es: {0}", Bigger);
            Console.WriteLine("El promedio es {0}", Average);
            Console.ReadKey();
        }
    }
}
