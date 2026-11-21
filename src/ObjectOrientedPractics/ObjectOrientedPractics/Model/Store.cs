using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Хранит данные обо всех товарах и покупателях магазина.
/// </summary>
public class Store
{
    private List<Item> _items;
    private List<Customer> _customers;

    /// <summary>
    /// Возвращает и задаёт список товаров.
    /// </summary>
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
        }
    }

    /// <summary>
    /// Возвращает и задаёт список покупателей.
    /// </summary>
    public List<Customer> Customers
    {
        get
        {
            return _customers;
        }
        set
        {
            ValueValidator.AssertValueNotNull(value, nameof(Customers));
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Store"/> с пустыми списками товаров и покупателей.
    /// </summary>
    public Store()
    {
        _items = new List<Item>();
        _customers = new List<Customer>();
    }
}