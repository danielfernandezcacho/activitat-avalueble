using System;
using System.Collections.Generic;
using System.Text;

namespace activitat_avalueble
{
    class Program
    {
        public class activitat_avaluable
        {
            int billete5 = 0,billete10 = 0, billete20 = 0, billete50 = 0, billete100 = 0, billete200 = 0, billete500 = 0;

            public void ejercicio_avaluable()
            {

                int precioTotalComida = 0, pagoCliente = 0, cambio = 0;

                string[] menu = new string[5];
                int[] precio = new int[5];

                int seguir = 1;
                bool existe = true;
                bool correcto = false;


                Dictionary<string, int> carta = new Dictionary<string, int>();

                carta.Add("pizza", 50);
                carta.Add("espagetis", 20);
                carta.Add("plato combinado", 7);
                carta.Add("cafe con pasta", 5);
                carta.Add("barbacoa", 10);

                List<string> pedido = new List<string>();

                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == 0)
                    {
                        menu[i] = "pizza";
                    }
                    else if (i == 1)
                    {
                        menu[i] = "espagetis";
                    }
                    else if (i == 2)
                    {
                        menu[i] = "plato combinado";
                    }
                    else if (i == 3)
                    {
                        menu[i] = "cafe con pasta";
                    }
                    else
                    {
                        menu[i] = "barbacoa";
                    }

                    precio[i] = carta[menu[i]];
                }

                Console.WriteLine("que te gustaria comer");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine(menu[i] + " " + precio[i] + " euros");
                }

                while (seguir == 1)
                {
                    seguir = 0;
                    correcto = false;
                    Console.WriteLine("quin plat voldria escollir");
                    pedido.Add(Console.ReadLine());
                    Console.WriteLine("¿vol demanar mes menjar? --> 1.Si / 0.No");
                    while (!correcto)
                    {
                        try
                        {
                            seguir = Convert.ToInt32(Console.ReadLine());
                            correcto = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("tiene que escoger una de las dos opciones la opcion entrada no es valida");
                        }
                    }
                }

                foreach (string comida in pedido)
                {
                    existe = false;
                    for (int i = 0; i < menu.Length; i++)//muestra el menu
                    {
                        if (comida == menu[i])
                        {
                            precioTotalComida += precio[i];
                            existe = true;
                        }
                    }

                    if (!existe) Console.WriteLine("El plato entrado no existe");
                }

                Console.WriteLine("El precio total de la comida es " + precioTotalComida + " euros");
                while (!correcto || pagoCliente < precioTotalComida)
                {
                    correcto = false;
                    Console.WriteLine("El pago es de" + pagoCliente + " euros");
                    Console.WriteLine("introduce la pantidad de la cuenta");
                    try
                    {
                        pagoCliente += Convert.ToInt32(Console.ReadLine());
                        correcto = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Este no es el precio vuelva a intentarlo");
                    }
                }

                cambio = pagoCliente - precioTotalComida;
                if (cambio != 0)
                {
                   cambiocomida(cambio);
                }
            }
            // hace todas las operaciones para calcular todos las opciones de cambio
           
            void cambiocomida(int cambio)
            {
                bool cambioFinalizado = false;
                int restaCambio = 0;

                while (!cambioFinalizado)
                {
                    if (cambio >= 500)
                    {
                        billete500 = cambio / 500;
                        restaCambio = billete500 * 500;
                        cambio -= restaCambio;
                    }

                    else if (cambio >= 200)
                    {
                        billete200 = cambio / 200;
                        restaCambio = billete200 * 200;
                        cambio -= restaCambio;
                    }

                    else if (cambio >= 100)
                    {
                        billete100 = cambio / 100;
                        restaCambio = billete100 * 100;
                        cambio -= restaCambio;
                    }

                    else if (cambio >= 50)
                    {
                        billete50 = cambio / 50;
                        restaCambio = billete50 * 50;
                        cambio -= restaCambio;
                    }

                    else if (cambio >= 20)
                    {
                        billete20 = cambio / 20;
                        restaCambio = billete20 * 20;
                        cambio -= restaCambio;
                    }

                    else if (cambio >= 10)
                    {
                        billete10 = cambio / 10;
                        restaCambio = billete10 * 10;
                        cambio -= restaCambio;
                    }

                    else if (cambio >= 5)
                    {
                        billete5 = cambio / 5;
                        restaCambio = billete5 * 5;
                        cambio -= restaCambio;
                    }

                    else
                    {
                        Console.Write("el cambio sera ");
                        if (billete500 != 0) Console.Write("con " + billete500 + " billetes de 500 ");
                        if (billete200 != 0) Console.Write("con " + billete200 + " billetes de 200 ");
                        if (billete100 != 0) Console.Write("con " + billete100 + " billetes de 100 ");
                        if (billete50 != 0) Console.Write("con " + billete50 + " billetes de 50 ");
                        if (billete20 != 0) Console.Write("con " + billete20 + " billetes de 20 ");
                        if (billete10 != 0) Console.Write("con " + billete10 + " billetes de 10 ");
                        if (billete5 != 0) Console.Write("con " + billete5 + " billetes de 5 ");
                        Console.WriteLine("el cambio es " + cambio + " euros en monedas");
                        cambioFinalizado = true;
                    }
                }
            }
        }
    }
}
