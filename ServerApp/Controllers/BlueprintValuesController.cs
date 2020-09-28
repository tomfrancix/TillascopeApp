using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerApp.Models;
using ServerApp.Models.BindingTargets;

namespace ServerApp.Controllers
{
    [Route("api/blueprints")]
    public class BlueprintValuesController : Controller
    {
        private DataContext context;
        public BlueprintValuesController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IEnumerable<Blueprint> GetBlueprints()
        {
            return context.Blueprints;
        }

        [HttpPost]
        public IActionResult CreateBlueprint([FromBody] BlueprintData bdata)
        {
            if (ModelState.IsValid)
            {
                Blueprint b = bdata.Blueprint;
                context.Add(b);
                context.SaveChanges();
                return Ok(b.BlueprintId);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("{id}")]
        public IActionResult ReplaceBlueprint(long id, [FromBody] BlueprintData bdata)
        {
            if (ModelState.IsValid)
            {
                Blueprint b = bdata.Blueprint;
                b.BlueprintId = id;
                context.Update(b);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpDelete("{id}")]
        public void DeleteBlueprint(long id)
        {
            context.Remove(new Blueprint { BlueprintId = id });
            context.SaveChanges();
        }
    }
}
