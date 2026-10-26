using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет модель товара с Id, именем, описанием и стоимостью.
/// </summary>
public class Item
{
    private readonly int _id;
    private string _name = string.Empty;
    private string _info = string.Empty;
    private double _cost;

    /// <summary>
    /// Возвращает Id товара.
    /// </summary>
    public int Id { get { return _id; } }

    /// <summary>
    /// Возвращает и задаёт название товара.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если длина строки превышает 200 символов.</exception>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
            _name = value;
        }
    }
    
    /// <summary>
    /// Возвращает и задаёт информацию о товаре.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если длина строки превышает 1000 символов.</exception>
    public string Info
    {
        get
        {
            return _info;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
            _info = value;
        }
    }

    /// <summary>
    /// Возвращает и задаёт стоимость товара.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение находится вне диапазона от 0 до 100 000.</exception>
    public double Cost
    {
        get
        {
            return _cost;
        }
        set
        {
            // Проверяем цену на вхождение в допустимый диапазон
            if (value is < 0 or > 100000)
            {
                throw new ArgumentException("Стоимость товара должна быть в диапазоне от 0 до 100000.");
            }
            _cost = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/> по умолчанию с автоматической генерацией идентификатора.
    /// </summary>
    public Item()
    {
        _id=IdGenerator.GetNextId();
    }
    
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/> с заданными параметрами.
    /// </summary>
    /// <param name="name">Название товара. Должно быть не более 200 символов.</param>
    /// <param name="info">Описание товара. Должно быть не более 1000 символов.</param>
    /// <param name="cost">Стоимость товара. Должна быть в диапазоне от 0 до 100 000.</param>
    public Item(string name, string info, double cost)
    {
        Name = name;
        Info = info;
        Cost = cost;
        _id = IdGenerator.GetNextId();
    }
    
    /// <summary>
    /// Возвращает строковое представление текущего товара для отображения в интерфейсе.
    /// </summary>
    /// <returns>Название товара.</returns>
    public override string ToString() { return Name; }
}