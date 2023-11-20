﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views.Product
{
    public partial class frmViewProduct : Form,IViewProduct
    {
        public string SearchText
        {
            get { return txtSearch.Text;}
            set { txtSearch.Text = value; }
        }
        public int OptionIndex {
            get { return cboOptionSearch.SelectedIndex; }
            set { cboOptionSearch.SelectedIndex = value; }
        }
        public BindingSource ProductBindingSource
        {
            get { return productBindingSource; }
        }
        public event EventHandler? RemoveProduct;

        public event EventHandler? LoadProduct;

        public event EventHandler? SearchProduct;

        public event EventHandler? ShowAddProduct;
        public event EventHandler? ShowUpdateProduct;
        public frmViewProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddProduct?.Invoke(sender,e);
        }

        private void frmViewProduct_Load(object sender, EventArgs e)
        {
            LoadProduct?.Invoke(sender,e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadProduct?.Invoke(sender,e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdateProduct?.Invoke(sender,e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveProduct?.Invoke(sender,e);
        }
    }
}