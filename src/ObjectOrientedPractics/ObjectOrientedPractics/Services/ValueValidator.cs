namespace ObjectOrientedPractics.Services;

/// <summary>
/// Сервисный класс, предоставляет метод валидации входящих значений и защиты данных от некорректных параметров.
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

    /// <summary>
    /// Проверяет, находится ли число в заданном диапазоне.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <param name="min">Минимальное число.</param>
    /// <param name="max">Максимальное число.</param>
    /// <param name="propertyName">Имя свойства, из сеттера которого вызывается проверка (используется в тексте ошибки).</param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если число <paramref name="value"/> не находится в диапазоне от <paramref name="min"/> до <paramref name="max"/>.
    /// </exception>
    public static void AssertOnRange(double value, double min, double max, string propertyName)
    {
        if (value < min || value > max)
        {
            throw new ArgumentException($"{propertyName} должен быть в диапазоне от {min} до {max}.");
        }
    }
    
    /// <summary>
    /// Проверяет, что переданный объект не равен null.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="propertyName">Проверяемый объект.</param>
    /// <exception cref="ArgumentNullException">Имя свойства, из сеттера которого вызывается проверка (используется в тексте ошибки).</exception>
    public static void AssertValueNotNull(object value, string propertyName)
    {
        if (value == null)
        {
            throw new ArgumentNullException(propertyName, $"{propertyName} не может быть null.");
        }
    }
}