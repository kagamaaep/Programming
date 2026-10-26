using ObjectOrientedPractics.Tabs;

namespace ObjectOrientedPractics;

public partial class MainForm : Form
{
    private ItemsTab _itemsTab;

    public MainForm()
    {
        InitializeComponent();

        _itemsTab = new ItemsTab();
        _itemsTab.Dock = DockStyle.Fill;
        tabPage1.Controls.Add(_itemsTab);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {
    }

    private void tabPage2_Click_1(object sender, EventArgs e)
    {
    }
}