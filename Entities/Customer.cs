using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractİnterfaceDemoApp.Entities
{           //somut sınıflar çıplak kalmamalı.
    public class Customer:Abstract.IEntity
        

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTimeBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
