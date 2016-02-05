using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NorthwindBusinessServices.Products;
using NorthwindDataAccess.DataContext;

namespace NorthwindUserInterface.Desktop.Winforms.Modules.Products
{
    public partial class ProductsGridView : UserControl
    {
        private IEnumerable<ProductDetails> ProductDetails { get; set; }

        public ProductsGridView()
        {
            InitializeComponent();
        }

        private void ProductsGridView_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        public void ReloadGrid()
        {
            var service = new ProductsService(new NorthwindUnitOfWork());
            ProductDetails = service.GetProducts(int.MaxValue, 1).Data;

            gridControl1.DataSource = ProductDetails;
        }
    }
}
