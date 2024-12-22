using System;

namespace RealEstateAgency.Domain;

public record class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TypeOrder Type { get; set }
    public decimal Price { get; set; }
    public enum TypeOrder
    {
        Purchase,
        Sale
    }

    public Order(int id, DateTime date, TypeOrder type, decimal price)
    {
        Id = id;
        Date = date;
        Type = type;
        Price = price;
    }
}