using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMDI
{
  class Producto
  {

    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }
    public Categoria Categoria { get; set; }
    public bool Vigente { get; set; }

    public string NombreCategoria
    {
      get
      {
        string nombreCat = "";

        if( this.Categoria != null)
        {
          nombreCat = this.Categoria.Nombre;
        }

        return nombreCat;
      }
    }

  }
}
