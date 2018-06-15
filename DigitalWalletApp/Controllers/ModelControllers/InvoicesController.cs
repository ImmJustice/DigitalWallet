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
{   [RoutePrefix("api/Invoices")]
    public class InvoicesController : ApiController
    {
        private DigitalWalletDBEntities1 db = new DigitalWalletDBEntities1();

        // GET: api/Invoices
        [HttpGet]
        [Route("AllInvoices")]
        public IQueryable<Invoice> GetInvoices()
        {
            return db.Invoices;
        }

        // GET: api/Invoices/5
        [HttpGet]
        [Route("GetInvoice")]
        [ResponseType(typeof(Invoice))]
        public IHttpActionResult GetInvoice(int id)
        {
            Invoice invoice = db.Invoices.Find(id);
            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(invoice);
        }



        //// PUT: api/Invoices/5
        //[HttpGet]
        //[Route("AddInvoice")]
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutInvoice(Invoice invoice)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != invoice.InvoiceNo)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(invoice).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!InvoiceExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/Invoices
        [HttpGet]
        [Route("AddInvoice")]
        [ResponseType(typeof(Boolean))]
        public IHttpActionResult PostInvoice(Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Invoices.Add(invoice);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (InvoiceExists(invoice.InvoiceNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = invoice.InvoiceNo }, invoice);
        }

        // DELETE: api/Invoices/5
        [HttpGet]
        [Route("DeleteInvoice")]
        [ResponseType(typeof(Boolean))]
        public IHttpActionResult DeleteInvoice(int id)
        {
            Invoice invoice = db.Invoices.Find(id);
            if (invoice == null)
            {
                return NotFound();
            }

            db.Invoices.Remove(invoice);
            db.SaveChanges();

            return Ok(invoice);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InvoiceExists(int id)
        {
            return db.Invoices.Count(e => e.InvoiceNo == id) > 0;
        }
    }
}