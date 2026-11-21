using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View;

/// <summary>
/// Предоставляет главное окно приложения, содержащее вкладки для управления товарами, покупателями, корзинами и заказами.
/// </summary>
public partial class MainForm : Form
{
    private Store _store;
    private ItemsTab _itemsTab;
    private CustomersTab _customersTab;

    public MainForm()
    {
        InitializeComponent();

        _store = ProjectSerializer.LoadStore();

        _itemsTab = new ItemsTab();
        _itemsTab.Dock = DockStyle.Fill;
        tabPage1.Controls.Add(_itemsTab);

        _customersTab = new CustomersTab();
        _customersTab.Dock = DockStyle.Fill;
        tabPage2.Controls.Add(_customersTab);

        _itemsTab.Items = _store.Items;
        _customersTab.Customers = _store.Customers;
        _customersTab.Items = _store.Items;
        cartsTab1.Items = _store.Items;
        cartsTab1.Customers = _store.Customers;
        ordersTab1.Customers = _store.Customers;

        tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        FormClosing += MainForm_FormClosing;
    }

    private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl1.SelectedIndex == 2)
        {
            cartsTab1.RefreshData();
        }
        else if (tabControl1.SelectedIndex == 3)
        {
            ordersTab1.RefreshData();
        }
    }

    private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        ProjectSerializer.SaveStore(_store);
    }
}