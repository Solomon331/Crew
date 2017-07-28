using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H2ODatabase.Models
{
    public class Crew
    {
        public int CrewID { get; set; }

        public string CrewName { get; set; }
      
        public List<Student> Students { get; set; }
    }
}