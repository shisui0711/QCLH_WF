﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views.Provider
{
    public partial class frmUpdateProvider : Form, IUpdateProvider
    {
        public frmUpdateProvider()
        {
            InitializeComponent();
        }

        private string _message;
        public string Message
        {
            get { return _message;}
            set { _message = value;
                MessageBox.Show(_message, "Thông Báo");
            }
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

        public int ProviderID
        {
            get { return int.Parse(txtProviderID.Text);} }
        public string ProviderName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public event EventHandler? UpdateProvider;
    }
}
