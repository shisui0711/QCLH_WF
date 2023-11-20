﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views.User
{
    public partial class frmChangePassword : Form,IChangePassword
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private string _message;
        public string Message
        {
            get { return _message;}
            set { _message = value;
                MessageBox.Show(_message,"Thông báo"); }
        }
        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetField("txt" + name);
            if (textBoxField != null && textBoxField.GetType().IsAssignableTo(typeof(UserControl)))
            {
                var textBox = (UserControl)textBoxField.GetValue(this);
                textBox.Focus();
            }
        }


        public string Email
        {
            get { return lblEmail.Text;}
            set { lblEmail.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text;}
            set { txtPassword.Text = value; }
        }
        public string Repassword
        {
            get { return txtRepassword.Text;}
            set { txtRepassword.Text = value; }
        }
        public event EventHandler? ChangePassowrd;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangePassowrd?.Invoke(sender,e);
        }
    }
}
