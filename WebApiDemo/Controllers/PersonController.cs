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
        private readonly IPersonManager personManager;
        public PersonController(IPersonManager personManager)
        {
            this.personManager = personManager;
        }
        [HttpGet]
        public IEnumerable<PersonViewModel> GetAllPersons()
        {
            return this.personManager.GetAll();
        }
        [Route("[action]")]
        [HttpGet]
        public IEnumerable<PersonViewModel> GetAdultPersons()
        {
            return this.personManager.GetAdultPersons();
        }
        
        [Route("[action]")]
        [HttpGet]
        public PersonViewModel GetAdultPersonsById(int id)
        {
            return this.personManager.GetById(id);
        }
        
        [Route("[action]")]
        [HttpGet]
        public PersonViewModel GetPersonsById(int id)
        {
            return personManager.GetById(id);
        }
    }
}
