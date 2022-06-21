﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PhanThaiVuong_BigSchool.ViewModels
{
    internal class ValidTimeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",CultureInfo.CurrentCulture,DateTimeStyles.None,
                out dateTime);
            return isValid;
        }
    }
}