using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.PrograAvanzada.AW.Wcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> ListarTodos()
        {
            decimal elPrecioInferior = 10, elPrecioSuperior = 20;
            var laAccion = new Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var laAccion = new Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

        public IList<Model.SalesOrderHeader> BuscarVentas()
        {
            var laAccion = new Acciones.Productos();
            var lasVentas = laAccion.BuscarVentas();
            return lasVentas;
        }
        //examen
        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoFechaEnOrden(DateTime fecha1, DateTime fecha2)
        {
            var laAccion = new Acciones.Productos();
            var lasVentas = laAccion.BuscarVentasPorRangoFechaEnOrden(fecha1,fecha2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoTotal(decimal total1, decimal total2)
        {
            var laAccion = new Acciones.Productos();
            var lasVentas = laAccion.BuscarVentasPorRangoTotal(total1, total2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorDescuento(decimal desc)
        {
            var laAccion = new Acciones.Productos();
            var lasVentas = laAccion.BuscarVentasPorDescuento(desc);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorVentasPorCantidad(short canti)
        {
            var laAccion = new Acciones.Productos();
            var lasVentas = laAccion.BuscarVentasPorVentasPorCantidad(canti);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorVentasPorGenero(string gen)
        {
            var laAccion = new Acciones.Productos();
            var lasVentas = laAccion.BuscarVentasPorVentasPorGenero(gen);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoEdad(DateTime fecha1, DateTime fecha2)
        {
            var laAccion = new Acciones.Productos();
            var lasVentas = laAccion.BuscarVentasPorRangoEdad(fecha1, fecha2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorAntiguedad(DateTime fecha1, DateTime fecha2)
        {
            var laAccion = new Acciones.Productos();
            var lasVentas = laAccion.BuscarVentasPorAntiguedad(fecha1, fecha2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorContieneNombreApellido(string name)
        {
            var laAccion = new Acciones.Productos();
            var lasVentas = laAccion.BuscarVentasPorContieneNombreApellido(name);
            return lasVentas;
        }
        //examen
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
