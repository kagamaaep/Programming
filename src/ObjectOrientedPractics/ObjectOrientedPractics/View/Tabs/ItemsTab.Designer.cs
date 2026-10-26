using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs;

partial class ItemsTab
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
        ButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        AddButton = new System.Windows.Forms.Button();
        RemoveButton = new System.Windows.Forms.Button();
        GenerateButton = new System.Windows.Forms.Button();
        ItemsListBox = new System.Windows.Forms.ListBox();
        ItemsLabel = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        InfoTextBox = new System.Windows.Forms.TextBox();
        NameTextBox = new System.Windows.Forms.TextBox();
        InfoLabel = new System.Windows.Forms.Label();
        NameLabel = new System.Windows.Forms.Label();
        CostTextBox = new System.Windows.Forms.TextBox();
        CostLabel = new System.Windows.Forms.Label();
        IdLabel = new System.Windows.Forms.Label();
        IdTextBox = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        ButtonsLayoutPanel.SuspendLayout();
        panel2.SuspendLayout();
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
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new System.Drawing.Size(572, 434);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.WhiteSmoke;
        panel1.Controls.Add(ButtonsLayoutPanel);
        panel1.Controls.Add(ItemsListBox);
        panel1.Controls.Add(ItemsLabel);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(222, 428);
        panel1.TabIndex = 0;
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
        ButtonsLayoutPanel.Size = new System.Drawing.Size(215, 45);
        ButtonsLayoutPanel.TabIndex = 2;
        // 
        // AddButton
        // 
        AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
        AddButton.Location = new System.Drawing.Point(3, 3);
        AddButton.Name = "AddButton";
        AddButton.Size = new System.Drawing.Size(65, 39);
        AddButton.TabIndex = 0;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // RemoveButton
        // 
        RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
        RemoveButton.Location = new System.Drawing.Point(74, 3);
        RemoveButton.Name = "RemoveButton";
        RemoveButton.Size = new System.Drawing.Size(65, 39);
        RemoveButton.TabIndex = 1;
        RemoveButton.Text = "Remove";
        RemoveButton.UseVisualStyleBackColor = true;
        RemoveButton.Click += RemoveButton_Click;
        // 
        // GenerateButton
        // 
        GenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
        GenerateButton.Location = new System.Drawing.Point(145, 3);
        GenerateButton.Name = "GenerateButton";
        GenerateButton.Size = new System.Drawing.Size(67, 39);
        GenerateButton.TabIndex = 2;
        GenerateButton.Text = "Generate";
        GenerateButton.UseVisualStyleBackColor = true;
        GenerateButton.Click += GenerateButton_Click;
        // 
        // ItemsListBox
        // 
        ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        ItemsListBox.BackColor = System.Drawing.Color.White;
        ItemsListBox.FormattingEnabled = true;
        ItemsListBox.IntegralHeight = false;
        ItemsListBox.Location = new System.Drawing.Point(3, 20);
        ItemsListBox.Name = "ItemsListBox";
        ItemsListBox.Size = new System.Drawing.Size(219, 357);
        ItemsListBox.TabIndex = 1;
        ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
        // 
        // ItemsLabel
        // 
        ItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        ItemsLabel.Location = new System.Drawing.Point(4, 4);
        ItemsLabel.Name = "ItemsLabel";
        ItemsLabel.Size = new System.Drawing.Size(100, 21);
        ItemsLabel.TabIndex = 0;
        ItemsLabel.Text = "Items";
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.White;
        panel2.Controls.Add(InfoTextBox);
        panel2.Controls.Add(NameTextBox);
        panel2.Controls.Add(InfoLabel);
        panel2.Controls.Add(NameLabel);
        panel2.Controls.Add(CostTextBox);
        panel2.Controls.Add(CostLabel);
        panel2.Controls.Add(IdLabel);
        panel2.Controls.Add(IdTextBox);
        panel2.Controls.Add(label2);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(231, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(338, 428);
        panel2.TabIndex = 1;
        // 
        // InfoTextBox
        // 
        InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        InfoTextBox.BackColor = System.Drawing.Color.White;
        InfoTextBox.Location = new System.Drawing.Point(2, 214);
        InfoTextBox.Multiline = true;
        InfoTextBox.Name = "InfoTextBox";
        InfoTextBox.Size = new System.Drawing.Size(332, 133);
        InfoTextBox.TabIndex = 9;
        InfoTextBox.TextChanged += InfoTextBox_TextChanged;
        // 
        // NameTextBox
        // 
        NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        NameTextBox.BackColor = System.Drawing.Color.White;
        NameTextBox.Location = new System.Drawing.Point(2, 109);
        NameTextBox.Multiline = true;
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new System.Drawing.Size(332, 76);
        NameTextBox.TabIndex = 8;
        NameTextBox.TextChanged += NameTextBox_TextChanged;
        // 
        // InfoLabel
        // 
        InfoLabel.Location = new System.Drawing.Point(2, 188);
        InfoLabel.Name = "InfoLabel";
        InfoLabel.Size = new System.Drawing.Size(82, 23);
        InfoLabel.TabIndex = 7;
        InfoLabel.Text = "Description:";
        InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // NameLabel
        // 
        NameLabel.Location = new System.Drawing.Point(2, 83);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new System.Drawing.Size(53, 23);
        NameLabel.TabIndex = 5;
        NameLabel.Text = "Name:";
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CostTextBox
        // 
        CostTextBox.BackColor = System.Drawing.Color.White;
        CostTextBox.Location = new System.Drawing.Point(49, 57);
        CostTextBox.Name = "CostTextBox";
        CostTextBox.Size = new System.Drawing.Size(100, 23);
        CostTextBox.TabIndex = 4;
        CostTextBox.TextChanged += CostTextBox_TextChanged;
        // 
        // CostLabel
        // 
        CostLabel.Location = new System.Drawing.Point(2, 56);
        CostLabel.Name = "CostLabel";
        CostLabel.Size = new System.Drawing.Size(41, 23);
        CostLabel.TabIndex = 3;
        CostLabel.Text = "Cost:";
        CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.Location = new System.Drawing.Point(2, 27);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new System.Drawing.Size(41, 23);
        IdLabel.TabIndex = 2;
        IdLabel.Text = "ID:";
        IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // IdTextBox
        // 
        IdTextBox.BackColor = System.Drawing.Color.White;
        IdTextBox.Location = new System.Drawing.Point(49, 28);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new System.Drawing.Size(100, 23);
        IdTextBox.TabIndex = 1;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label2.Location = new System.Drawing.Point(3, 4);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 21);
        label2.TabIndex = 1;
        label2.Text = "Selected Item";
        // 
        // ItemsTab
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Size = new System.Drawing.Size(572, 434);
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ButtonsLayoutPanel.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button GenerateButton;

    private System.Windows.Forms.TextBox InfoTextBox;

    private System.Windows.Forms.TextBox NameTextBox;

    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Button RemoveButton;

    private System.Windows.Forms.Label InfoLabel;

    private System.Windows.Forms.ListBox ItemsListBox;
    private System.Windows.Forms.TableLayoutPanel ButtonsLayoutPanel;

    private System.Windows.Forms.Label CostLabel;
    private System.Windows.Forms.TextBox CostTextBox;
    private System.Windows.Forms.Label NameLabel;

    private System.Windows.Forms.Label IdLabel;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox IdTextBox;

    private System.Windows.Forms.Label ItemsLabel;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}