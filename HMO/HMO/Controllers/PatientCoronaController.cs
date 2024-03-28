using BLL.Functions;
using DTO.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientCoronaController : ControllerBase
    {
        private readonly PatientCoronaFunctions _funcs;

        public PatientCoronaController()
        {
            this._funcs = new PatientCoronaFunctions();
        }

        [HttpGet("GetAllPatientsCorona")]
        public IActionResult GetAllPatientsCorona()
        {
            return Ok(_funcs.GetAllPatientsCorona());
        }

        [HttpPost("AddNewPatientCorona")]
        public IActionResult AddNewPatientCorona([FromBody] PatientsCoronaDTO patient)
        {
            _funcs.AddPatientCorona(patient);
            return Ok();
        }

        [HttpPut("UpdatePatientCorona/{code}")]
        public IActionResult UpdatePatientCorona(int code, [FromBody] PatientsCoronaDTO p)
        {
            _funcs.UpdatePatientCorona(code, p);
            return Ok();
        }

        [HttpDelete("DeletePatientCorona/{code}")]
        public IActionResult DeletePatientCorona(int code)
        {
            _funcs.DeletePatientCorona(code);
            return Ok();
        }

        [HttpGet("GetPatientCoronaById/{id}")]
        public IActionResult GetPatientCoronaById(string id)
        {
            return Ok(_funcs.getPatientCoronaById(id));
        }

    }
}
