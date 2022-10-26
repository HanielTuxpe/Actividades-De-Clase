namespace Banco
{
	class pantalones 
    {

		static void Main(string[] args)
        {

			double S, SAt, SA, PA, PCA, I, M, PM, PSI, GPI;
            GPI = 0;
			Console.WriteLine("Ingrese el saldo anterior");
			SAt = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el monto de las compras que realizó");
			PCA = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el pago que depositó en el corte anterior");
			PA = double.Parse(Console.ReadLine());
            PM = SAt * 0.15;
			if ( PM > PA)
            {
                I = SAt * 0.12;
                M = 200;
            }
            else
            {
                I = 0;
                M = 0;
            }
            SA = SAt + PCA - PA + I + M;
            PM = SA * 0.15;
            PSI = SA * 0.85;
            GPI = GPI + I;
			Console.WriteLine("El saldo actual es: $" + SA );
            Console.WriteLine("El pago minimo es de: $" + PM);
            Console.WriteLine("Los intereses son de: $" + I);
            Console.WriteLine("El pago para no generar intereses es de: $" + PSI);
            Console.WriteLine("La ganancia por intereses es de: $" + GPI);
            Console.ReadKey();
		}

	}

}