using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Form_useraccount : Form
    {
        
        Controller controllerObj = new Controller();
        public Form_useraccount()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectRoomType();
            comboBox_roomType.DataSource = dt;
            comboBox_roomType.DisplayMember = "RoomType";

            DataTable dt2 = controllerObj.SelectRoomView();
            comboBox_RoomView.DataSource = dt2;
            comboBox_RoomView.DisplayMember = "RoomView";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_roomType.Text.Length == 0 || comboBox_RoomView.Text.Length == 0 || txt_Price.Text.Length == 0)
            {
                MessageBox.Show("Enter all of the information please!");
                return;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_useraccount_Load(object sender, EventArgs e)
        {

        }
    }
}
