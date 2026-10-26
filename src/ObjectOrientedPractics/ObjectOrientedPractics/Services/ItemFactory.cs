using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services;

/// <summary>
/// Сервисный класс для автоматической генерации случайных товаров.
/// </summary>
public static class ItemFactory
{
    //Объект для генерации случайных чисел
    private static readonly Random _random = new Random();
    
    //Массив заготовок для названий товаров
    private static readonly string[] _names =
        [
            "Умный будильник «AeroWake»","Беспроводная мышь «Клик-Мастер 3000»",
            "Вечная свеча «Lumina Aura»", "Одеяло с терморегуляцией «КлиматКонтроль»",
            "Рюкзак-антивор «SecurePack»", "Умный зонт «RainGlow»", "Складные гантели «FlexiWeight»", "Умная бутылка для воды «HydroPulse»"
        ];
    
    //Массив заготовок для описания товаров
    private static readonly string[] _infos =
        [
            "Постепенно увеличивает яркость подсветки и активирует аромакапсулу за 15 минут до звонка.","Имеет 8 программируемых кнопок и бесшумное колесо прокрутки.",
            "Управляется со смартфона, поддерживает 16 миллионов цветов и имеет таймер выключения.", "Одна сторона охлаждает в жару, а вторая — удерживает тепло в зимние ночи.",
            "Изготовлен из водонепроницаемой ткани, устойчивой к порезам, имеет встроенный USB-порт.", "Синхронизируется с прогнозом погоды по Bluetooth и светится мягким синим цветом, если скоро пойдет дождь.",
            "Заменяют целый гантельный ряд, регулируются от 2 до 24 кг с помощью дискового механизма.",
            "Встроенный светодиодный индикатор на дне мигает каждые 40 минут, а приложение на смартфоне считает дневной баланс воды."
        ];

    public static Item GenerateItem()
    {
        string randomName = _names[_random.Next(_names.Length)];
        string randomInfo = _infos[_random.Next(_infos.Length)];
        double randomCost = _random.Next(0,100000);

        return new Item(randomName, randomInfo, randomCost);
    }
}