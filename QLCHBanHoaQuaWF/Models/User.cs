﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBanHoaQuaWF.Models
{
    public class User
    {
        public User(int employeeId, Employee employee, string email, string password, int roleId, UserRole userRole)
        {
            EmployeeID = employeeId;
            Employee = employee;
            Email = email;
            Password = password;
            RoleID = roleId;
            UserRole = userRole;
        }

        public User()
        {
            
        }
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }
        [MinLength(8,ErrorMessage = "Mật khẩu phải dài ít nhất 8 ký tự.")]
        public string Password { get; set; }

        public DateTime LastLogin { get; set; }

        public bool Lock { get; set; } = false;
        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public UserRole UserRole { get; set; }
        
        
    }
}