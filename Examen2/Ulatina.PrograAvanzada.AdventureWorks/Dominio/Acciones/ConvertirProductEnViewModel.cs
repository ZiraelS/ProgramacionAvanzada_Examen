using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.AdventureWorks.Dominio.Acciones
{
    public class ConvertirProductEnViewModel
    {
        public IList<ViewModels.ProductsViewModel> ConviertaListaDeProductos (IList <PrograAvanzada.AW.Model.Product> listaDeProductos)
        {
            var elResultado = new List<ViewModels.ProductsViewModel>();

            foreach (var elProducto in listaDeProductos)
            {
                var elProductViewModel = new ViewModels.ProductsViewModel();
                elProductViewModel.Color = elProducto.Color;
                elProductViewModel.ListPrice = elProducto.ListPrice;
                elProductViewModel.ProductID = elProducto.ProductID;
                elProductViewModel.ProductName = elProducto.Name;
                elProductViewModel.ProductNumber = elProducto.ProductNumber;
                if (elProducto.ProductModel != null)
                    elProductViewModel.ProductModelName = elProducto.ProductModel.Name;
                else
                    elProductViewModel.ProductModelName = string.Empty;
                if (elProducto.ProductSubcategory != null)
                    elProductViewModel.ProductSubcategoryName = elProducto.ProductSubcategory.Name;
                else
                    elProductViewModel.ProductSubcategoryName = string.Empty;
                if (elProducto.ProductSubcategory != null && elProducto.ProductSubcategory.ProductCategory != null)
                    elProductViewModel.ProductCategoryName = elProducto.ProductSubcategory.ProductCategory.Name;
                else
                    elProductViewModel.ProductCategoryName = string.Empty;
                elResultado.Add(elProductViewModel);
            }
            return elResultado;
        }
    }
}