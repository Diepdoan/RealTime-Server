using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Real_Time.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IHubContext<NotifyHub> _hubContext;
        public ValuesController(IHubContext<NotifyHub> hubContext)
        {
            _hubContext = hubContext;
        }
        [HttpPost]
        [Route("postMess")]
        public string PostMess([FromQuery]string user, [FromQuery]string mess)
        {
            string retMessage;
            try
            {
               // _hubContext.Clients.All.BroadcastMessage(type, payload);
                _hubContext.Clients.All.SendAsync("ReceiveMessage1",user, mess);
                retMessage = "Success";
            }
            catch (Exception e)
            {
                retMessage = e.ToString();
            }
            return retMessage;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2","value3" };
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
