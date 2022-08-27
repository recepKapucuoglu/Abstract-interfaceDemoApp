﻿using AbstractİnterfaceDemoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractİnterfaceDemoApp.Adapters
{
    public class MernisServiceAdapter : Abstract.ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(customer.NationalityId,customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateTimeBirth.Year );
        }
    }
}
