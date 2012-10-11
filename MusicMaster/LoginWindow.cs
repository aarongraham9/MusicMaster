using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MM.Models;

namespace MusicMaster
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();

            SetFormOptions();
        }

        private void SetFormOptions()
        {
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(LoginWindow_KeyDown);
        }

        private void LoginWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            //Do parsing, verification and checks on login information.

            //Check to see if the user exists and if the information is correct.
            //i.e. int isUserInformationCorrect(username, password)
            //If this user exists and data is correct then get their user data as a usermodel opject.
            UserModel userData = new UserModel(username, password);//For now just create a new user with this information

            SectionSelectionWindow sectionSelectionWindow = new SectionSelectionWindow(userData);
            this.Visible = false;
            sectionSelectionWindow.ShowDialog(this);

            tbUsername.Text = "";
            tbPassword.Text = "";
            this.Visible = true;
        }
    }
}
