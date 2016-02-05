namespace NorthwindUserInterface.Desktop.Winforms
{
    partial class Shell
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shell));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPageHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageHomeGroupGeneral = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationBarItemProducts = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItemSales = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItemCustomers = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItemEmployees = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.productsView = new NorthwindUserInterface.Desktop.Winforms.Modules.Products.ProductsView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHome});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.Size = new System.Drawing.Size(1052, 143);
            // 
            // ribbonPageHome
            // 
            this.ribbonPageHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageHomeGroupGeneral});
            this.ribbonPageHome.Name = "ribbonPageHome";
            this.ribbonPageHome.Text = "HOME";
            // 
            // ribbonPageHomeGroupGeneral
            // 
            this.ribbonPageHomeGroupGeneral.Name = "ribbonPageHomeGroupGeneral";
            this.ribbonPageHomeGroupGeneral.Text = "General";
            // 
            // officeNavigationBar
            // 
            this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.navigationBarItemProducts,
            this.navigationBarItemSales,
            this.navigationBarItemCustomers,
            this.navigationBarItemEmployees});
            this.officeNavigationBar.Location = new System.Drawing.Point(0, 534);
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.SelectedItem = this.navigationBarItemProducts;
            this.officeNavigationBar.Size = new System.Drawing.Size(1052, 45);
            this.officeNavigationBar.TabIndex = 1;
            this.officeNavigationBar.Text = "officeNavigationBar1";
            // 
            // navigationBarItemProducts
            // 
            this.navigationBarItemProducts.Name = "navigationBarItemProducts";
            this.navigationBarItemProducts.Text = "Products";
            // 
            // navigationBarItemSales
            // 
            this.navigationBarItemSales.Name = "navigationBarItemSales";
            this.navigationBarItemSales.Text = "Sales";
            // 
            // navigationBarItemCustomers
            // 
            this.navigationBarItemCustomers.Name = "navigationBarItemCustomers";
            this.navigationBarItemCustomers.Text = "Customers";
            // 
            // navigationBarItemEmployees
            // 
            this.navigationBarItemEmployees.Name = "navigationBarItemEmployees";
            this.navigationBarItemEmployees.Text = "Employees";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Controls.Add(this.navigationPage2);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 143);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame.SelectedPage = this.navigationPage2;
            this.navigationFrame.SelectedPageIndex = 0;
            this.navigationFrame.Size = new System.Drawing.Size(1052, 391);
            this.navigationFrame.TabIndex = 3;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.productsView);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1052, 391);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1052, 391);
            // 
            // productsView
            // 
            this.productsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsView.Location = new System.Drawing.Point(0, 0);
            this.productsView.Name = "productsView";
            this.productsView.ProductDetails = null;
            this.productsView.Size = new System.Drawing.Size(1052, 391);
            this.productsView.TabIndex = 0;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 579);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shell";
            this.Ribbon = this.ribbonControl;
            this.Text = "Northwind";
            this.Load += new System.EventHandler(this.Shell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageHomeGroupGeneral;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemProducts;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemSales;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemCustomers;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemEmployees;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private Modules.Products.ProductsView productsView;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
    }
}

