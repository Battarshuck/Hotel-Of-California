using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public int Insert()
        {
            string query = $"INSERT INTO  Values ();";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Delete()
        {
            string query = $"DELETE FROM  WHERE ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Update()
        {
            string query = $"UPDATE SET WHERE ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Select()
        {
            string query = $"SELECT * FROM ;";
            return dbMan.ExecuteReader(query);
        }
        public int Count()
        {
            string query = $"SELECT COUNT() FROM ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
