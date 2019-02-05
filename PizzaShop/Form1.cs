using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class frmLogin : Form
    {
        //Varables
        public static String strName = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

        public void ClearDetails()
        {
            //Local variable to store result
            DialogResult dr;
            //accept response
            dr = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if yes then close program
            if (dr == DialogResult.No)
            {
                Application.Exit();

            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmPizza sw = new frmPizza();
            this.Hide();
            sw.Show();
        }

        //Procedure to Exit
        public void Halt()
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Pa$$word")
            {
                frmPizza sw = new frmPizza();
                this.Hide();
                sw.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Details", "Please Re-Enter Details", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }

        }
        //code to check the username and password
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //local variable to store result
            DialogResult dr;
            //accept response
            dr = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if yes then close program
            if (dr == DiaologResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
