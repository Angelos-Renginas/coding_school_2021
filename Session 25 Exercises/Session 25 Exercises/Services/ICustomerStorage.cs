using Session25.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session_25_Exercises.Services {

    public interface ICustomerStorage {
        public void AddItem(Customer customer);
        public void RemoveItem(int id);
        public List<Customer> GetAllItems();
        public Customer GetById(int id);
    }
}
