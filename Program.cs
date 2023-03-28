using Abstract_and_Interface.Abstract;
using Abstract_and_Interface.Adapters;
using Abstract_and_Interface.Concrete;
using Abstract_and_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Interface
{
    internal class Program  // iki farkli firimanin veri tabanina musterilerini kaydeden bir program yazdik.
                           // Iki firimadan birisi musteriyi kaydederken dogrulama istedi. Onu da mernis servisi ile yaptik.
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBrithday = new DateTime(2002,6,21), 
                FirstName = "Tahsin Emre", LastName = "Öztürk", NationalityId = "324********"});
            Console.ReadLine();
        }
    }

    


}
