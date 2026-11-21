using System.ComponentModel;

namespace ObjectOrientedPractics.View.Controls;

partial class OrderControl
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent()
    {
        AmountValueLabel = new System.Windows.Forms.Label();
        AmountLabel = new System.Windows.Forms.Label();
        OrderItemsListBox = new System.Windows.Forms.ListBox();
        OrderItemsLabel = new System.Windows.Forms.Label();
        addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
        StatusComboBox = new System.Windows.Forms.ComboBox();
        CreatedTextBox = new System.Windows.Forms.TextBox();
        IdTextBox = new System.Windows.Forms.TextBox();
        StatusLabel = new System.Windows.Forms.Label();
        CreatedLabel = new System.Windows.Forms.Label();
        IdLabel = new System.Windows.Forms.Label();
        SelectedOrderLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // AmountValueLabel
        // 
        AmountValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        AmountValueLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        AmountValueLabel.Location = new System.Drawing.Point(240, 405);
        AmountValueLabel.Name = "AmountValueLabel";
        AmountValueLabel.Size = new System.Drawing.Size(134, 33);
        AmountValueLabel.TabIndex = 11;
        AmountValueLabel.Text = "0,00";
        AmountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // AmountLabel
        // 
        AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        AmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        AmountLabel.Location = new System.Drawing.Point(309, 386);
        AmountLabel.Name = "AmountLabel";
        AmountLabel.Size = new System.Drawing.Size(65, 20);
        AmountLabel.TabIndex = 10;
        AmountLabel.Text = "Amount:";
        AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // OrderItemsListBox
        // 
        OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        OrderItemsListBox.FormattingEnabled = true;
        OrderItemsListBox.IntegralHeight = false;
        OrderItemsListBox.Location = new System.Drawing.Point(6, 285);
        OrderItemsListBox.Name = "OrderItemsListBox";
        OrderItemsListBox.Size = new System.Drawing.Size(368, 98);
        OrderItemsListBox.TabIndex = 9;
        // 
        // OrderItemsLabel
        // 
        OrderItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        OrderItemsLabel.Location = new System.Drawing.Point(6, 262);
        OrderItemsLabel.Name = "OrderItemsLabel";
        OrderItemsLabel.Size = new System.Drawing.Size(100, 20);
        OrderItemsLabel.TabIndex = 8;
        OrderItemsLabel.Text = "Order Items";
        // 
        // addressControl1
        // 
        addressControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        addressControl1.BackColor = System.Drawing.Color.White;
        addressControl1.Enabled = false;
        addressControl1.Location = new System.Drawing.Point(3, 114);
        addressControl1.Name = "addressControl1";
        addressControl1.Size = new System.Drawing.Size(374, 142);
        addressControl1.TabIndex = 7;
        // 
        // StatusComboBox
        // 
        StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        StatusComboBox.FormattingEnabled = true;
        StatusComboBox.Location = new System.Drawing.Point(75, 85);
        StatusComboBox.Name = "StatusComboBox";
        StatusComboBox.Size = new System.Drawing.Size(140, 23);
        StatusComboBox.TabIndex = 6;
        StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
        // 
        // CreatedTextBox
        // 
        CreatedTextBox.BackColor = System.Drawing.Color.White;
        CreatedTextBox.Location = new System.Drawing.Point(75, 56);
        CreatedTextBox.Name = "CreatedTextBox";
        CreatedTextBox.ReadOnly = true;
        CreatedTextBox.Size = new System.Drawing.Size(140, 23);
        CreatedTextBox.TabIndex = 5;
        // 
        // IdTextBox
        // 
        IdTextBox.BackColor = System.Drawing.Color.White;
        IdTextBox.Location = new System.Drawing.Point(75, 27);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new System.Drawing.Size(140, 23);
        IdTextBox.TabIndex = 4;
        // 
        // StatusLabel
        // 
        StatusLabel.Location = new System.Drawing.Point(6, 85);
        StatusLabel.Name = "StatusLabel";
        StatusLabel.Size = new System.Drawing.Size(63, 23);
        StatusLabel.TabIndex = 3;
        StatusLabel.Text = "Status:";
        StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CreatedLabel
        // 
        CreatedLabel.Location = new System.Drawing.Point(6, 56);
        CreatedLabel.Name = "CreatedLabel";
        CreatedLabel.Size = new System.Drawing.Size(63, 23);
        CreatedLabel.TabIndex = 2;
        CreatedLabel.Text = "Created:";
        CreatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.Location = new System.Drawing.Point(6, 27);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new System.Drawing.Size(63, 23);
        IdLabel.TabIndex = 1;
        IdLabel.Text = "ID:";
        IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // SelectedOrderLabel
        // 
        SelectedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        SelectedOrderLabel.Location = new System.Drawing.Point(6, 3);
        SelectedOrderLabel.Name = "SelectedOrderLabel";
        SelectedOrderLabel.Size = new System.Drawing.Size(120, 20);
        SelectedOrderLabel.TabIndex = 0;
        SelectedOrderLabel.Text = "Selected Order";
        // 
        // OrderControl
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        Controls.Add(AmountValueLabel);
        Controls.Add(AmountLabel);
        Controls.Add(OrderItemsListBox);
        Controls.Add(OrderItemsLabel);
        Controls.Add(addressControl1);
        Controls.Add(StatusComboBox);
        Controls.Add(CreatedTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(StatusLabel);
        Controls.Add(CreatedLabel);
        Controls.Add(IdLabel);
        Controls.Add(SelectedOrderLabel);
        Name = "OrderControl";
        Size = new System.Drawing.Size(380, 444);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label AmountValueLabel;
    private System.Windows.Forms.Label AmountLabel;
    private System.Windows.Forms.ListBox OrderItemsListBox;
    private System.Windows.Forms.Label OrderItemsLabel;
    private ObjectOrientedPractics.View.Controls.AddressControl addressControl1;
    private System.Windows.Forms.ComboBox StatusComboBox;
    private System.Windows.Forms.TextBox CreatedTextBox;
    private System.Windows.Forms.TextBox IdTextBox;
    private System.Windows.Forms.Label StatusLabel;
    private System.Windows.Forms.Label CreatedLabel;
    private System.Windows.Forms.Label IdLabel;
    private System.Windows.Forms.Label SelectedOrderLabel;

    #endregion
}