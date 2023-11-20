﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views.Customer
{
    public partial class frmViewCustomer : Form,IViewCustomer
    {
        public string SearchText
        {
            get { return txtSearch.Text;}
            set { txtSearch.Text = value; }
        }
        public int OptionIndex
        {
            get { return cboOptionSearch.SelectedIndex;}
            set { cboOptionSearch.SelectedIndex = value; }
        }
        public BindingSource CustomerBindingSource
        {
            get { return bindingSourceCustomer; }
        }
        public event EventHandler? LoadCustomer;
        public event EventHandler? RemoveCustomer;
        public event EventHandler? SearchCustomer;
        public event EventHandler ShowAddCustomer;
        public event EventHandler ShowUpdateCustomer;
        public frmViewCustomer()
        {
            InitializeComponent();
        }

        private void frmViewCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer?.Invoke(sender,e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddCustomer?.Invoke(sender,e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            LoadCustomer?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCustomer?.Invoke(sender,e);
        }

        private void cboOptionSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdateCustomer?.Invoke(sender,e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemoveCustomer?.Invoke(sender,e);
        }
    }
}