using System.Collections.Generic;

namespace RealEstateAgency.Domain;

public class Client
{
    public int Client_id { get; private set; }
    public string Full_name { get; private set; }
    public string Passport { get; private set; }
    public string Phone_number { get; private set; }
    public string Address { get; private set; }
    public List<Order> Orders { get; set; } = new List<Order>();

    public Client(int client_id, string full_name, string passport, string phoone_number, string address)
    {
        Client_id = client_id;
        Full_name = full_name;
        Passport = passport;
        Phone_number = phoone_number;
        Address = address;
    }
}