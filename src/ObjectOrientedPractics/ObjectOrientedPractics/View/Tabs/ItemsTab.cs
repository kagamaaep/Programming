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
    /// Возвращает и задает список товаров вкладки.
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

        var categories = Enum.GetValues(typeof(Category));
        foreach (var category in categories)
        {
            CategoryComboBox.Items.Add(category);
        }
    }

    private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1)
        {
            IdTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            InfoTextBox.Text = string.Empty;
            CategoryComboBox.SelectedIndex = -1;
            return;
        }

        if (ItemsListBox.SelectedItem is not Item selectedItem)
        {
            return;
        }

        IdTextBox.Text = selectedItem.Id.ToString();
        CostTextBox.Text = selectedItem.Cost.ToString();
        NameTextBox.Text = selectedItem.Name;
        InfoTextBox.Text = selectedItem.Info;
        CategoryComboBox.SelectedItem = selectedItem.Category;
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        Item newItem = new Item();
        newItem.Name = $"Товар {newItem.Id}";
        newItem.Cost = 100;
        newItem.Info = "Описание товара";
        newItem.Category = Category.Electronics;

        _items.Add(newItem);
        ItemsListBox.Items.Add(newItem);
        ItemsListBox.SelectedItem = newItem;
    }

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
    }

    private void GenerateButton_Click(object sender, EventArgs e)
    {
        Item randomItem = ItemFactory.GenerateItem();
        _items.Add(randomItem);
        ItemsListBox.Items.Add(randomItem);
        ItemsListBox.SelectedItem = randomItem;
    }

    private void CostTextBox_TextChanged(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1 || ItemsListBox.SelectedItem is not Item selectedItem)
        {
            return;
        }

        try
        {
            selectedItem.Cost = double.Parse(CostTextBox.Text);
            CostTextBox.BackColor = Color.White;
        }
        catch (Exception)
        {
            CostTextBox.BackColor = Color.Red;
        }
    }

    private void NameTextBox_TextChanged(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1 || ItemsListBox.SelectedItem is not Item selectedItem)
        {
            return;
        }

        try
        {
            selectedItem.Name = NameTextBox.Text;
            NameTextBox.BackColor = Color.White;
            int selectionStart = NameTextBox.SelectionStart;
            int index = ItemsListBox.SelectedIndex;
            ItemsListBox.Items[index] = selectedItem;
            NameTextBox.SelectionStart = selectionStart;
        }
        catch (Exception)
        {
            NameTextBox.BackColor = Color.Red;
        }
    }

    private void InfoTextBox_TextChanged(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1 || ItemsListBox.SelectedItem is not Item selectedItem)
        {
            return;
        }

        try
        {
            selectedItem.Info = InfoTextBox.Text;
            InfoTextBox.BackColor = Color.White;
        }
        catch (Exception)
        {
            InfoTextBox.BackColor = Color.Red;
        }
    }

    private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ItemsListBox.SelectedIndex == -1 || ItemsListBox.SelectedItem is not Item selectedItem)
        {
            return;
        }

        if (CategoryComboBox.SelectedItem is Category selectedCategory)
        {
            selectedItem.Category = selectedCategory;
        }
    }

    private void UpdateListBox()
    {
        ItemsListBox.Items.Clear();

        foreach (var item in _items)
        {
            ItemsListBox.Items.Add(item);
        }
    }
}