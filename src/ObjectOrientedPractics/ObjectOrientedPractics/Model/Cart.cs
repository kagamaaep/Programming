using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет корзину товаров покупателя.
/// </summary>
public class Cart
{
    private List<Item> _items = new List<Item>();

    /// <summary>
    /// Возвращает и задает список товаров в корзине.
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
    /// Возвращает общую стоимость всех товаров в корзине.
    /// </summary>
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
    /// Создает пустой экземпляр класса <see cref="Cart"/>.
    /// </summary>
    public Cart()
    {
    }
}