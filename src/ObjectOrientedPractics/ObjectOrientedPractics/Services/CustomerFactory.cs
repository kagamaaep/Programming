using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services;

/// <summary>
/// Сервисный класс для автоматической генерации случайных покупателей.
/// </summary>
public static class CustomerFactory
{
    //Объект для генерации случайных чисел
    private static readonly Random _random = new Random();
    
    //Массив заготовок для имён
    private static readonly string[] _fullnames =
        [
            "Кириллова Антония Антоновна","Тетерин Данила Ефимович",
            "Никитина Антонина Никитьевна", "Журавлева Вероника Михаиловна",
            "Ермакова Валерия Саввановна", "Анисимов Ефим Лукьевич", "Блохин Ипполит Савванович",
            "Дорофеева Аграфена Кирилловна", "Селезнев Иннокентий Серафимович", "Куликов Иван Власович"
        ];
    
    //Массив заготовок для адресов
    private static readonly string[] _addresses =
        [
            "Россия, г. Москва, Железнодорожная ул., 17, корп. 1, кв. 122","Россия, г. Москва, Школьный пер., 17, корп. 5, кв. 43",
            "Россия, г. Москва, Мира ул., 29, корп. 2, кв. 50", "Россия, г. Москва, Заречный пер., 87, корп. 6, кв. 77",
            "Россия, г. Москва, Пролетарская ул., 26, корп. 3, кв. 116", "Россия, г. Москва, Мичурина ул., 30, корп. 6, кв. 61",
            "Россия, г. Москва, Ленинская ул., 31, корп. 4, кв. 193", "Россия, г. Москва, Полевая ул., 4, корп. 5, кв. 56",
            "Россия, г. Москва, Первомайский пер., 25, корп. 5, кв. 104", "Россия, г. Москва, 17 Сентября ул., 60, корп. 2, кв. 30"
        ];

    public static Customer GenerateCustomer()
    {
        string randomFullName = _fullnames[_random.Next(_fullnames.Length)];
        string randomAddress = _addresses[_random.Next(_addresses.Length)];

        return new Customer(randomFullName, randomAddress);
    }
}