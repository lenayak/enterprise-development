namespace RealEstateAgency.Domain;

/// <summary>
/// Данные клиента
/// </summary>
public class Client
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// ФИО 
    /// </summary>
    public required string FullName { get; set; }

    /// <summary>
    /// Паспорт
    /// </summary>
    public required string Passport { get; set; }

    /// <summary>
    /// Контактный телефон
    /// </summary>
    public required string PhoneNumber { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    public required string Address { get; set; }
}