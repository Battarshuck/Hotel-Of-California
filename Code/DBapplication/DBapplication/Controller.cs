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

        public int InsertRerservation(string StartDate, string EndDate, string USSN, string RoomNO, int N)
        {
            int price = SelectPriceForBill(RoomNO);

            price = price * N;
            InsertBill(price.ToString());

            int temp = SelectLastBillNO();

            string query = $"INSERT INTO Reservation (StartDate,EndDate,USSN,RoomNO,BillNO)  Values ('{StartDate}','{EndDate}',{USSN},{RoomNO},{temp});";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertBill(string RoomCost)
        {
            string query = $"INSERT INTO Bill (RoomCost) Values ({RoomCost});";
            return dbMan.ExecuteNonQuery(query);
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
        //For the combox
        public DataTable SelectAvailableRoomNumber(string RoomType, string RoomView, string startDate, string endDate)
        {
            string query = $"(select RoomNO from Reservation where (select RoomNO from Room as R, RoomType as RT where RT.RoomType = '{RoomType}' and RT.RoomView = '{RoomView}' and R.RoomType = RT.RoomTypeID) = RoomNO and (EndDate <= '{startDate}' OR StartDate >= '{endDate}')) union (select RoomNO from Room as R, RoomType as RT where RT.RoomType = '{RoomType}' and RT.RoomView = '{RoomView}' and R.RoomType = RT.RoomTypeID and R.Occupancy = 0);";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectUserSSN()
        {
            string query = $"SELECT SSN FROM [User];";
            return dbMan.ExecuteReader(query);
        }
      

        public int SelectLastBillNO()
        {
            string query = $"select max(BillNO) from Bill;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int SelectPriceForBill(string RoomNO)
        {
            string query = $"Select Price from Room as r, RoomType as RT , Reservation as res where res.RoomNO = r.RoomNO and r.RoomType = RT.RoomTypeID and res.RoomNO = {RoomNO};";
            return (int)dbMan.ExecuteScalar(query);
        }



        public int Count()
        {
            string query = $"SELECT COUNT() FROM ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int CountBills()
        {
            string query = $"Select Count(Bill.BillNO) from Bill ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int ExistAccount(string username, string password)
        {

            string query = $"select 1 where EXISTS(select UserName from LoginAccount where UserName = '{username}' AND[Password]= '{password}');";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int ExistAvailableRoom(string RoomType, string RoomView)
        {
            string query = $"select 1 where EXISTS(select R.Occupancy from RoomType as RT,Room as R where RT.RoomTypeID = R.RoomType and RT.RoomType = '{RoomType}' and RT.RoomView = '{RoomView}' and R.Occupancy = 0);";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int ExistRoomToReserve(string RoomType, string RoomView, string startDate, string endDate)
        {
            string query = $"select 1 from Reservation where (select RoomNO from Room as R, RoomType as RT where RT.RoomType = '{RoomType}' and RT.RoomView = '{RoomView}' and R.RoomType = RT.RoomTypeID) = RoomNO and (EndDate < '{startDate}' OR StartDate > '{endDate}');";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
