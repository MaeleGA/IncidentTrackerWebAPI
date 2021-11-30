using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IR_WebAPI.Models;

namespace IR_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingUnitsController : ControllerBase
    {
        private readonly XamarinAccountAppApi_dbContext _context;

        public BuildingUnitsController(XamarinAccountAppApi_dbContext context)
        {
            _context = context;
        }

        // GET: api/BuildingUnits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BuildingUnit>>> GetBuildingUnit()
        {
            return await _context.BuildingUnit.ToListAsync();
        }

        // GET: api/BuildingUnits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BuildingUnit>> GetBuildingUnit(int id)
        {
            var buildingUnit = await _context.BuildingUnit.FindAsync(id);

            if (buildingUnit == null)
            {
                return NotFound();
            }

            return buildingUnit;
        }

        // PUT: api/BuildingUnits/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBuildingUnit(int id, BuildingUnit buildingUnit)
        {
            if (id != buildingUnit.BuId)
            {
                return BadRequest();
            }

            _context.Entry(buildingUnit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildingUnitExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BuildingUnits
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BuildingUnit>> PostBuildingUnit(BuildingUnit buildingUnit)
        {
            _context.BuildingUnit.Add(buildingUnit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBuildingUnit", new { id = buildingUnit.BuId }, buildingUnit);
        }

        // DELETE: api/BuildingUnits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BuildingUnit>> DeleteBuildingUnit(int id)
        {
            var buildingUnit = await _context.BuildingUnit.FindAsync(id);
            if (buildingUnit == null)
            {
                return NotFound();
            }

            _context.BuildingUnit.Remove(buildingUnit);
            await _context.SaveChangesAsync();

            return buildingUnit;
        }

        private bool BuildingUnitExists(int id)
        {
            return _context.BuildingUnit.Any(e => e.BuId == id);
        }
    }
}
