namespace ObjectOrientedPractics;

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
        itemsTab1 = new ObjectOrientedPractics.Tabs.ItemsTab();
        tabPage2 = new System.Windows.Forms.TabPage();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControl1.Location = new System.Drawing.Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(800, 450);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(itemsTab1);
        tabPage1.Location = new System.Drawing.Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(3);
        tabPage1.Size = new System.Drawing.Size(792, 422);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Items";
        tabPage1.UseVisualStyleBackColor = true;
        tabPage1.Click += tabPage1_Click;
        // 
        // itemsTab1
        // 
        itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
        itemsTab1.Location = new System.Drawing.Point(3, 3);
        itemsTab1.Name = "itemsTab1";
        itemsTab1.Size = new System.Drawing.Size(786, 416);
        itemsTab1.TabIndex = 0;
        itemsTab1.Tag = "";
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
        tabPage2.Click += tabPage2_Click_1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(tabControl1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "ObjectOrientedPractics";
        Load += MainForm_Load;
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TabPage tabPage2;

    private ObjectOrientedPractics.Tabs.ItemsTab itemsTab1;

    private System.Windows.Forms.TabPage tabPage1;

    private System.Windows.Forms.TabControl tabControl1;

    #endregion
}