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
    public static List<Cliente> Clientes = new List<Cliente>();
    public static List<Venta> Ventas = new List<Venta>();

    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {

      LlenarClientes();
      LlenarProductos();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new frmPrincipal());
    }

    private static void LlenarProductos()
    {
      Categorias.Add(new Categoria()
      {
        Nombre = "Linea blanca"
      });

      Productos.Add(new Producto()
      {
        Categoria = Categorias[0],
        Nombre = "Plancha",
        Precio = 150,
        Stock = 5,
        Vigente = true
      });
      Productos.Add(new Producto()
      {
        Categoria = Categorias[0],
        Nombre = "Lavadora",
        Precio = 1250,
        Stock = 1,
        Vigente = true
      });
      Productos.Add(new Producto()
      {
        Categoria = Categorias[0],
        Nombre = "Radio",
        Precio = 50,
        Stock = 15,
        Vigente = false
      });

    }

    private static void LlenarClientes()
    {
      Clientes.Add(new Cliente
      {
        Nombres = "ana",
        Apellidos = "Baca Ramirez",
        TipoDocumento = new DocumentoPersona () { Siglas = "DNI" },
        NumeroDocumento = "12345678"
      });

      Clientes.Add(new Cliente
      {
        Nombres = "Cesar",
        Apellidos = "Leon Terán",
        TipoDocumento = new DocumentoPersona() { Siglas = "DNI" },
        NumeroDocumento = "15975312"
      });
    }
  }
}
