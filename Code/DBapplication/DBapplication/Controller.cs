﻿using System;
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
        //------------------------------------------Global QUERIES---------------------------------------------

        public void CheckOut(string RoomNO, string USSN)
        {
            SetNotOccupancy(RoomNO);
            int check = DeleteReservtion(RoomNO,USSN);
            if (check == 1)
                MessageBox.Show("Check out successful");
            else
                MessageBox.Show("This room isn't reserved by this user!");
        }

        //------------------------------------------Insert QUERIES---------------------------------------------
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
            SetEventCostNulls();

            int temp = SelectLastBillNO();

            string query = $"INSERT INTO Reservation (StartDate,EndDate,USSN,RoomNO,BillNO)  Values ('{StartDate}','{EndDate}',{USSN},{RoomNO},{temp});";

            SetOccupancy(RoomNO);

            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertBill(string RoomCost)
        {
            string query = $"INSERT INTO Bill (RoomCost) Values ({RoomCost});";
            SetEventCostNulls();
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertDependents(string FName,string LName,string ESSN,string gender,string relationship)
        {
            string query = $"INSERT INTO Dependents Values ('{FName}' ,'{LName}' , {ESSN} ,'{gender}' , '{relationship}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertEmployee(string FName, string Minit,string LName, string SSN,string roleid,string gender, string BDate, string Address, string MobileNO, string SuperSSN, string salary, string username)
        {
            string query = $"INSERT INTO Employee  Values ('{FName}','{Minit}','{LName}',{SSN},'{roleid}','{gender}','{BDate}','{Address}','{MobileNO}',{SuperSSN},{salary},'{username}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertEmpAccount(string username,string password)
        {
            string query = $"INSERT INTO LoginAccount Values ('{username}','{password}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Insert()
        {
            string query = $"INSERT INTO  Values ();";
            return dbMan.ExecuteNonQuery(query);
        }

        //------------------------------------------Delete QUERIES---------------------------------------------
        public int Delete()
        {
            string query = $"DELETE FROM  WHERE ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteReservtion(string RoomNO, string USSN)
        {
            string query = $"DELETE FROM Reservation WHERE RoomNO = {RoomNO} and USSN = {USSN}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeleteDependents(string FName, string ESSN)
        {
            string query = $"DELETE FROM Dependents WHERE FName = '{FName}' and ESSN = {ESSN}";
            return dbMan.ExecuteNonQuery(query);
        }

        //------------------------------------------Update QUERIES---------------------------------------------
        public int Update()
        {
            string query = $"UPDATE SET WHERE ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SetEventCostNulls()
        {
            string query = $"UPDATE Bill SET Eventcost = 0 WHERE EventCost is NULL;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int SetOccupancy(string RoomNO)
        {
            string query = $"UPDATE Room SET Occupancy = 1 WHERE RoomNO = {RoomNO};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int SetNotOccupancy(string RoomNO)
        {
            string query = $"UPDATE Room SET Occupancy = 0 WHERE RoomNO = {RoomNO};";
            return dbMan.ExecuteNonQuery(query);
        }

        //------------------------------------------SELECT QUERIES---------------------------------------------
        public DataTable Select()
        {
            string query = $"SELECT * FROM ;";
            return dbMan.ExecuteReader(query);
        }

        //For the combox
        public DataTable SelectRoomNOFromReserveation()
        {
            string query = $"SELECT RoomNO FROM Reservation;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectUSSNFromReserveation()
        {
            string query = $"SELECT USSN FROM Reservation;";
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
        public DataTable SelectEmployeSSN()
        {
            string query = $"SELECT distinct SSN FROM Employee;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectRoleID()
        {
            string query = $"SELECT distinct RoleID FROM Roles;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeDEPSSN()
        {
            string query = $"SELECT distinct ESSN FROM Dependents;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDependentFName()
        {
            string query = $"SELECT distinct FName FROM Dependents;";
            return dbMan.ExecuteReader(query);
        }


        public int SelectLastBillNO()
        {
            string query = $"select max(BillNO) from Bill;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int SelectPriceForBill(string RoomNO)
        {
            string query = $"select price from room as r, RoomType as rt where r.RoomType = rt.RoomTypeID and r.RoomNO = {RoomNO};";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable SelectRoomPrice(string RoomNO)
        {
            string query = $"select EventCost, RoomCost, (EventCost + RoomCost) as TotalCost from  Bill as b, Reservation as r where b.BillNO = r.BillNO and r.RoomNO = {RoomNO};" ;
            return dbMan.ExecuteReader(query);
        }

        //------------------------------------------Count QUERIES---------------------------------------------
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
