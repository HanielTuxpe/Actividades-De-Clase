namespace Consultorio
{
    class program
    {
        static void Main (string[]args)
        {
            double C, T, P;

            Console.WriteLine("Consulte costo de cita");
            //Entrada
            Console.WriteLine("Ingrese su número de cita");
            C = double.Parse(Console.ReadLine());
            //Proceso
            if (C <= 3)
            {
                P = 200;
                T = C * P;
            }
            else
            {
                if (C <= 5)
                {
                    P = 150;
                    T = ((C-3) * P) + 600;
                }
                else
                {
                    if (C <= 8)
                    {
                        P = 100;
                        T = ((C - 5) * P) + 900;
                    }
                    else
                    {
                        P = 50;
                        T = ((C - 8) * P) + 1200;
                    }
                }
            }
            Console.WriteLine("El pago de la cita es de: $" + P);
            Console.WriteLine("El pago total del tratamiento: " + T);
            //salida
            Console.ReadKey();
        }
    }
}