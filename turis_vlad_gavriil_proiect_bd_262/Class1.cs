using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace turis_vlad_gavriil_proiect_bd_262
{
    class Class1
    {
       public static OracleConnection GetDBConnection()
        {
            string host = "193.226.51.37";
            int port = 1521;
            string sid = "o11g";
            string user = "gavriilvladturis";
            string password = "gavriilvlad#17";

            return Class2.GetDBConnection(host, port, sid, user, password);
        }
    }
}
