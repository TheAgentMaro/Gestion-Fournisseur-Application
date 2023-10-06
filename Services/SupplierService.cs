using GestionFournisseur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using GestionFournisseur.Services.Interfaces;

namespace GestionFournisseur.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly List<Supplier> _suppliers;

        public SupplierService()
        {
            // Initialize with some sample data
            _suppliers = new List<Supplier>
            {
                new Supplier { Id = 1, Name = "Supplier 1", Email = "supplier1@example.com" },
                new Supplier { Id = 2, Name = "Supplier 2", Email = "supplier2@example.com" },
                new Supplier { Id = 3, Name = "Supplier 3", Email = "supplier3@example.com" }
            };
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _suppliers;
        }

        public Supplier GetSupplierById(int id)
        {
            return _suppliers.FirstOrDefault(s => s.Id == id);
        }


        public void AddSupplier(Supplier supplier)
        {
            supplier.Id = GenerateNewId();
            _suppliers.Add(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            var existingSupplier = _suppliers.FirstOrDefault(s => s.Id == supplier.Id);
            if (existingSupplier != null)
            {
                existingSupplier.Name = supplier.Name;
                existingSupplier.Email = supplier.Email;
            }
        }

        public void DeleteSupplier(int id)
        {
            var supplier = _suppliers.FirstOrDefault(s => s.Id == id);
            if (supplier != null)
            {
                _suppliers.Remove(supplier);
            }
        }

        private int GenerateNewId()
        {
            // Generate a new unique ID (assuming you have a more robust logic in your actual implementation)
            return _suppliers.Max(s => s.Id) + 1;
        }
    }
}