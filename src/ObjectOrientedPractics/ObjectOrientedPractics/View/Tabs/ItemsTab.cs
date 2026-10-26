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
    /// Создает экземпляр класса <see cref="ItemsTab"/> и инициализирует компоненты.
    /// </summary>
    public ItemsTab()
    {
        InitializeComponent();
        IdTextBox.ReadOnly = true;
        _items = ProjectSerializer.LoadItems(); // Загружаем сохраненные товары в память

        foreach (var item in _items)
        {
            ItemsListBox.Items.Add(item);
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

            return;
        }

        Item? selectedItem = ItemsListBox.SelectedItem as  Item;

        IdTextBox.Text = selectedItem?.Id.ToString();
        NameTextBox.Text = selectedItem?.Name;
        InfoTextBox.Text = selectedItem?.Info;
        CostTextBox.Text = (selectedItem?.Cost).ToString();
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
                    // 4. Передаем число в свойство класса, где сработает проверка от 0 до 100 000
                    selectedItem.Cost = cost;
                    // Если всё хорошо — возвращаем белый фон
                    CostTextBox.BackColor = Color.White;
                    ProjectSerializer.SaveItems(_items);
                }
                catch (ArgumentException)
                {
                    // Если число правильное, но вышло за рамки лимита (например, 500 000)
                    CostTextBox.BackColor = Color.Red;
                }
            }
            else
            {
                // 5. Если пользователь ввел буквы (например, "сто рублей") или оставил поле пустым
                CostTextBox.BackColor = Color.Red;
            }
        }
    }

    /// <summary>
    /// Срабатывает при нажатии на кнопку генерации случайного товара.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void GenerateButton_Click(object sender, EventArgs e)
    {
        Item randomItem = Services.ItemFactory.GenerateItem();
        _items.Add(randomItem);
        ItemsListBox.Items.Add(randomItem);
        ItemsListBox.SelectedItem = randomItem;
        ProjectSerializer.SaveItems(_items);
    }
}