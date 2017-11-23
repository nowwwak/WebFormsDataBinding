using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormsDataBinding.Data;

namespace WebFormsDataBinding.Biz
{
    public class BAL
    {
        public List<string> GetCountries()
        {
            using (NORTHWNDEntities context = new NORTHWNDEntities())
            {
                return context.Customers.Select(c => c.Country).Distinct().ToList();
            }  
        }

        public List<Customer> GetCustomersByCountry(string country)
        {
            using (NORTHWNDEntities context = new NORTHWNDEntities())
            {
                return context.Customers.Where(c => c.Country == country).ToList();
            }
        }

        public Customer GetCustomer(string custID)
        {
            using (NORTHWNDEntities context = new NORTHWNDEntities())
            {
                return context.Customers.FirstOrDefault(c => c.CustomerID == custID);
            }
        }

        public void Update(Customer customer)
        {
            using (NORTHWNDEntities context = new NORTHWNDEntities())
            {
                context.Customers.Attach(customer);
                context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}