using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using simpleRest.Models;

namespace simpleRest
{
    public class PersonPersistencia

    {
        private SqlConnection conn;
        private SqlCommand command;


        public PersonPersistencia()
        {
            string myConnectionString;

            myConnectionString = "Data Source=WS50A2VJIMENEZ\\SQLEXPRESS;Initial Catalog=inspeccion;Integrated Security=SSPI;";
            //myConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=inspeccion;Integrated Security=SSPI;";
            try
            {
                conn = new SqlConnection(myConnectionString);
                
                       }
            catch (Exception ex)
            {

               
            }

        }

        public int savePerson(Person personToSave)
        {
            int primaryKey;
            String sqlString = "INSERT INTO empleado (apellido,nombre) VALUES('" + personToSave.Apellidos + "','" + personToSave.Nombres + "')";
            conn.Open();
            command = new SqlCommand(sqlString, conn);
            command.ExecuteNonQuery();
            primaryKey = Convert.ToInt32(command.ExecuteScalar());


            return primaryKey;

        }

        public Person getPerson(int id) {

            Person person = new Person();
            SqlDataReader sqlReader = null;
            String sql = "SELECT * from empleado where idEmpleado = " + id.ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            sqlReader = cmd.ExecuteReader();
            if (sqlReader.Read())
            {
                person.ID = sqlReader.GetInt32(0);
                person.Nombres = sqlReader.GetString(1);
                person.Apellidos = sqlReader.GetString(1);
                conn.Close();
                return person;
              
            }
            else
            {
                conn.Close();
                return null;
            }


        }


    }
}