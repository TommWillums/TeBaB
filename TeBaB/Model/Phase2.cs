using System;

namespace TeBaB.Model
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int Courts { get; set; }
        public string SubscriptionType { get; set; }
        public bool AutomaticRenewal { get; set; }
        public DateTime NextRenewalDate { get; set; }
        public string Price { get; set; }
        public DateTime Created { get; set; }
    }

    public class ClubPayment
    {
        public int Id { get; set; }
        public Club Club { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
    }

    public class OpeningHours
    {
        // TODO:
    }

    // Consider Court prices as well:
    // Bane 1, Fredag, Årskort, Tid1, Beløp
    // Bane 2, Lørdag, Non-member, Tid2, Beløp
    public class Price
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public UserType UserType { get; set; }
        public DateTime Created { get; set; }
    }

    public class UserPayment
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
        public DateTime Created { get; set; }
    }


}
