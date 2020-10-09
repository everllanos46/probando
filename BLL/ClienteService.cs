using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ClienteService
    {
        ClienteRepository clienteRepository;
        Cliente clientee;

        public List<Cliente> clientes = new List<Cliente>();

        public ClienteService()
        {
            ConsultarClientes();
        }

        public string Guardar(Cliente cliente)
        {
            clientee = new Cliente();
           
            clientee=Buscar(cliente.Identificacion);

            if (clientee != null)
            {
                clientes.Add(cliente);
                clienteRepository.Guardar(clientes);
                return "Guardado correctamente";
            }
            return "Ya se encuentra";  
        }

        public void ConsultarClientes()
        {
            clienteRepository = new ClienteRepository();
            clientes = clienteRepository.ConsultarClientes();
        }

        public Cliente Buscar(string identificacion)
        {
            clientee = new Cliente();
            clientee=clienteRepository.Buscar(identificacion);
            if (clientee == null)
            { 
                return null;
            }
            return clientee;
        }
    }
}
