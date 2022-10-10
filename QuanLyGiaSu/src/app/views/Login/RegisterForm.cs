﻿using QuanLyGiaSu.src.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.app.views.Login
{
    public partial class RegisterForm : Form
    {
        string userPermission;
        public RegisterForm(UserType userType)
        {
            InitializeComponent();
            if (userType == UserType.tutor)
            {
                lbUserType.Text = "ĐĂNG KÝ GIA SƯ";
                userPermission = "Gia sư";
            } else if (userType == UserType.parent)
            {
                lbUserType.Text = "ĐĂNG KÝ PHỤ HUYNH";
                userPermission = "Phụ huynh";
            } else
            {
                lbUserType.Text = "ĐĂNG KÝ ADMIN";
                userPermission = "Admin";
            }

            tmCheckInfoLogin.Start();

            tbEmail.GotFocus += removeText;
            tbUser.GotFocus += removeText;
            tbPassword.GotFocus += removeText;
            tbConfirmPass.GotFocus += removeText;

            tbEmail.LostFocus += addText;
            tbUser.LostFocus += addText;
            tbPassword.LostFocus += addText;
            tbConfirmPass.LostFocus += addText;

        }

        void refreshTextBoxPassword()
        {
            tbPassword.Clear();
            tbConfirmPass.Clear();
        }

        void checkInfoTextBox()
        {
            if (tbUser.Text.Length > 8 && tbEmail.Text.Length > 11 && tbPassword.Text.Length > 8 && tbConfirmPass.Text.Length > 8)
            {
                btnRegister.BackColor = Color.Gray;
                btnRegister.Enabled = false;
            }
            else
            {
                btnRegister.BackColor = Color.Blue;
                btnRegister.Enabled = true;
                tmCheckInfoLogin.Stop();
            }
        }

        public void removeText(object sender, EventArgs e)
        {
            tbEmail.Text = "";
            tbUser.Text = "";
            tbPassword.Text = "";
            tbConfirmPass.Text = "";
        }

        public void addText(object sender, EventArgs e)
        {
            if (tbEmail.Text.Length == 0)
            {
                tbEmail.Text = "trungtamgiasu@gmail.com";
            } if (String.IsNullOrWhiteSpace(tbEmail.Text))
            {
                tbUser.Text = "trungtamgiasu123";
            } if (String.IsNullOrWhiteSpace(tbEmail.Text))
            {
                tbPassword.Text = "password";
            } if (String.IsNullOrWhiteSpace(tbEmail.Text))
            {
                tbConfirmPass.Text = "password";
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                // LƯU THÔNG TIN ACCOUTN
                if (tbPassword.Text != tbConfirmPass.Text)
                {
                    lbExceptionPassword.Visible = true;
                    refreshTextBoxPassword();
                    return;
                };
                Locator.author.getAccount(userPermission, tbUser.Text, Locator.tutorController.hashPassWord(tbPassword.Text, tbUser.Text), tbEmail.Text, 0);
                Locator.tutorController.registerAccount(Locator.author);

                this.Hide();
                NhapThongTinGiaSu nhapThongTinGiaSu = new NhapThongTinGiaSu();
                nhapThongTinGiaSu.ShowDialog();
                this.Close();
            }
            catch
            {
                lbExceptionUserName.Visible = true;
                refreshTextBoxPassword();
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void checkInfoLogin_Tick(object sender, EventArgs e)
        {
            checkInfoTextBox();
        }
    }
}
