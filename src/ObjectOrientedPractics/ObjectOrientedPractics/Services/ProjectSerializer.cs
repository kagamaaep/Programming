using System.Text.Json;
using System.Text.Json.Serialization;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services;

/// <summary>
/// Сервисный класс для сохранения и загрузки данных магазина в файл JSON с сохранением ссылок.
/// </summary>
public class ProjectSerializer
{
    private static readonly string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

    private static readonly JsonSerializerOptions _options = new JsonSerializerOptions
    {
        WriteIndented = true,
        ReferenceHandler = ReferenceHandler.Preserve
    };

    /// <summary>
    /// Сохраняет экземпляр магазина <see cref="Store"/> в файл store.json.
    /// </summary>
    /// <param name="store">Экземпляр магазина.</param>
    public static void SaveStore(Store store)
    {
        if (!Directory.Exists(_appDataPath))
        {
            Directory.CreateDirectory(_appDataPath);
        }

        string filePath = Path.Combine(_appDataPath, "store.json");
        string jsonString = JsonSerializer.Serialize(store, _options);
        File.WriteAllText(filePath, jsonString);
    }

    /// <summary>
    /// Загружает экземпляр магазина <see cref="Store"/> из файла store.json.
    /// </summary>
    /// <returns>Загруженный экземпляр магазина или новый пустой экземпляр.</returns>
    public static Store LoadStore()
    {
        string filePath = Path.Combine(_appDataPath, "store.json");

        if (!File.Exists(filePath))
        {
            return new Store();
        }

        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Store>(jsonString, _options) ?? new Store();
    }
}