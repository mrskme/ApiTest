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
    public class MissionController : ControllerBase
    {
        public MissionController()
        {
            
        }
        [HttpGet]
        public async Task<IEnumerable<Mission>> GetAll()
        {
            var missionRepository = new MissionRepository();
            return await missionRepository.GetAll();
        }
        //private MissionRepository _missionRepository;
        //public MissionController()
        //{
        //    _missionRepository = new MissionRepository();
        //}

        //[HttpGet("{id}")]
        //public async Task<Mission> Get(int id)
        //{
        //    return await Task.Run(() => _data.OneById(id));
        //}

        [HttpPost]
        public async Task<IEnumerable<int>> Create(Mission mission)
        {
            var missionRepository = new MissionRepository();
            return await missionRepository.Create(mission);
        }
        //[HttpPut]
        //public async Task<int> Edit(Mission mission)
        //{
        //    return await Task.Run(() => 1);
        //}
        //[HttpDelete]
        //public async Task<int> Delete(int id)
        //{
        //    return await Task.Run(() => 1);
        //}
    } 
}
