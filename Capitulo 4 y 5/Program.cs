using System;

namespace Capitulo_4_y_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Option;

            //Mostrando el menu principal
            Console.WriteLine("Seleccione Cual Capitulo quiere Ver");
            Console.WriteLine("1. Capitulo 4");
            Console.WriteLine("2. Capitulo 5");
            Console.WriteLine("3. Salir");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Option = Convert.ToInt32(Console.ReadLine());

                if (Option != 3)
                {

                    switch (Option)
                    {

                        case 1:

                            //Mostrando el sub menu 1
                            Console.WriteLine("Selecciono el Capitulo 4: ");
                            Console.WriteLine("1) Ejercicio #1");
                            Console.WriteLine("2) Ejercicio #2");
                            Console.WriteLine("5) Ejercicio #5");

                            Option = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            switch (Option)
                            {

                                case 1:
                                    Console.WriteLine("Ejercicio #1");
                                    Capitulo_4_Ejercicio_1 Capitulo4Ejercicio1 = new Capitulo_4_Ejercicio_1();
                                    Capitulo4Ejercicio1.Calcular();
                                    break;

                                case 2:
                                    Console.WriteLine("Ejercicio #2");
                                    Capitulo_4_Ejercicio_2 Capitulo4Ejercicio2 = new Capitulo_4_Ejercicio_2();
                                    Capitulo4Ejercicio2.Elevator();
                                    break;

                                case 5:
                                    Console.WriteLine("Ejercicio #5");
                                    Capitulo_4_Ejercicio_5 Capitulo4Ejercicio5 = new Capitulo_4_Ejercicio_5();
                                    Capitulo4Ejercicio5.Average();
                                    break;
                            }
                            break;

                        case 2:

                            //Mostrando el sub menu 2
                            Console.WriteLine("Selecciono el Capitulo 5: ");
                            Console.WriteLine("4) Ejercicio #4");
                            Console.WriteLine("5) Ejercicio #5");
                            Option = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            switch (Option)
                            {
                                case 4:
                                    Console.WriteLine("Ejercicio #4");
                                    Capitulo_5_Ejercicio_4 Capitulo5Ejercicio4 = new Capitulo_5_Ejercicio_4();
                                    Capitulo5Ejercicio4.Calculate();
                                    break;

                                case 5:
                                    Console.WriteLine("Ejercicio #5");
                                    Capitulo_5_Ejercicio_5 Capitulo5Ejercicio5 = new Capitulo_5_Ejercicio_5();
                                    Capitulo5Ejercicio5.Display();
                                    break;
                            }
                            break;
                    }

                }
                break;

            } while (Option != 3);
            Console.ReadKey();
        }
    }
}
