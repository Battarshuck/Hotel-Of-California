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

        public int InsertAccount(string fname, string minit, string lname, string username, string password, string gender, string bdate, string ssn, string mobile, string address)
        {
            string query = $"Insert into LoginAccount (UserName, Password) values('{username}', '{password}'); ";
            int query_result = dbMan.ExecuteNonQuery(query);

            InsertUser(fname, minit, lname, username, gender, bdate, ssn, mobile, address);

            return query_result;
        }

        private int InsertUser(string fname, string minit, string lname, string username, string gender, string bdate, string ssn, string mobile, string address)
        {
            string query = $"INSERT INTO [User](FName, Minit, LName, SSN, Gender, BirthDate, Address, MobileNO, UserName) " +
                $"Values('{fname}', '{minit}', '{lname}', {ssn}, '{gender}', '{bdate}', '{address}', {mobile}, '{username}')";

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
        //------------------------------------------SELECT QUERIES---------------------------------------------
        public DataTable Select()
        {
            string query = $"SELECT * FROM ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectRoomType()
        {
            string query = $"(select RoomType from RoomType)  union (select RoomType from RoomType) ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectRoomView()
        {
            string query = $"(select RoomView from RoomType)  union (select RoomView from RoomType) ;";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectRoleid(string username)
        {
            string query = $"SELECT RoleID FROM Employee where UserName='{username}';";
            return dbMan.ExecuteReader(query);
        }


        public int Count()
        {
            string query = $"SELECT COUNT() FROM ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int ExistAccount(string username, string password)
        {
            string query = $"select 1 where EXISTS(select UserName from LoginAccount where UserName = '{username}' AND[Password]= '{password}');";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
