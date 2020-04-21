using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.KPSServiceReference;
using Entities.Concrete;

namespace Business.MicroServices.KPSService
{
    public class KPSServiceAdapter : IKPSService
    {
        public bool ValidateMember(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(member.TCNO),
                member.FirstName.ToUpper(),
                member.LastName.ToUpper(),
                member.DateOfBirth.Year
                );
        }
    }
}
