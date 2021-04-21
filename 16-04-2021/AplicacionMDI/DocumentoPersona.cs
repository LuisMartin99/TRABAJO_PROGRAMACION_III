using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMDI
{
  public class DocumentoPersona
  {

    public string Nombre { get; set; }
    public string Siglas { get; set; }
    public int  Valores { get; set; } //solo dígitos, solo letras o ambos
    public bool Vigente { get; set; }


  }
}
