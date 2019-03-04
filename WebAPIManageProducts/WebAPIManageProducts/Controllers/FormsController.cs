using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIManageProducts.Model;

namespace WebAPIManageProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        ECommDBContext _context;

        public FormsController(ECommDBContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Form>> Get()
        {
            List<Form> forms = _context.Forms.ToList();
            return forms;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpGet("getforms")]
        public ActionResult<string> GetForms()
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Form form)
        {
            using (ECommDBContext _context = new ECommDBContext())
            {
                form.Id = Guid.NewGuid();
                _context.Forms.Add(form);
                _context.SaveChanges();
            }

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
