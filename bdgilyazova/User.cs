using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdgilyazova
{
    public class User
    {
        public int iddrivers { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string passportdata { get; set; }
        public string height { get; set; }
        public string birth { get; set; }

        public User(DataRow row)
        {
            iddrivers = Convert.ToInt32(row["iddrivers"]);
            login = Convert.ToString(row["login"]);
            password = Convert.ToString(row["password"]);
            fullname = Convert.ToString(row["fullname"]);
            passportdata = Convert.ToString(row["passportdata"]);
            height = Convert.ToString(row["height"]);
            birth = Convert.ToString(row["birth"]);
        }
   
    }
}

