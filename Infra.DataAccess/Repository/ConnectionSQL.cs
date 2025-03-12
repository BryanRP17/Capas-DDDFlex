using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Infra.DataAccess.Repository
{
    public class ConnectionSQL
    {
        protected SqlConnection Conexion = new SqlConnection("Server=BRYANRP17;Database=Practica_Patrones;" +
            "Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
