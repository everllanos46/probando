using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class ClienteRepository
    {
        private string ruta = "Cliente.txt";
        public List<Cliente> clientes;
        public ClienteRepository()
        {
            clientes = ConsultarClientes();
        }
        public void Guardar(List<Cliente> listaClientes)
        {
            File.Delete(ruta);
            clientes = listaClientes;
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            foreach (var item in clientes)
            {
                escritor.WriteLine($"{item.Nombre};{item.Identificacion};{item.ValorPagado}");
            }
            escritor.Close();
            file.Close();
        }

        public List<Cliente> ConsultarClientes()
        {
            clientes = new List<Cliente>();
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

        public Cliente Buscar(string identificacion)
        {
            Cliente cliente = new Cliente();
            foreach (var item in clientes)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return null;
                }
            }
            return cliente;

        }

    }
}
