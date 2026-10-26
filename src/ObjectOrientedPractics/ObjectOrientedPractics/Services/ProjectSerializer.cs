using System.Text.Json;using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services;

/// <summary>
/// Сервисный класс для сохранения и загрузки данных приложения в файлы JSON.
/// </summary>
public class ProjectSerializer
{
    private static readonly string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

    private static readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true
    };
    
    /// <summary>
    /// Сохраняет список товаров в файл.
    /// </summary>
    /// <param name="items"></param>
    public static void SaveItems(List<Item> items)
    {
        // Если папки еще нет в AppData - создаём её
        if (!Directory.Exists(_appDataPath))
        {
            Directory.CreateDirectory(_appDataPath);
        }
        
        string filePath = Path.Combine(_appDataPath, "items.json");
        // Превращаем список объектов в строку JSON
        string  jsonString = JsonSerializer.Serialize(items, _options);
        // Записываем строку в файл
        File.WriteAllText(filePath, jsonString);
    }

    /// <summary>
    /// Загружает список товаров из файла.
    /// </summary>
    /// <returns></returns>
    public static List<Item> LoadItems()
    {
        string filePath = Path.Combine(_appDataPath, "items.json");

        if (!File.Exists(filePath))
        {
            return [];// Если файла еще нет
        }
        
        string jsonString = File.ReadAllText(filePath);
        // Восстанавливаем объекты обратно из строки JSON обратно в List<Item>
        return JsonSerializer.Deserialize<List<Item>>(jsonString) ?? [];
    }
    
    /// <summary>
    /// Сохраняет список покупателей в файл.
    /// </summary>
    /// <param name="customers"></param>
    public static void SaveCustomers(List<Customer> customers)
    {
        // Если папки еще нет в AppData - создаём её
        if (!Directory.Exists(_appDataPath))
        {
            Directory.CreateDirectory(_appDataPath);
        }
        
        string filePath = Path.Combine(_appDataPath, "customers.json");
        // Превращаем список объектов в строку JSON
        string  jsonString = JsonSerializer.Serialize(customers, _options);
        // Записываем строку в файл
        File.WriteAllText(filePath, jsonString);
    }

    /// <summary>
    /// Загружает список покупателей из файла.
    /// </summary>
    /// <returns></returns>
    public static List<Customer> LoadCustomers()
    {
        string filePath = Path.Combine(_appDataPath, "customers.json");

        if (!File.Exists(filePath))
        {
            return [];// Если файла еще нет
        }

        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Customer>>(jsonString) ?? [];
    }
}