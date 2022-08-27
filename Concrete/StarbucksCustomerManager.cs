using AbstractİnterfaceDemoApp.Abstract;
using AbstractİnterfaceDemoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractİnterfaceDemoApp.Concrete
{
    public class StarbucksCustomerManager : Abstract.BaseCustomerManager
    {
        private Abstract.ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            this._customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {   
             // mernis dogrulaması için .

            if(_customerCheckService.CheckIfRealPerson(customer))
            { base.Save(customer);}
            else { throw new Exception("not a valid customer"); }
            
        }


    }
}
