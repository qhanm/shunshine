﻿using shunshine.App.EntityCodeFirst.Constant;
using System;
using System.Collections.Generic;

namespace shunshine.App.Models.ViewModels
{
    public class AppUserViewModel
    {
        public AppUserViewModel(string fullName, string email, string avatar, Guid userId)
        {
            FullName = fullName;
            Email = email;
            Avatar = avatar;
            Id = userId;
        }

        public AppUserViewModel()
        {
            Roles = new List<string>();
        }

        public Guid? Id { set; get; }
        public string FullName { set; get; }
        public string BirthDay { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string UserName { set; get; }
        public string Address { get; set; }
        public string PhoneNumber { set; get; }
        public string Avatar { get; set; }
        public decimal Balance { get; set; }
        public Status Status { get; set; }

        public string Gender { get; set; }

        public DateTime DateCreated { get; set; }

        public List<string> Roles { get; set; }
    }
}