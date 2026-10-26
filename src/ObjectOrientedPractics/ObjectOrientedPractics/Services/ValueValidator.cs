namespace ObjectOrientedPractics.Services;

/// <summary>
/// Предоставляет метод валидации входящих значений и защиты данных от некорректных параметров.
/// </summary>
public class ValueValidator
{
    /// <summary>
    /// Проверяет, что длина строки не превышает максимально допустимое значение.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <param name="maxLength">Максимально допустимая длина строки (количество символов).</param>
    /// <param name="propertyName">Имя свойства, из сеттера которого вызывается проверка (используется в тексте ошибки).</param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если длина строки <paramref name="value"/> превышает значение <paramref name="maxLength"/>.
    /// </exception>
    public static void AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if (value != null && value.Length > maxLength)
        {
            throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
        }
    }
}