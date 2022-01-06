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

        public int InsertEvent(string cost, string description, string startdate, string enddate)
        {
            string query = $"insert into Events (EventCost,Description,StartDate,EndDate) " +
                $"values({cost}, '{description}', '{startdate}', '{enddate}')";
            return dbMan.ExecuteNonQuery(query);
        }

        //------------------------------------DELETE QUERIES-------------------------
        public int DeleteEvent(string num)
        {
            string query = $"DELETE FROM Events WHERE EventNO = {num}";
            return dbMan.ExecuteNonQuery(query);
        }
        //------------------------------------UPDATE QUERIES-------------------------

        public int UpdateRoomCleanStatus(string num)
        {
            string query = $"UPDATE Room SET Cleaned='T' WHERE RoomNO='{num}';";
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

        public DataTable SelectRoleid(string username)
        {
            string query = $"SELECT RoleID FROM Employee where UserName='{username}';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeeName(string username)
        {
            string query = $"EXEC SelectEmployeeName @user_username = '{username}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllEventsNumbers()
        {
            string query = $"Select EventNO from Events";
            return dbMan.ExecuteReader(query);
        }
        
        public DataTable SelectEvent(string num)
        {
            string query = $"Select * from Events where EventNO = '{num}'";
            return dbMan.ExecuteReader(query);
        }
        
        public DataTable SelectAllEvents()
        {
            string query = $"Select * from Events";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectRoomsToBeCleaned(string username)
        {
            string query = $"select RoomNO,Cleaned from Room, Employee where UserName = '{username}' AND ESSN = SSN";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectRoomsRequestClean(string username)
        {
            string query = $"select RoomNO from Room, Employee where UserName = '{username}' AND ESSN = SSN AND Cleaned='F'";
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
