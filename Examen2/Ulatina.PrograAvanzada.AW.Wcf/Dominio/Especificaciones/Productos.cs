using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.Wcf.Especificaciones
{
    internal class Productos
    {
        public Productos()
        {
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

        public IList<Model.SalesOrderHeader> BuscarVentas()
        {
            var elRepositorio = new Repositorio.Productos();
            var lasVentas = elRepositorio.BuscarVentas();
            return lasVentas;
        }

        //examen
        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoFechaEnOrden(DateTime fecha1, DateTime fecha2)
        {
            var elRepositorio = new Repositorio.Productos();
            var lasVentas = elRepositorio.BuscarVentasPorRangoFechaEnOrden(fecha1, fecha2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoTotal(decimal total1, decimal total2)
        {
            var elRepositorio = new Repositorio.Productos();
            var lasVentas = elRepositorio.BuscarVentasPorRangoTotal(total1, total2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorDescuento(decimal desc)
        {
            var elRepositorio = new Repositorio.Productos();
            var lasVentas = elRepositorio.BuscarVentasPorDescuento(desc);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorVentasPorCantidad(short canti)
        {
            var elRepositorio = new Repositorio.Productos();
            var lasVentas = elRepositorio.BuscarVentasPorVentasPorCantidad(canti);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorVentasPorGenero(string gen)
        {
            var elRepositorio = new Repositorio.Productos();
            var lasVentas = elRepositorio.BuscarVentasPorVentasPorGenero(gen);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoEdad(DateTime fecha1, DateTime fecha2)
        {
            var elRepositorio = new Repositorio.Productos();
            var lasVentas = elRepositorio.BuscarVentasPorRangoEdad(fecha1, fecha2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorAntiguedad(DateTime fecha1, DateTime fecha2)
        {
            var elRepositorio = new Repositorio.Productos();
            var lasVentas = elRepositorio.BuscarVentasPorAntiguedad(fecha1, fecha2);
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorContieneNombreApellido(string name)
        {
            var elRepositorio = new Repositorio.Productos();
            var lasVentas = elRepositorio.BuscarVentasPorContieneNombreApellido(name);
            return lasVentas;
        }
        //examen
    }
}