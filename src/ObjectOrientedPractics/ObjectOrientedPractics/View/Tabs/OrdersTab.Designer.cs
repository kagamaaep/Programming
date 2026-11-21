using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs;

partial class OrdersTab
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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        panel1 = new System.Windows.Forms.Panel();
        FindTextBox = new System.Windows.Forms.TextBox();
        FindLabel = new System.Windows.Forms.Label();
        OrdersDataGridView = new System.Windows.Forms.DataGridView();
        IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        CustomerFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        DeliveryAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        OrdersLabel = new System.Windows.Forms.Label();
        orderControl1 = new ObjectOrientedPractics.View.Controls.OrderControl();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(panel1, 0, 0);
        tableLayoutPanel1.Controls.Add(orderControl1, 1, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new System.Drawing.Size(780, 450);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.WhiteSmoke;
        panel1.Controls.Add(FindTextBox);
        panel1.Controls.Add(FindLabel);
        panel1.Controls.Add(OrdersDataGridView);
        panel1.Controls.Add(OrdersLabel);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(384, 444);
        panel1.TabIndex = 0;
        // 
        // FindTextBox
        // 
        FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        FindTextBox.Location = new System.Drawing.Point(45, 415);
        FindTextBox.Name = "FindTextBox";
        FindTextBox.Size = new System.Drawing.Size(336, 23);
        FindTextBox.TabIndex = 3;
        FindTextBox.TextChanged += FindTextBox_TextChanged;
        // 
        // FindLabel
        // 
        FindLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        FindLabel.Location = new System.Drawing.Point(3, 415);
        FindLabel.Name = "FindLabel";
        FindLabel.Size = new System.Drawing.Size(40, 23);
        FindLabel.TabIndex = 2;
        FindLabel.Text = "Find:";
        FindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // OrdersDataGridView
        // 
        OrdersDataGridView.AllowUserToAddRows = false;
        OrdersDataGridView.AllowUserToDeleteRows = false;
        OrdersDataGridView.AllowUserToOrderColumns = false;
        OrdersDataGridView.AllowUserToResizeRows = false;
        OrdersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdColumn, CreatedColumn, CustomerFullNameColumn, DeliveryAddressColumn, AmountColumn, OrderStatusColumn });
        OrdersDataGridView.Location = new System.Drawing.Point(3, 25);
        OrdersDataGridView.MultiSelect = false;
        OrdersDataGridView.Name = "OrdersDataGridView";
        OrdersDataGridView.ReadOnly = true;
        OrdersDataGridView.RowHeadersVisible = false;
        OrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        OrdersDataGridView.Size = new System.Drawing.Size(378, 384);
        OrdersDataGridView.TabIndex = 1;
        OrdersDataGridView.ColumnHeaderMouseClick += OrdersDataGridView_ColumnHeaderMouseClick;
        OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
        // 
        // IdColumn
        // 
        IdColumn.FillWeight = 45F;
        IdColumn.HeaderText = "Id";
        IdColumn.Name = "IdColumn";
        IdColumn.ReadOnly = true;
        IdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
        // 
        // CreatedColumn
        // 
        CreatedColumn.FillWeight = 95F;
        CreatedColumn.HeaderText = "Created";
        CreatedColumn.Name = "CreatedColumn";
        CreatedColumn.ReadOnly = true;
        CreatedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        // 
        // CustomerFullNameColumn
        // 
        CustomerFullNameColumn.FillWeight = 115F;
        CustomerFullNameColumn.HeaderText = "Customer Full Name";
        CustomerFullNameColumn.Name = "CustomerFullNameColumn";
        CustomerFullNameColumn.ReadOnly = true;
        CustomerFullNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        // 
        // DeliveryAddressColumn
        // 
        DeliveryAddressColumn.FillWeight = 135F;
        DeliveryAddressColumn.HeaderText = "Delivery Address";
        DeliveryAddressColumn.Name = "DeliveryAddressColumn";
        DeliveryAddressColumn.ReadOnly = true;
        DeliveryAddressColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        // 
        // AmountColumn
        // 
        AmountColumn.FillWeight = 75F;
        AmountColumn.HeaderText = "Amount";
        AmountColumn.Name = "AmountColumn";
        AmountColumn.ReadOnly = true;
        AmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
        // 
        // OrderStatusColumn
        // 
        OrderStatusColumn.FillWeight = 80F;
        OrderStatusColumn.HeaderText = "Order Status";
        OrderStatusColumn.Name = "OrderStatusColumn";
        OrderStatusColumn.ReadOnly = true;
        OrderStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        // 
        // OrdersLabel
        // 
        OrdersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        OrdersLabel.Location = new System.Drawing.Point(3, 3);
        OrdersLabel.Name = "OrdersLabel";
        OrdersLabel.Size = new System.Drawing.Size(100, 20);
        OrdersLabel.TabIndex = 0;
        OrdersLabel.Text = "Orders";
        // 
        // orderControl1
        // 
        orderControl1.BackColor = System.Drawing.Color.White;
        orderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        orderControl1.Location = new System.Drawing.Point(393, 3);
        orderControl1.Name = "orderControl1";
        orderControl1.Size = new System.Drawing.Size(384, 444);
        orderControl1.TabIndex = 1;
        // 
        // OrdersTab
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Name = "OrdersTab";
        Size = new System.Drawing.Size(780, 450);
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox FindTextBox;
    private System.Windows.Forms.Label FindLabel;
    private System.Windows.Forms.DataGridView OrdersDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryAddressColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;
    private System.Windows.Forms.Label OrdersLabel;
    private ObjectOrientedPractics.View.Controls.OrderControl orderControl1;

    #endregion
}