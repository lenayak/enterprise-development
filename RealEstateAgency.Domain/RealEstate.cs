namespace RealEstateAgency.Domain;

public class RealEstate
{
    public RealEstateType Type { get; set; }
    public string Address { get; set; }
    public double Square { get; set; }
    public int Rooms { get; set; }
    public enum RealEstateType
    {
        Residential,
        NonResidential
    }
    public RealEstate(RealEstateType type, string address, double square, int rooms)
    {
        Type = type;
        Address = address;
        Square = square;
        Rooms = rooms;
    }
}