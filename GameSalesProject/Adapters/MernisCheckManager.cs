using GameSalesProject.Business.Abstracts;
using GameSalesProject.Entities.Concretes;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Adapters
{
    public class MernisCheckManager : MemberCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(member.NationalityId), member.FirstName.ToUpper(), member.LastName.ToUpper(), member.DateOfBirth.Year);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
