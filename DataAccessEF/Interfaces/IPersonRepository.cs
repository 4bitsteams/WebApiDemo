using Domain.Models;

namespace DataAccessEF.Interfaces
{
    public interface IPersonRepository : IGenericRepository<Person> {
        IEnumerable<Person> GetAdultPersons();
    
    }
}
