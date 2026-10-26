namespace ObjectOrientedPractics.Services;

/// <summary>
/// Предоставляет метод генерации уникального Id.
/// </summary>
public static class IdGenerator
{
    /// <summary>
    /// Накопительный счетчик для создания уникальных номеров.
    /// </summary>
    private static int _idCounter = 0;
    
    /// <summary>
    /// Генерирует и возвращает следующий уникальный числовой идентификатор.
    /// </summary>
    /// <returns>Уникальный целочисленный идентификатор, увеличенный на единицу.</returns>
    public static int GetNextId()
    {
        _idCounter++;
        return _idCounter;
    }
}