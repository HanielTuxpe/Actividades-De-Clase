namespace Calculadora
{
	class program
    {
		static void Main(string[] args)
        {
            char op, ope = ' ';
			double n1 = 0, n2 = 0, t = 0;
            Console.WriteLine("Calculadora");
            Console.WriteLine("Qué operacion desea hacer?");
            Console.WriteLine("D = División \nM = Multiplicación");
            Console.WriteLine("R = Resta \nS = Suma");
			op = char.Parse(Console.ReadLine());
            if (op == 'S' || op == 'R' || op == 'D' || op == 'M')
            {
			    Console.WriteLine("Ingrese el primer valor");
			    n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo valor valor");
			    n2 = double.Parse(Console.ReadLine());
                switch(op)
                {
                    case 'S' : t = n1 + n2; ope = '+'; break;
                    case 'M' : t = n1 * n2; ope = '*'; break;
                    case 'R' : t = n1 - n2; ope = '-'; break;
                    case 'D' : t = n1 / n2; ope = '/'; break;
                }
                Console.WriteLine("El resultado de " + n1 + ope + n2 + "=" + t);
            }
            else
            {
                Console.WriteLine("Verificar la opción");
            }
            Console.ReadKey();
		}
	}
}