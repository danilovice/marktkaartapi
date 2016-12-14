namespace Marktkaart.Models {

public class Markt
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public string Adres { get; set; }
        public string Plaats { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}