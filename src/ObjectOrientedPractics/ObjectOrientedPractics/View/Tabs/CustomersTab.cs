using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs;

/// <summary>
/// Предоставляет пользовательский интерфейс для управления списком покупателей.
/// </summary>
public partial class CustomersTab : UserControl
{
    private List<Customer> _customers = new List<Customer>();
    
    /// <summary>
    /// Создает экземпляр класса <see cref="CustomersTab"/> и инициализирует компоненты.
    /// </summary>
    public CustomersTab()
    {
        InitializeComponent();
        IdTextBox.ReadOnly = true;
        _customers = ProjectSerializer.LoadCustomers(); // Загружаем сохраненные товары в память

        foreach (var customer in _customers)
        {
            CustomersListBox.Items.Add(customer);
        }
    }
    
    /// <summary>
    /// Срабатывает при изменении выбранного покупателя в визуальном списке.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private  void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (CustomersListBox.SelectedIndex == -1)
        {
            IdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;

            return;
        }

        Customer? selectedCustomer = CustomersListBox.SelectedItem as Customer;
        IdTextBox.Text = selectedCustomer?.Id.ToString();
        FullNameTextBox.Text = selectedCustomer?.FullName;
        AddressTextBox.Text = selectedCustomer?.Address;
    }

    /// <summary>
    /// Срабатывает при нажатии на кнопку добавления покупателя.
    /// Создает пустой шаблон карточки покупателя.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void AddButton_Click(object sender, EventArgs e)
    {
        Customer newCustomer = new Customer();
        newCustomer.FullName = $"Покупатель {newCustomer.Id}";
        newCustomer.Address = "Адрес";
        _customers.Add(newCustomer);
        CustomersListBox.Items.Add(newCustomer);
        CustomersListBox.SelectedItem = newCustomer;
        ProjectSerializer.SaveCustomers(_customers);
    }

    /// <summary>
    /// Срабатывает при нажатии на кнопку удаления покупателя.
    /// Удаляет выбранного покупателя из памяти и с экрана.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void RemoveButton_Click(object sender, EventArgs e)
    {
        if (CustomersListBox.SelectedIndex == -1)
        {
            return;
        }

        int selectedIndex = CustomersListBox.SelectedIndex;
        _customers.RemoveAt(selectedIndex);
        CustomersListBox.Items.RemoveAt(selectedIndex);

        if (CustomersListBox.Items.Count > 0)
        {
            if (selectedIndex >= CustomersListBox.Items.Count)
            {
                selectedIndex = CustomersListBox.Items.Count - 1;
            }

            CustomersListBox.SelectedIndex = selectedIndex;
        }
        ProjectSerializer.SaveCustomers(_customers);
    }
    
    /// <summary>
    /// Срабатывает при изменении текста в поле полного имени покупателя.
    /// Сохраняет изменения с защитой положения курсора от ввода задом наперед.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
     private void FullNameTextBox_TextChanged(object sender, EventArgs e)
    {
        if (CustomersListBox.SelectedIndex == -1)
        {
            return;
        }

        Customer? selectedItem = CustomersListBox.SelectedItem as Customer;

        if (selectedItem != null)
        {
            try
            {
                selectedItem.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
                int selectionStart = FullNameTextBox.SelectionStart;
                int index = CustomersListBox.SelectedIndex;
                CustomersListBox.Items[index] = selectedItem;
                FullNameTextBox.SelectionStart = selectionStart;
                ProjectSerializer.SaveCustomers(_customers);
            }
            catch (Exception)
            {
                FullNameTextBox.BackColor = Color.Red;
            }
        }
    }
    
    /// <summary>
    /// Срабатывает при изменении текста в поле адреса покупателя.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void AddressTextBox_TextChanged(object sender, EventArgs e)
    {
        if (CustomersListBox.SelectedIndex == -1)
        {
            return;
        }

        Customer? selectedItem = CustomersListBox.SelectedItem as Customer;

        if (selectedItem != null)
        {
            try
            {
                selectedItem.Address = AddressTextBox.Text;
                AddressTextBox.BackColor = Color.White;
                ProjectSerializer.SaveCustomers(_customers);
            }
            catch (Exception)
            {
                AddressTextBox.BackColor = Color.Red;
            }
        }
    }
    
    /// <summary>
    /// Срабатывает при нажатии на кнопку генерации случайного покупателя.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void GenerateButton_Click(object sender, EventArgs e)
    {
        Customer randomCustomer = CustomerFactory.GenerateCustomer();
        _customers.Add(randomCustomer);
        CustomersListBox.Items.Add(randomCustomer);
        CustomersListBox.SelectedItem = randomCustomer;
        ProjectSerializer.SaveCustomers(_customers);
    }
}