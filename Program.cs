using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Creates guest models and registers them in the guest list
List<Person> guests = new List<Person>();

Person p1 = new Person(firstName: "Guest 1");
Person p2 = new Person(firstName: "Guest 2");

guests.Add(p1);
guests.Add(p2);

// Creates the suite
Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyRate: 30);

// Creates a new reservation, passing the suite and guests
Reservation reservation = new Reservation(reservedDays: 10);
reservation.RegisterSuite(suite);
reservation.RegisterGuests(guests);

// Displays the number of guests and the daily rate
Console.WriteLine($"Guests: {reservation.GetGuestsCount()}");
Console.WriteLine($"Daily Rate: {reservation.CalculateDailyRate()}");