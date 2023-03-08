using DataAccessEF.DbContex;
using DataAccessEF.Interfaces;
using Domain.Models;

namespace DataAccessEF.Repository
{
    class EmailRepository : GenericRepository<Email>, IEmailRepository
    {
        public EmailRepository(PeopleContext context) : base(context) { }
    }
}
