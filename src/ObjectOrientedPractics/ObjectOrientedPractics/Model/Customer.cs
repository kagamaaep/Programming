using System.Text.Json.Serialization;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет покупателя магазина с уникальным идентификатором, именем, адресом, корзиной и списком заказов.
/// </summary>
public class Customer
{
    private readonly int _id;
    private string _fullName;
    private Address _address;
    private Cart _cart;
    private List<Order> _orders;

    /// <summary>
    /// Возвращает уникальный идентификатор покупателя.
    /// </summary>
    [JsonInclude]
    public int Id
    {
        get { return _id; }
        private init { _id = value; }
    }

    /// <summary>
    /// Возвращает и задает полное имя покупателя (не более 200 символов).
    /// </summary>
    public string FullName
    {
        get { return _fullName; }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
            _fullName = value;
        }
    }

    /// <summary>
    /// Возвращает и задает адрес доставки покупателя.
    /// </summary>
    public Address Address
    {
        get { return _address; }
        set
        {
            ValueValidator.AssertValueNotNull(value, nameof(Address));
            _address = value;
        }
    }

    /// <summary>
    /// Возвращает и задает корзину покупателя.
    /// </summary>
    public Cart Cart
    {
        get { return _cart; }
        set { _cart = value; }
    }

    /// <summary>
    /// Возвращает и задает список заказов покупателя.
    /// </summary>
    public List<Order> Orders
    {
        get { return _orders; }
        set { _orders = value; }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Customer"/> по умолчанию.
    /// </summary>
    [JsonConstructor]
    public Customer()
    {
        _id = IdGenerator.GetNextId();
        _fullName = "Покупатель";
        _address = new Address();
        _cart = new Cart();
        _orders = new List<Order>();
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Customer"/> с указанным полным именем и адресом.
    /// </summary>
    /// <param name="fullName">Полное имя покупателя.</param>
    /// <param name="address">Адрес доставки.</param>
    public Customer(string fullName, Address address)
    {
        _id = IdGenerator.GetNextId();
        FullName = fullName;
        Address = address;
        _cart = new Cart();
        _orders = new List<Order>();
    }

    /// <summary>
    /// Возвращает строковое представление покупателя для отображения в элементах интерфейса.
    /// </summary>
    /// <returns>Полное имя покупателя.</returns>
    public override string ToString()
    {
        return FullName;
    }
}