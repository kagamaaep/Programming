using System.ComponentModel;

namespace ObjectOrientedPractics.Tabs;

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
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        listBox1 = new System.Windows.Forms.ListBox();
        label1 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        textBox4 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
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
        tableLayoutPanel1.Size = new System.Drawing.Size(592, 434);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.WhiteSmoke;
        panel1.Controls.Add(tableLayoutPanel2);
        panel1.Controls.Add(listBox1);
        panel1.Controls.Add(label1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(230, 428);
        panel1.TabIndex = 0;
        panel1.Paint += panel1_Paint;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.Controls.Add(button1, 0, 0);
        tableLayoutPanel2.Controls.Add(button2, 1, 0);
        tableLayoutPanel2.Location = new System.Drawing.Point(4, 380);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new System.Drawing.Size(223, 45);
        tableLayoutPanel2.TabIndex = 2;
        // 
        // button1
        // 
        button1.Dock = System.Windows.Forms.DockStyle.Fill;
        button1.Location = new System.Drawing.Point(3, 3);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(68, 39);
        button1.TabIndex = 0;
        button1.Text = "Add";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Dock = System.Windows.Forms.DockStyle.Fill;
        button2.Location = new System.Drawing.Point(77, 3);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(68, 39);
        button2.TabIndex = 1;
        button2.Text = "Remove";
        button2.UseVisualStyleBackColor = true;
        // 
        // listBox1
        // 
        listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        listBox1.BackColor = System.Drawing.Color.White;
        listBox1.FormattingEnabled = true;
        listBox1.IntegralHeight = false;
        listBox1.Location = new System.Drawing.Point(3, 20);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(223, 357);
        listBox1.TabIndex = 1;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(4, 4);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 21);
        label1.TabIndex = 0;
        label1.Text = "Items";
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.White;
        panel2.Controls.Add(textBox4);
        panel2.Controls.Add(textBox3);
        panel2.Controls.Add(label6);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(textBox2);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(textBox1);
        panel2.Controls.Add(label2);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(239, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(350, 428);
        panel2.TabIndex = 1;
        panel2.Paint += panel2_Paint;
        // 
        // textBox4
        // 
        textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox4.BackColor = System.Drawing.Color.White;
        textBox4.Location = new System.Drawing.Point(2, 214);
        textBox4.Multiline = true;
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(344, 133);
        textBox4.TabIndex = 9;
        // 
        // textBox3
        // 
        textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox3.BackColor = System.Drawing.Color.White;
        textBox3.Location = new System.Drawing.Point(2, 109);
        textBox3.Multiline = true;
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(344, 76);
        textBox3.TabIndex = 8;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(2, 188);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(82, 23);
        label6.TabIndex = 7;
        label6.Text = "Description:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(2, 83);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(53, 23);
        label5.TabIndex = 5;
        label5.Text = "Name:";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        label5.Click += label5_Click;
        // 
        // textBox2
        // 
        textBox2.BackColor = System.Drawing.Color.White;
        textBox2.Location = new System.Drawing.Point(49, 57);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(100, 23);
        textBox2.TabIndex = 4;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(2, 56);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(41, 23);
        label4.TabIndex = 3;
        label4.Text = "Cost:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(2, 27);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(41, 23);
        label3.TabIndex = 2;
        label3.Text = "ID:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBox1
        // 
        textBox1.BackColor = System.Drawing.Color.White;
        textBox1.Location = new System.Drawing.Point(49, 28);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(100, 23);
        textBox1.TabIndex = 1;
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
        Size = new System.Drawing.Size(592, 434);
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox textBox4;

    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}