﻿using PhanThaiVuong_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhanThaiVuong_BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required]
        public String Place { get; set; }

        [Required]
        [FutureDate]
        public String Date { get; set; }

        [Required]
        [ValidTime]
        public String Time { get; set; }

        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTme()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }

        internal DateTime GetDateTime()
        {
            throw new NotImplementedException();
        }
    }
}