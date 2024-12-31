using BusinessEntitiesLayer;
using CommonUtilities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationLayer
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;
        public CustomerService()
        {
            _customerRepository =new CustomerRepository();
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                int result = _customerRepository.InsertCustomer(customer);
                return result > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception(ErrorHandler.GetFriendlyMessage(ex));                
            }
        }


        public bool EditCustomer(Customer customer)
        {
            return _customerRepository.EditCustomer(customer);
        }


        public bool DeleteCustomer(int customerId)
        {
            return _customerRepository.DeleteCustomer(customerId);
        }

               

        public List<Customer> GetCustomersByField(Dictionary<string, object> searchParameters)
        {
            return _customerRepository.GetCustomers(searchParameters);
        }

        public void AddDefaultCustomer()
        {
            var initialCustomer = new Customer { FirstName = "Global", LastName = "Global" , PhoneNumber = "0", EmailAddress = "Global", CustomerAddress = "Global" };

            AddCustomer(initialCustomer);
        }
    }



}
