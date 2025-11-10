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
                            Buscar();
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
        private void Buscar()
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();

            Console.Write("Ingrese la palabra a buscar: ");
            string palabra = Console.ReadLine();

            if (frase.Contains(palabra))
            {
                Console.WriteLine("La palabra fue encontrada en la frase.");
            }
            else
            {
                Console.WriteLine("La palabra NO se encuentra en la frase.");
            }

            string palabraMinus = palabra.ToLower();
            int a = 0, e = 0, i = 0, o = 0, u = 0;

            foreach (char c in palabraMinus)
            {
                switch (c)
                {
                    case 'a': a++; break;
                    case 'e': e++; break;
                    case 'i': i++; break;
                    case 'o': o++; break;
                    case 'u': u++; break;
                }
            }

            int totalVocales = a + e + i + o + u;

            Console.WriteLine($"\nLa palabra \"{palabra}\" tiene {totalVocales} vocal(es):");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"o = {o}");
            Console.WriteLine($"u = {u}");
        }
    }
}

