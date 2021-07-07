using Session25.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session_25_Exercises.Services {


    public class CustomerStorage : ICustomerStorage {

        private List<Customer> innerList { get; set; }

        public CustomerStorage() {
            innerList = new List<Customer>();
        }
        public void AddItem(Customer customer) {
            if (customer.ID == 0) {
                customer.ID = innerList.Count + 1;
                innerList.Add(customer);
                return;
            }

            var selectedItem = GetById(customer.ID);
            selectedItem.Name = customer.Name;
            selectedItem.Surname = customer.Surname;
            selectedItem.AFM = customer.AFM;
            selectedItem.Active = customer.Active;
        }

        public List<Customer> GetAllItems() {
            return innerList;
        }

        public Customer GetById(int id) {
            return innerList.FirstOrDefault(item => item.ID == id);
        }

        public void RemoveItem(int id) {
            var selectedItem = GetById(id);
            if (selectedItem == null)
                throw new Exception(string.Format("Customer with id '{0}' was not found.", id));

            innerList.Remove(selectedItem);
        }
    }
}
