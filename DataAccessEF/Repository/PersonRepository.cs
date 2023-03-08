﻿using DataAccessEF.DbContex;
using DataAccessEF.Interfaces;
using Domain.Models;

namespace DataAccessEF.Repository
{
    class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(PeopleContext context) : base(context) { }

        IEnumerable<Person> IPersonRepository.GetAdultPersons()
        {
            var result= context.Person.Where(pers => pers.Age >= 32).ToList();
            return result;
        }
    }
}
