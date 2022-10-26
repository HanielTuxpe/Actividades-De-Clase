namespace Practica7
{
    class program
    {
        static void Main (string[]args)
        {
            double T, P, p1, p2, p3;

            Console.WriteLine("Programa para calcular el presupuesto de un banquete");
            //Entrada
            Console.WriteLine("Ingrese la cantidad de personas del banquete");
            P = double.Parse(Console.ReadLine());
            //Proceso
            if (P > 300)
            {
                T = P * 75;
            }
            else
            {
                if (P >= 200 && P <= 300)
                {
                    T = P * 85;
                }
                else 
                {
                    T = P * 90;
                }
            }
            Console.WriteLine("El pago total es de: " + T);
            //salida
            Console.ReadKey();
        }
    }
}