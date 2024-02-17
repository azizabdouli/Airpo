// See https://aka.ms/new-console-template for more information


using AM.ApplicationCore.Domain;

Plane p = new Plane();
p.Capacity = 100;
Console.WriteLine(p.Capacity);
p.ManufactureDate = DateTime.Now;
p.PlaneType = PlaneType.Boeing;
Passenger p1 = new Passenger() {FirstName="Aziz",LastName="Abdouli",EmailAdress="aziz.abdouli@esprit.tn"};
Traveller t1 = new Traveller();
Staff s1 = new Staff();
p1.PassengerType();
t1.PassengerType();
s1.PassengerType();






