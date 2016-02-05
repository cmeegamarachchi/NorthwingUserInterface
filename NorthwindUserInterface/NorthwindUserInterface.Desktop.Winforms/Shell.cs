using System;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;
using NorthwindBusinessServices.Products;
using NorthwindDataAccess.DataContext;

namespace NorthwindUserInterface.Desktop.Winforms
{
    public partial class Shell : RibbonForm
    {

        public Shell()
        {
            InitializeComponent();
        }

        private void Shell_Load(object sender, EventArgs e)
        {
            ReloadProductDetails();
            SelectProductsView();
        }

        private void ReloadProductDetails()
        {
            var productsService = new ProductsService(new NorthwindUnitOfWork());
            productsView.ProductDetails = productsService.GetProducts(Int32.MaxValue, 1).Data;
            productsView.RefreshProductDetails();
        }

        private void SelectProductsView()
        {
            this.ribbonControl.MergeRibbon(productsView.ribbonControl);
        }
    }
}