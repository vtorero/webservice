using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace simpleRest
{
    public class PersonPersistencia

    {
        private SqlConnection conn;
        private SqlCommand command;


        public PersonPersistencia()
        {
            string myConnectionString;

   
            myConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=inspeccion;Integrated Security=SSPI;";
            try
            {
                conn = new SqlConnection(myConnectionString);
                
                       }
            catch (Exception ex)
            {

               
            }

        }

        public long savePerson(Models.Person personToSave)
        {
            String sqlString = "INSERT INTO empleado (Apellidos,Nombres) VALUES('" + personToSave.Apellidos + "','" + personToSave.Nombres + "')";
            conn.Open();
            command = new SqlCommand(sqlString, conn);
            command.ExecuteNonQuery();

            return 1;

        }


    }
}