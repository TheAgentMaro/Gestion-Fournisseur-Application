namespace GestionFournisseur.Repositories.Interfaces
{
    public interface IRepository : IWriteProductRepository, IReadProductRepository, IAccountRepository,
    IReadSupplierRepository, IWriteSupplierRepository, IOrderRepository
    {
    }
}
