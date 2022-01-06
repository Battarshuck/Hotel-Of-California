﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Form_Receptionist : Form
    {

        Controller controllerObject = new Controller();
        public Form_Receptionist()
        {
            InitializeComponent();

            DataTable dt = controllerObject.SelectRoomType();
            CheckRoomTypeCombo.DataSource = dt;
            CheckRoomTypeCombo.DisplayMember = "RoomType";

            dt = controllerObject.SelectRoomView();
            CheckRoomViewCombo.DataSource = dt;
            CheckRoomViewCombo.DisplayMember = "RoomView";

            dt = controllerObject.SelectUserSSN();
            CheckUSSN.DataSource = dt;
            CheckUSSN.DisplayMember = "SSN";

        }

        private void Form_Receptionist_Load(object sender, EventArgs e)
        {

        }

        private void CheckRoomAvailableBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckStartDate.Value > CheckEndDate.Value || CheckStartDate.Value < DateTime.Today)
                {
                    MessageBox.Show("Invalid dates");
                    return;
                }

                CheckRoomNO.Items.Clear();

                int check = controllerObject.ExistRoomToReserve(CheckRoomTypeCombo.Text, CheckRoomViewCombo.Text, CheckStartDate.Text, CheckEndDate.Text);

                DataTable dt = controllerObject.SelectAvailableRoomNumber(CheckRoomTypeCombo.Text, CheckRoomViewCombo.Text, CheckStartDate.Text, CheckEndDate.Text);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string RoomNo = dt.Rows[i][0].ToString();
                    CheckRoomNO.Items.Add(RoomNo);
                }

                MessageBox.Show("Room is available");
            }
            catch
            {
                MessageBox.Show("Room isn't available");
            }
        }

        private void ReserveBTN_Click(object sender, EventArgs e)
        {
            try
            {

                int yy1 = CheckStartDate.Value.Year, mm1 = CheckStartDate.Value.Month;

                if (mm1 <= 2)
                {
                    yy1 = yy1 - 1;
                    mm1 = mm1 + 13;
                }

                int NoDays1 = (146097 * yy1) / 400 + (153 * mm1 + 8) / 5 + CheckStartDate.Value.Day;

                int yy2 = CheckEndDate.Value.Year, mm2 = CheckEndDate.Value.Month;

                if (mm2 <= 2)
                {
                    yy2 = yy2 - 1;
                    mm2 = mm2 + 13;
                }

                int NoDays2 = (146097 * yy2) / 400 + (153 * mm2 + 8) / 5 + CheckEndDate.Value.Day;

                int difference = NoDays2 - NoDays1;


                int check = controllerObject.InsertRerservation(CheckStartDate.Text, CheckEndDate.Text,CheckUSSN.Text,CheckRoomNO.Text ,difference);
                MessageBox.Show("Room reserved");
            }
            catch
            {
                MessageBox.Show("Room reservation failed");
            }
        }

        private void label6_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
