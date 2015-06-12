using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrudEF.Entities;

namespace CrudEF.Data.CustomerAccess
{
    public class DAOCustomer
    {
        private static DAOCustomer _DAOCustomer;
              private DAOCustomer() { }
        public static DAOCustomer GetInstance() {
            if (_DAOCustomer == null)
            {
                _DAOCustomer = new DAOCustomer();
            }
            return _DAOCustomer;
        }

        public void AddCustomer(Customer customer) {

            using (var _db = new CRUDEFEntities()) {
                _db.Customers.Add(customer);
                _db.SaveChanges();
            }
        }
        public void UpdateCustomer(Customer customer) {
            using (var _db = new CRUDEFEntities()) {
                var customer_temp = _db.Customers.SingleOrDefault(c => c.CustomerID == customer.CustomerID);
                _db.Entry(customer_temp).CurrentValues.SetValues(customer);
                _db.SaveChanges();
            }
        }
        public void DeleteCustomer(int idCustomer) {
            using (var _db = new CRUDEFEntities()) {
                var currentCustomer = _db.Customers.SingleOrDefault(c => c.CustomerID == idCustomer);
                _db.Entry(currentCustomer).State = System.Data.Entity.EntityState.Deleted;
                _db.SaveChanges();
            }
        }
        public List<Customer> GetAllCustomers() {
            using (var _db = new CRUDEFEntities()) {
                IQueryable<Customer> list = from c in _db.Customers
                                            select c;
                return list.ToList();
            }
        }
        public Customer GetCustomerByID(int idCustomer) {
            using (var _db = new CRUDEFEntities())
            {
                var currentCustomer = from c in _db.Customers
                                            where c.CustomerID.Equals(idCustomer)
                                            select c;
                return currentCustomer.Single();
            }
        }
    }
}
