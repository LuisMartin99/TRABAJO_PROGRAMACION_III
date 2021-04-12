using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionMDI
{
  static class Program
  {

    public static List<Categoria> Categorias = new List<Categoria>();
    public static List<Producto> Productos = new List<Producto>();
    public static List<Trabajador> Trabajadores = new List<Trabajador>();
    public static List<DocumentoPersona> DocumentoPersonas = new List<DocumentoPersona>();
        public static List<Usuario> Usuarios = new List<Usuario>();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new frmPrincipal());
    }
  }
}
