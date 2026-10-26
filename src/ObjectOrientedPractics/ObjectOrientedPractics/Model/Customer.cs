using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет данные о покупателе с уникальным идентификатором, полным именем и адресом доставки.
/// </summary>
public class Customer
{
    private readonly int _id;
    private string _fullname = string.Empty;
    private string _address = string.Empty;

    /// <summary>
    /// Возвращает Id покупателя.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Возвращает и задаёт полное имя покупателя.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если длина строки превышает 200 символов.</exception>
    public string FullName
    {
        get
        {
            return _fullname;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
            _fullname = value;
        }
    }
    
    /// <summary>
    /// Возвращает и задаёт адрес доставки покупателя.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если длина строки превышает 500 символов.</exception>
    public string Address
    {
        get
        {
            return _address;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
            _address = value;
        }
    }
    
    /// <summary>
    /// Создаёт экземпляр <see cref="Customer"/>.
    /// </summary>
    public Customer()
    {
        _id=IdGenerator.GetNextId();
    }
    
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/> с заданными параметрами.
    /// </summary>
    /// <param name="fullname">Полное имя покупателя. Должно быть не более 200 символов.</param>
    /// <param name="address">Адрес покупателя. Должен быть не более 500 символов.</param>
    public Customer(string fullname, string address)
    {
        FullName = fullname;
        Address = address;
        _id = IdGenerator.GetNextId();
    }
    
    /// <summary>
    /// Возвращает строковое представление текущего покупателя для отображения в интерфейсе.
    /// </summary>
    /// <returns>Полное имя покупателя.</returns>
    public override string ToString() { return FullName; }
}