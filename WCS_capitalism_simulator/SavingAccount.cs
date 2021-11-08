using System;
namespace WCS_capitalism_simulator
{
    public class SavingAccount : ISavingCalculator
    {
        public Guid SavingAccountId { get; set; }
        public double Amount { get; set; }
        public int InterestRate { get; set; }

        public double GetInterests()
        {
            // Montant initial du capital * ( (1 + Taux d’intérêt annuel / Nombre de périodes)
            // ^ (Nombre de périodes * Temps de valorisation) – 1)
            return Amount * InterestRate / 100;
        }
    }
}
