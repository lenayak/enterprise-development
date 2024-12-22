using RealEstateAgency.Domain;
using System.Collections.Generic;
using System;

namespace RealEstateAgency.Tests;

public static class TestData
{
	public static List<Client> Clients { get; private set; }
	public static List<Order> Orders { get; private set; }
	public static List<RealEstate> RealEstates { get; private set; }

	static TestData()
	{
		RealEstates =

		[
			new RealEstate
			{
				Type = RealEstate.PropertyType.Residential,
				Address = "gorod Podolsk, ul. Gagarina, 08",
				Square = 180.0,
				Rooms = 4
			},
			new RealEstate
			{
				Type = RealEstate.PropertyType.Uninhabitable,
				Address = "gorod Pavlovskii Posad, spusk Domodedovskaia, 56",
				Square = 200.0,
				Rooms = 5
			},
			new RealEstate
			{
				Type = RealEstate.PropertyType.Residential,
				Address = "gorod Serebrianye Prudy, ul. 1905 goda, 13",
				Square = 150.0,
				Rooms = 4
			},
			new RealEstate
			{
				Type = RealEstate.PropertyType.Residential,
				Address = "gorod Serpuhov, ul. Balkanskaia, 59",
				Square = 110.0,
				Rooms = 3
			},
			new RealEstate
			{
				Type = RealEstate.PropertyType.Residential,
				Address = "gorod Dmitrov, spusk Ladygina, 37",
				Square = 120.0,
				Rooms = 3
			},
			new RealEstate
			{
				Type = RealEstate.PropertyType.Residential,
				Address = "gorod Pushkino, vezd Gogolia, 28",
				Square = 100.0,
				Rooms = 2
			}
		];

		Clients =

		[
			new Client
			{
				ClientId = 1,
				FirstAndLastName = "Petrova Anna",
				Pasport = "1234 567890",
				NumberPhone = "+7 123 456 7890",
				Address = " gorod Lyubercy, shosse Kosmonavtov, 75",
			},
			new Client
			{
				ClientId = 2,
				FirstAndLastName = "Ivanov Ivan",
				Pasport = "4321 987654",
				NumberPhone = "+7 987 654 3210",
				Address = "gorod grust', prospekt razocharovanie, dom 13",
			},
			new Client
			{
				ClientId = 3,
				FirstAndLastName = "Ivolgov Alex",
				Pasport = "3456 789012",
				NumberPhone = "+7 654 321 0987",
				Address = "gorod Balashiha, spusk Buharestskaya, 26",
			},
			new Client
			{
				ClientId = 4,
				FirstAndLastName = "Sidorov Petr",
				Pasport = "6789 012345",
				NumberPhone = "+7 321 654 7890",
				Address = " gorod Orekhovo-Zuevo, v'ezd Stalina, 76",
			}
		];

		Orders =

		[
			new Order
			{
				Id = 1,
				Time = DateTime.Now.AddMonths(-2),
				Type = Order.PurchaseOrSale.Purchase,
				Price = 950000,
				Item = RealEstates[0],
				Client = Clients[0]
			},
			new Order
			{
				Id = 2,
				Time = DateTime.Now.AddMonths(-1),
				Type = Order.PurchaseOrSale.Sale,
				Price = 1200000,
				Item = RealEstates[1],
				Client = Clients[0]
			},
			new Order
			{
				Id = 3,
				Time = DateTime.Now.AddMonths(-4),
				Type = Order.PurchaseOrSale.Sale,
				Price = 950000,
				Item = RealEstates[2],
				Client = Clients[1]
			},
			new Order
			{
				Id = 4,
				Time = DateTime.Now.AddMonths(-3),
				Type = Order.PurchaseOrSale.Purchase,
				Price = 500000,
				Item = RealEstates[3],
				Client = Clients[2]
			},
			new Order
			{
				Id = 5,
				Time = DateTime.Now.AddMonths(-5),
				Type = Order.PurchaseOrSale.Sale,
				Price = 700000,
				Item = RealEstates[4],
				Client = Clients[3]
			},
			new Order
			{
				Id = 6,
				Time = DateTime.Now.AddMonths(-2),
				Type = Order.PurchaseOrSale.Purchase,
				Price = 850000,
				Item = RealEstates[5],
				Client = Clients[3]
			}
		];
	}
}