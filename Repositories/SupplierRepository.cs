using System.Collections.Generic;
using System.Linq;
using GestionFournisseur.Models;

namespace GestionFournisseur.Data
{
    public class SupplierRepository
    {
        private readonly ApplicationDbContext _context;

        public SupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetSupplierById(int id)
        {
            return _context.Suppliers.FirstOrDefault(s => s.Id == id);
        }

        public void AddSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
        }

        public void DeleteSupplier(Supplier supplier)
        {
            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
        }
    }
}
