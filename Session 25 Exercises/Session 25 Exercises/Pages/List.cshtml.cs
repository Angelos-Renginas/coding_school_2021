using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Session_25_Exercises.Services;
using Session25.Model;

namespace Session_25_Exercises.Pages
{
    public class ListModel : PageModel
    {
        public List<Customer> Customers = new List<Customer>();

        private ICustomerStorage _storage { get; set; }

        public ListModel(ICustomerStorage storage) {
            _storage = storage;
        }

        public void OnGet() {
            Customers = _storage.GetAllItems();
        }
    }
}
