using System.Collections.Generic;
using System;
using System.Linq;

namespace AportePatronBuilder
{
    public class Program
    {

        public static void Main(string[] args)
        {

            int numero = 0;
            do
            {
                Console.WriteLine("Elija un sabor de helado");
                Console.Write("1. Helado de Chocolate\n2. Helado de Fresa\n3. Helado de Menta\n4. Salir\n");
                numero = int.Parse(Console.ReadLine());
                switch (numero)
                {
                    case 1:
                        //Si el cliente pide Helado de Chocolate
                        Console.WriteLine("\n******************************** DESCRIPCION DE COMPRA *************************************************");
                        var heladochoco = new HeladoChocolateBuilder();
                        Console.WriteLine(heladochoco.BuildHelado());
                        Console.WriteLine("********************************************************************************************************\n");
                        break;

                    case 2:
                        //Si el cliente pide Helado de Fresa
                        Console.WriteLine("\n******************************** DESCRIPCION DE COMPRA *************************************************");
                        var heladofresa = new HeladoFresaBuilder();
                        Console.WriteLine(heladofresa.BuildHelado());
                        Console.WriteLine("********************************************************************************************************\n");
                        break;

                    case 3:
                        //Si el cliente pide Helado de Menta
                        Console.WriteLine("\n******************************** DESCRIPCION DE COMPRA *************************************************");
                        var heladomenta = new HeladoMentaBuilder();
                        Console.WriteLine(heladomenta.BuildHelado());
                        Console.WriteLine("********************************************************************************************************\n");
                        break;
                    case 4:
                        Console.WriteLine("\nFinalizando programa... \n");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }
            } while (numero != 4);
        }
    }
}