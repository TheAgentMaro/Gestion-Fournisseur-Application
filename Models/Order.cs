using static System.Net.Mime.MediaTypeNames;

namespace GestionFournisseur.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set;}

    }
}
