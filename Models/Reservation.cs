using System.Collections.Generic;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuests(List<Person> guests)
        {
            // Verifica se a capacidade da suíte é maior ou igual ao número de hóspedes
            if (Suite.Capacity >= guests.Count)
            {
                Guests = guests;
            }
            else
            {
                // Lança uma exceção se a capacidade for menor que o número de hóspedes
                throw new Exception("The number of guests exceeds the suite's capacity.");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestsCount()
        {
            // Retorna a quantidade de hóspedes
            return Guests.Count;
        }

        public decimal CalculateDailyRate()
        {
            // Calcula o valor da diária: DiasReservados X Suite.ValorDiaria
            decimal totalValue = ReservedDays * Suite.DailyRate;

            // Aplica um desconto de 10% se a reserva for de 10 dias ou mais
            if (ReservedDays >= 10)
            {
                totalValue *= 0.90M; // 10% de desconto
            }

            return totalValue;
        }
    }
}