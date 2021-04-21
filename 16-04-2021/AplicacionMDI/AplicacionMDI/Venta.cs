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
    public string TipoDocumento { get; set; }   // B Boleta, F Factura
    public string Serie { get; set; }
    public int  Numero { get; set; }
    public DateTime  Fecha { get; set; }
    public bool Vigente { get; set; }

    public List<DetalleVenta> Detalles { get; set; }

    public string NombreDocumento
    {
      get
      {
        string nombre="";

        if(this.TipoDocumento.ToUpper().Equals("B") == true)
        {
          nombre = "Boleta";
        }
        else
        {
          if (this.TipoDocumento.ToUpper().Equals("F") == true)
          {
            nombre = "Factura";
          }
         
        }

        return nombre;
      }
    }

    public string Documento
    {
      get
      {
        string doc = "";

        doc = this.NombreDocumento + " " + this.Serie + "-" + this.Numero.ToString("00000");

        return doc;
      }
    }

    public double Total
    {
      get
      {
        double total = 0;

        foreach ( var det in this.Detalles)
        {
          total += det.Cantidad * det.PrecioUnitario;
        }

        return total;
      }
    }

  }

}
