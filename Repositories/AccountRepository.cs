using GestionFournisseur.Data;

namespace GestionFournisseur.Repositories
{
    public class AccountRepository
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
