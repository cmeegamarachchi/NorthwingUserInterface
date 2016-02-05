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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
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
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 579);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shell";
            this.Ribbon = this.ribbonControl;
            this.Text = "Northwind";
            this.Load += new System.EventHandler(this.Shell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
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
    }
}

