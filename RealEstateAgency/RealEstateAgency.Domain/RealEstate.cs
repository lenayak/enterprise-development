namespace RealEstateAgency.Domain;

public enum RealEstateType
{
    Residental,
    NonResidental
}

/// <summary>
/// Объект недвижимости
/// </summary>
public class RealEstate
{
    /// <summary>
    /// Идентификатор объекта
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Тип объекта недвижимости (жилое/нежилое)
    /// </summary>
    public required RealEstateType Type { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    public required string Address { get; set; }

    /// <summary>
    /// Площадь
    /// </summary>
    public required double Square { get; set; }

    /// <summary>
    /// Количество комнат
    /// </summary>
    public required int Rooms { get; set; }
}
