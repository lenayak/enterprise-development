using RealEstateAgency.Domain;
namespace RealEstateAgency.Tests;

public class RealEstateAgencyData
{
	public static List<Client> Clients { get; private set; }
	public static List<Order> Orders { get; private set; }
	public static List<RealEstate> RealEstates { get; private set; }

	public RealEstateAgencyData()
	{
		Clients =
		[
			new Client
			{
				Id = 1,
				FullName = "Ivanov Ivan Ivanovich",
				Passport = "1111 111111",
				PhoneNumber = "+7 111 111 11111",
				Address = "st. Tverskaya, 1, Moscow"
			},
			new Client
			{
				Id = 2,
				FullName = "Alekseev Aleksey Alekseevich",
				Passport = "2222 222222",
				PhoneNumber = "+7 222 222 2222",
				Address = "st. Tverskaya, 2, Moscow"
			},
			new Client
			{
				Id = 3,
				FullName = "Sergeev Sergey Sergeevich",
				Passport = "3333 333333",
				PhoneNumber = "+7 333 333 3333",
				Address = "st. Tverskaya, 3, Moscow"
			},
			new Client
			{
				Id = 4,
				FullName = "Petrov Petr Petrovich",
				Passport = "4444 444444",
				PhoneNumber = "+7 444 444 4444",
				Address = "st. Tverskaya, 4, Moscow"
			},
			new Client
			{
				Id = 5,
				FullName = "Vasilev Vasily Vasilevich",
				Passport = "5555 555555",
				PhoneNumber = "+7 555 555 5555",
				Address = "st. Tverskaya, 5, Moscow"
			}
		];

		RealEstates =
		[
			new RealEstate
			{
				Id = 1,
				Type = RealEstateType.Residental,
				Address = "st. Arbat, 1, Moscow",
				Square = 10.0,
				Rooms = 1
			},
			new RealEstate
			{
				Id = 2,
				Type = RealEstateType.Residental,
				Address = "st. Arbat, 2, Moscow",
				Square = 20.0,
				Rooms = 2
			},
			new RealEstate
			{
				Id = 3,
				Type = RealEstateType.Residental,
				Address = "st. Arbat, 3, Moscow",
				Square = 30.0,
				Rooms = 3
			},
			new RealEstate
			{
				Id = 4,
				Type = RealEstateType.Residental,
				Address = "st. Arbat, 4, Moscow",
				Square = 40.0,
				Rooms = 4
			},
			new RealEstate
			{
				Id = 5,
				Type = RealEstateType.Residental,
				Address = "st. Arbat, 5, Moscow",
				Square = 50.0,
				Rooms = 5
			},
			new RealEstate
			{
				Id = 6,
				Type = RealEstateType.NonResidental,
				Address = "st. Arbat, 6, Moscow",
				Square = 60.0,
				Rooms = 6
			},
			new RealEstate
			{
				Id = 7,
				Type = RealEstateType.NonResidental,
				Address = "st. Arbat, 7, Moscow",
				Square = 70.0,
				Rooms = 7
			},
			new RealEstate
			{
				Id = 8,
				Type = RealEstateType.NonResidental,
				Address = "st. Arbat, 8, Moscow",
				Square = 80.0,
				Rooms = 8
			},
			new RealEstate
			{
				Id = 9,
				Type = RealEstateType.NonResidental,
				Address = "st. Arbat, 9, Moscow",
				Square = 90.0,
				Rooms = 9
			},
			new RealEstate
			{
				Id = 10,
				Type = RealEstateType.NonResidental,
				Address = "st. Arbat, 10, Moscow",
				Square = 100.0,
				Rooms = 10
			},
		];

		Orders =
		[
			new Order
			{
				Id = 1,
				Client = Clients[0],
				Time = DateTime.Now.AddMonths(-1),
				Type = TypeOrder.Purchase,
				Item = RealEstates[0],
				Price = 100
			},
			new Order
			{
				Id = 2,
				Client = Clients[0],
				Time = DateTime.Now.AddMonths(-2),
				Type = TypeOrder.Sale,
				Item = RealEstates[1],
				Price = 200
			},
			new Order
			{
				Id = 3,
				Client = Clients[1],
				Time = DateTime.Now.AddMonths(-3),
				Type = TypeOrder.Purchase,
				Item = RealEstates[2],
				Price = 300
			},
			new Order
			{
				Id = 4,
				Client = Clients[1],
				Time = DateTime.Now.AddMonths(-4),
				Type = TypeOrder.Sale,
				Item = RealEstates[3],
				Price = 400
			},
			new Order
			{
				Id = 5,
				Client = Clients[2],
				Time = DateTime.Now.AddMonths(-3),
				Type = TypeOrder.Purchase,
				Item = RealEstates[4],
				Price = 500
			},
			new Order
			{
				Id = 6,
				Client = Clients[2],
				Time = DateTime.Now.AddMonths(-2),
				Type = TypeOrder.Sale,
				Item = RealEstates[5],
				Price = 600
			},
			new Order
			{
				Id = 7,
				Client = Clients[3],
				Time = DateTime.Now.AddMonths(-1),
				Type = TypeOrder.Purchase,
				Item = RealEstates[6],
				Price = 700
			},
			new Order
			{
				Id = 8,
				Client = Clients[3],
				Time = DateTime.Now.AddMonths(-2),
				Type = TypeOrder.Sale,
				Item = RealEstates[7],
				Price = 800
			},
			new Order
			{
				Id = 9,
				Client = Clients[4],
				Time = DateTime.Now.AddMonths(-3),
				Type = TypeOrder.Purchase,
				Item = RealEstates[8],
				Price = 900
			},
			new Order
			{
				Id = 10,
				Client = Clients[4],
				Time = DateTime.Now.AddMonths(-2),
				Type = TypeOrder.Sale,
				Item = RealEstates[9],
				Price = 1000
			}
		];
	}
}
