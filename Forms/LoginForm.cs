using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System;
using ArtisanMarketAdmin.Data;
using ArtisanMarketAdmin.Models;

namespace ArtisanMarketAdmin.Forms
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var admin = new Admin(txtUsername.Text, txtPassword.Text);

            if (admin.Login(_db))
            {
                this.Hide();
                new DashboardForm().ShowDialog();
                this.Close();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
                lblError.Visible = true;
            }
        }
    }
}