using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMV.Models
{
    public class Persone2
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
    }
    public class Model01
    {
        public Persone2[] persones { get; set; }
        public Model01() 
        {
            persones = new Persone2[]
            {
                new Persone2{ Id=1,Prénom="Sami",Nom="Bennoui" },
                new Persone2{ Id=2,Prénom="Raouf",Nom="Benyahya"},
                new Persone2{ Id=3,Prénom="Abedrahman",Nom="Mebani"},
                new Persone2{ Id=4,Prénom="hassen",Nom="Goumni"},
                new Persone2{ Id=5,Prénom="Ronaldo",Nom="Cristiano"},
                 new Persone2{ Id=5,Prénom="Kaka",Nom="Recardo"}

            };
        }
    }
  
}