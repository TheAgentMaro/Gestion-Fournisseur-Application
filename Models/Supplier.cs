using System.ComponentModel.DataAnnotations;


namespace GestionFournisseur.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Supplier Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Supplier Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Adress.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Supplier Phone is required")]
        [Phone(ErrorMessage = "Invalid Phone Number.")]
        public string PhoneNumber { get; set; }

        public string ProductServices { get; set; }

        // Additional properties for supplier evaluation, performance, etc.

        // You can also define relationships with other entities if needed, using navigation properties.

        // Example of a one-to-many relationship with another entity:
        // public ICollection<Order> Orders { get; set; }
    }
}
