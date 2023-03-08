using BLL.IManager;
using DataAccessEF.Interfaces;
using Domain.ViewModel;
using System.Linq.Expressions;

namespace BLL.Manager
{
    public class PersonManager : IPersonManager
    {
        private readonly IUnitOfWork unitOfWork;
        public PersonManager(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Add(PersonViewModel entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<PersonViewModel> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonViewModel> Find(Expression<Func<PersonViewModel, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonViewModel> GetAdultPersons()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PersonViewModel GetById(int id)
        {
            PersonViewModel personViewModel = new PersonViewModel();
            var result= unitOfWork.Person.GetById(id);

            return personViewModel;
        }

        public void Remove(PersonViewModel entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<PersonViewModel> entities)
        {
            throw new NotImplementedException();
        }
    }
}
