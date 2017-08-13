using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.AdventureWorks.Dominio.Acciones
{
    public class ConvertirVentasEnViewModel
    {
        public IList<ViewModels.SalesViewModel> VentasEnViewModel(IList<PrograAvanzada.AW.Model.SalesOrderHeader> listaDeVentas)
        {
            var elResultado = new List<ViewModels.SalesViewModel>();

            foreach (var laVenta in listaDeVentas)
            {
                var laVentaViewModel = new ViewModels.SalesViewModel();
                laVentaViewModel.SalesOrderID = laVenta.SalesOrderID;
                laVentaViewModel.SalesOrderNumber = laVenta.SalesOrderNumber;
                laVentaViewModel.RevisionNumber = laVenta.RevisionNumber;
                laVentaViewModel.OrderDate = laVenta.OrderDate;
                laVentaViewModel.TotalDue = laVenta.TotalDue;
                elResultado.Add(laVentaViewModel);
            }
            return elResultado;
        }
    }
}