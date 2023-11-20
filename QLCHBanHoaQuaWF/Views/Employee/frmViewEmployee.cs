﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views.Employee
{
    public partial class frmViewEmployee : Form, IViewEmployee
    {
        public string SearchText {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public int OptionIndex {
            get { return cboOptionSearch.SelectedIndex; }
            set { cboOptionSearch.SelectedIndex = value; }
        }
        public BindingSource EmployeeBindingSource { get { return employeeBindingSource; } }
        public event EventHandler? LoadEmployee;
        public event EventHandler? RemoveEmployee;
        public event EventHandler? SearchEmployee;
        public event EventHandler? ShowPurchaseHistory;
        public event EventHandler? ShowImportHistory;
        public event EventHandler? ShowShiftHistory;
        public event EventHandler? ShowAddEmployee;
        public event EventHandler? ShowUpdateEmployee;
        public frmViewEmployee()
        {
            InitializeComponent();
        }

        private void frmViewEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployee?.Invoke(sender,e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadEmployee?.Invoke(sender,e);
            txtSearch.Text = String.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchEmployee?.Invoke(sender,e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddEmployee?.Invoke(sender,e);
        }

        private void cboOptionSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdateEmployee?.Invoke(sender,e);
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            ShowPurchaseHistory?.Invoke(sender,e);
        }

        private void btnImportHistory_Click(object sender, EventArgs e)
        {
            ShowImportHistory?.Invoke(sender,e);
        }

        private void btnShiftHistory_Click(object sender, EventArgs e)
        {
            ShowShiftHistory?.Invoke(sender,e);
        }
    }
}