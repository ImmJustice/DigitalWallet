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
{   [RoutePrefix("api/Transactions")]
    public class TransactionsController : ApiController
    {
        private DigitalWalletDBEntities1 db = new DigitalWalletDBEntities1();

        // GET: api/Transactions
        [HttpGet]
        [Route("AllTransactions")]
        public IQueryable<Transaction> GetTransactions()
        {
            return db.Transactions;
        }

        // GET: api/Transactions/5
        [HttpGet]
        [ResponseType(typeof(Transaction))]
        public IHttpActionResult GetTransaction(int AccountTo, DateTime datepaid)
        {
            Transaction transaction = db.Transactions.Find(AccountTo, datepaid);
            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(transaction);
        }

        [HttpGet]
        [Route("AccountTo")]
        [ResponseType(typeof(List<Transaction>))]
        public IHttpActionResult TransAccountTo(int accountTo)
        {
            return Ok(db.Transactions.Where(T => T.AccountTo == accountTo));
        }

        [HttpGet]
        [Route("AccountFrom")]
        [ResponseType(typeof(List<Transaction>))]
        public IHttpActionResult TransAccountFrom(int accountFrom)
        {
            return Ok(db.Transactions.Where(T => T.AccountFrom == accountFrom));
        }

        // PUT: api/Transactions/5

        [ResponseType(typeof(void))]
        public IHttpActionResult PutTransaction(int id, Transaction transaction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != transaction.AccountTo)
            {
                return BadRequest();
            }

            db.Entry(transaction).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionExists(id))
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

        // POST: api/Transactions
        [HttpPost]
        [Route("AddTransaction")]
        [ResponseType(typeof(bool))]
        public IHttpActionResult PostTransaction(Transaction transaction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Transactions.Add(transaction);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (TransactionExists(transaction.AccountTo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = transaction.AccountTo }, transaction);
        }

        // DELETE: api/Transactions/5
        [HttpGet]
        [Route("DeleteTransaction")]
        [ResponseType(typeof(Transaction))]
        public IHttpActionResult DeleteTransaction(int id, DateTime date)
        {
            Transaction transaction = db.Transactions.Find(id,date);
            if (transaction == null)
            {
                return NotFound();
            }

            db.Transactions.Remove(transaction);
            db.SaveChanges();

            return Ok(transaction);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TransactionExists(int id)
        {
            return db.Transactions.Count(e => e.AccountTo == id) > 0;
        }
    }
}