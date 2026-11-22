using System.ComponentModel;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs;

partial class CustomersTab
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
        panel1 = new System.Windows.Forms.Panel();
        ButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        AddButton = new System.Windows.Forms.Button();
        RemoveButton = new System.Windows.Forms.Button();
        GenerateButton = new System.Windows.Forms.Button();
        CustomersListBox = new System.Windows.Forms.ListBox();
        CustomersLabel = new System.Windows.Forms.Label();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        panel2 = new System.Windows.Forms.Panel();
        addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        FullNameTextBox = new System.Windows.Forms.TextBox();
        IdTextBox = new System.Windows.Forms.TextBox();
        SelectedCustomerLabel = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        ButtonsLayoutPanel.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.WhiteSmoke;
        panel1.Controls.Add(ButtonsLayoutPanel);
        panel1.Controls.Add(CustomersListBox);
        panel1.Controls.Add(CustomersLabel);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(230, 428);
        panel1.TabIndex = 1;
        // 
        // ButtonsLayoutPanel
        // 
        ButtonsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        ButtonsLayoutPanel.ColumnCount = 3;
        ButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        ButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        ButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        ButtonsLayoutPanel.Controls.Add(AddButton, 0, 0);
        ButtonsLayoutPanel.Controls.Add(RemoveButton, 1, 0);
        ButtonsLayoutPanel.Controls.Add(GenerateButton, 2, 0);
        ButtonsLayoutPanel.Location = new System.Drawing.Point(4, 380);
        ButtonsLayoutPanel.Name = "ButtonsLayoutPanel";
        ButtonsLayoutPanel.RowCount = 1;
        ButtonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        ButtonsLayoutPanel.Size = new System.Drawing.Size(223, 45);
        ButtonsLayoutPanel.TabIndex = 2;
        // 
        // AddButton
        // 
        AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
        AddButton.Location = new System.Drawing.Point(3, 3);
        AddButton.Name = "AddButton";
        AddButton.Size = new System.Drawing.Size(68, 39);
        AddButton.TabIndex = 0;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // RemoveButton
        // 
        RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
        RemoveButton.Location = new System.Drawing.Point(77, 3);
        RemoveButton.Name = "RemoveButton";
        RemoveButton.Size = new System.Drawing.Size(68, 39);
        RemoveButton.TabIndex = 1;
        RemoveButton.Text = "Remove";
        RemoveButton.UseVisualStyleBackColor = true;
        RemoveButton.Click += RemoveButton_Click;
        // 
        // GenerateButton
        // 
        GenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
        GenerateButton.Location = new System.Drawing.Point(151, 3);
        GenerateButton.Name = "GenerateButton";
        GenerateButton.Size = new System.Drawing.Size(69, 39);
        GenerateButton.TabIndex = 2;
        GenerateButton.Text = "Generate";
        GenerateButton.UseVisualStyleBackColor = true;
        GenerateButton.Click += GenerateButton_Click;
        // 
        // CustomersListBox
        // 
        CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        CustomersListBox.FormattingEnabled = true;
        CustomersListBox.IntegralHeight = false;
        CustomersListBox.Location = new System.Drawing.Point(3, 20);
        CustomersListBox.Name = "CustomersListBox";
        CustomersListBox.Size = new System.Drawing.Size(227, 357);
        CustomersListBox.TabIndex = 1;
        CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
        // 
        // CustomersLabel
        // 
        CustomersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        CustomersLabel.Location = new System.Drawing.Point(4, 4);
        CustomersLabel.Name = "CustomersLabel";
        CustomersLabel.Size = new System.Drawing.Size(100, 23);
        CustomersLabel.TabIndex = 0;
        CustomersLabel.Text = "Customers";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
        tableLayoutPanel1.Controls.Add(panel1, 0, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new System.Drawing.Size(592, 434);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(panel2, 0, 0);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(236, 0);
        tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tableLayoutPanel2.Size = new System.Drawing.Size(356, 434);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.White;
        panel2.Controls.Add(addressControl1);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(FullNameTextBox);
        panel2.Controls.Add(IdTextBox);
        panel2.Controls.Add(SelectedCustomerLabel);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(350, 428);
        panel2.TabIndex = 0;
        // 
        // addressControl1
        // 
        addressControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        addressControl1.BackColor = System.Drawing.Color.White;
        addressControl1.Location = new System.Drawing.Point(4, 95);
        addressControl1.Name = "addressControl1";
        addressControl1.Size = new System.Drawing.Size(344, 333);
        addressControl1.TabIndex = 7;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(2, 56);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(74, 23);
        label4.TabIndex = 3;
        label4.Text = "Full Name:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(2, 27);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(58, 23);
        label3.TabIndex = 2;
        label3.Text = "ID:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // FullNameTextBox
        // 
        FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        FullNameTextBox.Location = new System.Drawing.Point(83, 57);
        FullNameTextBox.Name = "FullNameTextBox";
        FullNameTextBox.Size = new System.Drawing.Size(204, 23);
        FullNameTextBox.TabIndex = 6;
        FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
        // 
        // IdTextBox
        // 
        IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        IdTextBox.BackColor = System.Drawing.Color.White;
        IdTextBox.Location = new System.Drawing.Point(83, 28);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new System.Drawing.Size(154, 23);
        IdTextBox.TabIndex = 5;
        // 
        // SelectedCustomerLabel
        // 
        SelectedCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        SelectedCustomerLabel.Location = new System.Drawing.Point(3, 4);
        SelectedCustomerLabel.Name = "SelectedCustomerLabel";
        SelectedCustomerLabel.Size = new System.Drawing.Size(123, 23);
        SelectedCustomerLabel.TabIndex = 1;
        SelectedCustomerLabel.Text = "Selected Customer";
        // 
        // CustomersTab
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Size = new System.Drawing.Size(592, 434);
        panel1.ResumeLayout(false);
        ButtonsLayoutPanel.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    private ObjectOrientedPractics.View.Controls.AddressControl addressControl1;

    private System.Windows.Forms.Button GenerateButton;

    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Button RemoveButton;

    private System.Windows.Forms.TableLayoutPanel ButtonsLayoutPanel;

    private System.Windows.Forms.TextBox FullNameTextBox;

    private System.Windows.Forms.TextBox IdTextBox;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.ListBox CustomersListBox;

    private System.Windows.Forms.Label SelectedCustomerLabel;

    private System.Windows.Forms.Label CustomersLabel;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    
    
    #endregion
}