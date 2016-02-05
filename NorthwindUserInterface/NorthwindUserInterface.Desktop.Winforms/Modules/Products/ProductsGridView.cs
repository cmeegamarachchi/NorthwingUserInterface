using System.Collections.Generic;
using System.Windows.Forms;
using NorthwindBusinessServices.Products;

namespace NorthwindUserInterface.Desktop.Winforms.Modules.Products
{
    public partial class ProductsGridView : UserControl
    {
        public ProductsGridView()
        {
            InitializeComponent();
        }

        public IEnumerable<ProductDetails> ProductDetails
        {
            get { return gridControl1.DataSource as IEnumerable<ProductDetails>; }
            set { gridControl1.DataSource = value; }
        }

        public void RefreshDataSource()
        {
            gridControl1.RefreshDataSource();
        }
    }
}