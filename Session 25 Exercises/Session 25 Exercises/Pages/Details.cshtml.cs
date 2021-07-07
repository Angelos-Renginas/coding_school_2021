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
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Customer SelectedCustomer { get; set; }

        private ICustomerStorage _storage { get; set; }

        public DetailsModel(ICustomerStorage storage) {
            _storage = storage;
        }

        public void OnGet(int id)
        {
            if (id == 0) {
                SelectedCustomer = new Customer();
                return;
            }

            SelectedCustomer = _storage.GetById(id);
        }

        public IActionResult OnPost() {
            _storage.AddItem(SelectedCustomer);

            return RedirectToPage("List");
        }

        public IActionResult OnPostCancel() {
            return RedirectToPage("List");
        }

        public IActionResult OnPostDelete() {
            _storage.RemoveItem(SelectedCustomer.ID);
            return RedirectToPage("List");
        }

    }
}
