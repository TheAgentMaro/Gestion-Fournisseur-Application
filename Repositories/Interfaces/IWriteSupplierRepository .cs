using GestionFournisseur.Models;

namespace GestionFournisseur.Repositories.Interfaces
{
    public interface IWriteSupplierRepository
    {
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(Supplier supplier);
    }
}
