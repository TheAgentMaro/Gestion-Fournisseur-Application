using GestionFournisseur.Data;
using GestionFournisseur.Repositories.Interfaces;

namespace GestionFournisseur.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public AccountRepository() { }

        public void Register(string name, string email, string password)
        {

        }

        public void Login(string email, string password)
        {
        }

        public void Logout()
        {
        }
    }
}
