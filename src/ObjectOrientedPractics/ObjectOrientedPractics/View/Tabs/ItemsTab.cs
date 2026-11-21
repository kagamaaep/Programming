using System.ComponentModel;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs;

/// <summary>
/// Предоставляет пользовательский интерфейс для управления списком товаров.
/// </summary>
public partial class ItemsTab : UserControl
{
    private List<Item> _items = new List<Item>();

    /// <summary>
    /// Возвращает и задаёт список товаров вкладки.
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
            ValueValidator.AssertValueNotNull(value, nameof(Items));
            _items = value;
            UpdateListBox();
        }
    }
    
    /// <summary>
    /// Создает экземпляр класса <see cref="ItemsTab"/> и инициализирует компоненты.
    /// </summary>
    public ItemsTab()
    {
        InitializeComponent();
        IdTextBox.ReadOnly = true;
        _items = ProjectSerializer.LoadItems();
        foreach (var item in _items)
        {
            ItemsListBox.Items.Add(item);
        }

        var categories = Enum.GetValues(typeof(Category));
        foreach (var category in categories)
        {
            CategoryComboBox.Items.Add(category);
        }
    }
    
    /// <summary>
    /// Срабатывает при изменении выбранного товара в визуальном списке.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private  void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1)
        {
            IdTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            InfoTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;
            CategoryComboBox.SelectedIndex = -1;

            return;
        }

        Item? selectedItem = ItemsListBox.SelectedItem as  Item;

        IdTextBox.Text = selectedItem?.Id.ToString();
        NameTextBox.Text = selectedItem?.Name;
        InfoTextBox.Text = selectedItem?.Info;
        CostTextBox.Text = (selectedItem?.Cost).ToString();
        CategoryComboBox.SelectedItem = selectedItem?.Category;
    }

    /// <summary>
    /// Срабатывает при нажатии на кнопку добавления товара.
    /// Создает пустой шаблон товара.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void AddButton_Click(object sender, EventArgs e)
    {
        Item newItem = new Item();
        newItem.Name = $"Товар {newItem.Id}";
        newItem.Info = "Описание товара";
        newItem.Cost = 0;
        
        _items.Add(newItem);
        ItemsListBox.Items.Add(newItem);
        ItemsListBox.SelectedItem = newItem;
    }

    /// <summary>
    /// Срабатывает при нажатии на кнопку удаления товара.
    /// Удаляет выбранный товар из памяти и с экрана.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void RemoveButton_Click(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1)
        {
            return;
        }

        int selectedIndex = ItemsListBox.SelectedIndex;
        _items.RemoveAt(selectedIndex);
        ItemsListBox.Items.RemoveAt(selectedIndex);

        if (ItemsListBox.Items.Count > 0)
        {
            if (selectedIndex >= ItemsListBox.Items.Count)
            {
                selectedIndex = ItemsListBox.Items.Count - 1;
            }

            ItemsListBox.SelectedIndex = selectedIndex;
        }
        ProjectSerializer.SaveItems(_items);
    }

    /// <summary>
    /// Срабатывает при изменении текста в поле названия товара.
    /// Сохраняет изменения с защитой положения курсора.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void NameTextBox_TextChanged(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1)
        {
            return;
        }

        Item? selectedItem = ItemsListBox.SelectedItem as Item;

        if (selectedItem != null)
        {
            try
            {
                selectedItem.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
                int selectionStart = NameTextBox.SelectionStart;
                int index = ItemsListBox.SelectedIndex;
                ItemsListBox.Items[index] = selectedItem;
                NameTextBox.SelectionStart = selectionStart;
                ProjectSerializer.SaveItems(_items);
            }
            catch (Exception)
            {
                NameTextBox.BackColor = Color.Red;
            }
        }
    }
    
    /// <summary>
    /// Срабатывает при изменении текста в поле описания товара.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void InfoTextBox_TextChanged(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1)
        {
            return;
        }

        Item? selectedItem = ItemsListBox.SelectedItem as Item;

        if (selectedItem != null)
        {
            try
            {
                selectedItem.Info = InfoTextBox.Text;
                InfoTextBox.BackColor = Color.White;
                ProjectSerializer.SaveItems(_items);
            }
            catch (Exception)
            {
                InfoTextBox.BackColor = Color.Red;
            }
        }
    }

    /// <summary>
    /// Срабатывает при изменении текста в поле стоимости товара.
    /// Конвертирует строку в число вещественного типа.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void CostTextBox_TextChanged(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1)
        {
            return;
        }

        Item? selectedItem = ItemsListBox.SelectedItem as Item;
        
        if (selectedItem != null)
        {
            if (double.TryParse(CostTextBox.Text, out double cost))
            {
                try
                {
                    selectedItem.Cost = cost;
                    CostTextBox.BackColor = Color.White;
                    ProjectSerializer.SaveItems(_items);
                }
                catch (ArgumentException)
                {
                    CostTextBox.BackColor = Color.Red;
                }
            }
            else
            {
                CostTextBox.BackColor = Color.Red;
            }
        }
    }

    /// <summary>
    /// Обрабатывает изменение выбранной категории товара.
    /// </summary>
    private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1 || CategoryComboBox.SelectedIndex == -1)
        {
            return;
        }

        _items[ItemsListBox.SelectedIndex].Category = (Category)CategoryComboBox.SelectedIndex;
    }

    /// <summary>
    /// Срабатывает при нажатии на кнопку генерации случайного товара.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void GenerateButton_Click(object sender, EventArgs e)
    {
        Item randomItem = ItemFactory.GenerateItem();
        _items.Add(randomItem);
        ItemsListBox.Items.Add(randomItem);
        ItemsListBox.SelectedItem = randomItem;
        ProjectSerializer.SaveItems(_items);
    }
    
    /// <summary>
    /// Обновляет отображение списка товаров в элементе ListBox.
    /// </summary>
    private void UpdateListBox()
    {
        ItemsListBox.Items.Clear();

        foreach (var item in _items)
        {
            ItemsListBox.Items.Add(item);
        }
    }
}