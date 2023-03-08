using Domain.ViewModel;
using System.Linq.Expressions;

namespace BLL.IManager
{
    public interface IPersonManager
    {
        PersonViewModel GetById(int id);
        IEnumerable<PersonViewModel> GetAll();
        IEnumerable<PersonViewModel> Find(Expression<Func<PersonViewModel, bool>> expression);
        void Add(PersonViewModel entity);
        void AddRange(IEnumerable<PersonViewModel> entities);
        void Remove(PersonViewModel entity);
        void RemoveRange(IEnumerable<PersonViewModel> entities);

        IEnumerable<PersonViewModel> GetAdultPersons();
    }
}
