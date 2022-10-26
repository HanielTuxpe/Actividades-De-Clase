namespace DescuentoCompra
{
    class program
    {
        static void Main (string[]args)
        {
            double x1 = 0, x2 = 0, a = 0, b = 0, c = 0, p = 0;
            Console.WriteLine("Calculadora Cuadrática");
            //Entrada
            Console.WriteLine("Ingrese el valor de a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de a");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de a");
            c = double.Parse(Console.ReadLine());
            //Proceso
            p = Math.Pow(b, 2) - (4 * a *c);

            if (p >= 0)
            {
                x1 = ((b) + (Math.Sqrt(p))) / (2 * a);
                x2 = ((b) - (Math.Sqrt(p))) / (2 * a);
                Console.WriteLine("X1 es igual a: " + x1);
                Console.WriteLine("X2 es igual a: " + x2);
            }
            else
            {
                Console.WriteLine("No se puede obtener el resultado");
            }
            Console.ReadKey();
        }
    }
}