using System;
using ACT_MI.SubMenus;

namespace ACT_MI
{
    public class Menus
    {
        private ProcesarEnteros _procesarEnteros;
        private ProcesarStrings _procesarStrings;
        private ProcesarArreglos _procesarArreglos;

        public Menus()
        {
            _procesarEnteros = new ProcesarEnteros();
            _procesarStrings = new ProcesarStrings();
            _procesarArreglos = new ProcesarArreglos();
        }

        public void Menu()
        {
            int option = 0;
            while (option != 4)
            {
                Console.WriteLine("Ingrese una opcion del menu:");
                Console.WriteLine("1: Enteros");
                Console.WriteLine("2: Strings");
                Console.WriteLine("3: Arreglos");
                Console.WriteLine("4: Me voy");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                _procesarEnteros.Procesar();
                                break;
                            }
                        case 2:
                            {
                                _procesarStrings.Procesar();
                                break;
                            }
                        case 3:
                            {
                                _procesarArreglos.Procesar();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Me fui");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Intente con una opción del menú válida.");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("El tipo ingresado no es valido.");
                    continue;
                }
            }
        }
    }
}