using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.Wcf.Acciones
{
    public class Productos
    {
        public Productos()
        {
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

        public IList<Model.SalesOrderHeader> BuscarVentas()
        {
            var laEspecificacion = new Especificaciones.Productos();
            var lasVentas = laEspecificacion.BuscarVentas();
            return lasVentas;
        }

        //examen
        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoFechaEnOrden(DateTime fecha1, DateTime fecha2)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var lasVentas = laEspecificacion.BuscarVentasPorRangoFechaEnOrden(fecha1 ,fecha2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoTotal(decimal total1, decimal total2)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var lasVentas = laEspecificacion.BuscarVentasPorRangoTotal(total1, total2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorDescuento(decimal desc)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var lasVentas = laEspecificacion.BuscarVentasPorDescuento(desc);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorVentasPorCantidad(short canti)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var lasVentas = laEspecificacion.BuscarVentasPorVentasPorCantidad(canti);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorVentasPorGenero(string gen)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var lasVentas = laEspecificacion.BuscarVentasPorVentasPorGenero(gen);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoEdad(DateTime fecha1, DateTime fecha2)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var lasVentas = laEspecificacion.BuscarVentasPorRangoEdad(fecha1, fecha2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorAntiguedad(DateTime fecha1, DateTime fecha2)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var lasVentas = laEspecificacion.BuscarVentasPorAntiguedad(fecha1, fecha2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorContieneNombreApellido(string name)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var lasVentas = laEspecificacion.BuscarVentasPorContieneNombreApellido(name);
            return lasVentas;
        }
        //examen
    }
}