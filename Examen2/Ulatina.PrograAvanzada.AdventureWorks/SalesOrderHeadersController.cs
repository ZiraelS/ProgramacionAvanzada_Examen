using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ulatina.PrograAvanzada.AW.Model;

namespace Ulatina.PrograAvanzada.AdventureWorks
{
    public class SalesOrderHeadersController : Controller
    {
        private AdventureWorks2014Entities db = new AdventureWorks2014Entities();

        // GET: SalesOrderHeaders
        public ActionResult Index()
        {
            return View(db.SalesOrderHeader.ToList());
        }
        
        public ActionResult IndexViewModelVentas()
        {
            var laAccion = new AW.Wcf.Acciones.Productos();
            var ventas = laAccion.BuscarVentas();
            var laAccionViewModel = new Dominio.Acciones.ConvertirVentasEnViewModel();
            var ventasViewModel = laAccionViewModel.VentasEnViewModel(ventas);
            return View(ventasViewModel.ToList());
        }

        //Examen
        public ActionResult IndexViewModel1()
        {
            var fecha1 = new DateTime(2011, 01, 01, 00, 00, 00, 0000);
            var fecha2 = new DateTime(2011, 06, 31, 00, 00, 00, 0000);
            var laAccion = new AW.Wcf.Acciones.Productos();
            var ventas = laAccion.BuscarVentasPorRangoFechaEnOrden(fecha1, fecha2);
            var laAccionViewModel = new Dominio.Acciones.ConvertirVentasEnViewModel();
            var ventasViewModel = laAccionViewModel.VentasEnViewModel(ventas);
            return View(ventasViewModel.ToList());
        }
        public ActionResult IndexViewModel2()
        {
            decimal total1 = 5000;
            decimal total2 = 6000;
            var laAccion = new AW.Wcf.Acciones.Productos();
            var ventas = laAccion.BuscarVentasPorRangoTotal(total1,total2);
            var laAccionViewModel = new Dominio.Acciones.ConvertirVentasEnViewModel();
            var ventasViewModel = laAccionViewModel.VentasEnViewModel(ventas);
            return View(ventasViewModel.ToList());
        }
        public ActionResult IndexViewModel3()
        {
            decimal desc = 50;
            var laAccion = new AW.Wcf.Acciones.Productos();
            var ventas = laAccion.BuscarVentasPorDescuento(desc);
            var laAccionViewModel = new Dominio.Acciones.ConvertirVentasEnViewModel();
            var ventasViewModel = laAccionViewModel.VentasEnViewModel(ventas);
            return View(ventasViewModel.ToList());
        }
        public ActionResult IndexViewModel4()
        {
            short canti = 4; 
            var laAccion = new AW.Wcf.Acciones.Productos();
            var ventas = laAccion.BuscarVentasPorVentasPorCantidad(canti);
            var laAccionViewModel = new Dominio.Acciones.ConvertirVentasEnViewModel();
            var ventasViewModel = laAccionViewModel.VentasEnViewModel(ventas);
            return View(ventasViewModel.ToList());
        }
        public ActionResult IndexViewModel5()
        {
            string gen = "M";
            var laAccion = new AW.Wcf.Acciones.Productos();
            var ventas = laAccion.BuscarVentasPorVentasPorGenero(gen);
            var laAccionViewModel = new Dominio.Acciones.ConvertirVentasEnViewModel();
            var ventasViewModel = laAccionViewModel.VentasEnViewModel(ventas);
            return View(ventasViewModel.ToList());
        }
        public ActionResult IndexViewModel6()
        {
            var fecha1 = new DateTime(1969, 01, 01);
            var fecha2 = new DateTime(1971, 12, 31);
            var laAccion = new AW.Wcf.Acciones.Productos();
            var ventas = laAccion.BuscarVentasPorRangoEdad(fecha1, fecha2);
            var laAccionViewModel = new Dominio.Acciones.ConvertirVentasEnViewModel();
            var ventasViewModel = laAccionViewModel.VentasEnViewModel(ventas);
            return View(ventasViewModel.ToList());
        }
        public ActionResult IndexViewModel7()
        {
            var fecha1 = new DateTime(2007, 01, 01);
            var fecha2 = new DateTime(2009, 12, 31);
            var laAccion = new AW.Wcf.Acciones.Productos();
            var ventas = laAccion.BuscarVentasPorAntiguedad(fecha1, fecha2);
            var laAccionViewModel = new Dominio.Acciones.ConvertirVentasEnViewModel();
            var ventasViewModel = laAccionViewModel.VentasEnViewModel(ventas);
            return View(ventasViewModel.ToList());
        }
        public ActionResult IndexViewModel8()
        {
            string name = "ui";
            var laAccion = new AW.Wcf.Acciones.Productos();
            var ventas = laAccion.BuscarVentasPorContieneNombreApellido(name);
            var laAccionViewModel = new Dominio.Acciones.ConvertirVentasEnViewModel();
            var ventasViewModel = laAccionViewModel.VentasEnViewModel(ventas);
            return View(ventasViewModel.ToList());
        }
        //Examen

        // GET: SalesOrderHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeader.Find(id);
            if (salesOrderHeader == null)
            {
                return HttpNotFound();
            }
            return View(salesOrderHeader);
        }

        // GET: SalesOrderHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesOrderHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SalesOrderID,RevisionNumber,OrderDate,DueDate,ShipDate,Status,OnlineOrderFlag,SalesOrderNumber,PurchaseOrderNumber,AccountNumber,CustomerID,SalesPersonID,TerritoryID,BillToAddressID,ShipToAddressID,ShipMethodID,CreditCardID,CreditCardApprovalCode,CurrencyRateID,SubTotal,TaxAmt,Freight,TotalDue,Comment,rowguid,ModifiedDate")] SalesOrderHeader salesOrderHeader)
        {
            if (ModelState.IsValid)
            {
                db.SalesOrderHeader.Add(salesOrderHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salesOrderHeader);
        }

        // GET: SalesOrderHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeader.Find(id);
            if (salesOrderHeader == null)
            {
                return HttpNotFound();
            }
            return View(salesOrderHeader);
        }

        // POST: SalesOrderHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SalesOrderID,RevisionNumber,OrderDate,DueDate,ShipDate,Status,OnlineOrderFlag,SalesOrderNumber,PurchaseOrderNumber,AccountNumber,CustomerID,SalesPersonID,TerritoryID,BillToAddressID,ShipToAddressID,ShipMethodID,CreditCardID,CreditCardApprovalCode,CurrencyRateID,SubTotal,TaxAmt,Freight,TotalDue,Comment,rowguid,ModifiedDate")] SalesOrderHeader salesOrderHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesOrderHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salesOrderHeader);
        }

        // GET: SalesOrderHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeader.Find(id);
            if (salesOrderHeader == null)
            {
                return HttpNotFound();
            }
            return View(salesOrderHeader);
        }

        // POST: SalesOrderHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeader.Find(id);
            db.SalesOrderHeader.Remove(salesOrderHeader);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
