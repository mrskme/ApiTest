using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTest.Model;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<Person> Get(int id)
        {
            return await Task.Run(() => 
                new Person() {Id = id, Email = "MrSkme@hotmail.no", Name = "Eirik"});
        }
        public async Task<IEnumerable<Person>> GetMany()
        {
            return await Task.Run(() => new []
            {
                new Person() {Id = 1, Email = "Per@hotmail.no", Name = "Per"},
                new Person() {Id = 2, Email = "Pål@hotmail.no", Name = "Pål"},
            });
        }
        [HttpPost]
        public async Task<int>  Create(Person person)
        {
            return await Task.Run(() => 1);
        }
        public async Task<int> Delete(int id)
        {
            return await Task.Run(() => 1);
        }
    } 
}
