namespace Panatlones
{
	class pantalones 
    {

		static void Main(string[] args)
        {
			string modelo;
            int talla;
			double CP, PDM, PT, IT, G, PF, ST, CT, PP;
            PP = 0;
            PDM = 0;
			Console.WriteLine("¿cuanto cuesta el metro de tela?");
			PT = Double.Parse(Console.ReadLine());
			Console.WriteLine("¿Cuantos pantalones se quieren producir?");
			CP = Double.Parse(Console.ReadLine());
			Console.WriteLine("¿Que modelo es el pantalon? A y B)");
			modelo = Console.ReadLine();
			Console.WriteLine("¿Que talla es el pantalon? (30,32,36)");
			talla = int.Parse(Console.ReadLine());
			if (modelo == "A")
            {
                CT = 1.5 * PT;
                PDM = CT * 0.8;
            }
            else
            {
                CT = 1.8 * PT;
                PDM = CT * 0.95;                
            }
            if(talla == 32 || talla == 36)
            {
                IT = (CT + PDM) * 0.04;
            }
            else
            {
                IT = 0;
            }
			ST = CT + PDM + IT;
            G = (ST * .30);
            PP = ST + G;
			PF = G * CP;
            PT = PP * CP;
			Console.WriteLine("El precio final por pantalon es de: $" + PP);
            Console.WriteLine("La ganancia por pantalón es de: $" + G);
            Console.WriteLine("La ganancia total es de: $" + PF);
            Console.WriteLine("El precio de venta total es de: $" + PT);
            Console.ReadKey();
		}

	}

}