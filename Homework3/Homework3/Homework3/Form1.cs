using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form1 : Form
    {
        List<string> username = new List<string>();
        List<string> password = new List<string>();
        List<int> money = new List<int>();
        int cek = 0;
        int user = 0;
        int cekdepo = 0;
        int cekwid = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            if (cek == 0)
            {
                buttonlogin.Visible = false;
                MessageBox.Show("Please enter new registration");
                cek = 1;
            }
            else
            {
                buttonlogin.Visible = true;
                cekuserdanpass();
                cek = 0;
            }


        }
        private void cekuserdanpass()
        {
            int cekregis = 0;
            foreach (string username in username)
            {
                if (username == textBoxusername.Text)
                {
                    MessageBox.Show("User already registered");
                    cekregis = 1;
                    break;
                }
            }
            if (cekregis == 0)
            {
                MessageBox.Show("Succesfully registered");
                username.Add(textBoxusername.Text);
                password.Add(textBoxpassword.Text);
                money.Add(0);
                textBoxusername.Text = "";
                textBoxpassword.Text = "";
            }
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            int ceklogin = 0;
            user = -1;
            foreach (string username in username)
            {
                user++;
                if (username == textBoxusername.Text)
                {
                    ceklogin = 1;
                    break;
                }
            }
            if (ceklogin == 1 && password[user] == textBoxpassword.Text)
            {
                MessageBox.Show("Welcome");
                label4.Visible = true;
                buttondeposit.Visible = true;
                buttonwithdraw.Visible = true;
                buttonlogout.Visible = true;
                buttonregister.Visible = false;
                buttonlogin.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                textBoxpassword.Visible = false;
                textBoxusername.Visible = false;
                label4.Text = "Saldo: " + money[user].ToString("C", new CultureInfo("id-ID"));
            }
            else
            {
                MessageBox.Show("No Username Found");
            }
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully logged out");
            label4.Visible = false;
            buttondeposit.Visible = false;
            buttonwithdraw.Visible = false;
            buttonlogout.Visible = false;
            buttonregister.Visible = true;
            buttonlogin.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBoxpassword.Visible = true;
            textBoxusername.Visible = true;
        }

        private void buttondeposit_Click(object sender, EventArgs e)
        {
            if (cekdepo == 0)
            {
                label2.Text = "Amount:";
                label2.Visible = true;
                textBoxusername.Text = "";
                textBoxusername.Visible = true;
                buttonwithdraw.Visible = false;
                cekdepo = 1;
            }
            else
            {
                int moneydeposit = Convert.ToInt32(textBoxusername.Text);
                int moneynow = money[user];

                if (moneydeposit <= 0)
                {
                    MessageBox.Show("cannot deposit less than 1");
                }
                else
                {
                    MessageBox.Show("Successfully Deposited " + moneydeposit.ToString());
                    money[user] = moneynow + moneydeposit;
                }
                label4.Text = "Saldo: " + money[user].ToString("C", new CultureInfo("id-ID"));
                label2.Text = "Username";
                label2.Visible = false;
                textBoxusername.Visible = false;
                buttonwithdraw.Visible = true;
                textBoxusername.Text = "";
                cekdepo = 0;
            }
        }

        private void buttonwithdraw_Click(object sender, EventArgs e)
        {
            if (cekwid == 0)
            {
                label2.Text = "Amount:";
                label2.Visible = true;
                textBoxusername.Visible = true;
                textBoxusername.Text = "";
                buttondeposit.Visible = false;
                cekwid = 1;
            }
            else
            {
                int moneywithdraw = Convert.ToInt32(textBoxusername.Text);
                int moneynow = money[user];
                if (moneynow < moneywithdraw)
                {
                    MessageBox.Show("Balance too small");
                }
                else if (moneywithdraw <= 0)
                {
                    MessageBox.Show("cannot withdraw less than 1");
                }
                else
                {
                    MessageBox.Show("Successfully Withdrawn " + moneywithdraw.ToString());
                    money[user] = moneynow - moneywithdraw;
                }
                label4.Text = "Saldo: " + money[user].ToString("C", new CultureInfo("id-ID"));
                label2.Text = "Username";
                label2.Visible = false;
                textBoxusername.Visible = false;
                buttondeposit.Visible = true;
                textBoxusername.Text = "";
                cekwid = 0;
            }
        }
    }
}