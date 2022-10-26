namespace Calculadora
{
	class program
    {
        public static double fact(double n1)
        {
            if(n1 == 0 || n1 == 1)
                return 1;
            return n1 * fact(n1 - 1);
        }
		static void Main(string[] args)
        {
            char op; string ope = " "; double n1 = 0, n2 = 0, t = 0;
            Console.WriteLine("Calculadora Extendida");
            Console.WriteLine("Qué operacion desea hacer?");
            Console.WriteLine("J = Suma|H = Resta |G = Multiplicación |D = División");
            Console.WriteLine("F = Factorial      |R = Raíz Cuadrada  |E = Elevar al cuadrado|Q = Elevar al cubo");
            Console.WriteLine("S = Seno|C = Coseno|T = Tangente       |L = Logarítmo         |I = Inversa");
            Console.WriteLine("N = Elevar a la 'n'|Ñ = Raíz cuadrada a|P = Porcentaje        |M = Módulo        |O = Redondear");
			op = char.Parse(Console.ReadLine());
            if (char.ToUpper(op) == 'F'||char.ToUpper(op) == 'R'||char.ToUpper(op) == 'E'||char.ToUpper(op) == 'Q'||
                char.ToUpper(op) == 'S'||char.ToUpper(op) == 'C'||char.ToUpper(op) == 'T'||char.ToUpper(op) == 'L'||
                char.ToUpper(op) == 'I'||char.ToUpper(op) == 'O')
            {
			    Console.WriteLine("Ingrese el valor a evaluar");
			    n1 = double.Parse(Console.ReadLine());
                switch(op)
                {
                    case 'f' : case 'F' : t = fact(n1); ope = "!"; break;
                    case 'r' : case 'R' : t = Math.Sqrt(n1); ope = "√"; break;
                    case 'e' : case 'E' : t = Math.Pow(n1,2); ope = "^"; break;
                    case 'q' : case 'Q' : t = Math.Pow(n1,3); ope = "^"; break;
                    case 's' : case 'S' : t = Math.Sin(n1); ope = "sin"; break;
                    case 'c' : case 'C' : t = Math.Cos(n1); ope = "cos"; break;
                    case 't' : case 'T' : t = Math.Tan(n1); ope = "tan"; break;
                    case 'l' : case 'L' : t = Math.Log10(n1); ope = "Log"; break;
                    case 'i' : case 'I' : t = Math.Log(n1); ope = "In"; break;
                    case 'o' : case 'O' : t = Math.Round(n1); ope = " "; break;
                }
                t = Math.Round(t,3); Console.WriteLine("El resultado de " + ope + " de " + n1 + " = " + t);
            }
            else
            {
                if(char.ToUpper(op) == 'N'||char.ToUpper(op) == 'Ñ'||char.ToUpper(op) == 'P'||char.ToUpper(op) == 'M' ||
                   char.ToUpper(op) == 'J'||char.ToUpper(op) == 'H'||char.ToUpper(op) == 'G'||char.ToUpper(op) == 'D')
                {
                    Console.WriteLine("Ingrese el primer valor");
			        n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor");
			        n2 = double.Parse(Console.ReadLine());
                    switch(op)
                    {
                    case 'n' : case 'N' : t = Math.Pow(n1,n2); ope = "^"; break;
                    case 'ñ' : case 'Ñ' : t = Math.Pow(n1,1/n2); ope = "√"; break;
                    case 'p' : case 'P' : t = (n1 / 100) * n2; ope = "%"; break;
                    case 'm' : case 'M' : t = n1 % n2; ope = "mod"; break;
                    case 'j' : case 'J' : t = n1 + n2; ope = "+"; break;
                    case 'h' : case 'H' : t = n1 - n2; ope = "-"; break;
                    case 'g' : case 'G' : t = n1 * n2; ope = "*"; break;
                    case 'd' : case 'D' : t = n1 / n2; ope = "/"; break;
                    }
                    t = Math.Round(t,3); Console.WriteLine("El resultado de " + n1 + " " + ope + " " + n2 + " = " + t);
                }
                else
                {
                    Console.WriteLine("Verificar la opción");
                }
            }
            Console.ReadKey();
		}
	}
}