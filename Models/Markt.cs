using System.ComponentModel.DataAnnotations;

namespace Marktkaart.Models 
{
    public class Markt
    {
        [Key]
        public string Guid { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public string Adres { get; set; }
        public string Plaats { get; set; }
        public string Gemeente { get; set; }
        public double X { get; set; }
        public double Y { get; set; }


    }
}