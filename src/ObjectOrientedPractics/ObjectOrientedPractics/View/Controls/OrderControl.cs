using System.ComponentModel;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls;

/// <summary>
/// Предоставляет элемент управления для отображения информации о выбранном заказе и изменения его статуса.
/// </summary>
public partial class OrderControl : UserControl
{
    private Order? _order;

    /// <summary>
    /// Событие, возникающее при изменении статуса заказа пользователем.
    /// </summary>
    public event EventHandler? StatusChanged;

    /// <summary>
    /// Возвращает и задает отображаемый заказ.
    /// </summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Order? Order
    {
        get { return _order; }
        set
        {
            _order = value;
            UpdateOrderInfo();
        }
    }

    public OrderControl()
    {
        InitializeComponent();

        IdTextBox.ReadOnly = true;
        CreatedTextBox.ReadOnly = true;
        OrderItemsListBox.SelectionMode = SelectionMode.None;

        foreach (var status in Enum.GetValues(typeof(OrderStatus)))
        {
            StatusComboBox.Items.Add(status);
        }

        UpdateOrderInfo();
    }

    /// <summary>
    /// Обновляет элементы управления в соответствии с текущим заказом.
    /// </summary>
    private void UpdateOrderInfo()
    {
        if (_order == null)
        {
            IdTextBox.Text = string.Empty;
            CreatedTextBox.Text = string.Empty;
            StatusComboBox.SelectedIndex = -1;
            StatusComboBox.Enabled = false;
            addressControl1.Address = new Address();
            OrderItemsListBox.Items.Clear();
            AmountValueLabel.Text = "0.00";
            return;
        }

        IdTextBox.Text = _order.Id.ToString();
        CreatedTextBox.Text = _order.Date.ToString();
        StatusComboBox.Enabled = true;
        StatusComboBox.SelectedItem = _order.Status;
        addressControl1.Address = _order.Address;

        OrderItemsListBox.Items.Clear();
        foreach (var item in _order.Items)
        {
            OrderItemsListBox.Items.Add(item);
        }

        AmountValueLabel.Text = _order.Amount.ToString("F2");
    }

    private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_order == null || StatusComboBox.SelectedItem is not OrderStatus newStatus)
        {
            return;
        }

        if (_order.Status != newStatus)
        {
            _order.Status = newStatus;
            CreatedTextBox.Text = _order.Date.ToString();
            StatusChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}