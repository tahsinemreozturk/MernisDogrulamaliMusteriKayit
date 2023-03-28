using Abstract_and_Interface.Abstract;
using Abstract_and_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Interface.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer) 
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else 
            {
               throw new Exception("Not a valid person");
            }
            
        }

       
    }
}
