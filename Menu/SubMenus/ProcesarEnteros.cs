using System;

namespace ACT_MI.SubMenus
{
    public class ProcesarEnteros
    {
        public void Procesar()
        {
            int opcion = 0;
            while (opcion != 6)
            {
                Console.WriteLine("MENU ENTERO");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Otra");
                Console.WriteLine("6. Volver");
                Console.Write("Seleccione una opción: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Sumar();
                            break;
                        case 2:
                            Restar();
                            break;
                        case 3:
                            Multiplicar();
                            break;
                        case 4:
                            Dividir();
                            break;
                        case 5:
                            Otra();
                            break;
                        case 6:
                            Console.WriteLine("Volviendo..");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debe ingresar un numero valido.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }
            }
        }

        private void Sumar()
        {
            Console.WriteLine("SUMA");
            Console.Write("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int resultado = num1 + num2;
            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
        }

        private void Restar()
        {
            Console.WriteLine("RESTA");
            Console.Write("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int resultado = num1 - num2;
            Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
        }

        private void Multiplicar()
        {
            Console.WriteLine("MULTIPLICACIÓN");
            Console.Write("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int resultado = num1 * num2;
            Console.WriteLine($"Resultado: {num1} × {num2} = {resultado}");
        }

        private void Dividir()
        {
            Console.WriteLine("DIVISIÓN");
            try
            {
                Console.Write("Ingrese el dividendo: ");
                int dividendo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                if (divisor == 0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                    return;
                }

                int resultado = dividendo / divisor;
                Console.WriteLine($"Resultado: {dividendo} ÷ {divisor} = {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: División entre cero no permitida.");
            }
        }

        private void Otra()
        {
            Console.WriteLine("OTRAS OPERACIONES");
            Console.Write("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
            Console.WriteLine($"Elevado al cuadrado: {numero * numero}");
            Console.WriteLine($"¿Es par?: {(numero % 2 == 0 ? "Sí" : "No")}");
            Console.WriteLine($"¿Es positivo?: {(numero >= 0 ? "Sí" : "No")}");
        }
    }
}