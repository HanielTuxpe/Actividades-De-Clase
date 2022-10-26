namespace Practica1
{
    class program
    {
        static void Main (string[]args)
        {
            int a, b, M;

            Console.WriteLine("Ejemplo 3.1 Uso de variable if");
            Console.WriteLine("Programa para comparar dos valores");
            Console.WriteLine("Ingrese el valor A");
            
            //Entrada
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor B");
            b = int.Parse(Console.ReadLine());
            //Proceso
             
            if (a > b)
            {
                Console.WriteLine("El valor mayor es " + a);
            }
            if (b > a)
            {
                Console.WriteLine("El valor mayor es " + b);
            }
            if (a == b)
            {
                Console.WriteLine("Los valores son iguales");
            }
            //salida
            Console.ReadKey();
        }
    }
}