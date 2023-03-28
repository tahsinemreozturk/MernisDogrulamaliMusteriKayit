using Abstract_and_Interface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Interface.Entities
{
    public class Customer:IEntity

    {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBrithday { get; set; }
            public string NationalityId { get; set; }
        
    }
}
