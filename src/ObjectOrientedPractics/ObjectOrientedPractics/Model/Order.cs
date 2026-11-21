using System.Text.Json.Serialization;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет заказ покупателя с историей изменения статусов.
/// </summary>
public class Order
{
    private readonly int _id;
    private Address _address;
    private List<Item> _items;
    private OrderStatus _status;
    private Dictionary<DateTime, OrderStatus> _statusHistory;

    /// <summary>
    /// Возвращает уникальный идентификатор заказа.
    /// </summary>
    [JsonInclude]
    public int Id
    {
        get { return _id; }
        private init { _id = value; }
    }

    /// <summary>
    /// Возвращает дату и время последнего изменения статуса заказа.
    /// </summary>
    [JsonIgnore]
    public DateTime Date
    {
        get
        {
            if (_statusHistory != null && _statusHistory.Count > 0)
            {
                return _statusHistory.Keys.Max();
            }

            return DateTime.Now;
        }
    }

    /// <summary>
    /// Возвращает и задает историю изменения статусов заказа.
    /// </summary>
    public Dictionary<DateTime, OrderStatus> StatusHistory
    {
        get { return _statusHistory; }
        set
        {
            ValueValidator.AssertValueNotNull(value, nameof(StatusHistory));
            _statusHistory = value;
        }
    }

    /// <summary>
    /// Возвращает и задает адрес доставки заказа.
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
    /// Возвращает и задает список товаров в заказе.
    /// </summary>
    public List<Item> Items
    {
        get { return _items; }
        set
        {
            ValueValidator.AssertValueNotNull(value, nameof(Items));
            _items = value;
        }
    }

    /// <summary>
    /// Возвращает общую стоимость всех товаров в заказе.
    /// </summary>
    [JsonIgnore]
    public double Amount
    {
        get
        {
            if (_items == null || _items.Count == 0)
            {
                return 0.0;
            }

            double total = 0.0;
            foreach (var item in _items)
            {
                total += item.Cost;
            }

            return total;
        }
    }

    /// <summary>
    /// Возвращает и задает текущий статус заказа с записью в историю изменений.
    /// </summary>
    public OrderStatus Status
    {
        get { return _status; }
        set
        {
            _status = value;
            if (_statusHistory == null)
            {
                _statusHistory = new Dictionary<DateTime, OrderStatus>();
            }

            DateTime timestamp = DateTime.Now;
            while (_statusHistory.ContainsKey(timestamp))
            {
                timestamp = timestamp.AddTicks(1);
            }

            _statusHistory[timestamp] = value;
        }
    }

    /// <summary>
    /// Создает пустой экземпляр класса <see cref="Order"/>.
    /// </summary>
    [JsonConstructor]
    public Order()
    {
        _id = IdGenerator.GetNextId();
        _address = new Address();
        _items = new List<Item>();
        _statusHistory = new Dictionary<DateTime, OrderStatus>();
        Status = OrderStatus.New;
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Order"/> с заданными параметрами.
    /// </summary>
    /// <param name="address">Адрес доставки.</param>
    /// <param name="items">Список товаров.</param>
    public Order(Address address, List<Item> items)
    {
        _id = IdGenerator.GetNextId();
        Address = address;
        Items = items;
        _statusHistory = new Dictionary<DateTime, OrderStatus>();
        Status = OrderStatus.New;
    }
}