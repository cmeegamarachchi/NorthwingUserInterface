namespace NorthwindUserInterface.Desktop.Winforms.Modules.Products
{
    partial class ProductsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemReloadProducts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNewProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageProducts = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageHomeGroupGeneral = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barButtonItemReloadProducts,
            this.barButtonItemNewProduct,
            this.barButtonItemEditProduct});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 4;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageProducts});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.Size = new System.Drawing.Size(631, 141);
            // 
            // barButtonItemReloadProducts
            // 
            this.barButtonItemReloadProducts.Caption = "Reload";
            this.barButtonItemReloadProducts.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemReloadProducts.Glyph")));
            this.barButtonItemReloadProducts.Id = 1;
            this.barButtonItemReloadProducts.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemReloadProducts.LargeGlyph")));
            this.barButtonItemReloadProducts.Name = "barButtonItemReloadProducts";
            // 
            // barButtonItemNewProduct
            // 
            this.barButtonItemNewProduct.Caption = "New";
            this.barButtonItemNewProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemNewProduct.Glyph")));
            this.barButtonItemNewProduct.Id = 2;
            this.barButtonItemNewProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemNewProduct.LargeGlyph")));
            this.barButtonItemNewProduct.Name = "barButtonItemNewProduct";
            // 
            // barButtonItemEditProduct
            // 
            this.barButtonItemEditProduct.Caption = "Edit";
            this.barButtonItemEditProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemEditProduct.Glyph")));
            this.barButtonItemEditProduct.Id = 3;
            this.barButtonItemEditProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemEditProduct.LargeGlyph")));
            this.barButtonItemEditProduct.Name = "barButtonItemEditProduct";
            // 
            // ribbonPageProducts
            // 
            this.ribbonPageProducts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageHomeGroupGeneral});
            this.ribbonPageProducts.Name = "ribbonPageProducts";
            this.ribbonPageProducts.Text = "PRODUCTS";
            // 
            // ribbonPageHomeGroupGeneral
            // 
            this.ribbonPageHomeGroupGeneral.ItemLinks.Add(this.barButtonItemReloadProducts);
            this.ribbonPageHomeGroupGeneral.ItemLinks.Add(this.barButtonItemNewProduct);
            this.ribbonPageHomeGroupGeneral.ItemLinks.Add(this.barButtonItemEditProduct);
            this.ribbonPageHomeGroupGeneral.Name = "ribbonPageHomeGroupGeneral";
            this.ribbonPageHomeGroupGeneral.Text = "General";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 141);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(631, 356);
            this.splitContainerControl1.SplitterPosition = 444;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(631, 497);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReloadProducts;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewProduct;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageHomeGroupGeneral;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}
