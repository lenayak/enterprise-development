using RealEstateAgency.Domain;
namespace RealEstateAgency.Tests;

public class RealEstateAgencyTests
{
    /// <summary>
    /// Вывести сведения о всех клиентах, ищущих недвижимость заданного типа, упорядочить по ФИО.
    /// </summary>
    [Fact]
    public void GetClientsByRealEstateType()
    {
        var realEstateType = RealEstateType.NonResidental;
        var clients = RealEstateAgencyData.Clients
            .Where(c => RealEstateAgencyData.Orders.Any(o => o.Client == c && o.Type == TypeOrder.Purchase && o.Item.Type == realEstateType))
            .OrderBy(c => c.FullName)
            .ToList();

        Assert.NotEmpty(clients);
        Assert.Equal("Petrov Petr Petrovich", clients[0].FullName);
    }

    /// <summary>
    /// Вывести всех продавцов, оставивших заявки за заданный период
    /// </summary>
    [Fact]
    public void GetSellersByPeriod()
    {
        var start = new DateTime(2024, 1, 1);
        var end = new DateTime(2024, 12, 31);

        var sellers = RealEstateAgencyData.Clients
            .Where(c => RealEstateAgencyData.Orders.Any(o => o.Client == c && o.Type == TypeOrder.Sale && o.Time >= start && o.Time <= end))
            .ToList();

        Assert.NotEmpty(sellers);
        Assert.Contains(sellers, s => s.FullName == "Ivanov Ivan Ivanovich");
        Assert.Contains(sellers, s => s.FullName == "Alekseev Aleksey Alekseevich");
        Assert.Contains(sellers, s => s.FullName == "Sergeev Sergey Sergeevich");
        Assert.Contains(sellers, s => s.FullName == "Petrov Petr Petrovich");
        Assert.Contains(sellers, s => s.FullName == "Vasilev Vasily Vasilevich");
    }

    /// <summary>
    /// Вывести сведения о продавцах и объектах недвижимости, соответствующих определенной заявке покупателя
    /// </summary>
    [Fact]
    public void GetSellersAndRealEstatesForBuyerRequest()
    {
        var realEstateType = RealEstateType.NonResidental;
        var maxPrice = 1000;

        var sellers = RealEstateAgencyData.Clients
            .Join(
                RealEstateAgencyData.Orders.Where(o => o.Type == TypeOrder.Sale
                                        && o.Item.Type == realEstateType
                                        && o.Price <= maxPrice),
                seller => seller.Id,
                saleOrder => saleOrder.Client.Id,
                (seller, saleOrder) => new
                {
                    Seller = seller,
                    Property = saleOrder.Item
                })
            .ToList();

        Assert.NotEmpty(sellers);
        Assert.Equal("Sergeev Sergey Sergeevich", sellers[0].Seller.FullName);
    }

    /// <summary>
    /// Вывести информацию о количестве заявок по каждому типу недвижимости
    /// </summary>
    [Fact]
    public void GetOrderCountByRealEstateType()
    {
        var orderCountByType = RealEstateAgencyData.Orders
            .GroupBy(o => o.Item.Type)
            .Select(g => new
            {
                RealEstateType = g.Key,
                OrderCount = g.Count()
            })
            .ToList();

        var residentialCount = orderCountByType.FirstOrDefault(t => t.RealEstateType == RealEstateType.Residental);
        var nonresidentalCount = orderCountByType.FirstOrDefault(t => t.RealEstateType == RealEstateType.NonResidental);

        Assert.NotNull(residentialCount);
        Assert.NotNull(nonresidentalCount);

        Assert.Equal(5, residentialCount.OrderCount);
        Assert.Equal(5, nonresidentalCount.OrderCount);
    }

    /// <summary>
    /// Вывести топ 5 клиентов по количеству заявок (отдельно на покупку и продажу)
    /// </summary>
    [Fact]
    public void GetTop5ClientsByOrderCount()
    {
        var purchaseOrders = RealEstateAgencyData.Clients
            .OrderByDescending(c => RealEstateAgencyData.Orders.Count(o => o.Client == c && o.Type == TypeOrder.Purchase))
            .Take(5)
            .ToList();

        var saleOrders = RealEstateAgencyData.Clients
            .OrderByDescending(c => RealEstateAgencyData.Orders.Count(o => o.Client == c && o.Type == TypeOrder.Sale))
            .Take(5)
            .ToList();

        Assert.NotEmpty(purchaseOrders);
        Assert.Contains(purchaseOrders, p => p.FullName == "Petrov Petr Petrovich");

        Assert.NotEmpty(saleOrders);
        Assert.Contains(saleOrders, s => s.FullName == "Petrov Petr Petrovich");
    }

    /// <summary>
    /// Вывести информацию о клиентах, открывших заявки с минимальной стоимостью
    /// </summary>
    [Fact]
    public void GetClientsWithMinOrderPrice()
    {
        var minPrice = RealEstateAgencyData.Orders.Min(o => o.Price);

        var clientsWithMinPrice = RealEstateAgencyData.Clients
            .Where(c => RealEstateAgencyData.Orders.Any(o => o.Client == c && o.Price == minPrice))
            .ToList();

        Assert.NotEmpty(clientsWithMinPrice);
        Assert.Equal(100, minPrice);
        Assert.Contains(clientsWithMinPrice, c => c.FullName == "Ivanov Ivan Ivanovich");
    }
}
