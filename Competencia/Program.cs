using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;

namespace Competencia
{
    class Program
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Articulo> articulos = new List<Articulo>();
        static Cliente cliente;
        static Articulo articulo;
        static ClienteService clienteService= new ClienteService();
        static ArticuloService articuloService = new ArticuloService();
        static void Main(string[] args)
        {
            int opcion;
            do {
                Console.Clear();
                Console.WriteLine("-----PROGRAMA FACTURACION-----");
                Console.WriteLine("1.Agregar Cliente");
                Console.WriteLine("2.Comprar Articulos");
                Console.WriteLine("3.Salir");
                Console.WriteLine("Ingrese la opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarClientes();
                        break;
                    case 2:
                        //ComprarArticulos();
                        break;
                    case 3:
                        AgregarArticulos();
                        break;
                }
            } while (opcion <= 3);
        }

        public static  void AgregarClientes()
        {
            cliente = new Cliente();
            Console.Clear();
            Console.WriteLine("Ingrese su nombre");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su identificacion");
            cliente.Identificacion = Console.ReadLine();
            cliente.ValorPagado = 0;
            Console.WriteLine(clienteService.Guardar(cliente));
            Console.ReadKey();

        }

        public static void AgregarArticulos()
        {
            articulo = new Articulo();
            Console.Clear();
            Console.WriteLine("Nombre del producto");
            articulo.Nombre = Console.ReadLine();
            Console.WriteLine("Codigo del producto");
            articulo.Codigo = Console.ReadLine();
            Console.WriteLine("Cantidad");
            articulo.Cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Descripcion del producto");
            articulo.Descripcion = Console.ReadLine();
            articulo.PrecioUnitario = Convert.ToInt32(Console.ReadLine());
            articulo.PorcentajeUtilidad = 0;
            Console.WriteLine(articuloService.Guardar(articulo));


        }
    }
}
