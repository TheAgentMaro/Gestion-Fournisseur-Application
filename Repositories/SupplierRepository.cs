using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GestionFournisseur.Data;
using GestionFournisseur.Models;
using GestionFournisseur.Repositories.Interfaces;

namespace GestionFournisseur.Repositories
{
    public class SupplierRepository : IRepository
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
            try
            {
                _context.Suppliers.Add(supplier);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while adding supplier", ex);
            }
        }
        public void UpdateSupplier(Supplier supplier)
        {
            try
            {
                _context.Suppliers.Update(supplier);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void DeleteSupplier(Supplier supplier)
        {
            try
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
