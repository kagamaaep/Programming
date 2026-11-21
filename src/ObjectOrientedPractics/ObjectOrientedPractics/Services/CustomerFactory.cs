using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services;

/// <summary>
/// Сервисный класс для автоматической генерации случайных покупателей.
/// </summary>
public static class CustomerFactory
{
    private static readonly Random _random = new Random();
    
    private static readonly string[] _fullnames =
        [
            "Кириллова Антония Антоновна","Тетерин Данила Ефимович",
            "Никитина Антонина Никитьевна", "Журавлева Вероника Михаиловна",
            "Ермакова Валерия Саввановна", "Анисимов Ефим Лукьевич", "Блохин Ипполит Савванович",
            "Дорофеева Аграфена Кирилловна", "Селезнев Иннокентий Серафимович", "Куликов Иван Власович"
        ];
    
    private static readonly Address[] _addresses =
        [
            new Address(101000, "Росссия", "Москва","Ул. Железнодорожная", "17","122"),
            new Address(102000, "Росссия", "Томск","Иркутский тракт", "122","101"),
            new Address(103000, "Росссия", "Новосибирск","Ул. Мира", "11","2"),
            new Address(104000, "Росссия", "Новокузнецк","Ул. Красноармейская", "14","59"),
            new Address(101000, "Росссия", "Пенза","Ул. Пролетарская", "31/2","63"),
            new Address(101000, "Росссия", "Владивосток","Школьный пер.", "11а","98")
        ];

    public static Customer GenerateCustomer()
    {
        string randomFullName = _fullnames[_random.Next(_fullnames.Length)];
        Address randomAddress = _addresses[_random.Next(_addresses.Length)];

        return new Customer(randomFullName, randomAddress); 
    }
}