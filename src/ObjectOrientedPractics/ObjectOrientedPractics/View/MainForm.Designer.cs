namespace ObjectOrientedPractics.View;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        tabControl1 = new System.Windows.Forms.TabControl();
        tabPage1 = new System.Windows.Forms.TabPage();
        tabPage2 = new System.Windows.Forms.TabPage();
        CartsTabPage = new System.Windows.Forms.TabPage();
        cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
        ordersTab = new System.Windows.Forms.TabPage();
        ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
        tabControl1.SuspendLayout();
        CartsTabPage.SuspendLayout();
        ordersTab.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(CartsTabPage);
        tabControl1.Controls.Add(ordersTab);
        tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControl1.Location = new System.Drawing.Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(800, 450);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Location = new System.Drawing.Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(3);
        tabPage1.Size = new System.Drawing.Size(792, 422);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Items";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new System.Drawing.Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new System.Windows.Forms.Padding(3);
        tabPage2.Size = new System.Drawing.Size(792, 422);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Customers";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // CartsTabPage
        // 
        CartsTabPage.Controls.Add(cartsTab1);
        CartsTabPage.Location = new System.Drawing.Point(4, 24);
        CartsTabPage.Name = "CartsTabPage";
        CartsTabPage.Padding = new System.Windows.Forms.Padding(3);
        CartsTabPage.Size = new System.Drawing.Size(792, 422);
        CartsTabPage.TabIndex = 2;
        CartsTabPage.Text = "Carts";
        CartsTabPage.UseVisualStyleBackColor = true;
        // 
        // cartsTab1
        // 
        cartsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
        cartsTab1.Location = new System.Drawing.Point(3, 3);
        cartsTab1.Name = "cartsTab1";
        cartsTab1.Size = new System.Drawing.Size(786, 416);
        cartsTab1.TabIndex = 0;
        // 
        // ordersTab
        // 
        ordersTab.Controls.Add(ordersTab1);
        ordersTab.Location = new System.Drawing.Point(4, 24);
        ordersTab.Name = "ordersTab";
        ordersTab.Padding = new System.Windows.Forms.Padding(3);
        ordersTab.Size = new System.Drawing.Size(792, 422);
        ordersTab.TabIndex = 3;
        ordersTab.Text = "Orders";
        ordersTab.UseVisualStyleBackColor = true;
        // 
        // ordersTab1
        // 
        ordersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
        ordersTab1.Location = new System.Drawing.Point(3, 3);
        ordersTab1.Name = "ordersTab1";
        ordersTab1.Size = new System.Drawing.Size(786, 416);
        ordersTab1.TabIndex = 0;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(tabControl1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "ObjectOrientedPractics";
        tabControl1.ResumeLayout(false);
        CartsTabPage.ResumeLayout(false);
        ordersTab.ResumeLayout(false);
        ResumeLayout(false);
    }

    private ObjectOrientedPractics.View.Tabs.OrdersTab ordersTab1;

    private System.Windows.Forms.TabPage ordersTab;

    private ObjectOrientedPractics.View.Tabs.CartsTab cartsTab1;

    private System.Windows.Forms.TabPage CartsTabPage;

    private System.Windows.Forms.TabPage tabPage1;

    private System.Windows.Forms.TabPage tabPage2;

    private System.Windows.Forms.TabControl tabControl1;

    #endregion
}