﻿using QLCHBanHoaQuaWF.Views;
using QLCHBanHoaQuaWF.Views.Customer;
using QLCHBanHoaQuaWF.Views.Employee;
using QLCHBanHoaQuaWF.Views.ImportOrder;
using QLCHBanHoaQuaWF.Views.Options;
using QLCHBanHoaQuaWF.Views.Product;
using QLCHBanHoaQuaWF.Views.Provider;
using QLCHBanHoaQuaWF.Views.SalesOrder;
using QLCHBanHoaQuaWF.Views.User;
using QLCHBanHoaQuaWF.Views.UserRole;
using System.Reflection;

namespace QLCHBanHoaQuaWF.Presenters;

public class MainPresenter
{
    private readonly IViewMain _viewMain;
    private readonly IViewEmployee _viewEmployee;
    private readonly IViewCustomer _viewCustomer;
    private readonly IViewProduct _viewProduct;
    private readonly IViewProvider _viewProvider;
    private readonly IViewSalesOrder _viewSalesOrder;
    private readonly IViewImportOrder _viewImportOrder;
    private readonly IViewUser _viewUser;
    private readonly IViewUserRole _viewUserRole;
    private readonly IViewOptions _viewOptions;
    public MainPresenter(IViewMain viewMain, IViewCustomer viewCustomer, IViewEmployee viewEmployee, IViewProduct viewProduct, IViewProvider viewProvider, IViewSalesOrder viewSalesOrder, IViewImportOrder viewImportOrder, IViewUser viewUser, IViewUserRole viewUserRole, IViewOptions viewOptions)
    {
        _viewMain = viewMain;
        _viewCustomer = viewCustomer;
        _viewEmployee = viewEmployee;
        _viewProduct = viewProduct;
        _viewProvider = viewProvider;
        _viewSalesOrder = viewSalesOrder;
        _viewImportOrder = viewImportOrder;
        _viewUser = viewUser;
        _viewUserRole = viewUserRole;
        _viewOptions = viewOptions;

        _viewMain.LoadPages += delegate { LoadPages(); };
    }

    public void LoadPages()
    {
        _viewMain.User = AuthPresenter.User.Email;
        _viewMain.Role = AuthPresenter.User.UserRole.RoleName;

        List<FieldInfo> fieldViews = GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.FieldType.Name.StartsWith("IView")).ToList();
        foreach (TabPage tabPage in _viewMain.NavigationBar.TabPages)
        {
            string name = tabPage.Name.Substring(3);
            var field = fieldViews.Find(f => f.FieldType.Name.Substring(5) == name);
            if (field != null)
            {
                Form form = (Form)field.GetValue(this);
                if (form != null)
                {
                    form.TopLevel = false;
                    tabPage.Controls.Add(form);
                    form.Dock = DockStyle.Fill;
                    form.Show();
                }
            }

        }
    }
}