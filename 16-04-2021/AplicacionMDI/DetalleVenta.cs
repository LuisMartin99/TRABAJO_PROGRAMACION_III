using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMDI
{
  class DetalleVenta
  {

    public Producto Producto { get; set; }
    public int Cantidad { get; set; }
    public double PrecioUnitario { get; set; }

    public string NombreProducto
    {
      get
      {
        string nomProducto = "";

        if( this.Producto != null)
        {
          nomProducto = this.Producto.Nombre;
        }

        return nomProducto;
      }
    }

  }

}
