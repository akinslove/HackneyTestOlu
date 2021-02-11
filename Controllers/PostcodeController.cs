using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HackneyTestDockerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostcodeController : ControllerBase
    {

        [HttpGet]
        public Postcode Get(string postCodeText)
        {
            //pattern
            string pattern = @"[A-Za-z][1-9][1-9][A-Za-z]{2}";

            //use regular expression by creating regex instance
            Regex reg = new Regex(pattern);

            //validate postcode
            if (!reg.IsMatch(postCodeText))
            {
                throw new InvalidDataException("Wrong Postcode supplied");
            }

            //TODO:connect to database and retrieve list of address

            Postcode postcode = new Postcode();

            //store the address
            return postcode;
        }



        //TODO: DELETE
       

        // GET api/<PostcodeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PostcodeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PostcodeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostcodeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
