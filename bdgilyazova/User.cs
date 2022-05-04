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
    public class InfoCar
    { 
        public int idcar_data { get; set; }
        public string vim { get; set; }
        public string model_of_car { get; set; }
        public string year_of_release { get; set; }
        public string fullname_of_driver { get; set; }
        public string state_number { get; set; }
        public string employee { get; set; }

     
        public InfoCar(DataRow row_two)
        {
            idcar_data = Convert.ToInt32(row_two["idcar_data"]);
            vim = Convert.ToString(row_two["vim"]);
            model_of_car = Convert.ToString(row_two["model_of_car"]);
            year_of_release = Convert.ToString(row_two["year_of_release"]);
            fullname_of_driver = Convert.ToString(row_two["fullname_of_driver"]);
            state_number = Convert.ToString(row_two["state_number"]);
            employee = Convert.ToString(row_two["employee"]);
        }
    }
}

