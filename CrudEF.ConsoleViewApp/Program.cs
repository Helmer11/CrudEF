using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrudEF.Entities;
using CrudEF.BusinessLogic.CustomerBusinessLogic;
namespace CrudEF.ConsoleViewApp
{
    /* In this program we create a basic crud 
     * using  EntityFramework 6 in N-Tier.
     * 
     * You can run the program and
     * see all region c# that I do to divide each part
     * of the crud.
     * */
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Create 
            //var customer1 = new Customer() {
            //    FirstName = "Jorge Luis",
            //    LastName ="Guzman S.",
            //    Email = "JLGSHK@hotmail.com",
            //    Birthday = new DateTime(1986,09,15)
            //};
            //var customer2 = new Customer()
            //{
            //    FirstName = "Jean Carlos",
            //    LastName = "Guzman SV.",
            //    Birthday = new DateTime(2013, 10,31)
            //};
            //Console.WriteLine("Insert into database....");
            //CustomerBL.GetInstance().AddCustomer(customer1);
            //CustomerBL.GetInstance().AddCustomer(customer2);
            #endregion
            #region Update
            //var currentCustomer = CustomerBL.GetInstance().GetCustomerByID(1);
            //currentCustomer.Email = "jorge.guzman@isfodosu.edu.do";
            //Console.WriteLine("Update a Customer");
            //CustomerBL.GetInstance().UpdateCustomer(currentCustomer);
            //var currentCustomer2 = CustomerBL.GetInstance().GetCustomerByID(2);
            //currentCustomer2.LastName = "Guzman V."; 
            //Console.WriteLine("Update a Customer");
            //CustomerBL.GetInstance().UpdateCustomer(currentCustomer2);
            #endregion
            #region Delete
            //var currentCustomerDelete = CustomerBL.GetInstance().GetCustomerByID(3);
            
            //Console.WriteLine("Delete a Customer");
            //CustomerBL.GetInstance().DeleteCustomer(currentCustomerDelete.CustomerID);

            //var currentCustomerDelete2 = CustomerBL.GetInstance().GetCustomerByID(4);

            //Console.WriteLine("Delete a Customer");
            //CustomerBL.GetInstance().DeleteCustomer(currentCustomerDelete2.CustomerID);
            #endregion
            #region Read
            //List<Customer> listOfCustomers = CustomerBL.GetInstance().GetAllCustomers();
            //foreach (var customer in listOfCustomers) {
            //    Console.WriteLine(customer.FirstName + customer.LastName);
            //}
            #endregion
            
            
            Console.WriteLine("All ok!!");
            Console.ReadKey();
        }
    }
}
