﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaSu.src.models
{
    public class AccountModel
    {
        private int _accid;
        private string _phanQuyen;
        private string _userName;
        private string _password;
        private string _email;
        private int _nganSach;

        public int Accid { get => _accid; set => _accid = value; }
        public string PhanQuyen { get => _phanQuyen; set => _phanQuyen = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }
        public int NganSach { get => _nganSach; set => _nganSach = value; }

        // TẠO USER ACCOUNT
        public void setAccount( string phanQuyen, string userName, string password, string email, int nganSach)
        {
            PhanQuyen = phanQuyen;
            UserName = userName;
            Password = password;
            Email = email;
            NganSach = nganSach;
        }

        public AccountModel() { }
    }
}
