using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace GestionFournisseur.Models
{
    public class Order
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
