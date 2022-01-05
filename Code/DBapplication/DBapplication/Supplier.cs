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
    public partial class Supplier : System.Windows.Forms.Form
    {
        Controller controllerObj;
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            int result = controllerObj.Insert();
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Supplier failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int result = controllerObj.Delete();
            if (result == 0)
            {
                MessageBox.Show("No rows are deleted");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int result = controllerObj.Update();
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            controllerObj.TerminateConnection();
            this.Close();
        }

        
        private void selectAllButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Select();
            //suppliersDataGrid.DataSource = dt;
            //suppliersDataGrid.Refresh();


        }

        private void countButton_Click(object sender, EventArgs e)
        {
           // countTextBox.Text = controllerObj.Count().ToString();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            Show_Form hi = new Show_Form();
            hi.Show();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            edit_form hi = new edit_form();
            hi.Show();
        }




        /*                 *******************     Switch Form      ****************** 
                    
        private void switchButton_Click(object sender, EventArgs e)
        {
            Form1 curr = new Form1();
            curr.Show();
        }
        */

        /*   ****************************** Only characters can be inserted into textbox ***************
         * char cr = e.KeyChar;
         * if(!char.IsLetter(cr) && cr != 8 && cr !=46) {e.Handled = true;}
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         *
         */


        /*                *****************     Check Validations      ****************
                     
        private void insertButton_Click(object sender, EventArgs e)
        {
            int check;
            bool ok = int.TryParse(dno.Text, out check);
            
            ok = ok && (Combo.Text.length > 0);

            if(ok)
            {
                int age = Int16.Parse(age.Text);
                ok = ok && (age > 0);
            }

            if (ok == false) MessageBox.Show("The insertion of a new Department failed. DNumber should be integer.");
            else
            {
                int result = controllerObj.InsertDepartment(dname.Text, dno.Text,
                    mgrssn.Text, stdate2.Value);
                if (result == 0)
                {
                    MessageBox.Show("The insertion of a new Department failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }
        }
        */




        /*                *****************     ComboBox intialization      ****************
                         
        public Form2()
        {
            InitializeComponent();
            DataTable dt = controllerObject.SelectCustomerName();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.Items.Add("Female");
        }
        */
    }
}
