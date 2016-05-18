using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Libreria El Buen Lector";
            string cliente = "";
            string numeroTelefono = "";
            string libro = "";
            string msj = "yes";
            double montoAPagar = 0;
            int numero = 0;
            int cantidad;
            int calculo = 0;
            double descuento = 0;
            int pago = 0;
            double vuelto = 0;
            double impuestoVenta = 0;
            string mensaje = "";


            Console.Write("Digite su nombre");
            cliente = Console.ReadLine();

            Console.Write("Digite su numero de telefono");
            numeroTelefono = Console.ReadLine();

            /*switch (libro) { 
                case 1:
                    Console.WriteLine("");
            
            
            }*/

            
            Console.WriteLine("===================================");
            Console.WriteLine("*_*   " + titulo + "   *_*");
            Console.WriteLine("Lista de Libros");
            Console.WriteLine("===================================");
            Console.WriteLine("1- El Senor de los Anillos. Las Dos Torres. (fantasia)");
            Console.WriteLine("2- Alicia en el pais de las Maravillas. (infantil)");
            Console.WriteLine("3- Sementerio de Mascotas. (misterio)");
            Console.WriteLine("4- Quiero Aprender. (educativo)");
            Console.WriteLine("5- El Poder del Pensamiento Positivo. (superacion)");
            Console.WriteLine("6- El primer libro de matematicas. (educativo)");
            Console.WriteLine("7- Las Aventuras de Tom Sawyer. (infantil)");
            Console.WriteLine("8- El Mago de Oz. (fantasia)");
            Console.WriteLine("9- La Zona Muerta. (misterio)");
            Console.WriteLine("10- Viaje al Centro de la Tierra. (ciencia ficcion)");

            Console.Write("Que libro desea comprar, seleccione segun el numero a su izquierda");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Cuantas unidades desea comprar?");
            cantidad = int.Parse(Console.ReadLine());

            if (numero == 2 || numero == 7)
            {
                calculo = cantidad * 2500;
                descuento = (calculo * 0.05) - calculo;
                montoAPagar = (calculo - descuento) + impuestoVenta;
                impuestoVenta = montoAPagar * 0.13;
                Console.Write("El monto total a pagar es de " + montoAPagar);
                Console.Write("Con cuanto desea cancelar?");
                pago = int.Parse(Console.ReadLine());
                vuelto = pago - montoAPagar;

            }
            else if(numero == 3 || numero == 9){
                calculo = cantidad * 2500;
                descuento = (calculo * 0.1) - calculo;
                montoAPagar = (calculo - descuento) + impuestoVenta;
                impuestoVenta = montoAPagar * 0.13;
                Console.Write("El monto total a pagar es de " + montoAPagar);
                Console.Write("Con cuanto desea cancelar?");
                pago = int.Parse(Console.ReadLine());
                vuelto = pago - montoAPagar;

            }
            else if (numero == 4 || numero == 6)
            {
                calculo = cantidad * 2500;
                descuento = (calculo * 0.2) - calculo;
                montoAPagar = (calculo - descuento) + impuestoVenta;
                impuestoVenta = montoAPagar * 0.13;
                Console.Write("El monto total a pagar es de " + montoAPagar);
                Console.Write("Con cuanto desea cancelar?");
                pago = int.Parse(Console.ReadLine());
                vuelto = pago - montoAPagar;

            }
            else if (numero == 1 || numero == 8)
            {
                calculo = cantidad * 2500;
                descuento = (calculo * 0.15) - calculo;
                montoAPagar = (calculo - descuento) + impuestoVenta;
                impuestoVenta = montoAPagar * 0.13;
                Console.Write("El monto total a pagar es de " + montoAPagar);
                Console.Write("Con cuanto desea cancelar?");
                pago = int.Parse(Console.ReadLine());
                vuelto = pago - montoAPagar;

            }
            else
            {
                calculo = cantidad * 2500;
                descuento = (calculo * 0.25) - calculo;                
                montoAPagar = (calculo - descuento) + impuestoVenta;
                impuestoVenta = montoAPagar * 0.13;
                Console.Write("El monto total a pagar es de " + montoAPagar);
                Console.Write("Con cuanto desea cancelar?");
                pago = int.Parse(Console.ReadLine());
                vuelto = pago - montoAPagar;

            }

            if(numero == 1){
                mensaje = "El Senor de los Anillos. Las Dos Torres.";
            }
            else if (numero == 2)
            {
                mensaje = "Alicia en el pais de las Maravillas.";
            }
            else if (numero == 3)
            {
                mensaje = "Sementerio de Mascotas.";
            }
            else if (numero == 4)
            {
                mensaje = "Quiero Aprender.";
            }
            else if (numero == 5)
            {
                mensaje = "El Poder del Pensamiento Positivo.";
            }
            else if (numero == 6)
            {
                mensaje = "El primer libro de matematicas.";
            }
            else if (numero == 7)
            {
                mensaje = "Las Aventuras de Tom Sawyer.";
            }
            else if (numero == 8)
            {
                mensaje = "El Mago de Oz.";
            }
            else if (numero == 9)
            {
                mensaje = "La Zona Muerta.";
            }
            else
            {
                mensaje = "Viaje al Centro de la Tierra.";
            }

            Console.WriteLine("===================================");
            Console.WriteLine("*_*   " + titulo +"   *_*");
            Console.WriteLine("===================================");
            Console.WriteLine("Factura Proforma               N001");
            Console.WriteLine("Cliente: " + cliente);
            Console.WriteLine("Numero de Telefono: " + numeroTelefono);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Item-------------------------------");
            Console.WriteLine(mensaje);
            Console.WriteLine("Cantidad---------------------------");
            Console.WriteLine(cantidad);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total Orden--------------------" + calculo);
            Console.WriteLine("Descuento---------------------" + descuento);
            Console.WriteLine("Impuesto Venta----------------" + impuestoVenta);
            Console.WriteLine("Impuesto Total----------------" + impuestoVenta);
            Console.WriteLine("Precio Neto-------------------" + montoAPagar);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Monto Recibido-----------------" + pago);
            Console.WriteLine("Monto Cambio-------------------" +  vuelto);
            Console.WriteLine("===================================");
            Console.WriteLine("Gracias por su compra...");
        }
    }
}
