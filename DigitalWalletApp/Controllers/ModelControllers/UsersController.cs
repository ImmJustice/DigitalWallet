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
{   [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        private DigitalWalletDBEntities1 db = new DigitalWalletDBEntities1();

        // GET: api/Users
        [HttpGet]
        [Route("AllUsers")]
        public IQueryable<User> GetUsers()
        {
            return db.Users;
        }

        [HttpGet]
        [Route("AllStudents")]
        public IQueryable<User> GetStudents()
        {
            return db.Users.Where(U => U.UserType == "S");
        }

        // GET: api/Users
        [HttpGet]
        [Route("GetUser")]
        [ResponseType(typeof(User))]
        public IHttpActionResult GetUser(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(int id, User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.UserID)
            {
                return BadRequest();
            }

            db.Entry(user).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/Users
        [HttpPost]
        [Route("AddUser")]
        [ResponseType(typeof(Boolean))]
        public IHttpActionResult PostUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Users.Add(user);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (UserExists(user.UserID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = user.UserID }, user);
        }

        // DELETE: api/Users/5
        [HttpGet]
        [Route("DeleteUser")]
        [ResponseType(typeof(Boolean))]
        public IHttpActionResult DeleteUser(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            db.Users.Remove(user);
            db.SaveChanges();

            return Ok(user);
        }

        [HttpGet]
        [Route("GetUserList")]
        [ResponseType(typeof(List<String>))]
        public IHttpActionResult UserList()
        {
            return Ok( db.Users.Select(U => U.UserID.ToString()).ToList());
        }
        [HttpGet]
        [Route("GetStudents")]
        [ResponseType(typeof(List<String>))]
        public IHttpActionResult StudentList()
        {
            return Ok(db.Users.Where(U => U.UserType == "S").Select(U => U.UserID.ToString()).ToList());
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserExists(int id)
        {
            return db.Users.Count(e => e.UserID == id) > 0;
        }
    }
}