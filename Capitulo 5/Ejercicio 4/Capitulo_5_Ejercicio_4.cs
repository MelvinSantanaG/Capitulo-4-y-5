using System;

namespace Capitulo_4_y_5
{
    class Capitulo_5_Ejercicio_4
    {
        //Declarando la variable
        int Number;
        int Factorial = 1;

        public void Calculate()
        {
            Console.WriteLine("Digite el Numero");

            //Pediendo el numero
            Number = Convert.ToInt32(Console.ReadLine());

            //Calculando el numero introducido
            for (int i = 1; i<=Number; i++)
            {
                Factorial *= i;
            }

            //Mostrando el resultado 
            Console.WriteLine("El Factorial de {0} es {1}",Number,Factorial);
        }
    }
}
