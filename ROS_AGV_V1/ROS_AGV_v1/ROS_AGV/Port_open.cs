using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ROS_AGV
{
    class Port_open
    {
        public void port_open(string server, string port, string userid, string password, string database)
        {
            //string connStr = "server = " + server + " ;  port = " + port + "; userid = " + userid + "; password = " + password + "; database = " + database + "; charset = utf8;";
            //MySqlConnection conn = new MySqlConnection(connStr);
            //MySqlCommand command = conn.CreateCommand();

            //conn.Open();
        }


        public void upload(string server, string port, string userid, string password, string database,
            string table,
            string pallet_id)
        {
            string connStr = "server = " + server + " ;  port = " + port + "; userid = " + userid + "; password = " + password + "; database = " + database + "; charset = utf8;";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.ConnectionString = connStr;
            conn.Open();

            command.CommandText = "INSERT INTO " + table + " (Status) VALUES('" + pallet_id + "')";/////////commend
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void read(string server, string port, string userid, string password, string database,string table,out string Status)
        {
            Status = "";
            string connStr = "server = " + server + " ;  port = " + port + "; userid = " + userid + "; password = " + password + "; database = " + database + "; charset = utf8;";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "SELECT * FROM " + table + " WHERE Time = (SELECT max(Time) FROM " + table + ")";/////////commend
            MySqlCommand cmd = new MySqlCommand(command.CommandText, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Status = reader.GetString(1);
            }
            conn.Close();
            reader.Close();
            //return "";
        }
    }
}
