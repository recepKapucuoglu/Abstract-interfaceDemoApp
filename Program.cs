using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractİnterfaceDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        { //1. firmadan yeni bir müsteri eklemesi yapalım. 
            Abstract.BaseCustomerManager customerManager = new Concrete.NeroCustomerManager();  
            customerManager.Save(new Entities.Customer { DateTimeBirth=new DateTime(1994,8,11),FirstName="recep",LastName="kapucuoğlu",NationalityId="545457" });
            // 2. firma yeni bir müşteri ekleyelim.    // mernis dogrulaması ile.
            Abstract.BaseCustomerManager customerManager2 = new Concrete.StarbucksCustomerManager(new Adapters.MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { DateTimeBirth = new DateTime(1994, 8, 11), FirstName = "recep", LastName = "kapucuoğlu", NationalityId = "545457" });






            Console.ReadLine();
        }
    }
}
