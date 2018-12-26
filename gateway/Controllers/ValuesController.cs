using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gateway.clients.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly ILogger<ValuesController> logger;

        public ValuesController(IUserService userService, ILogger<ValuesController> logger)
        {
            this.userService = userService ?? throw new ArgumentNullException(nameof(userService));
            this.logger = logger ?? throw new ArgumentNullException(nameof(ValuesController));
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            this.logger.Log(LogLevel.Trace, "trying to get values from the user service");
            var result = await this.userService.GetValues();
            this.logger.Log(LogLevel.Trace, "successfully retreived values from the user service");
            return this.Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
