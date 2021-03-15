using ControllerAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerAPI.Controllers
{
    [Route("api/response-service/")]
    [Consumes("application/json")]
    [Produces("application/json")]
    [SwaggerTag("Responses from services")]
    [ApiController]
    public class ResponseServiceController : ControllerBase
    {
        private readonly IEFCoreRepository _repository;

        public ResponseServiceController(IEFCoreRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("get-all")]
        [SwaggerOperation(Summary = "Gets all responses", Description = "Gets Responses drom data base")]
        [SwaggerResponse(200, "Success")]
        [SwaggerResponse(417, "SQL EXCEPTION")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var responseServices = await _repository.GetAllResponseService();
                return Ok(new { responseServices });
            }
            catch (SqlException ex)
            {
                return StatusCode(417, new { detail = "SqlException", message = ex.Message });
            }
        }
    }
}
