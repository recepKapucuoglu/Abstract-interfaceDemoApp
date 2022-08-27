using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractİnterfaceDemoApp.Abstract
{   
    //kullanıcıların mernis dogrulama durumu
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Entities.Customer customer);
    }
}
