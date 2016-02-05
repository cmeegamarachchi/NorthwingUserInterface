using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NorthwindBusinessServices.Products;

namespace NorthwindUserInterface.Desktop.Winforms.Modules.Products
{
    public partial class ProductsView : UserControl
    {
        public IEnumerable<ProductDetails> ProductDetails
        {
            get
            {
                return productsGridView.ProductDetails;
            }
            set
            {
                productsGridView.ProductDetails = value;
            }
        }
        
        public ProductsView()
        {
            InitializeComponent();
        }

        public void RefreshProductDetails()
        {
            productsGridView.RefreshDataSource();
        }
    }
}