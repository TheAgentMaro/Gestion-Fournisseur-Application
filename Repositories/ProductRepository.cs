using GestionFournisseur.Data;

namespace GestionFournisseur.Repositories
{
    public class ProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public ProductRepository() { }

        public void AddProduct(string name, string supplier, int quantity, string status, string date, string image)
        {
        }

        public void UpdateProduct(int id, string name, string supplier, int quantity, string status, string date,
            string image)
        {
        }

        public void DeleteProduct(int id)
        {
        }
    }
}
