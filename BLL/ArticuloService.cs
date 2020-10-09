using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ArticuloService
    {
        ArticuloRepository articuloRepository;
        Articulo articuloo;
        Factura factura;
        FacturaRepository facturaRepository;
        

        public List<Articulo> articulos = new List<Articulo>();

        public ArticuloService()
        {
            ConsultarArticulos();
        }

        public String Guardar(Articulo articulo)
        {

            articuloo = new Articulo();

            articuloo = Buscar(articulo.Codigo);

            if (articulo != null)
            {
                facturaRepository.Guardar(articulo)
                articulos.Add(articulo);
                articuloRepository.Guardar(articulos);

                return "Producto guardado";
            }
            return "Ya se encuentra este producto";
        }

        public void ConsultarArticulos()
        {
            articuloRepository = new ArticuloRepository();
            articulos = articuloRepository.ConsultarArticulo();
        }

        public Articulo Buscar(string codigo)
        {
            articuloo = new Articulo();
            articuloo = articuloRepository.Buscar(codigo);
            if (articuloo == null)
            {
                return null;
            }
            return articuloo;
        }
    }
}
