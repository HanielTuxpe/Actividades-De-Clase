namespace DescuentoCompra
{
    class program
    {
        static void Main (string[]args)
        {
            int P, D, T;
            P = 0;
            D = 0;
            T = 0;
            Console.WriteLine("Consulte el descuento de compra");
            //Entrada
            Console.WriteLine("Ingrese el precio de compra");
            P = int.Parse(Console.ReadLine());
            //Proceso
            if (P >= 200)
            {
                D = (P * 15/100);
                T = P * D;
            }
            else
            {
                if (P >= 100 && P < 200)
                {
                    D = (P * 12/100);
                    T = P - D;
                }
                else
                {
                    if (P < 100 && P >= 1)
                    {
                        D = (P * 10/100);
                        T = P - D;
                    }
                }
            }
            Console.WriteLine("El descuento es de: $" + D);
            Console.WriteLine("El pago total es de: $" + T);
            //salida
            Console.ReadKey();
        }
    }
}