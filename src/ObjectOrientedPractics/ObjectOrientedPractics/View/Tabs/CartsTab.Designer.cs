using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs;

partial class CartsTab
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        AddToCartButton = new System.Windows.Forms.Button();
        ItemsListBox = new System.Windows.Forms.ListBox();
        label1 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        CreateOrderButton = new System.Windows.Forms.Button();
        RemoveItemButton = new System.Windows.Forms.Button();
        ClearCartButton = new System.Windows.Forms.Button();
        AmountValueLabel = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        CartTextBox = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        CustomerComboBox = new System.Windows.Forms.ComboBox();
        label2 = new System.Windows.Forms.Label();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tableLayoutPanel1.Controls.Add(panel1, 0, 0);
        tableLayoutPanel1.Controls.Add(panel2, 1, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new System.Drawing.Size(592, 434);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.WhiteSmoke;
        panel1.Controls.Add(tableLayoutPanel2);
        panel1.Controls.Add(ItemsListBox);
        panel1.Controls.Add(label1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(230, 428);
        panel1.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.Controls.Add(AddToCartButton, 0, 0);
        tableLayoutPanel2.Location = new System.Drawing.Point(4, 380);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.Size = new System.Drawing.Size(223, 45);
        tableLayoutPanel2.TabIndex = 2;
        // 
        // AddToCartButton
        // 
        AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        AddToCartButton.Location = new System.Drawing.Point(3, 3);
        AddToCartButton.Name = "AddToCartButton";
        AddToCartButton.Size = new System.Drawing.Size(68, 39);
        AddToCartButton.TabIndex = 0;
        AddToCartButton.Text = "Add To Cart";
        AddToCartButton.UseVisualStyleBackColor = true;
        AddToCartButton.Click += AddToCartButton_Click;
        // 
        // ItemsListBox
        // 
        ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        ItemsListBox.FormattingEnabled = true;
        ItemsListBox.Location = new System.Drawing.Point(3, 20);
        ItemsListBox.Name = "ItemsListBox";
        ItemsListBox.Size = new System.Drawing.Size(223, 349);
        ItemsListBox.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(4, 4);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 0;
        label1.Text = "Items";
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.White;
        panel2.Controls.Add(tableLayoutPanel3);
        panel2.Controls.Add(AmountValueLabel);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(CartTextBox);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(CustomerComboBox);
        panel2.Controls.Add(label2);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(239, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(350, 428);
        panel2.TabIndex = 2;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel3.ColumnCount = 4;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel3.Controls.Add(CreateOrderButton, 0, 0);
        tableLayoutPanel3.Controls.Add(RemoveItemButton, 2, 0);
        tableLayoutPanel3.Controls.Add(ClearCartButton, 3, 0);
        tableLayoutPanel3.Location = new System.Drawing.Point(4, 246);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel3.Size = new System.Drawing.Size(343, 45);
        tableLayoutPanel3.TabIndex = 6;
        // 
        // CreateOrderButton
        // 
        CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        CreateOrderButton.Location = new System.Drawing.Point(3, 3);
        CreateOrderButton.Name = "CreateOrderButton";
        CreateOrderButton.Size = new System.Drawing.Size(79, 39);
        CreateOrderButton.TabIndex = 0;
        CreateOrderButton.Text = "Create Order";
        CreateOrderButton.UseVisualStyleBackColor = true;
        CreateOrderButton.Click += CreateOrderButton_Click;
        // 
        // RemoveItemButton
        // 
        RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        RemoveItemButton.Location = new System.Drawing.Point(173, 3);
        RemoveItemButton.Name = "RemoveItemButton";
        RemoveItemButton.Size = new System.Drawing.Size(79, 39);
        RemoveItemButton.TabIndex = 1;
        RemoveItemButton.Text = "Remove Item";
        RemoveItemButton.UseVisualStyleBackColor = true;
        RemoveItemButton.Click += RemoveItemButton_Click;
        // 
        // ClearCartButton
        // 
        ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        ClearCartButton.Location = new System.Drawing.Point(258, 3);
        ClearCartButton.Name = "ClearCartButton";
        ClearCartButton.Size = new System.Drawing.Size(82, 39);
        ClearCartButton.TabIndex = 2;
        ClearCartButton.Text = "Clear Cart";
        ClearCartButton.UseVisualStyleBackColor = true;
        ClearCartButton.Click += ClearCartButton_Click;
        // 
        // AmountValueLabel
        // 
        AmountValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        AmountValueLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        AmountValueLabel.Location = new System.Drawing.Point(241, 210);
        AmountValueLabel.Name = "AmountValueLabel";
        AmountValueLabel.Size = new System.Drawing.Size(105, 33);
        AmountValueLabel.TabIndex = 5;
        AmountValueLabel.Text = "4 999,90";
        AmountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        label4.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label4.Location = new System.Drawing.Point(285, 196);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(61, 23);
        label4.TabIndex = 4;
        label4.Text = "Amount:";
        // 
        // CartTextBox
        // 
        CartTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        CartTextBox.Location = new System.Drawing.Point(3, 94);
        CartTextBox.Multiline = true;
        CartTextBox.Name = "CartTextBox";
        CartTextBox.Size = new System.Drawing.Size(343, 99);
        CartTextBox.TabIndex = 3;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(4, 68);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(38, 23);
        label3.TabIndex = 2;
        label3.Text = "Cart:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CustomerComboBox
        // 
        CustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        CustomerComboBox.FormattingEnabled = true;
        CustomerComboBox.Location = new System.Drawing.Point(81, 30);
        CustomerComboBox.Name = "CustomerComboBox";
        CustomerComboBox.Size = new System.Drawing.Size(266, 23);
        CustomerComboBox.TabIndex = 1;
        CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(4, 30);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(71, 23);
        label2.TabIndex = 0;
        label2.Text = "Customer:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CartsTab
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Size = new System.Drawing.Size(592, 434);
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button ClearCartButton;

    private System.Windows.Forms.Button RemoveItemButton;

    private System.Windows.Forms.Button CreateOrderButton;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.Label AmountValueLabel;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox CartTextBox;

    private System.Windows.Forms.ComboBox CustomerComboBox;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button AddToCartButton;
    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.ListBox ItemsListBox;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}