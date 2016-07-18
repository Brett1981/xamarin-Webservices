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
using Webservices.Models;

namespace Webservices.Controllers
{
    public class MaterielsController : ApiController
    {
        private WebservicesContext db = new WebservicesContext();

        // GET: api/Materiels
        public List<Materiel> GetMateriels()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Materiels.ToList();
        }

        // GET: api/Materiels/5
        [ResponseType(typeof(Materiel))]
        public IHttpActionResult GetMateriel(int id)
        {
            Materiel materiel = db.Materiels.Find(id);
            if (materiel == null)
            {
                return NotFound();
            }

            return Ok(materiel);
        }

        // PUT: api/Materiels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMateriel(int id, Materiel materiel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != materiel.MaterielId)
            {
                return BadRequest();
            }

            db.Entry(materiel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterielExists(id))
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

        // POST: api/Materiels
        [ResponseType(typeof(Materiel))]
        public IHttpActionResult PostMateriel(Materiel materiel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Materiels.Add(materiel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = materiel.MaterielId }, materiel);
        }

        // DELETE: api/Materiels/5
        [ResponseType(typeof(Materiel))]
        public IHttpActionResult DeleteMateriel(int id)
        {
            Materiel materiel = db.Materiels.Find(id);
            if (materiel == null)
            {
                return NotFound();
            }

            db.Materiels.Remove(materiel);
            db.SaveChanges();

            return Ok(materiel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MaterielExists(int id)
        {
            return db.Materiels.Count(e => e.MaterielId == id) > 0;
        }
    }
}