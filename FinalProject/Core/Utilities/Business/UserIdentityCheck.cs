using IdentityVerification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public static class UserIdentityCheck
    {
        public static bool CheckUserIdentity(long identityNo, string name, string surname, int birthday)
        {
            var mernisClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = mernisClient.TCKimlikNoDogrulaAsync(identityNo, name, surname, birthday).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
