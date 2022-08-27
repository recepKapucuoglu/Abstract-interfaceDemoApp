using AbstractİnterfaceDemoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractİnterfaceDemoApp.Abstract
{

    // firmaların 2 side database kayıt istiyor. ama biri extradan mernis dogrulaması istiyor. bu yüzden abstract olusturup mernis dogrulaması isteyene override hakkkı tanımıs olacagız.
    //BU YÜZDEN ABSTRACT KULLANARAK HEM ZORUNLU KAYITI DEVAM ETTİRİRKEN MERNİS DOGRULAMASI İSTEYEN FİRMAYADA VİRTUAL-OVERRİDE SEÇENEGI SUNDUK.  
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)   //virtual= zorunlu koda ekleme yapabilirim. (2.firma mernis dogrulaması için override kullanarak ekleme yapacak.) 
        {
            Console.WriteLine("DATABASE KAYDEDİLDİ."+customer.FirstName);
        }
    }
}
