using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class ArticuloRepository
    {
        private string ruta = "Articulo.txt";
        public List<Articulo> articulos;
        public ArticuloRepository()
        {
            articulos = new List<Articulo>();
        }
        public void Guardar(List<Articulo> listaArticulos)
        {
            File.Delete(ruta);
            articulos = listaArticulos;
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            foreach (var item in articulos)
            {
                escritor.WriteLine($"{item.Proveedor}{item.Nombre};{item.Cantidad};{item.Codigo};{item.Descripcion};{item.PrecioUnitario};{item.PorcentajeUtilidad}");
            }

            escritor.Close();
            file.Close();
        }

        public List<Articulo> ConsultarArticulo()
        {
            articulos = new List<Articulo>();
            string Linea = string.Empty;
            FileStream sourceStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(sourceStream);
            while ((Linea = reader.ReadLine()) != null)
            {
                Articulo articulo = new Articulo();
                char delimiter = ';';
                string[] MatrizArticulo = Linea.Split(delimiter);
                articulo.Proveedor = MatrizArticulo[0];
                articulo.Nombre = MatrizArticulo[1];
                articulo.Cantidad = Convert.ToInt32(MatrizArticulo[2]);
                articulo.Codigo = MatrizArticulo[3];
                articulo.Descripcion = MatrizArticulo[4];
                articulo.PrecioUnitario = Convert.ToDecimal(MatrizArticulo[6]);
                articulo.PorcentajeUtilidad = Convert.ToDecimal(MatrizArticulo[7]);

                articulos.Add(articulo);
            }
            reader.Close();
            sourceStream.Close();
            return articulos;
        }

        public Articulo Buscar(string codigo)
        {
            Articulo articulo = new Articulo();
            foreach (var item in articulos)
            {
                if (item.Codigo.Equals(codigo))
                {
                    
                    return null;
                }
            }
            return articulo;

        }
    }
}
