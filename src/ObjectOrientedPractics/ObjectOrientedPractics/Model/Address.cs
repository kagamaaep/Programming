using ObjectOrientedPractics.Services;
namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет адрес доставки.
/// </summary>
public class Address
{
    private int _index;
    private string _country = String.Empty;
    private string _city = String.Empty;
    private string _street = String.Empty;
    private string _building  = String.Empty;
    private string _apartment  = String.Empty;

    /// <summary>
    /// Возвращает и задаёт почтовый индекс.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение вне диапазона от 100000 до 999999.</exception>
    public int Index
    {
        get
        {
            return _index;
        }
        set
        {
            ValueValidator.AssertOnRange(value, 100000, 999999, nameof(Index));
            _index = value;
        }
    }

    /// <summary>
    /// Возвращает и задаёт страну/регион.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если длина строки больше 50 символов.</exception>
    public string Country
    {
        get
        {
            return _country;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
            _country = value;
        }
    }

    /// <summary>
    /// Возвращает и задаёт город.
    /// </summary>
    /// /// <exception cref="ArgumentException">Выбрасывается, если длина строки больше 50 символов.</exception>
    public string City
    {
        get
        {
            return _city;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value,50, nameof(City));
            _city = value;
        }
    }
    
    /// <summary>
    /// Возвращает и задаёт улицу.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если длина строки больше 100 символов.</exception>
    public string Street
    {
        get
        {
            return _street;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
            _street = value;
        }
    }

    /// <summary>
    /// Возвращает и задаёт номер дома.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если длина строки больше 10 символов.</exception>
    public string Building
    {
        get
        {
            return _building;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value,10, nameof(Building));
            _building = value;
        }
    }

    /// <summary>
    /// Возвращает и задаёт номер квартиры.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если длина строки больше 10 символов.</exception>
    public string Apartment
    {
        get
        {
            return _apartment;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value,10, nameof(Apartment));
            _apartment = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Address"/> по умолчанию.
    /// </summary>
    [System.Text.Json.Serialization.JsonConstructor]
    public Address()
    {
        Index = 100000;
        Country = String.Empty;
        City = String.Empty;
        Street = String.Empty;
        Building = String.Empty;
        Apartment = String.Empty;
    }

    /// <summary>
    /// Создаёт экземпляр кдасса <see cref="Address"/> с заданными параметрами.
    /// </summary>
    /// <param name="index">Почтовый индекс. Должен быть целым шестизначным числом.</param>
    /// <param name="country">Страна/регион. Должно быть не более 50 символов.</param>
    /// <param name="city">Город. Должен быть не более 50 символов.</param>
    /// <param name="street">Улица. Должна быть не более 100 символов.</param>
    /// <param name="building">Номер дома. Должен быть не более 10 символов.</param>
    /// <param name="apartment">Номер квартиры. Должен быть не более 10 символов.</param>
    public Address(int index, string country, string city, string street, string building, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
    }
}