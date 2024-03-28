using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.Functions;
using System;
using DTO.Repository;

namespace HMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly PatientFunctions _funcs;

        public PatientController()
        {
            this._funcs = new PatientFunctions();
        }

        [HttpGet("GetAllPatients")]
        public IActionResult GetAllPatients()
        {
            return Ok(_funcs.GetAllPatients());
        }

        [HttpPost("AddNewPatient")]
        public IActionResult AddNewPatient([FromBody] PatientsDTO patient)
        {
            _funcs.AddPatient(patient);
            return Ok();
        }

        [HttpPut("UpdatePatient/{id}")]
        public IActionResult UpdatePatient(string id, [FromBody] PatientsDTO p)
        {
            _funcs.UpdatePatient(id, p);
            return Ok();
        }

        [HttpDelete("DeletePatient/{id}")]
        public IActionResult DeletePatient(string id)
        {
            _funcs.DeletePatient(id);
            return Ok();    
        }
    }
}
