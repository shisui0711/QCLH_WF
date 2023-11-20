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
    public partial class frmViewProvider : Form, IViewProvider
    {
        public string SearchText
        {
            get { return txtSearch.Text;}
            set { txtSearch.Text = value; }
        }
        public BindingSource ProviderBindingSource
        {
            get { return providerBindingSource; }
        }
        public event EventHandler? RemoveProvider;
        public event EventHandler? LoadProvider;
        public event EventHandler? SearchProvider;
        public event EventHandler? ShowAddProvider;
        public event EventHandler? ShowUpdateProvider;

        public frmViewProvider()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProvider?.Invoke(sender,e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadProvider?.Invoke(sender,e);
        }

        private void frmViewProvider_Load(object sender, EventArgs e)
        {
            LoadProvider?.Invoke(sender,e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddProvider?.Invoke(sender,e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdateProvider?.Invoke(sender,e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveProvider?.Invoke(sender,e);
        }
    }
}