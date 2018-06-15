using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using simpleRest.Models;

namespace simpleRest.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public IEnumerable<string> Get()
        {
            return new string[] { "Persona1", "Persona2", "Persona3", "Persona4" };
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            Person person = new Person();
            person.ID = id;
            person.Apellidos = "Jimenez";
            person.Nombres = "Victor";
            person.PayRate = 45.5;
            person.StartDate = DateTime.Parse("5/5/2000");
            person.EndDate = DateTime.Parse("5/5/2010");

            return person;
        }

        // POST: api/Person
        public HttpResponseMessage Post([FromBody] Person value)
        {
            PersonPersistencia pp = new PersonPersistencia();
            long id;
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
