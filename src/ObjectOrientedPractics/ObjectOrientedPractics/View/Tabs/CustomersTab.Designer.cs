using System.ComponentModel;

namespace ObjectOrientedPractics.Tabs;

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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        panel2 = new System.Windows.Forms.Panel();
        label4 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox1 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        listBox1 = new System.Windows.Forms.ListBox();
        label1 = new System.Windows.Forms.Label();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
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
        tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(panel2, 0, 0);
        tableLayoutPanel2.Controls.Add(panel3, 0, 1);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(323, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tableLayoutPanel2.Size = new System.Drawing.Size(474, 444);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.White;
        panel2.Controls.Add(label4);
        panel2.Controls.Add(textBox3);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(textBox2);
        panel2.Controls.Add(textBox1);
        panel2.Controls.Add(label2);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(468, 171);
        panel2.TabIndex = 0;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(3, 62);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(74, 23);
        label4.TabIndex = 3;
        label4.Text = "Full Name:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        label4.Click += label4_Click;
        // 
        // textBox3
        // 
        textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox3.Location = new System.Drawing.Point(83, 91);
        textBox3.Multiline = true;
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(382, 77);
        textBox3.TabIndex = 7;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(3, 33);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(58, 23);
        label3.TabIndex = 2;
        label3.Text = "ID:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(3, 91);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(74, 23);
        label5.TabIndex = 4;
        label5.Text = "Address:";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBox2
        // 
        textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox2.Location = new System.Drawing.Point(83, 62);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(382, 23);
        textBox2.TabIndex = 6;
        // 
        // textBox1
        // 
        textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox1.Location = new System.Drawing.Point(83, 33);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(154, 23);
        textBox1.TabIndex = 5;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label2.Location = new System.Drawing.Point(2, 1);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(123, 23);
        label2.TabIndex = 1;
        label2.Text = "Selected Customer";
        label2.Click += label2_Click;
        // 
        // panel3
        // 
        panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        panel3.BackColor = System.Drawing.Color.White;
        panel3.Location = new System.Drawing.Point(3, 180);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(468, 261);
        panel3.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel3);
        panel1.Controls.Add(listBox1);
        panel1.Controls.Add(label1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(314, 444);
        panel1.TabIndex = 1;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel3.ColumnCount = 3;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel3.Controls.Add(button1, 0, 0);
        tableLayoutPanel3.Controls.Add(button2, 1, 0);
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 391);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel3.Size = new System.Drawing.Size(308, 50);
        tableLayoutPanel3.TabIndex = 2;
        // 
        // button1
        // 
        button1.Dock = System.Windows.Forms.DockStyle.Fill;
        button1.Location = new System.Drawing.Point(3, 3);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(96, 44);
        button1.TabIndex = 0;
        button1.Text = "Add";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Dock = System.Windows.Forms.DockStyle.Fill;
        button2.Location = new System.Drawing.Point(105, 3);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(96, 44);
        button2.TabIndex = 1;
        button2.Text = "Remove";
        button2.UseVisualStyleBackColor = true;
        // 
        // listBox1
        // 
        listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        listBox1.FormattingEnabled = true;
        listBox1.IntegralHeight = false;
        listBox1.Location = new System.Drawing.Point(0, 20);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(311, 368);
        listBox1.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(1, 4);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 0;
        label1.Text = "Customers";
        // 
        // Customers
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Size = new System.Drawing.Size(800, 450);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel1.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.ListBox listBox1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}