using DataAccessEF.DbContex;
using DataAccessEF.Interfaces;
using Domain.Models;

namespace DataAccessEF.Repository
{
    class AddressRepository : GenericRepository<Address>, IAdressRepository
    {
        public AddressRepository(PeopleContext context) : base(context) { }
    }
}
