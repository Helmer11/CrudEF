using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrudEF.Entities;
using CrudEF.Data.CustomerAccess;

namespace CrudEF.BusinessLogic.CustomerBusinessLogic
{
    public class CustomerBL
    {
        private static CustomerBL _CustomerBL;
        private CustomerBL() { }
        public static CustomerBL GetInstance() {
            if (_CustomerBL == null) {
                _CustomerBL = new CustomerBL();
            }
            return _CustomerBL;
        }

        public void AddCustomer(Customer customer)
        {
            DAOCustomer.GetInstance().AddCustomer(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            DAOCustomer.GetInstance().UpdateCustomer(customer);
        }
        public void DeleteCustomer(int idCustomer)
        {
            DAOCustomer.GetInstance().DeleteCustomer(idCustomer);
        }
        public List<Customer> GetAllCustomers()
        {
            return DAOCustomer.GetInstance().GetAllCustomers();
        }
        public Customer GetCustomerByID(int idCustomer)
        {
            return DAOCustomer.GetInstance().GetCustomerByID(idCustomer);
        }
    }
}
