using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMDI
{
  class Trabajador
  {

    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DocumentoPersona TipoDocumento { get; set; }
    public string NumeroDocumento { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Celular { get; set; }
    public string Correo { get; set; }  //validar con expresiones regulares
    public bool Vigente { get; set; }

  }
}
