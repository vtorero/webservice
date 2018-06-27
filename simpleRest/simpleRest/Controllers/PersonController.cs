using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using simpleRest.Models;
using System.Data.SqlClient;
using System.Collections;

namespace simpleRest.Controllers
{
  
    public class PersonController : ApiController
    {

        // GET: api/Person
        
        public ArrayList Get()
        {
            PersonPersistencia pp = new PersonPersistencia();
            return pp.getPersons();
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            PersonPersistencia pp = new PersonPersistencia();
            return pp.getPerson(id);
        }

        // POST: api/Person
        public HttpResponseMessage Post([FromBody] Person value)
        {
            PersonPersistencia pp = new PersonPersistencia();
            int id;
            id = pp.savePerson(value);
            value.ID = id;
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("person/{0}",id));
            return response;
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
