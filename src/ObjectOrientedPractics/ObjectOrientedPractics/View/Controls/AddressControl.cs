using ObjectOrientedPractics.Model;
using System.ComponentModel;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls;

public partial class AddressControl : UserControl
{
    /// <summary>
    /// Хранит данные об адресе.
    /// </summary>
    private Address _address = new Address();

    /// <summary>
    /// Возвращает и задаёт адрес.
    /// </summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Address Address
    {
        get
        {
            return _address;
        }
        set
        {
            ValueValidator.AssertValueNotNull(value, nameof(Address));
            _address = value;
            UpdateTextBoxes();
        }
    }
    
    public AddressControl()
    {
        InitializeComponent();
    }

    private void UpdateTextBoxes()
    {
        PostIndexTextBox.Text = _address.Index.ToString();
        CountryTextBox.Text = _address.Country;
        CityTextBox.Text = _address.City;
        StreetTextBox.Text = _address.Street;
        BuildingTextBox.Text = _address.Building;
        ApartmentTextBox.Text = _address.Apartment;
    }

    /// <summary>
    /// Обрабатывает изменение текста в поле почтового индекса.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            PostIndexTextBox.BackColor = Color.White;
            _address.Index = int.Parse(PostIndexTextBox.Text);
        }
        catch (Exception)
        {
            PostIndexTextBox.BackColor = Color.Red;
        }
    }

    /// <summary>
    /// Обрабатывает изменение текста в поле страны.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void CountryTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            CountryTextBox.BackColor = Color.White;
            _address.Country = CountryTextBox.Text;
        }
        catch (Exception)
        {
            CountryTextBox.BackColor = Color.Red;
        }
    }

    /// <summary>
    /// Обрабатывает изменение текста в поле города.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void CityTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            CityTextBox.BackColor = Color.White;
            _address.City = CityTextBox.Text;
        }
        catch (Exception)
        {
            CityTextBox.BackColor = Color.Red;
        }
    }

    /// <summary>
    /// Обрабатывает изменение текста в поле улицы.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void StreetTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            StreetTextBox.BackColor = Color.White;
            _address.Street = StreetTextBox.Text;
        }
        catch (Exception)
        {
            StreetTextBox.BackColor = Color.Red;
        }
    }

    /// <summary>
    /// Обрабатывает изменение текста в поле номера дома.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void BuildingTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            BuildingTextBox.BackColor = Color.White;
            _address.Building = BuildingTextBox.Text;
        }
        catch (Exception)
        {
            BuildingTextBox.BackColor = Color.Red;
        }
    }

    /// <summary>
    /// Обрабатывает изменение текста в поле номера квартиры.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            ApartmentTextBox.BackColor = Color.White;
            _address.Apartment = ApartmentTextBox.Text;
        }
        catch (Exception)
        {
            ApartmentTextBox.BackColor = Color.Red;
        }
    }
}
