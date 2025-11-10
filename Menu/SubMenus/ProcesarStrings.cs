using System;

namespace ACT_MI.SubMenus
{
    public class ProcesarStrings{
        public void Procesar()
        {
            int opcion = 0;

            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("Submenú Strings");
                Console.WriteLine("1. Concatenar");
                Console.WriteLine("2. Buscar ");
                Console.WriteLine("3. Formato");
                Console.WriteLine("4. Volver");
                Console.Write("Elija una Opcion: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Concatenar();
                            break;

                        case 2:
                            
                            break;

                        case 3:
                            
                            break;

                        case 4:
                            Console.WriteLine("Volviendo al menú principal...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Vuelva a intentarlo.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Tiene que ingresar un número válido.");
                }

                if (opcion != 4)
                {
                    Console.WriteLine(" Presione una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
        private void Concatenar()
        {
            Console.Write("Escriba el primer texto: ");
            string texto1 = Console.ReadLine();

            Console.Write("Escriba el segundo texto: ");
            string texto2 = Console.ReadLine();

            string resultado = texto1 + " " + texto2;

            Console.WriteLine($"Texto concatenado: {resultado}");
        }
    }
}

