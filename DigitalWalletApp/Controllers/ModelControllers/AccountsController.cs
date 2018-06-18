using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DigitalWalletApp.Models;


namespace DigitalWalletApp.Controllers.ModelControllers
{
    [RoutePrefix("api/Accounts")]
    public class AccountsController : ApiController
    {
        private DigitalWalletDBEntities1 db = new DigitalWalletDBEntities1();

        // GET: api/AllAccounts
        [HttpGet]
        [Route("AllAccounts")]
        
        public IQueryable<Account> GetAccounts()
        {
            return db.Accounts;
        }

        // GET: api/GetAccount ()=> ID
        [HttpGet]
        [Route("GetAccount")]
        [ResponseType(typeof(Account))]
        public IHttpActionResult GetAccount(int id)
        {
            Account account = (db.Accounts.Find(id));
            if (account == null)
            {
                return NotFound();
            }

            return  Ok(account);
        }



        // PUT: api/Accounts/5
        //[HttpGet]
        //[Route("AddAccount")]
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutAccount(int id, [FromBody]Account account)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != account.AccountNo)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(account).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AccountExists(id))
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

        // POST: api/Accounts/AddAccount ()=> Account
        [HttpPost]
        [Route("AddAccount")]
        [ResponseType(typeof(Boolean))]
        public IHttpActionResult PostAccount([FromBody]Account account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Accounts.Add(account);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AccountExists(account.AccountNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = account.AccountNo }, account);
        }

        // DELETE: api/Accounts/DeleteAccount ()=> ID
        [HttpGet]
        [Route("DeleteAccount")]
        [ResponseType(typeof(Boolean))]
        public IHttpActionResult DeleteAccount(int id)
        {
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return NotFound();
            }

            db.Accounts.Remove(account);
            db.SaveChanges();

            return Ok(account);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AccountExists(int id)
        {
            return db.Accounts.Count(e => e.AccountNo == id) > 0;
        }
    }
}