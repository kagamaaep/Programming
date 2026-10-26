using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View;

/// <summary>
/// Предоставляет главное окно приложения, содержащее вкладки для управления товарами и покупателями.
/// </summary>
public partial class MainForm : Form
{
    /// <summary>
    /// Пользовательский элемент управления для работы со списком товаров.
    /// </summary>
    private ItemsTab _itemsTab;
    /// <summary>
    /// Пользовательский элемент управления для работы со списком покупателей.
    /// </summary>
    private CustomersTab _customersTab;

    public MainForm()
    {
        InitializeComponent();
        _itemsTab = new ItemsTab();
        _itemsTab.Dock = DockStyle.Fill;
        tabPage1.Controls.Add(_itemsTab);
        
        _customersTab = new CustomersTab();
        _customersTab.Dock = DockStyle.Fill;
        
        tabControl1.TabPages[1].Controls.Add(_customersTab);
    }

    /// <summary>
    /// Срабатывает при первоначальной загрузке главной формы на экран.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void MainForm_Load(object sender, EventArgs e)
    {
    }
}