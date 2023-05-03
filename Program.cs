namespace EjercicioSesion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
        }

        public static void Ejercicio1()
        {
            int i = 1;

            Console.WriteLine("Introduzca un número");
            int j = Convert.ToInt32(Console.ReadLine());

            while (i < 11)
            {
                Console.WriteLine(i * j);
                i++;
            }
        }

        public static void Ejercicio2()
        {
            int input = 1;
            int positiveCount = 0;
            int negativeCount = 0;

            do
            {
                Console.WriteLine("Ingrese un número (0 si desea salir)");
                input = Convert.ToInt32(Console.ReadLine());

                if (input > 0)
                {
                    Console.WriteLine("El número ingresado es positivo");
                    positiveCount++;

                }
                else if (input < 0)
                {
                    negativeCount++;
                    Console.WriteLine("El número ingresado es negativo");
                }
                else { Console.WriteLine("Saliendo del programa...."); }
            }
            while (input != 0);

            Console.WriteLine("Cantidad de números positivos: " + positiveCount);
            Console.WriteLine("Cantidad de números negativos: " + negativeCount);
        }

        public static void Ejercicio3()
        {
            int ancho, altura;
            bool relleno = false;

            Console.WriteLine("Vamos a dibujar un cuadrado/rectángulo \nIntroduzca un número para limitar el ancho de la figura: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca un número para limitar la altura de la figura: ");    
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Desea que esté rellena? (s/n)");
            relleno = Console.ReadLine().ToLower() == "s";

            if (ancho == altura) 
            {
                Cuadrado(ancho, relleno);
            }
            else
            {
                Rectangulo(ancho, altura, relleno);
            }
            Console.WriteLine();
        }

        public static void Rectangulo(int ancho, int altura, bool relleno)
        {
            for (int i = 0; i < altura; i++) 
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (relleno || i == 0 || i == altura - 1 || j == 0 || j == ancho - 1)
                    {
                        Console.Write("*");
                    }
                    else { Console.Write(" "); }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Cuadrado(int lado, bool relleno)
        {
            Rectangulo(lado, lado, relleno);
        }
    }
}