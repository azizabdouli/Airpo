// See https://aka.ms/new-console-template for more information


using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Plane p = new Plane { Capacity=100,ManufactureDate=DateTime.Now,PlaneType=PlaneType.Boeing};

Console.WriteLine(p);

//Tester checkProfile
Passenger p1 = new Passenger() {FirstName="Aziz",LastName="Abdouli",EmailAdress="aziz.abdouli@esprit.tn"};

Console.WriteLine(  p1.CheckProfile("Aziz","Abdouli","AAAA"));
//testrer Passenger Type
Traveller t1 = new Traveller();
Staff s1 = new Staff();
p1.PassengerType();
t1.PassengerType();
s1.PassengerType();
Console.WriteLine(  "********************GetFlightDates*************");
FlightMethods fm = new FlightMethods();
fm.Flights = TestData.listFlights;
fm.GetFlightDates("Madrid");
Console.WriteLine( "************GetFlights**************");
fm.GetFlights("Destination", "Paris");









