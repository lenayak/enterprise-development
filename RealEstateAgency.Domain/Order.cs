namespace RealEstateAgency.Domain;

public enum TypeOrder
{
    Purchase,
    Sale
}

/// <summary>
/// ������ �������
/// </summary>
public class Order
{
    /// <summary>
    /// ������������� ������
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// ������, ��������� ������
    /// </summary>
    public required Client Client { get; set; }

    /// <summary>
    /// ����� ������
    /// </summary>
    public required DateTime Time { get; set; }

    /// <summary>
    /// ��� ������ (������� ��� �������)
    /// </summary>
    public required TypeOrder Type { get; set; }

    /// <summary>
    /// ������ ������������
    /// </summary>
    public required RealEstate Item { get; set; }

    /// <summary>
    /// ���� ������������
    /// </summary>
    public required decimal Price { get; set; }
}