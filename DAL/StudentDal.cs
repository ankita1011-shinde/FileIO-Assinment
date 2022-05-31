using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFirstForm.DAL
{
    public class StudentDal
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public StudentDal()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(constr);
        }
    }
}
