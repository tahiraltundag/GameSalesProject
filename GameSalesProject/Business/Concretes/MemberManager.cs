using GameSalesProject.Adapters;
using GameSalesProject.Business.Abstracts;
using GameSalesProject.Entities.Abstracts;
using GameSalesProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Business.Concretes
{
    public class MemberManager : MemberService
    {

        MernisCheckManager _mernisCheckManager;

        public MemberManager(MernisCheckManager mernisCheckManager)
        {
            _mernisCheckManager = mernisCheckManager;
        }

        public MemberManager()
        {

        }



        List<Member> members = new List<Member>();

        public void Add(Member member)
        {
            if( _mernisCheckManager.CheckIfRealPerson(member) == true)
            {
                if (members.Contains(member) == true)
                {
                    Console.WriteLine(member.FirstName + " Bu üye sisteme zaten kayıtlı");
                }
                else
                {
                    members.Add(member);
                    Console.WriteLine(member.FirstName + " Adlı Yeni üye sisteme kaydedildi");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir şahıs bulunmamaktadır");
            }
        }


        public void Delete(Member member)
        {
            if (_mernisCheckManager.CheckIfRealPerson(member) == true)
            {
                if (members.Contains(member) == true)
                {
                    members.Remove(member);
                    Console.WriteLine(member.FirstName + " Üyesi sistemden silindi");
                }
                else
                {
                    Console.WriteLine("Tespit edilemeyen kullanıcı");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir şahıs bulunmamaktadır");
            }
        }


        public void Update(Member member)
        {
            if (_mernisCheckManager.CheckIfRealPerson(member) == true)
            {
                if (members.Contains(member) == true)
                {
                    Console.WriteLine(member.FirstName + " üye bilgileri güncellendi");
                }
                else
                {
                    Console.WriteLine("Böyle bir üye sistemde bulunmamakta");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir şahıs bulunmamaktadır");
            }
        }    
    }
}
