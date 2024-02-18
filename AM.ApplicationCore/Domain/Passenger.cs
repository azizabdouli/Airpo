using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }
        public override string ToString()
        {
            return $"Passport Number: {PassportNumber}, First Name: {FirstName}, " +
                   $"Last Name: {LastName}, Birth Date: {BirthDate}, " +
                   $"Email Address: {EmailAdress}, Phone Number: {PhoneNumber}";
        }
        public Boolean CheckProfile(string prenom, string nom, string email = null)
        {
            if (email != null)
                return (prenom == FirstName && nom == LastName && email == EmailAdress);
            else
                return (prenom == FirstName && nom == LastName);

        }
        


    }
}
