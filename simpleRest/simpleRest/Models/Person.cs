using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simpleRest.Models
{
    public class Person
    {
        public long ID { get; set; }
        public String Apellidos { get; set; }
        public String Nombres { get; set; }
        public Double PayRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}