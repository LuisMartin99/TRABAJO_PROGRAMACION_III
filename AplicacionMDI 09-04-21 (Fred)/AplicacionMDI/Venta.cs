using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMDI
{
  class Venta
  {

    public Cliente Cliente { get; set; }
    public string TipoDocumento { get; set; }
    public string Serie { get; set; }
    public string Numero { get; set; }
    public string Fecha { get; set; }
    public bool Vigente { get; set; }

    public List<DetalleVenta> detalles { get; set; }

  }

}
