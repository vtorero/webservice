using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simpleRest
{
    public class PersonPersistencia
    {
        private MySql.Data.MySqlClient.MySqlConnection conn;

        public PersonPersistencia()
        {
            string myConnectionString;
            myConnectionString = "server=127.0.0.1; uid=root; pwd=; database=test";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

                throw;
            }

        }

        public long savePerson(Models.Person personToSave)
        {
            String sqlString = "INSERT INTO person (Apellidos,Nombres,StarDate,EndDate) VALUES('" + personToSave.Apellidos + "','" + personToSave.Nombres + "','" + personToSave.StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + personToSave.EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;
            return id;

        }


    }
}