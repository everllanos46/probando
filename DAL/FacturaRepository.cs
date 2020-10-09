using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace DAL
{
    public class FacturaRepository
    {
        List<Factura> facturas = new List<Factura>();

        public void Guardar(Articulo articulo, List<Factura> listaFacturas)
        {
            facturas = listaFacturas;
            string ruta = facturas.Count() + ".txt";
            File.Delete(ruta);
            
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            
            escritor.WriteLine($"Número: {facturas.Count()}");
            escritor.WriteLine($"Fecha: {facturas.Count()}");
            escritor.WriteLine($"Producto e información");
            escritor.WriteLine($"{articulo.Nombre}");
            escritor.WriteLine($"{articulo.Descripcion}");
            escritor.WriteLine($"{articulo.Codigo}");
            escritor.WriteLine($"{articulo.PrecioUnitario}");

            escritor.Close();
            file.Close();
        }

        public List<Factura> ConsultarFactura()
        {
            facturas = new List<Factura>();

            string Linea = string.Empty;
            FileStream sourceStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(sourceStream);
            while ((Linea = reader.ReadLine()) != null)
            {
                Cliente cliente = new Cliente();
                char delimiter = ';';
                string[] MatrizCliente = Linea.Split(delimiter);
                cliente.Nombre = MatrizCliente[0];
                cliente.Identificacion = MatrizCliente[1];
                cliente.ValorPagado = Convert.ToInt64(MatrizCliente[2]);
                clientes.Add(cliente);
            }
            reader.Close();
            sourceStream.Close();
            return clientes;
        }
    }
}

        

