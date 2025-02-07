namespace RealEstateAgency.Domain;

public enum RealEstateType
{
	Residental,
	NonResidental
}

/// <summary>
/// ������ ������������
/// </summary>
public class RealEstate
{
	/// <summary>
	/// ������������� �������
	/// </summary>
	public required int Id { get; set; }

	/// <summary>
	/// ��� ������� ������������ (�����/�������)
	/// </summary>
	public required RealEstateType Type { get; set; }

	/// <summary>
	/// �����
	/// </summary>
	public required string Address { get; set; }

	/// <summary>
	/// �������
	/// </summary>
	public required double Square { get; set; }

	/// <summary>
	/// ���������� ������
	/// </summary>
	public required int Rooms { get; set; }
}
