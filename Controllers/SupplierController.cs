using GestionFournisseur.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GestionFournisseur.Controllers
{
    public class SupplierController : Controller
    {
        private List<Supplier> _suppliers; // Assuming you have a list of suppliers

        public SupplierController()
        {
            // Initialize the suppliers list (you can replace this with your actual data source)
            _suppliers = new List<Supplier>
            {
                new Supplier { Id = 1, Name = "Mohamed Marwen Meddeb", Email = "marwen.meddeb@outlook.fr", PhoneNumber = "1234567890" },
                new Supplier { Id = 2, Name = "Fernardo Vichy", Email = "fernardo.vic@gmail.com", PhoneNumber = "9876543210" },
                new Supplier { Id = 3, Name = "John Wick", Email = "john.wick@gmail.com", PhoneNumber = "9876543210" },
            };
        }

        public IActionResult Index()
        {
            // Get all suppliers and pass them to the view
            return View(_suppliers);
        }

        // Action for Create view
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                // Generate a new ID for the supplier (you can replace this with your own logic)
                supplier.Id = _suppliers.Max(s => s.Id) + 1;

                // Add the supplier to the list
                _suppliers.Add(supplier);

                // Redirect to the supplier list page
                return RedirectToAction("Index");
            }

            return View(supplier);
        }

        // Action for Edit view
        public IActionResult Edit(int id)
        {
            // Find the supplier with the given ID
            var supplier = _suppliers.FirstOrDefault(s => s.Id == id);

            if (supplier == null)
            {
                // Return a 404 Not Found page or handle the error as needed
                return NotFound();
            }

            return View(supplier);
        }

        [HttpPost]
        public IActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                // Find the index of the existing supplier in the list
                var index = _suppliers.FindIndex(s => s.Id == supplier.Id);

                if (index == -1)
                {
                    // Return a 404 Not Found page or handle the error as needed
                    return NotFound();
                }

                // Update the supplier in the list
                _suppliers[index] = supplier;

                // Redirect to the supplier list page
                return RedirectToAction("Index");
            }

            return View(supplier);
        }

        // Action for Details view
        public IActionResult Details(int id)
        {
            // Find the supplier with the given ID
            var supplier = _suppliers.FirstOrDefault(s => s.Id == id);

            if (supplier == null)
            {
                // Return a 404 Not Found page or handle the error as needed
                return NotFound();
            }

            return View(supplier);
        }

        // Action for Delete view
        public IActionResult Delete(int id)
        {
            // Find the supplier with the given ID
            var supplier = _suppliers.FirstOrDefault(s => s.Id == id);

            if (supplier == null)
            {
                // Return a 404 Not Found page or handle the error as needed
                return NotFound();
            }

            return View(supplier);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            // Find the supplier with the given ID
            var supplier = _suppliers.FirstOrDefault(s => s.Id == id);

            if (supplier == null)
            {
                // Return a 404 Not Found page or handle the error as needed
                return NotFound();
            }

            // Remove the supplier from the list
            _suppliers.Remove(supplier);

            // Redirect to the supplier list page
            return RedirectToAction("Index");
        }
    }
}
