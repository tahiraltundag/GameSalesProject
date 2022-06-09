using GameSalesProject.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Entities.Concretes
{
    public class Member : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }

        public Member(int id, string firstName, string lastName,long nationalityId,DateTime dateOfBirth, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            NationalityId = nationalityId;
            DateOfBirth = dateOfBirth;
            Password = password;
        }
    }
}
