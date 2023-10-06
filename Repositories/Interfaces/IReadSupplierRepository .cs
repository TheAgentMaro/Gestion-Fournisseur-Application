using GestionFournisseur.Models;

namespace GestionFournisseur.Repositories.Interfaces
{
    public interface IReadSupplierRepository
    {
        IEnumerable<Supplier> GetAllSuppliers();
        Supplier GetSupplierById(int id);
    }
}
