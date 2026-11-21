using System.ComponentModel;

namespace ObjectOrientedPractics.View.Controls;

partial class AddressControl
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        PostIndexTextBox = new System.Windows.Forms.TextBox();
        CountryTextBox = new System.Windows.Forms.TextBox();
        StreetTextBox = new System.Windows.Forms.TextBox();
        BuildingTextBox = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        CityTextBox = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        ApartmentTextBox = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(145, 23);
        label1.TabIndex = 0;
        label1.Text = "Delivery Address";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(0, 29);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(80, 23);
        label2.TabIndex = 1;
        label2.Text = "Post Index:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(0, 58);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(64, 23);
        label3.TabIndex = 2;
        label3.Text = "Country:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(0, 87);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(46, 23);
        label4.TabIndex = 3;
        label4.Text = "Street:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(0, 116);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(64, 23);
        label5.TabIndex = 4;
        label5.Text = "Building:";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // PostIndexTextBox
        // 
        PostIndexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        PostIndexTextBox.Location = new System.Drawing.Point(86, 29);
        PostIndexTextBox.Name = "PostIndexTextBox";
        PostIndexTextBox.Size = new System.Drawing.Size(255, 23);
        PostIndexTextBox.TabIndex = 5;
        PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
        // 
        // CountryTextBox
        // 
        CountryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        CountryTextBox.Location = new System.Drawing.Point(86, 58);
        CountryTextBox.Name = "CountryTextBox";
        CountryTextBox.Size = new System.Drawing.Size(97, 23);
        CountryTextBox.TabIndex = 6;
        CountryTextBox.TextChanged += CountryTextBox_TextChanged;
        // 
        // StreetTextBox
        // 
        StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        StreetTextBox.Location = new System.Drawing.Point(86, 88);
        StreetTextBox.Name = "StreetTextBox";
        StreetTextBox.Size = new System.Drawing.Size(255, 23);
        StreetTextBox.TabIndex = 7;
        StreetTextBox.TextChanged += StreetTextBox_TextChanged;
        // 
        // BuildingTextBox
        // 
        BuildingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        BuildingTextBox.Location = new System.Drawing.Point(86, 116);
        BuildingTextBox.Name = "BuildingTextBox";
        BuildingTextBox.Size = new System.Drawing.Size(80, 23);
        BuildingTextBox.TabIndex = 8;
        BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(206, 58);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(38, 23);
        label6.TabIndex = 9;
        label6.Text = "City:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CityTextBox
        // 
        CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        CityTextBox.Location = new System.Drawing.Point(244, 59);
        CityTextBox.Name = "CityTextBox";
        CityTextBox.Size = new System.Drawing.Size(97, 23);
        CityTextBox.TabIndex = 10;
        CityTextBox.TextChanged += CityTextBox_TextChanged;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(183, 118);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(72, 21);
        label7.TabIndex = 11;
        label7.Text = "Apartment:";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // ApartmentTextBox
        // 
        ApartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        ApartmentTextBox.Location = new System.Drawing.Point(261, 116);
        ApartmentTextBox.Name = "ApartmentTextBox";
        ApartmentTextBox.Size = new System.Drawing.Size(80, 23);
        ApartmentTextBox.TabIndex = 12;
        ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
        // 
        // AddressControl
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        Controls.Add(ApartmentTextBox);
        Controls.Add(label7);
        Controls.Add(CityTextBox);
        Controls.Add(label6);
        Controls.Add(BuildingTextBox);
        Controls.Add(StreetTextBox);
        Controls.Add(CountryTextBox);
        Controls.Add(PostIndexTextBox);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Size = new System.Drawing.Size(344, 344);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox ApartmentTextBox;

    private System.Windows.Forms.TextBox CityTextBox;
    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.TextBox StreetTextBox;
    private System.Windows.Forms.TextBox BuildingTextBox;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.TextBox PostIndexTextBox;
    private System.Windows.Forms.TextBox CountryTextBox;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;

    #endregion
}