using GitDiffApi.Data;
using GitDiffApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Web.Http.Description;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GitDiffApi.Controllers
{
    

    [Route("repositories")]
    [ApiController]
    [DisplayName("RenamedProperty")]
    public class GitDiffController : ControllerBase
    {
        public GitDiffController(){}
        string ResponseDescription = "";

        [HttpGet("{owner}/{repository}/commits/{oid}")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(parameters), StatusCodes.Status200OK)]
        //[Produces("application/json", Type = typeof(parameters))]
        //[ProducesResponseType(typeof(object), 200, ResponseDescription = "Metadata about a commit in JSON format.")]

        public  IActionResult GetCommitById(string owner, string repository, string oid)
        //public IActionResult GetCommitById([FromBody] parameters parameters)
        {
            GetData getData = new GetData();
            var commit = getData.GetCommit(oid);          
            return new JsonResult(commit);
        }



[HttpGet("{ owner}/{repository}/commits/{oid}/diff")]
        public IActionResult GetCommitDiff(string owner, string repository, string oid)
        {            
            return Ok();           
        }
    }
}
