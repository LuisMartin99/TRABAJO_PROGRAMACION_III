using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMDI
{
  class Usuario
  {

    public Trabajador Trabajador { get; set; }
    public string Nombre { get; set; }
    public string Clave { get; set; }
    public string Tipo { get; set; } // A Administrador; L Limitado
    public bool Vigente { get; set; }

  }

}
