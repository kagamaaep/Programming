using System.ComponentModel;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs;

/// <summary>
/// Предоставляет пользовательский интерфейс для просмотра, поиска, сортировки и управления заказами.
/// </summary>
public partial class OrdersTab : UserControl
{
    private record OrderRowEntry(Order Order, Customer Customer);

    private List<Customer> _customers = new List<Customer>();
    private List<OrderRowEntry> _allEntries = new List<OrderRowEntry>();
    private List<OrderRowEntry> _displayedEntries = new List<OrderRowEntry>();

    private string? _sortColumnName;
    private bool _sortAscending = true;

    /// <summary>
    /// Возвращает и задает список покупателей магазина.
    /// </summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public List<Customer> Customers
    {
        get { return _customers; }
        set
        {
            _customers = value;
            UpdateOrders();
        }
    }

    public OrdersTab()
    {
        InitializeComponent();
        orderControl1.StatusChanged += OrderControl1_StatusChanged;
    }

    /// <summary>
    /// Обновляет данные на вкладке при переключении на нее.
    /// </summary>
    public void RefreshData()
    {
        UpdateOrders();
    }

    /// <summary>
    /// Собирает заказы всех покупателей в общий список и обновляет таблицу.
    /// </summary>
    private void UpdateOrders()
    {
        _allEntries.Clear();

        if (_customers != null)
        {
            foreach (var customer in _customers)
            {
                if (customer.Orders == null) continue;

                foreach (var order in customer.Orders)
                {
                    _allEntries.Add(new OrderRowEntry(order, customer));
                }
            }
        }

        ApplyFilterAndSort();
    }

    /// <summary>
    /// Применяет фильтрацию по строке поиска и текущую сортировку к списку заказов.
    /// </summary>
    private void ApplyFilterAndSort()
    {
        string query = FindTextBox.Text.Trim();
        IEnumerable<OrderRowEntry> result = _allEntries;

        if (!string.IsNullOrEmpty(query))
        {
            result = result.Where(entry =>
                entry.Customer.FullName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                entry.Order.Status.ToString().Contains(query, StringComparison.OrdinalIgnoreCase) ||
                FormatAddress(entry.Order.Address).Contains(query, StringComparison.OrdinalIgnoreCase));
        }

        if (_sortColumnName == nameof(IdColumn))
        {
            result = _sortAscending
                ? result.OrderBy(e => e.Order.Id)
                : result.OrderByDescending(e => e.Order.Id);
        }
        else if (_sortColumnName == nameof(AmountColumn))
        {
            result = _sortAscending
                ? result.OrderBy(e => e.Order.Amount)
                : result.OrderByDescending(e => e.Order.Amount);
        }

        _displayedEntries = result.ToList();
        RenderTable();
    }

    /// <summary>
    /// Отрисовывает отфильтрованные и отсортированные заказы в таблице.
    /// </summary>
    private void RenderTable()
    {
        OrdersDataGridView.Rows.Clear();

        foreach (var entry in _displayedEntries)
        {
            OrdersDataGridView.Rows.Add(
                entry.Order.Id,
                entry.Order.Date,
                entry.Customer.FullName,
                FormatAddress(entry.Order.Address),
                entry.Order.Amount.ToString("F2"),
                entry.Order.Status
            );
        }

        if (_displayedEntries.Count == 0)
        {
            orderControl1.Order = null;
        }
    }

    private static string FormatAddress(Address address)
    {
        return $"{address.Index}, {address.Country}, {address.City}, " +
               $"{address.Street}, {address.Building}, {address.Apartment}";
    }

    private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (OrdersDataGridView.SelectedRows.Count == 0)
        {
            orderControl1.Order = null;
            return;
        }

        int index = OrdersDataGridView.SelectedRows[0].Index;
        if (index < 0 || index >= _displayedEntries.Count)
        {
            orderControl1.Order = null;
            return;
        }

        orderControl1.Order = _displayedEntries[index].Order;
    }

    private void OrderControl1_StatusChanged(object? sender, EventArgs e)
    {
        if (OrdersDataGridView.SelectedRows.Count == 0 || orderControl1.Order == null)
        {
            return;
        }

        int rowIndex = OrdersDataGridView.SelectedRows[0].Index;
        OrdersDataGridView.Rows[rowIndex].Cells[1].Value = orderControl1.Order.Date;
        OrdersDataGridView.Rows[rowIndex].Cells[5].Value = orderControl1.Order.Status;
    }

    private void FindTextBox_TextChanged(object sender, EventArgs e)
    {
        ApplyFilterAndSort();
    }

    private void OrdersDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        string columnName = OrdersDataGridView.Columns[e.ColumnIndex].Name;

        if (columnName != nameof(IdColumn) && columnName != nameof(AmountColumn))
        {
            return;
        }

        if (_sortColumnName == columnName)
        {
            _sortAscending = !_sortAscending;
        }
        else
        {
            _sortColumnName = columnName;
            _sortAscending = true;
        }

        ApplyFilterAndSort();
    }
}