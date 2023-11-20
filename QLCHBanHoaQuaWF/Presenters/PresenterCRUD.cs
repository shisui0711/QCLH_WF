﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views;
using QLCHBanHoaQuaWF.Views.Customer;

namespace QLCHBanHoaQuaWF.Presenters
{
    public abstract class PresenterCRUD
    {
        public abstract void Add();
        public abstract void Update();
        public abstract void Remove();
        public abstract void Search();
        public abstract void Load();

        public bool IsValid(object target, IValidateControl validateControl)
        {
            var errors = new List<ValidationResult>();
            bool isValid =
                Validator.TryValidateObject(target, new ValidationContext(target), errors, true);
            if (!isValid)
            {
                validateControl.Message = errors.First().ErrorMessage;
                validateControl.Focus(errors.SelectMany(x => x.MemberNames).First());
            }
            return isValid;
        }
    }
}