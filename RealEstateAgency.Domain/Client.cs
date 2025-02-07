namespace RealEstateAgency.Domain;

/// <summary>
/// ������ �������
/// </summary>
public class Client
{
	/// <summary>
	/// ������������� �������
	/// </summary>
	public required int Id { get; set; }

	/// <summary>
	/// ��� 
	/// </summary>
	public required string FullName { get; set; }

	/// <summary>
	/// �������
	/// </summary>
	public required string Passport { get; set; }

	/// <summary>
	/// ���������� �������
	/// </summary>
	public required string PhoneNumber { get; set; }

	/// <summary>
	/// �����
	/// </summary>
	public required string Address { get; set; }
}