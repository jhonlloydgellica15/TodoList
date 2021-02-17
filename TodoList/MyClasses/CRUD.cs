using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TodoList.MyClasses
{
    class CRUD
    {
        public MySqlConnection con;
        
        public CRUD()
        {
            string host = "localhost";
            string database = "todo";
            string port = "3306";
            string username = "root";
            string password = "";

            string connStr = $"datasource={host}; database={database}; port={port}; username={username}; password={password};";

            con = new MySqlConnection(connStr);
        }
    }

    class TODO : CRUD
    {

        MySqlCommand cmd;
        MySqlDataAdapter msda;


        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public string task { set; get; }
        public string id { set; get; }
        public void READ()
        {
            dt.Clear();
            string query = "SELECT * FROM tbltodo";
            msda = new MySqlDataAdapter(query, con);
            msda.Fill(ds);
            dt = ds.Tables[0];
        }


        public void UPDATE()
        {
            con.Open();
            using(cmd = new MySqlCommand("UPDATE tbltodo SET todo = @todo WHERE id = @id", con))
            {
                cmd.Parameters.AddWithValue("@todo", task);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        public void DELETE()
        {
            con.Open();
            using(cmd = new MySqlCommand("DELETE FROM tbltodo WHERE id = @id ", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        public void INSERT(TextBox value)
        {
            task = value.Text;
            try
            {
                //task = value.Text;
                con.Open();
                cmd = new MySqlCommand("INSERT INTO tbltodo (todo) VALUES (@task)", con);
                cmd.Parameters.AddWithValue("@task", task);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Task Added Successfully!", "Message Info");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
