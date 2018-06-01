using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DigitalWalletApp.Models;

namespace DigitalWalletApp.Controllers.ModelControllers
{
    public class WorkAllocationsController : ApiController
    {
        private DigitalWalletDBEntities1 db = new DigitalWalletDBEntities1();

        // GET: api/WorkAllocations
        public IQueryable<WorkAllocation> GetWorkAllocations()
        {
            return db.WorkAllocations;
        }

        // GET: api/WorkAllocations/5
        [ResponseType(typeof(WorkAllocation))]
        public IHttpActionResult GetWorkAllocation(int id)
        {
            WorkAllocation workAllocation = db.WorkAllocations.Find(id);
            if (workAllocation == null)
            {
                return NotFound();
            }

            return Ok(workAllocation);
        }

        // PUT: api/WorkAllocations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWorkAllocation(int id, WorkAllocation workAllocation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != workAllocation.TeamID)
            {
                return BadRequest();
            }

            db.Entry(workAllocation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkAllocationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/WorkAllocations
        [ResponseType(typeof(WorkAllocation))]
        public IHttpActionResult PostWorkAllocation(WorkAllocation workAllocation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WorkAllocations.Add(workAllocation);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (WorkAllocationExists(workAllocation.TeamID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = workAllocation.TeamID }, workAllocation);
        }

        // DELETE: api/WorkAllocations/5
        [ResponseType(typeof(WorkAllocation))]
        public IHttpActionResult DeleteWorkAllocation(int id)
        {
            WorkAllocation workAllocation = db.WorkAllocations.Find(id);
            if (workAllocation == null)
            {
                return NotFound();
            }

            db.WorkAllocations.Remove(workAllocation);
            db.SaveChanges();

            return Ok(workAllocation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WorkAllocationExists(int id)
        {
            return db.WorkAllocations.Count(e => e.TeamID == id) > 0;
        }
    }
}