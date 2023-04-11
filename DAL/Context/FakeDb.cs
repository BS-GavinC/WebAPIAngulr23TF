namespace WebAPIAngulr23TF.Models
{
    public static class FakeDb
    {
        public static List<Voiture> Voitures = new List<Voiture>
        {
            new Voiture("BMW", "Serie 1", "1-ERT345", 120, "Black"),
            new Voiture("Citroen", "C1", "1-46234EV", 12, "White"),
            new Voiture("Renault", "Kangoo", "1-DSGVS453", 70, "Blue")
        };
    }
}
