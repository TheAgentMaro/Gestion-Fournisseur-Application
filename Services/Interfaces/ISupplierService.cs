using GestionFournisseur.Models;

namespace GestionFournisseur.Services.Interfaces
{
    public interface ISupplierService
    {
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
    }
}
