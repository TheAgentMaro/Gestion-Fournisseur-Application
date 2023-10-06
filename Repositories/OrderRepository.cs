using GestionFournisseur.Data;
using GestionFournisseur.Repositories.Interfaces;

namespace GestionFournisseur.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public OrderRepository() { }
        public void AddOrder(string name, string supplier, int quantity, string status, string date, string image)
        {
        }
        public void UpdateOrder(int id, string name, string supplier, int quantity, string status, string date,
                       string image)
        {
        }
        public void DeleteOrder(int id)
        {
        }
    }
}
