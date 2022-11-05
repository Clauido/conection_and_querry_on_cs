using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_PostgresSQL.Clases
{
    internal class Class_Conection
    {
        NpgsqlConnection conex = new NpgsqlConnection("Server= localhost; Database= taller3; User id= postgres; Password= claudio1611;");

        public void conectar()
        {
            try
            {
                conex.Open();
                MessageBox.Show("Se concectó corerctamnte a la base de datos");
            }
            catch(NpgsqlException e){
                MessageBox.Show("Conexión Erronea"+ e);//e.ToString()
            }
        }
    }
}
