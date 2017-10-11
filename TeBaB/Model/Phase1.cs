using System;

namespace TeBaB.Model
{
    public enum Weekday { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
    public enum Sex { Male, Female }

    public class Court
    {
        public int Id { get; set; }
        public string Name { get; set; }        // Bane 2 Ute
        public string Type { get; set; }        // Hardcourt
        public Club Club { get; set; }
        public int CourtGroup { get; set; }     // Ute, Inne
        public string Location { get; set; }
        public string VisibleFor { get; set; }  // Klubb, Årskort, Member, Non-Member
        public bool Active { get; set; }
        public DateTime Created { get; set; }
    }

    /* 
     * GROUP: Only collection of users
     * 
     * KURS: Navn, antall, pris, Beskrivelse, Gruppering,
     *      Start, slutt, rabatt/per uke, Maks deltakere, 
     *      utmelding: (ikke tillatt, senest 1-14 dager før), 
     *      ansvarlig, synlig for, aktiv
     * Søk på: Navn, Kursgruppe, Ansvarlig
     */

    public class Booking
    {
        public int Id { get; set; }
        public BookingType Type { get; set; }   // Fast(grønn), Medlem(gul), Mesterskap(blå), Annet(rød)
        public User User { get; set; }      
        public Court Court { get; set; }        // Or only the Court Id?
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }       // Minutes
        public string DisplayAs { get; set; }
        public DateTime Created { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public Membership Membership { get; set; }  // Senior+Årskort
        public UserType UserType { get; set; }      // Coach
        public UserGroup Group { get; set; }        // Senior/1800-1930
        public DateTime Birthdate { get; set; }
        public Sex Sex { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Mobile { get; set; }
        public string Contact1 { get; set; }    // Name, Phone, Email 
        public string Contact2 { get; set; }    // Name, Phone, Email 
        public DateTime Created { get; set; }
    }

    public class Membership
    {
        public string Id { get; set; }
        public string MemberNumber { get; set; }
        public string MemberType { get; set; }  // junior, senior, member, non-member, ...
        public Product Product { get; set; }    // Årskort
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }
        public bool Active { get; set; }
    }

    public class UserGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }    // Barn 8-10 år
        public DateTime Created { get; set; }
    }

    // membership, ballmachine, personal-trainer, 
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public DateTime Created { get; set; }
    }


}
