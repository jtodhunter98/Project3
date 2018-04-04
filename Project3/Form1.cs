using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string FILEPATH = @"C:\Users\todjord\Documents\Visual Studio 2017\Projects\Project3\residents.csv";

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }

        private void enterInfoBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            int password = Int32.Parse(passwordBox.Text);

            if (username == "home")
            {
                if (password == 1234)
                {
                    MessageBox.Show("Login Successful");
                }
            }
        }

        

        private void fNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentWorkerOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void athleteOption_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void scholarOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void floorBox_TextChanged(object sender, EventArgs e)
        {
            floorBox.MaxLength = 1;
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            idBox.MaxLength = 4;
        }

        private void newResidentBtn_Click(object sender, EventArgs e)
        {
            string firstName = fNameBox.Text;
            string lastName = lNameBox.Text;


            FileStream file = new FileStream(FILEPATH, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(firstName);
        }
    }
}
