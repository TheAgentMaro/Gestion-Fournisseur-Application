using System.ComponentModel.DataAnnotations;

namespace GestionFournisseur.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set;}
    }
}
