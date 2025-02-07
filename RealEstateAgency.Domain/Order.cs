namespace RealEstateAgency.Domain;

public enum TypeOrder
{
    Purchase,
    Sale
}

/// <summary>
/// Заявка клиента
/// </summary>
public class Order
{
    /// <summary>
    /// Идентификатор заявки
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Клиент, сделавший заявку
    /// </summary>
    public required Client Client { get; set; }

    /// <summary>
    /// Время заявки
    /// </summary>
    public required DateTime Time { get; set; }

    /// <summary>
    /// Тип заявки (покупка или продажа)
    /// </summary>
    public required TypeOrder Type { get; set; }

    /// <summary>
    /// Объект недвижимости
    /// </summary>
    public required RealEstate Item { get; set; }

    /// <summary>
    /// Цена недвижимости
    /// </summary>
    public required decimal Price { get; set; }
}