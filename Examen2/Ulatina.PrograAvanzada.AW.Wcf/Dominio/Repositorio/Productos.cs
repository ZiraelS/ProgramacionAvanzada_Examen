using System;
using System.Collections.Generic;
using System.Linq;

namespace Ulatina.PrograAvanzada.AW.Wcf.Repositorio
{


    /// <summary>
    /// tarea moral
    /// genere el código en linq para las siguientes consultas:
    /// 1.  lista de artículos que contienen una hilera determinada en el nombre.
    /// 2.  lista de artículos cuya fecha de vencimiento sea menor o igual a una determinada.
    /// 3.  lista de artículos de un color determinado.
    /// 4.  lista de artículos cuyo nombre de la subcategoría contenga una hilera determinada.
    /// 5.  lista de artículos cuyo nombre de la categoría contenga una hilera determinada.
    /// 6.  lista de artículos cuyo nombre de modelo contenga una hilera determinada.
    /// 7.  lista de artículos que contengan al menos un review.

    /// </summary>
    internal class Productos
    {
        static Model.AdventureWorks2014Entities _Contexto = new Model.AdventureWorks2014Entities();

        public Productos()
        {
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            Model.Product elProducto = new Model.Product();
            elProducto = _Contexto.Product.Include("ProductSubCategory").Include("ProductModel").Include(" ProductReview").Include("ProductSubCategory.ProductCategory").Where(p => p.ProductNumber.Equals(elNumero)).FirstOrDefault();
            return elProducto;
        }

        //Examen
        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoFechaEnOrden(DateTime fecha1, DateTime fecha2)
        {
            var lasVentas = _Contexto.SalesOrderHeader.Where(p => fecha1 <= p.OrderDate && p.OrderDate <= fecha2).ToList();
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoTotal(decimal total1, decimal total2)
        {
            var lasVentas = _Contexto.SalesOrderHeader.Where(p => total1 <= p.TotalDue && p.TotalDue <= total2).ToList();
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorDescuento(decimal desc)
        {
            //var lasVentas = _Contexto.SalesOrderHeader.Where(p => desc < p. /*SalesOrderDetail.UnitPriceDiscount*/).ToList();
            var lasVentas = _Contexto.SalesOrderHeader.Where(p => p.SalesOrderDetail.Any(d => d.UnitPriceDiscount > desc)).ToList();
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorVentasPorCantidad(short canti)
        {
            //var lasVentas = _Contexto.SalesOrderDetail.Where(d=> d.OrderQty == canti).ToList();
            var lasVentas = _Contexto.SalesOrderHeader.Where(p => p.SalesOrderDetail.Any(d => d.OrderQty == canti)).ToList();
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorVentasPorGenero(string gen)
        {
            var lasVentas = _Contexto.SalesOrderHeader.Where(p => p.SalesPerson.Employee.Gender.Contains(gen)).ToList();
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorRangoEdad(DateTime fecha1, DateTime fecha2)
        {
            var lasVentas = _Contexto.SalesOrderHeader.Where(p => fecha1 <= p.SalesPerson.Employee.BirthDate && p.SalesPerson.Employee.BirthDate <= fecha2).ToList();
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorAntiguedad(DateTime fecha1, DateTime fecha2)
        {
            var lasVentas = _Contexto.SalesOrderHeader.Where(p => fecha1 <= p.SalesPerson.Employee.HireDate && p.SalesPerson.Employee.HireDate <= fecha2).ToList();
            return lasVentas;
        }

        public IList<Model.SalesOrderHeader> BuscarVentasPorContieneNombreApellido(string name)
        {
            var lasVentas = _Contexto.SalesOrderHeader.Where(p => p.SalesPerson.Employee.Person.FirstName.Contains(name) || p.SalesPerson.Employee.Person.LastName.Contains(name)).ToList();
            return lasVentas;
        }
        //Examen

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var losProductos = _Contexto.Product.Where(p => elPrecioInferior <= p.ListPrice && p.ListPrice <= elPrecioSuperior).ToList();
            return losProductos;
        }

        public IList<Model.SalesOrderHeader> BuscarVentas()
        {
            var lasVentas = _Contexto.SalesOrderHeader.Where(p => p.SalesOrderNumber.Contains("SO43659")).ToList();
            return lasVentas;
        }
    }
}