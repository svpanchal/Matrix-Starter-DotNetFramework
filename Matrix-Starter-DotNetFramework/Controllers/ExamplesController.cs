using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Services.Description;
using Matrix_Starter_DotNetFramework.Models;
using Matrix_Starter_DotNetFramework.Models.Dtos;
using Swashbuckle.Swagger;

namespace Matrix_Starter_DotNetFramework.Controllers
{
    /// <summary>
    /// Examples Controller Class
    /// </summary>
    [EnableCors(origins: "*",
        headers: "*", methods: "*")]
    public class ExamplesController : ApiController
    {
        /// <summary>
        /// Get all Examples
        /// </summary>
        /// <remarks>Get a list of all Examples</remarks>
        public IHttpActionResult GetExamples()
        {
            var response = new Response<string>
            {
                IsValid = true,
                Message = new ResponseMessage(),
                Dto = "Dto"
            };

            return Ok(response);
        }

        /// <summary>
        /// Get Example
        /// </summary>
        /// <remarks>Get an Example by id</remarks>
        public IHttpActionResult GetExample(int id)
        {
            var response = new Response<string>
            {
                IsValid = true,
                Message = new ResponseMessage(),
                Dto = "Dto"
            };

            return Ok(response);
        }

        /// <summary>
        /// Post Example
        /// </summary>
        /// <remarks>Post an Example</remarks>
        public IHttpActionResult PostExample([FromBody] string value)
        {
            var response = new Response<string>
            {
                IsValid = true,
                Message = new ResponseMessage(),
                Dto = "Dto"
            };

            return Ok(response);
        }

        /// <summary>
        /// Put Example
        /// </summary>
        /// <remarks>Put an Example</remarks>
        public IHttpActionResult PutExample(int id, [FromBody] string value)
        {
            var response = new Response<string>
            {
                IsValid = true,
                Message = new ResponseMessage(),
                Dto = "Dto"
            };

            return Ok(response);
        }

        /// <summary>
        /// Delete Example
        /// </summary>
        /// <remarks>Delete an Example</remarks>
        public IHttpActionResult DeleteExample(int id)
        {
            var response = new Response<string>
            {
                IsValid = true,
                Message = new ResponseMessage(),
                Dto = "Dto"
            };

            return Ok(response);
        }
    }
}
