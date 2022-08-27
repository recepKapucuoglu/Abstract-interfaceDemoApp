using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractİnterfaceDemoApp.Abstract
{  // her nesne için temelde mutlaka olusturulan interface.
    // 2 firmada customer'i data base kaydı için save metodu.    => bu interfaceyi iplemente eden claslar müsterilerini databaseye kaydetmiş olacak. 
    // ilerleyen zamanda firmalar artarsa buradan iplemente edip databasesini kaydetmiş olacak.
    public interface ICustomerService
    {
        void Save(Entities.Customer customer);  // müsteri clasını databaseye kaydet.
    }
}
