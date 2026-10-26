using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет данные о покупателе.
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
    /// Возвращает адрес покупателя.
    /// </summary>
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
    /// 
    /// </summary>
    /// <param name="fullname">Полное имя покупателя. Должно быть меньше 200 символов.</param>
    /// <param name="address">Адрес покупателя. Должен быть меньше 500 символов.</param>
    public Customer(string fullname, string address)
    {
        _id = IdGenerator.GetNextId();
        FullName = fullname;
        Address = address;
        
        // TODO: Добавить логирование создания нового покупателя в файл
    }
}