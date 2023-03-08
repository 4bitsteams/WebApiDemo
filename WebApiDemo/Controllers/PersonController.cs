using BLL.IManager;
using DataAccessEF.Interfaces;
using Domain.Models;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IPersonManager personManager;
        public PersonController(IUnitOfWork unitOfWork, IPersonManager personManager)
        {
            this.unitOfWork = unitOfWork;
            this.personManager = personManager;
        }
        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return unitOfWork.Person.GetAll();
        }
        [Route("[action]")]
        [HttpGet]
        public IEnumerable<Person> GetAdultPersons()
        {
            return unitOfWork.Person.GetAdultPersons();
        }
        
        [Route("[action]")]
        [HttpGet]
        public Person GetAdultPersonsById(int id)
        {
            return unitOfWork.Person.GetById(id);
        }
        
        [Route("[action]")]
        [HttpGet]
        public PersonViewModel GetPersonsById(int id)
        {
            return personManager.GetById(id);
        }
    }
}
