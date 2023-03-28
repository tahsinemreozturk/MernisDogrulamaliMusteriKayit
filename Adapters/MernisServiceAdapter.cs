using Abstract_and_Interface.Abstract;
using Abstract_and_Interface.Entities;
using Abstract_and_Interface.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Interface.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateOfBrithday.Year);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
