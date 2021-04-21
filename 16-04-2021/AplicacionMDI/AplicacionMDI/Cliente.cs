using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMDI
{
  public class Cliente
  {

    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DocumentoPersona TipoDocumento { get; set; }
    public string NumeroDocumento { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public bool Vigente { get; set; }

    public string NombreCompleto
    {
      get
      {
        return this.Apellidos + " " + this.Nombres;
      }
    }

    public string Documento
    {
      get
      {
        string doc = "";

        if( this.TipoDocumento != null)
        {
          doc = this.TipoDocumento.Siglas + " " + this.NumeroDocumento;
        }

        return doc;
      }
    }
  }
}
