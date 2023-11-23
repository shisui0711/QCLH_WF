﻿namespace QLCHBanHoaQuaWF.Views.UserRole
{
    public partial class frmUpdateUserRole : Form, IUpdateUserRole
    {
        public frmUpdateUserRole()
        {
            InitializeComponent();
        }

        public int RoleID
        {
            get { return int.Parse(txtRoleID.Text); }
            set { txtRoleID.Text = value.ToString(); }
        }
        public string RoleName
        {
            get { return txtRoleName.Text; }
            set { txtRoleName.Text = value; }
        }
        public string Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }
        public CheckedListBox PermissionSelected
        {
            get { return clbPermission; }
        }
        public event EventHandler? LoadPermission;
        public event EventHandler? UpdateUserRole;

        private void frmUpdateUserRole_Load(object sender, EventArgs e)
        {
            LoadPermission?.Invoke(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateUserRole?.Invoke(sender, e);
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                MessageBox.Show(_message, "Thông báo");
            }
        }
        private string _message;
        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetField("txt" + name);
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this);
                textBox.Focus();
            }
        }
    }
}
