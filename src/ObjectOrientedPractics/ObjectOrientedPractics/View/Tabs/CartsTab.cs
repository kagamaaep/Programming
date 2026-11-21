using System.ComponentModel;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs;

/// <summary>
/// Представляет вкладку для управления корзиной покупателя и оформления заказов.
/// </summary>
public partial class CartsTab : UserControl
{
    private List<Item> _items;
    private List<Customer> _customers;

    /// <summary>
    /// Возвращает и задает список товаров магазина.
    /// </summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public List<Item> Items
    {
        get
        {
            return _items;
        }
        set
        {
            _items = value;
            UpdateItemsListBox();
        }
    }

    /// <summary>
    /// Возвращает и задает список покупателей магазина.
    /// </summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public List<Customer> Customers
    {
        get
        {
            return _customers;
        }
        set
        {
            _customers = value;
            UpdateCustomersComboBox();
        }
    }

    /// <summary>
    /// Возвращает и задает текущего выбранного покупателя.
    /// </summary>
    private Customer CurrentCustomer { get; set; }

    public CartsTab()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Обновляет данные на вкладке при переключении на нее.
    /// </summary>
    public void RefreshData()
    {
        UpdateItemsListBox();

        var selectedCustomer = CurrentCustomer;
        UpdateCustomersComboBox();

        if (selectedCustomer != null && _customers != null && _customers.Contains(selectedCustomer))
        {
            CustomerComboBox.SelectedItem = selectedCustomer;
        }
        else
        {
            CustomerComboBox.SelectedIndex = -1;
            CurrentCustomer = null;
            UpdateCartTextBox();
        }
    }

    /// <summary>
    /// Обновляет список товаров в левом ListBox.
    /// </summary>
    private void UpdateItemsListBox()
    {
        ItemsListBox.Items.Clear();
        if (_items == null) return;

        foreach (var item in _items)
        {
            ItemsListBox.Items.Add(item);
        }
    }

    /// <summary>
    /// Обновляет список покупателей в ComboBox.
    /// </summary>
    private void UpdateCustomersComboBox()
    {
        CustomerComboBox.Items.Clear();
        if (_customers == null) return;

        foreach (var customer in _customers)
        {
            CustomerComboBox.Items.Add(customer);
        }
    }

    /// <summary>
    /// Обновляет список товаров в корзине текущего покупателя и общую стоимость.
    /// </summary>
    private void UpdateCartTextBox()
    {
        CartTextBox.Clear();

        if (CurrentCustomer == null || CurrentCustomer.Cart == null)
        {
            AmountValueLabel.Text = "0.00";
            return;
        }

        CartTextBox.Lines = CurrentCustomer.Cart.Items.Select(item => item.ToString()).ToArray();
        AmountValueLabel.Text = CurrentCustomer.Cart.Amount.ToString("F2");
    }

    private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        CurrentCustomer = CustomerComboBox.SelectedItem as Customer;
        UpdateCartTextBox();
    }

    private void AddToCartButton_Click(object sender, EventArgs e)
    {
        if (CurrentCustomer == null || ItemsListBox.SelectedItem is not Item selectedItem)
        {
            return;
        }

        CurrentCustomer.Cart.Items.Add(selectedItem);
        UpdateCartTextBox();
    }

    private void RemoveItemButton_Click(object sender, EventArgs e)
    {
        if (CurrentCustomer == null || CurrentCustomer.Cart.Items.Count == 0)
        {
            return;
        }

        int lineIndex = CartTextBox.GetLineFromCharIndex(CartTextBox.SelectionStart);
        if (lineIndex >= 0 && lineIndex < CurrentCustomer.Cart.Items.Count)
        {
            CurrentCustomer.Cart.Items.RemoveAt(lineIndex);
        }
        else
        {
            CurrentCustomer.Cart.Items.RemoveAt(CurrentCustomer.Cart.Items.Count - 1);
        }

        UpdateCartTextBox();
    }

    private void ClearCartButton_Click(object sender, EventArgs e)
    {
        if (CurrentCustomer == null)
        {
            return;
        }

        CurrentCustomer.Cart.Items.Clear();
        UpdateCartTextBox();
    }

    private void CreateOrderButton_Click(object sender, EventArgs e)
    {
        if (CurrentCustomer == null || CurrentCustomer.Cart.Items.Count == 0)
        {
            return;
        }

        var orderItems = new List<Item>(CurrentCustomer.Cart.Items);
        var order = new Order(CurrentCustomer.Address, orderItems);

        CurrentCustomer.Orders.Add(order);
        CurrentCustomer.Cart.Items.Clear();

        UpdateCartTextBox();
    }
}