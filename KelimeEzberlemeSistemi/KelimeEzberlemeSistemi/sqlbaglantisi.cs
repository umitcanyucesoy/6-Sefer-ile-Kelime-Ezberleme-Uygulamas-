using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace KelimeEzberlemeSistemi
{



    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-HPC3T1H\\SQLEXPRESS01;Initial Catalog=KelimeEzberlemeSistemi;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }

    }


}
