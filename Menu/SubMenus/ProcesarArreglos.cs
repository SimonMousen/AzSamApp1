using System;
using System.Linq;

namespace ACT_MI.SubMenus
{
    public class ProcesarArreglos
    {
        public void Procesar()
        {
            int option = 0;
            while (option != 5)
            {
                Console.Clear();
                Console.WriteLine("=== PROCESAR ARREGLOS ===");
                Console.WriteLine("1. Crear arreglo");
                Console.WriteLine("2. Ordenar arreglo");
                Console.WriteLine("3. Buscar elemento");
                Console.WriteLine("4. Unir y arreglar");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Seleccione una opción: ");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    int[] arreglo = new int[0];

                    switch (option)
                    {
                        case 1:
                            arreglo = CrearArreglo();
                            MostrarArreglo(arreglo);
                            break;
                        case 2:
                            arreglo = CrearArreglo();
                            OrdenarArreglo(arreglo);
                            break;
                        case 3:
                            arreglo = CrearArreglo();
                            BuscarElemento(arreglo);
                            break;
                        case 4:
                            UnirYArreglar();
                            break;
                        case 5:
                            Console.WriteLine("Volviendo al menú principal...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }

                    if (option != 5)
                    {
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: El tipo ingresado no es válido.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        private int[] CrearArreglo()
        {
            Console.Write("Ingrese el tamaño del arreglo: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[] arreglo = new int[tamaño];
            
            Console.WriteLine("Ingrese los elementos del arreglo:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Elemento [{i + 1}]: ");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arreglo;
        }

        private void MostrarArreglo(int[] arreglo)
        {
            Console.WriteLine("\nArreglo creado:");
            Console.WriteLine($"[{string.Join(", ", arreglo)}]");
        }

        private void OrdenarArreglo(int[] arreglo)
        {
            Array.Sort(arreglo);
            Console.WriteLine("\nArreglo ordenado:");
            Console.WriteLine($"[{string.Join(", ", arreglo)}]");
        }

        private void BuscarElemento(int[] arreglo)
        {
            Console.Write("Ingrese el elemento a buscar: ");
            int elemento = Convert.ToInt32(Console.ReadLine());

            int indice = Array.IndexOf(arreglo, elemento);
            
            if (indice != -1)
            {
                Console.WriteLine($"Elemento encontrado en la posición: {indice}");
            }
            else
            {
                Console.WriteLine("Elemento no encontrado en el arreglo");
            }
        }

        private void UnirYArreglar()
        {
            Console.WriteLine("=== CREAR PRIMER ARREGLO ===");
            int[] arreglo1 = CrearArreglo();
            
            Console.WriteLine("=== CREAR SEGUNDO ARREGLO ===");
            int[] arreglo2 = CrearArreglo();

            int[] arregloUnido = new int[arreglo1.Length + arreglo2.Length];
            Array.Copy(arreglo1, arregloUnido, arreglo1.Length);
            Array.Copy(arreglo2, 0, arregloUnido, arreglo1.Length, arreglo2.Length);

            Array.Sort(arregloUnido);

            Console.WriteLine("\nArreglos unidos y ordenados:");
            Console.WriteLine($"Arreglo 1: [{string.Join(", ", arreglo1)}]");
            Console.WriteLine($"Arreglo 2: [{string.Join(", ", arreglo2)}]");
            Console.WriteLine($"Unido y ordenado: [{string.Join(", ", arregloUnido)}]");
        }
    }
}